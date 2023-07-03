using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kashirin
{
    public class EmployeesRepository
    {
        SQLiteConnection database;
        public EmployeesRepository(string databasePath)
        {
            database = new SQLiteConnection(databasePath);
            database.CreateTable<Employees>();
        }
        public IEnumerable<Employees> GetItemsEmployee()
        {
            return database.Table<Employees>().ToList();
        }
        public Employees GetItemEmployee(int id)
        {
            return database.Get<Employees>(id);
        }
        public int DeleteItemEmployee(int id)
        {
            return database.Delete<Employees>(id);
        }
        public int SaveItemEmployee(Employees item)
        {
            if (item.IDEmployee != 0)
            {
                database.Update(item);
                return item.IDEmployee;
            }
            else
            {
                return database.Insert(item);
            }
        }
    }
}
