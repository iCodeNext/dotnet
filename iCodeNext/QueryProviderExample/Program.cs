using Microsoft.EntityFrameworkCore;
using QueryProviderExample;
using System.Collections;
using System.Linq.Expressions;
using System.Net.Http;

var dbContextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
    .UseSqlServer("Server=DESKTOP-TVCSFN3\\MHA;Database=iCodeNext;Trusted_Connection=True;Encrypt=false")
    .LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information)
    .EnableSensitiveDataLogging()
    .Options;
ApplicationDbContext context = new ApplicationDbContext(dbContextOptions);



Func<User, bool> Check_Func = num => num.Id > 2;

Expression<Func<int, bool>> Check_Exp = num => num > 2;

int i = 2;
Expression<Func<int, bool>> Check_Exp_withParam = num => num > i;


List<User> numbers = [];
var result = numbers.Where(x => x.Id > 2).OrderBy(x => x.Name);

int id = 2;
var shape = context.Users.Where(x => x.Id > id)
                 .OrderBy(x => x.Id)
                 .Select(x => new { x.Id, x.Name });

Console.ReadLine();


public class MyQueryable : IQueryable
{
    public Type ElementType => throw new NotImplementedException();

    public Expression Expression => throw new NotImplementedException();

    public IQueryProvider Provider => throw new NotImplementedException();

    public IEnumerator GetEnumerator()
    {
        Provider.Execute(Expression);
        return null;
    }

}











/*
 Roslyn - High level source generator
 T4 - Generate code as a template
 Expression Tree - Repsentation of Code
 Reflection.Emit - IL
  */

