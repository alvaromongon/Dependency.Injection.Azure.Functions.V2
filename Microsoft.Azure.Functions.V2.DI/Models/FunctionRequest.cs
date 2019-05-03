using System.Collections.Generic;

namespace Microsoft.Azure.Functions.V2.DI.Models
{
    public class FunctionRequest
    {
        public IEnumerable<KeyValuePair<string, IEnumerable<string>>> Headers { get; set; } =
            new List<KeyValuePair<string, IEnumerable<string>>>();
    }
}