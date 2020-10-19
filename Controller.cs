using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.Attributes;
using System.Windows.Media.Imaging;
using Autodesk.Revit.UI.Events;

namespace Bridge
{
    class Controller : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIDocument uIDocument = commandData.Application.ActiveUIDocument;
            Document doc = uIDocument.Document;
            //对选中元素进行新增操作
            //ICollection<ElementId> ids = doc.
            //对选中元素进行删除操作
            ICollection<ElementId> idsDel = doc.Delete(uIDocument.Selection.GetElementIds());
            ////对选中元素进行查找操作
            //ICollection<ElementId> ids2 = doc.Delete(uIDocument.Selection.GetElementIds());
            ////对选中元素进行修改操作
            //ICollection<ElementId> ids3 = doc.Delete(uIDocument.Selection.GetElementIds());
            return Result.Succeeded;
        }
    }
}
