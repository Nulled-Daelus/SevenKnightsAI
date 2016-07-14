using RestSharp;
using System;

namespace SevenKnightsAI.Classes
{
    internal class SlimPushbullet
    {
        private readonly string PUSHBULLET_HOST = "https://api.pushbullet.com/v2";
        public string AccessToken { get; private set; }
        private RestClient Client;

        public SlimPushbullet(string accessToken)
        {
            this.Client = new RestClient(this.PUSHBULLET_HOST);
            this.AccessToken = accessToken;
        }

        public void AppendAuthorization(RestRequest request)
        {
            string value = string.Format("Bearer {0}", this.AccessToken);
            request.AddHeader("Authorization", value);
        }

        public void PushLink(string email, string title, string body, string url, Action<IRestResponse> callback)
        {
            RestRequest restRequest = new RestRequest("pushes", Method.POST);
            this.AppendAuthorization(restRequest);
            restRequest.AddParameter("type", "note");
            restRequest.AddParameter("email", email);
            restRequest.AddParameter("title", title);
            restRequest.AddParameter("body", body);
            restRequest.AddParameter("url", url);
            this.Client.ExecuteAsync(restRequest, null);
        }

        public void PushNote(string email, string title, string body, Action<IRestResponse> callback)
        {
            RestRequest restRequest = new RestRequest("pushes", Method.POST);
            this.AppendAuthorization(restRequest);
            restRequest.AddParameter("type", "note");
            restRequest.AddParameter("email", email);
            restRequest.AddParameter("title", title);
            restRequest.AddParameter("body", body);
            this.Client.ExecuteAsync(restRequest, callback);
        }
    }
}