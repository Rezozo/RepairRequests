using Npgsql;
using RepairRequests.model;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace RepairRequests.provider
{
    public class RequestProvider
    {
        private NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=repair;User Id=postgres;Password=0987");
        private DictionaryProvider dictionaryProvider = new DictionaryProvider();
        private UserProvider userProvider = new UserProvider();
        private DetailProvider detailProvider = new DetailProvider();
        private CommentProvider commentProvider = new CommentProvider();

        public Request GetFullInfoById(int requestId)
        {
            Request request = new Request();

            connection.Open();
            var mainCommand = new NpgsqlCommand($"SELECT r.id, r.creation_date, r.planned_date, r.equipment, r.description, s.title, p.title, " +
                $" r.sender_id, r.executor_id, tor.title FROM requests r INNER JOIN status s ON s.id = r.status_id " +
                $"INNER JOIN priority p ON p.id = r.priority_id INNER JOIN type_of_repair tor ON tor.id = r.repair_id " +
                $"WHERE r.id = {requestId}", connection);
            var reader = mainCommand.ExecuteReader();

            int senderId = 0;
            int executorId = 0;
            if (reader.Read())
            {
                request.Id = reader.GetInt32(0);
                request.CreationDate = reader.GetDateTime(1);
                request.EndDate = reader.GetDateTime(2);
                request.Equipment = reader.GetString(3);
                request.Description = reader.GetString(4);
                request.Status = reader.GetString(5);
                request.Priority = reader.GetString(6);
                senderId = reader.GetInt32(7);
                executorId = reader.GetInt32(8);
                request.TypeOfRepair = reader.GetString(9);
            }
            reader.Close();
            connection.Close();

            request.Sender = userProvider.GetUserById(senderId);
            request.Executor = userProvider.GetUserById(executorId);

            request.Helper = userProvider.GetAllExecutorsByRequest(requestId);
            request.Details = detailProvider.GetByRequest(requestId);
            request.Comments = commentProvider.GetCommentsByRequest(requestId);

            return request;
        }

        public List<ShortRequest> GetAllRequests()
        {
            List<ShortRequest> shortRequests = new List<ShortRequest>();

            connection.Open();
            var command = new NpgsqlCommand("SELECT r.id, r.creation_date, r.equipment, tor.title, r.description, s.title, r.planned_date, r.sender_id FROM requests r " +
                "INNER JOIN status s ON s.id = r.status_id " +
                "INNER JOIN type_of_repair tor ON tor.id = r.repair_id;", connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                ShortRequest shortRequest = new ShortRequest();
                shortRequest.Id = reader.GetInt32(0);
                shortRequest.CreationDate = reader.GetDateTime(1);
                shortRequest.Equipment = reader.GetString(2);
                shortRequest.TypeOfRepair = reader.GetString(3);
                shortRequest.Description = reader.GetString(4);
                shortRequest.Status = reader.GetString(5);
                if (!reader.IsDBNull(6))
                {
                    shortRequest.EndDate = reader.GetDateTime(6);
                }
                shortRequest.SenderId = reader.GetInt32(7);
                shortRequests.Add(shortRequest);
            }
            reader.Close();
            connection.Close();

            return shortRequests;
        }

        public List<ShortRequest> GetAllRequestsByUser(int userId)
        {
            List<ShortRequest> shortRequests = new List<ShortRequest>();

            connection.Open();
            var command = new NpgsqlCommand("SELECT r.id, r.creation_date, r.equipment, tor.title, r.description, s.title, r.planned_date FROM requests r " +
                "INNER JOIN status s ON s.id = r.status_id " +
                $"INNER JOIN type_of_repair tor ON tor.id = r.repair_id WHERE r.sender_id = {userId}", connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                ShortRequest shortRequest = new ShortRequest();
                shortRequest.Id = reader.GetInt32(0);
                shortRequest.CreationDate = reader.GetDateTime(1);
                shortRequest.Equipment = reader.GetString(2);
                shortRequest.TypeOfRepair = reader.GetString(3);
                shortRequest.Description = reader.GetString(4);
                shortRequest.Status = reader.GetString(5);
                if (!reader.IsDBNull(6))
                {
                    shortRequest.EndDate = reader.GetDateTime(6);
                }
                shortRequests.Add(shortRequest);
            }
            reader.Close();
            connection.Close();

            return shortRequests;
        }

        public List<ShortRequest> GetAllRequestsByExecutor(int userId)
        {
            List<ShortRequest> shortRequests = new List<ShortRequest>();

            connection.Open();
            var command = new NpgsqlCommand("SELECT r.id, r.creation_date, r.equipment, tor.title, r.description, s.title, r.planned_date FROM requests r " +
                "INNER JOIN status s ON s.id = r.status_id " +
                $"INNER JOIN type_of_repair tor ON tor.id = r.repair_id WHERE r.executor_id = {userId} AND r.status_id != 3", connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                ShortRequest shortRequest = new ShortRequest();
                shortRequest.Id = reader.GetInt32(0);
                shortRequest.CreationDate = reader.GetDateTime(1);
                shortRequest.Equipment = reader.GetString(2);
                shortRequest.TypeOfRepair = reader.GetString(3);
                shortRequest.Description = reader.GetString(4);
                shortRequest.Status = reader.GetString(5);
                if (!reader.IsDBNull(6))
                {
                    shortRequest.EndDate = reader.GetDateTime(6);
                }
                shortRequests.Add(shortRequest);
            }
            reader.Close();
            connection.Close();

            return shortRequests;
        }

        public void SaveRequest(string equipment, string description, string typeOfRequipment, int userId)
        {
            int typeId = dictionaryProvider.GetRepairTypeIdByName(typeOfRequipment);

            connection.Open();
            var command = new NpgsqlCommand($"INSERT INTO requests VALUES (DEFAULT, '{DateTime.Now}', '{equipment}', {typeId}, '{description}', " +
                $"{userId}, null, 1, null, null)", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void RegistrationRequest(int requestId, string executor, string priority, DateTime date)
        {
            int executorId = userProvider.GetExecutorByFullName(executor);
            int priorityId = dictionaryProvider.GetPriorityByName(priority);

            connection.Open();
            var command = new NpgsqlCommand($"UPDATE requests SET executor_id = {executorId}, status_id = 2, priority_id = {priorityId}, planned_date = '{date}' " +
                $"WHERE id = {requestId}", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void DeleteById(int requestId)
        {
            connection.Open();
            var command = new NpgsqlCommand($"DELETE FROM requests WHERE id = {requestId}" , connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void UpdateShortRequest(int requestId, string equipment, string description, string typeOfRequipment)
        {
            int typeId = dictionaryProvider.GetRepairTypeIdByName(typeOfRequipment);

            connection.Open();
            var command = new NpgsqlCommand($"UPDATE requests SET equipment='{equipment}', description='{description}', repair_id={typeId} " +
                $"WHERE id = {requestId}", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void UpdateEndData(int requestId, DateTime endTime)
        {
            connection.Open();
            var command = new NpgsqlCommand($"UPDATE requests SET planned_date = '{endTime}' " +
                $"WHERE id = {requestId}", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void CloseRequest(int requestId)
        {
            connection.Open();
            var command = new NpgsqlCommand($"UPDATE requests SET status_id = 3 " +
                $"WHERE id = {requestId}", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
