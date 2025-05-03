using System;
using GoldOctopus.Library;
using GoldOctopus.Library.Sources;
using Newtonsoft.Json;
using RestSharp;

namespace GoldOctopus.Business
{
    public class ApiBL
    {

        private static ApiBL instance;

        private readonly LogBL Log = LogBL.GetInstance();
        public static ApiBL GetInstance()
        {
            if (instance == null)
            {
                instance = new ApiBL();
                return instance;
            }

            return instance;
        }
        public SaglamogluDto GetSaglamogluData(string url)
        {
            SaglamogluDto result = null;
            var client = new RestClient(string.Format("{0}?tick={1}", url, DateTime.Now.Ticks));

            var restRequest = new RestRequest();
            restRequest.RequestFormat = DataFormat.Json;
            restRequest.Method = Method.Get;

            var response = client.Execute(restRequest);

            if (response != null && !string.IsNullOrEmpty(response.Content))
            {
                result = JsonConvert.DeserializeObject<SaglamogluDto>(response.Content, Constants.JsonSettings);
                return result;
            }

            Log.Error("ApiCallError", response.ErrorException);
            throw response.ErrorException;
        }

        public T GetDataFromSource<T>(string url)
        {

            T result = default(T);
            var client = new RestClient(string.Format("{0}?tick={1}", url, DateTime.Now.Ticks));

            var restRequest = new RestRequest();
            restRequest.RequestFormat = DataFormat.Json;
            restRequest.Method = Method.Get;

            var response = client.Execute(restRequest);

            if (response != null && !string.IsNullOrEmpty(response.Content))
            {
                result = JsonConvert.DeserializeObject<T>(response.Content, Constants.JsonSettings);
                return result;
            }

            Log.Error("ApiCallError", response.ErrorException);
            throw response.ErrorException;


        }


        public string GetRawDataFromSource(string url)
        {

            var client = new RestClient(string.Format("{0}?tick={1}", url, DateTime.Now.Ticks));

            var restRequest = new RestRequest();
            restRequest.RequestFormat = DataFormat.Json;
            restRequest.Method = Method.Get;

            var response = client.Execute(restRequest);

            if (response != null && !string.IsNullOrEmpty(response.Content))
            {
                return response.Content;
            }

            Log.Error("ApiCallError", response.ErrorException);
            throw response.ErrorException;
        }

    }
}