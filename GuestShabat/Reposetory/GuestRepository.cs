using GuestShabat.DAL;
using GuestShabat.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShabatHost.Model;

namespace GuestShabat.Reposetory
{
    internal class GuestRepository : IRepository<GuestModel>
    {
        private readonly DBContext _dbContext;

        public GuestRepository(DBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool Create(GuestModel entity)
        {
            string query = "INSERT INTO Guests(name) VALUES(@GuestName)";

            var parameter = new SqlParameter("@GuestName", SqlDbType.NVarChar) { Value = entity.Name };

            return _dbContext.ExecuteNonQuery(query, parameter) > 0;
        }

        public bool Delete(int id)
        {
            string query = "DELETE FROM Guests WHERE ID = @id";
            var parameter = new SqlParameter("@id", SqlDbType.NVarChar) { Value = id };
            return _dbContext.ExecuteNonQuery(query, parameter) > 0;
        }

        public GuestModel? FindById(int id)
        {
            string query = "SELECT * FROM Guests where ID = @id";

            var parameter = new SqlParameter("@id", SqlDbType.Int) { Value = id };

            var dt = _dbContext.ExecuteQuery(query, parameter);
            if (dt.Rows.Count <= 0)
                return null;

            return new GuestModel(dt.Rows[0]);
        }

        public GuestModel? FindByName(string name)
        {
            string query = "SELECT * FROM Guests where name = @name";

            var parameter = new SqlParameter("@name", SqlDbType.NVarChar) { Value = name };

            var dt = _dbContext.ExecuteQuery(query, parameter);
            if (dt.Rows.Count <= 0)
                return null;

            return new GuestModel(dt.Rows[0]);
        }

        public GuestModel createAndReturn(string name)
        {
            string query = "INSERT INTO Guests(name) VALUES(@GuestName); select * from Guests where ID = scope_identity();";

            var parameter = new SqlParameter("@GuestName", SqlDbType.NVarChar) { Value = name };

            var dt = _dbContext.ExecuteQuery(query, parameter);
            if (dt == null || dt.Rows.Count <= 0)
                throw new Exception("error creating new guest");

            return new GuestModel(dt.Rows[0]);
        }

        public List<GuestModel> GetAll()
        {
            var categories = new List<GuestModel>();
            string query = "SELECT * FROM Guests";

            var dt = _dbContext.ExecuteQuery(query);

            foreach (DataRow row in dt.Rows)
                categories.Add(new GuestModel(row));

            return categories;
        }

        public bool Update(GuestModel entity)
        {
            string query = "UPDATE Guests WHERE ID = @id";
            var parameter = new SqlParameter("@id", SqlDbType.Int) { Value = entity.ID };
            return _dbContext.ExecuteNonQuery(query, parameter) > 0;
        }
    }
}
