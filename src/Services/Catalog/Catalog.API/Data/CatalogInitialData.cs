namespace Catalog.API.Data
{
    public class CatalogInitialData : IInitialData
    {
        public async Task Populate(IDocumentStore store, CancellationToken cancellationToken)
        {
            using var session = store.LightweightSession();

            if (await session.Query<Product>().AnyAsync()) return;

            session.Store<Product>(GetPreconfiguredProducts());
            await session.SaveChangesAsync();
        }

        private static IEnumerable<Product> GetPreconfiguredProducts() => new List<Product>()
        { 
            new Product()
            {
                Id = Guid.NewGuid(),
                Name = "Samsung Galaxy S20",
                Category = new List<string> { "Electronics", "Mobile" },
                Description = "High performance Android phone.",
                ImageFile = "galaxy_s20.jpg",
                Price = 799.99M
            },
            new Product()
            {
                Id = Guid.NewGuid(),
                Name = "MacBook Pro",
                Category = new List<string> { "Electronics", "Laptop" },
                Description = "Apple laptop with M1 chip.",
                ImageFile = "macbook_pro.jpg",
                Price = 1499.99M
            },
            new Product()
            {
                Id = Guid.NewGuid(),
                Name = "Dell XPS 13",
                Category = new List<string> { "Electronics", "Laptop" },
                Description = "Powerful laptop for productivity and creativity.",
                ImageFile = "dell_xps13.jpg",
                Price = 1299.99M
            },
            new Product()
            {
                Id = Guid.NewGuid(),
                Name = "Sony WH-1000XM4",
                Category = new List<string> { "Electronics", "Headphones" },
                Description = "Noise-canceling wireless headphones.",
                ImageFile = "sony_wh1000xm4.jpg",
                Price = 349.99M
            },
            new Product()
            {
                Id = Guid.NewGuid(),
                Name = "GoPro HERO9",
                Category = new List<string> { "Electronics", "Camera" },
                Description = "Action camera with 5K video capabilities.",
                ImageFile = "gopro_hero9.jpg",
                Price = 449.99M
            },
            new Product()
            {
                Id = Guid.NewGuid(),
                Name = "Apple Watch Series 6",
                Category = new List<string> { "Electronics", "Wearable" },
                Description = "Smartwatch with health tracking features.",
                ImageFile = "apple_watch_series6.jpg",
                Price = 399.99M
            },
            new Product()
            {
                Id = Guid.NewGuid(),
                Name = "Amazon Echo Dot",
                Category = new List<string> { "Electronics", "Smart Home" },
                Description = "Voice-controlled smart speaker.",
                ImageFile = "echo_dot.jpg",
                Price = 49.99M
            },
            new Product()
            {
                Id = Guid.NewGuid(),
                Name = "Nikon D3500",
                Category = new List<string> { "Electronics", "Camera" },
                Description = "Entry-level DSLR camera.",
                ImageFile = "nikon_d3500.jpg",
                Price = 499.99M
            },
            new Product()
            {
                Id = Guid.NewGuid(),
                Name = "Bose SoundLink Mini",
                Category = new List<string> { "Electronics", "Speaker" },
                Description = "Portable Bluetooth speaker with deep bass.",
                ImageFile = "bose_soundlink_mini.jpg",
                Price = 199.99M
            },
            new Product()
            {
                Id = Guid.NewGuid(),
                Name = "Sony PlayStation 5",
                Category = new List<string> { "Electronics", "Gaming Console" },
                Description = "Next-gen gaming console with immersive graphics.",
                ImageFile = "ps5.jpg",
                Price = 499.99M
            },
            new Product()
            {
                Id = Guid.NewGuid(),
                Name = "Xbox Series X",
                Category = new List<string> { "Electronics", "Gaming Console" },
                Description = "High-performance gaming console by Microsoft.",
                ImageFile = "xbox_series_x.jpg",
                Price = 499.99M
            },
            new Product()
            {
                Id = Guid.NewGuid(),
                Name = "HP Spectre x360",
                Category = new List<string> { "Electronics", "Laptop" },
                Description = "Convertible laptop with touchscreen.",
                ImageFile = "hp_spectre_x360.jpg",
                Price = 1399.99M
            },
            new Product()
            {
                Id = Guid.NewGuid(),
                Name = "Canon EOS M50",
                Category = new List<string> { "Electronics", "Camera" },
                Description = "Mirrorless camera with 4K video support.",
                ImageFile = "canon_eos_m50.jpg",
                Price = 649.99M
            },
            new Product()
            {
                Id = Guid.NewGuid(),
                Name = "Fitbit Versa 3",
                Category = new List<string> { "Electronics", "Wearable" },
                Description = "Smartwatch with fitness tracking and GPS.",
                ImageFile = "fitbit_versa_3.jpg",
                Price = 229.99M
            },
            new Product()
            {
                Id = Guid.NewGuid(),
                Name = "Oculus Quest 2",
                Category = new List<string> { "Electronics", "VR Headset" },
                Description = "All-in-one virtual reality headset.",
                ImageFile = "oculus_quest_2.jpg",
                Price = 299.99M
            },
            new Product()
            {
                Id = Guid.NewGuid(),
                Name = "Samsung Galaxy Buds Pro",
                Category = new List<string> { "Electronics", "Earbuds" },
                Description = "Wireless earbuds with active noise cancellation.",
                ImageFile = "galaxy_buds_pro.jpg",
                Price = 199.99M
            },
            new Product()
            {
                Id = Guid.NewGuid(),
                Name = "Apple AirPods Pro",
                Category = new List<string> { "Electronics", "Earbuds" },
                Description = "Wireless earbuds with spatial audio.",
                ImageFile = "airpods_pro.jpg",
                Price = 249.99M
            },
            new Product()
            {
                Id = Guid.NewGuid(),
                Name = "DJI Mavic Air 2",
                Category = new List<string> { "Electronics", "Drone" },
                Description = "Compact drone with 4K video capability.",
                ImageFile = "dji_mavic_air_2.jpg",
                Price = 799.99M
            },
            new Product()
            {
                Id = Guid.NewGuid(),
                Name = "Google Nest Hub",
                Category = new List<string> { "Electronics", "Smart Home" },
                Description = "Smart display with Google Assistant.",
                ImageFile = "nest_hub.jpg",
                Price = 99.99M
            }
        };

    }
}
