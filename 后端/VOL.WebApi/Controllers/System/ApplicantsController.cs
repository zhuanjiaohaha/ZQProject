/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹ApplicantsController编写
 */
using Microsoft.AspNetCore.Mvc;
using VOL.Core.Controllers.Basic;
using VOL.Entity.AttributeManager;
using VOL.Entity.DomainModels;
using VOL.System.IServices;
namespace VOL.System.Controllers
{
    [Route("api/Applicants")]
    [PermissionTable(Name = "Applicants")]
    public partial class ApplicantsController : ApiBaseController<IApplicantsService>
    {
        public ApplicantsController(IApplicantsService service)
        : base(service)
        {
        }


    }
}

