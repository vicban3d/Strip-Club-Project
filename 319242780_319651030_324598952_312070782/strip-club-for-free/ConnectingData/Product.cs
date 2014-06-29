using System;
using System.Collections.Generic;
using System.Text;

namespace ConnectingData
{
    class Product
    {
        int catalog;
        string name;
        int quantity;

        public Product(int c, string n, int q)
        {
            catalog = c;
            name = n;
            quantity = q;
        }

        public int getCatalogNum()
        {
            return catalog;
        }

        public int getQuantity()
        {
            return quantity;
        }

        public string getName()
        {
            return name;
        }
    }
}
