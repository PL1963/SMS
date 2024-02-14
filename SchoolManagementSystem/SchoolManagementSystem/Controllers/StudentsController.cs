using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.DbContexts;
using SchoolManagementSystem.Models.StdentModel;
using SchoolManagementSystem.Models.ViewModel;

namespace SchoolManagementSystem.Controllers
{
    public class StudentsController : Controller
    {
        private readonly ApplicationDbContext _studentViewModel;
        public StudentsController(ApplicationDbContext dbContext ) 
        {
        this._studentViewModel = dbContext;
        }
        [HttpGet]
        public IActionResult Registration()
        {
            return View();
        }

        
        public IActionResult StudentLogin()
        {
            return View();
        }


        [HttpPost]
        public IActionResult StudentLogin(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = _studentViewModel.LoginCredentials
                    .FirstOrDefault(u => u.UserName == loginViewModel.UserName && u.Password == loginViewModel.Password);

                if (user != null)
                {
                    
                    return RedirectToAction("Registration"); // Redirect to a Registration page
                }
             
            }

            return View(loginViewModel);
        }      
    

        [HttpPost]
        public async Task<IActionResult> Registration(AddStudentViewModel addStudentViewModel)
        {
            var student = new Student
            {
                FirstName = addStudentViewModel.FirstName,
                LastName = addStudentViewModel.LastName,
                Age = addStudentViewModel.Age,
                DateOfBirth = addStudentViewModel.DateOfBirth,
                Gender = addStudentViewModel.Gender,
                PhoneNumber = addStudentViewModel.PhoneNumber,
                Email = addStudentViewModel.Email,

                CourseName = addStudentViewModel.CourseName,
                YearOfPassing = addStudentViewModel.YearOfPassing,
                UniversityName = addStudentViewModel.UniversityName,
                Percentage = addStudentViewModel.Percentage,
            };
            await _studentViewModel.Students.AddAsync(student);
            await _studentViewModel.SaveChangesAsync();

            return View();
        }

    }
}
