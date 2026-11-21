using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000199 RID: 409
	[UnrealObjectPath("/Script/Engine.CameraComponent")]
	[UnrealStructLayout(3376, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 3376)]
	public class UCameraComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001B6F RID: 7023 RVA: 0x00028DC2 File Offset: 0x00026FC2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCameraComponent._ClassPtr;
		}

		// Token: 0x06001B70 RID: 7024 RVA: 0x00028DD0 File Offset: 0x00026FD0
		public UCameraComponent() : this(BuiltinUtils.AllocNativeUObject(UCameraComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001B71 RID: 7025 RVA: 0x00028DF8 File Offset: 0x00026FF8
		[NullableContext(1)]
		public UCameraComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UCameraComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06001B72 RID: 7026 RVA: 0x00028E2B File Offset: 0x0002702B
		// (set) Token: 0x06001B73 RID: 7027 RVA: 0x00028E3B File Offset: 0x0002703B
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

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06001B74 RID: 7028 RVA: 0x00028E4C File Offset: 0x0002704C
		// (set) Token: 0x06001B75 RID: 7029 RVA: 0x00028E5C File Offset: 0x0002705C
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

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06001B76 RID: 7030 RVA: 0x00028E6D File Offset: 0x0002706D
		// (set) Token: 0x06001B77 RID: 7031 RVA: 0x00028E7D File Offset: 0x0002707D
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

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06001B78 RID: 7032 RVA: 0x00028E8E File Offset: 0x0002708E
		// (set) Token: 0x06001B79 RID: 7033 RVA: 0x00028E9E File Offset: 0x0002709E
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

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06001B7A RID: 7034 RVA: 0x00028EAF File Offset: 0x000270AF
		// (set) Token: 0x06001B7B RID: 7035 RVA: 0x00028EBF File Offset: 0x000270BF
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

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06001B7C RID: 7036 RVA: 0x00028ED0 File Offset: 0x000270D0
		// (set) Token: 0x06001B7D RID: 7037 RVA: 0x00028EE9 File Offset: 0x000270E9
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

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06001B7E RID: 7038 RVA: 0x00028F19 File Offset: 0x00027119
		// (set) Token: 0x06001B7F RID: 7039 RVA: 0x00028F32 File Offset: 0x00027132
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

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06001B80 RID: 7040 RVA: 0x00028F62 File Offset: 0x00027162
		// (set) Token: 0x06001B81 RID: 7041 RVA: 0x00028F7B File Offset: 0x0002717B
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

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06001B82 RID: 7042 RVA: 0x00028FAB File Offset: 0x000271AB
		// (set) Token: 0x06001B83 RID: 7043 RVA: 0x00028FC4 File Offset: 0x000271C4
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

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06001B84 RID: 7044 RVA: 0x00028FF4 File Offset: 0x000271F4
		// (set) Token: 0x06001B85 RID: 7045 RVA: 0x0002900D File Offset: 0x0002720D
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

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06001B86 RID: 7046 RVA: 0x0002903D File Offset: 0x0002723D
		// (set) Token: 0x06001B87 RID: 7047 RVA: 0x00029051 File Offset: 0x00027251
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

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06001B88 RID: 7048 RVA: 0x00029066 File Offset: 0x00027266
		// (set) Token: 0x06001B89 RID: 7049 RVA: 0x00029076 File Offset: 0x00027276
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

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06001B8A RID: 7050 RVA: 0x00029088 File Offset: 0x00027288
		// (set) Token: 0x06001B8B RID: 7051 RVA: 0x000290C1 File Offset: 0x000272C1
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

		// Token: 0x06001B8C RID: 7052 RVA: 0x000290E2 File Offset: 0x000272E2
		public void SetUseFieldOfViewForLOD(bool bInUseFieldOfViewForLOD)
		{
			UCameraComponent.__SetUseFieldOfViewForLOD_Internal(base.NativePtr, bInUseFieldOfViewForLOD);
		}

		// Token: 0x06001B8D RID: 7053 RVA: 0x000290F0 File Offset: 0x000272F0
		public void SetProjectionMode(ECameraProjectionMode InProjectionMode)
		{
			UCameraComponent.__SetProjectionMode_Internal(base.NativePtr, InProjectionMode);
		}

		// Token: 0x06001B8E RID: 7054 RVA: 0x00029103 File Offset: 0x00027303
		public void SetPostProcessBlendWeight(float InPostProcessBlendWeight)
		{
			UCameraComponent.__SetPostProcessBlendWeight_Internal(base.NativePtr, InPostProcessBlendWeight);
		}

		// Token: 0x06001B8F RID: 7055 RVA: 0x00029111 File Offset: 0x00027311
		public void SetOrthoWidth(float InOrthoWidth)
		{
			UCameraComponent.__SetOrthoWidth_Internal(base.NativePtr, InOrthoWidth);
		}

		// Token: 0x06001B90 RID: 7056 RVA: 0x0002911F File Offset: 0x0002731F
		public void SetOrthoNearClipPlane(float InOrthoNearClipPlane)
		{
			UCameraComponent.__SetOrthoNearClipPlane_Internal(base.NativePtr, InOrthoNearClipPlane);
		}

		// Token: 0x06001B91 RID: 7057 RVA: 0x0002912D File Offset: 0x0002732D
		public void SetOrthoFarClipPlane(float InOrthoFarClipPlane)
		{
			UCameraComponent.__SetOrthoFarClipPlane_Internal(base.NativePtr, InOrthoFarClipPlane);
		}

		// Token: 0x06001B92 RID: 7058 RVA: 0x0002913B File Offset: 0x0002733B
		public void SetFieldOfView(float InFieldOfView)
		{
			UCameraComponent.__SetFieldOfView_Internal(base.NativePtr, InFieldOfView);
		}

		// Token: 0x06001B93 RID: 7059 RVA: 0x00029149 File Offset: 0x00027349
		public void SetEnableScissorOffCenter(bool bInEnableScissorOffCenter)
		{
			UCameraComponent.__SetEnableScissorOffCenter_Internal(base.NativePtr, bInEnableScissorOffCenter);
		}

		// Token: 0x06001B94 RID: 7060 RVA: 0x00029157 File Offset: 0x00027357
		public void SetConstraintAspectRatio(bool bInConstrainAspectRatio)
		{
			UCameraComponent.__SetConstraintAspectRatio_Internal(base.NativePtr, bInConstrainAspectRatio);
		}

		// Token: 0x06001B95 RID: 7061 RVA: 0x00029165 File Offset: 0x00027365
		public void SetAspectRatio(float InAspectRatio)
		{
			UCameraComponent.__SetAspectRatio_Internal(base.NativePtr, InAspectRatio);
		}

		// Token: 0x06001B96 RID: 7062 RVA: 0x00029173 File Offset: 0x00027373
		public void OnCameraMeshHiddenChanged()
		{
			UCameraComponent.__OnCameraMeshHiddenChanged_Internal(base.NativePtr);
		}

		// Token: 0x06001B97 RID: 7063 RVA: 0x00029180 File Offset: 0x00027380
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

		// Token: 0x06001B98 RID: 7064 RVA: 0x000291CA File Offset: 0x000273CA
		public void KuroClearExtraPostProcessBlends()
		{
			UCameraComponent.__KuroClearExtraPostProcessBlends_Internal(base.NativePtr);
		}

		// Token: 0x06001B99 RID: 7065 RVA: 0x000291D7 File Offset: 0x000273D7
		public void KuroClearAdditiveOffset()
		{
			UCameraComponent.__KuroClearAdditiveOffset_Internal(base.NativePtr);
		}

		// Token: 0x06001B9A RID: 7066 RVA: 0x000291E4 File Offset: 0x000273E4
		public void CameraFrustumHiddenSetter(bool bHidden)
		{
			UCameraComponent.__CameraFrustumHiddenSetter_Internal(base.NativePtr, bHidden);
		}

		// Token: 0x06001B9B RID: 7067
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUseFieldOfViewForLOD_Internal(IntPtr @this, bool bInUseFieldOfViewForLOD);

		// Token: 0x06001B9C RID: 7068
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetProjectionMode_Internal(IntPtr @this, TEnumAsByte<ECameraProjectionMode> InProjectionMode);

		// Token: 0x06001B9D RID: 7069
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPostProcessBlendWeight_Internal(IntPtr @this, float InPostProcessBlendWeight);

		// Token: 0x06001B9E RID: 7070
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOrthoWidth_Internal(IntPtr @this, float InOrthoWidth);

		// Token: 0x06001B9F RID: 7071
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOrthoNearClipPlane_Internal(IntPtr @this, float InOrthoNearClipPlane);

		// Token: 0x06001BA0 RID: 7072
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOrthoFarClipPlane_Internal(IntPtr @this, float InOrthoFarClipPlane);

		// Token: 0x06001BA1 RID: 7073
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFieldOfView_Internal(IntPtr @this, float InFieldOfView);

		// Token: 0x06001BA2 RID: 7074
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEnableScissorOffCenter_Internal(IntPtr @this, bool bInEnableScissorOffCenter);

		// Token: 0x06001BA3 RID: 7075
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetConstraintAspectRatio_Internal(IntPtr @this, bool bInConstrainAspectRatio);

		// Token: 0x06001BA4 RID: 7076
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAspectRatio_Internal(IntPtr @this, float InAspectRatio);

		// Token: 0x06001BA5 RID: 7077
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnCameraMeshHiddenChanged_Internal(IntPtr @this);

		// Token: 0x06001BA6 RID: 7078
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __KuroGetAdditiveOffset_Internal(IntPtr @this, ref FTransform OutAdditiveOffset, ref float OutAdditiveFOVOffset);

		// Token: 0x06001BA7 RID: 7079
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __KuroClearExtraPostProcessBlends_Internal(IntPtr @this);

		// Token: 0x06001BA8 RID: 7080
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __KuroClearAdditiveOffset_Internal(IntPtr @this);

		// Token: 0x06001BA9 RID: 7081
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CameraFrustumHiddenSetter_Internal(IntPtr @this, bool bHidden);

		// Token: 0x06001BAA RID: 7082 RVA: 0x000291F2 File Offset: 0x000273F2
		static UCameraComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.CameraComponent");
		}

		// Token: 0x06001BAB RID: 7083 RVA: 0x00029200 File Offset: 0x00027400
		protected UCameraComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040008E5 RID: 2277
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.CameraComponent";

		// Token: 0x040008E6 RID: 2278
		private static IntPtr _ClassPtr;

		// Token: 0x040008E7 RID: 2279
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040008E8 RID: 2280
		internal static int __PropertyOffset_FieldOfView;

		// Token: 0x040008E9 RID: 2281
		internal static int __PropertyOffset_OrthoWidth;

		// Token: 0x040008EA RID: 2282
		internal static int __PropertyOffset_OrthoNearClipPlane;

		// Token: 0x040008EB RID: 2283
		internal static int __PropertyOffset_OrthoFarClipPlane;

		// Token: 0x040008EC RID: 2284
		internal static int __PropertyOffset_AspectRatio;

		// Token: 0x040008ED RID: 2285
		internal static int __PropertyOffset_bConstrainAspectRatio;

		// Token: 0x040008EE RID: 2286
		internal static byte __PropertyMask_bConstrainAspectRatio;

		// Token: 0x040008EF RID: 2287
		internal static int __PropertyOffset_bUseFieldOfViewForLOD;

		// Token: 0x040008F0 RID: 2288
		internal static byte __PropertyMask_bUseFieldOfViewForLOD;

		// Token: 0x040008F1 RID: 2289
		internal static int __PropertyOffset_bEnableScissorOffCenter;

		// Token: 0x040008F2 RID: 2290
		internal static byte __PropertyMask_bEnableScissorOffCenter;

		// Token: 0x040008F3 RID: 2291
		internal static int __PropertyOffset_bLockToHmd;

		// Token: 0x040008F4 RID: 2292
		internal static byte __PropertyMask_bLockToHmd;

		// Token: 0x040008F5 RID: 2293
		internal static int __PropertyOffset_bUsePawnControlRotation;

		// Token: 0x040008F6 RID: 2294
		internal static byte __PropertyMask_bUsePawnControlRotation;

		// Token: 0x040008F7 RID: 2295
		internal static int __PropertyOffset_ProjectionMode;

		// Token: 0x040008F8 RID: 2296
		internal static int __PropertyOffset_PostProcessBlendWeight;

		// Token: 0x040008F9 RID: 2297
		internal static int __PropertyOffset_PostProcessSettings;

		// Token: 0x040008FA RID: 2298
		[Nullable(2)]
		private FPostProcessSettings _PostProcessSettings;
	}
}
