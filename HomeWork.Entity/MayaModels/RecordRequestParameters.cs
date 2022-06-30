using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity.MayaModels
{
    public class RecordRequestParameters
    {
        public string RecordId { get; set; }
        public string CustomObjectId { get; set; }

        public Dictionary<string, object> FieldsValues { get; set; }
        public bool IsForcingSave { get; set; }
    }
}
