using Azure;
using Azure.Data.Tables;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IBAS_menu.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly ILogger<menu> _logger2;
    public static List<menu> _menu = new List<menu>();

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        List<menu> _productionRepo;
        ILogger<menu> _logger2;
        TableClient client = new TableClient("DefaultEndpointsProtocol=https;AccountName=myibasmenurgstorage;AccountKey=iX5N7qIGT8otQcRgQB2Z+2Gv1Tec6v93MCt+a41JFFbJRlM6TrI8H24XSFHQWb9PEMp71+/HXzOb+AStDObrIg==;BlobEndpoint=https://myibasmenurgstorage.blob.core.windows.net/;QueueEndpoint=https://myibasmenurgstorage.queue.core.windows.net/;TableEndpoint=https://myibasmenurgstorage.table.core.windows.net/;FileEndpoint=https://myibasmenurgstorage.file.core.windows.net/;", "canteenmenu");
        TableServiceClient serviceClient = new TableServiceClient("DefaultEndpointsProtocol=https;AccountName=myibasmenurgstorage;AccountKey=iX5N7qIGT8otQcRgQB2Z+2Gv1Tec6v93MCt+a41JFFbJRlM6TrI8H24XSFHQWb9PEMp71+/HXzOb+AStDObrIg==;BlobEndpoint=https://myibasmenurgstorage.blob.core.windows.net/;QueueEndpoint=https://myibasmenurgstorage.queue.core.windows.net/;TableEndpoint=https://myibasmenurgstorage.table.core.windows.net/;FileEndpoint=https://myibasmenurgstorage.file.core.windows.net/;");
        string filter = $"RowKey ne 'id-001'";

        var tableClient = new TableClient(
               new Uri("https://myibasmenurgstorage.table.core.windows.net/"),
               "canteenmenu",
               new TableSharedKeyCredential("myibasmenurgstorage", "iX5N7qIGT8otQcRgQB2Z+2Gv1Tec6v93MCt+a41JFFbJRlM6TrI8H24XSFHQWb9PEMp71+/HXzOb+AStDObrIg=="));

        Pageable<TableEntity> entities = tableClient.Query<TableEntity>(filter: filter);

        foreach (TableEntity entity in entities)
        {
            menu menu = new menu
            {
                Day = (string)entity["Weekday"],  // Assuming Time is a DateTime
                WarmMeal = (string)entity["VarmDish"],
                ColdMeal = (string)entity["ColdDish"]
            };
            _menu.Add(menu);

        }
    }

}

