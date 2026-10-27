using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001AF4 RID: 6900
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroFlickerLightActor")]
	[UnrealStructLayout(1504, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1504)]
	public class AKuroFlickerLightActor : AKuroGameBudgetBlueprintActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06019C55 RID: 105557 RVA: 0x00261280 File Offset: 0x0025F480
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroFlickerLightActor._ClassPtr;
		}

		// Token: 0x06019C56 RID: 105558 RVA: 0x0026128C File Offset: 0x0025F48C
		public AKuroFlickerLightActor() : this(BuiltinUtils.AllocNativeUObject(AKuroFlickerLightActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06019C57 RID: 105559 RVA: 0x002612B4 File Offset: 0x0025F4B4
		[NullableContext(1)]
		public AKuroFlickerLightActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroFlickerLightActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006713 RID: 26387
		// (get) Token: 0x06019C58 RID: 105560 RVA: 0x002612E7 File Offset: 0x0025F4E7
		// (set) Token: 0x06019C59 RID: 105561 RVA: 0x002612FB File Offset: 0x0025F4FB
		public unsafe UKuroFlickerLightPreset Preset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroFlickerLightPreset>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroFlickerLightActor.__PropertyOffset_Preset);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroFlickerLightActor.__PropertyOffset_Preset, value);
			}
		}

		// Token: 0x17006714 RID: 26388
		// (get) Token: 0x06019C5A RID: 105562 RVA: 0x00261310 File Offset: 0x0025F510
		// (set) Token: 0x06019C5B RID: 105563 RVA: 0x00261320 File Offset: 0x0025F520
		public unsafe float BaseIntensityScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFlickerLightActor.__PropertyOffset_BaseIntensityScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFlickerLightActor.__PropertyOffset_BaseIntensityScale) = value;
			}
		}

		// Token: 0x17006715 RID: 26389
		// (get) Token: 0x06019C5C RID: 105564 RVA: 0x00261331 File Offset: 0x0025F531
		// (set) Token: 0x06019C5D RID: 105565 RVA: 0x00261341 File Offset: 0x0025F541
		public unsafe float IntensityCurveScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFlickerLightActor.__PropertyOffset_IntensityCurveScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFlickerLightActor.__PropertyOffset_IntensityCurveScale) = value;
			}
		}

		// Token: 0x17006716 RID: 26390
		// (get) Token: 0x06019C5E RID: 105566 RVA: 0x00261352 File Offset: 0x0025F552
		// (set) Token: 0x06019C5F RID: 105567 RVA: 0x00261362 File Offset: 0x0025F562
		public unsafe float FlickSpeedScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFlickerLightActor.__PropertyOffset_FlickSpeedScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFlickerLightActor.__PropertyOffset_FlickSpeedScale) = value;
			}
		}

		// Token: 0x17006717 RID: 26391
		// (get) Token: 0x06019C60 RID: 105568 RVA: 0x00261373 File Offset: 0x0025F573
		// (set) Token: 0x06019C61 RID: 105569 RVA: 0x00261383 File Offset: 0x0025F583
		public unsafe bool bApplyToonLight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFlickerLightActor.__PropertyOffset_bApplyToonLight) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFlickerLightActor.__PropertyOffset_bApplyToonLight) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006718 RID: 26392
		// (get) Token: 0x06019C62 RID: 105570 RVA: 0x00261394 File Offset: 0x0025F594
		// (set) Token: 0x06019C63 RID: 105571 RVA: 0x002613A4 File Offset: 0x0025F5A4
		public unsafe float ToonLightBaseIntensityScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFlickerLightActor.__PropertyOffset_ToonLightBaseIntensityScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFlickerLightActor.__PropertyOffset_ToonLightBaseIntensityScale) = value;
			}
		}

		// Token: 0x17006719 RID: 26393
		// (get) Token: 0x06019C64 RID: 105572 RVA: 0x002613B5 File Offset: 0x0025F5B5
		// (set) Token: 0x06019C65 RID: 105573 RVA: 0x002613C5 File Offset: 0x0025F5C5
		public unsafe float ToonLightIntensityCurveScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFlickerLightActor.__PropertyOffset_ToonLightIntensityCurveScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFlickerLightActor.__PropertyOffset_ToonLightIntensityCurveScale) = value;
			}
		}

		// Token: 0x1700671A RID: 26394
		// (get) Token: 0x06019C66 RID: 105574 RVA: 0x002613D6 File Offset: 0x0025F5D6
		// (set) Token: 0x06019C67 RID: 105575 RVA: 0x002613E6 File Offset: 0x0025F5E6
		public unsafe bool bApplyToonHardLight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFlickerLightActor.__PropertyOffset_bApplyToonHardLight) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFlickerLightActor.__PropertyOffset_bApplyToonHardLight) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700671B RID: 26395
		// (get) Token: 0x06019C68 RID: 105576 RVA: 0x002613F7 File Offset: 0x0025F5F7
		// (set) Token: 0x06019C69 RID: 105577 RVA: 0x00261407 File Offset: 0x0025F607
		public unsafe float ToonHardLightBaseIntensityScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFlickerLightActor.__PropertyOffset_ToonHardLightBaseIntensityScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFlickerLightActor.__PropertyOffset_ToonHardLightBaseIntensityScale) = value;
			}
		}

		// Token: 0x1700671C RID: 26396
		// (get) Token: 0x06019C6A RID: 105578 RVA: 0x00261418 File Offset: 0x0025F618
		// (set) Token: 0x06019C6B RID: 105579 RVA: 0x00261428 File Offset: 0x0025F628
		public unsafe float ToonHardLightIntensityCurveScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFlickerLightActor.__PropertyOffset_ToonHardLightIntensityCurveScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFlickerLightActor.__PropertyOffset_ToonHardLightIntensityCurveScale) = value;
			}
		}

		// Token: 0x1700671D RID: 26397
		// (get) Token: 0x06019C6C RID: 105580 RVA: 0x00261439 File Offset: 0x0025F639
		// (set) Token: 0x06019C6D RID: 105581 RVA: 0x00261449 File Offset: 0x0025F649
		public unsafe float AllIntensityScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFlickerLightActor.__PropertyOffset_AllIntensityScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFlickerLightActor.__PropertyOffset_AllIntensityScale) = value;
			}
		}

		// Token: 0x1700671E RID: 26398
		// (get) Token: 0x06019C6E RID: 105582 RVA: 0x0026145A File Offset: 0x0025F65A
		// (set) Token: 0x06019C6F RID: 105583 RVA: 0x0026146A File Offset: 0x0025F66A
		public unsafe float CurrentBaseIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFlickerLightActor.__PropertyOffset_CurrentBaseIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFlickerLightActor.__PropertyOffset_CurrentBaseIntensity) = value;
			}
		}

		// Token: 0x1700671F RID: 26399
		// (get) Token: 0x06019C70 RID: 105584 RVA: 0x0026147B File Offset: 0x0025F67B
		// (set) Token: 0x06019C71 RID: 105585 RVA: 0x0026148B File Offset: 0x0025F68B
		public unsafe float CurrentIntensityCurve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFlickerLightActor.__PropertyOffset_CurrentIntensityCurve);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFlickerLightActor.__PropertyOffset_CurrentIntensityCurve) = value;
			}
		}

		// Token: 0x17006720 RID: 26400
		// (get) Token: 0x06019C72 RID: 105586 RVA: 0x0026149C File Offset: 0x0025F69C
		// (set) Token: 0x06019C73 RID: 105587 RVA: 0x002614B0 File Offset: 0x0025F6B0
		public unsafe UPointLightComponent RootLight
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPointLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroFlickerLightActor.__PropertyOffset_RootLight);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroFlickerLightActor.__PropertyOffset_RootLight, value);
			}
		}

		// Token: 0x06019C74 RID: 105588 RVA: 0x002614C5 File Offset: 0x0025F6C5
		public void UpdateLight()
		{
			AKuroFlickerLightActor.__UpdateLight_Internal(base.NativePtr);
		}

		// Token: 0x06019C75 RID: 105589 RVA: 0x002614D2 File Offset: 0x0025F6D2
		public virtual void ForeachPointLight(UPointLightComponent PointLightComponent)
		{
			AKuroFlickerLightActor.__ForeachPointLight_Internal(base.NativePtr, (PointLightComponent != null) ? PointLightComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06019C76 RID: 105590 RVA: 0x002614EF File Offset: 0x0025F6EF
		protected virtual void ForeachPointLight_Implementation(UPointLightComponent PointLightComponent)
		{
			AKuroFlickerLightActor.__ForeachPointLight_Implementation_Internal(base.NativePtr, (PointLightComponent != null) ? PointLightComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06019C77 RID: 105591 RVA: 0x0026150C File Offset: 0x0025F70C
		public virtual void CalculateIntensity(float DeltaTime)
		{
			AKuroFlickerLightActor.__CalculateIntensity_Internal(base.NativePtr, DeltaTime);
		}

		// Token: 0x06019C78 RID: 105592 RVA: 0x0026151A File Offset: 0x0025F71A
		protected virtual void CalculateIntensity_Implementation(float DeltaTime)
		{
			AKuroFlickerLightActor.__CalculateIntensity_Implementation_Internal(base.NativePtr, DeltaTime);
		}

		// Token: 0x06019C79 RID: 105593
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateLight_Internal(IntPtr @this);

		// Token: 0x06019C7A RID: 105594
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ForeachPointLight_Internal(IntPtr @this, IntPtr PointLightComponent);

		// Token: 0x06019C7B RID: 105595
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ForeachPointLight_Implementation_Internal(IntPtr @this, IntPtr PointLightComponent);

		// Token: 0x06019C7C RID: 105596
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CalculateIntensity_Internal(IntPtr @this, float DeltaTime);

		// Token: 0x06019C7D RID: 105597
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CalculateIntensity_Implementation_Internal(IntPtr @this, float DeltaTime);

		// Token: 0x06019C7E RID: 105598 RVA: 0x00261528 File Offset: 0x0025F728
		static AKuroFlickerLightActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroFlickerLightActor");
		}

		// Token: 0x06019C7F RID: 105599 RVA: 0x00261536 File Offset: 0x0025F736
		protected AKuroFlickerLightActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E045 RID: 57413
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroFlickerLightActor";

		// Token: 0x0400E046 RID: 57414
		private static IntPtr _ClassPtr;

		// Token: 0x0400E047 RID: 57415
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E048 RID: 57416
		internal static int __PropertyOffset_Preset;

		// Token: 0x0400E049 RID: 57417
		internal static int __PropertyOffset_BaseIntensityScale;

		// Token: 0x0400E04A RID: 57418
		internal static int __PropertyOffset_IntensityCurveScale;

		// Token: 0x0400E04B RID: 57419
		internal static int __PropertyOffset_FlickSpeedScale;

		// Token: 0x0400E04C RID: 57420
		internal static int __PropertyOffset_bApplyToonLight;

		// Token: 0x0400E04D RID: 57421
		internal static int __PropertyOffset_ToonLightBaseIntensityScale;

		// Token: 0x0400E04E RID: 57422
		internal static int __PropertyOffset_ToonLightIntensityCurveScale;

		// Token: 0x0400E04F RID: 57423
		internal static int __PropertyOffset_bApplyToonHardLight;

		// Token: 0x0400E050 RID: 57424
		internal static int __PropertyOffset_ToonHardLightBaseIntensityScale;

		// Token: 0x0400E051 RID: 57425
		internal static int __PropertyOffset_ToonHardLightIntensityCurveScale;

		// Token: 0x0400E052 RID: 57426
		internal static int __PropertyOffset_AllIntensityScale;

		// Token: 0x0400E053 RID: 57427
		internal static int __PropertyOffset_CurrentBaseIntensity;

		// Token: 0x0400E054 RID: 57428
		internal static int __PropertyOffset_CurrentIntensityCurve;

		// Token: 0x0400E055 RID: 57429
		internal static int __PropertyOffset_RootLight;

		// Token: 0x02003140 RID: 12608
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ForeachPointLight_FunctionParams
		{
			// Token: 0x04016F50 RID: 94032
			[FieldOffset(0)]
			public IntPtr PointLightComponent;
		}

		// Token: 0x02003141 RID: 12609
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __CalculateIntensity_FunctionParams
		{
			// Token: 0x04016F51 RID: 94033
			[FieldOffset(0)]
			public float DeltaTime;
		}
	}
}
