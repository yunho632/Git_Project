using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Cognex.VisionPro;
//using Cognex.VisionPro.FGGigE;
//using Cognex.VisionPro.ImageProcessing;

namespace WVision
{
    public enum enum_CameraGrabMode : short
    {
        Manual = 0,
        Auto = 1,
        Live = 2
    };

    public interface IVisionCamera : IDisposable
    {
        int SEQ { get; set; } // 카메라 보여주는 순서?
        string CameraName { get; set; } // 내부용 확인용        
        string SerialNo { get; set; } // Cognex Serial No
        enum_CameraGrabMode CameraMode { get; set; }
        DateTime AcquireTime { get; set; }
        //CogIPOneImageFlipRotateOperationConstants FlipRotate { get; set; }
        long AcqTime { get; set; }
        //bool initialization();
        void Snapshot();
        void CameraAuto();
        void CameraManaual();
        void CameraLive();
        bool IsAlive(); // 카메라 상태        
    }

    public class WindyCameraEventArgs : EventArgs
    {
        public string SerialNumber { get; set; }
        public ICogImage Image { get; set; }
        public WindyCameraEventArgs(string serialNumber, ICogImage image)
        {
            this.SerialNumber = serialNumber;
            this.Image = image;
        }
    }
}
