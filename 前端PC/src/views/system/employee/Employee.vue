<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/system/employee/Employee.js此处编写
 -->
<template>
    <view-grid ref="grid"
               :columns="columns"
               :detail="detail"
               :editFormFields="editFormFields"
               :editFormOptions="editFormOptions"
               :searchFormFields="searchFormFields"
               :searchFormOptions="searchFormOptions"
               :table="table"
               :extend="extend">
    </view-grid>
</template>
<script>
    import extend from "@/extension/system/employee/Employee.js";
    import { ref, defineComponent } from "vue";
    export default defineComponent({
        setup() {
            const table = ref({
                key: 'EmployeeId',
                footer: "Foots",
                cnName: '员工信息',
                name: 'employee/Employee',
                url: "/Employee/",
                sortName: "CreateDate"
            });
            const editFormFields = ref({});
            const editFormOptions = ref([]);
            const searchFormFields = ref({});
            const searchFormOptions = ref([]);
            const columns = ref([{field:'EmployeeId',title:'员工ID',type:'string',width:120,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'RealName',title:'真实姓名',type:'string',width:120,align:'left',sort:true},
                       {field:'StageName',title:'艺名',type:'string',width:120,align:'left'},
                       {field:'Sex',title:'性别',type:'int',bind:{ key:'gender',data:[]},width:120,align:'left'},
                       {field:'Nationality',title:'名族',type:'string',width:120,align:'left'},
                       {field:'NativePlace',title:'籍贯',type:'string',width:120,align:'left'},
                       {field:'BirthDate',title:'出生日期',type:'datetime',width:120,align:'left',sort:true},
                       {field:'Height',title:'身高',type:'decimal',width:120,align:'left'},
                       {field:'Weight',title:'体重',type:'decimal',width:120,align:'left'},
                       {field:'Educational',title:'学历',type:'string',width:120,align:'left'},
                       {field:'Tel',title:'联系电话',type:'string',width:120,align:'left'},
                       {field:'IdCard',title:'身份证号',type:'string',width:120,align:'left'},
                       {field:'PoliticalStatus',title:'政治面貌',type:'string',width:120,align:'left'},
                       {field:'DomicileAddress',title:'户籍地址',type:'string',width:120,align:'left'},
                       {field:'CurrentResidence',title:'现居住地',type:'string',width:120,align:'left'},
                       {field:'EmergencyContact',title:'紧急联系人',type:'string',width:120,align:'left'},
                       {field:'EmergencyContactTel',title:'紧急联系人电话',type:'string',width:120,align:'left'},
                       {field:'EducationalExperience',title:'教育经历',type:'string',width:120,align:'left'},
                       {field:'WorkExperience',title:'工作经历',type:'string',width:120,align:'left'},
                       {field:'PersonalSkills',title:'个人擅长的技能（自己填写）',type:'string',width:120,align:'left'},
                       {field:'WantWork',title:'意向行业',type:'string',width:120,align:'left'},
                       {field:'AbilityTag',title:'能力标签（公司对其作出的判断）',type:'string',width:120,align:'left'},
                       {field:'InsertTime',title:'插入时间',type:'datetime',width:120,align:'left',sort:true},
                       {field:'UpdateTime',title:'更新时间',type:'datetime',width:120,align:'left',sort:true},
                       {field:'HeadImgUrl',title:'头像地址',type:'string',width:120,align:'left'},
                       {field:'IsReal',title:'是否真实用户（主要用于验证姓名、身份证是否一致）',type:'int',width:120,align:'left'},
                       {field:'Company',title:'所属公司',type:'string',width:120,align:'left'},
                       {field:'Department',title:'所在部门',type:'string',width:120,align:'left'},
                       {field:'Place',title:'工作场所',type:'string',width:120,align:'left'},
                       {field:'Position',title:'职位',type:'string',width:120,align:'left'},
                       {field:'WriteStep',title:'填写信息所处的阶段，第一阶段少量信息，第二阶段详细信息',type:'int',bind:{ key:'WriteStep',data:[]},width:120,align:'left'},
                       {field:'CreateID',title:'CreateID',type:'int',width:120,hidden:true,align:'left'},
                       {field:'Creator',title:'Creator',type:'string',width:120,align:'left'},
                       {field:'CreateDate',title:'CreateDate',type:'datetime',width:120,align:'left',sort:true},
                       {field:'ModifyID',title:'ModifyID',type:'int',width:120,hidden:true,align:'left'},
                       {field:'Modifier',title:'Modifier',type:'string',width:120,align:'left'},
                       {field:'ModifyDate',title:'ModifyDate',type:'datetime',width:120,align:'left',sort:true}]);
            const detail = ref({
                cnName: "员工信息文件表",
                table: "EmployeeFile",
                columns: [{field:'EmployeeFileId',title:'员工文件id',type:'string',width:110,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'AddressUrl',title:'文件存储地址',type:'string',width:220,align:'left',sort:true},
                       {field:'FileType',title:'文件类型',type:'int',width:110,align:'left'},
                       {field:'EmployeeId',title:'EmployeeId',type:'string',width:110,align:'left'},
                       {field:'InsertTime',title:'InsertTime',type:'datetime',width:150,align:'left',sort:true},
                       {field:'UpdateTime',title:'UpdateTime',type:'datetime',width:150,align:'left',sort:true},
                       {field:'CreateID',title:'CreateID',type:'int',width:100,hidden:true,align:'left'},
                       {field:'Creator',title:'Creator',type:'string',width:100,align:'left'},
                       {field:'CreateDate',title:'CreateDate',type:'datetime',width:150,align:'left',sort:true},
                       {field:'ModifyID',title:'ModifyID',type:'int',width:100,hidden:true,align:'left'},
                       {field:'Modifier',title:'Modifier',type:'string',width:100,align:'left'},
                       {field:'ModifyDate',title:'ModifyDate',type:'datetime',sort:true,width:150,align:'left',sort:true}],
                sortName: "ModifyDate",
                key: "EmployeeFileId"
            });
            return {
                table,
                extend,
                editFormFields,
                editFormOptions,
                searchFormFields,
                searchFormOptions,
                columns,
                detail,
            };
        },
    });
</script>
