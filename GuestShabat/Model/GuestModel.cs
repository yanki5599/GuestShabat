using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestShabat.Model
{
    public class GuestModel
    {

        public string Name { get; set; }
        public int? ID { get; set; }
        public GuestModel(string name, int? iD = null)
        {
            Name = name;
            ID = iD;
        }

        public GuestModel(DataRow row)
        {
            if (row == null || !row.Table.Columns.Contains("name") || !row.Table.Columns.Contains("ID"))
            {
                throw new System.ArgumentNullException(nameof(row));
            }
            Name = row["name"].ToString()!;
            ID = (int)row["ID"];
        }


    }
}
