using Microsoft.EntityFrameworkCore;
using OEETest1.Data;
using OEETest1.Interface;

namespace OEETest1.Repositry
{
	public class GenericRepo<T> : IGenericRepo<T> where T : class
	{
		private readonly OEEDbContext _dbContext;

        public GenericRepo(OEEDbContext dbContext)
        {
			_dbContext = dbContext;
        }

		public async Task Add(T item)
		{
			//_dbContext.Set<T>().Add(item);
			//return _dbContext.SaveChanges();
			await _dbContext.Set<T>().AddAsync(item);
		}

		//     public async Task Add(T item)
		//=> await _dbContext.Set<T>().AddAsync(item);

		public void Delete(T item)
		{
			//_dbContext.Remove(item);
			//return _dbContext.SaveChanges();
			_dbContext.Set<T>().Remove(item);
		}

		public async Task<T> Get(int id)
			=> await _dbContext.Set<T>().FindAsync(id);
		//=> _dbContext.Set<T>().Find(id);
		

		public async Task< IEnumerable<T> > GetAll()
		{
			return await _dbContext.Set<T>().ToListAsync();
			//if (typeof (T) ==  typeof (Shift))
				//return (IEnumerable<T> await _dbContext.Shift.Include(s=> s.shifts).ToListAsync())
			//else 
				//return await _dbContext.set<T>()ToListAsync();
		}

		public void Update(T item)
		{
			//_dbContext.Update(item);
			//return _dbContext.SaveChanges();
			 
			_dbContext.Set<T>().Update(item);

		}
	}
}
