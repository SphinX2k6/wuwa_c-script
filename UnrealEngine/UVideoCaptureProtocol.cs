using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002319 RID: 8985
	[UnrealObjectPath("/Script/MovieSceneCapture.VideoCaptureProtocol")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UVideoCaptureProtocol : UFrameGrabberProtocol, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022059 RID: 139353 RVA: 0x00324B71 File Offset: 0x00322D71
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UVideoCaptureProtocol._ClassPtr;
		}

		// Token: 0x0602205A RID: 139354 RVA: 0x00324B80 File Offset: 0x00322D80
		public UVideoCaptureProtocol() : this(BuiltinUtils.AllocNativeUObject(UVideoCaptureProtocol.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602205B RID: 139355 RVA: 0x00324BA8 File Offset: 0x00322DA8
		[NullableContext(1)]
		public UVideoCaptureProtocol(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UVideoCaptureProtocol.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008372 RID: 33650
		// (get) Token: 0x0602205C RID: 139356 RVA: 0x00324BDB File Offset: 0x00322DDB
		// (set) Token: 0x0602205D RID: 139357 RVA: 0x00324BEB File Offset: 0x00322DEB
		public unsafe bool bUseCompression
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UVideoCaptureProtocol.__PropertyOffset_bUseCompression) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UVideoCaptureProtocol.__PropertyOffset_bUseCompression) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008373 RID: 33651
		// (get) Token: 0x0602205E RID: 139358 RVA: 0x00324BFC File Offset: 0x00322DFC
		// (set) Token: 0x0602205F RID: 139359 RVA: 0x00324C0C File Offset: 0x00322E0C
		public unsafe float CompressionQuality
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UVideoCaptureProtocol.__PropertyOffset_CompressionQuality);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UVideoCaptureProtocol.__PropertyOffset_CompressionQuality) = value;
			}
		}

		// Token: 0x06022060 RID: 139360 RVA: 0x00324C1D File Offset: 0x00322E1D
		static UVideoCaptureProtocol()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneCapture.VideoCaptureProtocol");
		}

		// Token: 0x06022061 RID: 139361 RVA: 0x00324C2B File Offset: 0x00322E2B
		protected UVideoCaptureProtocol(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401224A RID: 74314
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneCapture.VideoCaptureProtocol";

		// Token: 0x0401224B RID: 74315
		private static IntPtr _ClassPtr;

		// Token: 0x0401224C RID: 74316
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401224D RID: 74317
		internal static int __PropertyOffset_bUseCompression;

		// Token: 0x0401224E RID: 74318
		internal static int __PropertyOffset_CompressionQuality;
	}
}
