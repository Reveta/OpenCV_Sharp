﻿using System.Collections.Generic;
using OpenCvSharp;

namespace HelloWorld.Interfaces {
	public interface IInstruments {
		Mat ResizePhoto(Mat image, int width, int height);
		Mat GenKernel(double[,] array);

		List<Mat> GetImages(string searchPattern);
	}
}