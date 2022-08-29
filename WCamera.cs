using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WVision
{
    public class WCamera : ConcurrentDictionary<int, IVisionCamera>, IDisposable
    {

        public bool Initialize()
        {
            //Camera 파일 규칙
            WGlobal._PATH_CAMERA = WGlobal._PATH_VISION + @"Camera.ini";

            if (Directory.Exists(WGlobal._PATH_CAMERA)) Directory.CreateDirectory(WGlobal._PATH_CAMERA);

            WGlobal._PATH_CAMERA += @"\Camera.ini";

            // 전체 카메라 초기화
            return false;
        }

        public void ShowCameraConfig()
        {
            using (Form_CameraConfig f = new Form_CameraConfig())
            {
                f.ShowDialog();

                //this.Initialize();
            }
        }

        public void Dispose()
        {
            foreach (IVisionCamera cam in this.Values)
            {
                cam.Dispose();
            }
        }
    }
}
