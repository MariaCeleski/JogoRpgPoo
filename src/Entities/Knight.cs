namespace JogoRpgPoo.src.Entities
{
    public class Knight : Hero  //Boss
    {
        public Knight(String Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        // Implementação de interface
        // public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        // public string Hadouken { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}