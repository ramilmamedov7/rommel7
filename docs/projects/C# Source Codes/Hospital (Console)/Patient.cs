using System;

namespace Hospital
{
    class Patient
    {
        string PatientName { set; get; }
        public Patient(string name)
        {
            this.PatientName = name;
        }
    }
}
