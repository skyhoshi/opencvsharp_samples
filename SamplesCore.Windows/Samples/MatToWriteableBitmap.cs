﻿using System.Windows;
using OpenCvSharp;
using OpenCvSharp.WpfExtensions;

namespace SamplesCore.Windows
{
    /// <summary>
    /// 
    /// </summary>
    class MatToWriteableBitmap : ISample
    {
        public void Run()
        {
            using var mat = new Mat(FilePath.Image.Fruits, ImreadModes.Color); // width % 4 != 0

            var wb = WriteableBitmapConverter.ToWriteableBitmap(mat);

            var image = new System.Windows.Controls.Image
            {
                Source = wb
            };

            var window = new System.Windows.Window
            {
                Content = image
            };

            var app = new Application();
            app.Run(window);
        }
    }
}