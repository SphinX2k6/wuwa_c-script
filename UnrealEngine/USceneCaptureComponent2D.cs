using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020010D4 RID: 4308
	[UnrealObjectPath("/Script/Engine.SceneCaptureComponent2D")]
	[UnrealStructLayout(3680, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 3680)]
	public class USceneCaptureComponent2D : USceneCaptureComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600F5F2 RID: 62962 RVA: 0x0016C72D File Offset: 0x0016A92D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USceneCaptureComponent2D._ClassPtr;
		}

		// Token: 0x0600F5F3 RID: 62963 RVA: 0x0016C73C File Offset: 0x0016A93C
		public USceneCaptureComponent2D() : this(BuiltinUtils.AllocNativeUObject(USceneCaptureComponent2D.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600F5F4 RID: 62964 RVA: 0x0016C764 File Offset: 0x0016A964
		[NullableContext(1)]
		public USceneCaptureComponent2D(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USceneCaptureComponent2D.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003BE4 RID: 15332
		// (get) Token: 0x0600F5F5 RID: 62965 RVA: 0x0016C797 File Offset: 0x0016A997
		// (set) Token: 0x0600F5F6 RID: 62966 RVA: 0x0016C7B0 File Offset: 0x0016A9B0
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

		// Token: 0x17003BE5 RID: 15333
		// (get) Token: 0x0600F5F7 RID: 62967 RVA: 0x0016C7E0 File Offset: 0x0016A9E0
		// (set) Token: 0x0600F5F8 RID: 62968 RVA: 0x0016C7F0 File Offset: 0x0016A9F0
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

		// Token: 0x17003BE6 RID: 15334
		// (get) Token: 0x0600F5F9 RID: 62969 RVA: 0x0016C801 File Offset: 0x0016AA01
		// (set) Token: 0x0600F5FA RID: 62970 RVA: 0x0016C811 File Offset: 0x0016AA11
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

		// Token: 0x17003BE7 RID: 15335
		// (get) Token: 0x0600F5FB RID: 62971 RVA: 0x0016C822 File Offset: 0x0016AA22
		// (set) Token: 0x0600F5FC RID: 62972 RVA: 0x0016C832 File Offset: 0x0016AA32
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

		// Token: 0x17003BE8 RID: 15336
		// (get) Token: 0x0600F5FD RID: 62973 RVA: 0x0016C843 File Offset: 0x0016AA43
		// (set) Token: 0x0600F5FE RID: 62974 RVA: 0x0016C853 File Offset: 0x0016AA53
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

		// Token: 0x17003BE9 RID: 15337
		// (get) Token: 0x0600F5FF RID: 62975 RVA: 0x0016C864 File Offset: 0x0016AA64
		// (set) Token: 0x0600F600 RID: 62976 RVA: 0x0016C874 File Offset: 0x0016AA74
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

		// Token: 0x17003BEA RID: 15338
		// (get) Token: 0x0600F601 RID: 62977 RVA: 0x0016C885 File Offset: 0x0016AA85
		// (set) Token: 0x0600F602 RID: 62978 RVA: 0x0016C895 File Offset: 0x0016AA95
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

		// Token: 0x17003BEB RID: 15339
		// (get) Token: 0x0600F603 RID: 62979 RVA: 0x0016C8A6 File Offset: 0x0016AAA6
		// (set) Token: 0x0600F604 RID: 62980 RVA: 0x0016C8BA File Offset: 0x0016AABA
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

		// Token: 0x17003BEC RID: 15340
		// (get) Token: 0x0600F605 RID: 62981 RVA: 0x0016C8CF File Offset: 0x0016AACF
		// (set) Token: 0x0600F606 RID: 62982 RVA: 0x0016C8DF File Offset: 0x0016AADF
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

		// Token: 0x17003BED RID: 15341
		// (get) Token: 0x0600F607 RID: 62983 RVA: 0x0016C8F0 File Offset: 0x0016AAF0
		// (set) Token: 0x0600F608 RID: 62984 RVA: 0x0016C900 File Offset: 0x0016AB00
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

		// Token: 0x17003BEE RID: 15342
		// (get) Token: 0x0600F609 RID: 62985 RVA: 0x0016C911 File Offset: 0x0016AB11
		// (set) Token: 0x0600F60A RID: 62986 RVA: 0x0016C925 File Offset: 0x0016AB25
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

		// Token: 0x17003BEF RID: 15343
		// (get) Token: 0x0600F60B RID: 62987 RVA: 0x0016C93A File Offset: 0x0016AB3A
		// (set) Token: 0x0600F60C RID: 62988 RVA: 0x0016C94E File Offset: 0x0016AB4E
		public unsafe TEnumAsByte<ESceneCaptureCompositeMode> CompositeMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USceneCaptureComponent2D.__PropertyOffset_CompositeMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USceneCaptureComponent2D.__PropertyOffset_CompositeMode) = value;
			}
		}

		// Token: 0x17003BF0 RID: 15344
		// (get) Token: 0x0600F60D RID: 62989 RVA: 0x0016C964 File Offset: 0x0016AB64
		// (set) Token: 0x0600F60E RID: 62990 RVA: 0x0016C99D File Offset: 0x0016AB9D
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

		// Token: 0x17003BF1 RID: 15345
		// (get) Token: 0x0600F60F RID: 62991 RVA: 0x0016C9BE File Offset: 0x0016ABBE
		// (set) Token: 0x0600F610 RID: 62992 RVA: 0x0016C9CE File Offset: 0x0016ABCE
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

		// Token: 0x17003BF2 RID: 15346
		// (get) Token: 0x0600F611 RID: 62993 RVA: 0x0016C9DF File Offset: 0x0016ABDF
		// (set) Token: 0x0600F612 RID: 62994 RVA: 0x0016C9F8 File Offset: 0x0016ABF8
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

		// Token: 0x17003BF3 RID: 15347
		// (get) Token: 0x0600F613 RID: 62995 RVA: 0x0016CA28 File Offset: 0x0016AC28
		// (set) Token: 0x0600F614 RID: 62996 RVA: 0x0016CA38 File Offset: 0x0016AC38
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

		// Token: 0x17003BF4 RID: 15348
		// (get) Token: 0x0600F615 RID: 62997 RVA: 0x0016CA49 File Offset: 0x0016AC49
		// (set) Token: 0x0600F616 RID: 62998 RVA: 0x0016CA62 File Offset: 0x0016AC62
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

		// Token: 0x17003BF5 RID: 15349
		// (get) Token: 0x0600F617 RID: 62999 RVA: 0x0016CA92 File Offset: 0x0016AC92
		// (set) Token: 0x0600F618 RID: 63000 RVA: 0x0016CAA2 File Offset: 0x0016ACA2
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

		// Token: 0x17003BF6 RID: 15350
		// (get) Token: 0x0600F619 RID: 63001 RVA: 0x0016CAB3 File Offset: 0x0016ACB3
		// (set) Token: 0x0600F61A RID: 63002 RVA: 0x0016CAC3 File Offset: 0x0016ACC3
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

		// Token: 0x17003BF7 RID: 15351
		// (get) Token: 0x0600F61B RID: 63003 RVA: 0x0016CAD4 File Offset: 0x0016ACD4
		// (set) Token: 0x0600F61C RID: 63004 RVA: 0x0016CAE8 File Offset: 0x0016ACE8
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

		// Token: 0x17003BF8 RID: 15352
		// (get) Token: 0x0600F61D RID: 63005 RVA: 0x0016CAFD File Offset: 0x0016ACFD
		// (set) Token: 0x0600F61E RID: 63006 RVA: 0x0016CB0D File Offset: 0x0016AD0D
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

		// Token: 0x17003BF9 RID: 15353
		// (get) Token: 0x0600F61F RID: 63007 RVA: 0x0016CB1E File Offset: 0x0016AD1E
		// (set) Token: 0x0600F620 RID: 63008 RVA: 0x0016CB32 File Offset: 0x0016AD32
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

		// Token: 0x17003BFA RID: 15354
		// (get) Token: 0x0600F621 RID: 63009 RVA: 0x0016CB47 File Offset: 0x0016AD47
		// (set) Token: 0x0600F622 RID: 63010 RVA: 0x0016CB5B File Offset: 0x0016AD5B
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

		// Token: 0x17003BFB RID: 15355
		// (get) Token: 0x0600F623 RID: 63011 RVA: 0x0016CB70 File Offset: 0x0016AD70
		// (set) Token: 0x0600F624 RID: 63012 RVA: 0x0016CB89 File Offset: 0x0016AD89
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

		// Token: 0x17003BFC RID: 15356
		// (get) Token: 0x0600F625 RID: 63013 RVA: 0x0016CBB9 File Offset: 0x0016ADB9
		// (set) Token: 0x0600F626 RID: 63014 RVA: 0x0016CBD2 File Offset: 0x0016ADD2
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

		// Token: 0x17003BFD RID: 15357
		// (get) Token: 0x0600F627 RID: 63015 RVA: 0x0016CC02 File Offset: 0x0016AE02
		// (set) Token: 0x0600F628 RID: 63016 RVA: 0x0016CC12 File Offset: 0x0016AE12
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

		// Token: 0x0600F629 RID: 63017 RVA: 0x0016CC23 File Offset: 0x0016AE23
		[NullableContext(2)]
		public void UpdateCaptureParams(in FSceneCaptureComponent2DParams Params, bool ForceCaptureOnce)
		{
			USceneCaptureComponent2D.__UpdateCaptureParams_Internal(base.NativePtr, (Params ?? new FSceneCaptureComponent2DParams()).NativePtr, ForceCaptureOnce);
		}

		// Token: 0x0600F62A RID: 63018 RVA: 0x0016CC41 File Offset: 0x0016AE41
		public void CaptureScene()
		{
			USceneCaptureComponent2D.__CaptureScene_Internal(base.NativePtr);
		}

		// Token: 0x0600F62B RID: 63019 RVA: 0x0016CC50 File Offset: 0x0016AE50
		[NullableContext(2)]
		public void AddOrUpdateBlendable(IBlendableInterface InBlendableObject, float InWeight = 1f)
		{
			FScriptInterface fscriptInterface = new FScriptInterface(InBlendableObject, (InBlendableObject != null) ? InBlendableObject.InterfaceOffset() : 0);
			USceneCaptureComponent2D.__AddOrUpdateBlendable_Internal(base.NativePtr, fscriptInterface, InWeight);
		}

		// Token: 0x0600F62C RID: 63020
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateCaptureParams_Internal(IntPtr @this, IntPtr Params, bool ForceCaptureOnce);

		// Token: 0x0600F62D RID: 63021
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CaptureScene_Internal(IntPtr @this);

		// Token: 0x0600F62E RID: 63022
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddOrUpdateBlendable_Internal(IntPtr @this, in FScriptInterface InBlendableObject, float InWeight);

		// Token: 0x0600F62F RID: 63023 RVA: 0x0016CC7F File Offset: 0x0016AE7F
		static USceneCaptureComponent2D()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SceneCaptureComponent2D");
		}

		// Token: 0x0600F630 RID: 63024 RVA: 0x0016CC8D File Offset: 0x0016AE8D
		protected USceneCaptureComponent2D(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008539 RID: 34105
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SceneCaptureComponent2D";

		// Token: 0x0400853A RID: 34106
		private static IntPtr _ClassPtr;

		// Token: 0x0400853B RID: 34107
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400853C RID: 34108
		internal static int __PropertyOffset_bForceCaptureOnce;

		// Token: 0x0400853D RID: 34109
		internal static byte __PropertyMask_bForceCaptureOnce;

		// Token: 0x0400853E RID: 34110
		internal static int __PropertyOffset_bEnableCapture;

		// Token: 0x0400853F RID: 34111
		internal static int __PropertyOffset_CaptureInterval;

		// Token: 0x04008540 RID: 34112
		internal static int __PropertyOffset_CaptureMaxRTSize;

		// Token: 0x04008541 RID: 34113
		internal static int __PropertyOffset_CaptureMaxRTSizeXScale;

		// Token: 0x04008542 RID: 34114
		internal static int __PropertyOffset_CaptureMaxRTSizeYScale;

		// Token: 0x04008543 RID: 34115
		internal static int __PropertyOffset_bIgnoreCaptureMaxRTSize;

		// Token: 0x04008544 RID: 34116
		internal static int __PropertyOffset_ProjectionType;

		// Token: 0x04008545 RID: 34117
		internal static int __PropertyOffset_FOVAngle;

		// Token: 0x04008546 RID: 34118
		internal static int __PropertyOffset_OrthoWidth;

		// Token: 0x04008547 RID: 34119
		internal static int __PropertyOffset_TextureTarget;

		// Token: 0x04008548 RID: 34120
		internal static int __PropertyOffset_CompositeMode;

		// Token: 0x04008549 RID: 34121
		internal static int __PropertyOffset_PostProcessSettings;

		// Token: 0x0400854A RID: 34122
		[Nullable(2)]
		private FPostProcessSettings _PostProcessSettings;

		// Token: 0x0400854B RID: 34123
		internal static int __PropertyOffset_PostProcessBlendWeight;

		// Token: 0x0400854C RID: 34124
		internal static int __PropertyOffset_bOverride_CustomNearClippingPlane;

		// Token: 0x0400854D RID: 34125
		internal static byte __PropertyMask_bOverride_CustomNearClippingPlane;

		// Token: 0x0400854E RID: 34126
		internal static int __PropertyOffset_CustomNearClippingPlane;

		// Token: 0x0400854F RID: 34127
		internal static int __PropertyOffset_bUseCustomAspectRatio;

		// Token: 0x04008550 RID: 34128
		internal static byte __PropertyMask_bUseCustomAspectRatio;

		// Token: 0x04008551 RID: 34129
		internal static int __PropertyOffset_CustomAspectRatio;

		// Token: 0x04008552 RID: 34130
		internal static int __PropertyOffset_bUseCustomProjectionMatrix;

		// Token: 0x04008553 RID: 34131
		internal static int __PropertyOffset_CustomProjectionMatrix;

		// Token: 0x04008554 RID: 34132
		internal static int __PropertyOffset_bEnableClipPlane;

		// Token: 0x04008555 RID: 34133
		internal static int __PropertyOffset_ClipPlaneBase;

		// Token: 0x04008556 RID: 34134
		internal static int __PropertyOffset_ClipPlaneNormal;

		// Token: 0x04008557 RID: 34135
		internal static int __PropertyOffset_bCameraCutThisFrame;

		// Token: 0x04008558 RID: 34136
		internal static byte __PropertyMask_bCameraCutThisFrame;

		// Token: 0x04008559 RID: 34137
		internal static int __PropertyOffset_bConsiderUnrenderedOpaquePixelAsFullyTranslucent;

		// Token: 0x0400855A RID: 34138
		internal static byte __PropertyMask_bConsiderUnrenderedOpaquePixelAsFullyTranslucent;

		// Token: 0x0400855B RID: 34139
		internal static int __PropertyOffset_bDisableFlipCopyGLES;
	}
}
