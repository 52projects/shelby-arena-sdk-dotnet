using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Shelby.Api.Entity {
    public class RequestCredentials {
        public ApiSession ApiSession { get; set; }
        public string BaseUrl { get; set; }
        public string ApiKey { get; set; }
        public string ApiSecret { get; set; }

        public string CreateSignature(string url) {
            // cut off the base url
            var newUrl = url.Substring(this.BaseUrl.Length);
            newUrl = this.ApiSecret + "_" + newUrl;

            return this.CalculateMD5Hash(newUrl.ToLower());
        }

        private string CalculateMD5Hash(string input) {
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.UTF8.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++) {
                sb.Append(hash[i].ToString("X2"));
            }

            return sb.ToString();
        }
    }
}
