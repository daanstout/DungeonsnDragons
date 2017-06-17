using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet {
    public class Item {
        public readonly string itemName;
        public readonly int itemWeight;
        public readonly int itemWorth;

        public Item(string name, int weight, int worth) {
            itemName = name;
            itemWeight = weight;
            itemWorth = worth;
        }
    }
}
