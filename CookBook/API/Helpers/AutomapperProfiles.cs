using API.Database;
using API.DTOs;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Helpers
{
    public class AutoMapperProfiles : Profile
    {

        public AutoMapperProfiles()
        {

            //CreateMap<AppUser, MemberDto>()
            //    .ForMember(dest => dest.PhotoUrl, opt => opt.MapFrom(src =>
            //        src.Photos.FirstOrDefault(x => x.IsMain).Url))
            //    .ForMember(dest => dest.Age, opt => opt.MapFrom(src => src.DateOfBirth.CalculateAge()));

            CreateMap<Recipe, RecipeDto>().ReverseMap();
            CreateMap<RecipeDetail, RecipeDetailInsertDto>().ReverseMap();
            CreateMap<Ingredient, IngredientDto>().ReverseMap();
            CreateMap<RecipeDetail, RecipeDetailDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<AppUser, AppUserDto>().ReverseMap();
        }
    }
}
