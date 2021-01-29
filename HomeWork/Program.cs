using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerInfo playerInfo1 = new PlayerInfo();

            PlayerManager playerManager = new PlayerManager(new UserValidationManager());
            playerInfo1.Account = "deneme";
            playerInfo1.BirthdayYear = 2134;


            


        }
    }
}
