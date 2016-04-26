using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Configuration;

namespace VideoApp
{
    class Cognitive
    {
        private string strVideoKey = ConfigurationSettings.AppSettings["VideoKey"].ToString();

        private async Task<HttpResponseMessage> MakeRequest(string strUrl, string strContent, string strKey, string strActionMethod)
        {

            var client = new HttpClient();
            var queryString = HttpUtility.ParseQueryString(string.Empty);

            // Request headers
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", strKey);
            HttpResponseMessage response = null;

            // Request body
            byte[] byteData = Encoding.UTF8.GetBytes(strContent);

            using (var content = new ByteArrayContent(byteData))
            {
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                if (strActionMethod == "POST")
                    response = await client.PostAsync(strUrl, content);
                else if (strActionMethod == "GET")
                    response = await client.GetAsync(strUrl);
            }

            return response;
        }

        private async Task<HttpResponseMessage> MakeRequest(string strUrl, byte[] btStream, string strKey, string strActionMethod)
        {
            var client = new HttpClient();
            var queryString = HttpUtility.ParseQueryString(string.Empty);

            // Request headers
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", strKey);
            HttpResponseMessage response = null;

            using (var content = new ByteArrayContent(btStream))
            {
                content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");

                if (strActionMethod == "POST")
                    response = await client.PostAsync(strUrl, content);
                else if (strActionMethod == "GET")
                    response = await client.GetAsync(strUrl);
            }

            return response;

        }
        /// <summary>
        /// Track影片的內容
        /// </summary>
        /// <param name="strVideoUrl">要分析的影片網址</param>
        /// <param name="objResponse">回應狀態</param>
        /// <returns></returns>
        internal async Task<HttpResponseMessage> TrackingVideo(string strVideoUrl)
        {
            string strContent = "{\"url\":\"" + strVideoUrl + "\"}";
            string strUrl = "https://api.projectoxford.ai/video/v1.0/trackface";

            return await MakeRequest(strUrl, strContent, strVideoKey, "POST");
        }

        /// <summary>
        /// Track影片的內容
        /// </summary>
        /// <param name="btStream">要分析的影片內容</param>
        /// <param name="objResponse">回應狀態</param>
        /// <returns></returns>
        internal async Task<HttpResponseMessage> TrackingVideo(byte[] btStream)
        {
            string strUrl = "https://api.projectoxford.ai/video/v1.0/trackface";
            return await MakeRequest(strUrl, btStream, strVideoKey, "POST");
        }

        /// <summary>
        /// 取得指定影片目前轉換的狀態
        /// </summary>
        /// <param name="strVideoOperUrl">影片網址</param>
        /// <returns></returns>
        internal async Task<HttpResponseMessage> GetVideoOperationStatus(string strVideoOperUrl)
        {
            return await MakeRequest(strVideoOperUrl, "", strVideoKey, "GET");
        }

        /// <summary>
        /// 取得指定影片目前轉換的狀態
        /// </summary>
        /// <param name="strVideoOperUrl">影片網址</param>
        /// <returns></returns>
        internal async Task<HttpResponseMessage> GetVideoResule(string strVideoContentUrl)
        {
            return await MakeRequest(strVideoContentUrl, "", strVideoKey, "GET");
        }
    }
}
