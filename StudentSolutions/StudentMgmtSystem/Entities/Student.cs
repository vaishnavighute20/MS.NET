namespace StudentMgmtSystem.Entities
{
    public class Student
    {
      
      public int  Id {  get; set; }
        public string Name { get; set; }

        public string Email { get; set; }
        public int  MoNumber { get; set; }

        public string Address { get; set; }
        public string Date { get; set; }

        public double Fees { get; set; }
        public string Status { get; set; }

        public Student()
        {
            
        }

        public Student(int id, string name, string email, int number, string address, string date, double fees, string status)
        {
            this.Id = id;
            this.Name = name;
               this.Email = email;
            this.MoNumber = number;
            this.Address = address;
            this.Date = date;
            this.Fees = fees;
            this.Status = status;
            
        }
    }
}
