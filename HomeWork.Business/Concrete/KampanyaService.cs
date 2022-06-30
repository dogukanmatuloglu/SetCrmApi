using Core.Entity.MayaModels;
using HomeWork.Business.Abstract;
using HomeWork.Entity.Model;
using HomeWork.Entity.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Business.Concrete
{
    public class KampanyaService : IKampanyaService
    {
        private readonly KampanyaModel _kampanyaModel;
        private readonly ISetCrmHelper _helper;
        public KampanyaService(KampanyaModel kampanyaModel,ISetCrmHelper helper)
        {
            _kampanyaModel = kampanyaModel; 
            _helper = helper;   
        }

        public async Task StartAsync(KampanyaInputModel input)
        {
            var apiRequestModel = new RecordRequestParameters()
            {
                CustomObjectId = _kampanyaModel.KAMPANYA_CUSTOM_OBJECTID,
                IsForcingSave = false,
                FieldsValues = new Dictionary<string, object>(),
            };

            apiRequestModel.FieldsValues.Add(_kampanyaModel.KAMPANYA_ADI, input.Adi);
            apiRequestModel.FieldsValues.Add(_kampanyaModel.KAMPANYA_TURU, input.KampanyaTuru);

            await _helper.PostRecordAsync(apiRequestModel);
        }
    }
}
