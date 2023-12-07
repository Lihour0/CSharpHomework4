namespace Homework4
{
    internal class Emp
    {
        private int empId;
        private string empName;
        private string empGender;
        private string empBOD;
        private string empAddress;
        private string empTel;
        public Emp() { }

        public Emp(int id, string name, string gender, string bod, string address, string tel)
        {
            empId = id;
            empName = name;
            empGender = gender;
            empBOD = bod;
            empAddress = address;
            empTel = tel;
        }

        public int EmpId
        {
            get { return empId; }
            set { empId = value; }
        }

        public string EmpName
        {
            get { return empName; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value");
                empName = value;
            }
        }

        public string EmpGender
        {
            get { return empGender; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value");
                empGender = value;
            }
        }

        public string EmpBOD
        {
            get { return empBOD; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value");
                empBOD = value;
            }
        }

        public string EmpAddress
        {
            get { return empAddress; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value");
                empAddress = value;
            }
        }

        public string EmpTel
        {
            get { return empTel; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value");
                empTel = value;
            }
        }




        public void ShowInfo()
        {
            Console.WriteLine($"Employee ID: {EmpId}");
            Console.WriteLine($"Employee Name: {EmpName}");
            Console.WriteLine($"Employee Gender: {EmpGender}");
            Console.WriteLine($"Employee Date of Birth: {EmpBOD}");
            Console.WriteLine($"Employee Address: {EmpAddress}");
            Console.WriteLine($"Employee Telephone: {EmpTel}");
        }
    }
}
