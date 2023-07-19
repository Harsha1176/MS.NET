using Project1.Models;

namespace Project1
{
    public class StudentUtils
    {
        public static List<StudentViewModel> studentList = new List<StudentViewModel>();
        public static List<StudentViewModel> GetStudentViews()
        {
            return studentList;
        }
        public static void AddStudent(StudentViewModel StudentView)
        {
            studentList.Add(StudentView);
        }
        public static StudentViewModel? GetStudent(int StudentId)
        {
            StudentViewModel? StudentViewModel = studentList.Where(x => x.StudentId == StudentId).FirstOrDefault();
            if (StudentViewModel != null)
            {
                return StudentViewModel;
            }
            else
            {
                return null;
            }

            //return userList;
        }
        public static void DeleteStudent(StudentViewModel StudentView)
        {
            StudentViewModel StudentViewModel = studentList.Where(x => x.StudentId == StudentView.StudentId).First();
            if (StudentViewModel != null)
            {
                studentList.Remove(StudentViewModel);
            }
        }
        public static void UpdateStudent(StudentViewModel StudentView)
        {
            StudentViewModel? StudentViewModel = studentList.Where(x => x.StudentId == StudentView.StudentId).FirstOrDefault();
            StudentViewModel.Studentname = StudentView.Studentname;
            StudentViewModel.Course = StudentView.Course;
            StudentViewModel.MobileNo = StudentView.MobileNo;
            StudentViewModel.City = StudentView.City;

        }
    }
}