using System;

namespace Roshambo
{
    
    public class ChaosMaster
    {
        public int GenerateRoshambo()
        {
            var x = new Random();
            int RoshamboValue = x.Next(0, 4);
            return RoshamboValue;
        }
    }
}

