using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001181 RID: 4481
	[UnrealObjectPath("/Script/Engine.SpotLightComponent")]
	[UnrealStructLayout(1280, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1280)]
	public class USpotLightComponent : UPointLightComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601076D RID: 67437 RVA: 0x00182D92 File Offset: 0x00180F92
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USpotLightComponent._ClassPtr;
		}

		// Token: 0x0601076E RID: 67438 RVA: 0x00182DA0 File Offset: 0x00180FA0
		public USpotLightComponent() : this(BuiltinUtils.AllocNativeUObject(USpotLightComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601076F RID: 67439 RVA: 0x00182DC8 File Offset: 0x00180FC8
		[NullableContext(1)]
		public USpotLightComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USpotLightComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700402F RID: 16431
		// (get) Token: 0x06010770 RID: 67440 RVA: 0x00182DFB File Offset: 0x00180FFB
		// (set) Token: 0x06010771 RID: 67441 RVA: 0x00182E0B File Offset: 0x0018100B
		public unsafe float SpotLightShadowDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USpotLightComponent.__PropertyOffset_SpotLightShadowDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USpotLightComponent.__PropertyOffset_SpotLightShadowDistance) = value;
			}
		}

		// Token: 0x17004030 RID: 16432
		// (get) Token: 0x06010772 RID: 67442 RVA: 0x00182E1C File Offset: 0x0018101C
		// (set) Token: 0x06010773 RID: 67443 RVA: 0x00182E2C File Offset: 0x0018102C
		public unsafe float ShadowFadeDistancePercent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USpotLightComponent.__PropertyOffset_ShadowFadeDistancePercent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USpotLightComponent.__PropertyOffset_ShadowFadeDistancePercent) = value;
			}
		}

		// Token: 0x17004031 RID: 16433
		// (get) Token: 0x06010774 RID: 67444 RVA: 0x00182E3D File Offset: 0x0018103D
		// (set) Token: 0x06010775 RID: 67445 RVA: 0x00182E4D File Offset: 0x0018104D
		public unsafe float ShadowCastMinScreenRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USpotLightComponent.__PropertyOffset_ShadowCastMinScreenRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USpotLightComponent.__PropertyOffset_ShadowCastMinScreenRadius) = value;
			}
		}

		// Token: 0x17004032 RID: 16434
		// (get) Token: 0x06010776 RID: 67446 RVA: 0x00182E5E File Offset: 0x0018105E
		// (set) Token: 0x06010777 RID: 67447 RVA: 0x00182E6E File Offset: 0x0018106E
		public unsafe float InnerConeAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USpotLightComponent.__PropertyOffset_InnerConeAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USpotLightComponent.__PropertyOffset_InnerConeAngle) = value;
			}
		}

		// Token: 0x17004033 RID: 16435
		// (get) Token: 0x06010778 RID: 67448 RVA: 0x00182E7F File Offset: 0x0018107F
		// (set) Token: 0x06010779 RID: 67449 RVA: 0x00182E8F File Offset: 0x0018108F
		public unsafe float OuterConeAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USpotLightComponent.__PropertyOffset_OuterConeAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USpotLightComponent.__PropertyOffset_OuterConeAngle) = value;
			}
		}

		// Token: 0x17004034 RID: 16436
		// (get) Token: 0x0601077A RID: 67450 RVA: 0x00182EA0 File Offset: 0x001810A0
		// (set) Token: 0x0601077B RID: 67451 RVA: 0x00182EB9 File Offset: 0x001810B9
		public unsafe bool bCastPerObjShadows
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USpotLightComponent.__PropertyOffset_bCastPerObjShadows) & USpotLightComponent.__PropertyMask_bCastPerObjShadows) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USpotLightComponent.__PropertyOffset_bCastPerObjShadows) = ((*(base.NativePtr + (IntPtr)USpotLightComponent.__PropertyOffset_bCastPerObjShadows) & ~USpotLightComponent.__PropertyMask_bCastPerObjShadows) | (value ? USpotLightComponent.__PropertyMask_bCastPerObjShadows : 0));
			}
		}

		// Token: 0x17004035 RID: 16437
		// (get) Token: 0x0601077C RID: 67452 RVA: 0x00182EE9 File Offset: 0x001810E9
		// (set) Token: 0x0601077D RID: 67453 RVA: 0x00182F02 File Offset: 0x00181102
		public unsafe bool bUseColorfulLightFunction
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USpotLightComponent.__PropertyOffset_bUseColorfulLightFunction) & USpotLightComponent.__PropertyMask_bUseColorfulLightFunction) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USpotLightComponent.__PropertyOffset_bUseColorfulLightFunction) = ((*(base.NativePtr + (IntPtr)USpotLightComponent.__PropertyOffset_bUseColorfulLightFunction) & ~USpotLightComponent.__PropertyMask_bUseColorfulLightFunction) | (value ? USpotLightComponent.__PropertyMask_bUseColorfulLightFunction : 0));
			}
		}

		// Token: 0x17004036 RID: 16438
		// (get) Token: 0x0601077E RID: 67454 RVA: 0x00182F32 File Offset: 0x00181132
		// (set) Token: 0x0601077F RID: 67455 RVA: 0x00182F4B File Offset: 0x0018114B
		public unsafe bool bUseColorfulLFOnToonShading
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USpotLightComponent.__PropertyOffset_bUseColorfulLFOnToonShading) & USpotLightComponent.__PropertyMask_bUseColorfulLFOnToonShading) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USpotLightComponent.__PropertyOffset_bUseColorfulLFOnToonShading) = ((*(base.NativePtr + (IntPtr)USpotLightComponent.__PropertyOffset_bUseColorfulLFOnToonShading) & ~USpotLightComponent.__PropertyMask_bUseColorfulLFOnToonShading) | (value ? USpotLightComponent.__PropertyMask_bUseColorfulLFOnToonShading : 0));
			}
		}

		// Token: 0x17004037 RID: 16439
		// (get) Token: 0x06010780 RID: 67456 RVA: 0x00182F7B File Offset: 0x0018117B
		// (set) Token: 0x06010781 RID: 67457 RVA: 0x00182F94 File Offset: 0x00181194
		public unsafe bool bUseAsVolumetricLight
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USpotLightComponent.__PropertyOffset_bUseAsVolumetricLight) & USpotLightComponent.__PropertyMask_bUseAsVolumetricLight) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USpotLightComponent.__PropertyOffset_bUseAsVolumetricLight) = ((*(base.NativePtr + (IntPtr)USpotLightComponent.__PropertyOffset_bUseAsVolumetricLight) & ~USpotLightComponent.__PropertyMask_bUseAsVolumetricLight) | (value ? USpotLightComponent.__PropertyMask_bUseAsVolumetricLight : 0));
			}
		}

		// Token: 0x17004038 RID: 16440
		// (get) Token: 0x06010782 RID: 67458 RVA: 0x00182FC4 File Offset: 0x001811C4
		// (set) Token: 0x06010783 RID: 67459 RVA: 0x00182FDD File Offset: 0x001811DD
		public unsafe bool bCastToonShadow
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USpotLightComponent.__PropertyOffset_bCastToonShadow) & USpotLightComponent.__PropertyMask_bCastToonShadow) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USpotLightComponent.__PropertyOffset_bCastToonShadow) = ((*(base.NativePtr + (IntPtr)USpotLightComponent.__PropertyOffset_bCastToonShadow) & ~USpotLightComponent.__PropertyMask_bCastToonShadow) | (value ? USpotLightComponent.__PropertyMask_bCastToonShadow : 0));
			}
		}

		// Token: 0x06010784 RID: 67460 RVA: 0x0018300D File Offset: 0x0018120D
		public void SetOuterConeAngle(float NewOuterConeAngle)
		{
			USpotLightComponent.__SetOuterConeAngle_Internal(base.NativePtr, NewOuterConeAngle);
		}

		// Token: 0x06010785 RID: 67461 RVA: 0x0018301B File Offset: 0x0018121B
		public void SetInnerConeAngle(float NewInnerConeAngle)
		{
			USpotLightComponent.__SetInnerConeAngle_Internal(base.NativePtr, NewInnerConeAngle);
		}

		// Token: 0x06010786 RID: 67462
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOuterConeAngle_Internal(IntPtr @this, float NewOuterConeAngle);

		// Token: 0x06010787 RID: 67463
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetInnerConeAngle_Internal(IntPtr @this, float NewInnerConeAngle);

		// Token: 0x06010788 RID: 67464 RVA: 0x00183029 File Offset: 0x00181229
		static USpotLightComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SpotLightComponent");
		}

		// Token: 0x06010789 RID: 67465 RVA: 0x00183037 File Offset: 0x00181237
		protected USpotLightComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008CE5 RID: 36069
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SpotLightComponent";

		// Token: 0x04008CE6 RID: 36070
		private static IntPtr _ClassPtr;

		// Token: 0x04008CE7 RID: 36071
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008CE8 RID: 36072
		internal static int __PropertyOffset_SpotLightShadowDistance;

		// Token: 0x04008CE9 RID: 36073
		internal static int __PropertyOffset_ShadowFadeDistancePercent;

		// Token: 0x04008CEA RID: 36074
		internal static int __PropertyOffset_ShadowCastMinScreenRadius;

		// Token: 0x04008CEB RID: 36075
		internal static int __PropertyOffset_InnerConeAngle;

		// Token: 0x04008CEC RID: 36076
		internal static int __PropertyOffset_OuterConeAngle;

		// Token: 0x04008CED RID: 36077
		internal static int __PropertyOffset_bCastPerObjShadows;

		// Token: 0x04008CEE RID: 36078
		internal static byte __PropertyMask_bCastPerObjShadows;

		// Token: 0x04008CEF RID: 36079
		internal static int __PropertyOffset_bUseColorfulLightFunction;

		// Token: 0x04008CF0 RID: 36080
		internal static byte __PropertyMask_bUseColorfulLightFunction;

		// Token: 0x04008CF1 RID: 36081
		internal static int __PropertyOffset_bUseColorfulLFOnToonShading;

		// Token: 0x04008CF2 RID: 36082
		internal static byte __PropertyMask_bUseColorfulLFOnToonShading;

		// Token: 0x04008CF3 RID: 36083
		internal static int __PropertyOffset_bUseAsVolumetricLight;

		// Token: 0x04008CF4 RID: 36084
		internal static byte __PropertyMask_bUseAsVolumetricLight;

		// Token: 0x04008CF5 RID: 36085
		internal static int __PropertyOffset_bCastToonShadow;

		// Token: 0x04008CF6 RID: 36086
		internal static byte __PropertyMask_bCastToonShadow;
	}
}
