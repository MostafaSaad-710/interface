using demo.Interface_Ex01;
using demo.Interface_Ex02;
using demo.interface_Ex03;

namespace demo
{

    /// <summary>
    /// 1. public
    /// أي كلاس في أي مشروع يقدر يشوفها ويستخدمها.
    /// 2. internal
    /// الكلاسات داخل نفس المشروع فقط هم اللي يقدروا يشوفوها، حتى لو مش وارثين.
    /// 3. private
    /// الكود ده متاح فقط داخل نفس الكلاس، لا كلاس خارجي ولا كلاس وارث يقدر يشوفه.
    /// 4. protected
    /// الكود ده متاح للكلاس الأصلي وأي كلاس يرث منه، بس مش لأي كود خارج الكلاسات دي.
    /// 5. private protected
    /// الكود متاح بس للكلاس الأصلي والكلاسات اللي ترثه، لكن فقط لو كانوا في نفس المشروع.
    /// 6. protected internal
    /// الكود متاح للكلاسات اللي في نفس المشروع أو تورث الكلاس حتى لو من مشروع تاني.
    /// </summary>

    internal class Program
    {
        static void Print10Numbers(ISeries Series)
        {
            for(int i = 0 ; i < 10 ; i++)
            {
                Console.Write($"{Series.Current} ");
                Series.next();
            }
            Console.WriteLine( );
            Series.Reset();
        }

        static void Main(string[] args)
        {
            #region interface Ex01

            //// Interfaces : Reference Type
            //// Code Contract between the developer who write and developer who Use it

            //// You can't create object from any interface

            //MyType myType = new MyType();

            //myType.Salary = 12000;
            //Console.WriteLine(myType.Salary);
            //myType.myfun();
            //// Default Implemented Methods is not inherited


            //IMyType myTypee;
            //// Ref ---> Can refere to object from any class which implemented interface 'IMyType'


            //myTypee = new MyType();
            //myTypee.Salary = 11000;
            //Console.WriteLine(myTypee.Salary);
            //myTypee.myfun();
            //myTypee.Print(); 

            #endregion

            #region interface Ex02
            //SeriesByTwo seriesByTwo = new SeriesByTwo();

            //Print10Numbers(seriesByTwo);

            //SeriesByThree seriesByThree = new SeriesByThree();

            //Print10Numbers(seriesByThree);



            //int[] arr = { 1, 2, 3, 6, 5, 4, 9, 8, 7 };

            //Array.Sort(arr);

            //foreach (int item in arr)
            //{
            //    Console.Write($"{item} ");
            //}


            //Employee[] employee = new Employee[3]
            //{
            //    new Employee(){id = 1 , name = "Ahmed" , age = 30, salary = 12000},
            //    new Employee(){id = 2 , name = "Amr" , age = 45 , salary = 11000},
            //    new Employee(){id = 3 , name = "Ali" , age = 35 , salary = 16000}
            //};

            //Array.Sort(employee);

            //foreach (Employee item in employee)
            //{
            //    Console.Write($"{item} ");
            //}

            ////Error :  Failed to compare two elements in the array
            ////         At least one object must implement IComparable

            //// i am as a user to fun(sort) must be when send any array is from dataType implement interface(IComparable)

            #endregion

            #region interface Ex03

            //Car car = new Car();

            //car.Speed = 200;

            //car.Forward();


            //IFlyable flyable = new Airplane();

            //flyable.Backward();
            //flyable.Forward();

            //Console.WriteLine( );

            //Airplane airplane = new Airplane();
            //IMoveable moveable = airplane;

            //moveable.Backward();
            //moveable.Forward();


            #endregion

            #region Shallow Copy Vs Deep Copy
            // Shallow Copy Vs Deep Copy

            //int[] arr01 = { 1, 2, 3 };
            //int[] arr02 = { 4, 5, 6 };

            //Console.WriteLine($"Arr01 : {arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02 : {arr02.GetHashCode()}");

            //arr02 = arr01; // Shallow Copy
            //               // Copy identity

            //Console.WriteLine( );
            //Console.WriteLine($"Arr01 : {arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02 : {arr02.GetHashCode()}");

            //// Identity (Address) + Object state [date]

            //arr02[0] = 100;

            //Console.WriteLine(arr01[0]); // 100



            //int[] arr01 = { 1, 2, 3 };
            //int[] arr02 = { 4, 5, 6 };

            //Console.WriteLine($"Arr01 : {arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02 : {arr02.GetHashCode()}");

            //arr02 = (int[]) arr01.Clone(); // Deep Copy
            //// Clone Method Will Copy The Objrct state of Caller
            //// Assign the new object to arr02 , will generate new identity

            //Console.WriteLine();
            //Console.WriteLine($"Arr01 : {arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02 : {arr02.GetHashCode()}");

            //// Identity (Address) + Object state [date]

            //arr02[0] = 100;

            //Console.WriteLine(arr01[0]); // 1
            //Console.WriteLine(arr02[0]); // 1 
            #endregion

            #region Built-In interface ICloneable
            //Employee E01 = new Employee() { id = 1, name = "Ahmed", age = 30, salary = 12000 };
            //Employee E02 = new Employee() { id = 2, name = "Amr", age = 45, salary = 11000 };

            //E02 = E01; // shallow copy
            ////E02 = (Employee)E01.Clone(); // deep copy


            //Console.WriteLine(E01);
            //Console.WriteLine(E02);

            //Console.WriteLine(E01.GetHashCode());
            //Console.WriteLine(E02.GetHashCode());

            #endregion

            #region Built-In interface IComparable
            //Employee[] employee = new Employee[3]
            //{
            //    new Employee(){id = 1 , name = "Ahmed" , age = 60, salary = 12000},
            //    new Employee(){id = 2 , name = "Amr" , age = 45 , salary = 11000},
            //    new Employee(){id = 3 , name = "Ali" , age = 35 , salary = 16000}
            //};

            //Array.Sort(employee);

            //foreach (Employee item in employee)
            //{
            //    Console.WriteLine($"{item} ");
            //} 
            #endregion

            #region Built-In interface IComparer
            //Employee[] employee = new Employee[3]
            //{
            //    new Employee(){id = 1 , name = "Ahmed" , age = 60, salary = 12000},
            //    new Employee(){id = 2 , name = "Amr" , age = 45 , salary = 11000},
            //    new Employee(){id = 3 , name = "Ali" , age = 35 , salary = 16000}
            //};


            //Array.Sort(employee , new EmployeeComparerNameLength());

            //foreach (Employee item in employee)
            //{
            //    Console.WriteLine($"{item} ");
            //}

            #endregion


        }
    }
}
