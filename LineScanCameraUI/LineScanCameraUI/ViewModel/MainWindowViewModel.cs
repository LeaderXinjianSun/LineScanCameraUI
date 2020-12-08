using HalconDotNet;
using HandyControl.Controls;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewROI;

namespace LineScanCameraUI.ViewModel
{
    class MainWindowViewModel : NotificationObject
    {
        #region 属性绑定
        private string version;

        public string Version
        {
            get { return version; }
            set
            {
                version = value;
                this.RaisePropertyChanged("Version");
            }
        }
        private string messageStr;

        public string MessageStr
        {
            get { return messageStr; }
            set
            {
                messageStr = value;
                this.RaisePropertyChanged("MessageStr");
            }
        }
        private bool statusCamera;

        public bool StatusCamera
        {
            get { return statusCamera; }
            set
            {
                statusCamera = value;
                this.RaisePropertyChanged("StatusCamera");
            }
        }
        private bool statusPLC;

        public bool StatusPLC
        {
            get { return statusPLC; }
            set
            {
                statusPLC = value;
                this.RaisePropertyChanged("StatusPLC");
            }
        }
        private string homePageVisibility;

        public string HomePageVisibility
        {
            get { return homePageVisibility; }
            set
            {
                homePageVisibility = value;
                this.RaisePropertyChanged("HomePageVisibility");
            }
        }
        private string parameterPageVisibility;

        public string ParameterPageVisibility
        {
            get { return parameterPageVisibility; }
            set
            {
                parameterPageVisibility = value;
                this.RaisePropertyChanged("ParameterPageVisibility");
            }
        }
        private string jogPageVisibility;

        public string JogPageVisibility
        {
            get { return jogPageVisibility; }
            set
            {
                jogPageVisibility = value;
                this.RaisePropertyChanged("JogPageVisibility");
            }
        }

        private HImage cameraIamge;

        public HImage CameraIamge
        {
            get { return cameraIamge; }
            set
            {
                cameraIamge = value;
                this.RaisePropertyChanged("CameraIamge");
            }
        }
        private bool cameraRepaint;

        public bool CameraRepaint
        {
            get { return cameraRepaint; }
            set
            {
                cameraRepaint = value;
                this.RaisePropertyChanged("CameraRepaint");
            }
        }
        private ObservableCollection<ROI> cameraROIList;

        public ObservableCollection<ROI> CameraROIList
        {
            get { return cameraROIList; }
            set
            {
                cameraROIList = value;
                this.RaisePropertyChanged("CameraROIList");
            }
        }
        private HObject cameraAppendHObject;

        public HObject CameraAppendHObject
        {
            get { return cameraAppendHObject; }
            set
            {
                cameraAppendHObject = value;
                this.RaisePropertyChanged("CameraAppendHObject");
            }
        }
        private Tuple<string, object> cameraGCStyle;

        public Tuple<string, object> CameraGCStyle
        {
            get { return cameraGCStyle; }
            set
            {
                cameraGCStyle = value;
                this.RaisePropertyChanged("CameraGCStyle");
            }
        }
        private string pLCIP;

        public string PLCIP
        {
            get { return pLCIP; }
            set
            {
                pLCIP = value;
                this.RaisePropertyChanged("PLCIP");
            }
        }
        private int pLCPort;

        public int PLCPort
        {
            get { return pLCPort; }
            set
            {
                pLCPort = value;
                this.RaisePropertyChanged("PLCPort");
            }
        }
        private double axis2Pos1;

        public double Axis2Pos1
        {
            get { return axis2Pos1; }
            set
            {
                axis2Pos1 = value;
                this.RaisePropertyChanged("Axis2Pos1");
            }
        }
        private double axis2Pos2;

        public double Axis2Pos2
        {
            get { return axis2Pos2; }
            set
            {
                axis2Pos2 = value;
                this.RaisePropertyChanged("Axis2Pos2");
            }
        }
        private double axis3Pos1;

        public double Axis3Pos1
        {
            get { return axis3Pos1; }
            set
            {
                axis3Pos1 = value;
                this.RaisePropertyChanged("Axis3Pos1");
            }
        }
        private double axis4Pos1;

        public double Axis4Pos1
        {
            get { return axis4Pos1; }
            set
            {
                axis4Pos1 = value;
                this.RaisePropertyChanged("Axis4Pos1");
            }
        }
        private double axis9Pos1;

