using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002318 RID: 8984
	[UnrealObjectPath("/Script/MovieSceneCapture.UserDefinedImageCaptureProtocol")]
	[UnrealStructLayout(232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 232)]
	public abstract class UUserDefinedImageCaptureProtocol : UUserDefinedCaptureProtocol, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022049 RID: 139337 RVA: 0x00324A3D File Offset: 0x00322C3D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUserDefinedImageCaptureProtocol._ClassPtr;
		}

		// Token: 0x1700836F RID: 33647
		// (get) Token: 0x0602204A RID: 139338 RVA: 0x00324A49 File Offset: 0x00322C49
		// (set) Token: 0x0602204B RID: 139339 RVA: 0x00324A59 File Offset: 0x00322C59
		public unsafe EDesiredImageFormat Format
		{
			get
			{
				return (EDesiredImageFormat)(*(base.NativePtr + (IntPtr)UUserDefinedImageCaptureProtocol.__PropertyOffset_Format));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUserDefinedImageCaptureProtocol.__PropertyOffset_Format) = (byte)value;
			}
		}

		// Token: 0x17008370 RID: 33648
		// (get) Token: 0x0602204C RID: 139340 RVA: 0x00324A6A File Offset: 0x00322C6A
		// (set) Token: 0x0602204D RID: 139341 RVA: 0x00324A7A File Offset: 0x00322C7A
		public unsafe bool bEnableCompression
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUserDefinedImageCaptureProtocol.__PropertyOffset_bEnableCompression) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUserDefinedImageCaptureProtocol.__PropertyOffset_bEnableCompression) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008371 RID: 33649
		// (get) Token: 0x0602204E RID: 139342 RVA: 0x00324A8B File Offset: 0x00322C8B
		// (set) Token: 0x0602204F RID: 139343 RVA: 0x00324A9B File Offset: 0x00322C9B
		public unsafe int CompressionQuality
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUserDefinedImageCaptureProtocol.__PropertyOffset_CompressionQuality);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUserDefinedImageCaptureProtocol.__PropertyOffset_CompressionQuality) = value;
			}
		}

		// Token: 0x06022050 RID: 139344 RVA: 0x00324AAC File Offset: 0x00322CAC
		[NullableContext(2)]
		public void WriteImageToDisk(in FCapturedPixels PixelData, in FCapturedPixelsID StreamID, in FFrameMetrics FrameMetrics, bool bCopyImageData = false)
		{
			UUserDefinedImageCaptureProtocol.__WriteImageToDisk_Internal(base.NativePtr, (PixelData ?? new FCapturedPixels()).NativePtr, (StreamID ?? new FCapturedPixelsID()).NativePtr, (FrameMetrics ?? new FFrameMetrics()).NativePtr, bCopyImageData);
		}

		// Token: 0x06022051 RID: 139345 RVA: 0x00324AEB File Offset: 0x00322CEB
		[NullableContext(1)]
		public string GenerateFilenameForCurrentFrame()
		{
			return FString.ToStringAndDeleteNativePtr(UUserDefinedImageCaptureProtocol.__GenerateFilenameForCurrentFrame_Internal(base.NativePtr));
		}

		// Token: 0x06022052 RID: 139346 RVA: 0x00324AFD File Offset: 0x00322CFD
		[NullableContext(2)]
		[return: Nullable(1)]
		public string GenerateFilenameForBuffer(UTexture Buffer, in FCapturedPixelsID StreamID)
		{
			return FString.ToStringAndDeleteNativePtr(UUserDefinedImageCaptureProtocol.__GenerateFilenameForBuffer_Internal(base.NativePtr, (Buffer != null) ? Buffer.NativePtr : IntPtr.Zero, (StreamID ?? new FCapturedPixelsID()).NativePtr));
		}

		// Token: 0x06022053 RID: 139347
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __WriteImageToDisk_Internal(IntPtr @this, IntPtr PixelData, IntPtr StreamID, IntPtr FrameMetrics, bool bCopyImageData);

		// Token: 0x06022054 RID: 139348
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GenerateFilenameForCurrentFrame_Internal(IntPtr @this);

		// Token: 0x06022055 RID: 139349
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GenerateFilenameForBuffer_Internal(IntPtr @this, IntPtr Buffer, IntPtr StreamID);

		// Token: 0x06022056 RID: 139350 RVA: 0x00324B2F File Offset: 0x00322D2F
		static UUserDefinedImageCaptureProtocol()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneCapture.UserDefinedImageCaptureProtocol");
		}

		// Token: 0x06022057 RID: 139351 RVA: 0x00324B40 File Offset: 0x00322D40
		protected UUserDefinedImageCaptureProtocol() : this(BuiltinUtils.AllocNativeUObject(UUserDefinedImageCaptureProtocol.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022058 RID: 139352 RVA: 0x00324B68 File Offset: 0x00322D68
		protected UUserDefinedImageCaptureProtocol(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012244 RID: 74308
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneCapture.UserDefinedImageCaptureProtocol";

		// Token: 0x04012245 RID: 74309
		private static IntPtr _ClassPtr;

		// Token: 0x04012246 RID: 74310
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012247 RID: 74311
		internal static int __PropertyOffset_Format;

		// Token: 0x04012248 RID: 74312
		internal static int __PropertyOffset_bEnableCompression;

		// Token: 0x04012249 RID: 74313
		internal static int __PropertyOffset_CompressionQuality;
	}
}
