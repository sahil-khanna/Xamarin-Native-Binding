using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace SHLib
{

    // @interface MyFirstFramework : NSObject
    [BaseType(typeof(NSObject))]
    [Protocol]
    interface MyFirstFramework
    {
        // +(void)launch;
        [Static]
        [Export("launch")]
        void Launch();

        // +(NSString * _Nonnull)print __attribute__((warn_unused_result));
        [Static]
        [Export("print")]
        string Print { get; }
    }
}

