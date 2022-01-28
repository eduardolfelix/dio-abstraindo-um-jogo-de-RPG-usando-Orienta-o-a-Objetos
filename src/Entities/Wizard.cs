namespace Abstraindo_um_Jogo_de_RPG_Usando_Orientação_a_Objetos.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard()
        {
        }

        public Wizard(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
        }

        public Wizard(string Name, int Level, string HeroType, bool BlackWizard) : base(Name, Level, HeroType)
        {
            this.BlackWizard = BlackWizard;
        }
        public bool BlackWizard { get; set; }
        public string Atack(bool black)
        {
            if (!black)
                return this.Name + " te atacou com uma magia";
            else
                return this.Name + ", Black Wizard te atacou com uma magia de level duplicado";
        }
    }
}