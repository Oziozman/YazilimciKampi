using System;
using System.Collections.Generic;
using System.Text;

namespace TheGameSimulation.Abstract
{
    class PlayerManager
    {
        IPlayerCheckService _playerCheckService; // check servisinden field aldım
        public PlayerManager(IPlayerCheckService playerCheckService)//constrctr, playmanager newlendiğinde ilk burası calısacak
        {
            _playerCheckService = playerCheckService; //check servisin yönetim classından gelen nesne benim yarattgım fielda esittir dedim.      
        }
        public virtual void Add(IPlayer player)
        {
            if (_playerCheckService.CheckIfRealPerson(player))
            {
                Console.WriteLine(player.FirstName + " " + player.LastName + " oyuncusu başarıyla kaydedildi.");
            }
            else Console.WriteLine("Lütfen bilgilerinizi kontrol ediniz.!");
        }
        public void Update(IPlayer player)
        {
            Console.WriteLine(player.FirstName + " " + player.LastName + " oyuncusunun bilgileri güncellenmiştir.");
        }
        public void Delete(IPlayer player)
        {
            Console.WriteLine(player.FirstName + " " + player.LastName + " oyuncusu sistemden silindi.");
        }
    }
}
