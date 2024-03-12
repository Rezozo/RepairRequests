using Npgsql;
using RepairRequests.model;
using System.Collections.Generic;

namespace RepairRequests.provider
{
    public class NotificationProvider
    {
        private NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=repair;User Id=postgres;Password=0987");

        public List<Notification> GetAllNotificationByRequest(int userId)
        {
            List<Notification> result = new List<Notification>();

            connection.Open();
            var command = new NpgsqlCommand($"SELECT r.id, s.title FROM notifications n " +
                $"INNER JOIN requests r ON n.request_id = r.id " +
                $"INNER JOIN status s ON s.id = r.status_id " +
                $"WHERE r.sender_id = {userId}", connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                Notification notification = new Notification();
                notification.Id = reader.GetInt32(0);
                notification.Status = reader.GetString(1);
                result.Add(notification);
            }
            reader.Close();
            connection.Close();

            return result;
        }

        public void SaveNotification(int requestId)
        {
            connection.Open();
            var command = new NpgsqlCommand($"INSERT INTO notifications VALUES (DEFAULT, {requestId})", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void DeleteNotification(int requestId)
        {
            connection.Open();
            var command = new NpgsqlCommand($"DELETE FROM notifications WHERE request_id = {requestId}" , connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
