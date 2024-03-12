using Npgsql;
using RepairRequests.model;
using System.Collections.Generic;

namespace RepairRequests.provider
{
    public class DetailProvider
    {
        private NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=repair;User Id=postgres;Password=0987");

        public List<Details> GetByRequest(int requestId)
        {
            List<Details> list = new List<Details>();
            connection.Open();
            var command = new NpgsqlCommand($"SELECT d.id, d.title, d.cost, rd.count FROM requests_details rd " +
                $"INNER JOIN details d ON d.id = rd.detail_id WHERE rd.request_id = {requestId}", connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                Details details = new Details();
                details.Id = reader.GetInt32(0);
                details.Title = reader.GetString(1);
                details.Cost = (decimal)reader["cost"];
                details.Count = reader.GetInt32(3);
                list.Add(details);
            }
            connection.Close();
            return list;
        }

        public void CreateDetail(int requestId, string title, decimal cost, string count)
        {
            connection.Open();
            var command = new NpgsqlCommand($"Insert into details VALUES (DEFAULT, '{title}', '{cost}') RETURNING id", connection);
            int detailId = (int) command.ExecuteScalar();

            var command2 = new NpgsqlCommand($"Insert into requests_details VALUES ({requestId}, {detailId}, {count})", connection);
            command2.ExecuteNonQuery();

            connection.Close();
        }

        public void DeleteDetail(int detailId)
        {
            connection.Open();
            var command = new NpgsqlCommand($"DELETE FROM requests_details WHERE detailId = {detailId}", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
