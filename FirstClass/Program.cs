using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    class Program
    {
        class UserInfo
        {
            public string Name, Family, Address;
            public byte Age;

            public void writeUserInfo(string Name, string Family, string Address, byte Age)
            {
                Console.WriteLine("Name - {0}\nFamily - {1}\nAddress - {2}\nAge - {3}\n",Name,Family,Address,Age);
            }
        }
        static void Main(string[] args)
        {
            UserInfo user1 = new UserInfo();
            user1.Name = "Vasya";
            user1.Address = "Kyiv";
            user1.Family = "Pupkin";
            user1.Age = 31;


            UserInfo user2 = new UserInfo();

            user2.Name = "Masha";
            user2.Address = "Kyiv";
            user2.Family = "Vasileva";
            user2.Age = 30;

            user1.writeUserInfo(user1.Name, user1.Family, user1.Address, user1.Age);
            user2.writeUserInfo(user2.Name, user2.Family, user2.Address, user2.Age);

            Console.ReadKey();
        }
    }
}
