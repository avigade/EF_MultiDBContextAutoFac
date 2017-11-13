using GenericLib;
using IdentityAccess.Models;
using IdentityAccess.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Transactions.Models;
using Transactions.Services;

namespace DDDExample.Controllers
{
    [RoutePrefix("test")]
    public class TestController : ApiController
    {
        private readonly ITransactionService _transactService;
        private readonly IIdentityAccessService _identityService;

        public TestController(ITransactionService transServ, IIdentityAccessService identityServ)
        {
            _transactService = transServ;
            _identityService = identityServ;
        }

        [Route("trans/{id?}")]
        [HttpGet]
        public IHttpActionResult GetTransaction(int id)
        {
            Transaction transact = _transactService.GetById(1);

            return Ok(transact);
        }


        [Route("add")]
        [HttpPost]
        public IHttpActionResult AddTransaction()
        {
            Transaction transact = new Transaction() { Id = 1, TransactionRef = "ABV1235" };
            _transactService.AddTrans(transact);

            return Ok(transact);
        }



        [Route("identity/{id?}")]
        [HttpGet]
        public IHttpActionResult GetTransaction1(int id)
        {
            TezIdentity identity = _identityService.GetById(1);

            return Ok(identity);
        }


        [Route("identity/add")]
        [HttpPost]
        public IHttpActionResult AddTransaction1()
        {
            TezIdentity identity = new TezIdentity() { Id = 1, TezUserName = "Avinash" };
            _identityService.AddIdentity(identity);

            return Ok(identity);
        }
    }
}
