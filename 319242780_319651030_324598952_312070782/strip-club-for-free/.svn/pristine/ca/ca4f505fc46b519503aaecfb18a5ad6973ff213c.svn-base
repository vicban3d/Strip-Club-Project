using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace ConnectingData
{
    class Storage
    {
        List<Product> minimumQuantities = new List<Product>();

        public Storage()
        {
            makeMinQua();
        }

        private void makeMinQua() 
        {
            minimumQuantities.Add(new Product(111, "Finlandia", 50));
            minimumQuantities.Add(new Product(112, "Smirnoff", 50));
            minimumQuantities.Add(new Product(222, "Coca-Cola", 50));
            minimumQuantities.Add(new Product(333, "Fanta", 50));
            minimumQuantities.Add(new Product(444, "RedBull", 50));
            minimumQuantities.Add(new Product(777, "Zrima", 50));
        }

        public List<Product> checkQuantities(DataTable storage)
        {
            List<Product> toOrder = new List<Product>();
            for (int i = 0; i < storage.Rows.Count; i++)
            {
                int catalogNum = Convert.ToInt32(storage.Rows[i]["CatalogNum"].ToString());
                int size = minimumQuantities.Count;
                for (int j = 0; j < size; j++)
                {
                    if (catalogNum == ((Product)minimumQuantities[j]).getCatalogNum())
                    {
                        if (Convert.ToInt32(storage.Rows[i]["Quantity"].ToString()) < ((Product)minimumQuantities[j]).getQuantity())
                        {
                            toOrder.Add(new Product(catalogNum,storage.Rows[i]["ProductName"].ToString(), ((Product)minimumQuantities[j]).getQuantity() - Convert.ToInt32(storage.Rows[i]["Quantity"].ToString())));
                        }
                    }
                }
            }
                return toOrder;
        }
    }
}
