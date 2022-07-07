using System;

namespace IEXOOPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Implicit, Explicit
            //Manat manat = new Manat(200);
            //Dollar dollar = manat;

            //// Console.WriteLine(dollar.Usd);

            //string name = "14";
            ////Console.WriteLine(int.Parse(name).GetType());

            ////int age = 77;
            ////Console.WriteLine(age.ToString().GetType());

            ////DateTime date = DateTime.Now;
            ////var result = date.ToString("MM/dd/yyyy");
            ////Console.WriteLine(result);

            //var n = Convert.ToInt32(name);
            //Console.WriteLine(n);
            #endregion

            #region EXIMP
            //StringList stringList = new StringList();
            //stringList.Add("Mirsamir");
            //stringList.Add("Ramil");

            //stringList.GetAll();

            //IntList intList = new IntList();
            //intList.Add(5);
            //intList.Add(10);
            //intList.Add(100);

            //intList.GetAll();

            //Booklist bookList = new Booklist();

            //Book book1 = new Book
            //{
            //    Name = "Mayn Kampf",
            //    Author = "Hitler"
            //};
            //Book book2 = new Book
            //{
            //    Name = "7 Gozel",
            //    Author = "Nizami"
            //};

            //Book book3 = new Book
            //{
            //    Name = "Xosrov ve Sirin",
            //    Author = "Nizami"
            //};

            //bookList.Add(book1);
            //bookList.Add(book2);
            //bookList.Add(book3);

            //bookList.GetAll();


            //    DataList<string> stringList = new DataList<string>();

            //    stringList.Add("Sadiq");
            //    stringList.Add("Seid");
            //    stringList.Add("Aftandil");
            //    stringList.Add("Meqi");


            //    stringList.GetAll();

            //    DataList<int> intlist = new DataList<int>();
            //    intlist.Add(21);
            //    intlist.Add(31);
            //    intlist.Add(41);
            //    intlist.Add(51);


            //    intlist.GetAll();


            //    DataList<Book> booklist = new DataList<Book>();

            //    booklist.Add(new Book { Author = "Meqi", Name = "Qaslarin hezin sonu" });
            //    booklist.Add(new Book { Author = "Aftandil", Name = "Traktorumu nece temir edim" });

            //    booklist.GetAll();

            #endregion

            #region Operator Overloading
            //Employee employee = new Employee(31, "Resad");

            //Student student = new Student(23, "Elesger");

            //var result = employee > student;

            //Console.WriteLine(result);
            #endregion




            #region Generic
            //Employee<string> emp1 = new Employee<string>();

            //Employee<Person> emp2 = new Employee<Person>();

            //Employee<Test> emp4 = new Employee<Test>();

            //Employee<int> emp3 = new Employee<int>();
            //Employee<Person, Common> employee = new Employee<Person, Common>();
            #endregion
        }


        #region Implicit, Explicit
        //public class Dollar
        //{
        //    public double Usd { get; set; }

        //    public Dollar(double usd)
        //    {
        //        Usd = usd;
        //    }
        //}

        //public class Manat
        //{
        //    public double Azn { get; set; }

        //    public Manat(double azn)
        //    {
        //        Azn = azn;
        //    }

        //    public static implicit operator Dollar(Manat manat)
        //    {
        //        return new Dollar(manat.Azn / 1.7);
        //    }



        //}
        #endregion

    }
    #region Operator Overloading
    //public class Student
    //{
    //    public string Name { get; set; }
    //    public int Age { get; set; }

    //    public Student(int age, string name)
    //    {
    //        Name = name;
    //        Age = age;
    //    }
    //}


    //public class Employee
    //{
    //    public string Name { get; set; }
    //    public int Age { get; set; }

    //    public Employee(int age, string name)
    //    {
    //        Name = name;
    //        Age = age;
    //    }

    //    public static bool operator > (Employee employee, Student student)
    //    {
    //        return employee.Age > student.Age;

    //    }

    //    public static bool operator < (Employee employee, Student student)
    //    {
    //        return employee.Age < student.Age;

    //    }
    //}

    #endregion







    #region Generic
    //public class Employee<T, U> where T:U
    //                         /*where T : new()*/
    //                         //where T : struct
    //                         //where T : Common
    //                         //where T : ITest
    //                         //where T : class
    //{

    //}

    //public class Person : Common
    //{

    //}

    //public class Common
    //{

    //}


    //public class Test : ITest
    //{

    //}

    //public interface ITest
    //{

    //}

    #endregion




    #region Practice EXIMP
    // public class StringList
    // {
    //         private string[] arr;

    //     public StringList()
    //     {
    //         arr = new string[0];
    //     }


    //     public void Add(string str)
    //     {
    //         Array.Resize(ref arr, arr.Length + 1);
    //         arr[arr.Length - 1] = str;
    //     }

    //     public void GetAll()
    //     {
    //         foreach (var item in arr)
    //         {
    //             Console.WriteLine(item);
    //         }
    //     }

    // }





    // public class IntList
    // {
    //     private int[] arr;

    //     public IntList()
    //     {
    //         arr = new int[0];
    //     }


    //     public void Add(int a)
    //     {
    //         Array.Resize(ref arr, arr.Length + 1);
    //         arr[arr.Length - 1] = a;
    //     }

    //     public void GetAll()
    //     {
    //         foreach (var item in arr)
    //         {
    //             Console.WriteLine(item);
    //         }
    //     }

    // }

    // public class Booklist
    // {
    //     private Book[] arr;

    //     public Booklist()
    //     {
    //         arr = new Book[0];
    //     }


    //     public void Add(Book book)
    //     {
    //         Array.Resize(ref arr, arr.Length + 1);
    //         arr[arr.Length - 1] = book;
    //     }

    //     public void GetAll()
    //     {
    //         foreach (var item in arr)
    //         {
    //             Console.WriteLine(item.Name + " - " + item.Author);
    //         }
    //     }
    // }


    //public class Book
    //{
    //     public string Name { get; set; }
    //     public string Author { get; set; }
    //}



    // public class DataList<T>
    // {
    //     private T[] arr;

    //     public DataList()
    //     {
    //         arr = new T[0];
    //     }


    //     public void Add(T data)
    //     {
    //         Array.Resize(ref arr, arr.Length + 1);
    //         arr[arr.Length - 1] = data;
    //     }

    //     public void GetAll()
    //     {
    //         foreach (var item in arr)
    //         {
    //             Console.WriteLine(item);


    //         }
    //     }

    // }
    #endregion

}
