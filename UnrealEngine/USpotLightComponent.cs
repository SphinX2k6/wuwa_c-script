using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200028C RID: 652
	[UnrealObjectPath("/Script/Engine.SpotLightComponent")]
	[UnrealStructLayout(1296, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1296)]
	public class USpotLightComponent : UPointLightComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600478A RID: 18314 RVA: 0x0006430D File Offset: 0x0006250D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USpotLightComponent._ClassPtr;
		}

		// Token: 0x0600478B RID: 18315 RVA: 0x0006431C File Offset: 0x0006251C
		public USpotLightComponent() : this(BuiltinUtils.AllocNativeUObject(USpotLightComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600478C RID: 18316 RVA: 0x00064344 File Offset: 0x00062544
		[NullableContext(1)]
		public USpotLightComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USpotLightComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000D2B RID: 3371
		// (get) Token: 0x0600478D RID: 18317 RVA: 0x00064377 File Offset: 0x00062577
		// (set) Token: 0x0600478E RID: 18318 RVA: 0x00064387 File Offset: 0x00062587
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

		// Token: 0x17000D2C RID: 3372
		// (get) Token: 0x0600478F RID: 18319 RVA: 0x00064398 File Offset: 0x00062598
		// (set) Token: 0x06004790 RID: 18320 RVA: 0x000643A8 File Offset: 0x000625A8
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

		// Token: 0x17000D2D RID: 3373
		// (get) Token: 0x06004791 RID: 18321 RVA: 0x000643B9 File Offset: 0x000625B9
		// (set) Token: 0x06004792 RID: 18322 RVA: 0x000643C9 File Offset: 0x000625C9
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

		// Token: 0x17000D2E RID: 3374
		// (get) Token: 0x06004793 RID: 18323 RVA: 0x000643DA File Offset: 0x000625DA
		// (set) Token: 0x06004794 RID: 18324 RVA: 0x000643EA File Offset: 0x000625EA
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

		// Token: 0x17000D2F RID: 3375
		// (get) Token: 0x06004795 RID: 18325 RVA: 0x000643FB File Offset: 0x000625FB
		// (set) Token: 0x06004796 RID: 18326 RVA: 0x0006440B File Offset: 0x0006260B
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

		// Token: 0x17000D30 RID: 3376
		// (get) Token: 0x06004797 RID: 18327 RVA: 0x0006441C File Offset: 0x0006261C
		// (set) Token: 0x06004798 RID: 18328 RVA: 0x0006442C File Offset: 0x0006262C
		public unsafe float VolumetricScatteringViewDependence
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USpotLightComponent.__PropertyOffset_VolumetricScatteringViewDependence);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USpotLightComponent.__PropertyOffset_VolumetricScatteringViewDependence) = value;
			}
		}

		// Token: 0x17000D31 RID: 3377
		// (get) Token: 0x06004799 RID: 18329 RVA: 0x0006443D File Offset: 0x0006263D
		// (set) Token: 0x0600479A RID: 18330 RVA: 0x00064456 File Offset: 0x00062656
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

		// Token: 0x17000D32 RID: 3378
		// (get) Token: 0x0600479B RID: 18331 RVA: 0x00064486 File Offset: 0x00062686
		// (set) Token: 0x0600479C RID: 18332 RVA: 0x0006449F File Offset: 0x0006269F
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

		// Token: 0x17000D33 RID: 3379
		// (get) Token: 0x0600479D RID: 18333 RVA: 0x000644CF File Offset: 0x000626CF
		// (set) Token: 0x0600479E RID: 18334 RVA: 0x000644E8 File Offset: 0x000626E8
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

		// Token: 0x17000D34 RID: 3380
		// (get) Token: 0x0600479F RID: 18335 RVA: 0x00064518 File Offset: 0x00062718
		// (set) Token: 0x060047A0 RID: 18336 RVA: 0x00064531 File Offset: 0x00062731
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

		// Token: 0x17000D35 RID: 3381
		// (get) Token: 0x060047A1 RID: 18337 RVA: 0x00064561 File Offset: 0x00062761
		// (set) Token: 0x060047A2 RID: 18338 RVA: 0x0006457A File Offset: 0x0006277A
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

		// Token: 0x060047A3 RID: 18339 RVA: 0x000645AA File Offset: 0x000627AA
		public void SetVolumetricScatteringViewDependence(float NewValue)
		{
			USpotLightComponent.__SetVolumetricScatteringViewDependence_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x060047A4 RID: 18340 RVA: 0x000645B8 File Offset: 0x000627B8
		public void SetOuterConeAngle(float NewOuterConeAngle)
		{
			USpotLightComponent.__SetOuterConeAngle_Internal(base.NativePtr, NewOuterConeAngle);
		}

		// Token: 0x060047A5 RID: 18341 RVA: 0x000645C6 File Offset: 0x000627C6
		public void SetInnerConeAngle(float NewInnerConeAngle)
		{
			USpotLightComponent.__SetInnerConeAngle_Internal(base.NativePtr, NewInnerConeAngle);
		}

		// Token: 0x060047A6 RID: 18342
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVolumetricScatteringViewDependence_Internal(IntPtr @this, float NewValue);

		// Token: 0x060047A7 RID: 18343
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOuterConeAngle_Internal(IntPtr @this, float NewOuterConeAngle);

		// Token: 0x060047A8 RID: 18344
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetInnerConeAngle_Internal(IntPtr @this, float NewInnerConeAngle);

		// Token: 0x060047A9 RID: 18345 RVA: 0x000645D4 File Offset: 0x000627D4
		static USpotLightComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SpotLightComponent");
		}

		// Token: 0x060047AA RID: 18346 RVA: 0x000645E2 File Offset: 0x000627E2
		protected USpotLightComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001B85 RID: 7045
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SpotLightComponent";

		// Token: 0x04001B86 RID: 7046
		private static IntPtr _ClassPtr;

		// Token: 0x04001B87 RID: 7047
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001B88 RID: 7048
		internal static int __PropertyOffset_SpotLightShadowDistance;

		// Token: 0x04001B89 RID: 7049
		internal static int __PropertyOffset_ShadowFadeDistancePercent;

		// Token: 0x04001B8A RID: 7050
		internal static int __PropertyOffset_ShadowCastMinScreenRadius;

		// Token: 0x04001B8B RID: 7051
		internal static int __PropertyOffset_InnerConeAngle;

		// Token: 0x04001B8C RID: 7052
		internal static int __PropertyOffset_OuterConeAngle;

		// Token: 0x04001B8D RID: 7053
		internal static int __PropertyOffset_VolumetricScatteringViewDependence;

		// Token: 0x04001B8E RID: 7054
		internal static int __PropertyOffset_bCastPerObjShadows;

		// Token: 0x04001B8F RID: 7055
		internal static byte __PropertyMask_bCastPerObjShadows;

		// Token: 0x04001B90 RID: 7056
		internal static int __PropertyOffset_bUseColorfulLightFunction;

		// Token: 0x04001B91 RID: 7057
		internal static byte __PropertyMask_bUseColorfulLightFunction;

		// Token: 0x04001B92 RID: 7058
		internal static int __PropertyOffset_bUseColorfulLFOnToonShading;

		// Token: 0x04001B93 RID: 7059
		internal static byte __PropertyMask_bUseColorfulLFOnToonShading;

		// Token: 0x04001B94 RID: 7060
		internal static int __PropertyOffset_bUseAsVolumetricLight;

		// Token: 0x04001B95 RID: 7061
		internal static byte __PropertyMask_bUseAsVolumetricLight;

		// Token: 0x04001B96 RID: 7062
		internal static int __PropertyOffset_bCastToonShadow;

		// Token: 0x04001B97 RID: 7063
		internal static byte __PropertyMask_bCastToonShadow;
	}
}
