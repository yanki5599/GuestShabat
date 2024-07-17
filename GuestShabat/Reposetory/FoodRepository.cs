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
    internal class FoodRepository : IRepository<FoodModel>
    {
        private readonly DBContext _dbContext;

        public FoodRepository(DBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public bool Create(FoodModel entity)
        {
            string query = "INSERT INTO Food(Guest_ID, Category_ID,name)" +
                            "VALUES(@GuestId,@CatId,@foodName)";

           
            var parameters = new List<SqlParameter>(){
                new SqlParameter("@GuestId", SqlDbType.Int) { Value = entity.Guest_ID },
                new SqlParameter("@CatId", SqlDbType.Int) { Value = entity.Category_ID },
                new SqlParameter("@foodName", SqlDbType.NVarChar) { Value = entity.Name }
            };

            return _dbContext.ExecuteNonQuery(query, parameters.ToArray()) > 0;

        }

        public bool Delete(int id)
        {
            string query = "DELETE FROM Food WHERE ID = @id";

            var parameter = new SqlParameter("@id", SqlDbType.Int) { Value = id };

            return _dbContext.ExecuteNonQuery(query, parameter) > 0;
        }

        public FoodModel? FindById(int id)
        {
            string query = "SELECT * FROM Food where ID = @id";

            var parameter = new SqlParameter("@id", SqlDbType.Int) { Value = id };

            var dt = _dbContext.ExecuteQuery(query, parameter);
            if (dt.Rows.Count <= 0)
                return null;

            return new FoodModel(dt.Rows[0]);
        }

        public List<FoodModel> GetAll()
        {
            var foods = new List<FoodModel>();
            string query = "SELECT * FROM Food";

            var dt = _dbContext.ExecuteQuery(query);

            foreach (DataRow row in dt.Rows)
                foods.Add(new FoodModel(row));

            return foods;
        }

        public DataTable GetAllNameBy(CategoryModel category , GuestModel? guest = null )
        {

            string query = "SELECT f.name as [שם מאכל] FROM Food f WHERE Category_ID = @CatId" + (guest != null ? " AND Guest_ID = @GuestId" : "");

            var CatParameter = new SqlParameter("@CatId", SqlDbType.Int) { Value = category.ID };
            var GuestParameter = guest != null? new SqlParameter("@GuestId", SqlDbType.Int) { Value = guest.ID } : null;

            var dt = _dbContext.ExecuteQuery(query, CatParameter, GuestParameter);

           

            return dt;
        }

        public bool Update(FoodModel entity)
        {
            string query = "UPDATE Food WHERE ID = @id";
            var parameter = new SqlParameter("@id", SqlDbType.Int) { Value = entity.ID };
            return _dbContext.ExecuteNonQuery(query, parameter) > 0;
        }

        internal DataTable GetAllByExcept(CategoryModel category, GuestModel guest)
        {

            string query = "SELECT g.name as [שם אורח], f.name as [שם מאכל]" +  
                " FROM Guests g join Food f on g.ID = f.Guest_ID " +
                 " WHERE f.Category_ID = @CatId AND" +
                 " g.ID != @GuestId;";

            var GuestParameter = new SqlParameter("@GuestId", SqlDbType.Int) { Value = guest.ID };
            var CatParameter = new SqlParameter("@CatId", SqlDbType.Int) { Value = category.ID };
 
            return _dbContext.ExecuteQuery(query, CatParameter, GuestParameter);
        }
    }
}
