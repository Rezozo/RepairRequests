using Npgsql;
using RepairRequests.model;
using System;
using System.Collections.Generic;

namespace RepairRequests.provider
{
    public class ReportProvider
    {
        private NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=repair;User Id=postgres;Password=0987");
        private RequestProvider requestProvider = new RequestProvider();

        public List<Report> GetAllReports()
        {
            List<Report> result = new List<Report>();
            connection.Open();
            var command = new NpgsqlCommand("SELECT id, datefrom, dateto, description, request_id FROM reports", connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var report = new Report();
                report.Id = reader.GetInt32(0);
                report.DateFrom = reader.GetDateTime(1);
                report.DateTo = reader.GetDateTime(2);
                report.Description = reader.GetString(3);
                Request newRequest = new Request();
                newRequest.Id = reader.GetInt32(4);
                report.request = newRequest;
                result.Add(report);
            }
            connection.Close();

            foreach (Report report1 in result)
            {
                var fullRequest = requestProvider.GetFullInfoById(report1.request.Id);
                report1.request = fullRequest;
            }

            return result;
        }

        public void CreateReport(int requestId, string description)
        {
            Request request = requestProvider.GetFullInfoById(requestId);

            connection.Open();
            var command = new NpgsqlCommand($"INSERT INTO reports VALUES (DEFAULT, '{request.CreationDate}', '{DateTime.Now}', '{description}', {requestId})", connection);
            command.ExecuteNonQuery();
            connection.Close();

            requestProvider.CloseRequest(requestId);
        }
    }
}
