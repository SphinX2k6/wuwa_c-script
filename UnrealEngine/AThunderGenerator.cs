using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C30 RID: 7216
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.ThunderGenerator")]
	[UnrealStructLayout(2048, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2048)]
	public class AThunderGenerator : AKuroGameBudgetBlueprintActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601BF1D RID: 114461 RVA: 0x00292004 File Offset: 0x00290204
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AThunderGenerator._ClassPtr;
		}

		// Token: 0x0601BF1E RID: 114462 RVA: 0x00292010 File Offset: 0x00290210
		public AThunderGenerator() : this(BuiltinUtils.AllocNativeUObject(AThunderGenerator.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601BF1F RID: 114463 RVA: 0x00292038 File Offset: 0x00290238
		[NullableContext(1)]
		public AThunderGenerator(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AThunderGenerator.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170070D7 RID: 28887
		// (get) Token: 0x0601BF20 RID: 114464 RVA: 0x0029206B File Offset: 0x0029026B
		// (set) Token: 0x0601BF21 RID: 114465 RVA: 0x0029207B File Offset: 0x0029027B
		public unsafe float PointLightHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AThunderGenerator.__PropertyOffset_PointLightHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AThunderGenerator.__PropertyOffset_PointLightHeight) = value;
			}
		}

		// Token: 0x170070D8 RID: 28888
		// (get) Token: 0x0601BF22 RID: 114466 RVA: 0x0029208C File Offset: 0x0029028C
		// (set) Token: 0x0601BF23 RID: 114467 RVA: 0x002920A0 File Offset: 0x002902A0
		public unsafe UKuroWeatherDataAsset WeatherDataAsset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroWeatherDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + AThunderGenerator.__PropertyOffset_WeatherDataAsset);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AThunderGenerator.__PropertyOffset_WeatherDataAsset, value);
			}
		}

		// Token: 0x170070D9 RID: 28889
		// (get) Token: 0x0601BF24 RID: 114468 RVA: 0x002920B5 File Offset: 0x002902B5
		// (set) Token: 0x0601BF25 RID: 114469 RVA: 0x002920C5 File Offset: 0x002902C5
		public unsafe float TraceHeightMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AThunderGenerator.__PropertyOffset_TraceHeightMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AThunderGenerator.__PropertyOffset_TraceHeightMin) = value;
			}
		}

		// Token: 0x170070DA RID: 28890
		// (get) Token: 0x0601BF26 RID: 114470 RVA: 0x002920D6 File Offset: 0x002902D6
		// (set) Token: 0x0601BF27 RID: 114471 RVA: 0x002920E6 File Offset: 0x002902E6
		public unsafe float TraceHeightMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AThunderGenerator.__PropertyOffset_TraceHeightMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AThunderGenerator.__PropertyOffset_TraceHeightMax) = value;
			}
		}

		// Token: 0x170070DB RID: 28891
		// (get) Token: 0x0601BF28 RID: 114472 RVA: 0x002920F7 File Offset: 0x002902F7
		// (set) Token: 0x0601BF29 RID: 114473 RVA: 0x00292107 File Offset: 0x00290307
		public unsafe float DistributionFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AThunderGenerator.__PropertyOffset_DistributionFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AThunderGenerator.__PropertyOffset_DistributionFactor) = value;
			}
		}

		// Token: 0x170070DC RID: 28892
		// (get) Token: 0x0601BF2A RID: 114474 RVA: 0x00292118 File Offset: 0x00290318
		// (set) Token: 0x0601BF2B RID: 114475 RVA: 0x00292128 File Offset: 0x00290328
		public unsafe float GenerateIntervalMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AThunderGenerator.__PropertyOffset_GenerateIntervalMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AThunderGenerator.__PropertyOffset_GenerateIntervalMin) = value;
			}
		}

		// Token: 0x170070DD RID: 28893
		// (get) Token: 0x0601BF2C RID: 114476 RVA: 0x00292139 File Offset: 0x00290339
		// (set) Token: 0x0601BF2D RID: 114477 RVA: 0x00292149 File Offset: 0x00290349
		public unsafe float GenerateIntervalMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AThunderGenerator.__PropertyOffset_GenerateIntervalMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AThunderGenerator.__PropertyOffset_GenerateIntervalMax) = value;
			}
		}

		// Token: 0x170070DE RID: 28894
		// (get) Token: 0x0601BF2E RID: 114478 RVA: 0x0029215A File Offset: 0x0029035A
		// (set) Token: 0x0601BF2F RID: 114479 RVA: 0x0029216A File Offset: 0x0029036A
		public unsafe float GenerateChance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AThunderGenerator.__PropertyOffset_GenerateChance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AThunderGenerator.__PropertyOffset_GenerateChance) = value;
			}
		}

		// Token: 0x170070DF RID: 28895
		// (get) Token: 0x0601BF30 RID: 114480 RVA: 0x0029217B File Offset: 0x0029037B
		// (set) Token: 0x0601BF31 RID: 114481 RVA: 0x0029218B File Offset: 0x0029038B
		public unsafe float ThunderPlayInnerRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AThunderGenerator.__PropertyOffset_ThunderPlayInnerRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AThunderGenerator.__PropertyOffset_ThunderPlayInnerRange) = value;
			}
		}

		// Token: 0x170070E0 RID: 28896
		// (get) Token: 0x0601BF32 RID: 114482 RVA: 0x0029219C File Offset: 0x0029039C
		// (set) Token: 0x0601BF33 RID: 114483 RVA: 0x002921AC File Offset: 0x002903AC
		public unsafe float ThunderPlayRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AThunderGenerator.__PropertyOffset_ThunderPlayRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AThunderGenerator.__PropertyOffset_ThunderPlayRange) = value;
			}
		}

		// Token: 0x170070E1 RID: 28897
		// (get) Token: 0x0601BF34 RID: 114484 RVA: 0x002921BD File Offset: 0x002903BD
		// (set) Token: 0x0601BF35 RID: 114485 RVA: 0x002921CD File Offset: 0x002903CD
		public unsafe float BaseThunderAttackChance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AThunderGenerator.__PropertyOffset_BaseThunderAttackChance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AThunderGenerator.__PropertyOffset_BaseThunderAttackChance) = value;
			}
		}

		// Token: 0x170070E2 RID: 28898
		// (get) Token: 0x0601BF36 RID: 114486 RVA: 0x002921E0 File Offset: 0x002903E0
		// (set) Token: 0x0601BF37 RID: 114487 RVA: 0x00292219 File Offset: 0x00290419
		[Nullable(1)]
		public FKuroCurveFloat PointLightCurve
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._PointLightCurve) == null)
				{
					result = (this._PointLightCurve = new FKuroCurveFloat(base.NativePtr + (IntPtr)AThunderGenerator.__PropertyOffset_PointLightCurve, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)AThunderGenerator.__PropertyOffset_PointLightCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170070E3 RID: 28899
		// (get) Token: 0x0601BF38 RID: 114488 RVA: 0x0029223C File Offset: 0x0029043C
		// (set) Token: 0x0601BF39 RID: 114489 RVA: 0x00292275 File Offset: 0x00290475
		[Nullable(1)]
		public FKuroCurveFloat PointLightRadiusCurve
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._PointLightRadiusCurve) == null)
				{
					result = (this._PointLightRadiusCurve = new FKuroCurveFloat(base.NativePtr + (IntPtr)AThunderGenerator.__PropertyOffset_PointLightRadiusCurve, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)AThunderGenerator.__PropertyOffset_PointLightRadiusCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170070E4 RID: 28900
		// (get) Token: 0x0601BF3A RID: 114490 RVA: 0x00292298 File Offset: 0x00290498
		// (set) Token: 0x0601BF3B RID: 114491 RVA: 0x002922D1 File Offset: 0x002904D1
		[Nullable(1)]
		public FKuroCurveFloat PostProcessCurve
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._PostProcessCurve) == null)
				{
					result = (this._PostProcessCurve = new FKuroCurveFloat(base.NativePtr + (IntPtr)AThunderGenerator.__PropertyOffset_PostProcessCurve, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)AThunderGenerator.__PropertyOffset_PostProcessCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170070E5 RID: 28901
		// (get) Token: 0x0601BF3C RID: 114492 RVA: 0x002922F2 File Offset: 0x002904F2
		// (set) Token: 0x0601BF3D RID: 114493 RVA: 0x00292306 File Offset: 0x00290506
		public unsafe UNiagaraSystem NiagaraSystem
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraSystem>(base.NativePtr / (IntPtr)sizeof(void*) + AThunderGenerator.__PropertyOffset_NiagaraSystem);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AThunderGenerator.__PropertyOffset_NiagaraSystem, value);
			}
		}

		// Token: 0x170070E6 RID: 28902
		// (get) Token: 0x0601BF3E RID: 114494 RVA: 0x0029231B File Offset: 0x0029051B
		// (set) Token: 0x0601BF3F RID: 114495 RVA: 0x0029232F File Offset: 0x0029052F
		public unsafe UNiagaraComponent NiagaraComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AThunderGenerator.__PropertyOffset_NiagaraComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AThunderGenerator.__PropertyOffset_NiagaraComponent, value);
			}
		}

		// Token: 0x170070E7 RID: 28903
		// (get) Token: 0x0601BF40 RID: 114496 RVA: 0x00292344 File Offset: 0x00290544
		// (set) Token: 0x0601BF41 RID: 114497 RVA: 0x00292358 File Offset: 0x00290558
		public unsafe UPointLightComponent PointLightComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPointLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AThunderGenerator.__PropertyOffset_PointLightComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AThunderGenerator.__PropertyOffset_PointLightComponent, value);
			}
		}

		// Token: 0x170070E8 RID: 28904
		// (get) Token: 0x0601BF42 RID: 114498 RVA: 0x0029236D File Offset: 0x0029056D
		// (set) Token: 0x0601BF43 RID: 114499 RVA: 0x00292381 File Offset: 0x00290581
		public unsafe UKuroPostProcessComponent KuroPostProcessComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AThunderGenerator.__PropertyOffset_KuroPostProcessComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AThunderGenerator.__PropertyOffset_KuroPostProcessComponent, value);
			}
		}

		// Token: 0x170070E9 RID: 28905
		// (get) Token: 0x0601BF44 RID: 114500 RVA: 0x00292396 File Offset: 0x00290596
		// (set) Token: 0x0601BF45 RID: 114501 RVA: 0x002923AA File Offset: 0x002905AA
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<AKuroGlobalGI> CachedGlobalGI
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)AThunderGenerator.__PropertyOffset_CachedGlobalGI);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)AThunderGenerator.__PropertyOffset_CachedGlobalGI) = value;
			}
		}

		// Token: 0x170070EA RID: 28906
		// (get) Token: 0x0601BF46 RID: 114502 RVA: 0x002923BF File Offset: 0x002905BF
		// (set) Token: 0x0601BF47 RID: 114503 RVA: 0x002923D3 File Offset: 0x002905D3
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UKuroGISystem> CachedGISystem
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)AThunderGenerator.__PropertyOffset_CachedGISystem);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)AThunderGenerator.__PropertyOffset_CachedGISystem) = value;
			}
		}

		// Token: 0x170070EB RID: 28907
		// (get) Token: 0x0601BF48 RID: 114504 RVA: 0x002923E8 File Offset: 0x002905E8
		// (set) Token: 0x0601BF49 RID: 114505 RVA: 0x002923F8 File Offset: 0x002905F8
		public unsafe float ThunderAge
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AThunderGenerator.__PropertyOffset_ThunderAge);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AThunderGenerator.__PropertyOffset_ThunderAge) = value;
			}
		}

		// Token: 0x170070EC RID: 28908
		// (get) Token: 0x0601BF4A RID: 114506 RVA: 0x00292409 File Offset: 0x00290609
		// (set) Token: 0x0601BF4B RID: 114507 RVA: 0x00292419 File Offset: 0x00290619
		public unsafe float AttackAge
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AThunderGenerator.__PropertyOffset_AttackAge);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AThunderGenerator.__PropertyOffset_AttackAge) = value;
			}
		}

		// Token: 0x170070ED RID: 28909
		// (get) Token: 0x0601BF4C RID: 114508 RVA: 0x0029242A File Offset: 0x0029062A
		// (set) Token: 0x0601BF4D RID: 114509 RVA: 0x0029243A File Offset: 0x0029063A
		public unsafe bool bThunderActive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AThunderGenerator.__PropertyOffset_bThunderActive) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AThunderGenerator.__PropertyOffset_bThunderActive) = (value ? 1 : 0);
			}
		}

		// Token: 0x170070EE RID: 28910
		// (get) Token: 0x0601BF4E RID: 114510 RVA: 0x0029244B File Offset: 0x0029064B
		// (set) Token: 0x0601BF4F RID: 114511 RVA: 0x0029245F File Offset: 0x0029065F
		[Nullable(0)]
		public unsafe TEnumAsByte<EKuroThunderType> CurrentThunderType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)AThunderGenerator.__PropertyOffset_CurrentThunderType);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)AThunderGenerator.__PropertyOffset_CurrentThunderType) = value;
			}
		}

		// Token: 0x170070EF RID: 28911
		// (get) Token: 0x0601BF50 RID: 114512 RVA: 0x00292474 File Offset: 0x00290674
		// (set) Token: 0x0601BF51 RID: 114513 RVA: 0x00292484 File Offset: 0x00290684
		public unsafe float FinalThunderGenerateChance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AThunderGenerator.__PropertyOffset_FinalThunderGenerateChance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AThunderGenerator.__PropertyOffset_FinalThunderGenerateChance) = value;
			}
		}

		// Token: 0x170070F0 RID: 28912
		// (get) Token: 0x0601BF52 RID: 114514 RVA: 0x00292495 File Offset: 0x00290695
		// (set) Token: 0x0601BF53 RID: 114515 RVA: 0x002924A5 File Offset: 0x002906A5
		public unsafe float FinalThunderAttackChance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AThunderGenerator.__PropertyOffset_FinalThunderAttackChance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AThunderGenerator.__PropertyOffset_FinalThunderAttackChance) = value;
			}
		}

		// Token: 0x170070F1 RID: 28913
		// (get) Token: 0x0601BF54 RID: 114516 RVA: 0x002924B6 File Offset: 0x002906B6
		// (set) Token: 0x0601BF55 RID: 114517 RVA: 0x002924C6 File Offset: 0x002906C6
		public unsafe float ThunderCloudIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AThunderGenerator.__PropertyOffset_ThunderCloudIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AThunderGenerator.__PropertyOffset_ThunderCloudIntensity) = value;
			}
		}

		// Token: 0x170070F2 RID: 28914
		// (get) Token: 0x0601BF56 RID: 114518 RVA: 0x002924D7 File Offset: 0x002906D7
		// (set) Token: 0x0601BF57 RID: 114519 RVA: 0x002924E7 File Offset: 0x002906E7
		public unsafe float ThunderPostProcessIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AThunderGenerator.__PropertyOffset_ThunderPostProcessIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AThunderGenerator.__PropertyOffset_ThunderPostProcessIntensity) = value;
			}
		}

		// Token: 0x170070F3 RID: 28915
		// (get) Token: 0x0601BF58 RID: 114520 RVA: 0x002924F8 File Offset: 0x002906F8
		// (set) Token: 0x0601BF59 RID: 114521 RVA: 0x0029250C File Offset: 0x0029070C
		public unsafe FLinearColor ThunderPostProcessMainLightColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AThunderGenerator.__PropertyOffset_ThunderPostProcessMainLightColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AThunderGenerator.__PropertyOffset_ThunderPostProcessMainLightColor) = value;
			}
		}

		// Token: 0x170070F4 RID: 28916
		// (get) Token: 0x0601BF5A RID: 114522 RVA: 0x00292521 File Offset: 0x00290721
		// (set) Token: 0x0601BF5B RID: 114523 RVA: 0x00292535 File Offset: 0x00290735
		public unsafe FLinearColor ThunderPostProcessOriginColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AThunderGenerator.__PropertyOffset_ThunderPostProcessOriginColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AThunderGenerator.__PropertyOffset_ThunderPostProcessOriginColor) = value;
			}
		}

		// Token: 0x0601BF5C RID: 114524 RVA: 0x0029254A File Offset: 0x0029074A
		public static void SpawnThunderInWorld(UObject WorldContextObject, FVector Location, bool bAttack)
		{
			AThunderGenerator.__SpawnThunderInWorld_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Location, bAttack);
		}

		// Token: 0x0601BF5D RID: 114525 RVA: 0x00292563 File Offset: 0x00290763
		public void SpawnThunder(FVector HitLocation, bool bAttack)
		{
			AThunderGenerator.__SpawnThunder_Internal(base.NativePtr, HitLocation, bAttack);
		}

		// Token: 0x0601BF5E RID: 114526 RVA: 0x00292572 File Offset: 0x00290772
		public virtual void OnUpdateThunderEffect(float DeltaSeconds)
		{
			AThunderGenerator.__OnUpdateThunderEffect_Internal(base.NativePtr, DeltaSeconds);
		}

		// Token: 0x0601BF5F RID: 114527 RVA: 0x00292580 File Offset: 0x00290780
		public virtual void OnThunderTypeChanged()
		{
			AThunderGenerator.__OnThunderTypeChanged_Internal(base.NativePtr);
		}

		// Token: 0x0601BF60 RID: 114528 RVA: 0x00292590 File Offset: 0x00290790
		public unsafe virtual void OnReceiveThunderTrigger(AThunderTrigger Trigger, in FTransform CameraTransform)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = CameraTransform;
			AThunderGenerator.__OnReceiveThunderTrigger_Internal(base.NativePtr, (Trigger != null) ? Trigger.NativePtr : IntPtr.Zero, ptr);
		}

		// Token: 0x0601BF61 RID: 114529 RVA: 0x002925D5 File Offset: 0x002907D5
		public virtual void OnReceiveThunderAttack(FVector Location, bool bAttack)
		{
			AThunderGenerator.__OnReceiveThunderAttack_Internal(base.NativePtr, Location, bAttack);
		}

		// Token: 0x0601BF62 RID: 114530 RVA: 0x002925E4 File Offset: 0x002907E4
		public virtual void EnableThunder()
		{
			AThunderGenerator.__EnableThunder_Internal(base.NativePtr);
		}

		// Token: 0x0601BF63 RID: 114531 RVA: 0x002925F1 File Offset: 0x002907F1
		public virtual void DisableThunder()
		{
			AThunderGenerator.__DisableThunder_Internal(base.NativePtr);
		}

		// Token: 0x0601BF64 RID: 114532 RVA: 0x00292600 File Offset: 0x00290800
		public unsafe static FVector CalculateThunderPositionAdvanced(in FTransform CameraTransform, float MinRadius = 1000f, float MaxRadius = 5000f, float EdgeThickness = 0.2f, float MinVerticalAngle = -30f, float MaxVerticalAngle = 45f, float HorizontalFocusAngle = 0f, float HorizontalFocusStrength = 0.3f, int RandomSeed = 0)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			*uintPtr = CameraTransform;
			return AThunderGenerator.__CalculateThunderPositionAdvanced_Internal(uintPtr, MinRadius, MaxRadius, EdgeThickness, MinVerticalAngle, MaxVerticalAngle, HorizontalFocusAngle, HorizontalFocusStrength, RandomSeed);
		}

		// Token: 0x0601BF65 RID: 114533 RVA: 0x0029263C File Offset: 0x0029083C
		public unsafe virtual bool CalculateThunderPosition(in FTransform CameraTransform, ref FVector OutPosition, bool bAttack)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = CameraTransform;
			fixed (FVector* ptr2 = &OutPosition)
			{
				void* ptr3 = (void*)ptr2;
				return AThunderGenerator.__CalculateThunderPosition_Internal(base.NativePtr, ptr, ref OutPosition, bAttack);
			}
		}

		// Token: 0x0601BF66 RID: 114534 RVA: 0x00292678 File Offset: 0x00290878
		protected unsafe virtual bool CalculateThunderPosition_Implementation(in FTransform CameraTransform, ref FVector OutPosition, bool bAttack)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = CameraTransform;
			fixed (FVector* ptr2 = &OutPosition)
			{
				void* ptr3 = (void*)ptr2;
				return AThunderGenerator.__CalculateThunderPosition_Implementation_Internal(base.NativePtr, ptr, ref OutPosition, bAttack);
			}
		}

		// Token: 0x0601BF67 RID: 114535
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SpawnThunderInWorld_Internal(IntPtr WorldContextObject, FVector Location, bool bAttack);

		// Token: 0x0601BF68 RID: 114536
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SpawnThunder_Internal(IntPtr @this, FVector HitLocation, bool bAttack);

		// Token: 0x0601BF69 RID: 114537
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnUpdateThunderEffect_Internal(IntPtr @this, float DeltaSeconds);

		// Token: 0x0601BF6A RID: 114538
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnThunderTypeChanged_Internal(IntPtr @this);

		// Token: 0x0601BF6B RID: 114539
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnReceiveThunderTrigger_Internal(IntPtr @this, IntPtr Trigger, in FTransform CameraTransform);

		// Token: 0x0601BF6C RID: 114540
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnReceiveThunderAttack_Internal(IntPtr @this, FVector Location, bool bAttack);

		// Token: 0x0601BF6D RID: 114541
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EnableThunder_Internal(IntPtr @this);

		// Token: 0x0601BF6E RID: 114542
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DisableThunder_Internal(IntPtr @this);

		// Token: 0x0601BF6F RID: 114543
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __CalculateThunderPositionAdvanced_Internal(in FTransform CameraTransform, float MinRadius, float MaxRadius, float EdgeThickness, float MinVerticalAngle, float MaxVerticalAngle, float HorizontalFocusAngle, float HorizontalFocusStrength, int RandomSeed);

		// Token: 0x0601BF70 RID: 114544
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CalculateThunderPosition_Internal(IntPtr @this, in FTransform CameraTransform, ref FVector OutPosition, bool bAttack);

		// Token: 0x0601BF71 RID: 114545
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CalculateThunderPosition_Implementation_Internal(IntPtr @this, in FTransform CameraTransform, ref FVector OutPosition, bool bAttack);

		// Token: 0x0601BF72 RID: 114546 RVA: 0x002926B4 File Offset: 0x002908B4
		static AThunderGenerator()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.ThunderGenerator");
		}

		// Token: 0x0601BF73 RID: 114547 RVA: 0x002926C2 File Offset: 0x002908C2
		protected AThunderGenerator(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F026 RID: 61478
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.ThunderGenerator";

		// Token: 0x0400F027 RID: 61479
		private static IntPtr _ClassPtr;

		// Token: 0x0400F028 RID: 61480
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F029 RID: 61481
		internal static int __PropertyOffset_PointLightHeight;

		// Token: 0x0400F02A RID: 61482
		internal static int __PropertyOffset_WeatherDataAsset;

		// Token: 0x0400F02B RID: 61483
		internal static int __PropertyOffset_TraceHeightMin;

		// Token: 0x0400F02C RID: 61484
		internal static int __PropertyOffset_TraceHeightMax;

		// Token: 0x0400F02D RID: 61485
		internal static int __PropertyOffset_DistributionFactor;

		// Token: 0x0400F02E RID: 61486
		internal static int __PropertyOffset_GenerateIntervalMin;

		// Token: 0x0400F02F RID: 61487
		internal static int __PropertyOffset_GenerateIntervalMax;

		// Token: 0x0400F030 RID: 61488
		internal static int __PropertyOffset_GenerateChance;

		// Token: 0x0400F031 RID: 61489
		internal static int __PropertyOffset_ThunderPlayInnerRange;

		// Token: 0x0400F032 RID: 61490
		internal static int __PropertyOffset_ThunderPlayRange;

		// Token: 0x0400F033 RID: 61491
		internal static int __PropertyOffset_BaseThunderAttackChance;

		// Token: 0x0400F034 RID: 61492
		internal static int __PropertyOffset_PointLightCurve;

		// Token: 0x0400F035 RID: 61493
		private FKuroCurveFloat _PointLightCurve;

		// Token: 0x0400F036 RID: 61494
		internal static int __PropertyOffset_PointLightRadiusCurve;

		// Token: 0x0400F037 RID: 61495
		private FKuroCurveFloat _PointLightRadiusCurve;

		// Token: 0x0400F038 RID: 61496
		internal static int __PropertyOffset_PostProcessCurve;

		// Token: 0x0400F039 RID: 61497
		private FKuroCurveFloat _PostProcessCurve;

		// Token: 0x0400F03A RID: 61498
		internal static int __PropertyOffset_NiagaraSystem;

		// Token: 0x0400F03B RID: 61499
		internal static int __PropertyOffset_NiagaraComponent;

		// Token: 0x0400F03C RID: 61500
		internal static int __PropertyOffset_PointLightComponent;

		// Token: 0x0400F03D RID: 61501
		internal static int __PropertyOffset_KuroPostProcessComponent;

		// Token: 0x0400F03E RID: 61502
		internal static int __PropertyOffset_CachedGlobalGI;

		// Token: 0x0400F03F RID: 61503
		internal static int __PropertyOffset_CachedGISystem;

		// Token: 0x0400F040 RID: 61504
		internal static int __PropertyOffset_ThunderAge;

		// Token: 0x0400F041 RID: 61505
		internal static int __PropertyOffset_AttackAge;

		// Token: 0x0400F042 RID: 61506
		internal static int __PropertyOffset_bThunderActive;

		// Token: 0x0400F043 RID: 61507
		internal static int __PropertyOffset_CurrentThunderType;

		// Token: 0x0400F044 RID: 61508
		internal static int __PropertyOffset_FinalThunderGenerateChance;

		// Token: 0x0400F045 RID: 61509
		internal static int __PropertyOffset_FinalThunderAttackChance;

		// Token: 0x0400F046 RID: 61510
		internal static int __PropertyOffset_ThunderCloudIntensity;

		// Token: 0x0400F047 RID: 61511
		internal static int __PropertyOffset_ThunderPostProcessIntensity;

		// Token: 0x0400F048 RID: 61512
		internal static int __PropertyOffset_ThunderPostProcessMainLightColor;

		// Token: 0x0400F049 RID: 61513
		internal static int __PropertyOffset_ThunderPostProcessOriginColor;

		// Token: 0x020031A8 RID: 12712
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __OnUpdateThunderEffect_FunctionParams
		{
			// Token: 0x04016FE7 RID: 94183
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x020031A9 RID: 12713
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __OnReceiveThunderTrigger_FunctionParams
		{
			// Token: 0x04016FE8 RID: 94184
			[FieldOffset(0)]
			public IntPtr Trigger;

			// Token: 0x04016FE9 RID: 94185
			[FieldOffset(16)]
			public FTransform CameraTransform;
		}

		// Token: 0x020031AA RID: 12714
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OnReceiveThunderAttack_FunctionParams
		{
			// Token: 0x04016FEA RID: 94186
			[FieldOffset(0)]
			public FVector Location;

			// Token: 0x04016FEB RID: 94187
			[FieldOffset(12)]
			public bool bAttack;
		}

		// Token: 0x020031AB RID: 12715
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __CalculateThunderPosition_FunctionParams
		{
			// Token: 0x04016FEC RID: 94188
			[FieldOffset(0)]
			public FTransform CameraTransform;

			// Token: 0x04016FED RID: 94189
			[FieldOffset(48)]
			public FVector OutPosition;

			// Token: 0x04016FEE RID: 94190
			[FieldOffset(60)]
			public bool bAttack;

			// Token: 0x04016FEF RID: 94191
			[FieldOffset(61)]
			public bool __Result;
		}
	}
}
