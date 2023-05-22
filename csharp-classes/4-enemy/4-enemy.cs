namespace Enemies
{
    public class Zombie
    {
        private int health;

        private string name = "(No name)";

        public string Name
        {
            get 
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }		
        public Zombie()
        {
            this.health = 0;
        }
        public Zombie(int value)
        {
            if (value < 0)
                throw new System.ArgumentException("Health must be greater than or equal to 0");

            else
                this.health = value;
        }

        public int GetHealth()
        {
            return (this.health);
        }
    }
}