namespace StudentManagement
{
    internal class Program
    {
        private static string firstName;
        private static string lastName;
       // DatabaseService db=new DatabaseService();

        static void Main(string[] args)
        {
            DatabaseService db = new DatabaseService();
            bool flag = true;

            while (flag)
            {
                Console.WriteLine("========================");
                Console.WriteLine("Choose any option below");
                Console.WriteLine("========================");
                Console.WriteLine("PRESS 1: ADD STUDENT");
                Console.WriteLine("PRESS 2: UPDATE STUDENT");
                Console.WriteLine("PRESS 3: DELETE STUDENT");
                Console.WriteLine("PRESS 4: GET ALL STUDENTS");
                Console.WriteLine("PRESS 5: GET STUDENTS BY ID");
                Console.WriteLine("PRESS 6: Exit");

                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                       
                        Console.WriteLine("Add Student");
                        Console.WriteLine("Enter First Name");
                        string FirstName= Console.ReadLine();
                        Console.WriteLine("Enter Last Name");
                        string LastName= Console.ReadLine();    
                        Student student=new Student();
                        student.FirstName = FirstName;
                        student.LastName = LastName;
                        //bool v = db.AddStudent(student);
                        db.AddStudent(student);
                        Console.WriteLine("Student Added Successfully");
                        break;

                    case 2:
                        Console.WriteLine("Update Student");
                        Console.WriteLine("Enter Id of student to be updated");
                        string input1= Console.ReadLine();
                        if(!int.TryParse(input1, out int id))
                        {
                            Console.WriteLine("error");
                            return;
                        }
                        Console.WriteLine("Enter First Name");
                         FirstName = Console.ReadLine();
                        Console.WriteLine("Enter Last Name");
                        LastName = Console.ReadLine();
                        Student student2 = new Student();
                        student2.FirstName = FirstName;
                        student2.LastName = LastName;
                      
                        
                        bool result= db.updateStudent(id, student2);
                        if (result)
                        {
                            Console.WriteLine("Student Updated Successfully");
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                        break; 
                    case 3:
                        Console.WriteLine("Delete Student");

                        Console.WriteLine("Enter Id of student to be deleted");
                        input1 = Console.ReadLine();
                        if (!int.TryParse(input1, out id))
                        {
                            Console.WriteLine("error");
                            return;
                        }
                     
                        Student student3 = new Student();
                        result = db.deleteStudent(id);
                        if (result)
                        {
                            Console.WriteLine("Student Deleted Successfully");
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }


                        break;
                    case 4:

                        Console.WriteLine("Students List");
                        var det = db.GetAllStudents();

                        foreach (var item in det)
                        {
                            Console.WriteLine($"ID: {item.Id}, FirstName: {item.FirstName}, LastName: {item.LastName}");
                        }



                        break;

                    case 5:
                        Console.WriteLine("Get Student By Id");
                        Console.WriteLine("Enter id");
                        input1 = Console.ReadLine();

                        if (!int.TryParse(input1, out id))
                        {
                            Console.WriteLine("Error: Invalid ID");
                            return;
                        }

                        det = db.getStudentById(id);
                        foreach (var item in det)
                        {
                            if (det != null)
                            {
                                Console.WriteLine($"FirstName: {item.FirstName}, LastName: {item.LastName}");
                            }
                            else
                            {
                                Console.WriteLine("Student not found");
                            }
                        }
                        
                        break;
                    case 6:
                        Console.WriteLine("Thank You");
                        Environment.Exit(0);
                        break;
                }

            }
        }
    }
}
