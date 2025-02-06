namespace linqTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employees = new List<Employee>();
            employees.Add(new Employee(220, "Essam", 3000));
            employees.Add(new Employee(220, "ali", 3000));
            employees.Add(new Employee(3, "Shreen", 4000));
            employees.Add(new Employee(7, "Mohamed", 5000));
            employees.Add(new Employee(9, "Ahmed", 7000));
            employees.Add(new Employee(12, "Alaa", 6000));
            employees.Add(new Employee(20, "Fatma", 7000));
            employees.Add(new Employee(11100, "Hala", 3000));
            employees.Add(new Employee(120, "Mahmoud", 10000));
            employees.Add(new Employee(200, "Anwer", 50000));



            //var result = employees.CustomWhere(a => a.Id > 5);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Id + " -  " + item.Name);
            //}

            //var result1 = employees.CustomWhereWithIndex ((emp, Index) => emp.Id > 5 && emp.Name.Contains('a') && Index > 4 && Index < 6);
            //foreach (var item in result1)
            //{
            //    Console.WriteLine(item.Id + " -  " + item.Name);
            //}

            //var lst = new List<int> {1,2,3,4,5,6,7 };

            //var result =from x in lst where x>5 select x;

            //foreach (var item in result) 
            //{
            //    Console.WriteLine(item);
            //}


            //var result2 = employees.Where(emp => emp.Id > 5).CustomSelect(a=>a.Name);

            //foreach (var emp in result2)
            //{
            //    Console.WriteLine(emp);
            //}


            List<int> lst = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13];

            var result = lst.CustomSkip(5);

            var result11 = lst.CTakeLast(5);


            foreach (int i in result11)
            {
                Console.WriteLine(i);
            }






        }



    }
}
