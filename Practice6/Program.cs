using System;
using System.ComponentModel;

class Magic
{
    public string Type { get; set; }
    public string Name { get; set; }
    public double PowerLevel { get; set; }
    public double ManaCost { get; set; }
    public double Efficiency()
    {
        if (ManaCost == 0) return PowerLevel;
        return PowerLevel / ManaCost;
    }
    public string Description()
    {
        return $"{Name} ({Type}) Сила: {PowerLevel} Стоимость маны: {ManaCost}";
    }
    public virtual void Attack()
    {
        Console.WriteLine("Нанесено X урона");
    }
    public virtual void Heal()
    {
        Console.WriteLine("Вылечено X ОЗ");
    }
    public void CastTime()
    {
        Console.WriteLine("Время каста X секунд");
    }
    public void Cooldown()
    {
        Console.WriteLine("Время перезарядки X секунд");
    }
}

class SaintRay : Magic
{
    public string HeroUse { get; set; }
    public double LevelRequired { get; set; }
    public override void Attack()
    {
        Console.WriteLine("Нанесено 50 урона");
    }
    public override void Heal()
    {
        Console.WriteLine("Вылечено 25 ОЗ");
    }
    public new void CastTime()
    {
        Console.WriteLine("Время каста 5 секунд");
    }
    public new void Cooldown()
    {
        Console.WriteLine("Время перезарядки 30 секунд");
    }
}

class Program
{
    static void Main()
    {
        SaintRay holyspell = new SaintRay()
        {
            Type = "Святая",
            Name = "Святой луч",
            PowerLevel = 10,
            ManaCost = 50,
            HeroUse = "Жрец",
            LevelRequired = 15
        };

        Magic magic = holyspell;
        holyspell.Attack();
        holyspell.Heal();
        holyspell.CastTime();
        holyspell.Cooldown();
    }
}