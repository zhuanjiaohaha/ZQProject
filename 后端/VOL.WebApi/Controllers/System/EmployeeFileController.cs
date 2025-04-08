/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹EmployeeFileController编写
 */
using Microsoft.AspNetCore.Mvc;
using VOL.Core.Controllers.Basic;
using VOL.Entity.AttributeManager;
using VOL.System.IServices;
namespace VOL.System.Controllers
{
    [Route("api/EmployeeFile")]
    [PermissionTable(Name = "EmployeeFile")]
    public partial class EmployeeFileController : ApiBaseController<IEmployeeFileService>
    {
        public EmployeeFileController(IEmployeeFileService service)
        : base(service)
        {
        }
    }
}

