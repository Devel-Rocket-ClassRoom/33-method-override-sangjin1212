using System;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
Console.WriteLine("=== 악기 연주회 ===");
Instrumnet piano = new Piano();
Instrumnet gultar = new Guitar();
Instrumnet drum = new Drum();
piano.Tune();
piano.Play();
Console.WriteLine();
gultar.Tune();
gultar.Play();
Console.WriteLine();
drum.Tune();
drum.Play();
class Instrumnet
{
    public string _name;

    public Instrumnet(string name)
    {
        _name = name;
    }
    public virtual void Play()
    {
        Console.WriteLine($"[{_name}]을(를) 연주합니다.");
    }
    public virtual void Tune()
    {
        Console.WriteLine($"{_name}을(를) 조율합니다.");
    }
}

class Piano : Instrumnet
{
    public Piano() : base("피아노") { }
    public override void Play()
    {
        Console.WriteLine($"🎹{_name} 건반을 누릅니다 - 딩동댕-");
    }

    public override void Tune()
    {
        Console.WriteLine($"{_name} 현을 조율 합니다");
    }
}
class Guitar : Instrumnet
{
    public Guitar() : base("기타") { }
    public override void Play()
    {
        Console.WriteLine($"🎹{_name} 기타 줄을 튕깁니다 - 퉁퉁퉁-");
    }

    public override void Tune()
    {
        Console.WriteLine($"{_name}줄을 조율 합니다");
    }
}
class Drum : Instrumnet
{
    public Drum() : base("드럼") { }
    public override void Play()
    {
        Console.WriteLine($"🎹{_name}을(를) 두드립니다 -둥둥둥-");
    }

    public override void Tune()
    {
        Console.WriteLine($"{_name}을(를) 조율 합니다");
    }


}

