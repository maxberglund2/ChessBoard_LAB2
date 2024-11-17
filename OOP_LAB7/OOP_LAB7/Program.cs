namespace OOP_LAB7
{
    internal class Program
    {
        static void Divider(string title, int number)
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine(title);
            Console.WriteLine($"Items left in Stack = {number}");
        }
        static void Main(string[] args)
        {
            Employee employee = new Employee(1, "John Doe", "Male", 1000);
            Employee employee2 = new Employee(2, "Jane Doe", "Female", 500);
            Employee employee3 = new Employee(3, "Jack Doe", "Male", 2000);
            Employee employee4 = new Employee(4, "Jill Doe", "Female", 300);
            Employee employee5 = new Employee(5, "Jim Doe", "Male", 200);

            //stack 

            Stack<Employee> stack = new Stack<Employee>();
            stack.Push(employee);
            stack.Push(employee2);
            stack.Push(employee3);
            stack.Push(employee4);
            stack.Push(employee5);

            int AmoutOfEmployees = stack.Count;
            foreach (Employee emp in stack)
            {
                Console.WriteLine($"Items left in Stack = {AmoutOfEmployees}");
                Console.WriteLine(emp);
            }

            Divider("Retrive Using Pop Method", AmoutOfEmployees);

            while (stack.Count > 0)
            {
                Employee emp = stack.Pop();
                Console.WriteLine(emp);
                Console.WriteLine($"Items left in Stack = {stack.Count}");
            }
            stack.Push(employee);
            stack.Push(employee2);
            stack.Push(employee3);
            stack.Push(employee4);
            stack.Push(employee5);

            Divider("Retrive Using Peek Method", AmoutOfEmployees);
            for (int i = 0; i <= 1; i++)
            {
                Employee emp = stack.Peek();
                Console.WriteLine(emp);
                Console.WriteLine($"Items left in Stack = {stack.Count}");
            }

            //check if emp3 is in stack
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine(stack.Contains(employee3) ? "Emp3 is in stack" : "Emp3 is not in stack");

            // part 2
            Console.WriteLine("\n--------------------------------------------------");
            Console.WriteLine("Del 2 - List");
            Console.WriteLine("--------------------------------------------------");

            // list with 5 new employees
            List<Employee> list = new List<Employee>
            {
                new Employee(1, "Alice", "Female", 50000),
                new Employee(2, "Bob", "Male", 55000),
                new Employee(3, "Charlie", "Male", 60000),
                new Employee(4, "Diana", "Female", 65000),
                new Employee(5, "Eve", "Female", 70000)
            };

            var employeeToCheck = new Employee(2, "Bob", "Male", 55000);
            var employeeToCheck2 = new Employee(6, "Frank", "Male", 75000);
            list.Add(employeeToCheck2);

            Console.WriteLine(list.Contains(employeeToCheck)? "Employee2 object exists in the list" : "Employee2 object does not exist in the list");
            Console.WriteLine(list.Contains(employeeToCheck2) ? "Employee6 object exists in the list" : "Employee6 object does not exist in the list");


            Console.WriteLine("\n" + list.Find(emp => emp.Gender == "Male") + "\n");

            // find all employees that are male

            List<Employee> maleEmployees = list.FindAll(emp => emp.Gender == "Male");
            foreach (Employee emp in maleEmployees)
            {
                Console.WriteLine(emp);
            }
        }
    }
}