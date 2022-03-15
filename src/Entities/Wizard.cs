namespace JogoRpgPoo.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(String Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack()
        {
            return this.Name + " Lançou Magia ";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " Lançou Magia Super efetiva com bonus de " + Bonus;
            }
            else
            {
                return this.Name + " Lançou Magia com força fraca com bonus de " + Bonus;
            }


        }

    }
}
