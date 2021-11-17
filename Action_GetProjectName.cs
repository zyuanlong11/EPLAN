using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Eplan Electric P8 API 的命名空间
using Eplan.EplApi.ApplicationFramework;

namespace ToolEpanAPI.EplanActions
{
    class Action_GetProjectName : IEplAction
    {
        //我们要执行的Action具体动作
        public bool Execute(ActionCallingContext oActionCallingContext)
        {
            string strProjectName = FunctionLib.Lib_ProjectFunction.GetSelectedProjectName();
            MessageBox.Show(strProjectName, "ToolEplanAPI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }

        public void GetActionProperties(ref ActionProperties actionProperties)
        {
        }

        public bool OnRegister(ref string Name, ref int Ordinal)
        {
            Name = "GetProjectName"; //Action名字，必须与我们之前设定的子菜单项设置名字一样
            Ordinal = 20;  //Action的level，通常设置为20
            return true;
        }
    }
}

