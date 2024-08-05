using Foody.BusinessLayer.Abstract;
using Foody.BusinessLayer.Concrete;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.BusinessLayer
{
    public static class ServiceLayerExtension
    {
        public static IServiceCollection ServiceLayerExtensions(this IServiceCollection services)
        {

            services.AddScoped<IAboutService, AboutManager>();
            services.AddScoped<IAddressService, AddressManager>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<IFeatureService, FeatureManager>();
            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<IReviewService, ReviewManager>();
            services.AddScoped<ISliderService, SliderManager>();
            services.AddScoped<ISocialMediaService,SocialMediaManager>();
            services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));


            return services;
        }
    }
}
