using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;

namespace MVC_StaticFilesExample.Pages
{
    public class IndexModel : PageModel
    {
        public DateTime ServerStartTime
        {
            get
            {
                return Process.GetCurrentProcess().StartTime;
            }
        }
        public void OnGet()
        {
        }
    }
}
