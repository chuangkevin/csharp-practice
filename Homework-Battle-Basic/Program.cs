using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Character character1 = new Character()
        {
            Name = "Andy",
            Hp = 10,
            AttackPoint = 3
        };

        Character character2 = new Character()
        {
            Name = "Jimmy",
            Hp = 10,
            AttackPoint = 6
        };

        Console.WriteLine($"攻擊前"
                            + Environment.NewLine
                            + character1.ToString()
                            + Environment.NewLine
                            + character2
                            + Environment.NewLine);
        Attack(character1, character2);
        Console.WriteLine($"{character1.Name}攻擊後"
                            + Environment.NewLine
                            + character1.ToString()
                            + Environment.NewLine
                            + character2
                            + Environment.NewLine);

        Attack(character2, character1);
        Console.WriteLine($"{character2.Name}攻擊後"
                            + Environment.NewLine
                            + character1.ToString()
                            + Environment.NewLine
                            + character2
                            + Environment.NewLine);
        void Attack(Character attacker, Character attackee)
        {
            attackee.Hp -= attackee.AttackPoint;
        }
        Console.ReadLine();
    }

    public class Character
    {
        /// <summary>
        /// 角色名稱
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// 血量
        /// </summary>
        /// <value>
        /// The hp.
        /// </value>
        public int Hp { get; set; }

        /// <summary>
        /// 攻擊力
        /// </summary>
        /// <value>
        /// The attack point.
        /// </value>
        public int AttackPoint { get; set; }

        public override string ToString()
        {
            return $"{Name}的血量:{Hp}，攻擊力:{AttackPoint}";
        }
    }
}