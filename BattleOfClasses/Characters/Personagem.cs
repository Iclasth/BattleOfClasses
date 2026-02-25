namespace BattleOfClasses.Caracters
{
    public abstract class Personagem
    {
       Random random = new Random();

        protected int Hp = 10;
        protected int FoeHp = 10;

        protected int Dano = 3;
        protected int FoeDano = 3;

       

        public virtual void DarDano(bool work)
        {

            if (Hp > 0 && work == true)
            {
                FoeHp -= Dano;
            }
            
        }

        public virtual void TomarDano(bool work)
        {

            if(Hp > 0 && work == true)
            {
                Hp -= FoeDano;
            }


        }

        public virtual void TentarDefensa()
        {
            int currentNumber = random.Next(1, 10);
            int tentativa = random.Next(1, 10);

            if(tentativa >= currentNumber)
            {
                TomarDano(false);
            }
        }
    }
}
