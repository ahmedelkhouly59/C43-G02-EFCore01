using EFCORE_1.DbContexts;
using EFCORE_1.Models;

namespace EFCORE_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (ITIDbContext dbContext = new ITIDbContext()) {

                //JUST TEST TO CHECK IF IT IS CORRECT CODE OR NO
                var student = new Student
                {
                    FName = "John",
                    LName = "Doe",
                    Address = "123 Main St",
                    Age = 22,
                    Dep_Id = 1
                };
                dbContext.Students.Add(student);
                dbContext.SaveChanges();
            }
        }
    }
}
