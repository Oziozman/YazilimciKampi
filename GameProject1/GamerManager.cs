using System;

namespace GameProject1
{
    internal class GamerManager
    {
        private NewEStateUserValidationManager newEStateUserValidationManager;

        public GamerManager(NewEStateUserValidationManager newEStateUserValidationManager)
        {
            this.newEStateUserValidationManager = newEStateUserValidationManager;
        }

        internal void Add(Gamer gamer)
        {
            throw new NotImplementedException();
        }
    }
}