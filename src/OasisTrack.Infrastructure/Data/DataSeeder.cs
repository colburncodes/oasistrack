using OasisTrack.Core.Entities;

namespace OasisTrack.Infrastructure.Data;

public static class DataSeeder
{
    public static void SeedData(AppDbContext context)
    {
        SeedRoutes(context);
        SeedStores(context);
    }
    public static void SeedRoutes(AppDbContext context)
    {
        if (!context.Routes.Any())
        {
            var routes = new List<Route>
            {
                new Route { Name = "Route 1", Description = "First Route" },
                new Route { Name = "Route 2", Description = "Second Route" }
            };
            context.Routes.AddRange(routes);
            context.SaveChanges();
        }
    }
    public static void SeedStores(AppDbContext context)
    {
        if (!context.Stores.Any())
        {
            var routes = context.Routes.ToList();
            
            context.Stores.AddRange(
                new Store
                {
                    Name = "Test Store", 
                    Address = "112 Test Road", 
                    City = "St Louis", 
                    State = "MO", 
                    ZipCode = "62034", 
                    ManagerName = "Rod Wave",
                    PhoneNumber = "314-244-5554",
                    RouteId = routes[0].Id
                },
                new Store
                {
                    Name = "Test Store #2", 
                    Address = "432 Smith Street", 
                    City = "St Charles", 
                    State = "MO", 
                    ZipCode = "63021" ,
                    ManagerName = "John Doe",
                    PhoneNumber = "314-555-5554",
                    RouteId = routes.Count > 1 ? routes[1].Id : routes[0].Id
                }
            );
            context.SaveChanges();
        }
    }
}