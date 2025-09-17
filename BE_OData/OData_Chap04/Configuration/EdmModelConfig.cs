using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;
using OData_Chap04.Entity;

namespace OData_Chap04.Configuration
{
    public static class EdmModelConfig
    {
        public static IEdmModel GetEdmModel()
        {
            var builder = new ODataConventionModelBuilder();
            builder.EntitySet<Confirmed>("Confirms");
            builder.EntitySet<DailyReport>("DailyReports");
            builder.EntitySet<Death>("Deaths");
            builder.EntitySet<Recovered>("Recovereds");
            return builder.GetEdmModel();
        }
    }
}
