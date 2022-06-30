using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity.MayaModels
{
    public class RecordResponse
    {
        public string RecordId { get; set; }
        public List<ValidationResult> Errors { get; set; }
        public List<ValidationResult> Warnings { get; set; }
        public List<ValidationResult> Informations { get; set; }
        public bool IsOk { get; set; }
        public string Message { get; set; }
    }
}
