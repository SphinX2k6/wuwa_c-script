using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FEF RID: 4079
	[UnrealObjectPath("/Script/Engine.PlanarReflectionComponent")]
	[UnrealStructLayout(1104, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1104)]
	public class UPlanarReflectionComponent : USceneCaptureComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600DCEF RID: 56559 RVA: 0x001455B2 File Offset: 0x001437B2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPlanarReflectionComponent._ClassPtr;
		}

		// Token: 0x0600DCF0 RID: 56560 RVA: 0x001455C0 File Offset: 0x001437C0
		public UPlanarReflectionComponent() : this(BuiltinUtils.AllocNativeUObject(UPlanarReflectionComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600DCF1 RID: 56561 RVA: 0x001455E8 File Offset: 0x001437E8
		[NullableContext(1)]
		public UPlanarReflectionComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPlanarReflectionComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003419 RID: 13337
		// (get) Token: 0x0600DCF2 RID: 56562 RVA: 0x0014561B File Offset: 0x0014381B
		// (set) Token: 0x0600DCF3 RID: 56563 RVA: 0x0014562F File Offset: 0x0014382F
		[Nullable(2)]
		public unsafe UBoxComponent PreviewBox
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UPlanarReflectionComponent.__PropertyOffset_PreviewBox);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UPlanarReflectionComponent.__PropertyOffset_PreviewBox, value);
			}
		}

		// Token: 0x1700341A RID: 13338
		// (get) Token: 0x0600DCF4 RID: 56564 RVA: 0x00145644 File Offset: 0x00143844
		// (set) Token: 0x0600DCF5 RID: 56565 RVA: 0x00145654 File Offset: 0x00143854
		public unsafe float NormalDistortionStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_NormalDistortionStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_NormalDistortionStrength) = value;
			}
		}

		// Token: 0x1700341B RID: 13339
		// (get) Token: 0x0600DCF6 RID: 56566 RVA: 0x00145665 File Offset: 0x00143865
		// (set) Token: 0x0600DCF7 RID: 56567 RVA: 0x00145675 File Offset: 0x00143875
		public unsafe float PrefilterRoughness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_PrefilterRoughness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_PrefilterRoughness) = value;
			}
		}

		// Token: 0x1700341C RID: 13340
		// (get) Token: 0x0600DCF8 RID: 56568 RVA: 0x00145686 File Offset: 0x00143886
		// (set) Token: 0x0600DCF9 RID: 56569 RVA: 0x00145696 File Offset: 0x00143896
		public unsafe float PrefilterRoughnessDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_PrefilterRoughnessDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_PrefilterRoughnessDistance) = value;
			}
		}

		// Token: 0x1700341D RID: 13341
		// (get) Token: 0x0600DCFA RID: 56570 RVA: 0x001456A7 File Offset: 0x001438A7
		// (set) Token: 0x0600DCFB RID: 56571 RVA: 0x001456B7 File Offset: 0x001438B7
		public unsafe int ScreenPercentage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_ScreenPercentage);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_ScreenPercentage) = value;
			}
		}

		// Token: 0x1700341E RID: 13342
		// (get) Token: 0x0600DCFC RID: 56572 RVA: 0x001456C8 File Offset: 0x001438C8
		// (set) Token: 0x0600DCFD RID: 56573 RVA: 0x001456D8 File Offset: 0x001438D8
		public unsafe float ExtraFOV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_ExtraFOV);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_ExtraFOV) = value;
			}
		}

		// Token: 0x1700341F RID: 13343
		// (get) Token: 0x0600DCFE RID: 56574 RVA: 0x001456E9 File Offset: 0x001438E9
		// (set) Token: 0x0600DCFF RID: 56575 RVA: 0x001456F9 File Offset: 0x001438F9
		public unsafe float DistanceFromPlaneFadeStart_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_DistanceFromPlaneFadeStart_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_DistanceFromPlaneFadeStart_DEPRECATED) = value;
			}
		}

		// Token: 0x17003420 RID: 13344
		// (get) Token: 0x0600DD00 RID: 56576 RVA: 0x0014570A File Offset: 0x0014390A
		// (set) Token: 0x0600DD01 RID: 56577 RVA: 0x0014571A File Offset: 0x0014391A
		public unsafe float DistanceFromPlaneFadeEnd_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_DistanceFromPlaneFadeEnd_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_DistanceFromPlaneFadeEnd_DEPRECATED) = value;
			}
		}

		// Token: 0x17003421 RID: 13345
		// (get) Token: 0x0600DD02 RID: 56578 RVA: 0x0014572B File Offset: 0x0014392B
		// (set) Token: 0x0600DD03 RID: 56579 RVA: 0x0014573B File Offset: 0x0014393B
		public unsafe float DistanceFromPlaneFadeoutStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_DistanceFromPlaneFadeoutStart);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_DistanceFromPlaneFadeoutStart) = value;
			}
		}

		// Token: 0x17003422 RID: 13346
		// (get) Token: 0x0600DD04 RID: 56580 RVA: 0x0014574C File Offset: 0x0014394C
		// (set) Token: 0x0600DD05 RID: 56581 RVA: 0x0014575C File Offset: 0x0014395C
		public unsafe float DistanceFromPlaneFadeoutEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_DistanceFromPlaneFadeoutEnd);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_DistanceFromPlaneFadeoutEnd) = value;
			}
		}

		// Token: 0x17003423 RID: 13347
		// (get) Token: 0x0600DD06 RID: 56582 RVA: 0x0014576D File Offset: 0x0014396D
		// (set) Token: 0x0600DD07 RID: 56583 RVA: 0x0014577D File Offset: 0x0014397D
		public unsafe float AngleFromPlaneFadeStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_AngleFromPlaneFadeStart);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_AngleFromPlaneFadeStart) = value;
			}
		}

		// Token: 0x17003424 RID: 13348
		// (get) Token: 0x0600DD08 RID: 56584 RVA: 0x0014578E File Offset: 0x0014398E
		// (set) Token: 0x0600DD09 RID: 56585 RVA: 0x0014579E File Offset: 0x0014399E
		public unsafe float AngleFromPlaneFadeEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_AngleFromPlaneFadeEnd);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_AngleFromPlaneFadeEnd) = value;
			}
		}

		// Token: 0x17003425 RID: 13349
		// (get) Token: 0x0600DD0A RID: 56586 RVA: 0x001457AF File Offset: 0x001439AF
		// (set) Token: 0x0600DD0B RID: 56587 RVA: 0x001457BF File Offset: 0x001439BF
		public unsafe bool bShowPreviewPlane
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_bShowPreviewPlane) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_bShowPreviewPlane) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003426 RID: 13350
		// (get) Token: 0x0600DD0C RID: 56588 RVA: 0x001457D0 File Offset: 0x001439D0
		// (set) Token: 0x0600DD0D RID: 56589 RVA: 0x001457E0 File Offset: 0x001439E0
		public unsafe bool bCustomComposite
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_bCustomComposite) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_bCustomComposite) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003427 RID: 13351
		// (get) Token: 0x0600DD0E RID: 56590 RVA: 0x001457F1 File Offset: 0x001439F1
		// (set) Token: 0x0600DD0F RID: 56591 RVA: 0x00145801 File Offset: 0x00143A01
		public unsafe int Priority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_Priority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_Priority) = value;
			}
		}

		// Token: 0x17003428 RID: 13352
		// (get) Token: 0x0600DD10 RID: 56592 RVA: 0x00145812 File Offset: 0x00143A12
		// (set) Token: 0x0600DD11 RID: 56593 RVA: 0x00145822 File Offset: 0x00143A22
		public unsafe bool bEnableGaussianPrefilter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_bEnableGaussianPrefilter) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_bEnableGaussianPrefilter) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003429 RID: 13353
		// (get) Token: 0x0600DD12 RID: 56594 RVA: 0x00145833 File Offset: 0x00143A33
		// (set) Token: 0x0600DD13 RID: 56595 RVA: 0x00145843 File Offset: 0x00143A43
		public unsafe bool bRenderSceneTwoSided
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_bRenderSceneTwoSided) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_bRenderSceneTwoSided) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700342A RID: 13354
		// (get) Token: 0x0600DD14 RID: 56596 RVA: 0x00145854 File Offset: 0x00143A54
		// (set) Token: 0x0600DD15 RID: 56597 RVA: 0x00145864 File Offset: 0x00143A64
		public unsafe bool bApplyPrimitivePlanarReflectionRenderOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_bApplyPrimitivePlanarReflectionRenderOffset) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_bApplyPrimitivePlanarReflectionRenderOffset) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700342B RID: 13355
		// (get) Token: 0x0600DD16 RID: 56598 RVA: 0x00145875 File Offset: 0x00143A75
		// (set) Token: 0x0600DD17 RID: 56599 RVA: 0x00145885 File Offset: 0x00143A85
		public unsafe bool bRenderParticlesInPlanarReflection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_bRenderParticlesInPlanarReflection) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlanarReflectionComponent.__PropertyOffset_bRenderParticlesInPlanarReflection) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600DD18 RID: 56600 RVA: 0x00145896 File Offset: 0x00143A96
		static UPlanarReflectionComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PlanarReflectionComponent");
		}

		// Token: 0x0600DD19 RID: 56601 RVA: 0x001458A4 File Offset: 0x00143AA4
		protected UPlanarReflectionComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400776C RID: 30572
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.PlanarReflectionComponent";

		// Token: 0x0400776D RID: 30573
		private static IntPtr _ClassPtr;

		// Token: 0x0400776E RID: 30574
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400776F RID: 30575
		internal static int __PropertyOffset_PreviewBox;

		// Token: 0x04007770 RID: 30576
		internal static int __PropertyOffset_NormalDistortionStrength;

		// Token: 0x04007771 RID: 30577
		internal static int __PropertyOffset_PrefilterRoughness;

		// Token: 0x04007772 RID: 30578
		internal static int __PropertyOffset_PrefilterRoughnessDistance;

		// Token: 0x04007773 RID: 30579
		internal static int __PropertyOffset_ScreenPercentage;

		// Token: 0x04007774 RID: 30580
		internal static int __PropertyOffset_ExtraFOV;

		// Token: 0x04007775 RID: 30581
		internal static int __PropertyOffset_DistanceFromPlaneFadeStart_DEPRECATED;

		// Token: 0x04007776 RID: 30582
		internal static int __PropertyOffset_DistanceFromPlaneFadeEnd_DEPRECATED;

		// Token: 0x04007777 RID: 30583
		internal static int __PropertyOffset_DistanceFromPlaneFadeoutStart;

		// Token: 0x04007778 RID: 30584
		internal static int __PropertyOffset_DistanceFromPlaneFadeoutEnd;

		// Token: 0x04007779 RID: 30585
		internal static int __PropertyOffset_AngleFromPlaneFadeStart;

		// Token: 0x0400777A RID: 30586
		internal static int __PropertyOffset_AngleFromPlaneFadeEnd;

		// Token: 0x0400777B RID: 30587
		internal static int __PropertyOffset_bShowPreviewPlane;

		// Token: 0x0400777C RID: 30588
		internal static int __PropertyOffset_bCustomComposite;

		// Token: 0x0400777D RID: 30589
		internal static int __PropertyOffset_Priority;

		// Token: 0x0400777E RID: 30590
		internal static int __PropertyOffset_bEnableGaussianPrefilter;

		// Token: 0x0400777F RID: 30591
		internal static int __PropertyOffset_bRenderSceneTwoSided;

		// Token: 0x04007780 RID: 30592
		internal static int __PropertyOffset_bApplyPrimitivePlanarReflectionRenderOffset;

		// Token: 0x04007781 RID: 30593
		internal static int __PropertyOffset_bRenderParticlesInPlanarReflection;
	}
}
