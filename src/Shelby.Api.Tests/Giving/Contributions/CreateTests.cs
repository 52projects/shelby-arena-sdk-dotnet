﻿using Shelby.Api.People.Entity;
using Shelby.Api.People.QueryObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shelby.Api;
using Shouldly;

namespace Shelby.Api.Tests.Giving.Contributions {
    [TestClass]
    public class CreateTests : ContributionBase {

        [TestInitialize]
        public override void Setup() {
            base.Setup();
            this.ShelbyRestClient.ApiSession = base.GetApiSession();
        }
        [TestMethod]
        public void integration_giving_batches_create_contribution() {
            var contribution = new Shelby.Api.Giving.Entity.Contribution {
                ContributionDate = DateTime.UtcNow,
                PersonInformation = new Api.Giving.Entity.PersonInformation {
                    FirstName = "Chad",
                    LastName = "Meyer"
                },
                 CurrencyAmount = 1.12m
            };

            contribution.ContributionFunds.Add(new Api.Giving.Entity.ContributionFund {
                Amount = 1.12m,
                FundId = 1
            });
            var response = this.ShelbyRestClient.Giving.Contributions.Create(1, contribution);
            var results = response.Data;

            results.Successful.ShouldBe(true);
        }
    }
}
