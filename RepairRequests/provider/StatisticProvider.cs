using Npgsql;
using RepairRequests.model;
using System;
using System.Collections.Generic;

namespace RepairRequests.provider
{
    public  class StatisticProvider
    {
        private NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=repair;User Id=postgres;Password=0987");

        public long GetTotalDone()
        {
            connection.Open();
            var command = new NpgsqlCommand($"SELECT COUNT(*) AS total_completed_requests FROM requests WHERE status_id = 3", connection);
            long count = (long) command.ExecuteScalar();
            connection.Close();

            return count;
        }

        public long GetCompleteTime()
        {
            connection.Open();
            var command = new NpgsqlCommand($"SELECT AVG(dateto - datefrom)::bigint AS average_completion_time FROM reports", connection);
            long count =(long)command.ExecuteScalar();
            connection.Close();

            return count;
        }

        public List<Statistic> GetStatistics()
        {
            var list = new List<Statistic>();
            connection.Open();
            var command = new NpgsqlCommand("SELECT tor.title, COUNT(*) AS total_requests " +
                "FROM requests r INNER JOIN type_of_repair tor ON r.repair_id = tor.id GROUP BY tor.title;", connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Statistic(reader.GetString(0), reader.GetInt64(1)));
            }
            reader.Close();
            connection.Close();
            return list;
        }


    }
}
