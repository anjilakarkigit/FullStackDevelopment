namespace ConsoleApp2.ObjectOrientedConcepts;
public class Course : ICourseService
{
        private List<Student> students;
        private string grade;
        public decimal Credits { get; set; }

        public Course()
        {
            students = new List<Student>();
        }

        public string Grade
        {
            get { return grade; }
            set
            {
                if (value != "A" && value != "B" && value != "C" && value != "D" && value != "F")
                {
                    throw new ArgumentException("Invalid grade.");
                }

                grade = value;
            }
        }
        

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public List<Student> GetEnrolledStudents()
        {
            return students;
        }
}
