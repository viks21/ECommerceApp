using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Data
{
    public class StoreContextSeed
    {
        public static async Task SeedAsync(StoreContext context, ILoggerFactory logger)
        {
            try
            {
                if(!context.ProductBrand.Any())  
                {
                    var brandsData = File.ReadAllText("../InfraStructure/Data/SeedData/brands.json");

                    var brands = JsonSerializer.Deserialize<List<ProductBrand>>(brandsData);

                    foreach (var item in brands)
                    {   
                          context.ProductBrand.Add(item);  
                    }   

                    await context.SaveChangesAsync();

                } 

                if(!context.ProductTypes.Any())  
                {
                    var typesData = File.ReadAllText("../InfraStructure/Data/SeedData/types.json");

                    var types = JsonSerializer.Deserialize<List<ProductType>>(typesData);

                    foreach (var item in types)
                    {   
                          context.ProductTypes.Add(item);  
                    }   

                    await context.SaveChangesAsync();

                } 

                if(!context.Products.Any())  
                {
                    var productsData = File.ReadAllText("../InfraStructure/Data/SeedData/products.json");

                    var products = JsonSerializer.Deserialize<List<Products>>(productsData);

                    foreach (var item in products)
                    {   
                          context.Products.Add(item);  
                    }   

                    await context.SaveChangesAsync();

                } 
            }

            catch(Exception ex)
            {
                var logger1 = logger.CreateLogger<StoreContextSeed>();
                logger1.LogError(ex.Message);
            }


        }
    }
}