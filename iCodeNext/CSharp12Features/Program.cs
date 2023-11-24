using CSharp12Features.CollectionExpression;
using System;
using System.Collections.Immutable;

namespace CSharp12Features;

public class Program
{
    public static void Main(string[] args)
    {
        string[] names = ["james", "jack"];
        MyCollection namesCollection = ["name_3", .. names, "name_4"];


    }
}
