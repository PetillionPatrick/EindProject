using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ApiKwaliteit.Models;
using ApiKwaliteit.Models.DTO;
using AutoMapper;

namespace ApiKwaliteit.App_Start
{
    public class AutoMapperConfig
    {
        public static void Initialize()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Afkeur, AfkeurDTO>();
                cfg.CreateMap<AfkeurDTO, Afkeur>();
                cfg.CreateMap<Beuk, BeukDTO>();
                cfg.CreateMap<BeukDTO, Beuk>();
                cfg.CreateMap<Machine, MachineDTO>();
                cfg.CreateMap<MachineDTO, Machine>();
                cfg.CreateMap<Operator, OperatorDTO>();
                cfg.CreateMap<OperatorDTO, Operator>();
                cfg.CreateMap<Order, OrderDTO>();
                cfg.CreateMap<OrderDTO, Order>();
                cfg.CreateMap<Status, StatusDTO>();
                cfg.CreateMap<StatusDTO, Status>();
                cfg.CreateMap<Unit, UnitDTO>();
                cfg.CreateMap<UnitDTO, Unit>();
                cfg.CreateMap<User, UserDTO>();
                cfg.CreateMap<UserDTO, User>();
                cfg.CreateMap<LineInspector, LineInspectorDTO>();
                cfg.CreateMap<LineInspectorDTO, LineInspector>();
                cfg.CreateMap<TechnischeOperator, TechnischeOperatorDTO>();
                cfg.CreateMap<TechnischeOperatorDTO, TechnischeOperator>();
            });
        }
    }
}