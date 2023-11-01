namespace GenericTypes
{
    public interface IEntity { }
    public class Product : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }

    public class Customer : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public abstract class EntityBase : IEntity
    {

    }

    public interface IRepository<T> where T : class, IEntity, new()
    {
        public void Create(T entity);
        public IList<T> GetAll();
        public T GetById(int id);

    }

    public interface IMath<in W, out T> where T : class, IEntity, new()
                                        where W : IComparable
    {
        public void Add(W x, W y);
        public T Get();
        /*
         * covariant: input parametre olarak kullanılabilir. Böylece söz konusu tipten miras alanlar Tip yerine kullanılabilir.
         * contravariant: metodun dönüş değeridir. Dönen değer base class'a cast edilebilir!
         */
    }
}
