<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/system/employee/EmployeeFile.js此处编写
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
    import extend from "@/extension/system/employee/EmployeeFile.js";
    import { ref, defineComponent } from "vue";
    export default defineComponent({
        setup() {
            const table = ref({
                key: 'EmployeeFileId',
                footer: "Foots",
                cnName: '员工信息文件表',
                name: 'employee/EmployeeFile',
                url: "/EmployeeFile/",
                sortName: "ModifyDate"
            });
            const editFormFields = ref({});
            const editFormOptions = ref([]);
            const searchFormFields = ref({});
            const searchFormOptions = ref([]);
            const columns = ref([{field:'EmployeeFileId',title:'员工文件id',type:'string',width:110,hidden:true,readonly:true,require:true,align:'left'},
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
                       {field:'ModifyDate',title:'ModifyDate',type:'datetime',sort:true,width:150,align:'left',sort:true}]);
            const detail = ref({
                cnName: "#detailCnName",
                table: "#detailTable",
                columns: [],
                sortName: "",
                key: ""
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
