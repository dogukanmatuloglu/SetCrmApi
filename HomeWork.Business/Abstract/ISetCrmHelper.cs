using Core.Entity.MayaModels;
using HomeWork.Entity.MayaModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Business.Abstract
{
    public interface ISetCrmHelper
    {
        Task<RecordResponse> PostRecordAsync(RecordRequestParameters input);
        Task<PagedKeyValue> GetUserRecordAsync(string userId);
    }
}
