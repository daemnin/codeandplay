﻿using CodeAndPlay.Business.Contracts;
using Ninject;
using System;
using System.Web.Http;

namespace CodeAndPlay.API.Controllers
{
    public class OrganizerController : ApiController
    {
        public IKernel kernel;

        public OrganizerController(IKernel kernel)
        {
            this.kernel = kernel;
        }

        public IHttpActionResult Get()
        {
            try
            {
                var process = kernel.Get<IOrganizerProcess>();
                var result = process.Get();
                return Ok(result);
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }
    }
}