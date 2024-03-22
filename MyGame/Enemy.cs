namespace MyGame
{

    public class Enemy
    {
        private string name;
        private float health = 100;
        private float shield = 0;

        public Enemy(string name)
        {
            this.name = name;
            health = 100;
            shield = 0;
        }
    }
}