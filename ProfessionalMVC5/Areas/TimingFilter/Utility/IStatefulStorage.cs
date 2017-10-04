using System;

namespace ProfessionalMVC5.Areas.TimingFilter.Utility
{
    public interface IStatefulStorage
    {
        TValue Get<TValue>(string name);
        TValue GetOrAdd<TValue>(string name, Func<TValue> valueFactory);
    }
}
