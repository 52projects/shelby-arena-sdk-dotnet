﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shelby.Api.Model;
using RestSharp;
using Shelby.Api.Entity;

namespace Shelby.Api {
    public abstract class ApiSet<T> : BaseApiSet<T> where T : new() {
        public ApiSet(RequestCredentials credentials)
            : base(credentials) {
        }
        
        //public virtual F1Collection<T> FindAll(int? page = null, int? pageSize = null) {
        //    var collection = new F1Collection<T>();

        //    if (string.IsNullOrWhiteSpace(ListUrl)) {
        //        throw new NotImplementedException("The property ListUrl has no value on the ApiSet.");
        //    }

        //    var request = CreateRestRequest(Method.GET, ListUrl);

        //    if (page.HasValue) {
        //        request.AddParameter("page", page.Value);
        //    }

        //    if (pageSize.HasValue) {
        //        request.AddParameter("pageSize", pageSize.Value);
        //    }

        //    var item = base.ExecuteListRequest(request);

        //    this.PopulateHeaderInformation(collection, item);
        //    collection.Items.AddRange(item.Data);

        //    return collection;
        //}

        //public virtual F1Collection<T> FindAll(string parentID) {
        //    var collection = new F1Collection<T>();

        //    if (string.IsNullOrWhiteSpace(GetChildListUrl)) {
        //        throw new NotImplementedException("The property GetChildListUrl has no value on the ApiSet.");
        //    }

        //    var request = CreateRestRequest(Method.GET, string.Format(GetChildListUrl, parentID));
        //    var item = ExecuteListRequest(request);

        //    this.PopulateHeaderInformation(collection, item);
        //    collection.Items.AddRange(item.Data);

        //    return collection;
        //}

        //public virtual F1Collection<T> FindAll(string parentID, int? page = null) {
        //    var collection = new F1Collection<T>();

        //    if (string.IsNullOrWhiteSpace(GetChildListUrl)) {
        //        throw new NotImplementedException("The property GetChildListUrl has no value on the ApiSet.");
        //    }

        //    var request = CreateRestRequest(Method.GET, string.Format(GetChildListUrl, parentID));

        //    if (page.HasValue) {
        //        request.AddParameter("page", page.Value);
        //    }
            
        //    var item = ExecuteListRequest(request);

        //    this.PopulateHeaderInformation(collection, item);
        //    collection.Items.AddRange(item.Data);

        //    return collection;
        //}

        //public virtual F1Collection<T> FindBy(BaseQO qo) {
        //    var collection = new F1Collection<T>();

        //    if (string.IsNullOrWhiteSpace(SearchUrl)) {
        //        throw new NotImplementedException("The property SearchUrl has no value on the ApiSet.");
        //    }

        //    var request = CreateRestRequest(Method.GET, SearchUrl);

        //    foreach (var pair in qo.ToDictionary()) {
        //        request.AddParameter(pair.Key, pair.Value);
        //    }

        //    var item = ExecuteListRequest(request);

        //    this.PopulateHeaderInformation(collection, item);
        //    collection.Items.AddRange(item.Data);

        //    return collection;
        //}

        //public virtual F1Collection<T> FindBy(string parentID, BaseQO qo) {
        //    var collection = new F1Collection<T>();

        //    if (string.IsNullOrWhiteSpace(SearchUrl)) {
        //        throw new NotImplementedException("The property SearchUrl has no value on the ApiSet.");
        //    }

        //    var request = CreateRestRequest(Method.GET, string.Format(SearchUrl, parentID));

        //    foreach (var pair in qo.ToDictionary()) {
        //        request.AddParameter(pair.Key, pair.Value);
        //    }

        //    var item = ExecuteListRequest(request);

        //    this.PopulateHeaderInformation(collection, item);
        //    collection.Items.AddRange(item.Data);

        //    return collection;
        //}

        //private void PopulateHeaderInformation(F1Collection<T> collection, IRestResponse response) {
        //    for (int i = 0; i < response.Headers.Count; i++) {
        //        int value = 0;

        //        if (!int.TryParse(response.Headers[i].Value.ToString(), out value)) {
        //            continue;
        //        }

        //        switch (response.Headers[i].Name) {
        //            case "X-Pagination-Current-Page":
        //                collection.CurrentPage = value;
        //                break;
        //            case "X-Pagination-Total-Count":
        //                collection.TotalCount = value;
        //                break;
        //            case "X-Pagination-Total-Pages":
        //                collection.TotalPages = value;
        //                break;
        //            case "X-Pagination-Page-Size":
        //                collection.PageSize = value;
        //                break;
        //        }
        //    }
        //}
    }
}