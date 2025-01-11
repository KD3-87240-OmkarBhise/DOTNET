using System.Reflection;
using AttributesLib;
using EntityLib;
namespace ORM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ORM SQL Generator");

            // Example objects
            Employee emp = new Employee { EmpNo = 1, Name = "John", Address = "123 Street", Salary = 50000, Designation = "Manager" };
            Student stu = new Student { RollNo = 101, Name = "Alice", Address = "456 Avenue", Course = "Computer Science" };

            GenerateSQL(emp);
            GenerateSQL(stu);
        }

        static void GenerateSQL<T>(T obj)
        {
            Type type = obj.GetType();
            var dataTableAttr = type.GetCustomAttribute<DataTableAttribute>();

            if (dataTableAttr == null)
            {
                Console.WriteLine($"Class {type.Name} is not marked with DataTable attribute.");
                return;
            }

            string tableName = dataTableAttr.TableName;

            // Prepare SQL
            var properties = type.GetProperties()
                                 .Where(p => p.GetCustomAttribute<UnMappedAttribute>() == null)
                                 .Where(p => p.GetCustomAttribute<DataColumnAttribute>() != null)
                                 .ToArray();

            var columns = properties.Select(p => p.GetCustomAttribute<DataColumnAttribute>().ColumnName);
            var values = properties.Select(p => $"'" + p.GetValue(obj)?.ToString()?.Replace("'", "''") + "'");

            string sql = $"INSERT INTO {tableName} ({string.Join(", ", columns)}) VALUES ({string.Join(", ", values)});";

            // Write SQL to file
            string fileName = $"{tableName}_Insert.sql";
            File.AppendAllText(fileName, sql + Environment.NewLine);

            Console.WriteLine($"SQL for {type.Name} written to {fileName}:");
            Console.WriteLine(sql);
        }
    }
}
