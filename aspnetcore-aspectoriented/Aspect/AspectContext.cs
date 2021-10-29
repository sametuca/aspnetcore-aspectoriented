using System;

namespace aspnetcore_aspectoriented.Aspect
{
    public class AspectContext
    {
        private static readonly Lazy<AspectContext> _Instance = new Lazy<AspectContext>(() => new AspectContext());

        public AspectContext()
        {

        }

        public static AspectContext Instance => _Instance.Value;

        public string MethodName { get; set; }
        public object[] Arguments { get; set; }
    }
}
