namespace BattleOfClasses.Caracters
{
    public class Arqueiro : Personagem
    {
        public override void DarDano(bool work)
        {
            if (Hp > 0 && work == true)
            {
                
                FoeHp -= Dano * 3;
            }
        }

        public override void TomarDano(bool work)
        {
            if (Hp > 0 && work == true)
            {
                Hp -= Dano * 2;
            }
        }

        public override void TentarDefensa()
        {
            base.TentarDefensa();
        }
    }
}
