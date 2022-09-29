// See https://aka.ms/new-console-template for more information
using EmployeeCompositePattern;

Console.WriteLine("Hello, Employee Composite Pattern!");


Employee e1 = new Employee("Marcin");

Employee e2 = new Employee("Daniel");
Employee e3 = new Employee("Łukasz");

Employee e4 = new Employee("Stanisław");
Employee e5 = new Employee("Marek");
Employee e6 = new Employee("Bartłomiej");

Employee e7 = new Employee("Paweł");
Employee e8 = new Employee("Mateusz");
Employee e9 = new Employee("Maciej");

e1.addEmployee(e2);
e1.addEmployee(e3);

e2.addEmployee(e4);
e2.addEmployee(e5);
e2.addEmployee(e6);

e3.addEmployee(e7);
e3.addEmployee(e8);
e3.addEmployee(e9);

e1.doSomeWork(e1.Name);