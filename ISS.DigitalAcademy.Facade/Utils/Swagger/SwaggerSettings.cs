using Microsoft.OpenApi.Models;

namespace ISS.DigitalAcademy.Facade.Utils.Swagger
{
    public class SwaggerSettings
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SwaggerSettings"/> class.
        /// </summary>
        public SwaggerSettings()
        {
            Name = "ISS.DigitalAcademy.API";
            Info = new OpenApiInfo
            {
                Title = "IMD Cloud API",
                Description = "Secure IMD Cloud API allowed OAuth2 flow"
            };
        }

        /// <summary>
        /// Gets or sets document Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets swagger Info
        /// </summary>
        public OpenApiInfo Info { get; set; }

        /// <summary>
        /// Gets or sets RoutePrefix
        /// </summary>
        public string RoutePrefix { get; set; }

        /// <summary>
        /// Gets Route Prefix with tailing slash
        /// </summary>
        public string RoutePrefixWithSlash =>
            string.IsNullOrWhiteSpace(RoutePrefix)
                ? string.Empty
                : RoutePrefix + "/";
    }
}
