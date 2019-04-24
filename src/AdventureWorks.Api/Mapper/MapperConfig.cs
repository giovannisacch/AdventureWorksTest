using AdventureWorks.Api.ViewModels;
using AdventureWorks.Repository.Model;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureWorks.Api.Mapper
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Competidor, CompetidorViewModel>();
            CreateMap<CompetidorViewModel, Competidor>();

            CreateMap<PistaCorrida, PistaCorridaVIewModel>();
            CreateMap<PistaCorridaVIewModel, PistaCorrida>();

            CreateMap<HistoricoCorrida, HistoricoCorridaViewModel>();
            CreateMap<HistoricoCorridaViewModel, HistoricoCorrida>();


        }
    }
}
