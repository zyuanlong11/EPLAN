using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Eplan Electric P8 API需要的命名空间
using Eplan.EplApi.Base;
using Eplan.EplApi.DataModel;
using Eplan.EplApi.HEServices;

namespace ToolEpanAPI.FunctionLib
{
    class Lib_ProjectFunction
    {
        static public String GetSelectedProjectName()
        {
            SelectionSet selectionSet = new SelectionSet();
            try
            {
                return selectionSet.CurrentlyEdited.Project.ProjectFullName;
            }
            catch
            {
                return String.Empty;
            }
        }
    }
}

