
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Cognex.VisionPro;
using Cognex;

namespace WVision
{
    public class CGigECamera : IVisionCamera
    {
        #region "Property"
        public event EventHandler AcqComplete;

        //public typCameraParams _Property;
        //public struct typCameraParams
        //{

        //}

        public int SEQ { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CameraName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string SerialNo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public enum_CameraGrabMode CameraMode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime AcquireTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //public CogIPOneImageFlipRotateOperationConstants FlipRotate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public long AcqTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Exposure { get; set; }   // 노출
        public string Brightness { get; set; }  // 밝기
        public string Contrast { get; set; }  // 대조    
        public string Index { get; set; }

        #endregion

        private ICogAcqFifo CAcqFifo;
        private ICogGigEAccess mGigECameraAccess;

        public virtual void CameraAuto()
        {
            this.CAcqFifo.OwnedTriggerParams.TriggerModel = CogAcqTriggerModelConstants.Auto;
            this.CAcqFifo.StartAcquire();
        }

        public virtual void CameraLive()
        {
            this.CAcqFifo.OwnedTriggerParams.TriggerModel = CogAcqTriggerModelConstants.FreeRun;
            this.CAcqFifo.StartAcquire();
        }

        public virtual void CameraManaual()
        {
            {
                if (this.CAcqFifo == null) return;
                this.CAcqFifo.OwnedTriggerParams.TriggerModel = CogAcqTriggerModelConstants.Manual;
                this.CAcqFifo.Complete -= Operator_Complete;

                try
                {
                    int tNum = 0;
                    ICogImage img = this.CAcqFifo.Acquire(out tNum);

                    WindyCameraEventArgs WindyE = new WindyCameraEventArgs(this.SerialNo, img);
                    this.AcqComplete(this, WindyE);
                    this.CAcqFifo.Flush();
                }
                catch
                {
                    this.AcqComplete(this, null);
                }

            }
        }

        public virtual void Dispose()
        {
            try
            {
                if (this.CAcqFifo != null)
                {
                    this.CAcqFifo.Complete -= new CogCompleteEventHandler(Operator_Complete);
                    this.CAcqFifo.Flush();
                    this.CAcqFifo.FrameGrabber.Disconnect(false);
                }
            }
            catch
            {

            }
        }

        //public virtual bool initialization()
        //{
        //    Cognex.VisionPro.ICogFrameGrabber cCogFrameGrabber = CCognexGrabber.GetGrabber(this.SerialNo);

        //    try
        //    {
        //        if (cCogFrameGrabber != null)
        //        {
        //            int x, y, w, h;
        //            this.CAcqFifo = cCogFrameGrabber.CreateAcqFifo(this.VideoFormat, CogAcqFifoPixelFormatConstants.Format8Grey, int.Parse(this.PortNo), false);
        //            this.CAcqFifo.OwnedExposureParams.Exposure = double.Parse(this.Exposure);

        //            if (this.CAcqFifo.FrameGrabber.Name == "Cognex 8602e" || this.CAcqFifo.FrameGrabber.Name.ToUpper().IndexOf("e2v") > -1)
        //            {
        //                this.CAcqFifo.OwnedROIParams.GetROIXYWidthHeight(out x, out y, out w, out h);
        //                this.CAcqFifo.OwnedROIParams.SetROIXYWidthHeight(0, 0, w + x, Convert.ToInt32(double.Parse(this.Contrast) * 100.0 + Convert.ToDouble(y)));
        //            }
        //            else
        //            {
        //                this.CAcqFifo.OwnedContrastParams.Contrast = (double.Parse(this.Contrast) > 1 ? 0.5 : double.Parse(this.Contrast));
        //                this.CAcqFifo.OwnedBrightnessParams.Brightness = double.Parse(this.Brightness);
        //                // GIGE camera에서 초기화가 x,y위치가 0이 아닌경우가 있음
        //                this.CAcqFifo.OwnedROIParams.GetROIXYWidthHeight(out x, out y, out w, out h);
        //                this.CAcqFifo.OwnedROIParams.SetROIXYWidthHeight(0, 0, w + x, h + y);
        //            }
        //            if (this.CAcqFifo.GetType() == typeof(Cognex.VisionPro.FGGigE.Implementation.Internal.CogAcqFifoGigE)) this.mGigECameraAccess = cCogFrameGrabber.OwnedGigEAccess;

        //            this.CAcqFifo.Complete -= new CogCompleteEventHandler(Operator_Complete);
        //            this.CAcqFifo.Complete += new CogCompleteEventHandler(Operator_Complete);

        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //    }
        //}

        public bool IsAlive()
        {
            throw new NotImplementedException();
        }

        public virtual void Snapshot()
        {
            throw new NotImplementedException();
        }

        private void Operator_Complete(object sender, CogCompleteEventArgs e)
        {
            int numReadyVal, numPendingVal, myTicket, currentTrigNum;
            bool busyVal;
            ICogImage AcqImage;

            this.CAcqFifo.GetFifoState(out numPendingVal, out numReadyVal, out busyVal);

            if (numReadyVal > 0)
            {
                try
                {
                    AcqImage = this.CAcqFifo.CompleteAcquire(-1, out myTicket, out currentTrigNum);
                    this.CAcqFifo.Flush();
                    if (this.AcqComplete != null)
                    {
                        WindyCameraEventArgs WindyE = new WindyCameraEventArgs(this.SerialNo, AcqImage);
                        this.AcqComplete(this, WindyE);
                    }
                }
                catch (Cognex.VisionPro.Exceptions.CogAcqException ex)
                {
                    System.Diagnostics.Debug.Print(String.Format("No. Cam {0} => {1}", this.Index, ex.Message.ToString()));
                }

            }
            else
            {
                System.Diagnostics.Debug.Print(String.Format("No. {0}  numPendingVal =nothing", this.Index));
            }
            this.CAcqFifo.OwnedTriggerParams.TriggerModel = CogAcqTriggerModelConstants.Auto;
        }


    }
}
