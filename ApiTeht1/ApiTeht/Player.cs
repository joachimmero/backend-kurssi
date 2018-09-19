using System;
using System.Collections.Generic;

namespace ApiTeht
{
    public class Player
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }
        public bool IsBanned { get; set; }
        public DateTime CreationTime { get; set; }
        public List<Item> items { get; set; }

        public Player(){
            items = new List<Item>();
        }
    }

    public class NewPlayer
    {
        public string Name { get; set; }
    }

    public class ModifiedPlayer
    {
        public int Score { get; set; }
    }
}