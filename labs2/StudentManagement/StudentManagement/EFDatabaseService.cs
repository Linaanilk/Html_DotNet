using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class EFDatabaseService
    {
        private MyDbContext _dbContext;

        public EFDatabaseService()
        {
            _dbContext = new MyDbContext();
        }

        public List<Student>GetAllStudents(Student student)
        {
            return _dbContext.Students.ToList();
        }
        public Student GetStudentById(int id) 
        {
            return _dbContext.Students.FirstOrDefault(stud=>stud.Id==id); 
        }
        public Student AddStudent(Student student) 
        {
        _dbContext.Students.Add(student);
            _dbContext.SaveChanges();
            return student;
        }
        public void DeleteStudent(int id)
        {
            Student saveStudent = _dbContext.Students.FirstOrDefault(std => std.Id == id);
            _dbContext.Students.Remove(saveStudent);
            _dbContext.SaveChanges();
           
        }
        public void UpdateStudent(int id,Student student) 
        {
            Student saveStudent=_dbContext.Students.FirstOrDefault(std=> std.Id==id);
            saveStudent.FirstName=student.FirstName;
            saveStudent.LastName=student.LastName;
            _dbContext.SaveChanges();
          
        }
    }
}
