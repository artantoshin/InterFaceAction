using InterFaceAction;
using System.Text;

var enc65001 = Encoding.GetEncoding(65001);
Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = enc65001;

Person person = new Person();
Car car = new Car();
DoAction(person);
DoAction(car);

Message hello = new Message("Hello World");
hello.Print();  // Hello World

// Все объекты Message являются объектами IMessage
IMessage hello2 = new Message("Hello METANIT.COM");
Console.WriteLine(hello2.Text); // Hello METANIT.COM

void DoAction(IMovable movable) => movable.Move();
