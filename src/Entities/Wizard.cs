namespace Orientacao_objetos_usando_um_jogo_RPG.src.Entities
{
    public class Wizard : Hero
    {

        public Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        
        public  override string Attack()
        {
            return this.Name + " Lançou Magia";
        }
        
    }
}