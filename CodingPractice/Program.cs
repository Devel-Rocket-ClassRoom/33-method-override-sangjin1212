using System;
//Parent parent = new Parent();
//parent.Work();
//Child child = new Child();
//child.Work();
//class Parent
//{
//    public virtual void Work()
//    {
//        Console.WriteLine("프로그래머");
//    }
//}
//class Child : Parent
//{
//    public override void Work()
//    {
//        Console.WriteLine("프로그래머");
//    }
//}
//Animal animal = new Animal();
//animal.Eat();
//Animal cat = new Cat();
//cat.Eat();
//class Animal
//{
//    public virtual void Eat()
//    {
//        Console.WriteLine("Animal Eat");
//    }
//}
//class Cat : Animal
//{
//    public override void Eat()
//    {
//        Console.WriteLine("Cat Eat");
//    }
//}
//Child child = new Child();
//child.Say();
//child.Run();
//child.Walk();
//Parent parent = child;
//parent.Say();
//parent.Run();
//parent.Walk();

//class Parent
//{
//    public void Say()
//    {
//        Console.WriteLine("부모_안녕하세요.");
//    }
//    public void Run()
//    {
//        Console.WriteLine("부모_달리다.");
//    }
//    public virtual void Walk()
//    {
//        Console.WriteLine("부모_걷다");
//    }
//}
//class Child : Parent
//{ 
//    public new void  Say()
//    {
//        Console.WriteLine("자식_안녕하세요");
//    }
//    public new void Run()
//    {
//        Console.WriteLine("자식_달리다");
//    }
//    public override void Walk()
//    {
//        Console.WriteLine("자식_걷다");
//    }
//}
//Calculator calculator = new Calculator();
//Console.WriteLine(calculator.Add(1, 2));
//Console.WriteLine(calculator.Add(1.5, 2.5));
//Console.WriteLine(calculator.Add(1, 2,3));
//class Calculator
//{ 
//    public int Add(int a , int b) => a + b;
//    public double Add(double a, double b) => a + b;
//    public int Add(int a , int b , int c) => a + b + c;
//}
//Animal animal = new Animal();
//animal.Speak();
//Animal dog = new Dog();
//dog.Speak();
//Animal cat = new Cat();
//cat.Speak();
//class Animal
//{
//    public virtual void Speak()
//    {
//        Console.WriteLine("동물이 소리를 낸다");
//    }
//}
//class Dog : Animal
//{
//    public override void Speak()
//    {
//        Console.WriteLine("멍멍!");
//    }
//}
//class Cat : Animal
//{
//    public override void Speak()
//    {
//        Console.WriteLine("야옹!");
//    }
//}
//Child child = new Child();
//child.Greet();
//class Parent
//{
//    public virtual void Greet()
//    {
//        Console.WriteLine("안녕하세요");
//    }
//}
//class Child : Parent
//{
//    public override void Greet()
//    {
//        base.Greet();
//        Console.WriteLine("반갑습니다");

//    }
//}
//new Parent().Work();
//new Child().Work(); 
//new GrandChild().Work();
//class Parent
//{
//    public virtual void Work()
//    {
//        Console.WriteLine("프로그래머");
//    }
//}

//class Child : Parent
//{
//    public override void Work()
//    {
//        base.Work();
//    }
//}
//class GrandChild : Child
//{
//    public override void Work()
//    {
//        Console.WriteLine("프로그래머");
//    }
//}
//Person person = new Person();
//Console.WriteLine(person);
//Console.WriteLine(person.ToString());
//class Person
//{
//    public string Name;
//}
//Person person = new Person("박용준");
//Console.WriteLine(person);
//class Person
//{
//    public string _name;
//    public  Person(string name)
//    { 
//        _name = name;
//    }

//    public override string ToString()
//    {
//        return $"[Person 클래스: {_name}]";
//    }
//}
//Character hero = new Character("용사", 10, 100);
//Character mage = new Character("마법사", 8, 70);
//Console.WriteLine(hero);
//Console.WriteLine(mage);

//class Character
//{
//    public string Name;
//    public int Level;
//    public int Health;

//    public Character(string name, int level, int health)
//    { 
//        Name = name;
//        Level = level;
//        Health = health;
//    }
//    public override string ToString()
//    {
//        return $"[{Name}] Lv.{Level} HP:{Health}";
//    }
//}
//Character warrior = new Warrior("전사");
//Character mage = new Mage("마법사");
//Character archer = new Archer("궁수");

//Console.WriteLine(warrior);
//Console.WriteLine(mage);
//Console.WriteLine(archer);


//warrior.Attack();
//mage.Attack();
//archer.Attack();

Character[] party = new Character[]
    {
        new Warrior("전사"),
        new Mage("마법사"),
        new Archer("궁수")
    };
Console.WriteLine("=== 파티 공격 ===");
foreach (Character member in party)
{
    member.Attack();
}

class Character
{
    public string Name;
    public int AttackPower;

    public Character(string name, int attackPower)
    { 
        Name = name;
        AttackPower = attackPower;
    }
    public virtual void Attack()
    {
        Console.WriteLine($"{Name}이(가) 공격합니다. {AttackPower}데미지");
    }
    public override string ToString()
    {
        return $"[{Name}] 공격력: {AttackPower}";
    }
}
class Warrior : Character
{
    public Warrior(string name) : base(name, 50) { }

    public override void Attack()
    {
        Console.WriteLine($"{Name}이(가) 칼로 베어냅니다! 데미지: {AttackPower}");
    }
}

class Mage : Character
{
    public Mage(string name) : base(name, 30) { }

    public override void Attack()
    {
        Console.WriteLine($"{Name}이(가) 파이어볼을 시전합니다! 데미지: {AttackPower * 2}");
    }
}

class Archer : Character
{
    public Archer(string name) : base(name, 40) { }

    public override void Attack()
    {
        Console.WriteLine($"{Name}이(가) 화살을 쏩니다! 데미지: {AttackPower}");
    }
}