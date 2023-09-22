using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Messages_Manager
{
    internal class Program
    {
        /*
10
Add=Berg=9=0
Add=Kevin=0=0
Message=Berg=Kevin
*/
        static void Main(string[] args)
        {
            int possibleMessages = int.Parse(Console.ReadLine()); //sent + recieved
            string inpt;
            Dictionary<string , List<int>> users = new Dictionary<string , List<int>>();
            while((inpt = Console.ReadLine()) != "Statistics")
            {
                List<string> arg = inpt.Split("=").ToList();
                switch (arg[0])
                {
                    case "Add":
                        string username = arg[1];
                        int sent = int.Parse(arg[2]);
                        int received = int.Parse(arg[3]);
                        if (!users.ContainsKey(username))
                        {
                            users.Add(username, new List<int>() {sent, received });
                        }
                        break;
                    case "Message":
                        string sender = arg[1];
                        string receiver = arg[2];
                        if(users.ContainsKey(sender)&& users.ContainsKey(receiver)) 
                        {
                            users[sender][0]++;
                            users[receiver][1]++;
                            if (users[sender][0] + users[sender][1] >= possibleMessages)
                            {
                                Console.WriteLine($"{sender} reached the capacity!");
                                users.Remove(sender);
                            }
                            if (users[receiver][0] + users[receiver][1] >= possibleMessages)
                            {
                                Console.WriteLine($"{receiver} reached the capacity!");
                                users.Remove(receiver);
                            }
                        }

                        break;
                    case "Empty":

                        if (arg[1] == "All")
                        {
                            users.Clear();
                        }
                        else if (users.ContainsKey(arg[1]))
                        {
                            users.Remove(arg[1]);
                        }
                        break;
                }
            }

            Console.WriteLine($"Users count: {users.Count}");
            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key} - {user.Value.Sum()}");
            }
        }
    }
}
