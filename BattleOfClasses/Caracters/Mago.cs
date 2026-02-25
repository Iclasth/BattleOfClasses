namespace BattleOfClasses.Caracters
{
    public class Mago : Personagem
    {
        private Random random = new Random();
        public override void DarDano(bool work) 
        {

            if (Hp > 0 && work == true)
            {
                int tentarFireBalls = random.Next(1, 15);
                if (tentarFireBalls >= 5)
                {
                    FoeHp -= Dano * 3;
                }
                FoeHp -= Dano;
            }
        }

        public override void TomarDano(bool work)
        {
            if (Hp > 0 && work == true)
            {
                int tentarEscudoImpenetravel = random.Next(1, 15);
                if (tentarEscudoImpenetravel >= 7)
                {
                    work = false;
                } else 
                { 
                    Hp -= FoeDano;
                }
            }
        }

        public override void TentarDefensa()
        {
            base.TentarDefensa();
        }
    }
}
