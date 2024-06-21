using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;
using System.Windows.Input;
using System.Xml.Linq;

namespace StudentManagement
{
    public class DatabaseService
    {
        SqlConnection _connection;
        SqlCommand _command;
        SqlDataReader _reader;
        Student student;

        string connectionString = "server=SPCOKLAP-5536\\SQLEXPRESS;database=SampleDB;Trusted_Connection=yes";
        public bool AddStudent(Student student)
        {
            
            _connection = new SqlConnection(connectionString);
            _command = new SqlCommand();
            _command.Connection = _connection;
          
            _command.CommandText = "Insert into Student(FirstName,LastName) values (' " + student.FirstName + "',' " + student.LastName + " ')";
            _connection.Open();
            int row=_command.ExecuteNonQuery();
            _connection.Close();
            if(row>0) 
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool updateStudent(int id,Student student)
        {
            _connection = new SqlConnection(connectionString);
            _command = new SqlCommand();
            _command.Connection = _connection;

            _command.CommandText = "UPDATE Student SET FirstName = '" + student.FirstName + "', LastName = '" + student.LastName + "' WHERE Id = " + id;
            _connection.Open();
            int row = _command.ExecuteNonQuery();
            _connection.Close();
            if (row > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool deleteStudent(int id)
        {

            _connection = new SqlConnection(connectionString);
            _command = new SqlCommand();
            _command.Connection = _connection;

            _command.CommandText = "Delete Student WHERE Id = " + id;
            _connection.Open();
            int row = _command.ExecuteNonQuery();
            _connection.Close();
            if (row > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>();
            _connection = new SqlConnection(connectionString);
            _command = new SqlCommand();
            _connection.Open();

            _command.Connection = _connection;
            _command.CommandText = "select * from Student";
            _reader=_command.ExecuteReader();

            while(_reader.Read()) 
            {
            int id = Int32.Parse(_reader["Id"].ToString());
                string firstname = _reader["FirstName"].ToString();
                string lastname = _reader["LastName"].ToString();

                student = new Student();
                student.Id = id;
                student.FirstName=firstname;
                student.LastName=lastname;
                students.Add(student);
               /// return students;
              ///  Console.WriteLine($"ID: {id}, FirstName: {firstname}, LastName: {lastname}");


            }
            _connection.Close();
            return students;


        }
        public List<Student> getStudentById(int id)
        {

            List<Student> students = new List<Student>();
            _connection = new SqlConnection(connectionString);
            _command = new SqlCommand();
            _command.Connection = _connection;

            _command.CommandText = "Select * from Student WHERE Id = " + id;
            _connection.Open();
            int row = _command.ExecuteNonQuery();
             _reader=_command.ExecuteReader();
            while (_reader.Read())
            {
                
                string firstname = _reader["FirstName"].ToString();
                string lastname = _reader["LastName"].ToString();

                student = new Student();
                
                student.FirstName = firstname;
                student.LastName = lastname;
                students.Add(student);
                /// return students;
                ///  Console.WriteLine($"ID: {id}, FirstName: {firstname}, LastName: {lastname}");


            }
           
            return students;
            _connection.Close();


        }

        internal void getAllStudents()
        {
            throw new NotImplementedException();
        }
    }
}
