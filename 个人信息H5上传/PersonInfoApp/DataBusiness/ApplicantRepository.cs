using Dapper;
using MySqlConnector;
using System.Data;
using System.Threading.Tasks;
using PersonInfoApp.Models;
namespace PersonInfoApp.DataBusiness
{
    
    public class ApplicantRepository
    {
        private readonly string _connectionString;

        public ApplicantRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<bool> IsPhoneExistsAsync(string phone)
        {
            using (IDbConnection db = new MySqlConnection(_connectionString))
            {
                var sql = "SELECT COUNT(*) FROM Applicants WHERE Phone = @Phone";
                var count = await db.ExecuteScalarAsync<int>(sql, new { Phone = phone });
                return count > 0;
            }
        }

        public async Task<int> InsertApplicantAsync(Applicant applicant)
        {
            using (IDbConnection db = new MySqlConnection(_connectionString))
            {
                var sql = @"
                    INSERT INTO Applicants (Name, StageName,Sex, Age, Phone, City, Height, Weight, Bust, Waist, Hips, Occupation, WorkYears, Talents, CanDrink,Photos,Videos)
                    VALUES (@Name, @StageName,@Sex, @Age, @Phone, @City, @Height, @Weight, @Bust, @Waist, @Hips, @Occupation, @WorkYears, @Talents, @CanDrink,@Photos,@Videos);
                    SELECT LAST_INSERT_ID();
                ";
                return await db.ExecuteScalarAsync<int>(sql, applicant);
            }
        }

        public async Task<bool> IsApplicantExistsAsync(string name, string phone)
        {
            using (IDbConnection db = new MySqlConnection(_connectionString))
            {
                var sql = "SELECT COUNT(*) FROM Applicants WHERE Name = @Name AND Phone = @Phone";
                var count = await db.ExecuteScalarAsync<int>(sql, new { Name = name, Phone = phone });
                return count > 0;
            }
        }

        public async Task<List<Applicant>> GetAllApplicantsAsync()
        {
            using (IDbConnection db = new MySqlConnection(_connectionString))
            {
                var sql = "SELECT Id,Name,Age,Phone FROM Applicants";
                return (await db.QueryAsync<Applicant>(sql)).ToList();
            }
        }

        public async Task<Applicant> GetApplicantByIdAsync(int id)
        {
            using (IDbConnection db = new MySqlConnection(_connectionString))
            {
                var sql = "SELECT * FROM Applicants WHERE Id = @Id";
                return await db.QuerySingleOrDefaultAsync<Applicant>(sql, new { Id = id });
            }
        }
    }
}
