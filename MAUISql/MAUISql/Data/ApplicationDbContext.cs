
using MAUISql.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MAUISql.Data
{
    public class ApplicationDbContext
    {
        private const string DbName = "MAUISql.db";
        private static string DbPath => Path.Combine(FileSystem.AppDataDirectory, DbName);


        private SQLiteAsyncConnection _connection;
        private SQLiteAsyncConnection Database =>
            (_connection ??= new SQLiteAsyncConnection(DbPath,
                SQLiteOpenFlags.Create |
                SQLiteOpenFlags.ReadWrite |
                SQLiteOpenFlags.SharedCache));

        //Tightly Couple not  use it
        //public async Task Try()
        //{
        //    await Database.CreateTableAsync<Product>();
        //    Database.Table<Product>().ToListAsync();
        //}


        private async Task CreateTableIfNotExists<TTable>() where TTable : class , new()
        {
            await Database.CreateTableAsync<TTable>();
        }
        private async Task<AsyncTableQuery<TTable>> GetTableAsync<TTable>() where TTable: class ,new()
        {
            await CreateTableIfNotExists<TTable>();
            return Database.Table<TTable>();
        }

        private async Task<TResult> Execute<TTable,TResult>(Func<Task<TResult>> action) where TTable : class, new()
        {
            await CreateTableIfNotExists<TTable>();
            return await action();
        }

        public async Task<IEnumerable<TTable>> GetAllAsync<TTable>() where TTable : class,new()
        {
            var isTableExist= await GetTableAsync<TTable>();
            return await isTableExist.ToListAsync();
        }

        public async Task<IEnumerable<TTable>> GetFilteredAsync<TTable>( Expression<Func<TTable,bool>> predicate) where TTable : class, new()
        {
            var isTableExist = await GetTableAsync<TTable>();
            return await isTableExist.Where(predicate).ToListAsync();
        }

        public async Task<TTable> GetItemByKeyAsync<TTable>(object primaryKey) where TTable : class, new()
        {
            //await CreateTableIfNotExists<TTable>();
            //return await Database.GetAsync<TTable>(primaryKey) ;
            return await Execute<TTable,TTable>(async()=> await Database.GetAsync<TTable>(primaryKey));
        }
        public async Task<bool> AddItemAsync<TTable> (TTable entiy) where TTable : class,new()
        {
            //await CreateTableIfNotExists<TTable>();
            //return await Database.InsertAsync(entiy)>0;
            return await Execute<TTable, bool>(async () => await Database.InsertAsync(entiy) > 0);
        }
        public async Task<bool>UpdateItemAsync<TTable>(TTable entiy) where TTable : class, new()
        {
            await CreateTableIfNotExists<TTable>();
            return await Database.UpdateAsync(entiy) > 0;
        }

        public async Task<bool> DeleteItemAsync<TTable>(TTable entiy) where TTable : class, new()
        {
            await CreateTableIfNotExists<TTable>();
            return await Database.DeleteAsync(entiy) > 0;
        }

        public async Task<bool> DeleteItemByKeyAsync<TTable>(object primaryKey) where TTable : class, new()
        {
            await CreateTableIfNotExists<TTable>();
            return await Database.DeleteAsync<TTable>(primaryKey) > 0;
        }
        



    }
}
