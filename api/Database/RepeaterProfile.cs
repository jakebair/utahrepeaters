using AutoMapper;
using UtahRepeaters.Api.Database.Models;

namespace utahrepeaters.api.Database
{
    public class RepeaterProfile : Profile
    {
        public RepeaterProfile()
        {
            CreateMap<RawRepeater,Repeater>();
        }
    }
}