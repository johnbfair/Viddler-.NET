﻿using System;
using System.Xml.Serialization;

namespace Viddler.Videos
{
  /// <summary>
  /// Provides request parameters for Viddler API remote method: viddler.videos.upload
  /// </summary>
  /// <remarks>
  /// This class is not intended to be used in your code in any way.
  /// </remarks>
  [ViddlerMethod(MethodName = "viddler.videos.upload", ElementName = "video", IsSecure = false, IsSessionRequired = true, RequestType = ViddlerRequestType.Multipart)]
  public class Upload : Viddler.Data.Video
  {
  }
}
