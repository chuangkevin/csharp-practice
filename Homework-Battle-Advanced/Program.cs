using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Character character1 = new Character()
        {
            Name = "Andy",
            Hp = 50,
            AttackPoint = 3
        };

        Character character2 = new Character()
        {
            Name = "Jimmy",
            Hp = 50,
            AttackPoint = 6
        };

        int round = 1000;
        for (int i = 1; i <= round; i++)
        {
            Console.WriteLine($"回合:{i}開始"
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
            // 因為是character1先攻擊，所以檢查2是否死亡
            if (character2.IsDead)
            {
                Console.WriteLine($"{character2.Name}死亡，勝利者{character1.Name}");
                break;
            }
            Attack(character2, character1);
            Console.WriteLine($"{character2.Name}攻擊後"
                                + Environment.NewLine
                                + character1.ToString()
                                + Environment.NewLine
                                + character2
                                + Environment.NewLine);
            if (character1.IsDead)
            {
                Console.WriteLine($"{character1.Name}死亡，勝利者{character2.Name}");
                break;
            }
            Console.WriteLine("-----------------------");
        }

        Console.ReadLine();

        void Attack(Character attacker, Character attackee)
        {
            attackee.Hp -= attacker.AttackPoint;
        }
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

        /// <summary>
        /// 角色是否死亡
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is dead; otherwise, <c>false</c>.
        /// </value>
        public bool IsDead => Hp <= 0;

        public override string ToString()
        {
            return $"{Name}的血量:{Hp}，攻擊力:{AttackPoint}";
        }
    }
}