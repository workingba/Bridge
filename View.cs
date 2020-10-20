/**
 * 此界面主要负责软件的界面实现功能
 */
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
    enum ButtonType { PushButton, PulldownButton, SplitButton, Combobox, RadioButtonGroup, 
        ToggleButton, TextBox, Separator
    };
    [TransactionAttribute(TransactionMode.Manual)]
    [RegenerationAttribute(RegenerationOption.Manual)]
    public class View : IExternalApplication
    {
        private const String BridgeName= "桥梁";
   
        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }

        public Result OnStartup(UIControlledApplication application)
        {
            Function functionInstance = Function.GetFunction();
            //创建RibbonTab选项卡
            application.CreateRibbonTab(BridgeName);

            //创建选择面板，并在面板上添加PushButton按钮
            RibbonPanel panel1 = application.CreateRibbonPanel(BridgeName, "选择");
            functionInstance.AddButtonIteam(ref panel1, ButtonType.PushButton.ToString(), BridgeName, "修改(MD)", @"D:\workfile\HelloWorld\bin\Debug\HelloWorld.dll", "HelloWorld.Class1", @"D:\workfile\Bridge\Img\edit.jpg", "这是一段测试text", "这是将描述一段很详细的语句");

            //创建基础面板，并在面板上添加PulldownButton按钮
            RibbonPanel panel2 = application.CreateRibbonPanel(BridgeName, "基础");
            functionInstance.AddButtonIteam(ref panel2, ButtonType.PulldownButton.ToString(), BridgeName, "柱", @"D:\workfile\Bridge\bin\Debug\Bridge.dll", "Bridge.CreateItemPillar", @"D:\workfile\Bridge\Img\Pillar.jpg", "这是一段测试text", "这是将描述一段很详细的语句");

            //创建主梁面板，并在面板上添加SplitButton按钮
            RibbonPanel panel3 = application.CreateRibbonPanel(BridgeName, "主梁体系");
            functionInstance.AddButtonIteam(ref panel3, ButtonType.SplitButton.ToString(), BridgeName, "板", @"D:\workfile\HelloWorld\bin\Debug\HelloWorld.dll", "HelloWorld.Class1", @"D:\Image\bridge\edit.jpg", "这是一段测试text", "这是将描述一段很详细的语句");
            functionInstance.AddButtonIteam(ref panel3, ButtonType.SplitButton.ToString(), BridgeName, "横梁", @"D:\workfile\HelloWorld\bin\Debug\HelloWorld.dll", "HelloWorld.Class1", @"D:\Image\bridge\edit.jpg", "这是一段测试text", "这是将描述一段很详细的语句");
            functionInstance.AddButtonIteam(ref panel3, ButtonType.SplitButton.ToString(), BridgeName, "纵梁", @"D:\workfile\HelloWorld\bin\Debug\HelloWorld.dll", "HelloWorld.Class1", @"D:\Image\bridge\edit.jpg", "这是一段测试text", "这是将描述一段很详细的语句");

            //创建索塔体系面板，并在面板上添加SplitButton按钮
            RibbonPanel panel4 = application.CreateRibbonPanel(BridgeName, "索塔体系");
            functionInstance.AddButtonIteam(ref panel4, ButtonType.SplitButton.ToString(), BridgeName, "斜拉索", @"D:\workfile\HelloWorld\bin\Debug\HelloWorld.dll", "HelloWorld.Class1", @"D:\Image\bridge\edit.jpg", "这是一段测试text", "这是将描述一段很详细的语句");
            functionInstance.AddButtonIteam(ref panel4, ButtonType.SplitButton.ToString(), BridgeName, "塔座", @"D:\workfile\HelloWorld\bin\Debug\HelloWorld.dll", "HelloWorld.Class1", @"D:\Image\bridge\edit.jpg", "这是一段测试text", "这是将描述一段很详细的语句");
            functionInstance.AddButtonIteam(ref panel4, ButtonType.SplitButton.ToString(), BridgeName, "塔柱", @"D:\workfile\HelloWorld\bin\Debug\HelloWorld.dll", "HelloWorld.Class1", @"D:\Image\bridge\edit.jpg", "这是一段测试text", "这是将描述一段很详细的语句");


            //创建其他构件面板，并在面板上添加SplitButton按钮
            RibbonPanel panel5 = application.CreateRibbonPanel(BridgeName, "其他构件");
            functionInstance.AddButtonIteam(ref panel5, ButtonType.SplitButton.ToString(), BridgeName, "板", @"D:\workfile\HelloWorld\bin\Debug\HelloWorld.dll", "HelloWorld.Class1", @"D:\Image\bridge\edit.jpg", "这是一段测试text", "这是将描述一段很详细的语句");

            return Result.Succeeded;
        }

    }
}