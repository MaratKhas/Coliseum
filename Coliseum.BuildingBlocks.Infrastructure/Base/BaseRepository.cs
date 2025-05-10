//using Coliseum.BuildingBlocks.Infrastructure.Repositories;
//using Microsoft.Extensions.Caching.Memory;
//using System;
//using System.Collections.Concurrent;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Coliseum.BuildingBlocks.Infrastructure.Base
//{
//    public abstract class BaseRepository<T> : IRepository<T> where T : class
//    {
//        private readonly IMemoryCache _cache;

//        public BaseRepository(IMemoryCache cache)
//        {
//            _cache = cache;
//        }

//        public Task DeleteAsync(int id)
//        {
//            _cache.Remove(id);
//        }

//        public Task<IEnumerable<T>> GetAllAsync()
//        {
//            _cache.get
//        }

//        public Task<T> GetByAsync(int id)
//        {
//            throw new NotImplementedException();
//        }

//        public Task UpdateAsync(T entity)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
