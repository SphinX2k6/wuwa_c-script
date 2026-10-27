using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001AF5 RID: 6901
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroFlickerLightBase")]
	[UnrealStructLayout(1520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1520)]
	public abstract class AKuroFlickerLightBase : AKuroGameBudgetBlueprintActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06019C80 RID: 105600 RVA: 0x0026153F File Offset: 0x0025F73F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroFlickerLightBase._ClassPtr;
		}

		// Token: 0x17006721 RID: 26401
		// (get) Token: 0x06019C81 RID: 105601 RVA: 0x0026154B File Offset: 0x0025F74B
		// (set) Token: 0x06019C82 RID: 105602 RVA: 0x0026155F File Offset: 0x0025F75F
		[Nullable(2)]
		public unsafe UKuroFlickerLightPreset Preset
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroFlickerLightPreset>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroFlickerLightBase.__PropertyOffset_Preset);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroFlickerLightBase.__PropertyOffset_Preset, value);
			}
		}

		// Token: 0x17006722 RID: 26402
		// (get) Token: 0x06019C83 RID: 105603 RVA: 0x00261574 File Offset: 0x0025F774
		// (set) Token: 0x06019C84 RID: 105604 RVA: 0x00261584 File Offset: 0x0025F784
		public unsafe float BaseIntensityScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFlickerLightBase.__PropertyOffset_BaseIntensityScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFlickerLightBase.__PropertyOffset_BaseIntensityScale) = value;
			}
		}

		// Token: 0x17006723 RID: 26403
		// (get) Token: 0x06019C85 RID: 105605 RVA: 0x00261595 File Offset: 0x0025F795
		// (set) Token: 0x06019C86 RID: 105606 RVA: 0x002615A5 File Offset: 0x0025F7A5
		public unsafe float IntensityCurveScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFlickerLightBase.__PropertyOffset_IntensityCurveScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFlickerLightBase.__PropertyOffset_IntensityCurveScale) = value;
			}
		}

		// Token: 0x17006724 RID: 26404
		// (get) Token: 0x06019C87 RID: 105607 RVA: 0x002615B6 File Offset: 0x0025F7B6
		// (set) Token: 0x06019C88 RID: 105608 RVA: 0x002615C6 File Offset: 0x0025F7C6
		public unsafe float FlickSpeedScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFlickerLightBase.__PropertyOffset_FlickSpeedScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFlickerLightBase.__PropertyOffset_FlickSpeedScale) = value;
			}
		}

		// Token: 0x17006725 RID: 26405
		// (get) Token: 0x06019C89 RID: 105609 RVA: 0x002615D7 File Offset: 0x0025F7D7
		// (set) Token: 0x06019C8A RID: 105610 RVA: 0x002615E7 File Offset: 0x0025F7E7
		public unsafe bool bApplyToonLight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFlickerLightBase.__PropertyOffset_bApplyToonLight) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFlickerLightBase.__PropertyOffset_bApplyToonLight) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006726 RID: 26406
		// (get) Token: 0x06019C8B RID: 105611 RVA: 0x002615F8 File Offset: 0x0025F7F8
		// (set) Token: 0x06019C8C RID: 105612 RVA: 0x00261608 File Offset: 0x0025F808
		public unsafe float ToonLightBaseIntensityScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFlickerLightBase.__PropertyOffset_ToonLightBaseIntensityScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFlickerLightBase.__PropertyOffset_ToonLightBaseIntensityScale) = value;
			}
		}

		// Token: 0x17006727 RID: 26407
		// (get) Token: 0x06019C8D RID: 105613 RVA: 0x00261619 File Offset: 0x0025F819
		// (set) Token: 0x06019C8E RID: 105614 RVA: 0x00261629 File Offset: 0x0025F829
		public unsafe float ToonLightIntensityCurveScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFlickerLightBase.__PropertyOffset_ToonLightIntensityCurveScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFlickerLightBase.__PropertyOffset_ToonLightIntensityCurveScale) = value;
			}
		}

		// Token: 0x17006728 RID: 26408
		// (get) Token: 0x06019C8F RID: 105615 RVA: 0x0026163A File Offset: 0x0025F83A
		// (set) Token: 0x06019C90 RID: 105616 RVA: 0x0026164A File Offset: 0x0025F84A
		public unsafe bool bApplyToonHardLight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFlickerLightBase.__PropertyOffset_bApplyToonHardLight) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFlickerLightBase.__PropertyOffset_bApplyToonHardLight) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006729 RID: 26409
		// (get) Token: 0x06019C91 RID: 105617 RVA: 0x0026165B File Offset: 0x0025F85B
		// (set) Token: 0x06019C92 RID: 105618 RVA: 0x0026166B File Offset: 0x0025F86B
		public unsafe float ToonHardLightBaseIntensityScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFlickerLightBase.__PropertyOffset_ToonHardLightBaseIntensityScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFlickerLightBase.__PropertyOffset_ToonHardLightBaseIntensityScale) = value;
			}
		}

		// Token: 0x1700672A RID: 26410
		// (get) Token: 0x06019C93 RID: 105619 RVA: 0x0026167C File Offset: 0x0025F87C
		// (set) Token: 0x06019C94 RID: 105620 RVA: 0x0026168C File Offset: 0x0025F88C
		public unsafe float ToonHardLightIntensityCurveScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFlickerLightBase.__PropertyOffset_ToonHardLightIntensityCurveScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFlickerLightBase.__PropertyOffset_ToonHardLightIntensityCurveScale) = value;
			}
		}

		// Token: 0x1700672B RID: 26411
		// (get) Token: 0x06019C95 RID: 105621 RVA: 0x0026169D File Offset: 0x0025F89D
		// (set) Token: 0x06019C96 RID: 105622 RVA: 0x002616AD File Offset: 0x0025F8AD
		public unsafe float AllIntensityScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFlickerLightBase.__PropertyOffset_AllIntensityScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFlickerLightBase.__PropertyOffset_AllIntensityScale) = value;
			}
		}

		// Token: 0x1700672C RID: 26412
		// (get) Token: 0x06019C97 RID: 105623 RVA: 0x002616BE File Offset: 0x0025F8BE
		// (set) Token: 0x06019C98 RID: 105624 RVA: 0x002616CE File Offset: 0x0025F8CE
		public unsafe bool bEnableMaterialSyncMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFlickerLightBase.__PropertyOffset_bEnableMaterialSyncMode) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFlickerLightBase.__PropertyOffset_bEnableMaterialSyncMode) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700672D RID: 26413
		// (get) Token: 0x06019C99 RID: 105625 RVA: 0x002616DF File Offset: 0x0025F8DF
		// (set) Token: 0x06019C9A RID: 105626 RVA: 0x002616EF File Offset: 0x0025F8EF
		public unsafe float BrightLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFlickerLightBase.__PropertyOffset_BrightLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFlickerLightBase.__PropertyOffset_BrightLength) = value;
			}
		}

		// Token: 0x1700672E RID: 26414
		// (get) Token: 0x06019C9B RID: 105627 RVA: 0x00261700 File Offset: 0x0025F900
		// (set) Token: 0x06019C9C RID: 105628 RVA: 0x00261710 File Offset: 0x0025F910
		public unsafe float FlickerTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFlickerLightBase.__PropertyOffset_FlickerTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFlickerLightBase.__PropertyOffset_FlickerTime) = value;
			}
		}

		// Token: 0x1700672F RID: 26415
		// (get) Token: 0x06019C9D RID: 105629 RVA: 0x00261721 File Offset: 0x0025F921
		// (set) Token: 0x06019C9E RID: 105630 RVA: 0x00261731 File Offset: 0x0025F931
		public unsafe float MinimumBright
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFlickerLightBase.__PropertyOffset_MinimumBright);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFlickerLightBase.__PropertyOffset_MinimumBright) = value;
			}
		}

		// Token: 0x17006730 RID: 26416
		// (get) Token: 0x06019C9F RID: 105631 RVA: 0x00261742 File Offset: 0x0025F942
		// (set) Token: 0x06019CA0 RID: 105632 RVA: 0x00261752 File Offset: 0x0025F952
		public unsafe float ViewTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFlickerLightBase.__PropertyOffset_ViewTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFlickerLightBase.__PropertyOffset_ViewTime) = value;
			}
		}

		// Token: 0x17006731 RID: 26417
		// (get) Token: 0x06019CA1 RID: 105633 RVA: 0x00261763 File Offset: 0x0025F963
		// (set) Token: 0x06019CA2 RID: 105634 RVA: 0x00261773 File Offset: 0x0025F973
		public unsafe float IntensityScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFlickerLightBase.__PropertyOffset_IntensityScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFlickerLightBase.__PropertyOffset_IntensityScale) = value;
			}
		}

		// Token: 0x17006732 RID: 26418
		// (get) Token: 0x06019CA3 RID: 105635 RVA: 0x00261784 File Offset: 0x0025F984
		// (set) Token: 0x06019CA4 RID: 105636 RVA: 0x00261794 File Offset: 0x0025F994
		public unsafe float CurrentBaseIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFlickerLightBase.__PropertyOffset_CurrentBaseIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFlickerLightBase.__PropertyOffset_CurrentBaseIntensity) = value;
			}
		}

		// Token: 0x17006733 RID: 26419
		// (get) Token: 0x06019CA5 RID: 105637 RVA: 0x002617A5 File Offset: 0x0025F9A5
		// (set) Token: 0x06019CA6 RID: 105638 RVA: 0x002617B5 File Offset: 0x0025F9B5
		public unsafe float CurrentIntensityCurve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFlickerLightBase.__PropertyOffset_CurrentIntensityCurve);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFlickerLightBase.__PropertyOffset_CurrentIntensityCurve) = value;
			}
		}

		// Token: 0x06019CA7 RID: 105639 RVA: 0x002617C6 File Offset: 0x0025F9C6
		public void UpdateLight()
		{
			AKuroFlickerLightBase.__UpdateLight_Internal(base.NativePtr);
		}

		// Token: 0x06019CA8 RID: 105640
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateLight_Internal(IntPtr @this);

		// Token: 0x06019CA9 RID: 105641 RVA: 0x002617D3 File Offset: 0x0025F9D3
		static AKuroFlickerLightBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroFlickerLightBase");
		}

		// Token: 0x06019CAA RID: 105642 RVA: 0x002617E4 File Offset: 0x0025F9E4
		protected AKuroFlickerLightBase() : this(BuiltinUtils.AllocNativeUObject(AKuroFlickerLightBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06019CAB RID: 105643 RVA: 0x0026180C File Offset: 0x0025FA0C
		protected AKuroFlickerLightBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E056 RID: 57430
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroFlickerLightBase";

		// Token: 0x0400E057 RID: 57431
		private static IntPtr _ClassPtr;

		// Token: 0x0400E058 RID: 57432
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E059 RID: 57433
		internal static int __PropertyOffset_Preset;

		// Token: 0x0400E05A RID: 57434
		internal static int __PropertyOffset_BaseIntensityScale;

		// Token: 0x0400E05B RID: 57435
		internal static int __PropertyOffset_IntensityCurveScale;

		// Token: 0x0400E05C RID: 57436
		internal static int __PropertyOffset_FlickSpeedScale;

		// Token: 0x0400E05D RID: 57437
		internal static int __PropertyOffset_bApplyToonLight;

		// Token: 0x0400E05E RID: 57438
		internal static int __PropertyOffset_ToonLightBaseIntensityScale;

		// Token: 0x0400E05F RID: 57439
		internal static int __PropertyOffset_ToonLightIntensityCurveScale;

		// Token: 0x0400E060 RID: 57440
		internal static int __PropertyOffset_bApplyToonHardLight;

		// Token: 0x0400E061 RID: 57441
		internal static int __PropertyOffset_ToonHardLightBaseIntensityScale;

		// Token: 0x0400E062 RID: 57442
		internal static int __PropertyOffset_ToonHardLightIntensityCurveScale;

		// Token: 0x0400E063 RID: 57443
		internal static int __PropertyOffset_AllIntensityScale;

		// Token: 0x0400E064 RID: 57444
		internal static int __PropertyOffset_bEnableMaterialSyncMode;

		// Token: 0x0400E065 RID: 57445
		internal static int __PropertyOffset_BrightLength;

		// Token: 0x0400E066 RID: 57446
		internal static int __PropertyOffset_FlickerTime;

		// Token: 0x0400E067 RID: 57447
		internal static int __PropertyOffset_MinimumBright;

		// Token: 0x0400E068 RID: 57448
		internal static int __PropertyOffset_ViewTime;

		// Token: 0x0400E069 RID: 57449
		internal static int __PropertyOffset_IntensityScale;

		// Token: 0x0400E06A RID: 57450
		internal static int __PropertyOffset_CurrentBaseIntensity;

		// Token: 0x0400E06B RID: 57451
		internal static int __PropertyOffset_CurrentIntensityCurve;
	}
}
