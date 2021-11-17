using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//添加Eplan Electric P8 API需要的命名空间
using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Gui;

namespace ToolEplanAPI
{
    public class ToolEplanAPI : IEplAddIn
    {
        public bool OnExit()
        {
            return true;
        }

        public bool OnInit()
        {            
            return true;
        }

        public bool OnInitGui()
        {
            //添加子菜单【获取项目名称】并关联Action名字为【GetProjectName】的Action
            Menu oMenu = new Menu();
            oMenu.AddMenuItem("获取项目名称", "GetProjectName");
            return true;
        }

        public bool OnRegister(ref bool bLoadOnStart)
        {
            bLoadOnStart = true;
            return true;
        }

        public bool OnUnregister()
        {
            //删除子菜单
            Menu oMenu = new Menu();
            oMenu.RemoveMenuItem("获取项目名称", "GetProjectName");
            return true;
        }
    }
}
