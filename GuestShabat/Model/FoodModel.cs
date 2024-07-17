using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestShabat.Model
{
    internal class FoodModel // represents a dish in a category in the db
    {

        public string Name { get; set; }
        public int? Guest_ID { get; set; }
        public int? Category_ID { get; set; }
        public int? ID { get; set; }
        public FoodModel(string name, int?  guest_ID, int? category_ID, int? iD = null)
        {
            Name = name;
            Guest_ID = guest_ID;
            Category_ID = category_ID;
            ID = iD;
        }

        public FoodModel(DataRow row) 
        {
            if (row == null || !row.Table.Columns.Contains("name")  ||
                !row.Table.Columns.Contains("ID")  || !row.Table.Columns.Contains("Guest_ID")  
                || !row.Table.Columns.Contains("Category_ID")  )
            {
                throw new System.ArgumentNullException("row was null or missing args");
            }
            Name = row["name"].ToString()!;
            ID = (int)row["ID"];
            Guest_ID = (int)row["Guest_ID"];
            Category_ID = (int)row["Category_ID"];
        }

    }
}
