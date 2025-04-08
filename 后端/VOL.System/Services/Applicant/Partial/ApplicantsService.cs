/*
 *所有关于Applicants类的业务代码应在此处编写
*可使用repository.调用常用方法，获取EF/Dapper等信息
*如果需要事务请使用repository.DbContextBeginTransaction
*也可使用DBServerProvider.手动获取数据库相关信息
*用户信息、权限、角色等使用UserContext.Current操作
*ApplicantsService对增、删、改查、导入、导出、审核业务代码扩展参照ServiceFunFilter
*/
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;
using System.Linq;
using VOL.Core.Utilities;
using System.Linq.Expressions;
using VOL.Core.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using VOL.System.IRepositories;
using System.Collections.Generic;
using VOL.Core.ManageUser;

namespace VOL.System.Services
{
    public partial class ApplicantsService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IApplicantsRepository _repository;//访问数据库

        [ActivatorUtilitiesConstructor]
        public ApplicantsService(
            IApplicantsRepository dbRepository,
            IHttpContextAccessor httpContextAccessor
            )
        : base(dbRepository)
        {
            _httpContextAccessor = httpContextAccessor;
            _repository = dbRepository;
            //多租户会用到这init代码，其他情况可以不用
            //base.Init(dbRepository);
        }

        public override PageGridData<Applicants> GetPageData(PageDataOptions options)
        {
            

            return base.GetPageData(options);
        }

        public override WebResponseContent Add(SaveModel saveDataModel)
        {
            return base.Add(saveDataModel);
        }

        public override WebResponseContent Del(object[] keys, bool delList = true)
        {
            return base.Del(keys, delList);
        }

        public override WebResponseContent DownLoadTemplate()
        {
            return base.DownLoadTemplate();
        }

        public override object GetDetailPage(PageDataOptions pageData)
        {
            return base.GetDetailPage(pageData);
        }

        public override WebResponseContent Update(SaveModel saveModel)
        {
            return base.Update(saveModel);
        }

        public override WebResponseContent Upload(List<IFormFile> files)
        {
            return base.Upload(files);
        }
    }
}
