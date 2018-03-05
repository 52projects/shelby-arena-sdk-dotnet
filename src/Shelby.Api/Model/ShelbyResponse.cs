using System.Net;

namespace Shelby.Api.Model {
    public interface IShelbyResponse {
        string RequestValue { get; set; }
        string JsonResponse { get; set; }
        HttpStatusCode StatusCode { get; set; }
        string ErrorMessage { get; set; }
    }
    public interface IShelbyResponse<T> : IShelbyResponse {
        T Data { get; set; }
    }

    public class ShelbyResponse : IShelbyResponse {
        public string RequestValue { get; set; }

        public string JsonResponse { get; set; }

        public HttpStatusCode StatusCode { get; set; }

        public string ErrorMessage { get; set; }
    }

    public class ShelbyResponse<T> : ShelbyResponse, IShelbyResponse<T> where T : new() {
        public T Data { get; set; }
    }
}