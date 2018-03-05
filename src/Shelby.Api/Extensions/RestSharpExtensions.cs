using Shelby.Api.Model;
using RestSharp;

namespace Shelby.Api.Extensions {
    public static class RestsharpExtensions {
        public static IShelbyResponse ToShelbyResponse(this IRestResponse restResponse) {
            var response = new ShelbyResponse();

            response.StatusCode = restResponse.StatusCode;
            response.JsonResponse = restResponse.Content;

            if (restResponse.StatusCode != System.Net.HttpStatusCode.OK) {
                response.ErrorMessage = restResponse.ErrorMessage;
            }

            return response;
        }

        public static IShelbyResponse<S> ToShelbyResponse<S>(this IRestResponse<S> restResponse) where S : new() {
            var response = new ShelbyResponse<S>();

            response.StatusCode = restResponse.StatusCode;
            response.JsonResponse = restResponse.Content;

            if ((int)restResponse.StatusCode >= 300) {
                response.ErrorMessage = restResponse.ErrorMessage;
            }
            else {
                response.Data = restResponse.Data;
            }
            return response;
        }

        public static IShelbyResponse<S> ToShelbyResponse<S>(this IRestResponse<S> restResponse, string requestInput) where S : new() {
            var response = restResponse.ToShelbyResponse();
            response.RequestValue = requestInput;
            return response;
        }
    }
}
