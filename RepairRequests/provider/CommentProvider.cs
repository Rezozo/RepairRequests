using Npgsql;
using RepairRequests.model;
using System.Collections.Generic;

namespace RepairRequests.provider
{
    public class CommentProvider
    {
        private NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=repair;User Id=postgres;Password=0987");

        public List<Comment> GetCommentsByRequest(int requestId)
        {
            connection.Open();
            var comments = new List<Comment>();
            var command = new NpgsqlCommand("SELECT c.id, c.description from requests_comment rc " +
                $"INNER JOIN comment c ON c.id = rc.comment_id WHERE rc.request_id = {requestId}", connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var comment = new Comment();
                comment.Id = reader.GetInt32(0);
                comment.Description = reader.GetString(1);
                comments.Add(comment);
            }
            reader.Close();
            connection.Close();

            return comments;
        }

        public void CreateCommentByRequest(int requestId, string description)
        {
            connection.Open();
            var command = new NpgsqlCommand($"Insert into comment Values (DEFAULT, '{description}') RETURNING id", connection);
            int commentId = (int)command.ExecuteScalar();

            var command2 = new NpgsqlCommand($"Insert into requests_comment VALUES ({requestId}, {commentId})", connection);
            command2.ExecuteNonQuery();

            connection.Close();
        }
    }
}
