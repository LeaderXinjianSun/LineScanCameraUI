using HalconDotNet;
using HandyControl.Controls;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.ViewModel;
using SXJLibrary;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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
        private string pLCModeSate;

        public string PLCModeSate
        {
            get { return pLCModeSate; }
            set
            {
                pLCModeSate = value;
                this.RaisePropertyChanged("PLCModeSate");
            }
        }
        private int axis2Speed;

        public int Axis2Speed
        {
            get { return axis2Speed; }
            set
            {
                axis2Speed = value;
                this.RaisePropertyChanged("Axis2Speed");
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
        public DelegateCommand<object> AxisSetButtonCommand { get; set; }
        #endregion
        #region 变量
        private string iniParameterPath = System.Environment.CurrentDirectory + "\\Parameter.ini";
        private SXJLibrary.MitsubishiPLCFx5u plc; CameraOperate cam1 = new CameraOperate();
        private int axis2MaxVal = 1000000;
        private int axis3MaxVal = 50000;
        private int axis4MaxVal = 50000;
        private int axis9MaxVal = 50000;
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

            Axis2SpeedScale = double.Parse(DXH.Ini.DXHIni.ContentReader("Axis2", "Axis2SpeedScale", "0", iniParameterPath));
          
            Axis3SpeedScale = double.Parse(DXH.Ini.DXHIni.ContentReader("Axis3", "Axis3SpeedScale", "0", iniParameterPath));

            Axis4SpeedScale = double.Parse(DXH.Ini.DXHIni.ContentReader("Axis4", "Axis4SpeedScale", "0", iniParameterPath));

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
            AxisSetButtonCommand = new DelegateCommand<object>(new Action<object>(this.AxisSetButtonCommandExecute));
            #endregion
            #region 启动条件
            System.Diagnostics.Process[] myProcesses = System.Diagnostics.Process.GetProcessesByName("LineScanCameraUI");//获取指定的进程名   
            if (myProcesses.Length > 1) //如果可以获取到知道的进程名则说明已经启动
            {
                HandyControl.Controls.MessageBox.Show("不允许重复打开软件", "Error", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Error);
                System.Windows.Application.Current.Shutdown();
            }
            #endregion
        }

        private void AxisSetButtonCommandExecute(object obj)
        {
            switch (obj.ToString())
            {
                case "20":
                    if (HandyControl.Controls.MessageBox.Show("你确定设置轴2运行速度么？", "确认", MessageBoxButton.YesNo, MessageBoxImage.Warning, MessageBoxResult.No) == MessageBoxResult.Yes)
                    {
                        plc.WriteW("D4000", Axis2Speed);
                    }
                    break;
                default:
                    break;
            }
        }

        private void AxisPosGoButtonCommandExecute(object obj)
        {
            switch (obj.ToString())
            {
                case "20":
                    if (HandyControl.Controls.MessageBox.Show("你确定运动到点-轴2位置1-么？", "确认", MessageBoxButton.YesNo, MessageBoxImage.Warning, MessageBoxResult.No) == MessageBoxResult.Yes)
                    {
                        plc.WriteW("D4040", (int)(Axis2Pos1 * 1000));
                        DXH.Ini.DXHIni.WritePrivateProfileString("Axis2", "Axis2SpeedScale", Axis2SpeedScale.ToString("F1"), iniParameterPath);
                        plc.WriteW("D4010", (int)((double)axis2MaxVal * 0.1 * Axis2SpeedScale / 100));
                        plc.SetM("M411", true);

                    }
                    break;
                case "21":
                    if (HandyControl.Controls.MessageBox.Show("你确定运动到点-轴2位置2-么？", "确认", MessageBoxButton.YesNo, MessageBoxImage.Warning, MessageBoxResult.No) == MessageBoxResult.Yes)
                    {
                        plc.WriteW("D4040", (int)(Axis2Pos2 * 1000));
                        DXH.Ini.DXHIni.WritePrivateProfileString("Axis2", "Axis2SpeedScale", Axis2SpeedScale.ToString("F1"), iniParameterPath);
                        plc.WriteW("D4010", (int)((double)axis2MaxVal * 0.1 * Axis2SpeedScale / 100));
                        plc.SetM("M411", true);
                    }
                    break;
                case "30":
                    if (HandyControl.Controls.MessageBox.Show("你确定运动到点-轴3位置1-么？", "确认", MessageBoxButton.YesNo, MessageBoxImage.Warning, MessageBoxResult.No) == MessageBoxResult.Yes)
                    {
                        plc.WriteW("D4042", (int)(Axis3Pos1 * 200));
                        DXH.Ini.DXHIni.WritePrivateProfileString("Axis3", "Axis3SpeedScale", Axis3SpeedScale.ToString("F1"), iniParameterPath);
                        plc.WriteW("D4012", (int)((double)axis3MaxVal * 0.1 * Axis3SpeedScale / 100));
                        plc.SetM("M412", true);
                    }
                    break;
                case "40":
                    if (HandyControl.Controls.MessageBox.Show("你确定运动到点-轴4位置1-么？", "确认", MessageBoxButton.YesNo, MessageBoxImage.Warning, MessageBoxResult.No) == MessageBoxResult.Yes)
                    {
                        plc.WriteW("D4044", (int)(Axis4Pos1 * 200));
                        DXH.Ini.DXHIni.WritePrivateProfileString("Axis4", "Axis4SpeedScale", Axis4SpeedScale.ToString("F1"), iniParameterPath);
                        plc.WriteW("D4014", (int)((double)axis4MaxVal * 0.1 * Axis4SpeedScale / 100));
                        plc.SetM("M413", true);
                    }
                    break;
                case "90":
                    if (HandyControl.Controls.MessageBox.Show("你确定运动到点-轴9位置1-么？", "确认", MessageBoxButton.YesNo, MessageBoxImage.Warning, MessageBoxResult.No) == MessageBoxResult.Yes)
                    {
                        plc.WriteW("D4046", (int)(Axis9Pos1 /360 * 10000));
                        DXH.Ini.DXHIni.WritePrivateProfileString("Axis9", "Axis9SpeedScale", Axis9SpeedScale.ToString("F1"), iniParameterPath);
                        plc.WriteW("D4016", (int)((double)axis9MaxVal * 0.1 * Axis9SpeedScale / 100));
                        plc.SetM("M414", true);
                    }
                    break;
                default:
                    break;
            }
        }

        private void AxisPosGetButtonCommandExecute(object obj)
        {
            switch (obj.ToString())
            {
                case "20":
                    if (HandyControl.Controls.MessageBox.Show("你确定示教点-轴2位置1-么？", "确认", MessageBoxButton.YesNo, MessageBoxImage.Warning, MessageBoxResult.No) == MessageBoxResult.Yes)
                    {
                        Axis2Pos1 = GPos2;
                        plc.WriteW("D4026", (int)(Axis2Pos1 * 1000));
                    }
                    break;
                case "21":
                    if (HandyControl.Controls.MessageBox.Show("你确定示教点-轴2位置2-么？", "确认", MessageBoxButton.YesNo, MessageBoxImage.Warning, MessageBoxResult.No) == MessageBoxResult.Yes)                    
                    {
                        Axis2Pos2 = GPos2;
                        plc.WriteW("D4028", (int)(Axis2Pos2 * 1000));
                    }
                    break;
                case "30":
                    if (HandyControl.Controls.MessageBox.Show("你确定示教点-轴3位置1-么？", "确认", MessageBoxButton.YesNo, MessageBoxImage.Warning, MessageBoxResult.No) == MessageBoxResult.Yes)
                    {
                        Axis3Pos1 = GPos3;
                        plc.WriteW("D4020", (int)(Axis3Pos1 * 200));
                    }
                    break;
                case "40":
                    if (HandyControl.Controls.MessageBox.Show("你确定示教点-轴4位置1-么？", "确认", MessageBoxButton.YesNo, MessageBoxImage.Warning, MessageBoxResult.No) == MessageBoxResult.Yes)
                    {
                        Axis4Pos1 = GPos4;
                        plc.WriteW("D4022", (int)(Axis4Pos1 * 200));
                    }
                    break;
                case "90":
                    if (HandyControl.Controls.MessageBox.Show("你确定示教点-轴9位置1-么？", "确认", MessageBoxButton.YesNo, MessageBoxImage.Warning, MessageBoxResult.No) == MessageBoxResult.Yes)
                    {
                        Axis9Pos1 = GPos9;
                        plc.WriteW("D4024", (int)(Axis9Pos1 / 360 * 10000));
                    }
                    break;
                default:
                    break;
            }
        }

        private void PreviewMouseUpCommandExecute(object obj)
        {
            switch (obj.ToString())
            {
                case "20":                    
                    plc.SetM("M403", false);
                    break;
                case "21":                 
                    plc.SetM("M404", false);
                    break;
                case "30":
                    plc.SetM("M405", false);
                    break;
                case "31":
                    plc.SetM("M406", false);
                    break;
                case "40":
                    plc.SetM("M407", false);
                    break;
                case "41":
                    plc.SetM("M408", false);
                    break;
                case "90":
                    plc.SetM("M409", false);
                    break;
                case "91":
                    plc.SetM("M410", false);
                    break;
                case "100":
                    plc.SetM("M400", false);
                    break;
                default:
                    break;
            }
        }

        private void PreviewMouseDownCommandExecute(object obj)
        {
            switch (obj.ToString())
            {
                case "20":
                    DXH.Ini.DXHIni.WritePrivateProfileString("Axis2", "Axis2SpeedScale", Axis2SpeedScale.ToString("F1"), iniParameterPath);
                    plc.WriteW("D4010", (int)((double)axis2MaxVal * 0.1 * Axis2SpeedScale / 100));
                    plc.SetM("M403", true);
                    break;
                case "21":
                    DXH.Ini.DXHIni.WritePrivateProfileString("Axis2", "Axis2SpeedScale", Axis2SpeedScale.ToString("F1"), iniParameterPath);
                    plc.WriteW("D4010", (int)((double)axis2MaxVal * 0.1 * Axis2SpeedScale / 100));
                    plc.SetM("M404", true);
                    break;
                case "30":
                    DXH.Ini.DXHIni.WritePrivateProfileString("Axis3", "Axis3SpeedScale", Axis3SpeedScale.ToString("F1"), iniParameterPath);
                    plc.WriteW("D4012", (int)((double)axis3MaxVal * 0.1 * Axis3SpeedScale / 100));
                    plc.SetM("M405", true);
                    break;
                case "31":
                    DXH.Ini.DXHIni.WritePrivateProfileString("Axis3", "Axis3SpeedScale", Axis3SpeedScale.ToString("F1"), iniParameterPath);
                    plc.WriteW("D4012", (int)((double)axis3MaxVal * 0.1 * Axis3SpeedScale / 100));
                    plc.SetM("M406", true);
                    break;
                case "40":
                    DXH.Ini.DXHIni.WritePrivateProfileString("Axis4", "Axis4SpeedScale", Axis4SpeedScale.ToString("F1"), iniParameterPath);
                    plc.WriteW("D4014", (int)((double)axis4MaxVal * 0.1 * Axis4SpeedScale / 100));
                    plc.SetM("M407", true);
                    break;
                case "41":
                    DXH.Ini.DXHIni.WritePrivateProfileString("Axis4", "Axis4SpeedScale", Axis4SpeedScale.ToString("F1"), iniParameterPath);
                    plc.WriteW("D4014", (int)((double)axis4MaxVal * 0.1 * Axis4SpeedScale / 100));
                    plc.SetM("M408", true);
                    break;
                case "90":
                    DXH.Ini.DXHIni.WritePrivateProfileString("Axis9", "Axis9SpeedScale", Axis9SpeedScale.ToString("F1"), iniParameterPath);
                    plc.WriteW("D4016", (int)((double)axis9MaxVal * 0.1 * Axis9SpeedScale / 100));
                    plc.SetM("M409", true);
                    break;
                case "91":
                    DXH.Ini.DXHIni.WritePrivateProfileString("Axis9", "Axis9SpeedScale", Axis9SpeedScale.ToString("F1"), iniParameterPath);
                    plc.WriteW("D4016", (int)((double)axis9MaxVal * 0.1 * Axis9SpeedScale / 100));
                    plc.SetM("M410", true);
                    break;
                case "100":
                    plc.SetM("M400", true);
                    break;
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
                case "1":
                    plc.SetM("M420", true);
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
                    Axis2Pos1 = (double)plc.ReadW("D4026") / 1000;
                    Axis2Pos2 = (double)plc.ReadW("D4028") / 1000;
                    Axis3Pos1 = (double)plc.ReadW("D4020") / 200;
                    Axis4Pos1 = (double)plc.ReadW("D4022") / 200;
                    Axis9Pos1 = (double)plc.ReadW("D4024") / 10000 * 360;
                    Axis2Speed = plc.ReadW("D4000");
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
            bool rst = cam1.OpenCamera("CAM01", "GigEVision");
            if (rst)
            {
                addMessage("相机打开成功");
            }
            else
            {
                addMessage("相机打开失败");
            }
            run();
            
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
        private async void run()
        {
            bool m3000 = false, m3001 = false, m3002 = false, m3003 = false, m3004 = false, m3005 = false, m3006 = false;
            while (true)
            {
                try
                {
                    #region 读取坐标
                    await Task.Run(() =>
                    {
                        GPos2 = (double)plc.ReadW("D100") / 1000;
                        GPos3 = (double)plc.ReadW("D102") / 200;
                        GPos4 = (double)plc.ReadW("D104") / 200;
                        GPos9 = (double)plc.ReadW("D106") / 10000 * 360;
                    });
                    #endregion
                    #region 读信息
                    bool[] M3000 = await Task.Run<bool[]>(() =>
                    {
                        return plc.ReadMultiM("M3000", 16);
                    });

                    if (M3000 != null)
                    {
                        if (m3000 != M3000[0])
                        {
                            if (M3000[0])
                            {
                                PLCModeSate = "S0初始化流程";
                            }
                            m3000 = M3000[0];
                        }
                        if (m3001 != M3000[1])
                        {
                            if (M3000[1])
                            {
                                PLCModeSate = "S10模式选择流程";
                            }
                            m3001 = M3000[1];
                        }
                        if (m3002 != M3000[2])
                        {
                            if (M3000[2])
                            {
                                PLCModeSate = "S11运行流程";
                            }
                            m3002 = M3000[2];
                        }
                        if (m3003 != M3000[3])
                        {
                            if (M3000[3])
                            {
                                PLCModeSate = "S50调试流程";
                            }
                            m3003 = M3000[3];
                        }
                        if (m3004 != M3000[4])
                        {
                            if (M3000[4])
                            {
                                PLCModeSate = "S99急停流程";
                            }
                            m3004 = M3000[4];
                        }
                        if (m3005 != M3000[5])
                        {
                            if (M3000[5])
                            {
                                addMessage("暂停");
                            }
                            m3005 = M3000[5];
                        }
                        if (m3006 != M3000[6])
                        {
                            if (M3000[6])
                            {
                                addMessage("等待按“复位”按钮");
                            }
                            m3006 = M3000[6];
                        }
                    }

                    #endregion
                    #region 运行
                    bool m401 = await Task.Run<bool>(()=> {
                        return plc.ReadM("M401");
                    });
                    if (m401)
                    {
                        addMessage("触发拍照");
                        await Task.Run(()=> {
                            
                            plc.SetM("M401", false);
                            plc.SetM("M402", true);
                            cam1.GrabImageVoid(0, false, false);
                            
                        });
                        CameraIamge = cam1.CurrentImage;
                        addMessage("拍照完成");
                    }
                    #endregion
                  
                }
                catch 
                {

                }
                #region 更新状态
                StatusCamera = cam1.Connected;
                #endregion
                await Task.Delay(100);
            }
        }
        #endregion
    }
}
