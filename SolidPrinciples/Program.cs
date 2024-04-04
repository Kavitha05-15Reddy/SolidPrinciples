namespace SolidPrinciples
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Without SRP
            Calculator c1 = new Calculator();
            c1.AddDisplay(5,3);
            //With SRP
            Calculator1 c2 = new Calculator1();
            int sum = c2.Add(5,5);
            Display d = new Display();
            d.Result(sum);

            //Without OSP
            AreaCalculator area = new AreaCalculator();
            area.AreaRectangle(0.5,0.5);
            area.AreaCicle(0.5);
            //With OSP
            Rectangle r = new Rectangle(0.5,0.5);
            r.CalculateArea();
            Circle c = new Circle(0.5);
            c.CalculateArea();

            //LSP
            Vehicle vehicle1 = new Car();
            vehicle1.Accelerate();
            Vehicle vehicle2 = new Bike();
            vehicle2.Accelerate();

            //ISP
            Robot robo = new Robot();
            robo.Work();
            Human human = new Human();
            human.Work();
            human.Eat();
            human.Sleep();

            //Without DIP
            NotificationService1 n = new NotificationService1();
            n.SendNotification("Hello");
            //With DIP
            EmailSender1 email = new EmailSender1();
            NotificationService s = new NotificationService(email);
            s.SendNotification("Hello");

            //DRY
            Shape square = new Square(0.5);
            square.CalculateArea();
            Shape triangle = new Triangle(0.5, 0.5);
            triangle.CalculateArea();

            //KISS
            KISS sort = new KISS();
            sort.SortArray();
            sort.SortArray1();
        }
    }
}
