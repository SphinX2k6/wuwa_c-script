using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020010DB RID: 4315
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SceneRayTracingGICaptureComponentCube")]
	[UnrealStructLayout(928, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 928)]
	public class USceneRayTracingGICaptureComponentCube : USceneCaptureComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600F772 RID: 63346 RVA: 0x0016E3B4 File Offset: 0x0016C5B4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USceneRayTracingGICaptureComponentCube._ClassPtr;
		}

		// Token: 0x0600F773 RID: 63347 RVA: 0x0016E3C0 File Offset: 0x0016C5C0
		public USceneRayTracingGICaptureComponentCube() : this(BuiltinUtils.AllocNativeUObject(USceneRayTracingGICaptureComponentCube.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600F774 RID: 63348 RVA: 0x0016E3E8 File Offset: 0x0016C5E8
		[NullableContext(1)]
		public USceneRayTracingGICaptureComponentCube(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USceneRayTracingGICaptureComponentCube.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003C33 RID: 15411
		// (get) Token: 0x0600F775 RID: 63349 RVA: 0x0016E41B File Offset: 0x0016C61B
		// (set) Token: 0x0600F776 RID: 63350 RVA: 0x0016E42F File Offset: 0x0016C62F
		public unsafe UTextureRenderTargetCube TextureTarget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTargetCube>(base.NativePtr / (IntPtr)sizeof(void*) + USceneRayTracingGICaptureComponentCube.__PropertyOffset_TextureTarget);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USceneRayTracingGICaptureComponentCube.__PropertyOffset_TextureTarget, value);
			}
		}

		// Token: 0x17003C34 RID: 15412
		// (get) Token: 0x0600F777 RID: 63351 RVA: 0x0016E444 File Offset: 0x0016C644
		// (set) Token: 0x0600F778 RID: 63352 RVA: 0x0016E454 File Offset: 0x0016C654
		public unsafe bool bCaptureRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USceneRayTracingGICaptureComponentCube.__PropertyOffset_bCaptureRotation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USceneRayTracingGICaptureComponentCube.__PropertyOffset_bCaptureRotation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003C35 RID: 15413
		// (get) Token: 0x0600F779 RID: 63353 RVA: 0x0016E465 File Offset: 0x0016C665
		// (set) Token: 0x0600F77A RID: 63354 RVA: 0x0016E479 File Offset: 0x0016C679
		public unsafe UTextureRenderTargetCube TextureTargetLeft
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTargetCube>(base.NativePtr / (IntPtr)sizeof(void*) + USceneRayTracingGICaptureComponentCube.__PropertyOffset_TextureTargetLeft);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USceneRayTracingGICaptureComponentCube.__PropertyOffset_TextureTargetLeft, value);
			}
		}

		// Token: 0x17003C36 RID: 15414
		// (get) Token: 0x0600F77B RID: 63355 RVA: 0x0016E48E File Offset: 0x0016C68E
		// (set) Token: 0x0600F77C RID: 63356 RVA: 0x0016E4A2 File Offset: 0x0016C6A2
		public unsafe UTextureRenderTargetCube TextureTargetRight
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTargetCube>(base.NativePtr / (IntPtr)sizeof(void*) + USceneRayTracingGICaptureComponentCube.__PropertyOffset_TextureTargetRight);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USceneRayTracingGICaptureComponentCube.__PropertyOffset_TextureTargetRight, value);
			}
		}

		// Token: 0x17003C37 RID: 15415
		// (get) Token: 0x0600F77D RID: 63357 RVA: 0x0016E4B7 File Offset: 0x0016C6B7
		// (set) Token: 0x0600F77E RID: 63358 RVA: 0x0016E4CB File Offset: 0x0016C6CB
		public unsafe UTextureRenderTarget2D TextureTargetODS
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + USceneRayTracingGICaptureComponentCube.__PropertyOffset_TextureTargetODS);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USceneRayTracingGICaptureComponentCube.__PropertyOffset_TextureTargetODS, value);
			}
		}

		// Token: 0x17003C38 RID: 15416
		// (get) Token: 0x0600F77F RID: 63359 RVA: 0x0016E4E0 File Offset: 0x0016C6E0
		// (set) Token: 0x0600F780 RID: 63360 RVA: 0x0016E4F0 File Offset: 0x0016C6F0
		public unsafe float IPD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USceneRayTracingGICaptureComponentCube.__PropertyOffset_IPD);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USceneRayTracingGICaptureComponentCube.__PropertyOffset_IPD) = value;
			}
		}

		// Token: 0x0600F781 RID: 63361 RVA: 0x0016E501 File Offset: 0x0016C701
		public void CaptureScene()
		{
			USceneRayTracingGICaptureComponentCube.__CaptureScene_Internal(base.NativePtr);
		}

		// Token: 0x0600F782 RID: 63362
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CaptureScene_Internal(IntPtr @this);

		// Token: 0x0600F783 RID: 63363 RVA: 0x0016E50E File Offset: 0x0016C70E
		static USceneRayTracingGICaptureComponentCube()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SceneRayTracingGICaptureComponentCube");
		}

		// Token: 0x0600F784 RID: 63364 RVA: 0x0016E51C File Offset: 0x0016C71C
		protected USceneRayTracingGICaptureComponentCube(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040085B9 RID: 34233
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SceneRayTracingGICaptureComponentCube";

		// Token: 0x040085BA RID: 34234
		private static IntPtr _ClassPtr;

		// Token: 0x040085BB RID: 34235
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040085BC RID: 34236
		internal static int __PropertyOffset_TextureTarget;

		// Token: 0x040085BD RID: 34237
		internal static int __PropertyOffset_bCaptureRotation;

		// Token: 0x040085BE RID: 34238
		internal static int __PropertyOffset_TextureTargetLeft;

		// Token: 0x040085BF RID: 34239
		internal static int __PropertyOffset_TextureTargetRight;

		// Token: 0x040085C0 RID: 34240
		internal static int __PropertyOffset_TextureTargetODS;

		// Token: 0x040085C1 RID: 34241
		internal static int __PropertyOffset_IPD;
	}
}
