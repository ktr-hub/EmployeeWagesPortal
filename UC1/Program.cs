using System;

namespace UC1
{
    class Program
    {
        Boolean attendanceCheck()
        {
            Random random = new Random();
            int checker = random.Next(0, 2);
            if (checker == 1)
                return true;
            return false;
        }
        static void Main(string[] args)
        {
            Program attendanceObject = new Program();
            if (attendanceObject.attendanceCheck())
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is not present");
            }
        }
    }
}
