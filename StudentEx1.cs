using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int i;

            string[] name = new string[n];
            int[] grade1 = new int[n];
            int[] grade2 = new int[n];
            decimal[] average = new decimal[n];
            decimal max = 0;
            decimal[] averageCopy = new decimal[n];

            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Pleae enter values of student {0}", i);
;                
                string[] values = Console.ReadLine().Split(' ');


                name[i] = values[0];
                grade1[i] = Convert.ToInt32(values[1]);
                grade2[i] = Convert.ToInt32(values[2]);


                error1:
                if (name[i].Length > 15 )
                {
                    Console.WriteLine("Please re-enter the name! Must be 15 chars or less");
                    name[i] = Console.ReadLine();
                    goto error1;
                    
                }
                


                error2:
                if (grade1[i] < 0 || 100 < grade1[i])
                {
                    Console.WriteLine("Enter grade1 between 0 and 100");
                    grade1[i] = Convert.ToInt32(Console.ReadLine());
                    goto error2;
                    
                }
                

                error3:
                if (grade2[i] < 0 || 100 < grade2[i])
                {
                    Console.WriteLine("Enter grade2 between 0 and 100");
                    grade2[i] = Convert.ToInt32(Console.ReadLine());
                    goto error3;
                }


                average[i] = (grade1[i] + grade2[i]) / 2;

                if (max < average[i])
                {
                    max = average[i];
                }
            }

            //Print 3 top max values
            average.CopyTo(averageCopy, 0);
            Array.Sort(averageCopy);

            int numberOfMax = 3;

            for (i = n - numberOfMax; i < n; i++)
            {
                
                    for (int j = 0; j < n; j++)
                {
                    if (averageCopy[i] == average[j])
                    {


                        Console.WriteLine($"{name[j]} {average[j]}");
                        break;
                    }
                }


            }
        }
    }
}

/*
 * class Student
{
    private string name;
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            if (name.Length <= 15)
            {
                name = value;
            }
            else
            {
                Console.WriteLine("Name length is bigger than 15, please re-run the program");
            }
        }
    }

    public int grade1;
    public int Grade1
    {
        get
        {
            return grade1;
        }
        set
        {
            if (grade1 >= 0 && grade1 <= 100)
            {
                grade1 = value;
            }
            else
            {
                Console.WriteLine("The grade entered isn't between 0 and 100, please re-run the program");
            }
        }
    }

    public int grade2;
    public int Grade2
    {
        get
        {
            return grade2;
        }
        set
        {
            if (grade2 >= 0 && grade2 <= 100)
            {
                grade2 = value;
            }
            else
            {
                Console.WriteLine("The grade entered isn't between 0 and 100, please re-run the program");
            }
        }
    }

    public double Average
    {
        get
        {
            return (grade1 + grade2) / 2;
        }
    }

    static void Main(string[] args)
    {
        //student1 input//
        Student student1 = new Student();

        string values1 = Console.ReadLine();
        student1.Name = values1.Split(' ')[0];
        student1.Grade1 = Convert.ToInt32(values1.Split(' ')[1]);
        student1.Grade2 = Convert.ToInt32(values1.Split(' ')[2]);
        Console.Write($"The average of student 1 is {student1.Average}");
    }

}//




/*using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();

            string[] values = Console.ReadLine().Split(' ');

            student1.Name = values[0];

            student1.Grade1 = Convert.ToInt32(values[1]);

            student1.Grade2 = Convert.ToInt32(values[2]);

            Console.Write($"The average of student 1 is {student1.Average}");
        }
    }

    public class Student
    {
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                if (value.Length <= 15)
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Name length is bigger than 15, please re-run the program");
                }
            }
        }

        public int _grade1;
        public int Grade1
        {
            get
            {
                return _grade1;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _grade1 = value;
                }
                else
                {
                    Console.WriteLine("The grade entered isn't between 0 and 100, please re-run the program");
                }
            }
        }

        private int _grade2;
        public int Grade2
        {
            get
            {
                return _grade2;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _grade2 = value;
                }
                else
                {
                    Console.WriteLine("The grade entered isn't between 0 and 100, please re-run the program");
                }
            }
        }

        public double Average => (Grade1 + Grade2) / 2;
    }
}*/