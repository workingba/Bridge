﻿using System;
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
    [TransactionAttribute(TransactionMode.Manual)]
    class CreateItemPillar : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            TaskDialog.Show("Test","CreateItemPillar");
            return Result.Succeeded;
        }
    }
}
