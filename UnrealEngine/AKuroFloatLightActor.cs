using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001AFD RID: 6909
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroFloatLightActor")]
	[UnrealStructLayout(1528, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1528)]
	public class AKuroFloatLightActor : AKuroGameBudgetBlueprintActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06019D2A RID: 105770 RVA: 0x002622AB File Offset: 0x002604AB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroFloatLightActor._ClassPtr;
		}

		// Token: 0x06019D2B RID: 105771 RVA: 0x002622B8 File Offset: 0x002604B8
		public AKuroFloatLightActor() : this(BuiltinUtils.AllocNativeUObject(AKuroFloatLightActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06019D2C RID: 105772 RVA: 0x002622E0 File Offset: 0x002604E0
		[NullableContext(1)]
		public AKuroFloatLightActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroFloatLightActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006759 RID: 26457
		// (get) Token: 0x06019D2D RID: 105773 RVA: 0x00262313 File Offset: 0x00260513
		// (set) Token: 0x06019D2E RID: 105774 RVA: 0x00262327 File Offset: 0x00260527
		public unsafe UKuroFloatLightPreset Preset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroFloatLightPreset>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroFloatLightActor.__PropertyOffset_Preset);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroFloatLightActor.__PropertyOffset_Preset, value);
			}
		}

		// Token: 0x1700675A RID: 26458
		// (get) Token: 0x06019D2F RID: 105775 RVA: 0x0026233C File Offset: 0x0026053C
		// (set) Token: 0x06019D30 RID: 105776 RVA: 0x0026234C File Offset: 0x0026054C
		public unsafe float BaseIntensityScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFloatLightActor.__PropertyOffset_BaseIntensityScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFloatLightActor.__PropertyOffset_BaseIntensityScale) = value;
			}
		}

		// Token: 0x1700675B RID: 26459
		// (get) Token: 0x06019D31 RID: 105777 RVA: 0x0026235D File Offset: 0x0026055D
		// (set) Token: 0x06019D32 RID: 105778 RVA: 0x0026236D File Offset: 0x0026056D
		public unsafe float IntensityCurveScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFloatLightActor.__PropertyOffset_IntensityCurveScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFloatLightActor.__PropertyOffset_IntensityCurveScale) = value;
			}
		}

		// Token: 0x1700675C RID: 26460
		// (get) Token: 0x06019D33 RID: 105779 RVA: 0x0026237E File Offset: 0x0026057E
		// (set) Token: 0x06019D34 RID: 105780 RVA: 0x0026238E File Offset: 0x0026058E
		public unsafe float FlickSpeedScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFloatLightActor.__PropertyOffset_FlickSpeedScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFloatLightActor.__PropertyOffset_FlickSpeedScale) = value;
			}
		}

		// Token: 0x1700675D RID: 26461
		// (get) Token: 0x06019D35 RID: 105781 RVA: 0x0026239F File Offset: 0x0026059F
		// (set) Token: 0x06019D36 RID: 105782 RVA: 0x002623AF File Offset: 0x002605AF
		public unsafe bool bApplyToonLight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFloatLightActor.__PropertyOffset_bApplyToonLight) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFloatLightActor.__PropertyOffset_bApplyToonLight) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700675E RID: 26462
		// (get) Token: 0x06019D37 RID: 105783 RVA: 0x002623C0 File Offset: 0x002605C0
		// (set) Token: 0x06019D38 RID: 105784 RVA: 0x002623D0 File Offset: 0x002605D0
		public unsafe float ToonLightBaseIntensityScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFloatLightActor.__PropertyOffset_ToonLightBaseIntensityScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFloatLightActor.__PropertyOffset_ToonLightBaseIntensityScale) = value;
			}
		}

		// Token: 0x1700675F RID: 26463
		// (get) Token: 0x06019D39 RID: 105785 RVA: 0x002623E1 File Offset: 0x002605E1
		// (set) Token: 0x06019D3A RID: 105786 RVA: 0x002623F1 File Offset: 0x002605F1
		public unsafe float ToonLightIntensityCurveScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFloatLightActor.__PropertyOffset_ToonLightIntensityCurveScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFloatLightActor.__PropertyOffset_ToonLightIntensityCurveScale) = value;
			}
		}

		// Token: 0x17006760 RID: 26464
		// (get) Token: 0x06019D3B RID: 105787 RVA: 0x00262402 File Offset: 0x00260602
		// (set) Token: 0x06019D3C RID: 105788 RVA: 0x00262412 File Offset: 0x00260612
		public unsafe bool bApplyToonHardLight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFloatLightActor.__PropertyOffset_bApplyToonHardLight) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFloatLightActor.__PropertyOffset_bApplyToonHardLight) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006761 RID: 26465
		// (get) Token: 0x06019D3D RID: 105789 RVA: 0x00262423 File Offset: 0x00260623
		// (set) Token: 0x06019D3E RID: 105790 RVA: 0x00262433 File Offset: 0x00260633
		public unsafe float ToonHardLightBaseIntensityScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFloatLightActor.__PropertyOffset_ToonHardLightBaseIntensityScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFloatLightActor.__PropertyOffset_ToonHardLightBaseIntensityScale) = value;
			}
		}

		// Token: 0x17006762 RID: 26466
		// (get) Token: 0x06019D3F RID: 105791 RVA: 0x00262444 File Offset: 0x00260644
		// (set) Token: 0x06019D40 RID: 105792 RVA: 0x00262454 File Offset: 0x00260654
		public unsafe float ToonHardLightIntensityCurveScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFloatLightActor.__PropertyOffset_ToonHardLightIntensityCurveScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFloatLightActor.__PropertyOffset_ToonHardLightIntensityCurveScale) = value;
			}
		}

		// Token: 0x17006763 RID: 26467
		// (get) Token: 0x06019D41 RID: 105793 RVA: 0x00262465 File Offset: 0x00260665
		// (set) Token: 0x06019D42 RID: 105794 RVA: 0x00262475 File Offset: 0x00260675
		public unsafe float MovementSpeedScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFloatLightActor.__PropertyOffset_MovementSpeedScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFloatLightActor.__PropertyOffset_MovementSpeedScale) = value;
			}
		}

		// Token: 0x17006764 RID: 26468
		// (get) Token: 0x06019D43 RID: 105795 RVA: 0x00262486 File Offset: 0x00260686
		// (set) Token: 0x06019D44 RID: 105796 RVA: 0x00262496 File Offset: 0x00260696
		public unsafe float MovementPhase
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFloatLightActor.__PropertyOffset_MovementPhase);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFloatLightActor.__PropertyOffset_MovementPhase) = value;
			}
		}

		// Token: 0x17006765 RID: 26469
		// (get) Token: 0x06019D45 RID: 105797 RVA: 0x002624A7 File Offset: 0x002606A7
		// (set) Token: 0x06019D46 RID: 105798 RVA: 0x002624B7 File Offset: 0x002606B7
		public unsafe float MovementScalar1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFloatLightActor.__PropertyOffset_MovementScalar1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFloatLightActor.__PropertyOffset_MovementScalar1) = value;
			}
		}

		// Token: 0x17006766 RID: 26470
		// (get) Token: 0x06019D47 RID: 105799 RVA: 0x002624C8 File Offset: 0x002606C8
		// (set) Token: 0x06019D48 RID: 105800 RVA: 0x002624D8 File Offset: 0x002606D8
		public unsafe float MovementScalar2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFloatLightActor.__PropertyOffset_MovementScalar2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFloatLightActor.__PropertyOffset_MovementScalar2) = value;
			}
		}

		// Token: 0x17006767 RID: 26471
		// (get) Token: 0x06019D49 RID: 105801 RVA: 0x002624E9 File Offset: 0x002606E9
		// (set) Token: 0x06019D4A RID: 105802 RVA: 0x002624FD File Offset: 0x002606FD
		public unsafe USceneComponent SceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroFloatLightActor.__PropertyOffset_SceneRoot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroFloatLightActor.__PropertyOffset_SceneRoot, value);
			}
		}

		// Token: 0x17006768 RID: 26472
		// (get) Token: 0x06019D4B RID: 105803 RVA: 0x00262512 File Offset: 0x00260712
		// (set) Token: 0x06019D4C RID: 105804 RVA: 0x00262526 File Offset: 0x00260726
		public unsafe UPointLightComponent PointLightComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPointLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroFloatLightActor.__PropertyOffset_PointLightComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroFloatLightActor.__PropertyOffset_PointLightComponent, value);
			}
		}

		// Token: 0x17006769 RID: 26473
		// (get) Token: 0x06019D4D RID: 105805 RVA: 0x0026253B File Offset: 0x0026073B
		// (set) Token: 0x06019D4E RID: 105806 RVA: 0x0026254B File Offset: 0x0026074B
		public unsafe float CurrentBaseIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFloatLightActor.__PropertyOffset_CurrentBaseIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFloatLightActor.__PropertyOffset_CurrentBaseIntensity) = value;
			}
		}

		// Token: 0x1700676A RID: 26474
		// (get) Token: 0x06019D4F RID: 105807 RVA: 0x0026255C File Offset: 0x0026075C
		// (set) Token: 0x06019D50 RID: 105808 RVA: 0x0026256C File Offset: 0x0026076C
		public unsafe float CurrentIntensityCurve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFloatLightActor.__PropertyOffset_CurrentIntensityCurve);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFloatLightActor.__PropertyOffset_CurrentIntensityCurve) = value;
			}
		}

		// Token: 0x06019D51 RID: 105809 RVA: 0x0026257D File Offset: 0x0026077D
		static AKuroFloatLightActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroFloatLightActor");
		}

		// Token: 0x06019D52 RID: 105810 RVA: 0x0026258B File Offset: 0x0026078B
		protected AKuroFloatLightActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E0AC RID: 57516
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroFloatLightActor";

		// Token: 0x0400E0AD RID: 57517
		private static IntPtr _ClassPtr;

		// Token: 0x0400E0AE RID: 57518
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E0AF RID: 57519
		internal static int __PropertyOffset_Preset;

		// Token: 0x0400E0B0 RID: 57520
		internal static int __PropertyOffset_BaseIntensityScale;

		// Token: 0x0400E0B1 RID: 57521
		internal static int __PropertyOffset_IntensityCurveScale;

		// Token: 0x0400E0B2 RID: 57522
		internal static int __PropertyOffset_FlickSpeedScale;

		// Token: 0x0400E0B3 RID: 57523
		internal static int __PropertyOffset_bApplyToonLight;

		// Token: 0x0400E0B4 RID: 57524
		internal static int __PropertyOffset_ToonLightBaseIntensityScale;

		// Token: 0x0400E0B5 RID: 57525
		internal static int __PropertyOffset_ToonLightIntensityCurveScale;

		// Token: 0x0400E0B6 RID: 57526
		internal static int __PropertyOffset_bApplyToonHardLight;

		// Token: 0x0400E0B7 RID: 57527
		internal static int __PropertyOffset_ToonHardLightBaseIntensityScale;

		// Token: 0x0400E0B8 RID: 57528
		internal static int __PropertyOffset_ToonHardLightIntensityCurveScale;

		// Token: 0x0400E0B9 RID: 57529
		internal static int __PropertyOffset_MovementSpeedScale;

		// Token: 0x0400E0BA RID: 57530
		internal static int __PropertyOffset_MovementPhase;

		// Token: 0x0400E0BB RID: 57531
		internal static int __PropertyOffset_MovementScalar1;

		// Token: 0x0400E0BC RID: 57532
		internal static int __PropertyOffset_MovementScalar2;

		// Token: 0x0400E0BD RID: 57533
		internal static int __PropertyOffset_SceneRoot;

		// Token: 0x0400E0BE RID: 57534
		internal static int __PropertyOffset_PointLightComponent;

		// Token: 0x0400E0BF RID: 57535
		internal static int __PropertyOffset_CurrentBaseIntensity;

		// Token: 0x0400E0C0 RID: 57536
		internal static int __PropertyOffset_CurrentIntensityCurve;
	}
}
