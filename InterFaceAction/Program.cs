using InterFaceAction;

Person person = new Person();
Car car = new Car();
DoAction(person);
DoAction(car);

void DoAction(IMovable movable) => movable.Move();
