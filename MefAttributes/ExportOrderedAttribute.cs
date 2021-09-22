using System;
using System.Composition;

namespace MEFAttributes
{
    [MetadataAttribute]
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class ExportOrderedAttribute : ExportAttribute
    {
        public ExportOrderedAttribute(Type contractType,int order)
            : base(contractType)
        {
            Order = order;
        }

        public int Order { get; private set; }
    }
}
