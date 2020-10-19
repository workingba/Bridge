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
    sealed class Function
    {
        //单例模式设计
        private static Function instance = new Function();
        private Function() { }
        public static Function GetFunction()
        {
            return instance;
        }
        //进行各种按钮的属性设置
        public void AddButtonIteam(ref RibbonPanel ribbon, string buttonType, string tabName,string buttonText,string assemblyName,string className, string largeImageuri, string toolTip, string longDescription)
        {
            
            switch (buttonType)
            {
                case "PushButton":
                    PushButtonData pbd = new PushButtonData(tabName, buttonText, assemblyName, className);//tabName可用可不用？
                    SetPushButtonAttribute(ref ribbon, pbd, largeImageuri, toolTip, longDescription);
                    break;
                case "PulldownButton":
                    PulldownButtonData pdbd = new PulldownButtonData("柱", "柱");
                    SetPulldownButtonAttribute(ref ribbon, pdbd, largeImageuri, toolTip, longDescription);

                    break;
                case "SplitButton":
                    SplitButtonData sbd = new SplitButtonData("板","板");
                    //SetButtonAttribute(pbd, largeImageuri, toolTip, longDescription);

                    break;
                case "ComboBox":
                    ComboBoxData cbd = new ComboBoxData("");
                    //SetButtonAttribute(pbd, largeImageuri, toolTip, longDescription);

                    break;
                case "RadioButtonGroup":
                    RadioButtonGroupData rbgd = new RadioButtonGroupData("");
                    //SetButtonAttribute(pbd, largeImageuri, toolTip, longDescription);

                    break;
                case "ToggleButton":
                    ToggleButtonData tbd = new ToggleButtonData("","");
                    //SetButtonAttribute(pbd, largeImageuri, toolTip, longDescription);

                    break;
                case "TextBox":
                    TextBoxData textbd = new TextBoxData("");
                    //SetButtonAttribute(pbd, largeImageuri, toolTip, longDescription);

                    break;
                default:
                    break;
            }
            
        }
        //设置PulldownButton类型的介绍信息
        public void SetPushButtonAttribute(ref RibbonPanel ribbon,PushButtonData pbd, string largeImageuri, string toolTip, string longDescription)
        {
            SetCommonAttribute(ref pbd, largeImageuri, toolTip, longDescription);
            RibbonButton ribbonButton = ribbon.AddItem(pbd) as PushButton;
        }
        public void SetCommonAttribute(ref PushButtonData pbd, string largeImageuri, string toolTip, string longDescription)
        {
            pbd.LargeImage = new BitmapImage(new Uri(largeImageuri));
            pbd.ToolTip = toolTip;
            pbd.LongDescription = longDescription;
        }
        //设置PulldownButton类型的介绍信息
        public void SetPulldownButtonAttribute(ref RibbonPanel ribbon, PulldownButtonData pdb, string largeImageuri, string toolTip, string longDescription)
        {
            PushButtonData p1 = new PushButtonData("test1","test1",@"D:\workfile\HelloWorld\bin\Debug\HelloWorld.dll", "HelloWorld.Class1");
            PushButtonData p2 = new PushButtonData("test2","test2",@"D:\workfile\HelloWorld\bin\Debug\HelloWorld.dll", "HelloWorld.Class1");
            PushButtonData p3 = new PushButtonData("test3","test3",@"D:\workfile\HelloWorld\bin\Debug\HelloWorld.dll", "HelloWorld.Class1");
            pdb.LargeImage = new BitmapImage(new Uri(largeImageuri));
            pdb.ToolTip = toolTip;
            pdb.LongDescription = longDescription;
            PulldownButton pulldown = ribbon.AddItem(pdb) as PulldownButton;
            //在PulldownButton中添加PushButton
            SetCommonAttribute(ref p1, largeImageuri,toolTip,longDescription);//后面根据需求不是使用这几个参数，单独增加参数
            SetCommonAttribute(ref p2, largeImageuri, toolTip, longDescription);//后面根据需求不是使用这几个参数，单独增加参数
            SetCommonAttribute(ref p3, largeImageuri, toolTip, longDescription);//后面根据需求不是使用这几个参数，单独增加参数
            pulldown.AddPushButton(p1);
            pulldown.AddPushButton(p2);
            pulldown.AddPushButton(p3);
            
        }
        //设置PulldownButton类型的介绍信息
        public void SetSplitButtonAttribute(SplitButton p, string largeImageuri, string toolTip, string longDescription)
        {

        }
        //设置PulldownButton类型的介绍信息
        public void SetComboboxAttribute(ComboBox p, string largeImageuri, string toolTip, string longDescription)
        {

            //p.LargeImage = new BitmapImage(new Uri(largeImageuri));
            p.ToolTip = toolTip;
            p.LongDescription = longDescription;
        }
        //设置PulldownButton类型的介绍信息
        public void SetRadioButtonGroupAttribute(RadioButtonGroup p, string largeImageuri, string toolTip, string longDescription)
        {

            //p.LargeImage = new BitmapImage(new Uri(largeImageuri));
            p.ToolTip = toolTip;
            p.LongDescription = longDescription;
        }
        //设置PulldownButton类型的介绍信息
        public void SetToggleButtonAttribute(PulldownButton p, string largeImageuri, string toolTip, string longDescription)
        {

            p.LargeImage = new BitmapImage(new Uri(largeImageuri));
            p.ToolTip = toolTip;
            p.LongDescription = longDescription;
        }       
        //设置PulldownButton类型的介绍信息
        public void SetTextBoxAttribute(PulldownButton p, string largeImageuri, string toolTip, string longDescription)
        {

            p.LargeImage = new BitmapImage(new Uri(largeImageuri));
            p.ToolTip = toolTip;
            p.LongDescription = longDescription;
        }

        //private void closed(object sender, ComboBoxDropDownClosedEventArgs e)
        //{
        //    TaskDialog.Show("关闭", "已关闭");
        //}

        //private void change(object sender, ComboBoxCurrentChangedEventArgs e)
        //{
        //    TaskDialog.Show("修改", "已修改");
        //}
    }
}
