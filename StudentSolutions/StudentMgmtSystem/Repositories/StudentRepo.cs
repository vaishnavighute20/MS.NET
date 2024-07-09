using MySql.Data.MySqlClient;
using StudentMgmtSystem.Entities;
namespace StudentMgmtSystem.Repositories
{
    public class StudentRepo:IstudentRepo
    {
        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
            string conString = @"server=localhost;port=3306;user=root; password=root; database=dotnet";
            MySqlConnection con = new MySqlConnection(conString);
            string Query = "select * from students";

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(Query, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = int.Parse(reader["Id"].ToString());
                    string title = reader["Name"].ToString();
                    string email = reader["Email"].ToString();
                    int number =int.Parse(reader["MoNumber"].ToString());
                    string Address = reader["Address"].ToString();
                    string date = reader["Date"].ToString();
                    double fees = double.Parse(reader["Fees"].ToString());
                    string desc = reader["Status"].ToString();

                    Student std = new Student();
                    std.Id = id;
                    std.Name = title;
                    std.Email = email;
                    std.MoNumber= number;
                    std.Address = Address;
                    std.Date = date;
                    std.Fees = fees;
                    std.Status = desc;

                    students.Add(std);


                }
                reader.Close();

            
            }
            catch (Exception ex) {
                throw ex;
            }

            finally
            {
                if (con.State != System.Data.ConnectionState.Closed)
                {
                    con.Close();
                }
            }


            return students;
        }
    }
}
