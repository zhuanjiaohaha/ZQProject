/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果数据库字段发生变化，请在代码生器重新生成此Model
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VOL.Entity.SystemModels;

namespace VOL.Entity.DomainModels
{
    [Entity(TableCnName = "员工信息",TableName = "Employee",DetailTable =  new Type[] { typeof(EmployeeFile)},DetailTableCnName = "员工信息文件表")]
    public partial class Employee:BaseEntity
    {
        /// <summary>
       ///员工ID
       /// </summary>
       [Key]
       [Display(Name ="员工ID")]
       [MaxLength(36)]
       [Column(TypeName="uniqueidentifier")]
       [Required(AllowEmptyStrings=false)]
       public Guid EmployeeId { get; set; }

       /// <summary>
       ///真实姓名
       /// </summary>
       [Display(Name ="真实姓名")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       public string RealName { get; set; }

       /// <summary>
       ///艺名
       /// </summary>
       [Display(Name ="艺名")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       public string StageName { get; set; }

       /// <summary>
       ///性别
       /// </summary>
       [Display(Name ="性别")]
       [Column(TypeName="int")]
       public int? Sex { get; set; }

       /// <summary>
       ///名族
       /// </summary>
       [Display(Name ="名族")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       public string Nationality { get; set; }

       /// <summary>
       ///籍贯
       /// </summary>
       [Display(Name ="籍贯")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       public string NativePlace { get; set; }

       /// <summary>
       ///出生日期
       /// </summary>
       [Display(Name ="出生日期")]
       [Column(TypeName="datetime")]
       public DateTime? BirthDate { get; set; }

       /// <summary>
       ///身高
       /// </summary>
       [Display(Name ="身高")]
       [Column(TypeName="double")]
       public decimal? Height { get; set; }

       /// <summary>
       ///体重
       /// </summary>
       [Display(Name ="体重")]
       [Column(TypeName="double")]
       public decimal? Weight { get; set; }

       /// <summary>
       ///学历
       /// </summary>
       [Display(Name ="学历")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       public string Educational { get; set; }

       /// <summary>
       ///联系电话
       /// </summary>
       [Display(Name ="联系电话")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       public string Tel { get; set; }

       /// <summary>
       ///身份证号
       /// </summary>
       [Display(Name ="身份证号")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       public string IdCard { get; set; }

       /// <summary>
       ///政治面貌
       /// </summary>
       [Display(Name ="政治面貌")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       public string PoliticalStatus { get; set; }

       /// <summary>
       ///户籍地址
       /// </summary>
       [Display(Name ="户籍地址")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       public string DomicileAddress { get; set; }

       /// <summary>
       ///现居住地
       /// </summary>
       [Display(Name ="现居住地")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       public string CurrentResidence { get; set; }

       /// <summary>
       ///紧急联系人
       /// </summary>
       [Display(Name ="紧急联系人")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       public string EmergencyContact { get; set; }

       /// <summary>
       ///紧急联系人电话
       /// </summary>
       [Display(Name ="紧急联系人电话")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       public string EmergencyContactTel { get; set; }

       /// <summary>
       ///教育经历
       /// </summary>
       [Display(Name ="教育经历")]
       [MaxLength(1000)]
       [Column(TypeName="nvarchar(1000)")]
       public string EducationalExperience { get; set; }

       /// <summary>
       ///工作经历
       /// </summary>
       [Display(Name ="工作经历")]
       [MaxLength(1000)]
       [Column(TypeName="nvarchar(1000)")]
       public string WorkExperience { get; set; }

       /// <summary>
       ///个人擅长的技能（自己填写）
       /// </summary>
       [Display(Name ="个人擅长的技能（自己填写）")]
       [MaxLength(1000)]
       [Column(TypeName="nvarchar(1000)")]
       public string PersonalSkills { get; set; }

       /// <summary>
       ///意向行业
       /// </summary>
       [Display(Name ="意向行业")]
       [MaxLength(1000)]
       [Column(TypeName="nvarchar(1000)")]
       public string WantWork { get; set; }

       /// <summary>
       ///能力标签（公司对其作出的判断）
       /// </summary>
       [Display(Name ="能力标签（公司对其作出的判断）")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       public string AbilityTag { get; set; }

       /// <summary>
       ///插入时间
       /// </summary>
       [Display(Name ="插入时间")]
       [Column(TypeName="datetime")]
       public DateTime? InsertTime { get; set; }

       /// <summary>
       ///更新时间
       /// </summary>
       [Display(Name ="更新时间")]
       [Column(TypeName="datetime")]
       public DateTime? UpdateTime { get; set; }

       /// <summary>
       ///头像地址
       /// </summary>
       [Display(Name ="头像地址")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       public string HeadImgUrl { get; set; }

       /// <summary>
       ///是否真实用户（主要用于验证姓名、身份证是否一致）
       /// </summary>
       [Display(Name ="是否真实用户（主要用于验证姓名、身份证是否一致）")]
       [Column(TypeName="int")]
       public int? IsReal { get; set; }

       /// <summary>
       ///所属公司
       /// </summary>
       [Display(Name ="所属公司")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       public string Company { get; set; }

       /// <summary>
       ///所在部门
       /// </summary>
       [Display(Name ="所在部门")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       public string Department { get; set; }

       /// <summary>
       ///工作场所
       /// </summary>
       [Display(Name ="工作场所")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       public string Place { get; set; }

       /// <summary>
       ///职位
       /// </summary>
       [Display(Name ="职位")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       public string Position { get; set; }

       /// <summary>
       ///填写信息所处的阶段，第一阶段少量信息，第二阶段详细信息
       /// </summary>
       [Display(Name ="填写信息所处的阶段，第一阶段少量信息，第二阶段详细信息")]
       [Column(TypeName="int")]
       public int? WriteStep { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="CreateID")]
       [Column(TypeName="int")]
       public int? CreateID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Creator")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       public string Creator { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="CreateDate")]
       [Column(TypeName="datetime")]
       public DateTime? CreateDate { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ModifyID")]
       [Column(TypeName="int")]
       public int? ModifyID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Modifier")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       public string Modifier { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ModifyDate")]
       [Column(TypeName="datetime")]
       public DateTime? ModifyDate { get; set; }

       [Display(Name ="员工信息文件表")]
       [ForeignKey("EmployeeId")]
       public List<EmployeeFile> EmployeeFile { get; set; }

    }
}