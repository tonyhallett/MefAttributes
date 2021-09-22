using System.ComponentModel;

namespace MEFAttributes
{
    public interface IOrderMetadata
    {
        [DefaultValue(int.MaxValue)]
        int Order { get; }
    }
}