        public double Axis9Pos1
        {
            get { return axis9Pos1; }
            set
            {
                axis9Pos1 = value;
                this.RaisePropertyChanged("Axis9Pos1");
            }
        }
        private double axis2SpeedScale;

        public double Axis2SpeedScale
        {
            get { return axis2SpeedScale; }
            set
            {
                axis2SpeedScale = value;
                this.RaisePropertyChanged("Axis2SpeedScale");
            }
        }
        private double axis3SpeedScale;

        public double Axis3SpeedScale
        {
            get { return axis3SpeedScale; }
            set
            {
                axis3SpeedScale = value;
                this.RaisePropertyChanged("Axis3SpeedScale");
            }
        }
        private double axis4SpeedScale;

        public double Axis4SpeedScale
        {
            get { return axis4SpeedScale; }
            set
            {
                axis4SpeedScale = value;
                this.RaisePropertyChanged("Axis4SpeedScale");
            }
        }
        private double axis9SpeedScale;

        public double Axis9SpeedScale
        {
            get { return axis9SpeedScale; }
            set
            {
                axis9SpeedScale = value;
                this.RaisePropertyChanged("Axis9SpeedScale");
            }
        }
        private double gPos2;

        public double GPos2
        {
            get { return gPos2; }
            set
            {
                gPos2 = value;
                this.RaisePropertyChanged("GPos2");
            }
        }
        private double gPos3;

        public double GPos3
        {
            get { return gPos3; }
            set
            {
                gPos3 = value;
                this.RaisePropertyChanged("GPos3");
            }
        }
        private double gPos4;

        public double GPos4
        {
            get { return gPos4; }
            set
            {
                gPos4 = value;
                this.RaisePropertyChanged("GPos4");
            }
        }
        private double gPos9;

        public double GPos9
        {
            get { return gPos9; }
            set
            {
                gPos9 = value;
                this.RaisePropertyChanged("GPos9");
            }
        }

        #endregion
        #region 方法绑定
        public DelegateCommand AppLoadedEventCommand { get; set; }
        public DelegateCommand<object> MenuActionCommand { get; set; }
        public DelegateCommand<object> OperateButtonCommand { get; set; }
        public DelegateCommand<object> PreviewMouseDownCommand { get; set; }
        public DelegateCommand<object> PreviewMouseUpCommand { get; set; }
        public DelegateCommand<object> AxisPosGetButtonCommand { get; set; }
        public DelegateCommand<object> AxisPosGoButtonCommand { get; set; }
        #endregion
        #region 变量
        private string iniParameterPath = System.Environment.CurrentDirectory + "\\Parameter.ini";
        private SXJLibrary.MitsubishiPLCFx5u plc;
        #endregion
        #region 构造函数
        public MainWindowViewModel()
        {
            #region 初始化参数
            Version = "20201207";
            MessageStr = "";
            HomePageVisibility = "Visible";
            ParameterPageVisibility = "Collapsed";
            JogPageVisibility = "Collapsed";
            CameraROIList = new ObservableCollection<ROI>();
            PLCIP = DXH.Ini.DXHIni.ContentReader("PLC", "IP", "192.168.3.250", iniParameterPath);
            PLCPort = int.Parse(DXH.Ini.DXHIni.ContentReader("PLC", "PORT", "502", iniParameterPath));
            plc = new SXJLibrary.MitsubishiPLCFx5u(PLCIP, PLCPort);
            plc.ConnectStateChanged += Plc_ConnectStateChanged;
            Axis2Pos1 = double.Parse(DXH.Ini.DXHIni.ContentReader("Axis2", "Axis2Pos1", "0", iniParameterPath));
            Axis2Pos2 = double.Parse(DXH.Ini.DXHIni.ContentReader("Axis2", "Axis2Pos2", "0", iniParameterPath));
            Axis2SpeedScale = double.Parse(DXH.Ini.DXHIni.ContentReader("Axis2", "Axis2SpeedScale", "0", iniParameterPath));
            Axis3Pos1 = double.Parse(DXH.Ini.DXHIni.ContentReader("Axis3", "Axis3Pos1", "0", iniParameterPath));            
            Axis3SpeedScale = double.Parse(DXH.Ini.DXHIni.ContentReader("Axis3", "Axis3SpeedScale", "0", iniParameterPath));
            Axis4Pos1 = double.Parse(DXH.Ini.DXHIni.ContentReader("Axis4", "Axis4Pos1", "0", iniParameterPath));
            Axis4SpeedScale = double.Parse(DXH.Ini.DXHIni.ContentReader("Axis4", "Axis4SpeedScale", "0", iniParameterPath));
            Axis9Pos1 = double.Parse(DXH.Ini.DXHIni.ContentReader("Axis9", "Axis9Pos1", "0", iniParameterPath));
            Axis9SpeedScale = double.Parse(DXH.Ini.DXHIni.ContentReader("Axis9", "Axis9SpeedScale", "0", iniParameterPath));
            #endregion
            #region 初始化方法
            AppLoadedEventCommand = new DelegateCommand(new Action(this.AppLoadedEventCommandExecute));
            MenuActionCommand = new DelegateCommand<object>(new Action<object>(this.MenuActionCommandExecute));
            OperateButtonCommand = new DelegateCommand<object>(new Action<object>(this.OperateButtonCommandExecute));
            PreviewMouseDownCommand = new DelegateCommand<object>(new Action<object>(this.PreviewMouseDownCommandExecute));
            PreviewMouseUpCommand = new DelegateCommand<object>(new Action<object>(this.PreviewMouseUpCommandExecute));
            AxisPosGetButtonCommand = new DelegateCommand<object>(new Action<object>(this.AxisPosGetButtonCommandExecute));
            AxisPosGoButtonCommand = new DelegateCommand<object>(new Action<object>(this.AxisPosGoButtonCommandExecute));
            #endregion
            #region 启动条件
            System.Diagnostics.Process[] myProcesses = System.Diagnostics.Process.GetProcessesByName("LineScanCameraUI");//获取指定的进程名   
            if (myProcesses.Length > 1) //如果可以获取到知道的进程名则说明已经启动
            {
                MessageBox.Show("不允许重复打开软件", "Error", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Error);
                System.Windows.Application.Current.Shutdown();
            }
            #endregion
        }

