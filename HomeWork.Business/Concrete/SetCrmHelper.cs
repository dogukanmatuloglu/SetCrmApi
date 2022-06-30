using Core.Entity.MayaModels;
using HomeWork.Business.Abstract;
using HomeWork.Entity.MayaModels;
using HomeWork.Entity.Options;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace HomeWork.Business.Concrete
{
    public class SetCrmHelper : ISetCrmHelper
    {
        private readonly MayaSettings _mayaSettings;

        public SetCrmHelper(MayaSettings mayaSettings)
        {
            _mayaSettings = mayaSettings;
        }

        public async Task<PagedKeyValue> GetUserRecordAsync(string userId)
        {
            var client = new RestClient(_mayaSettings.ApiUrl + "/v1/getuser?publicId="+userId);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", _mayaSettings.ApiKey);
            request.AddHeader("Content-Type", "application/json");
            var response=client.Execute(request);
            if (response.IsSuccessful)
            {
                var result = JsonSerializer.Deserialize<
                    >(response.Content);
                return result;
            }
            else
            {
                return null;
            }
           

        }

        public async Task<RecordResponse> PostRecordAsync(RecordRequestParameters input)
        {
            var client = new RestClient(_mayaSettings.ApiUrl + "/v1/record");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", _mayaSettings.ApiKey);
            request.AddHeader("Content-Type", "application/json");
            var body=JsonSerializer.Serialize(input);
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            var response=client.Execute(request);

            if (response.IsSuccessful)
            {
                var result = JsonSerializer.Deserialize<RecordResponse>(response.Content);
                return result;
            }
            else
            {
                throw new Exception($"Api post record failed!!!{body}");
            }


        }
    }
}
