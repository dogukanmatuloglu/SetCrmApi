using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Entity.MayaModels
{
    public class PagedKeyValue
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public long ItemCount { get; set; }
        public int PageCount { get; set; }
        public bool HasPrevPage { get; set; }
        public bool HasNextPage { get; set; }
        public List<KeyValue> Items { get; set; }
    }
}
