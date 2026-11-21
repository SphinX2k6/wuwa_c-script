using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000277 RID: 631
	[UnrealObjectPath("/Script/Engine.SceneCaptureComponent2D")]
	[UnrealStructLayout(3728, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 3728)]
	public class USceneCaptureComponent2D : USceneCaptureComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060040A9 RID: 16553 RVA: 0x0005CCB9 File Offset: 0x0005AEB9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USceneCaptureComponent2D._ClassPtr;
		}

		// Token: 0x060040AA RID: 16554 RVA: 0x0005CCC8 File Offset: 0x0005AEC8
		public USceneCaptureComponent2D() : this(BuiltinUtils.AllocNativeUObject(USceneCaptureComponent2D.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060040AB RID: 16555 RVA: 0x0005CCF0 File Offset: 0x0005AEF0
		[NullableContext(1)]
		public USceneCaptureComponent2D(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USceneCaptureComponent2D.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000BDE RID: 3038
		// (get) Token: 0x060040AC RID: 16556 RVA: 0x0005CD23 File Offset: 0x0005AF23
		// (set) Token: 0x060040AD RID: 16557 RVA: 0x0005CD3C File Offset: 0x0005AF3C
		public unsafe bool bForceCaptureOnce
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USceneCaptureComponent2D.__PropertyOffset_bForceCaptureOnce) & USceneCaptureComponent2D.__PropertyMask_bForceCaptureOnce) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USceneCaptureComponent2D.__PropertyOffset_bForceCaptureOnce) = ((*(base.NativePtr + (IntPtr)USceneCaptureComponent2D.__PropertyOffset_bForceCaptureOnce) & ~USceneCaptureComponent2D.__PropertyMask_bForceCaptureOnce) | (value ? USceneCaptureComponent2D.__PropertyMask_bForceCaptureOnce : 0));
			}
		}

		// Token: 0x17000BDF RID: 3039
		// (get) Token: 0x060040AE RID: 16558 RVA: 0x0005CD6C File Offset: 0x0005AF6C
		// (set) Token: 0x060040AF RID: 16559 RVA: 0x0005CD7C File Offset: 0x0005AF7C
		public unsafe byte bEnableCapture
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USceneCaptureComponent2D.__PropertyOffset_bEnableCapture);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USceneCaptureComponent2D.__PropertyOffset_bEnableCapture) = value;
			}
		}

		// Token: 0x17000BE0 RID: 3040
		// (get) Token: 0x060040B0 RID: 16560 RVA: 0x0005CD8D File Offset: 0x0005AF8D
		// (set) Token: 0x060040B1 RID: 16561 RVA: 0x0005CD9D File Offset: 0x0005AF9D
		public unsafe float CaptureInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USceneCaptureComponent2D.__PropertyOffset_CaptureInterval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USceneCaptureComponent2D.__PropertyOffset_CaptureInterval) = value;
			}
		}

		// Token: 0x17000BE1 RID: 3041
		// (get) Token: 0x060040B2 RID: 16562 RVA: 0x0005CDAE File Offset: 0x0005AFAE
		// (set) Token: 0x060040B3 RID: 16563 RVA: 0x0005CDBE File Offset: 0x0005AFBE
		public unsafe int CaptureMaxRTSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USceneCaptureComponent2D.__PropertyOffset_CaptureMaxRTSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USceneCaptureComponent2D.__PropertyOffset_CaptureMaxRTSize) = value;
			}
		}

		// Token: 0x17000BE2 RID: 3042
		// (get) Token: 0x060040B4 RID: 16564 RVA: 0x0005CDCF File Offset: 0x0005AFCF
		// (set) Token: 0x060040B5 RID: 16565 RVA: 0x0005CDDF File Offset: 0x0005AFDF
		public unsafe int CaptureMaxRTSizeXScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USceneCaptureComponent2D.__PropertyOffset_CaptureMaxRTSizeXScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USceneCaptureComponent2D.__PropertyOffset_CaptureMaxRTSizeXScale) = value;
			}
		}

		// Token: 0x17000BE3 RID: 3043
		// (get) Token: 0x060040B6 RID: 16566 RVA: 0x0005CDF0 File Offset: 0x0005AFF0
		// (set) Token: 0x060040B7 RID: 16567 RVA: 0x0005CE00 File Offset: 0x0005B000
		public unsafe int CaptureMaxRTSizeYScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USceneCaptureComponent2D.__PropertyOffset_CaptureMaxRTSizeYScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USceneCaptureComponent2D.__PropertyOffset_CaptureMaxRTSizeYScale) = value;
			}
		}

		// Token: 0x17000BE4 RID: 3044
		// (get) Token: 0x060040B8 RID: 16568 RVA: 0x0005CE11 File Offset: 0x0005B011
		// (set) Token: 0x060040B9 RID: 16569 RVA: 0x0005CE21 File Offset: 0x0005B021
		public unsafe bool bIgnoreCaptureMaxRTSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USceneCaptureComponent2D.__PropertyOffset_bIgnoreCaptureMaxRTSize) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USceneCaptureComponent2D.__PropertyOffset_bIgnoreCaptureMaxRTSize) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000BE5 RID: 3045
		// (get) Token: 0x060040BA RID: 16570 RVA: 0x0005CE32 File Offset: 0x0005B032
		// (set) Token: 0x060040BB RID: 16571 RVA: 0x0005CE46 File Offset: 0x0005B046
		public unsafe TEnumAsByte<ECameraProjectionMode> ProjectionType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USceneCaptureComponent2D.__PropertyOffset_ProjectionType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USceneCaptureComponent2D.__PropertyOffset_ProjectionType) = value;
			}
		}

		// Token: 0x17000BE6 RID: 3046
		// (get) Token: 0x060040BC RID: 16572 RVA: 0x0005CE5B File Offset: 0x0005B05B
		// (set) Token: 0x060040BD RID: 16573 RVA: 0x0005CE6B File Offset: 0x0005B06B
		public unsafe float FOVAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USceneCaptureComponent2D.__PropertyOffset_FOVAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USceneCaptureComponent2D.__PropertyOffset_FOVAngle) = value;
			}
		}

		// Token: 0x17000BE7 RID: 3047
		// (get) Token: 0x060040BE RID: 16574 RVA: 0x0005CE7C File Offset: 0x0005B07C
		// (set) Token: 0x060040BF RID: 16575 RVA: 0x0005CE8C File Offset: 0x0005B08C
		public unsafe float OrthoWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USceneCaptureComponent2D.__PropertyOffset_OrthoWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USceneCaptureComponent2D.__PropertyOffset_OrthoWidth) = value;
			}
		}

		// Token: 0x17000BE8 RID: 3048
		// (get) Token: 0x060040C0 RID: 16576 RVA: 0x0005CE9D File Offset: 0x0005B09D
		// (set) Token: 0x060040C1 RID: 16577 RVA: 0x0005CEB1 File Offset: 0x0005B0B1
		[Nullable(2)]
		public unsafe UTextureRenderTarget2D TextureTarget
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + USceneCaptureComponent2D.__PropertyOffset_TextureTarget);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USceneCaptureComponent2D.__PropertyOffset_TextureTarget, value);
			}
		}

		// Token: 0x17000BE9 RID: 3049
		// (get) Token: 0x060040C2 RID: 16578 RVA: 0x0005CEC8 File Offset: 0x0005B0C8
		// (set) Token: 0x060040C3 RID: 16579 RVA: 0x0005CF01 File Offset: 0x0005B101
		[Nullable(1)]
		public FPostProcessSettings PostProcessSettings
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FPostProcessSettings result;
				if ((result = this._PostProcessSettings) == null)
				{
					result = (this._PostProcessSettings = new FPostProcessSettings(base.NativePtr + (IntPtr)USceneCaptureComponent2D.__PropertyOffset_PostProcessSettings, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPostProcessSettings.StaticStruct(), base.NativePtr + (IntPtr)USceneCaptureComponent2D.__PropertyOffset_PostProcessSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000BEA RID: 3050
		// (get) Token: 0x060040C4 RID: 16580 RVA: 0x0005CF22 File Offset: 0x0005B122
		// (set) Token: 0x060040C5 RID: 16581 RVA: 0x0005CF32 File Offset: 0x0005B132
		public unsafe float PostProcessBlendWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USceneCaptureComponent2D.__PropertyOffset_PostProcessBlendWeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USceneCaptureComponent2D.__PropertyOffset_PostProcessBlendWeight) = value;
			}
		}

		// Token: 0x17000BEB RID: 3051
		// (get) Token: 0x060040C6 RID: 16582 RVA: 0x0005CF43 File Offset: 0x0005B143
		// (set) Token: 0x060040C7 RID: 16583 RVA: 0x0005CF5C File Offset: 0x0005B15C
		public unsafe bool bOverride_CustomNearClippingPlane
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USceneCaptureComponent2D.__PropertyOffset_bOverride_CustomNearClippingPlane) & USceneCaptureComponent2D.__PropertyMask_bOverride_CustomNearClippingPlane) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USceneCaptureComponent2D.__PropertyOffset_bOverride_CustomNearClippingPlane) = ((*(base.NativePtr + (IntPtr)USceneCaptureComponent2D.__PropertyOffset_bOverride_CustomNearClippingPlane) & ~USceneCaptureComponent2D.__PropertyMask_bOverride_CustomNearClippingPlane) | (value ? USceneCaptureComponent2D.__PropertyMask_bOverride_CustomNearClippingPlane : 0));
			}
		}

		// Token: 0x17000BEC RID: 3052
		// (get) Token: 0x060040C8 RID: 16584 RVA: 0x0005CF8C File Offset: 0x0005B18C
		// (set) Token: 0x060040C9 RID: 16585 RVA: 0x0005CF9C File Offset: 0x0005B19C
		public unsafe float CustomNearClippingPlane
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USceneCaptureComponent2D.__PropertyOffset_CustomNearClippingPlane);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USceneCaptureComponent2D.__PropertyOffset_CustomNearClippingPlane) = value;
			}
		}

		// Token: 0x17000BED RID: 3053
		// (get) Token: 0x060040CA RID: 16586 RVA: 0x0005CFAD File Offset: 0x0005B1AD
		// (set) Token: 0x060040CB RID: 16587 RVA: 0x0005CFC6 File Offset: 0x0005B1C6
		public unsafe bool bUseCustomAspectRatio
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USceneCaptureComponent2D.__PropertyOffset_bUseCustomAspectRatio) & USceneCaptureComponent2D.__PropertyMask_bUseCustomAspectRatio) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USceneCaptureComponent2D.__PropertyOffset_bUseCustomAspectRatio) = ((*(base.NativePtr + (IntPtr)USceneCaptureComponent2D.__PropertyOffset_bUseCustomAspectRatio) & ~USceneCaptureComponent2D.__PropertyMask_bUseCustomAspectRatio) | (value ? USceneCaptureComponent2D.__PropertyMask_bUseCustomAspectRatio : 0));
			}
		}

		// Token: 0x17000BEE RID: 3054
		// (get) Token: 0x060040CC RID: 16588 RVA: 0x0005CFF6 File Offset: 0x0005B1F6
		// (set) Token: 0x060040CD RID: 16589 RVA: 0x0005D006 File Offset: 0x0005B206
		public unsafe float CustomAspectRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USceneCaptureComponent2D.__PropertyOffset_CustomAspectRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USceneCaptureComponent2D.__PropertyOffset_CustomAspectRatio) = value;
			}
		}

		// Token: 0x17000BEF RID: 3055
		// (get) Token: 0x060040CE RID: 16590 RVA: 0x0005D017 File Offset: 0x0005B217
		// (set) Token: 0x060040CF RID: 16591 RVA: 0x0005D027 File Offset: 0x0005B227
		public unsafe bool bUseCustomProjectionMatrix
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USceneCaptureComponent2D.__PropertyOffset_bUseCustomProjectionMatrix) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USceneCaptureComponent2D.__PropertyOffset_bUseCustomProjectionMatrix) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000BF0 RID: 3056
		// (get) Token: 0x060040D0 RID: 16592 RVA: 0x0005D038 File Offset: 0x0005B238
		// (set) Token: 0x060040D1 RID: 16593 RVA: 0x0005D04C File Offset: 0x0005B24C
		public unsafe FMatrix CustomProjectionMatrix
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USceneCaptureComponent2D.__PropertyOffset_CustomProjectionMatrix);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USceneCaptureComponent2D.__PropertyOffset_CustomProjectionMatrix) = value;
			}
		}

		// Token: 0x17000BF1 RID: 3057
		// (get) Token: 0x060040D2 RID: 16594 RVA: 0x0005D061 File Offset: 0x0005B261
		// (set) Token: 0x060040D3 RID: 16595 RVA: 0x0005D071 File Offset: 0x0005B271
		public unsafe bool bEnableClipPlane
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USceneCaptureComponent2D.__PropertyOffset_bEnableClipPlane) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USceneCaptureComponent2D.__PropertyOffset_bEnableClipPlane) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000BF2 RID: 3058
		// (get) Token: 0x060040D4 RID: 16596 RVA: 0x0005D082 File Offset: 0x0005B282
		// (set) Token: 0x060040D5 RID: 16597 RVA: 0x0005D096 File Offset: 0x0005B296
		public unsafe FVector ClipPlaneBase
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USceneCaptureComponent2D.__PropertyOffset_ClipPlaneBase);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USceneCaptureComponent2D.__PropertyOffset_ClipPlaneBase) = value;
			}
		}

		// Token: 0x17000BF3 RID: 3059
		// (get) Token: 0x060040D6 RID: 16598 RVA: 0x0005D0AB File Offset: 0x0005B2AB
		// (set) Token: 0x060040D7 RID: 16599 RVA: 0x0005D0BF File Offset: 0x0005B2BF
		public unsafe FVector ClipPlaneNormal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USceneCaptureComponent2D.__PropertyOffset_ClipPlaneNormal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USceneCaptureComponent2D.__PropertyOffset_ClipPlaneNormal) = value;
			}
		}

		// Token: 0x17000BF4 RID: 3060
		// (get) Token: 0x060040D8 RID: 16600 RVA: 0x0005D0D4 File Offset: 0x0005B2D4
		// (set) Token: 0x060040D9 RID: 16601 RVA: 0x0005D0ED File Offset: 0x0005B2ED
		public unsafe bool bCameraCutThisFrame
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USceneCaptureComponent2D.__PropertyOffset_bCameraCutThisFrame) & USceneCaptureComponent2D.__PropertyMask_bCameraCutThisFrame) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USceneCaptureComponent2D.__PropertyOffset_bCameraCutThisFrame) = ((*(base.NativePtr + (IntPtr)USceneCaptureComponent2D.__PropertyOffset_bCameraCutThisFrame) & ~USceneCaptureComponent2D.__PropertyMask_bCameraCutThisFrame) | (value ? USceneCaptureComponent2D.__PropertyMask_bCameraCutThisFrame : 0));
			}
		}

		// Token: 0x17000BF5 RID: 3061
		// (get) Token: 0x060040DA RID: 16602 RVA: 0x0005D11D File Offset: 0x0005B31D
		// (set) Token: 0x060040DB RID: 16603 RVA: 0x0005D136 File Offset: 0x0005B336
		public unsafe bool bConsiderUnrenderedOpaquePixelAsFullyTranslucent
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USceneCaptureComponent2D.__PropertyOffset_bConsiderUnrenderedOpaquePixelAsFullyTranslucent) & USceneCaptureComponent2D.__PropertyMask_bConsiderUnrenderedOpaquePixelAsFullyTranslucent) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USceneCaptureComponent2D.__PropertyOffset_bConsiderUnrenderedOpaquePixelAsFullyTranslucent) = ((*(base.NativePtr + (IntPtr)USceneCaptureComponent2D.__PropertyOffset_bConsiderUnrenderedOpaquePixelAsFullyTranslucent) & ~USceneCaptureComponent2D.__PropertyMask_bConsiderUnrenderedOpaquePixelAsFullyTranslucent) | (value ? USceneCaptureComponent2D.__PropertyMask_bConsiderUnrenderedOpaquePixelAsFullyTranslucent : 0));
			}
		}

		// Token: 0x17000BF6 RID: 3062
		// (get) Token: 0x060040DC RID: 16604 RVA: 0x0005D166 File Offset: 0x0005B366
		// (set) Token: 0x060040DD RID: 16605 RVA: 0x0005D176 File Offset: 0x0005B376
		public unsafe bool bDisableFlipCopyGLES
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USceneCaptureComponent2D.__PropertyOffset_bDisableFlipCopyGLES) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USceneCaptureComponent2D.__PropertyOffset_bDisableFlipCopyGLES) = (value ? 1 : 0);
			}
		}

		// Token: 0x060040DE RID: 16606 RVA: 0x0005D187 File Offset: 0x0005B387
		[NullableContext(2)]
		public void UpdateCaptureParams(in FSceneCaptureComponent2DParams Params, bool ForceCaptureOnce)
		{
			USceneCaptureComponent2D.__UpdateCaptureParams_Internal(base.NativePtr, (Params ?? new FSceneCaptureComponent2DParams()).NativePtr, ForceCaptureOnce);
		}

		// Token: 0x060040DF RID: 16607 RVA: 0x0005D1A5 File Offset: 0x0005B3A5
		public void CaptureScene()
		{
			USceneCaptureComponent2D.__CaptureScene_Internal(base.NativePtr);
		}

		// Token: 0x060040E0 RID: 16608
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateCaptureParams_Internal(IntPtr @this, IntPtr Params, bool ForceCaptureOnce);

		// Token: 0x060040E1 RID: 16609
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CaptureScene_Internal(IntPtr @this);

		// Token: 0x060040E2 RID: 16610 RVA: 0x0005D1B2 File Offset: 0x0005B3B2
		static USceneCaptureComponent2D()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SceneCaptureComponent2D");
		}

		// Token: 0x060040E3 RID: 16611 RVA: 0x0005D1C0 File Offset: 0x0005B3C0
		protected USceneCaptureComponent2D(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400195F RID: 6495
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SceneCaptureComponent2D";

		// Token: 0x04001960 RID: 6496
		private static IntPtr _ClassPtr;

		// Token: 0x04001961 RID: 6497
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001962 RID: 6498
		internal static int __PropertyOffset_bForceCaptureOnce;

		// Token: 0x04001963 RID: 6499
		internal static byte __PropertyMask_bForceCaptureOnce;

		// Token: 0x04001964 RID: 6500
		internal static int __PropertyOffset_bEnableCapture;

		// Token: 0x04001965 RID: 6501
		internal static int __PropertyOffset_CaptureInterval;

		// Token: 0x04001966 RID: 6502
		internal static int __PropertyOffset_CaptureMaxRTSize;

		// Token: 0x04001967 RID: 6503
		internal static int __PropertyOffset_CaptureMaxRTSizeXScale;

		// Token: 0x04001968 RID: 6504
		internal static int __PropertyOffset_CaptureMaxRTSizeYScale;

		// Token: 0x04001969 RID: 6505
		internal static int __PropertyOffset_bIgnoreCaptureMaxRTSize;

		// Token: 0x0400196A RID: 6506
		internal static int __PropertyOffset_ProjectionType;

		// Token: 0x0400196B RID: 6507
		internal static int __PropertyOffset_FOVAngle;

		// Token: 0x0400196C RID: 6508
		internal static int __PropertyOffset_OrthoWidth;

		// Token: 0x0400196D RID: 6509
		internal static int __PropertyOffset_TextureTarget;

		// Token: 0x0400196E RID: 6510
		internal static int __PropertyOffset_PostProcessSettings;

		// Token: 0x0400196F RID: 6511
		[Nullable(2)]
		private FPostProcessSettings _PostProcessSettings;

		// Token: 0x04001970 RID: 6512
		internal static int __PropertyOffset_PostProcessBlendWeight;

		// Token: 0x04001971 RID: 6513
		internal static int __PropertyOffset_bOverride_CustomNearClippingPlane;

		// Token: 0x04001972 RID: 6514
		internal static byte __PropertyMask_bOverride_CustomNearClippingPlane;

		// Token: 0x04001973 RID: 6515
		internal static int __PropertyOffset_CustomNearClippingPlane;

		// Token: 0x04001974 RID: 6516
		internal static int __PropertyOffset_bUseCustomAspectRatio;

		// Token: 0x04001975 RID: 6517
		internal static byte __PropertyMask_bUseCustomAspectRatio;

		// Token: 0x04001976 RID: 6518
		internal static int __PropertyOffset_CustomAspectRatio;

		// Token: 0x04001977 RID: 6519
		internal static int __PropertyOffset_bUseCustomProjectionMatrix;

		// Token: 0x04001978 RID: 6520
		internal static int __PropertyOffset_CustomProjectionMatrix;

		// Token: 0x04001979 RID: 6521
		internal static int __PropertyOffset_bEnableClipPlane;

		// Token: 0x0400197A RID: 6522
		internal static int __PropertyOffset_ClipPlaneBase;

		// Token: 0x0400197B RID: 6523
		internal static int __PropertyOffset_ClipPlaneNormal;

		// Token: 0x0400197C RID: 6524
		internal static int __PropertyOffset_bCameraCutThisFrame;

		// Token: 0x0400197D RID: 6525
		internal static byte __PropertyMask_bCameraCutThisFrame;

		// Token: 0x0400197E RID: 6526
		internal static int __PropertyOffset_bConsiderUnrenderedOpaquePixelAsFullyTranslucent;

		// Token: 0x0400197F RID: 6527
		internal static byte __PropertyMask_bConsiderUnrenderedOpaquePixelAsFullyTranslucent;

		// Token: 0x04001980 RID: 6528
		internal static int __PropertyOffset_bDisableFlipCopyGLES;
	}
}
