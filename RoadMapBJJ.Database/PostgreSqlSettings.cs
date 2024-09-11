using System.ComponentModel.DataAnnotations;
using Npgsql;

namespace RoadMapBJJ.Database
{
    public class PostgreSqlSettings
    {

        [Required]
        public string Host { get; set; } = null!;


        [Required]
        public int Port { get; set; } = 5432;


        [Required]
        public string Database { get; set; } = null!;

        [Required]
        public string Username { get; set; } = null!;
        
        [Required]
        public string Password { get; set; } = null!;
        

        public string BuildConnectionString()
        {
            var builder = new NpgsqlConnectionStringBuilder
            {
                Host = Host,
                Port = Port,
                Database = Database,
                Username = Username,
                Password = Password,
                IncludeErrorDetail = true,
            };

            return builder.ConnectionString;
        }
    }
}
