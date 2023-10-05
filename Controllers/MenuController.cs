using Azure.Data.Tables;
using Microsoft.AspNetCore.Mvc;

namespace IBAS_menu.Controllers
{
    [ApiController]
    [Route("api/menu")]
    public class MenuController
    {
        private List<menu> _productionRepo;
        private readonly ILogger<menu> _logger;
        TableClient client = new TableClient("DefaultEndpointsProtocol=https;AccountName=ibasstorageaccount;AccountKey=EbusB4QydPI9A3PWX9pnNlSb72yThVBCGE1k8fH6F3DaOaeeRF4+oFE/qKkZ0gf1SHUGup7hPyzY+AStbCOzfA==;BlobEndpoint=https://ibasstorageaccount.blob.core.windows.net/;QueueEndpoint=https://ibasstorageaccount.queue.core.windows.net/;TableEndpoint=https://ibasstorageaccount.table.core.windows.net/;FileEndpoint=https://ibasstorageaccount.file.core.windows.net/;", "IBasProduction");
        TableServiceClient serviceClient = new TableServiceClient("DefaultEndpointsProtocol=https;AccountName=ibasstorageaccount;AccountKey=EbusB4QydPI9A3PWX9pnNlSb72yThVBCGE1k8fH6F3DaOaeeRF4+oFE/qKkZ0gf1SHUGup7hPyzY+AStbCOzfA==;BlobEndpoint=https://ibasstorageaccount.blob.core.windows.net/;QueueEndpoint=https://ibasstorageaccount.queue.core.windows.net/;TableEndpoint=https://ibasstorageaccount.table.core.windows.net/;FileEndpoint=https://ibasstorageaccount.file.core.windows.net/;");

    }
}
