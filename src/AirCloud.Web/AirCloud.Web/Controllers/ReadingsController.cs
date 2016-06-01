﻿using System;
using System.Linq;
using System.Web.Http;

namespace AirCloud.Web.Controllers
{
    using dto     = Domain.Entities;
    using service = Domain.Services;

    public class ReadingsController : ApiController
    {
        public ReadingsController(service::IReadingsService readingsService)
        {
            this.readingsService = readingsService;
        }
        private readonly service::IReadingsService readingsService;

        public IQueryable<dto::Reading> GetAll_LongDetails([FromUri] DateTime date, [FromUri] int take = int.MaxValue) => readingsService.GetAll_LongDetails(date: date, take: take);

        public dto::Reading Create(dto::Reading createDto) => readingsService.Create(createDto);

        public DateTime GetFirstDateWithReading() => readingsService.GetFirstDateWithEntry();

        public object GetGlobalAverages()
        {
            var globalAverages = readingsService.GetGlobalAverages();
            return new
            {
                co = globalAverages.Item1,
                voc = globalAverages.Item2
            };
        }
    }
}