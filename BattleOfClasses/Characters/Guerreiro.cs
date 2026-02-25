namespace BattleOfClasses.Caracters
{
    public class Guerreiro : Personagem
    {

        public override void DarDano(bool work)
        {
            if(Hp > 0 && work == true)
            {
                FoeHp -= Dano * 2;
            }
        }

        public override void TomarDano(bool work)
        {
            if (Hp > 0 && work == true)
            {
                Hp -= Dano - 1;
            }
        }

        public override void TentarDefensa()
        {
            base.TentarDefensa();
        }
    }
}
