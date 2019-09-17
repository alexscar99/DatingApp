using AutoMapper;
using DADataManager.Dtos;
using DADataManager.Models;
using System.Linq;

namespace DADataManager.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, UserForListDto>()
                .ForMember(dest => dest.PhotoUrl, options =>
                    options.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url))
                .ForMember(dest => dest.Age, options => 
                    options.MapFrom(src => src.DateOfBirth.CalculateAge()));
            CreateMap<User, UserForDetailedDto>()
                .ForMember(dest => dest.PhotoUrl, options =>
                    options.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url))
                .ForMember(dest => dest.Age, options =>
                    options.MapFrom(src => src.DateOfBirth.CalculateAge()));
            CreateMap<PhotoForDetailedDto, PhotosForDetailedDto>();
        }
    }
}
