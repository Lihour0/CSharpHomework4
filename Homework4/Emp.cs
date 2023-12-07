namespace Homework4
{
    internal class Emp
    {
        private int EmpId;
        private string EmpName;
        private string EmpGender;
        private string EmpBOD;
        private string EmpAddress;
        private string EmpTel;
        public Emp() { };

        public Emp(int id, string name, string gender, string bod, string address, string tel)
        {
            EmpId = id;
            EmpName = name;
            EmpGender = gender;
            EmpBOD = bod;
            EmpAddress = address;
            EmpTel = tel;
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
