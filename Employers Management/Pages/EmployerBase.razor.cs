using Employers_Management.Data;
using Microsoft.AspNetCore.Components;
using System.Linq;

namespace Employers_Management.Pages
{
    public class EmployerBase:ComponentBase
    {
        protected static IEnumerable<Employer>? EmployersList { get; set; }
        protected Employer EmployerData { get; set; } = new Employer
        {
            Department = new Department()
        };
        protected override async Task OnInitializedAsync()
        {
            await Task.Run(LoadEmployers);
        }
        private void LoadEmployers()
        {
            System.Threading.Thread.Sleep(1000);
            EmployersList = new List<Employer> {
            new Employer{
            Id = 1,
            FirstName = "Hamid",
            LastName = "Longway",
            Gender = Gender.Male,
            Department = new Department { DepartmentId = 3, DepartmentName = "Payroll" },
            PhotoPath = "https://images.rawpixel.com/image_png_800/cHJpdmF0ZS9sci9pbWFnZXMvd2Vic2l0ZS8yMDI0LTExL3Jhd3BpeGVsX29mZmljZV8zMl9waG90b19wb3J0cmFpdF9zbWlsaW5nX2luZGlhbl9idXNpbmVzc19tYW5faV9kYzNmNjQxMi0yMTU3LTQ4MWQtOGEyNC05MTA2YmMxMjdhYzEtbTNwajlhbnQucG5n.png",
            Salaire=2000
        },
        new Employer
            {
                Id = 2,
                FirstName = "Sara",
                LastName = "Longway",
                Gender = Gender.Female,
                Department = new Department { DepartmentId = 3, DepartmentName = "Health" },
                PhotoPath = "https://images.rawpixel.com/image_png_800/cHJpdmF0ZS9sci9pbWFnZXMvd2Vic2l0ZS8yMDI0LTA4L3Jhd3BpeGVsX29mZmljZV8zNV9iZWF1dGlmdWxfc21pbGluZ195b3VuZ19pbmRpYW5fYnVzaW5lc3Nfd29tYV8yYWM3MjMyNS1jZmU3LTQ5ODgtODBkNi03YjViZTg3ODYzNjMucG5n.png",
                Salaire = 2000
            } };
        }

        protected void RemoveEmployer(int id)
        {
            EmployersList = EmployersList?.Where(employer => employer.Id != id).ToList();
        }

        protected  void AddEmployer()
        {
            EmployersList = EmployersList?.Append(EmployerData).ToList();
        }
        public void SetEmployerData(Employer employer)
        {
            EmployerData = employer;
        }

    }
}
