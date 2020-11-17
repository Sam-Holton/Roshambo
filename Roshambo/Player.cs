namespace Roshambo
{
    abstract class Player
    {
        string Name;
        int RoshamboValue;

        public abstract int GenerateRoshambo();
    }
}

