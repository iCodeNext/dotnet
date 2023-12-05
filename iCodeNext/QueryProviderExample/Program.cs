using QueryProviderExample;
using System.Collections;
using System.Linq.Expressions;



//Func<int, bool> Check_Func = num => num % 2 == 0;
//Check_Func(8);
//Expression<Func<int, bool>> Check_Exp = num => num % 2 == 0;

//Console.WriteLine("F");


List<User> numbers = [];
var result = numbers.Where(x => x.Id > 2).OrderBy(x => x.Name);

ApplicationDbContext context = new ApplicationDbContext();
var users = context.Users.Where(x => x.Id > 2).OrderBy(x => x.Id);


public class MyQueryable<TElement> : IQueryable<TElement>
{
    private IQueryProvider _myQueryProvider = new MyQueryProvider();
    public MyQueryable(Expression expression)
    {
        Expression = expression;
    }

    public Type ElementType => typeof(TElement);

    public Expression Expression { get; }

    public IQueryProvider Provider => _myQueryProvider;


    public IEnumerator<TElement> GetEnumerator()
    {
        return _myQueryProvider.Execute<IEnumerable<TElement>>(Expression).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}

public class MyQueryProvider : IQueryProvider
{
    public IQueryable CreateQuery(Expression expression)
    {
        throw new NotImplementedException();
    }

    public IQueryable<TElement> CreateQuery<TElement>(Expression expression)
    {
        throw new NotImplementedException();
    }

    public object Execute(Expression expression)
    {
        throw new NotImplementedException();
    }

    public TResult Execute<TResult>(Expression expression)
    {
        throw new NotImplementedException();
    }
}