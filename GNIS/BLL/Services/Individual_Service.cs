﻿using AutoMapper;
using BLL.DTO;
using DAL;
using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class Individual_Service
    {
        public static List<Individual_CustomerDTO> Get()
        {
            var data = DataFactory.CoporateData().Get(); //List<Course> ef model

            //mapper
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<individual_customer_tbl, Individual_CustomerDTO>();
            });
            var mapper = new Mapper(config);
            var retdata = mapper.Map<List<Individual_CustomerDTO>>(data);


            return retdata;
        }
    }
}
