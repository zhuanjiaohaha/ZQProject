
let viewgird = [
  {
    path: '/Sys_Log',
    name: 'sys_Log',
    component: () => import('@/views/system/Sys_Log.vue')
  },
  {
    path: '/Sys_User',
    name: 'Sys_User',
    component: () => import('@/views/system/Sys_User.vue')
  },
  {
    path: '/permission',
    name: 'permission',
    component: () => import('@/views/system/Permission.vue')
  },

  {
    path: '/Sys_Dictionary',
    name: 'Sys_Dictionary',
    component: () => import('@/views/system/Sys_Dictionary.vue')
  },
  {
    path: '/Sys_Role',
    name: 'Sys_Role',
    component: () => import('@/views/system/Sys_Role.vue')
  }, {
    path: '/Sys_Role1',
    name: 'Sys_Role1',
    component: () => import('@/views/system/Sys_Role1.vue')
  }, {
    path: '/FormDesignOptions',
    name: 'FormDesignOptions',
    component: () => import('@/views/system/form/FormDesignOptions.vue')
  }, {
    path: '/FormCollectionObject',
    name: 'FormCollectionObject',
    component: () => import('@/views/system/form/FormCollectionObject.vue')
  }, {
    path: '/Sys_WorkFlow',
    name: 'Sys_WorkFlow',
    component: () => import('@/views/system/flow/Sys_WorkFlow.vue')
  }, {
    path: '/Sys_WorkFlowTable',
    name: 'Sys_WorkFlowTable',
    component: () => import('@/views/system/flow/Sys_WorkFlowTable.vue')
  }, {
    path: '/Sys_QuartzOptions',
    name: 'Sys_QuartzOptions',
    component: () => import('@/views/system/quartz/Sys_QuartzOptions.vue')
  }, {
    path: '/Sys_QuartzLog',
    name: 'Sys_QuartzLog',
    component: () => import('@/views/system/quartz/Sys_QuartzLog.vue')
  }, {
    path: '/Sys_Department',
    name: 'Sys_Department',
    component: () => import('@/views/system/system/Sys_Department.vue')
  }    ,{
        path: '/EmployeeFile',
        name: 'EmployeeFile',
        component: () => import('@/views/system/employee/EmployeeFile.vue')
    }    ,{
        path: '/Employee',
        name: 'Employee',
        component: () => import('@/views/system/employee/Employee.vue')
    }    ,{
        path: '/Applicants',
        name: 'Applicants',
        component: () => import('@/views/system/applicant/Applicants.vue')
    }]

export default viewgird
