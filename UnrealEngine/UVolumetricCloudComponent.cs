using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001241 RID: 4673
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.VolumetricCloudComponent")]
	[UnrealStructLayout(672, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 672)]
	public class UVolumetricCloudComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601129A RID: 70298 RVA: 0x00193177 File Offset: 0x00191377
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UVolumetricCloudComponent._ClassPtr;
		}

		// Token: 0x0601129B RID: 70299 RVA: 0x00193184 File Offset: 0x00191384
		public UVolumetricCloudComponent() : this(BuiltinUtils.AllocNativeUObject(UVolumetricCloudComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601129C RID: 70300 RVA: 0x001931AC File Offset: 0x001913AC
		[NullableContext(1)]
		public UVolumetricCloudComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UVolumetricCloudComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170042E8 RID: 17128
		// (get) Token: 0x0601129D RID: 70301 RVA: 0x001931DF File Offset: 0x001913DF
		// (set) Token: 0x0601129E RID: 70302 RVA: 0x001931EF File Offset: 0x001913EF
		public unsafe float LayerBottomAltitude
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UVolumetricCloudComponent.__PropertyOffset_LayerBottomAltitude);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UVolumetricCloudComponent.__PropertyOffset_LayerBottomAltitude) = value;
			}
		}

		// Token: 0x170042E9 RID: 17129
		// (get) Token: 0x0601129F RID: 70303 RVA: 0x00193200 File Offset: 0x00191400
		// (set) Token: 0x060112A0 RID: 70304 RVA: 0x00193210 File Offset: 0x00191410
		public unsafe float LayerHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UVolumetricCloudComponent.__PropertyOffset_LayerHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UVolumetricCloudComponent.__PropertyOffset_LayerHeight) = value;
			}
		}

		// Token: 0x170042EA RID: 17130
		// (get) Token: 0x060112A1 RID: 70305 RVA: 0x00193221 File Offset: 0x00191421
		// (set) Token: 0x060112A2 RID: 70306 RVA: 0x00193231 File Offset: 0x00191431
		public unsafe float TracingStartMaxDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UVolumetricCloudComponent.__PropertyOffset_TracingStartMaxDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UVolumetricCloudComponent.__PropertyOffset_TracingStartMaxDistance) = value;
			}
		}

		// Token: 0x170042EB RID: 17131
		// (get) Token: 0x060112A3 RID: 70307 RVA: 0x00193242 File Offset: 0x00191442
		// (set) Token: 0x060112A4 RID: 70308 RVA: 0x00193252 File Offset: 0x00191452
		public unsafe float TracingMaxDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UVolumetricCloudComponent.__PropertyOffset_TracingMaxDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UVolumetricCloudComponent.__PropertyOffset_TracingMaxDistance) = value;
			}
		}

		// Token: 0x170042EC RID: 17132
		// (get) Token: 0x060112A5 RID: 70309 RVA: 0x00193263 File Offset: 0x00191463
		// (set) Token: 0x060112A6 RID: 70310 RVA: 0x00193273 File Offset: 0x00191473
		public unsafe float PlanetRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UVolumetricCloudComponent.__PropertyOffset_PlanetRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UVolumetricCloudComponent.__PropertyOffset_PlanetRadius) = value;
			}
		}

		// Token: 0x170042ED RID: 17133
		// (get) Token: 0x060112A7 RID: 70311 RVA: 0x00193284 File Offset: 0x00191484
		// (set) Token: 0x060112A8 RID: 70312 RVA: 0x00193298 File Offset: 0x00191498
		public unsafe FColor GroundAlbedo
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UVolumetricCloudComponent.__PropertyOffset_GroundAlbedo);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UVolumetricCloudComponent.__PropertyOffset_GroundAlbedo) = value;
			}
		}

		// Token: 0x170042EE RID: 17134
		// (get) Token: 0x060112A9 RID: 70313 RVA: 0x001932AD File Offset: 0x001914AD
		// (set) Token: 0x060112AA RID: 70314 RVA: 0x001932C1 File Offset: 0x001914C1
		public unsafe UMaterialInterface Material
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + UVolumetricCloudComponent.__PropertyOffset_Material);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UVolumetricCloudComponent.__PropertyOffset_Material, value);
			}
		}

		// Token: 0x170042EF RID: 17135
		// (get) Token: 0x060112AB RID: 70315 RVA: 0x001932D6 File Offset: 0x001914D6
		// (set) Token: 0x060112AC RID: 70316 RVA: 0x001932EF File Offset: 0x001914EF
		public unsafe bool bUsePerSampleAtmosphericLightTransmittance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UVolumetricCloudComponent.__PropertyOffset_bUsePerSampleAtmosphericLightTransmittance) & UVolumetricCloudComponent.__PropertyMask_bUsePerSampleAtmosphericLightTransmittance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UVolumetricCloudComponent.__PropertyOffset_bUsePerSampleAtmosphericLightTransmittance) = ((*(base.NativePtr + (IntPtr)UVolumetricCloudComponent.__PropertyOffset_bUsePerSampleAtmosphericLightTransmittance) & ~UVolumetricCloudComponent.__PropertyMask_bUsePerSampleAtmosphericLightTransmittance) | (value ? UVolumetricCloudComponent.__PropertyMask_bUsePerSampleAtmosphericLightTransmittance : 0));
			}
		}

		// Token: 0x170042F0 RID: 17136
		// (get) Token: 0x060112AD RID: 70317 RVA: 0x0019331F File Offset: 0x0019151F
		// (set) Token: 0x060112AE RID: 70318 RVA: 0x0019332F File Offset: 0x0019152F
		public unsafe float SkyLightCloudBottomOcclusion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UVolumetricCloudComponent.__PropertyOffset_SkyLightCloudBottomOcclusion);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UVolumetricCloudComponent.__PropertyOffset_SkyLightCloudBottomOcclusion) = value;
			}
		}

		// Token: 0x170042F1 RID: 17137
		// (get) Token: 0x060112AF RID: 70319 RVA: 0x00193340 File Offset: 0x00191540
		// (set) Token: 0x060112B0 RID: 70320 RVA: 0x00193350 File Offset: 0x00191550
		public unsafe float ViewSampleCountScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UVolumetricCloudComponent.__PropertyOffset_ViewSampleCountScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UVolumetricCloudComponent.__PropertyOffset_ViewSampleCountScale) = value;
			}
		}

		// Token: 0x170042F2 RID: 17138
		// (get) Token: 0x060112B1 RID: 70321 RVA: 0x00193361 File Offset: 0x00191561
		// (set) Token: 0x060112B2 RID: 70322 RVA: 0x00193371 File Offset: 0x00191571
		public unsafe float DistanceToSampleMaxCountScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UVolumetricCloudComponent.__PropertyOffset_DistanceToSampleMaxCountScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UVolumetricCloudComponent.__PropertyOffset_DistanceToSampleMaxCountScale) = value;
			}
		}

		// Token: 0x170042F3 RID: 17139
		// (get) Token: 0x060112B3 RID: 70323 RVA: 0x00193382 File Offset: 0x00191582
		// (set) Token: 0x060112B4 RID: 70324 RVA: 0x00193392 File Offset: 0x00191592
		public unsafe float ReflectionSampleCountScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UVolumetricCloudComponent.__PropertyOffset_ReflectionSampleCountScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UVolumetricCloudComponent.__PropertyOffset_ReflectionSampleCountScale) = value;
			}
		}

		// Token: 0x170042F4 RID: 17140
		// (get) Token: 0x060112B5 RID: 70325 RVA: 0x001933A3 File Offset: 0x001915A3
		// (set) Token: 0x060112B6 RID: 70326 RVA: 0x001933B3 File Offset: 0x001915B3
		public unsafe float ShadowViewSampleCountScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UVolumetricCloudComponent.__PropertyOffset_ShadowViewSampleCountScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UVolumetricCloudComponent.__PropertyOffset_ShadowViewSampleCountScale) = value;
			}
		}

		// Token: 0x170042F5 RID: 17141
		// (get) Token: 0x060112B7 RID: 70327 RVA: 0x001933C4 File Offset: 0x001915C4
		// (set) Token: 0x060112B8 RID: 70328 RVA: 0x001933D4 File Offset: 0x001915D4
		public unsafe float ShadowReflectionSampleCountScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UVolumetricCloudComponent.__PropertyOffset_ShadowReflectionSampleCountScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UVolumetricCloudComponent.__PropertyOffset_ShadowReflectionSampleCountScale) = value;
			}
		}

		// Token: 0x170042F6 RID: 17142
		// (get) Token: 0x060112B9 RID: 70329 RVA: 0x001933E5 File Offset: 0x001915E5
		// (set) Token: 0x060112BA RID: 70330 RVA: 0x001933F5 File Offset: 0x001915F5
		public unsafe float ShadowTracingDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UVolumetricCloudComponent.__PropertyOffset_ShadowTracingDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UVolumetricCloudComponent.__PropertyOffset_ShadowTracingDistance) = value;
			}
		}

		// Token: 0x170042F7 RID: 17143
		// (get) Token: 0x060112BB RID: 70331 RVA: 0x00193406 File Offset: 0x00191606
		// (set) Token: 0x060112BC RID: 70332 RVA: 0x0019341A File Offset: 0x0019161A
		public unsafe FLinearColor CloudColorTint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UVolumetricCloudComponent.__PropertyOffset_CloudColorTint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UVolumetricCloudComponent.__PropertyOffset_CloudColorTint) = value;
			}
		}

		// Token: 0x170042F8 RID: 17144
		// (get) Token: 0x060112BD RID: 70333 RVA: 0x0019342F File Offset: 0x0019162F
		// (set) Token: 0x060112BE RID: 70334 RVA: 0x0019343F File Offset: 0x0019163F
		public unsafe float CloudColorIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UVolumetricCloudComponent.__PropertyOffset_CloudColorIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UVolumetricCloudComponent.__PropertyOffset_CloudColorIntensity) = value;
			}
		}

		// Token: 0x060112BF RID: 70335 RVA: 0x00193450 File Offset: 0x00191650
		public void SetViewSampleCountScale(float NewValue)
		{
			UVolumetricCloudComponent.__SetViewSampleCountScale_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x060112C0 RID: 70336 RVA: 0x0019345E File Offset: 0x0019165E
		public void SetTracingStartMaxDistance(float NewValue)
		{
			UVolumetricCloudComponent.__SetTracingStartMaxDistance_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x060112C1 RID: 70337 RVA: 0x0019346C File Offset: 0x0019166C
		public void SetTracingMaxDistance(float NewValue)
		{
			UVolumetricCloudComponent.__SetTracingMaxDistance_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x060112C2 RID: 70338 RVA: 0x0019347A File Offset: 0x0019167A
		public void SetSkyLightCloudBottomOcclusion(float NewValue)
		{
			UVolumetricCloudComponent.__SetSkyLightCloudBottomOcclusion_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x060112C3 RID: 70339 RVA: 0x00193488 File Offset: 0x00191688
		public void SetShadowViewSampleCountScale(float NewValue)
		{
			UVolumetricCloudComponent.__SetShadowViewSampleCountScale_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x060112C4 RID: 70340 RVA: 0x00193496 File Offset: 0x00191696
		public void SetShadowTracingDistance(float NewValue)
		{
			UVolumetricCloudComponent.__SetShadowTracingDistance_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x060112C5 RID: 70341 RVA: 0x001934A4 File Offset: 0x001916A4
		public void SetShadowReflectionSampleCountScale(float NewValue)
		{
			UVolumetricCloudComponent.__SetShadowReflectionSampleCountScale_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x060112C6 RID: 70342 RVA: 0x001934B2 File Offset: 0x001916B2
		public void SetReflectionSampleCountScale(float NewValue)
		{
			UVolumetricCloudComponent.__SetReflectionSampleCountScale_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x060112C7 RID: 70343 RVA: 0x001934C0 File Offset: 0x001916C0
		public void SetPlanetRadius(float NewValue)
		{
			UVolumetricCloudComponent.__SetPlanetRadius_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x060112C8 RID: 70344 RVA: 0x001934CE File Offset: 0x001916CE
		public void SetMaterial(UMaterialInterface NewValue)
		{
			UVolumetricCloudComponent.__SetMaterial_Internal(base.NativePtr, (NewValue != null) ? NewValue.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060112C9 RID: 70345 RVA: 0x001934EB File Offset: 0x001916EB
		public void SetLayerHeight(float NewValue)
		{
			UVolumetricCloudComponent.__SetLayerHeight_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x060112CA RID: 70346 RVA: 0x001934F9 File Offset: 0x001916F9
		public void SetLayerBottomAltitude(float NewValue)
		{
			UVolumetricCloudComponent.__SetLayerBottomAltitude_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x060112CB RID: 70347 RVA: 0x00193507 File Offset: 0x00191707
		public void SetGroundAlbedo(FColor NewValue)
		{
			UVolumetricCloudComponent.__SetGroundAlbedo_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x060112CC RID: 70348 RVA: 0x00193515 File Offset: 0x00191715
		public void SetDistanceToSampleMaxCountScale(float NewValue)
		{
			UVolumetricCloudComponent.__SetDistanceToSampleMaxCountScale_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x060112CD RID: 70349 RVA: 0x00193523 File Offset: 0x00191723
		public void SetCloudColorTint(FLinearColor NewValue)
		{
			UVolumetricCloudComponent.__SetCloudColorTint_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x060112CE RID: 70350 RVA: 0x00193531 File Offset: 0x00191731
		public void SetCloudColorIntensity(float NewValue)
		{
			UVolumetricCloudComponent.__SetCloudColorIntensity_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x060112CF RID: 70351 RVA: 0x0019353F File Offset: 0x0019173F
		public void SetbUsePerSampleAtmosphericLightTransmittance(bool NewValue)
		{
			UVolumetricCloudComponent.__SetbUsePerSampleAtmosphericLightTransmittance_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x060112D0 RID: 70352
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetViewSampleCountScale_Internal(IntPtr @this, float NewValue);

		// Token: 0x060112D1 RID: 70353
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTracingStartMaxDistance_Internal(IntPtr @this, float NewValue);

		// Token: 0x060112D2 RID: 70354
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTracingMaxDistance_Internal(IntPtr @this, float NewValue);

		// Token: 0x060112D3 RID: 70355
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSkyLightCloudBottomOcclusion_Internal(IntPtr @this, float NewValue);

		// Token: 0x060112D4 RID: 70356
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetShadowViewSampleCountScale_Internal(IntPtr @this, float NewValue);

		// Token: 0x060112D5 RID: 70357
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetShadowTracingDistance_Internal(IntPtr @this, float NewValue);

		// Token: 0x060112D6 RID: 70358
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetShadowReflectionSampleCountScale_Internal(IntPtr @this, float NewValue);

		// Token: 0x060112D7 RID: 70359
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetReflectionSampleCountScale_Internal(IntPtr @this, float NewValue);

		// Token: 0x060112D8 RID: 70360
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPlanetRadius_Internal(IntPtr @this, float NewValue);

		// Token: 0x060112D9 RID: 70361
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMaterial_Internal(IntPtr @this, IntPtr NewValue);

		// Token: 0x060112DA RID: 70362
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLayerHeight_Internal(IntPtr @this, float NewValue);

		// Token: 0x060112DB RID: 70363
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLayerBottomAltitude_Internal(IntPtr @this, float NewValue);

		// Token: 0x060112DC RID: 70364
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGroundAlbedo_Internal(IntPtr @this, FColor NewValue);

		// Token: 0x060112DD RID: 70365
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDistanceToSampleMaxCountScale_Internal(IntPtr @this, float NewValue);

		// Token: 0x060112DE RID: 70366
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCloudColorTint_Internal(IntPtr @this, FLinearColor NewValue);

		// Token: 0x060112DF RID: 70367
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCloudColorIntensity_Internal(IntPtr @this, float NewValue);

		// Token: 0x060112E0 RID: 70368
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetbUsePerSampleAtmosphericLightTransmittance_Internal(IntPtr @this, bool NewValue);

		// Token: 0x060112E1 RID: 70369 RVA: 0x0019354D File Offset: 0x0019174D
		static UVolumetricCloudComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.VolumetricCloudComponent");
		}

		// Token: 0x060112E2 RID: 70370 RVA: 0x0019355B File Offset: 0x0019175B
		protected UVolumetricCloudComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040092EF RID: 37615
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.VolumetricCloudComponent";

		// Token: 0x040092F0 RID: 37616
		private static IntPtr _ClassPtr;

		// Token: 0x040092F1 RID: 37617
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040092F2 RID: 37618
		internal static int __PropertyOffset_LayerBottomAltitude;

		// Token: 0x040092F3 RID: 37619
		internal static int __PropertyOffset_LayerHeight;

		// Token: 0x040092F4 RID: 37620
		internal static int __PropertyOffset_TracingStartMaxDistance;

		// Token: 0x040092F5 RID: 37621
		internal static int __PropertyOffset_TracingMaxDistance;

		// Token: 0x040092F6 RID: 37622
		internal static int __PropertyOffset_PlanetRadius;

		// Token: 0x040092F7 RID: 37623
		internal static int __PropertyOffset_GroundAlbedo;

		// Token: 0x040092F8 RID: 37624
		internal static int __PropertyOffset_Material;

		// Token: 0x040092F9 RID: 37625
		internal static int __PropertyOffset_bUsePerSampleAtmosphericLightTransmittance;

		// Token: 0x040092FA RID: 37626
		internal static byte __PropertyMask_bUsePerSampleAtmosphericLightTransmittance;

		// Token: 0x040092FB RID: 37627
		internal static int __PropertyOffset_SkyLightCloudBottomOcclusion;

		// Token: 0x040092FC RID: 37628
		internal static int __PropertyOffset_ViewSampleCountScale;

		// Token: 0x040092FD RID: 37629
		internal static int __PropertyOffset_DistanceToSampleMaxCountScale;

		// Token: 0x040092FE RID: 37630
		internal static int __PropertyOffset_ReflectionSampleCountScale;

		// Token: 0x040092FF RID: 37631
		internal static int __PropertyOffset_ShadowViewSampleCountScale;

		// Token: 0x04009300 RID: 37632
		internal static int __PropertyOffset_ShadowReflectionSampleCountScale;

		// Token: 0x04009301 RID: 37633
		internal static int __PropertyOffset_ShadowTracingDistance;

		// Token: 0x04009302 RID: 37634
		internal static int __PropertyOffset_CloudColorTint;

		// Token: 0x04009303 RID: 37635
		internal static int __PropertyOffset_CloudColorIntensity;
	}
}
