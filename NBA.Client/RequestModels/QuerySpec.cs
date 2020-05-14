using System;
using System.Collections.Generic;
using System.Text;

namespace NBA.Client.RequestModels
{
    public class QuerySpec
    {
        public List<string>? Fields { get; set; }

        public List<Condition> Conditions { get; set; } = new List<Condition>();
        public List<SortField> SortFields { get; set; } = new List<SortField>();
        public LogicalOperator LogicalOperator { get; set; }
        public int From { get; set; }
        public int Size { get; set; } = 100;
    }

    public class Condition
    {
        public string Field { get; set; }
        public Operator Operator { get; set; }
        public string Value { get; set; }
    }

    public class SortField
    {
        public string? Path { get; set; }
        public SortOrder? SortOrder { get; set; }

        public bool? Ascending { get; set; }
    }

    public enum Operator
    {
        EQUALS, 
        NOT_EQUALS, 
        EQUALS_IC, 
        NOT_EQUALS_IC, 
        CONTAINS, 
        NOT_CONTAINS, 
        LT, 
        LTE, 
        GT, 
        GTE, 
        BETWEEN, 
        NOT_BETWEEN, 
        IN, 
        NOT_IN, 
        MATCHES, 
        NOT_MATCHES, 
        STARTS_WITH, 
        NOT_STARTS_WITH, 
        STARTS_WITH_IC, 
        NOT_STARTS_WITH_IC
    }

    public enum LogicalOperator
    {
        AND,
        OR
    }

    public enum SortOrder
    {
        ASC,
        DESC
    }

}
