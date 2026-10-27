using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002317 RID: 8983
	[UnrealObjectPath("/Script/MovieSceneCapture.UserDefinedCaptureProtocol")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 224)]
	public abstract class UUserDefinedCaptureProtocol : UMovieSceneImageCaptureProtocolBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602201F RID: 139295 RVA: 0x00324862 File Offset: 0x00322A62
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUserDefinedCaptureProtocol._ClassPtr;
		}

		// Token: 0x1700836E RID: 33646
		// (get) Token: 0x06022020 RID: 139296 RVA: 0x0032486E File Offset: 0x00322A6E
		// (set) Token: 0x06022021 RID: 139297 RVA: 0x00324882 File Offset: 0x00322A82
		[Nullable(2)]
		public unsafe UWorld World
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UWorld>(base.NativePtr / (IntPtr)sizeof(void*) + UUserDefinedCaptureProtocol.__PropertyOffset_World);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUserDefinedCaptureProtocol.__PropertyOffset_World, value);
			}
		}

		// Token: 0x06022022 RID: 139298 RVA: 0x00324897 File Offset: 0x00322A97
		public void StopCapturingFinalPixels()
		{
			UUserDefinedCaptureProtocol.__StopCapturingFinalPixels_Internal(base.NativePtr);
		}

		// Token: 0x06022023 RID: 139299 RVA: 0x003248A4 File Offset: 0x00322AA4
		[NullableContext(2)]
		public void StartCapturingFinalPixels(in FCapturedPixelsID StreamID)
		{
			UUserDefinedCaptureProtocol.__StartCapturingFinalPixels_Internal(base.NativePtr, (StreamID ?? new FCapturedPixelsID()).NativePtr);
		}

		// Token: 0x06022024 RID: 139300 RVA: 0x003248C1 File Offset: 0x00322AC1
		[NullableContext(2)]
		public void ResolveBuffer(UTexture Buffer, in FCapturedPixelsID BufferID)
		{
			UUserDefinedCaptureProtocol.__ResolveBuffer_Internal(base.NativePtr, (Buffer != null) ? Buffer.NativePtr : IntPtr.Zero, (BufferID ?? new FCapturedPixelsID()).NativePtr);
		}

		// Token: 0x06022025 RID: 139301 RVA: 0x003248EE File Offset: 0x00322AEE
		public virtual void OnWarmUp()
		{
			UUserDefinedCaptureProtocol.__OnWarmUp_Internal(base.NativePtr);
		}

		// Token: 0x06022026 RID: 139302 RVA: 0x003248FB File Offset: 0x00322AFB
		public virtual void OnTick()
		{
			UUserDefinedCaptureProtocol.__OnTick_Internal(base.NativePtr);
		}

		// Token: 0x06022027 RID: 139303 RVA: 0x00324908 File Offset: 0x00322B08
		public virtual void OnStartCapture()
		{
			UUserDefinedCaptureProtocol.__OnStartCapture_Internal(base.NativePtr);
		}

		// Token: 0x06022028 RID: 139304 RVA: 0x00324915 File Offset: 0x00322B15
		public virtual bool OnSetup()
		{
			return UUserDefinedCaptureProtocol.__OnSetup_Internal(base.NativePtr);
		}

		// Token: 0x06022029 RID: 139305 RVA: 0x00324922 File Offset: 0x00322B22
		protected virtual bool OnSetup_Implementation()
		{
			return UUserDefinedCaptureProtocol.__OnSetup_Implementation_Internal(base.NativePtr);
		}

		// Token: 0x0602202A RID: 139306 RVA: 0x0032492F File Offset: 0x00322B2F
		public virtual void OnPreTick()
		{
			UUserDefinedCaptureProtocol.__OnPreTick_Internal(base.NativePtr);
		}

		// Token: 0x0602202B RID: 139307 RVA: 0x0032493C File Offset: 0x00322B3C
		[NullableContext(2)]
		public virtual void OnPixelsReceived(in FCapturedPixels Pixels, in FCapturedPixelsID ID, FFrameMetrics FrameMetrics)
		{
			UUserDefinedCaptureProtocol.__OnPixelsReceived_Internal(base.NativePtr, (Pixels ?? new FCapturedPixels()).NativePtr, (ID ?? new FCapturedPixelsID()).NativePtr, (FrameMetrics ?? new FFrameMetrics()).NativePtr);
		}

		// Token: 0x0602202C RID: 139308 RVA: 0x00324978 File Offset: 0x00322B78
		public virtual void OnPauseCapture()
		{
			UUserDefinedCaptureProtocol.__OnPauseCapture_Internal(base.NativePtr);
		}

		// Token: 0x0602202D RID: 139309 RVA: 0x00324985 File Offset: 0x00322B85
		public virtual void OnFinalize()
		{
			UUserDefinedCaptureProtocol.__OnFinalize_Internal(base.NativePtr);
		}

		// Token: 0x0602202E RID: 139310 RVA: 0x00324992 File Offset: 0x00322B92
		public virtual void OnCaptureFrame()
		{
			UUserDefinedCaptureProtocol.__OnCaptureFrame_Internal(base.NativePtr);
		}

		// Token: 0x0602202F RID: 139311 RVA: 0x0032499F File Offset: 0x00322B9F
		public virtual bool OnCanFinalize()
		{
			return UUserDefinedCaptureProtocol.__OnCanFinalize_Internal(base.NativePtr);
		}

		// Token: 0x06022030 RID: 139312 RVA: 0x003249AC File Offset: 0x00322BAC
		protected virtual bool OnCanFinalize_Implementation()
		{
			return UUserDefinedCaptureProtocol.__OnCanFinalize_Implementation_Internal(base.NativePtr);
		}

		// Token: 0x06022031 RID: 139313 RVA: 0x003249B9 File Offset: 0x00322BB9
		public virtual void OnBeginFinalize()
		{
			UUserDefinedCaptureProtocol.__OnBeginFinalize_Internal(base.NativePtr);
		}

		// Token: 0x06022032 RID: 139314 RVA: 0x003249C6 File Offset: 0x00322BC6
		[NullableContext(1)]
		public FFrameMetrics GetCurrentFrameMetrics()
		{
			return new FFrameMetrics(UUserDefinedCaptureProtocol.__GetCurrentFrameMetrics_Internal(base.NativePtr), null);
		}

		// Token: 0x06022033 RID: 139315 RVA: 0x003249D9 File Offset: 0x00322BD9
		[NullableContext(1)]
		public string GenerateFilename([Nullable(2)] in FFrameMetrics InFrameMetrics)
		{
			return FString.ToStringAndDeleteNativePtr(UUserDefinedCaptureProtocol.__GenerateFilename_Internal(base.NativePtr, (InFrameMetrics ?? new FFrameMetrics()).NativePtr));
		}

		// Token: 0x06022034 RID: 139316
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopCapturingFinalPixels_Internal(IntPtr @this);

		// Token: 0x06022035 RID: 139317
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartCapturingFinalPixels_Internal(IntPtr @this, IntPtr StreamID);

		// Token: 0x06022036 RID: 139318
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResolveBuffer_Internal(IntPtr @this, IntPtr Buffer, IntPtr BufferID);

		// Token: 0x06022037 RID: 139319
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnWarmUp_Internal(IntPtr @this);

		// Token: 0x06022038 RID: 139320
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnTick_Internal(IntPtr @this);

		// Token: 0x06022039 RID: 139321
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnStartCapture_Internal(IntPtr @this);

		// Token: 0x0602203A RID: 139322
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __OnSetup_Internal(IntPtr @this);

		// Token: 0x0602203B RID: 139323
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __OnSetup_Implementation_Internal(IntPtr @this);

		// Token: 0x0602203C RID: 139324
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnPreTick_Internal(IntPtr @this);

		// Token: 0x0602203D RID: 139325
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnPixelsReceived_Internal(IntPtr @this, IntPtr Pixels, IntPtr ID, IntPtr FrameMetrics);

		// Token: 0x0602203E RID: 139326
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnPauseCapture_Internal(IntPtr @this);

		// Token: 0x0602203F RID: 139327
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnFinalize_Internal(IntPtr @this);

		// Token: 0x06022040 RID: 139328
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnCaptureFrame_Internal(IntPtr @this);

		// Token: 0x06022041 RID: 139329
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __OnCanFinalize_Internal(IntPtr @this);

		// Token: 0x06022042 RID: 139330
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __OnCanFinalize_Implementation_Internal(IntPtr @this);

		// Token: 0x06022043 RID: 139331
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnBeginFinalize_Internal(IntPtr @this);

		// Token: 0x06022044 RID: 139332
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetCurrentFrameMetrics_Internal(IntPtr @this);

		// Token: 0x06022045 RID: 139333
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GenerateFilename_Internal(IntPtr @this, IntPtr InFrameMetrics);

		// Token: 0x06022046 RID: 139334 RVA: 0x003249FB File Offset: 0x00322BFB
		static UUserDefinedCaptureProtocol()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneCapture.UserDefinedCaptureProtocol");
		}

		// Token: 0x06022047 RID: 139335 RVA: 0x00324A0C File Offset: 0x00322C0C
		protected UUserDefinedCaptureProtocol() : this(BuiltinUtils.AllocNativeUObject(UUserDefinedCaptureProtocol.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022048 RID: 139336 RVA: 0x00324A34 File Offset: 0x00322C34
		protected UUserDefinedCaptureProtocol(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012240 RID: 74304
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneCapture.UserDefinedCaptureProtocol";

		// Token: 0x04012241 RID: 74305
		private static IntPtr _ClassPtr;

		// Token: 0x04012242 RID: 74306
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012243 RID: 74307
		internal static int __PropertyOffset_World;

		// Token: 0x02003645 RID: 13893
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __OnSetup_FunctionParams
		{
			// Token: 0x0401770D RID: 96013
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003646 RID: 13894
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 112)]
		protected ref struct __OnPixelsReceived_FunctionParams
		{
			// Token: 0x0401770E RID: 96014
			[FieldOffset(0)]
			public byte Pixels;

			// Token: 0x0401770F RID: 96015
			[FieldOffset(16)]
			public byte ID;

			// Token: 0x04017710 RID: 96016
			[FieldOffset(96)]
			public byte FrameMetrics;
		}

		// Token: 0x02003647 RID: 13895
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __OnCanFinalize_FunctionParams
		{
			// Token: 0x04017711 RID: 96017
			[FieldOffset(0)]
			public bool __Result;
		}
	}
}
