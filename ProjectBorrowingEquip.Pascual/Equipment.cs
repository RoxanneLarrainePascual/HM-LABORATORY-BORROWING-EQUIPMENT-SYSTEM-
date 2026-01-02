using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBorrowingEquip.Pascual
{
    public class Equipment
    {
        public string Name { get; set; }
        public int TotalQuantity { get; set; }
        public int AvailableQuantity { get; set; }

        public Equipment(string name, int total, int available)
        {
            Name = name;
            TotalQuantity = total;
            AvailableQuantity = available;
        }

        public void Return(int quantity)
        {
            AvailableQuantity += quantity;
            if (AvailableQuantity > TotalQuantity)
                AvailableQuantity = TotalQuantity;
        }
    }
}
