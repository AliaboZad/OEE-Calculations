namespace OEETest1.Interface
{
	public interface IGenericRepo<T> where T : class
	{
		Task< IEnumerable<T> > GetAll();
		Task<T> Get (int id);
		Task Add(T item);
		void Update(T item);
		void Delete(T item);

	}
}
