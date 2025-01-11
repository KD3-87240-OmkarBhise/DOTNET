namespace AttributesLib
{
    [AttributeUsage(AttributeTargets.Class)]
    public class DataTableAttribute : Attribute
    {
        public string TableName { get; }

        public DataTableAttribute(string tableName)
        {
            TableName = tableName;
        }
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class DataColumnAttribute : Attribute
    {
        public string ColumnName { get; }

        public DataColumnAttribute(string columnName)
        {
            ColumnName = columnName;
        }
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class KeyColumnAttribute : Attribute { }

    [AttributeUsage(AttributeTargets.Property)]
    public class UnMappedAttribute : Attribute { }
}
