using HalconDotNet;
using System;
using System.Threading.Tasks;

namespace SXJLibrary
{
    public class CameraOperate
    {
        //相机句柄
        private HFramegrabber Framegrabber { set; get; }

        public HImage CurrentImage { set; get; } = new HImage();
        public bool Connected { set; get; }

        /// <summary>
        /// 打开相机
        /// </summary>
        /// <param name="cameraName">相机名字</param>
        /// <param name="CameraInterface">相机接口</param>
        /// <returns></returns>
        public bool OpenCamera(string cameraName, string CameraInterface)
        {
            try
            {
                //        "DirectShow", 1, 1, 0, 0, 0, 0, "default", 8, "rgb", 
                //-1, "false", "default", "[0] Integrated Camera", 0, -1, out hv_AcqHandle
                //            Framegrabber = new HFramegrabber(CameraInterface, 1, 1, 0, 0, 0, 0, "default", 8, "rgb",
                //-1, "false", "default", cameraName, 0, -1);
                Framegrabber = new HFramegrabber(CameraInterface, 0, 0, 0, 0, 0, 0, "default", -1, "default", -1, "false", "default", cameraName, 0, -1);

                Connected = true;
                //GrabImageaAsyncStart();
                //Framegrabber.SetFramegrabberParam("AcquisitionMode", "SingleFrame");
               

                return true;
            }
            catch (HalconException ex){ Connected = false; return false; }
        }

        /// <summary>
        /// 关闭当前相机
        /// </summary>
        /// <returns></returns>
        public bool CloseCamera()
        {
            try
            {
                Framegrabber.Dispose();
                return true;
            }
            catch { return false; }
        }

        /// <summary>
        /// 拍摄一张图片
        /// </summary>
        /// <returns></returns>
        public bool GrabImage(int medianRadius,bool isEnhance, bool isMirror)
        {
            try
            {
                if (Connected)
                {
                    //CurrentImage?.Dispose();
                    HImage image = isEnhance ? EnhancedImage(Framegrabber.GrabImage()) : Framegrabber.GrabImage();
                    if (medianRadius > 0)
                    {
                        HObject medianedImage;
                        HOperatorSet.MedianImage(image, out medianedImage, "circle", medianRadius, "mirrored");
                        image.Dispose();
                        if (isMirror)
                        {
                            HObject imageMirror;
                            HOperatorSet.MirrorImage(medianedImage,out imageMirror, "column");
                            CurrentImage = new HImage(imageMirror);
                        }
                        else
                            CurrentImage = new HImage(medianedImage);
                    }
                    else
                    {
                        if (isMirror)
                        {
                            HObject imageMirror;
                            HOperatorSet.MirrorImage(image, out imageMirror, "column");
                            image.Dispose();
                            CurrentImage = new HImage(imageMirror);
                        }
                        else
                            CurrentImage = image;
                    }
                    return true;
                }
                else return false;
            }
            catch
            {
                Connected = false;
                return false;
            }
        }

        public void GrabImageVoid(int medianRadius, bool isEnhance, bool isMirror)
        {
            try
            {
                {
                    //CurrentImage?.Dispose();
                    HImage image = isEnhance ? EnhancedImage(Framegrabber.GrabImage()) : Framegrabber.GrabImage();
                    if (medianRadius > 0)
                    {
                        HObject medianedImage;
                        HOperatorSet.MedianImage(image, out medianedImage, "circle", medianRadius, "mirrored");
                        image.Dispose();
                        if (isMirror)
                        {
                            HObject imageMirror;
                            HOperatorSet.MirrorImage(medianedImage, out imageMirror, "column");
                            medianedImage.Dispose();
                            CurrentImage = new HImage(imageMirror);
                        }
                        else
                            CurrentImage = new HImage(medianedImage);
                    }
                    else
                    {
                        if (isMirror)
                        {
                            HObject imageMirror;
                            HOperatorSet.MirrorImage(image, out imageMirror, "column");
                            image.Dispose();
                            CurrentImage = new HImage(imageMirror);
                        }
                        else
                            CurrentImage = image;
                    }
                }

            }
            catch
            {
                Connected = false;
              
            }
        }

        HImage EnhancedImage(HObject image)
        {
            //HTuple width, height;
            //HOperatorSet.GetImageSize(image, out width, out height);
            //HObject rectangle;
            //HOperatorSet.GenRectangle1(out rectangle, 0, 0, height - 1, width - 1);
            //HTuple min, max, range;
            //HOperatorSet.MinMaxGray(rectangle, image, 0, out min, out max, out range);
            HObject imageScaled;
            HTuple mult = 255.0 / (255 - 70);
            HTuple add = -1 * mult * 70;
            HOperatorSet.ScaleImage(image, out imageScaled, mult, add);
            return new HImage(imageScaled);
        }


        /// <summary>
        /// 保存当前图片
        /// </summary>
        /// <param name="imageType">bmp,png,tiff</param>
        /// <param name="imagePath"></param>
        /// <returns></returns>
        public bool SaveImage(string imageType, string imagePath)
        {
            try
            {
                CurrentImage.WriteImage(imageType, 0, imagePath);
                return true;
            }
            catch (Exception ex){ return false; }
        }

        /// <summary>
        /// 读取一张图片
        /// </summary>
        /// <param name="imagePath"></param>
        /// <returns></returns>
        public bool ReadImage(string imagePath)
        {
            try
            {
                //CurrentImage?.Dispose();
                HObject image;
                HOperatorSet.ReadImage(out image, imagePath);
                CurrentImage = new HImage(image);
                return true;
            }
            catch { return false; }
        }

        /// <summary>
        /// 设置曝光时间
        /// </summary>
        /// <param name="exposeValue"></param>
        /// <returns></returns>
        public bool SetExpose(double exposeValue)
        {
           
            try
            {
                Framegrabber.SetFramegrabberParam("ExposureTimeAbs", exposeValue);
                return true;
            }
            catch {  }
            try
            {
                Framegrabber.SetFramegrabberParam("ExposureTime", exposeValue);
                return true;
            }
            catch { }

            return false;
        }
        public bool SetRotaryEncoderDirection(bool dir)
        {
            try
            {
                if (dir)
                {
                    Framegrabber.SetFramegrabberParam("rotaryEncoderDirection", "CounterClockwise");
                }
                else
                {
                    Framegrabber.SetFramegrabberParam("rotaryEncoderDirection", "Clockwise");
                }
                return true;
            }
            catch 
            {
                return false;
            }
        }
    }
}