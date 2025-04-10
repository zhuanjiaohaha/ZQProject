/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹EmployeeController编写
 */
using Microsoft.AspNetCore.Mvc;
using VOL.Core.Controllers.Basic;
using VOL.Entity.AttributeManager;
using VOL.System.IServices;
namespace VOL.System.Controllers
{
    [Route("api/Employee")]
    [PermissionTable(Name = "Employee")]
    public partial class EmployeeController : ApiBaseController<IEmployeeService>
    {
        public EmployeeController(IEmployeeService service)
        : base(service)
        {
        }
    }
}

