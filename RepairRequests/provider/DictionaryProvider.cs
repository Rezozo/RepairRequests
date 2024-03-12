using Npgsql;
using System.Collections.Generic;

namespace RepairRequests.provider
{
    public class DictionaryProvider
    {
        private NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=repair;User Id=postgres;Password=0987");

        public List<string> GetAllRepairTypes()
        {
            connection.Open();
            List<string> result = new List<string>();

            var command = new NpgsqlCommand("SELECT title FROM type_of_repair", connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                result.Add(reader.GetString(0));
            }
            reader.Close();
            connection.Close();
            return result;
        }

        public int GetRepairTypeIdByName(string title)
        {
            connection.Open();
            int typeId = 0;
            var command = new NpgsqlCommand($"SELECT id FROM type_of_repair where title = '{title}'", connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                typeId = reader.GetInt32(0);
            }
            reader.Close();
            connection.Close();
            return typeId;
        }

        public List<string> GetAllStatuses()
        {
            connection.Open();
            List<string> result = new List<string>();

            var command = new NpgsqlCommand("SELECT title FROM status", connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                result.Add(reader.GetString(0));
            }
            reader.Close();
            connection.Close();
            return result;
        }

        public int GetStatusIdByName(string title)
        {
            connection.Open();
            int statusId = 0;
            var command = new NpgsqlCommand($"SELECT id FROM status where title = '{title}'", connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                statusId = reader.GetInt32(0);
            }
            reader.Close();
            connection.Close();
            return statusId;
        }

        public List<string> GetAllPriority()
        {
            connection.Open();
            List<string> result = new List<string>();

            var command = new NpgsqlCommand("SELECT title FROM priority", connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                result.Add(reader.GetString(0));
            }
            reader.Close();
            connection.Close();
            return result;
        }

        public int GetPriorityByName(string title)
        {
            connection.Open();
            int priorityId = 0;
            var command = new NpgsqlCommand($"SELECT id FROM priority where title = '{title}'", connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                priorityId = reader.GetInt32(0);
            }
            reader.Close();
            connection.Close();
            return priorityId;
        }

    }
}
