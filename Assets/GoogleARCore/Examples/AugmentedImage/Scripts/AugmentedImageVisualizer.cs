//-----------------------------------------------------------------------
// <copyright file="AugmentedImageVisualizer.cs" company="Google LLC">
//
// Copyright 2018 Google LLC. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// </copyright>
//-----------------------------------------------------------------------

namespace GoogleARCore.Examples.AugmentedImage
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;
    using GoogleARCore;
    using GoogleARCoreInternal;
    using TMPro;
    using UnityEngine;

    /// Uses 4 frame corner objects to visualize an AugmentedImage.
    public class AugmentedImageVisualizer : MonoBehaviour
    {
        /// The AugmentedImage to visualize.
        public AugmentedImage Image;

        /// A model for the lower left corner of the frame to place when an image is detected.
        public GameObject FrameLowerLeft;

        /// A model for the lower right corner of the frame to place when an image is detected.
        public GameObject FrameLowerRight;

        /// A model for the upper left corner of the frame to place when an image is detected.
        public GameObject FrameUpperLeft;

        /// A model for the upper right corner of the frame to place when an image is detected.
        public GameObject FrameUpperRight;



        /// The Unity Update method.

        public void Update()
        {
            if (Image == null || Image.TrackingState != TrackingState.Tracking)
            {
                FrameLowerLeft.SetActive(false);
                FrameLowerRight.SetActive(false);
                FrameUpperLeft.SetActive(false);
                FrameUpperRight.SetActive(false);
                return;
            }

            float halfWidth = Image.ExtentX / 2;
            float halfHeight = Image.ExtentZ / 2;
            FrameLowerLeft.transform.localPosition =
                (halfWidth * Vector3.left) + (halfHeight * Vector3.back);
            FrameLowerRight.transform.localPosition =
                (halfWidth * Vector3.right) + (halfHeight * Vector3.back);
            FrameUpperLeft.transform.localPosition =
                (halfWidth * Vector3.left) + (halfHeight * Vector3.forward);
            FrameUpperRight.transform.localPosition =
                (halfWidth * Vector3.right) + (halfHeight * Vector3.forward);


            if (Image != null)
            {
                FrameUpperRightText.setIMG(Image);
                FrameUpperLeftText.setIMG(Image);
                //FrameLowerRightText.setIMG(Image);
                FrameUpperLeftInfoText.setIMG(Image);
                FrameUpperLeftInfoText2.setIMG(Image);
                FrameUpperLeftInfoText3.setIMG(Image);
            }
            
                


            FrameLowerLeft.SetActive(false);
            FrameLowerRight.SetActive(false);
            FrameUpperLeft.SetActive(true);
            FrameUpperRight.SetActive(true);
        }
    }
}
