using MVCDemo.Models;
using System.Xml.Linq;

namespace MVCDemo.FriendServices
{
    public class FriendServices
    {
        static List<Friend> Friends { get; }
        static int nextId = 3;
        static FriendServices()
        {
            Friends = new List<Friend>
                {
                    new Friend { FriendID = 1,  FName  = "C"},
                    new Friend { FriendID = 2,  FName  = "D"  }
                };
        }

        public static List<Friend> GetAll() => Friends;

        public static Friend? Get(int id) => Friends.FirstOrDefault(p => p.FriendID == id);

        public static void Add(Friend friends)
        {
            friends.FriendID = nextId++;
            Friends.Add(friends);
        }

        public static void Delete(int id)
        {
            var friends = Get(id);
            if (friends is null)
                return;

            Friends.Remove(friends);
        }

        public static void Update(Friend friends)
        {
            var index = Friends.FindIndex(p => p.FriendID == friends.FriendID);
            if (index == -1)
                return;

            Friends[index] = friends;
        }
    }
}

