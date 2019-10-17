using System.Collections.Generic;

namespace Stores {
    public class Basket<TItem> {
        public List<TItem> Items {get; set;} = new List<TItem>();
    }
}