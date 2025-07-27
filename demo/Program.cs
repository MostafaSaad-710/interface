namespace assignment
{
    #region Q01
    interface IShape
    {
        double Area { get; }
        void DisplayShapeInfo();
    }

    interface ICircle : IShape { }
    interface IRectangle : IShape { }


    class Circle : ICircle
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Area { get { return Math.PI * Radius * Radius; } }

        public void DisplayShapeInfo()
        {
            Console.WriteLine("Shape: Circle");
            Console.WriteLine($"Radius: {Radius}");
            Console.WriteLine($"Area: {Area}");
        }
    }


    class Rectangle : IRectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double Area { get { return Width * Height; } }

        public void DisplayShapeInfo()
        {
            Console.WriteLine("Shape: Rectangle");
            Console.WriteLine("Width: " + Width);
            Console.WriteLine("Height: " + Height);
            Console.WriteLine("Area: " + Area);
        }
    }

    #endregion

    #region Q02
    public interface IAuthenticationService
    {
        bool AuthenticateUser(string username, string password);
        bool AuthorizeUser(string username, string role);
    }

    public class BasicAuthenticationService : IAuthenticationService
    {
        private string storedUsername = "admin";
        private string storedPassword = "1234";
        private string storedRole = "admin";

        public bool AuthenticateUser(string username, string password)
        {
            return username == storedUsername && password == storedPassword;
        }

        public bool AuthorizeUser(string username, string role)
        {
            return username == storedUsername && role == storedRole;
        }
    }

    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region PART 01

            // 1: b) To define a blueprint for a class
            // 2: a) private
            // 3: b) No
            // 4: b) Yes, interfaces can inherit from multiple interfaces
            // 5: [None of the provided options are correct; correct usage is ':' in C#]
            // 6: a) Yes
            // 7: b) No, all members are implicitly public
            // 8: b) To provide a clear separation between interface and class members
            // 9: b) No, interfaces cannot have constructors
            // 10: c) By separating interface names with commas

            #endregion

            #region PART 02

            #region Q01
            //ICircle circle = new Circle(5);
            //IRectangle rectangle = new Rectangle(4, 6);

            //circle.DisplayShapeInfo();
            //Console.WriteLine();
            //rectangle.DisplayShapeInfo(); 
            #endregion

            #region Q02
            //IAuthenticationService authService = new BasicAuthenticationService();

            //bool isAuthenticated = authService.AuthenticateUser("admin", "1234");
            //bool isAuthorized = authService.AuthorizeUser("admin", "admin");

            //Console.WriteLine("Authenticated: " + isAuthenticated);
            //Console.WriteLine("Authorized: " + isAuthorized);

            #endregion


            #endregion
        }
    }
}