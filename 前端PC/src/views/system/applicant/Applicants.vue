<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/system/applicant/Applicants.js此处编写
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
    import extend from "@/extension/system/applicant/Applicants.js";
    import { ref, defineComponent } from "vue";
    export default defineComponent({
        setup() {
            const table = ref({
                key: 'Id',
                footer: "Foots",
                cnName: '模卡申请',
                name: 'applicant/Applicants',
                url: "/Applicants/",
                sortName: "Id"
            });
            const editFormFields = ref({"Name":"","StageName":"","Sex":"","Age":"","Phone":"","City":"","Height":"","Weight":"","Bust":"","Waist":"","Hips":"","Occupation":"","WorkYears":"","Talents":"","CanDrink":"","Photos":"","Videos":""});
            const editFormOptions = ref([[{"title":"姓名","required":true,"field":"Name","type":"text"},
                               {"title":"艺名","field":"StageName","type":"text"}],
                              [{"title":"年龄","required":true,"field":"Age","type":"text"},
                               {"dataKey":"gender","data":[],"title":"性别","field":"Sex","type":"select"}],
                              [{"title":"联系电话","required":true,"field":"Phone","type":"phone"},
                               {"title":"现居城市","required":true,"field":"City","type":"text"}],
                              [{"title":"身高","required":true,"field":"Height","type":"text"},
                               {"title":"体重","required":true,"field":"Weight","type":"text"}],
                              [{"title":"胸围","required":true,"field":"Bust","type":"text"},
                               {"title":"腰围","required":true,"field":"Waist","type":"text"}],
                              [{"title":"臀围","required":true,"field":"Hips","type":"text"},
                               {"title":"从事职业","required":true,"field":"Occupation","type":"text"}],
                              [{"title":"工作年限","required":true,"field":"WorkYears","type":"text"}],
                              [{"title":"才艺特长","required":true,"field":"Talents","type":"textarea"}],
                              [{"dataKey":"CanDrink","data":[],"title":"能否饮酒","required":true,"field":"CanDrink","type":"select"}],
                              [{"title":"照片","field":"Photos","type":"img"}],
                              [{"title":"视频","field":"Videos","type":"file"}]]);
            const searchFormFields = ref({"Name":"","StageName":"","Sex":"","Age":[null,null],"Phone":"","City":"","Height":[null,null],"CanDrink":""});
            const searchFormOptions = ref([[{"title":"姓名","field":"Name","type":"like"},{"title":"艺名","field":"StageName","type":"like"}],[{"title":"年龄","field":"Age","type":"range"},{"dataKey":"gender","data":[],"title":"性别","field":"Sex","type":"select"}],[{"title":"联系电话","field":"Phone","type":"like"},{"title":"现居城市","field":"City","type":"like"}],[{"title":"身高","field":"Height","type":"range"},{"dataKey":"CanDrink","data":[],"title":"能否饮酒","field":"CanDrink","type":"select"}]]);
            const columns = ref([{field:'Name',title:'姓名',type:'string',width:120,require:true,align:'left',sort:true},
                       {field:'StageName',title:'艺名',type:'string',width:120,align:'left'},
                       {field:'Sex',title:'性别',type:'int',bind:{ key:'gender',data:[]},width:120,align:'left'},
                       {field:'Age',title:'年龄',type:'int',width:120,require:true,align:'left'},
                       {field:'Phone',title:'联系电话',type:'string',width:120,require:true,align:'left'},
                       {field:'City',title:'现居城市',type:'string',width:120,require:true,align:'left'},
                       {field:'Height',title:'身高',type:'int',width:120,require:true,align:'left'},
                       {field:'Weight',title:'体重',type:'int',width:120,require:true,align:'left'},
                       {field:'CanDrink',title:'能否饮酒',type:'int',bind:{ key:'CanDrink',data:[]},width:120,require:true,align:'left'},
                       {field:'Talents',title:'才艺特长',type:'string',width:120,require:true,align:'left'},
                       {field:'Id',title:'Id',type:'int',width:120,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'Photos',title:'照片',type:'img',width:120,hidden:true,align:'left'},
                       {field:'Videos',title:'视频',type:'file',width:120,hidden:true,align:'left'},
                       {field:'CreateID',title:'CreateID',type:'int',width:120,hidden:true,align:'left'},
                       {field:'Creator',title:'Creator',type:'string',width:120,hidden:true,align:'left'},
                       {field:'CreateDate',title:'CreateDate',type:'datetime',width:120,hidden:true,align:'left',sort:true},
                       {field:'ModifyID',title:'ModifyID',type:'int',width:120,hidden:true,align:'left'},
                       {field:'Modifier',title:'Modifier',type:'string',width:120,hidden:true,align:'left'},
                       {field:'ModifyDate',title:'ModifyDate',type:'datetime',width:120,hidden:true,align:'left',sort:true},
                       {field:'Bust',title:'胸围',type:'int',width:120,hidden:true,require:true,align:'left'},
                       {field:'Waist',title:'腰围',type:'int',width:120,hidden:true,require:true,align:'left'},
                       {field:'Hips',title:'臀围',type:'int',width:120,hidden:true,require:true,align:'left'},
                       {field:'Occupation',title:'从事职业',type:'string',width:120,hidden:true,require:true,align:'left'},
                       {field:'WorkYears',title:'工作年限',type:'int',width:120,hidden:true,require:true,align:'left'}]);
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
