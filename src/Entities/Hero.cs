namespace Abstraindo_um_Jogo_de_RPG_Usando_Orientação_a_Objetos.src.Entities
{
    public class Hero
    {
        public Hero()
        {
        }

        public Hero(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }

        public virtual string Atack(){
            return this.Name + " te atacou com uma magia White, de grau médio";
        }

        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType;
        }
    }
}