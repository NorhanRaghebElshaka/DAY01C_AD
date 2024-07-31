internal class Program
{
    private static void Main(string[] args)
    {
        #region Non-Generic SWAP
        //int A = 1, B = 2;
        //Console.WriteLine($"A = {A} , B = {B}");
        //Console.WriteLine("After swap");
        //Helper.SWAP( A,  B); // boxing
        //Console.WriteLine($"A = {A} , B = {B}");

        //double x = 2.2, y = 3.3;
        //Helper.SWAP( x,  y);

        //Console.WriteLine($"A = {x} , B = {y}");

        //Point p01 = new Point(1, 2);
        //Point p02 = new Point(2, 3);
        //Helper.SWAP( p01,  p02); 
        #endregion

        #region Generic SWAP
        //int A = 1, B = 2;
        //Console.WriteLine($"A = {A} , B = {B}");
        //Console.WriteLine("After swap");
        //Helper<int>.SWAP(A, B); // boxing
        //Console.WriteLine($"A = {A} , B = {B}");

        //double x = 2.2, y = 3.3;
        //Helper<double>.SWAP(x,y);

        //Console.WriteLine($"A = {x} , B = {y}");

        //Point p01 = new Point(1, 2);
        //Point p02 = new Point(2, 3);
        //Helper<Point>.SWAP(p01, p02); 
        #endregion

        #region Generic Search

        //int[] numbers = { 9, 1, 2, 5, 7, 12, 5, 9 };
        //int index = Helper<object>.SearchArray(numbers , 12);

        //Console.WriteLine(index);


        //Employee emp01 = new Employee()
        //{
        //    Id = 1,
        //    Name = "omar"
        //};

        //Employee emp02 = new Employee()
        //{
        //    Id = 2,
        //    Name = "Ahmed"
        //};

        ////Employee emp03; // object 


        //Employee[] employees =
        //{
        //    emp01 , emp02
        //};


        //int index = Helper<Employee>.SearchArray(employees, new Employee() { Id = 2, Name = "Ahmed" });

        //Console.WriteLine(index);
        ////if(emp01 == emp02)
        ////    Console.WriteLine("Equal");
        ////else
        ////    Console.WriteLine("Not equal");


        #endregion

        #region Equality
        //Employee emp01 = new Employee()
        //{
        //    Id = 1,
        //    Name = "omar"
        //};

        //Employee emp02 = new Employee()
        //{
        //    Id = 1,
        //    Name = "omar"
        //};

        //Console.WriteLine(emp01.GetHashCode());
        //Console.WriteLine(emp02.GetHashCode());

        //if (emp01.Equals(emp02))
        //    Console.WriteLine("Equal");
        //else
        //    Console.WriteLine("Not equal"); 
        #endregion

        #region Bubble Sort
        //Employee[] employees =
        //{
        //    new Employee (){Id = 10 , Name = "omar"},
        //    new Employee (){Id = 30 ,Name = "Ahmed"},
        //    new Employee (){Id = 20 ,Name = "mona"}
        //};
        //Helper<Employee>.BubbleSort(employees);

        //foreach (Employee employee in employees)
        //{
        //    Console.WriteLine(employee);
        //} 
        #endregion

        #region Non-Generic IComparable vs Generic IComparable
        //Point[] points =
        //  {
        //    new Point(1,2),
        //    new Point(4,4),
        //    new Point(2,5),
        //};
        //
        //Helper<Point>.BubbleSort(points);
        //
        //foreach (Point point in points)
        //{
        //    Console.WriteLine(point);
        //}

        #endregion

    }
}
    