        private void AxisPosGoButtonCommandExecute(object obj)
        {
            switch (obj.ToString())
            {
                default:
                    break;
            }
        }

        private void AxisPosGetButtonCommandExecute(object obj)
        {
            switch (obj.ToString())
            {
                default:
                    break;
            }
        }

        private void PreviewMouseUpCommandExecute(object obj)
        {
            switch (obj.ToString())
            {
                default:
                    break;
            }
        }

        private void PreviewMouseDownCommandExecute(object obj)
        {
            switch (obj.ToString())
            {
                default:
                    break;
            }
        }

        private void Plc_ConnectStateChanged(object sender, bool e)
        {
            StatusPLC = e;
        }

        private void OperateButtonCommandExecute(object obj)
        {
            switch (obj.ToString())
            {
                case "0":
                    addMessage("待添加功能");
                    break;
                case "100":
                    DXH.Ini.DXHIni.WritePrivateProfileString("PLC", "IP", PLCIP, iniParameterPath);
                    DXH.Ini.DXHIni.WritePrivateProfileString("PLC", "PORT", PLCPort.ToString(), iniParameterPath);
                    addMessage("参数保存成功");
                    break;
                default:
                    break;
            }
        }

        private void MenuActionCommandExecute(object obj)
        {
            switch (obj.ToString())
            {
                case "0":
                    HomePageVisibility = "Visible";
                    ParameterPageVisibility = "Collapsed";
                    JogPageVisibility = "Collapsed";
                    break;
                case "1":
                    HomePageVisibility = "Collapsed";
                    ParameterPageVisibility = "Visible";
                    JogPageVisibility = "Collapsed";
                    break;
                case "2":
                    HomePageVisibility = "Collapsed";
                    ParameterPageVisibility = "Collapsed";
                    JogPageVisibility = "Visible";
                    break;
                default:
                    break;
            }
        }

        private void AppLoadedEventCommandExecute()
        {
            //throw new NotImplementedException();
            plc.Start();
            addMessage("软件加载完成");
        }
        #endregion
        #region 自定义函数
        private void addMessage(string str)
        {
            string[] s = MessageStr.Split('\n');
            if (s.Length > 1000)
            {
                MessageStr = "";
            }
            if (MessageStr != "")
            {
                MessageStr += "\n";
            }
            MessageStr += System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + " " + str;
        }
        #endregion
    }
}
