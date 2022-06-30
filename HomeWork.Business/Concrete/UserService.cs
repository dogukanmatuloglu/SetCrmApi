using HomeWork.Business.Abstract;
using HomeWork.Entity.MayaModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Business.Concrete
{
    public class UserService : IUserService
    {
        private ISetCrmHelper _crmHelper;

        public UserService(ISetCrmHelper crmHelper)
        {
            _crmHelper = crmHelper;
        }

        public async Task<PagedKeyValue> StartAsync(string userId)
        {
          return await _crmHelper.GetUserRecordAsync(userId);
        }
    }
}
