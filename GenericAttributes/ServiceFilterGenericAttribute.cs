using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

namespace GenericAttributes;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
public class ServiceFilterGenericAttribute<T> : Attribute, IFilterFactory, IOrderedFilter
{
    public int Order { get; set; }
    public bool IsReusable { get; set; }

    public IFilterMetadata CreateInstance(IServiceProvider serviceProvider)
    {
        if (serviceProvider == null)
        {
            throw new ArgumentNullException(nameof(serviceProvider));
        }

        var filter = (IFilterMetadata)serviceProvider.GetRequiredService(typeof(T));
        if (filter is IFilterFactory filterFactory)
        {
            // Unwrap filter factories
            filter = filterFactory.CreateInstance(serviceProvider);
        }

        return filter;
    }
}




