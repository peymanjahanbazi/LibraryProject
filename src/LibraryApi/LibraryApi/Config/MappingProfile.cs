using AutoMapper;
using LibraryApi.Entities;
using LibraryApi.Models.Book;

namespace LibraryApi.Config;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<AddBookViewModel, Book>().ReverseMap();
    }
}