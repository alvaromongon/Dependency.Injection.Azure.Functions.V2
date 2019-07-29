using System.Collections.Generic;

namespace Dependency.Injection.Azure.Functions.V2.Models
{
    public class FunctionRequest
    {
        public IEnumerable<KeyValuePair<string, IEnumerable<string>>> Headers { get; set; } =
            new List<KeyValuePair<string, IEnumerable<string>>>();
    }
}