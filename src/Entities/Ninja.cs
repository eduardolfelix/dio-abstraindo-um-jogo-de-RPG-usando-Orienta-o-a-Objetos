namespace Abstraindo_um_Jogo_de_RPG_Usando_Orientação_a_Objetos.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja()
        {
        }

        public Ninja(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
        }

        public override string Atack()
        {
            return this.Name + ", que é um ninja te atacou com um golpe mortal";
        }
    }
}