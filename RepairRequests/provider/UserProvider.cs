using Npgsql;
using RepairRequests.model;
using System.Collections.Generic;

namespace RepairRequests.provider
{
    public class UserProvider
    {
        private NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=repair;User Id=postgres;Password=0987");

        public User isValidUser(string username, string password)
        {
            connection.Open();
            var command = new NpgsqlCommand("Select u.full_name, u.phone_number, u.login, r.title, u.id from users u INNER JOIN role r ON r.id = u.role_id" +
                " where login=@username and password=@password", connection);
            command.Parameters.AddWithValue("username", username);
            command.Parameters.AddWithValue("password", password);
            var reader = command.ExecuteReader();
            if (reader.Read())
            {
                User user = new User();
                user.Name = reader.GetString(0);
                user.PhoneNumber = reader.GetString(1);
                user.Login = reader.GetString(2);
                user.Role = reader.GetString(3);
                user.Id = reader.GetInt32(4);
                connection.Close();
                reader.Close();
                return user;
            }
            else
            {
                connection.Close();
                reader.Close();
                return null;
            }
        }

        public List<User> GetAllUsers()
        {
            List<User> allUsers = new List<User>();
            connection.Open();
            var command = new NpgsqlCommand("SELECT id, login, password, role_id, full_name, phone_number FROM users", connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var user = new User();
                user.Id = (int)reader[0];
                user.Login = (string)reader[1];
                user.Password = (string)reader[2];
                switch ((int)reader[3])
                {
                    case 1:
                        user.Role = "Администратор";
                        break;
                    case 2:
                        user.Role = "Исполнитель";
                        break;
                    case 3:
                        user.Role = "Менеджер";
                        break;
                    case 4:
                        user.Role = "Клиент";
                        break;
                }

                allUsers.Add(user);
            }
            reader.Close();
            connection.Close();
            return allUsers;
        }

        public User GetUserById(int id)
        {
            connection.Open();
            var command = new NpgsqlCommand($"SELECT full_name, phone_number FROM users WHERE id = {id}", connection);
            var reader = command.ExecuteReader();
            User user = new User();
            if (reader.Read())
            {
                user.Name = (string)reader[0];
                user.PhoneNumber = (string)reader[1];
            }
            reader.Close();
            connection.Close();
            return user;
        }

        public List<User> GetAllExecutorsByRequest(int request)
        {
            List<User> allUsers = new List<User>();
            connection.Open();
            var command = new NpgsqlCommand("SELECT u.id, u.full_name, u.phone_number FROM request_executors re " +
                $"INNER JOIN users u ON u.id = re.executor_id WHERE re.request_id = {request}", connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var user = new User();
                user.Id = (int)reader[0];
                user.Name = (string)reader[1];
                user.PhoneNumber = (string)reader[2];

                allUsers.Add(user);
            }
            reader.Close();
            connection.Close();
            return allUsers;
        }

        public void SetExecutor(int requestId, string name)
        {
            int executorId = GetExecutorByFullName(name);

            if (!ExecutorExists(requestId, executorId))
            {
                connection.Open();
                var command = new NpgsqlCommand($"INSERT INTO request_executors VALUES ({requestId}, {executorId}) ", connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        private bool ExecutorExists(int requestId, int executorId)
        {
            connection.Open();
            var command = new NpgsqlCommand($"SELECT COUNT(*) FROM request_executors WHERE request_id = {requestId} AND executor_id = {executorId}", connection);
            long count = (long)command.ExecuteScalar();
            connection.Close();

            return count > 0;
        }


        public void DeleteExecutor(int requestId, string name)
        {
            int executorId = GetExecutorByFullName(name);

            connection.Open();
            var command = new NpgsqlCommand($"DELETE FROM request_executors WHERE request_id = {requestId} AND executor_id = {executorId} ", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public List<string> GetAllExecutors()
        {
            List<string> executors = new List<string>();
            connection.Open();
            var command = new NpgsqlCommand("SELECT full_name FROM users WHERE role_id = 2", connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                executors.Add(reader.GetString(0));
            }
            reader.Close();
            connection.Close();
            return executors;
        }

        public int GetExecutorByFullName(string name)
        {
            connection.Open();
            var command = new NpgsqlCommand($"SELECT id FROM users WHERE full_name = '{name}'", connection);
            var reader = command.ExecuteReader();
            int executor = 0;
            while (reader.Read())
            {
                executor = reader.GetInt32(0);
            }
            reader.Close();
            connection.Close();
            return executor;
        }

        public void CreateUser(User user)
        {
            connection.Open();

            int roleId = 1;

            switch (user.Role)
            {
                case "Администратор":
                    roleId = 1;
                    break;
                case "Исполнитель":
                    roleId = 2;
                    break;
                case "Менеджер":
                    roleId = 3;
                    break;
                case "Клиент":
                    roleId = 4;
                    break;
            }

            var command = new NpgsqlCommand($"INSERT INTO users VALUES (DEFAULT, '{user.Name}', '{user.PhoneNumber}', '{user.Login}', '{user.Password}', " +
                $"'{roleId}')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void DeleteUser(int userId)
        {
            connection.Open();
            var command = new NpgsqlCommand($"DELETE FROM users WHERE id = {userId}", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

    }
}
