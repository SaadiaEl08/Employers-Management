namespace Employers_Management.Data
{
    public class Employer
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int ? Salaire { get; set; }
        public string ? PhotoPath { get; set; }
        public Gender Gender { get; set; }
        public Department Department { get; set; }

        public string toString()
        {
            return "rrrr";
        }


    }
}
