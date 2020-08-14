using Microsoft.OpenApi.Models;

namespace DemoAssignmentCoreProject
{
    internal class Info : OpenApiInfo
    {
        public string version { get; set; }
        public object title { get; set; }
        public object description { get; set; }
    }
}