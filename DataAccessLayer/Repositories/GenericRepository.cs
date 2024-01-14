using DataAccessLayer.Abstract;
using DataAccessLayer.Database;

namespace DataAccessLayer.Repositories;
public class GenericRepository<T> : IGenericDal<T> where T : class
{
	private readonly AppDbContext _appDbContext;

	public GenericRepository(AppDbContext appDbContext)
	{
		_appDbContext = appDbContext;
	}

	public void Add(T entity)
	{
		_appDbContext.Add(entity);
		_appDbContext.SaveChanges();
	}

	public void Delete(T entity)
	{
		_appDbContext.Remove(entity);
		_appDbContext.SaveChanges();
	}

	public List<T> GetAllList()
	{
		return _appDbContext.Set<T>().ToList();
	}

	public T GetById(int id)
	{
		return _appDbContext.Set<T>().Find(id);
	}

	public void Update(T entity)
	{
		_appDbContext.Update(entity);
		_appDbContext.SaveChanges();
	}
}