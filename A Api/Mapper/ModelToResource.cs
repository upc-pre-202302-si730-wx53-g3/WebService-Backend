﻿using AutoMapper;
using Data.Model;
using UniqueTrip.Request;
using UniqueTrip.Response;

namespace UniqueTrip.Mapper;

public class ModelToResource : Profile
{
    public ModelToResource()
    {
        CreateMap<Representante, RepresentanteRequest>();
        CreateMap<Representante, RepresentanteResponse>();
        CreateMap<Tourist, TouristRequest>();
        CreateMap<Tourist, TouristResponse>();
        CreateMap<Answer, ResponseRequest>();
        CreateMap<Answer, ResResponse>();
        CreateMap<Activities, ActivitiesRequest>();
        CreateMap<Activities, ActivitiesResponse>();
        CreateMap<Images, ImagesRequest>();
        CreateMap<Images, ImagesResponse>();
        
        CreateMap<Favorites, FavoritesRequest>();
        CreateMap<Favorites, FavoritesResponse>();
        CreateMap<PaymentMethod, PaymentMethodRequest>();
        CreateMap<PaymentMethod, PaymentMethodResponse>();
        
    }
    
}