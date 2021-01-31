using System;
using System.Collections.Generic;
using System.Text;

namespace TheGameSimulation.Concrete
{
    class PlayerCheckManager
    {
        public class PlayerCheckManager : IPlayerCheckService
        {
            public bool CheckIfRealPerson(IPlayer player)
            {
                return false;
            }
        }
}
