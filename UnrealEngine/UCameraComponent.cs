using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200090B RID: 2315
	[UnrealObjectPath("/Script/Engine.CameraComponent")]
	[UnrealStructLayout(3328, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 3328)]
	public class UCameraComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007F11 RID: 32529 RVA: 0x000B645E File Offset: 0x000B465E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCameraComponent._ClassPtr;
		}

		// Token: 0x06007F12 RID: 32530 RVA: 0x000B646C File Offset: 0x000B466C
		public UCameraComponent() : this(BuiltinUtils.AllocNativeUObject(UCameraComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007F13 RID: 32531 RVA: 0x000B6494 File Offset: 0x000B4694
		[NullableContext(1)]
		public UCameraComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UCameraComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001DDF RID: 7647
		// (get) Token: 0x06007F14 RID: 32532 RVA: 0x000B64C7 File Offset: 0x000B46C7
		// (set) Token: 0x06007F15 RID: 32533 RVA: 0x000B64D7 File Offset: 0x000B46D7
		public unsafe float FieldOfView
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCameraComponent.__PropertyOffset_FieldOfView);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCameraComponent.__PropertyOffset_FieldOfView) = value;
			}
		}

		// Token: 0x17001DE0 RID: 7648
		// (get) Token: 0x06007F16 RID: 32534 RVA: 0x000B64E8 File Offset: 0x000B46E8
		// (set) Token: 0x06007F17 RID: 32535 RVA: 0x000B64F8 File Offset: 0x000B46F8
		public unsafe float OrthoWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCameraComponent.__PropertyOffset_OrthoWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCameraComponent.__PropertyOffset_OrthoWidth) = value;
			}
		}

		// Token: 0x17001DE1 RID: 7649
		// (get) Token: 0x06007F18 RID: 32536 RVA: 0x000B6509 File Offset: 0x000B4709
		// (set) Token: 0x06007F19 RID: 32537 RVA: 0x000B6519 File Offset: 0x000B4719
		public unsafe float OrthoNearClipPlane
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCameraComponent.__PropertyOffset_OrthoNearClipPlane);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCameraComponent.__PropertyOffset_OrthoNearClipPlane) = value;
			}
		}

		// Token: 0x17001DE2 RID: 7650
		// (get) Token: 0x06007F1A RID: 32538 RVA: 0x000B652A File Offset: 0x000B472A
		// (set) Token: 0x06007F1B RID: 32539 RVA: 0x000B653A File Offset: 0x000B473A
		public unsafe float OrthoFarClipPlane
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCameraComponent.__PropertyOffset_OrthoFarClipPlane);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCameraComponent.__PropertyOffset_OrthoFarClipPlane) = value;
			}
		}

		// Token: 0x17001DE3 RID: 7651
		// (get) Token: 0x06007F1C RID: 32540 RVA: 0x000B654B File Offset: 0x000B474B
		// (set) Token: 0x06007F1D RID: 32541 RVA: 0x000B655B File Offset: 0x000B475B
		public unsafe float AspectRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCameraComponent.__PropertyOffset_AspectRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCameraComponent.__PropertyOffset_AspectRatio) = value;
			}
		}

		// Token: 0x17001DE4 RID: 7652
		// (get) Token: 0x06007F1E RID: 32542 RVA: 0x000B656C File Offset: 0x000B476C
		// (set) Token: 0x06007F1F RID: 32543 RVA: 0x000B6585 File Offset: 0x000B4785
		public unsafe bool bConstrainAspectRatio
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCameraComponent.__PropertyOffset_bConstrainAspectRatio) & UCameraComponent.__PropertyMask_bConstrainAspectRatio) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCameraComponent.__PropertyOffset_bConstrainAspectRatio) = ((*(base.NativePtr + (IntPtr)UCameraComponent.__PropertyOffset_bConstrainAspectRatio) & ~UCameraComponent.__PropertyMask_bConstrainAspectRatio) | (value ? UCameraComponent.__PropertyMask_bConstrainAspectRatio : 0));
			}
		}

		// Token: 0x17001DE5 RID: 7653
		// (get) Token: 0x06007F20 RID: 32544 RVA: 0x000B65B5 File Offset: 0x000B47B5
		// (set) Token: 0x06007F21 RID: 32545 RVA: 0x000B65CE File Offset: 0x000B47CE
		public unsafe bool bUseFieldOfViewForLOD
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCameraComponent.__PropertyOffset_bUseFieldOfViewForLOD) & UCameraComponent.__PropertyMask_bUseFieldOfViewForLOD) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCameraComponent.__PropertyOffset_bUseFieldOfViewForLOD) = ((*(base.NativePtr + (IntPtr)UCameraComponent.__PropertyOffset_bUseFieldOfViewForLOD) & ~UCameraComponent.__PropertyMask_bUseFieldOfViewForLOD) | (value ? UCameraComponent.__PropertyMask_bUseFieldOfViewForLOD : 0));
			}
		}

		// Token: 0x17001DE6 RID: 7654
		// (get) Token: 0x06007F22 RID: 32546 RVA: 0x000B65FE File Offset: 0x000B47FE
		// (set) Token: 0x06007F23 RID: 32547 RVA: 0x000B6617 File Offset: 0x000B4817
		public unsafe bool bEnableScissorOffCenter
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCameraComponent.__PropertyOffset_bEnableScissorOffCenter) & UCameraComponent.__PropertyMask_bEnableScissorOffCenter) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCameraComponent.__PropertyOffset_bEnableScissorOffCenter) = ((*(base.NativePtr + (IntPtr)UCameraComponent.__PropertyOffset_bEnableScissorOffCenter) & ~UCameraComponent.__PropertyMask_bEnableScissorOffCenter) | (value ? UCameraComponent.__PropertyMask_bEnableScissorOffCenter : 0));
			}
		}

		// Token: 0x17001DE7 RID: 7655
		// (get) Token: 0x06007F24 RID: 32548 RVA: 0x000B6647 File Offset: 0x000B4847
		// (set) Token: 0x06007F25 RID: 32549 RVA: 0x000B6660 File Offset: 0x000B4860
		public unsafe bool bLockToHmd
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCameraComponent.__PropertyOffset_bLockToHmd) & UCameraComponent.__PropertyMask_bLockToHmd) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCameraComponent.__PropertyOffset_bLockToHmd) = ((*(base.NativePtr + (IntPtr)UCameraComponent.__PropertyOffset_bLockToHmd) & ~UCameraComponent.__PropertyMask_bLockToHmd) | (value ? UCameraComponent.__PropertyMask_bLockToHmd : 0));
			}
		}

		// Token: 0x17001DE8 RID: 7656
		// (get) Token: 0x06007F26 RID: 32550 RVA: 0x000B6690 File Offset: 0x000B4890
		// (set) Token: 0x06007F27 RID: 32551 RVA: 0x000B66A9 File Offset: 0x000B48A9
		public unsafe bool bUsePawnControlRotation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCameraComponent.__PropertyOffset_bUsePawnControlRotation) & UCameraComponent.__PropertyMask_bUsePawnControlRotation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCameraComponent.__PropertyOffset_bUsePawnControlRotation) = ((*(base.NativePtr + (IntPtr)UCameraComponent.__PropertyOffset_bUsePawnControlRotation) & ~UCameraComponent.__PropertyMask_bUsePawnControlRotation) | (value ? UCameraComponent.__PropertyMask_bUsePawnControlRotation : 0));
			}
		}

		// Token: 0x17001DE9 RID: 7657
		// (get) Token: 0x06007F28 RID: 32552 RVA: 0x000B66D9 File Offset: 0x000B48D9
		// (set) Token: 0x06007F29 RID: 32553 RVA: 0x000B66ED File Offset: 0x000B48ED
		public unsafe TEnumAsByte<ECameraProjectionMode> ProjectionMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCameraComponent.__PropertyOffset_ProjectionMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCameraComponent.__PropertyOffset_ProjectionMode) = value;
			}
		}

		// Token: 0x17001DEA RID: 7658
		// (get) Token: 0x06007F2A RID: 32554 RVA: 0x000B6702 File Offset: 0x000B4902
		// (set) Token: 0x06007F2B RID: 32555 RVA: 0x000B6712 File Offset: 0x000B4912
		public unsafe float PostProcessBlendWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCameraComponent.__PropertyOffset_PostProcessBlendWeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCameraComponent.__PropertyOffset_PostProcessBlendWeight) = value;
			}
		}

		// Token: 0x17001DEB RID: 7659
		// (get) Token: 0x06007F2C RID: 32556 RVA: 0x000B6724 File Offset: 0x000B4924
		// (set) Token: 0x06007F2D RID: 32557 RVA: 0x000B675D File Offset: 0x000B495D
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
					result = (this._PostProcessSettings = new FPostProcessSettings(base.NativePtr + (IntPtr)UCameraComponent.__PropertyOffset_PostProcessSettings, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPostProcessSettings.StaticStruct(), base.NativePtr + (IntPtr)UCameraComponent.__PropertyOffset_PostProcessSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06007F2E RID: 32558 RVA: 0x000B677E File Offset: 0x000B497E
		public void SetUseFieldOfViewForLOD(bool bInUseFieldOfViewForLOD)
		{
			UCameraComponent.__SetUseFieldOfViewForLOD_Internal(base.NativePtr, bInUseFieldOfViewForLOD);
		}

		// Token: 0x06007F2F RID: 32559 RVA: 0x000B678C File Offset: 0x000B498C
		public void SetProjectionMode(ECameraProjectionMode InProjectionMode)
		{
			UCameraComponent.__SetProjectionMode_Internal(base.NativePtr, InProjectionMode);
		}

		// Token: 0x06007F30 RID: 32560 RVA: 0x000B679F File Offset: 0x000B499F
		public void SetPostProcessBlendWeight(float InPostProcessBlendWeight)
		{
			UCameraComponent.__SetPostProcessBlendWeight_Internal(base.NativePtr, InPostProcessBlendWeight);
		}

		// Token: 0x06007F31 RID: 32561 RVA: 0x000B67AD File Offset: 0x000B49AD
		public void SetOrthoWidth(float InOrthoWidth)
		{
			UCameraComponent.__SetOrthoWidth_Internal(base.NativePtr, InOrthoWidth);
		}

		// Token: 0x06007F32 RID: 32562 RVA: 0x000B67BB File Offset: 0x000B49BB
		public void SetOrthoNearClipPlane(float InOrthoNearClipPlane)
		{
			UCameraComponent.__SetOrthoNearClipPlane_Internal(base.NativePtr, InOrthoNearClipPlane);
		}

		// Token: 0x06007F33 RID: 32563 RVA: 0x000B67C9 File Offset: 0x000B49C9
		public void SetOrthoFarClipPlane(float InOrthoFarClipPlane)
		{
			UCameraComponent.__SetOrthoFarClipPlane_Internal(base.NativePtr, InOrthoFarClipPlane);
		}

		// Token: 0x06007F34 RID: 32564 RVA: 0x000B67D7 File Offset: 0x000B49D7
		public void SetFieldOfView(float InFieldOfView)
		{
			UCameraComponent.__SetFieldOfView_Internal(base.NativePtr, InFieldOfView);
		}

		// Token: 0x06007F35 RID: 32565 RVA: 0x000B67E5 File Offset: 0x000B49E5
		public void SetEnableScissorOffCenter(bool bInEnableScissorOffCenter)
		{
			UCameraComponent.__SetEnableScissorOffCenter_Internal(base.NativePtr, bInEnableScissorOffCenter);
		}

		// Token: 0x06007F36 RID: 32566 RVA: 0x000B67F3 File Offset: 0x000B49F3
		public void SetConstraintAspectRatio(bool bInConstrainAspectRatio)
		{
			UCameraComponent.__SetConstraintAspectRatio_Internal(base.NativePtr, bInConstrainAspectRatio);
		}

		// Token: 0x06007F37 RID: 32567 RVA: 0x000B6801 File Offset: 0x000B4A01
		public void SetAspectRatio(float InAspectRatio)
		{
			UCameraComponent.__SetAspectRatio_Internal(base.NativePtr, InAspectRatio);
		}

		// Token: 0x06007F38 RID: 32568 RVA: 0x000B6810 File Offset: 0x000B4A10
		[NullableContext(2)]
		public void RemoveBlendable(IBlendableInterface InBlendableObject)
		{
			FScriptInterface fscriptInterface = new FScriptInterface(InBlendableObject, (InBlendableObject != null) ? InBlendableObject.InterfaceOffset() : 0);
			UCameraComponent.__RemoveBlendable_Internal(base.NativePtr, fscriptInterface);
		}

		// Token: 0x06007F39 RID: 32569 RVA: 0x000B683E File Offset: 0x000B4A3E
		public void OnCameraMeshHiddenChanged()
		{
			UCameraComponent.__OnCameraMeshHiddenChanged_Internal(base.NativePtr);
		}

		// Token: 0x06007F3A RID: 32570 RVA: 0x000B684C File Offset: 0x000B4A4C
		public unsafe void KuroGetAdditiveOffset(ref FTransform OutAdditiveOffset, ref float OutAdditiveFOVOffset)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = OutAdditiveOffset;
			fixed (float* ptr2 = &OutAdditiveFOVOffset)
			{
				void* ptr3 = (void*)ptr2;
				UCameraComponent.__KuroGetAdditiveOffset_Internal(base.NativePtr, ref ptr, ref OutAdditiveFOVOffset);
				OutAdditiveOffset = ptr;
			}
		}

		// Token: 0x06007F3B RID: 32571 RVA: 0x000B6896 File Offset: 0x000B4A96
		public void KuroClearExtraPostProcessBlends()
		{
			UCameraComponent.__KuroClearExtraPostProcessBlends_Internal(base.NativePtr);
		}

		// Token: 0x06007F3C RID: 32572 RVA: 0x000B68A3 File Offset: 0x000B4AA3
		public void KuroClearAdditiveOffset()
		{
			UCameraComponent.__KuroClearAdditiveOffset_Internal(base.NativePtr);
		}

		// Token: 0x06007F3D RID: 32573 RVA: 0x000B68B0 File Offset: 0x000B4AB0
		[NullableContext(2)]
		public void GetCameraView(float DeltaTime, ref FMinimalViewInfo DesiredView)
		{
			UCameraComponent.__GetCameraView_Internal(base.NativePtr, DeltaTime, (DesiredView ?? new FMinimalViewInfo()).NativePtr);
		}

		// Token: 0x06007F3E RID: 32574 RVA: 0x000B68CE File Offset: 0x000B4ACE
		public void CameraFrustumHiddenSetter(bool bHidden)
		{
			UCameraComponent.__CameraFrustumHiddenSetter_Internal(base.NativePtr, bHidden);
		}

		// Token: 0x06007F3F RID: 32575 RVA: 0x000B68DC File Offset: 0x000B4ADC
		[NullableContext(2)]
		public void AddOrUpdateBlendable(IBlendableInterface InBlendableObject, float InWeight = 1f)
		{
			FScriptInterface fscriptInterface = new FScriptInterface(InBlendableObject, (InBlendableObject != null) ? InBlendableObject.InterfaceOffset() : 0);
			UCameraComponent.__AddOrUpdateBlendable_Internal(base.NativePtr, fscriptInterface, InWeight);
		}

		// Token: 0x06007F40 RID: 32576
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUseFieldOfViewForLOD_Internal(IntPtr @this, bool bInUseFieldOfViewForLOD);

		// Token: 0x06007F41 RID: 32577
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetProjectionMode_Internal(IntPtr @this, TEnumAsByte<ECameraProjectionMode> InProjectionMode);

		// Token: 0x06007F42 RID: 32578
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPostProcessBlendWeight_Internal(IntPtr @this, float InPostProcessBlendWeight);

		// Token: 0x06007F43 RID: 32579
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOrthoWidth_Internal(IntPtr @this, float InOrthoWidth);

		// Token: 0x06007F44 RID: 32580
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOrthoNearClipPlane_Internal(IntPtr @this, float InOrthoNearClipPlane);

		// Token: 0x06007F45 RID: 32581
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOrthoFarClipPlane_Internal(IntPtr @this, float InOrthoFarClipPlane);

		// Token: 0x06007F46 RID: 32582
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFieldOfView_Internal(IntPtr @this, float InFieldOfView);

		// Token: 0x06007F47 RID: 32583
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEnableScissorOffCenter_Internal(IntPtr @this, bool bInEnableScissorOffCenter);

		// Token: 0x06007F48 RID: 32584
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetConstraintAspectRatio_Internal(IntPtr @this, bool bInConstrainAspectRatio);

		// Token: 0x06007F49 RID: 32585
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAspectRatio_Internal(IntPtr @this, float InAspectRatio);

		// Token: 0x06007F4A RID: 32586
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveBlendable_Internal(IntPtr @this, in FScriptInterface InBlendableObject);

		// Token: 0x06007F4B RID: 32587
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnCameraMeshHiddenChanged_Internal(IntPtr @this);

		// Token: 0x06007F4C RID: 32588
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __KuroGetAdditiveOffset_Internal(IntPtr @this, ref FTransform OutAdditiveOffset, ref float OutAdditiveFOVOffset);

		// Token: 0x06007F4D RID: 32589
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __KuroClearExtraPostProcessBlends_Internal(IntPtr @this);

		// Token: 0x06007F4E RID: 32590
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __KuroClearAdditiveOffset_Internal(IntPtr @this);

		// Token: 0x06007F4F RID: 32591
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetCameraView_Internal(IntPtr @this, float DeltaTime, IntPtr DesiredView);

		// Token: 0x06007F50 RID: 32592
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CameraFrustumHiddenSetter_Internal(IntPtr @this, bool bHidden);

		// Token: 0x06007F51 RID: 32593
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddOrUpdateBlendable_Internal(IntPtr @this, in FScriptInterface InBlendableObject, float InWeight);

		// Token: 0x06007F52 RID: 32594 RVA: 0x000B690B File Offset: 0x000B4B0B
		static UCameraComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.CameraComponent");
		}

		// Token: 0x06007F53 RID: 32595 RVA: 0x000B6919 File Offset: 0x000B4B19
		protected UCameraComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003CF8 RID: 15608
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.CameraComponent";

		// Token: 0x04003CF9 RID: 15609
		private static IntPtr _ClassPtr;

		// Token: 0x04003CFA RID: 15610
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003CFB RID: 15611
		internal static int __PropertyOffset_FieldOfView;

		// Token: 0x04003CFC RID: 15612
		internal static int __PropertyOffset_OrthoWidth;

		// Token: 0x04003CFD RID: 15613
		internal static int __PropertyOffset_OrthoNearClipPlane;

		// Token: 0x04003CFE RID: 15614
		internal static int __PropertyOffset_OrthoFarClipPlane;

		// Token: 0x04003CFF RID: 15615
		internal static int __PropertyOffset_AspectRatio;

		// Token: 0x04003D00 RID: 15616
		internal static int __PropertyOffset_bConstrainAspectRatio;

		// Token: 0x04003D01 RID: 15617
		internal static byte __PropertyMask_bConstrainAspectRatio;

		// Token: 0x04003D02 RID: 15618
		internal static int __PropertyOffset_bUseFieldOfViewForLOD;

		// Token: 0x04003D03 RID: 15619
		internal static byte __PropertyMask_bUseFieldOfViewForLOD;

		// Token: 0x04003D04 RID: 15620
		internal static int __PropertyOffset_bEnableScissorOffCenter;

		// Token: 0x04003D05 RID: 15621
		internal static byte __PropertyMask_bEnableScissorOffCenter;

		// Token: 0x04003D06 RID: 15622
		internal static int __PropertyOffset_bLockToHmd;

		// Token: 0x04003D07 RID: 15623
		internal static byte __PropertyMask_bLockToHmd;

		// Token: 0x04003D08 RID: 15624
		internal static int __PropertyOffset_bUsePawnControlRotation;

		// Token: 0x04003D09 RID: 15625
		internal static byte __PropertyMask_bUsePawnControlRotation;

		// Token: 0x04003D0A RID: 15626
		internal static int __PropertyOffset_ProjectionMode;

		// Token: 0x04003D0B RID: 15627
		internal static int __PropertyOffset_PostProcessBlendWeight;

		// Token: 0x04003D0C RID: 15628
		internal static int __PropertyOffset_PostProcessSettings;

		// Token: 0x04003D0D RID: 15629
		[Nullable(2)]
		private FPostProcessSettings _PostProcessSettings;
	}
}
