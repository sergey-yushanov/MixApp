using MixApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixApp.Services
{
    public class FieldDataStore : IDataStore<Field>
    {
        readonly List<Field> fields;

        public FieldDataStore()
        {
            fields = new List<Field>();
            // load data from database
        }

        public async Task<bool> AddItemAsync(Field field)
        {
            fields.Add(field);
            
            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Field field)
        {
            var oldField = fields.Where((Field arg) => arg.Id == field.Id).FirstOrDefault();
            fields.Remove(oldField);
            fields.Add(field);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(int id)
        {
            var oldField = fields.Where((Field arg) => arg.Id == id).FirstOrDefault();
            fields.Remove(oldField);

            return await Task.FromResult(true);
        }

        public async Task<Field> GetItemAsync(int id)
        {
            return await Task.FromResult(fields.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Field>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(fields);
        }
    }
}
