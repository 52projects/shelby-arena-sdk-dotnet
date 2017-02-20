using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using Shelby.Api.Attributes;

namespace Shelby.Api {
    public abstract class BaseQO {
        public BaseQO() {
            this.SearchByFields = new Dictionary<string, string>();
        }
        public Dictionary<string, string> SearchByFields { get; set; }
        public Shelby.Api.Enum.SortDirection SortDirection { get; set; } = Api.Enum.SortDirection.ASC;

        public void AddSearchByField(string field, string value) {
            if (this.SearchByFields.ContainsKey(field)) {
                throw new Exception("Field " + field + " is already part of the searc collection.");
            }
            this.SearchByFields.Add(field, value);
        }

        public void AddPagingElements(int pageIndex, int pageSize = 100) {
            this.SearchByFields.Add("pageIndex", pageIndex.ToString());
            this.SearchByFields.Add("pageSize", pageSize.ToString());
        }
    }
}