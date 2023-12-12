using System.Linq;
using System.Collections.Generic;

namespace SqlDoc
{
    /// <remarks>
    /// This class is a pretend implementation for simplifying the question.
    /// The real implementation connects to a database, runs some SQL to describe the database
    /// and turns it into a complete object model.
    /// </remarks>
    public class Database
    {
        public IEnumerable<IDatabaseObject> Objects { get; set; } = Enumerable.Empty<IDatabaseObject>();
    }

    public interface IDatabaseObject
    {
        string Name { get; set; }
    }

    public class View : IDatabaseObject
    {
        public IEnumerable<Column> Columns { get; set; } = Enumerable.Empty<Column>();
        public IEnumerable<Table> Dependencies { get; set; } = Enumerable.Empty<Table>();
        public string Name { get; set; } = "";
    }

    public class Table : IDatabaseObject
    {
        public IEnumerable<Column> Columns { get; set; } = Enumerable.Empty<Column>();

        public string Name { get; set; } = "";

        public override string ToString()
        {
            string output = "";

            output = "Table: " + Name + "\n";
            foreach (var column in Columns)
            {
                output = output + "\t" + column.Name + " of type " + column.Name;
            }

            return output;
        }
    }

    public class Column : IDatabaseObject
    {
        public string Name { get; set; } = "";

        public string Type { get; set; } = "";
    }
}