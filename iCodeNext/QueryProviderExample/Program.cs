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
