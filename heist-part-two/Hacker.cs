public class Hacker : IRobber
{
    public string Name { get; set; }
    public int SkillLevel { get; set; }
    public int PercentageCut { get; set; }
    public void PerformSkill(Bank bank)
    {
        bank.AlarmScore = bank.AlarmScore - SkillLevel;
        Console.WriteLine($"{Name} is hacking the alarm system. Decrease security by {SkillLevel} points.");
        if(bank.AlarmScore <= 0)
        {
            Console.WriteLine($"{Name} has hacked the alarm system!");
        }
    }
}