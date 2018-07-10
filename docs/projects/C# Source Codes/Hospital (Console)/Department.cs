using System;
using System.Collections.Generic;

namespace Hospital
{
    class Department
    {
        public string name;
        List<Doctor> doctors = new List<Doctor>();
        List<Department> departments = new List<Department>();

        public void AddDepartments()
        {
            departments.Add(new Department("1.Cardiology"));
            departments.Add(new Department("2.Oncology"));
            departments.Add(new Department("3.Physiotherapy"));
            departments.Add(new Department("4.Urology"));
            departments.Add(new Department("5.Gynecology"));

        }
        public void ShowDepartments()
        {
            foreach (var department in departments)
            {
                Console.WriteLine(department.name);
            }
        }

        public void AddDoctors(string chooseShobe)
        {
            if (chooseShobe == "1")
            {
                doctors.Add(new Doctor("1.Lala Memmedova"));
                doctors.Add(new Doctor("2.Ramil Memmedov"));
            }
            else if (chooseShobe == "2")
            {
                doctors.Add(new Doctor("1.Mark Zuckerberg"));
                doctors.Add(new Doctor("2.Filankes Filankesov"));
            }
            else if (chooseShobe == "3")
            {
                doctors.Add(new Doctor("1.Bill Gates"));
                doctors.Add(new Doctor("2.Hans Zimmer"));
            }
            else if (chooseShobe == "4")
            {
                doctors.Add(new Doctor("1.Chester Bannington"));
                doctors.Add(new Doctor("2.Dimebag Darrell"));
            }
            else if (chooseShobe == "5")
            {
                doctors.Add(new Doctor("1.Ehdim Qaqa"));
                doctors.Add(new Doctor("2.Cavidan Sudkolik"));
            }
            else
            {
                Console.WriteLine("Error 404");
            }
        }

        public void ShowDoctors()
        {
            foreach (var doc in doctors)
            {
                Console.WriteLine(doc.DoctorName);
            }
        }

        public Department(string name)
        {
            this.name = name;
        }
        public Department()
        {

        }
        public Department(string name, List<Doctor> doctors)
        {
            this.name = name;
            this.doctors = doctors;
        }
    }
}
