//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.ComponentModel;
using MonoTouch;
using MonoTouch.CoreFoundation;
using MonoTouch.CoreMedia;
using MonoTouch.CoreMotion;
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;
using MonoTouch.CoreAnimation;
using MonoTouch.CoreLocation;
using MonoTouch.MapKit;
using MonoTouch.UIKit;
using MonoTouch.CoreGraphics;
using MonoTouch.NewsstandKit;
using MonoTouch.GLKit;
using MonoTouch.CoreVideo;
using OpenTK;

namespace KS_PSPDFKitBindings {
	[Register("PSPDFSelectionViewDelegate", true)]
	[Model]
	public unsafe partial class PSPDFSelectionViewDelegate : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("NSObject");
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PSPDFSelectionViewDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.Init);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.Init);
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public PSPDFSelectionViewDelegate (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.InitWithCoder, coder.Handle);
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFSelectionViewDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFSelectionViewDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("selectionView:shouldStartSelectionAtPoint:")]
		[CompilerGenerated]
		public virtual bool ShouldStartSelectionAtPoint (PSPDFSelectionView selectionView, global::System.Drawing.PointF point)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("selectionView:updateSelectedRect:")]
		[CompilerGenerated]
		public virtual void UpdateSelectedRect (PSPDFSelectionView selectionView, global::System.Drawing.RectangleF rect)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("selectionView:finishedWithSelectedRect:")]
		[CompilerGenerated]
		public virtual void FinishedWithSelectedRect (PSPDFSelectionView selectionView, global::System.Drawing.RectangleF rect)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("selectionView:cancelledWithSelectedRect:")]
		[CompilerGenerated]
		public virtual void CancelledWithSelectedRect (PSPDFSelectionView selectionView, global::System.Drawing.RectangleF rect)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("selectionView:singleTappedWithGestureRecognizer:")]
		[CompilerGenerated]
		public virtual void SingleTappedWithGestureRecognizer (PSPDFSelectionView selectionView, global::MonoTouch.UIKit.UITapGestureRecognizer recgestureRecognizert)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class PSPDFSelectionViewDelegate */
}
