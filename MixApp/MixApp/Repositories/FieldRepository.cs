using MixApp.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MixApp.Repositories
{
    public class FieldRepository
    {
        SQLiteConnection database;

        public FieldRepository(string databasePath)
        {
            database = new SQLiteConnection(databasePath);
            database.CreateTable<Field>();
        }

        public IEnumerable<Field> GetItems()
        {
            return database.Table<Field>().ToList();
        }

        public Field GetItem(int id)
        {
            return database.Get<Field>(id);
        }

        public int DeleteItem(int id)
        {
            return database.Delete<Field>(id);
        }

        public int SaveItem(Field item)
        {
            if (item.Id != 0)
            {
                database.Update(item);
                return item.Id;
            }
            else
            {
                return database.Insert(item);
            }
        }
    }
}
