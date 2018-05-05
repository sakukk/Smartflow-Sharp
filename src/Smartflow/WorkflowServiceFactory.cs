﻿/*
 License: https://github.com/chengderen/Smartflow/blob/master/LICENSE 
 Home page: https://github.com/chengderen/Smartflow

 Note: to build on C# 3.0 + .NET 4.0
 Author:chengderen-237552006@qq.com
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Smartflow
{
    public class WorkflowServiceFactory:IFactory
    {
        public  IWorkflow CreateWorkflowSerivce()
        {
            return new WorkflowService();
        }
    }
}