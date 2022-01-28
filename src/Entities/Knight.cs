namespace Abstraindo_um_Jogo_de_RPG_Usando_Orientação_a_Objetos.src.Entities
{
    public class Knight : Hero
    {
        public Knight()
        {
        }

        public Knight(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
        }

        public override string Atack()
        {
            return this.Name + " te atacou com uma lança";
        }
    }
}