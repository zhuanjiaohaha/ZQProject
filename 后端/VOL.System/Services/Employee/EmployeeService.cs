/*
 *Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下EmployeeService与IEmployeeService中编写
 */
using VOL.System.IRepositories;
using VOL.System.IServices;
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace VOL.System.Services
{
    public partial class EmployeeService : ServiceBase<Employee, IEmployeeRepository>
    , IEmployeeService, IDependency
    {
    public static IEmployeeService Instance
    {
      get { return AutofacContainerModule.GetService<IEmployeeService>(); } }
    }
 }
