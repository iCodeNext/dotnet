//public class NotificationService
//{
//    public void SendEmail(string email, string reciever)
//    {
//        SmtpClient smtpClient = new SmtpClient();
//        // todo
//        Console.WriteLine("Send Email!");
//    }

//    public void SendSms(string message, string reciever)
//    {
//        HttpClient httpClient = new HttpClient();
//        //todo
//        Console.WriteLine("Send Sms!");
//    }
//}

//public class UserHandler(NotificationService notificationService)
//{
//    public void Handle()
//    {
//        notificationService.SendSms("message", "0939....");
//    }
//}


#nullable disable

//public class User
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public string Email { get; set; }
//    public Gender Gender { get; set; }
//}

//public enum Gender : byte
//{
//    Male,
//    Female
//}

//public class Person
//{
//    string name;
//    public int Age = 10;
//}

//public class Program
//{
//    public static void Main()
//    {

//        Person person = new();

//    }
//}


//public class User
//{
//    //private string name; ?

//    //public void SetName(string name)
//    //{
//    //    this.name = name;
//    //}

//    //public string GetName()
//    //{
//    //    return this.name;
//    //}

//    //public string Name
//    //{
//    //    get
//    //    {
//    //        return this.name;
//    //    }
//    //    set
//    //    {
//    //        this.name = value;
//    //    }
//    //}
//    public string Name { get; set; }
//}

//public class Notification
//{
//    public string Message { get; init; }
//}

//public class Program
//{
//    public static void Main()
//    {
//        Notification notification = new() { };
//        notification.Message = "";
//    }
//}



//Indexer

//class Sentence
//{
//    string[] words = "The quick brown fox".Split();
//    public string this[int wordNum]
//    {
//        get { return words[wordNum]; }
//        set { words[wordNum] = value; }
//    }
//}

//public class Program
//{
//    public static void Main()
//    {
//        //string message = "Nabi";
//        //var first = message[1];

//        //Sentence sentence = new();
//        //var first_word = sentence[1];
//    }
//}


//nameof
//int count = 123;
//string name = nameof(count); // name is "count"


//public static class AppSetting
//{
//    public static int Id { get; set; }
//    public static int GetId()
//    {
//        return 5;
//    }

//    public static string GetName()
//    {
//        return "";
//    }
//}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        User.GetName(); // Class-> Method
//    }
//}






//Inheritance

//public class Entity
//{
//    public int Id { get; set; }
//}

//public class User : Entity
//{
//    public string Name { get; set; }
//}

//public class Program
//{
//    public static void Main()
//    {
//        User user = new();
//        user.Id = 5;

//        Entity upcast = user;

//        Entity entity = new();

//        User downcast = entity;
//        downcast.Name.First();
//    }
//}


//public abstract class Entity
//{
//    public int Id { get; set; }
//    public virtual string GetName()
//    {
//        return "default message";
//    }

//    public abstract int GetId();
//}

//public class User : Entity
//{
//    public string Name { get; set; }

//    public override int GetId()
//    {
//        throw new NotImplementedException();
//    }

//    public override string GetName()
//    {
//        return base.GetName();
//    }
//}

public abstract class Entity
{
    public int Id { get; set; }
    public virtual string GetName()
    {
        return "default message";
    }
}

//public sealed class User : Entity
//{
//    public  override string GetName()
//    {
//        return base.GetName();
//    }
//}

//public class Employee : User
//{
//    public Employee()
//    {
//        GetName();
//    }
//}


//public abstract class Entity
//{
//    public int Id { get; set; }
//    public virtual string GetName()
//    {
//        return "default message";
//    }

//    public abstract int GetId();
//}

//public class User(string name) : Entity
//{
//    public string Name { get; set; } = name;

//    public override int GetId()
//    {
//        throw new NotImplementedException();
//    }

//    public sealed override string GetName()
//    {
//        return base.GetName();
//    }
//}

//public class Employee : User
//{
//    public Employee(string name) : base(name)
//    {
//    }
//}




//public class User
//{
//    public required string Name { get; set; }
//}

//public class Program
//{
//    public static void Main()
//    {
//        User employee = new() { };
//    }
//}


//Generic Type

//public class Stack<T>
//{
//    int position;
//    T[] data = new T[100];
//    public void Push(T obj) => data[position++] = obj;
//    public T Pop() => data[--position];
//}

//public class StringStack
//{
//    int position;
//    string[] data = new string[100];
//    public void Push(string obj) => data[position++] = obj;
//    public string Pop() => data[--position];
//}


//Delegate
//public class Program
//{
//    public static string Main()
//    {
//        Func<int, int, int> func = (int x, int y) => x + y;

//        Action<int, int> func1 = (int x, int y) => x = y;
//    }
//}

//public delegate int Calculateor(int x, int y);

//public class CalUtil
//{
//    public int Call(Calculateor calculateor)
//    {
//        return calculateor(5, 6);
//    }
//}