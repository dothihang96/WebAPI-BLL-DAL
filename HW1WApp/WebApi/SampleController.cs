using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using HW1WApp.Models;
using HW1WApp.Repository.BLL;
using HW1WApp.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HW1WApp.WebApi
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        private IMasterBLO _iMasterBLO;

        /// <summary>
        /// 注入物件
        /// </summary>
        /// <param name="iMasterBLO"></param>
        public SampleController(IMasterBLO iMasterBLO)
        {
            _iMasterBLO = iMasterBLO;
        }

        // GET: api/<controller>
        [HttpGet]
        public outUniResult Get([FromBody]Guid id)
        {
            outUniResult _outUniResult = new outUniResult();
            try
            {
                _outUniResult.StatusCode = 200;
                _outUniResult.Result = _iMasterBLO.GetMaster(id);
                _outUniResult.Error = null;
                return _outUniResult;
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }
        // GET api/<controller>
        [HttpGet]
        public outUniResult GetAll()
        {
            outUniResult _outUniResult = new outUniResult();
            try
            {
                _outUniResult.StatusCode = (int)HttpStatusCode.OK;
                _outUniResult.Result = _iMasterBLO.GetAllMasters();
                _outUniResult.Error = null;
                return _outUniResult;
            }
            catch (Exception e)
            {
                ///2.送給前端的錯誤訊息，簡單就好
                _outUniResult.StatusCode = (int)HttpStatusCode.NotFound;
                _outUniResult.Result = "發生錯誤了";
                _outUniResult.Error = null;
                throw new Exception();
            }
        }

        // POST api/<controller>
        [HttpPost]
        public outUniResult Post([FromBody]inUnitResult inUnitResult)
        {
            outUniResult _outUniResult = new outUniResult(); 
            try
            {
                _outUniResult.StatusCode = (int)HttpStatusCode.OK;
                _outUniResult.Result = _iMasterBLO.PostMasters(inUnitResult);
                _outUniResult.Error = null;
                return _outUniResult;
            }
            catch (Exception e)
            {
                ///2.送給前端的錯誤訊息，簡單就好
                _outUniResult.StatusCode = (int)HttpStatusCode.NotFound;
                _outUniResult.Result = "發生錯誤了";
                _outUniResult.Error = null;
                throw new Exception();
            }
        }

        // PUT api/<controller>/5
        [HttpPost]
        public outUniResult Put([FromBody]Master master)
        {
            outUniResult _outUniResult = new outUniResult();
            try
            {
                _outUniResult.StatusCode = (int)HttpStatusCode.OK;
                _outUniResult.Result = _iMasterBLO.PutMasters(master);
                _outUniResult.Error = null;
                return _outUniResult;
            }
            catch (Exception e)
            {
                ///2.送給前端的錯誤訊息，簡單就好
                _outUniResult.StatusCode = (int)HttpStatusCode.NotFound;
                _outUniResult.Result = "發生錯誤了";
                _outUniResult.Error = null;
                throw new Exception();
            }
        }

        // DELETE api/<controller>/5
        [HttpPost]
        public void Delete([FromBody]Master master)
        {
            outUniResult _outUniResult = new outUniResult();
            try
            {
                _iMasterBLO.DeleteMasters(master);
            }
            catch (Exception e)
            {
                ///2.送給前端的錯誤訊息，簡單就好
                _outUniResult.StatusCode = (int)HttpStatusCode.NotFound;
                _outUniResult.Result = "發生錯誤了";
                _outUniResult.Error = null;
                throw new Exception();
            }
        }
    }
}