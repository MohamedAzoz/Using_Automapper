using APP_Using__Automapper.DTOs;
using APP_Using__Automapper.Models;
using AutoMapper;

namespace APP_Using__Automapper.Automapper
{
    public class AutomapperProfile:Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Book, BookDTO>()
                .ForMember(d => d.BookId, src => src.MapFrom(s => s.Id))
                .ReverseMap();
        }
    }
}
