using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BEE RID: 7150
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroWorldRainGlobalOverrider")]
	[UnrealStructLayout(1144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1144)]
	public class AKuroWorldRainGlobalOverrider : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601B83B RID: 112699 RVA: 0x002883BD File Offset: 0x002865BD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroWorldRainGlobalOverrider._ClassPtr;
		}

		// Token: 0x0601B83C RID: 112700 RVA: 0x002883CC File Offset: 0x002865CC
		public AKuroWorldRainGlobalOverrider() : this(BuiltinUtils.AllocNativeUObject(AKuroWorldRainGlobalOverrider.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601B83D RID: 112701 RVA: 0x002883F4 File Offset: 0x002865F4
		[NullableContext(1)]
		public AKuroWorldRainGlobalOverrider(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroWorldRainGlobalOverrider.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006EBD RID: 28349
		// (get) Token: 0x0601B83E RID: 112702 RVA: 0x00288427 File Offset: 0x00286627
		// (set) Token: 0x0601B83F RID: 112703 RVA: 0x0028843B File Offset: 0x0028663B
		[Nullable(2)]
		public unsafe USceneComponent SceneComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroWorldRainGlobalOverrider.__PropertyOffset_SceneComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroWorldRainGlobalOverrider.__PropertyOffset_SceneComponent, value);
			}
		}

		// Token: 0x17006EBE RID: 28350
		// (get) Token: 0x0601B840 RID: 112704 RVA: 0x00288450 File Offset: 0x00286650
		// (set) Token: 0x0601B841 RID: 112705 RVA: 0x00288469 File Offset: 0x00286669
		public unsafe bool bOverrideWindSize
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AKuroWorldRainGlobalOverrider.__PropertyOffset_bOverrideWindSize) & AKuroWorldRainGlobalOverrider.__PropertyMask_bOverrideWindSize) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AKuroWorldRainGlobalOverrider.__PropertyOffset_bOverrideWindSize) = ((*(base.NativePtr + (IntPtr)AKuroWorldRainGlobalOverrider.__PropertyOffset_bOverrideWindSize) & ~AKuroWorldRainGlobalOverrider.__PropertyMask_bOverrideWindSize) | (value ? AKuroWorldRainGlobalOverrider.__PropertyMask_bOverrideWindSize : 0));
			}
		}

		// Token: 0x17006EBF RID: 28351
		// (get) Token: 0x0601B842 RID: 112706 RVA: 0x00288499 File Offset: 0x00286699
		// (set) Token: 0x0601B843 RID: 112707 RVA: 0x002884A9 File Offset: 0x002866A9
		public unsafe float WindSizeOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWorldRainGlobalOverrider.__PropertyOffset_WindSizeOverride);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWorldRainGlobalOverrider.__PropertyOffset_WindSizeOverride) = value;
			}
		}

		// Token: 0x17006EC0 RID: 28352
		// (get) Token: 0x0601B844 RID: 112708 RVA: 0x002884BA File Offset: 0x002866BA
		// (set) Token: 0x0601B845 RID: 112709 RVA: 0x002884D3 File Offset: 0x002866D3
		public unsafe bool bOverrideGravity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AKuroWorldRainGlobalOverrider.__PropertyOffset_bOverrideGravity) & AKuroWorldRainGlobalOverrider.__PropertyMask_bOverrideGravity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AKuroWorldRainGlobalOverrider.__PropertyOffset_bOverrideGravity) = ((*(base.NativePtr + (IntPtr)AKuroWorldRainGlobalOverrider.__PropertyOffset_bOverrideGravity) & ~AKuroWorldRainGlobalOverrider.__PropertyMask_bOverrideGravity) | (value ? AKuroWorldRainGlobalOverrider.__PropertyMask_bOverrideGravity : 0));
			}
		}

		// Token: 0x17006EC1 RID: 28353
		// (get) Token: 0x0601B846 RID: 112710 RVA: 0x00288503 File Offset: 0x00286703
		// (set) Token: 0x0601B847 RID: 112711 RVA: 0x00288517 File Offset: 0x00286717
		public unsafe FVector GravityOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWorldRainGlobalOverrider.__PropertyOffset_GravityOverride);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWorldRainGlobalOverrider.__PropertyOffset_GravityOverride) = value;
			}
		}

		// Token: 0x17006EC2 RID: 28354
		// (get) Token: 0x0601B848 RID: 112712 RVA: 0x0028852C File Offset: 0x0028672C
		// (set) Token: 0x0601B849 RID: 112713 RVA: 0x00288545 File Offset: 0x00286745
		public unsafe bool bOverrideDrag
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AKuroWorldRainGlobalOverrider.__PropertyOffset_bOverrideDrag) & AKuroWorldRainGlobalOverrider.__PropertyMask_bOverrideDrag) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AKuroWorldRainGlobalOverrider.__PropertyOffset_bOverrideDrag) = ((*(base.NativePtr + (IntPtr)AKuroWorldRainGlobalOverrider.__PropertyOffset_bOverrideDrag) & ~AKuroWorldRainGlobalOverrider.__PropertyMask_bOverrideDrag) | (value ? AKuroWorldRainGlobalOverrider.__PropertyMask_bOverrideDrag : 0));
			}
		}

		// Token: 0x17006EC3 RID: 28355
		// (get) Token: 0x0601B84A RID: 112714 RVA: 0x00288575 File Offset: 0x00286775
		// (set) Token: 0x0601B84B RID: 112715 RVA: 0x00288585 File Offset: 0x00286785
		public unsafe float DragOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWorldRainGlobalOverrider.__PropertyOffset_DragOverride);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWorldRainGlobalOverrider.__PropertyOffset_DragOverride) = value;
			}
		}

		// Token: 0x17006EC4 RID: 28356
		// (get) Token: 0x0601B84C RID: 112716 RVA: 0x00288596 File Offset: 0x00286796
		// (set) Token: 0x0601B84D RID: 112717 RVA: 0x002885AF File Offset: 0x002867AF
		public unsafe bool bOverrideTimeDilation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AKuroWorldRainGlobalOverrider.__PropertyOffset_bOverrideTimeDilation) & AKuroWorldRainGlobalOverrider.__PropertyMask_bOverrideTimeDilation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AKuroWorldRainGlobalOverrider.__PropertyOffset_bOverrideTimeDilation) = ((*(base.NativePtr + (IntPtr)AKuroWorldRainGlobalOverrider.__PropertyOffset_bOverrideTimeDilation) & ~AKuroWorldRainGlobalOverrider.__PropertyMask_bOverrideTimeDilation) | (value ? AKuroWorldRainGlobalOverrider.__PropertyMask_bOverrideTimeDilation : 0));
			}
		}

		// Token: 0x17006EC5 RID: 28357
		// (get) Token: 0x0601B84E RID: 112718 RVA: 0x002885DF File Offset: 0x002867DF
		// (set) Token: 0x0601B84F RID: 112719 RVA: 0x002885EF File Offset: 0x002867EF
		public unsafe float TimeDilationOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWorldRainGlobalOverrider.__PropertyOffset_TimeDilationOverride);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWorldRainGlobalOverrider.__PropertyOffset_TimeDilationOverride) = value;
			}
		}

		// Token: 0x17006EC6 RID: 28358
		// (get) Token: 0x0601B850 RID: 112720 RVA: 0x00288600 File Offset: 0x00286800
		// (set) Token: 0x0601B851 RID: 112721 RVA: 0x00288619 File Offset: 0x00286819
		public unsafe bool bRainOverrideTimeFreezeSpherize
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AKuroWorldRainGlobalOverrider.__PropertyOffset_bRainOverrideTimeFreezeSpherize) & AKuroWorldRainGlobalOverrider.__PropertyMask_bRainOverrideTimeFreezeSpherize) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AKuroWorldRainGlobalOverrider.__PropertyOffset_bRainOverrideTimeFreezeSpherize) = ((*(base.NativePtr + (IntPtr)AKuroWorldRainGlobalOverrider.__PropertyOffset_bRainOverrideTimeFreezeSpherize) & ~AKuroWorldRainGlobalOverrider.__PropertyMask_bRainOverrideTimeFreezeSpherize) | (value ? AKuroWorldRainGlobalOverrider.__PropertyMask_bRainOverrideTimeFreezeSpherize : 0));
			}
		}

		// Token: 0x17006EC7 RID: 28359
		// (get) Token: 0x0601B852 RID: 112722 RVA: 0x00288649 File Offset: 0x00286849
		// (set) Token: 0x0601B853 RID: 112723 RVA: 0x00288659 File Offset: 0x00286859
		public unsafe float RainToSphereTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWorldRainGlobalOverrider.__PropertyOffset_RainToSphereTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWorldRainGlobalOverrider.__PropertyOffset_RainToSphereTime) = value;
			}
		}

		// Token: 0x17006EC8 RID: 28360
		// (get) Token: 0x0601B854 RID: 112724 RVA: 0x0028866A File Offset: 0x0028686A
		// (set) Token: 0x0601B855 RID: 112725 RVA: 0x0028867A File Offset: 0x0028687A
		public unsafe float RainToRainTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWorldRainGlobalOverrider.__PropertyOffset_RainToRainTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWorldRainGlobalOverrider.__PropertyOffset_RainToRainTime) = value;
			}
		}

		// Token: 0x17006EC9 RID: 28361
		// (get) Token: 0x0601B856 RID: 112726 RVA: 0x0028868B File Offset: 0x0028688B
		// (set) Token: 0x0601B857 RID: 112727 RVA: 0x002886A4 File Offset: 0x002868A4
		public unsafe bool bRainOverrideSphereMask
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AKuroWorldRainGlobalOverrider.__PropertyOffset_bRainOverrideSphereMask) & AKuroWorldRainGlobalOverrider.__PropertyMask_bRainOverrideSphereMask) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AKuroWorldRainGlobalOverrider.__PropertyOffset_bRainOverrideSphereMask) = ((*(base.NativePtr + (IntPtr)AKuroWorldRainGlobalOverrider.__PropertyOffset_bRainOverrideSphereMask) & ~AKuroWorldRainGlobalOverrider.__PropertyMask_bRainOverrideSphereMask) | (value ? AKuroWorldRainGlobalOverrider.__PropertyMask_bRainOverrideSphereMask : 0));
			}
		}

		// Token: 0x17006ECA RID: 28362
		// (get) Token: 0x0601B858 RID: 112728 RVA: 0x002886D4 File Offset: 0x002868D4
		// (set) Token: 0x0601B859 RID: 112729 RVA: 0x002886E4 File Offset: 0x002868E4
		public unsafe float RainSphereMaskRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWorldRainGlobalOverrider.__PropertyOffset_RainSphereMaskRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWorldRainGlobalOverrider.__PropertyOffset_RainSphereMaskRadius) = value;
			}
		}

		// Token: 0x17006ECB RID: 28363
		// (get) Token: 0x0601B85A RID: 112730 RVA: 0x002886F5 File Offset: 0x002868F5
		// (set) Token: 0x0601B85B RID: 112731 RVA: 0x00288709 File Offset: 0x00286909
		public unsafe FVector RainSphereMaskOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWorldRainGlobalOverrider.__PropertyOffset_RainSphereMaskOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWorldRainGlobalOverrider.__PropertyOffset_RainSphereMaskOffset) = value;
			}
		}

		// Token: 0x17006ECC RID: 28364
		// (get) Token: 0x0601B85C RID: 112732 RVA: 0x0028871E File Offset: 0x0028691E
		// (set) Token: 0x0601B85D RID: 112733 RVA: 0x0028872E File Offset: 0x0028692E
		public unsafe bool bRainSphereMaskUseBone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWorldRainGlobalOverrider.__PropertyOffset_bRainSphereMaskUseBone) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWorldRainGlobalOverrider.__PropertyOffset_bRainSphereMaskUseBone) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006ECD RID: 28365
		// (get) Token: 0x0601B85E RID: 112734 RVA: 0x0028873F File Offset: 0x0028693F
		// (set) Token: 0x0601B85F RID: 112735 RVA: 0x00288753 File Offset: 0x00286953
		public unsafe FName RainSphereMaskBoneName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWorldRainGlobalOverrider.__PropertyOffset_RainSphereMaskBoneName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWorldRainGlobalOverrider.__PropertyOffset_RainSphereMaskBoneName) = value;
			}
		}

		// Token: 0x17006ECE RID: 28366
		// (get) Token: 0x0601B860 RID: 112736 RVA: 0x00288768 File Offset: 0x00286968
		// (set) Token: 0x0601B861 RID: 112737 RVA: 0x00288778 File Offset: 0x00286978
		public unsafe int Priority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWorldRainGlobalOverrider.__PropertyOffset_Priority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWorldRainGlobalOverrider.__PropertyOffset_Priority) = value;
			}
		}

		// Token: 0x0601B862 RID: 112738 RVA: 0x00288789 File Offset: 0x00286989
		static AKuroWorldRainGlobalOverrider()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroWorldRainGlobalOverrider");
		}

		// Token: 0x0601B863 RID: 112739 RVA: 0x00288797 File Offset: 0x00286997
		protected AKuroWorldRainGlobalOverrider(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400ECD9 RID: 60633
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroWorldRainGlobalOverrider";

		// Token: 0x0400ECDA RID: 60634
		private static IntPtr _ClassPtr;

		// Token: 0x0400ECDB RID: 60635
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400ECDC RID: 60636
		internal static int __PropertyOffset_SceneComponent;

		// Token: 0x0400ECDD RID: 60637
		internal static int __PropertyOffset_bOverrideWindSize;

		// Token: 0x0400ECDE RID: 60638
		internal static byte __PropertyMask_bOverrideWindSize;

		// Token: 0x0400ECDF RID: 60639
		internal static int __PropertyOffset_WindSizeOverride;

		// Token: 0x0400ECE0 RID: 60640
		internal static int __PropertyOffset_bOverrideGravity;

		// Token: 0x0400ECE1 RID: 60641
		internal static byte __PropertyMask_bOverrideGravity;

		// Token: 0x0400ECE2 RID: 60642
		internal static int __PropertyOffset_GravityOverride;

		// Token: 0x0400ECE3 RID: 60643
		internal static int __PropertyOffset_bOverrideDrag;

		// Token: 0x0400ECE4 RID: 60644
		internal static byte __PropertyMask_bOverrideDrag;

		// Token: 0x0400ECE5 RID: 60645
		internal static int __PropertyOffset_DragOverride;

		// Token: 0x0400ECE6 RID: 60646
		internal static int __PropertyOffset_bOverrideTimeDilation;

		// Token: 0x0400ECE7 RID: 60647
		internal static byte __PropertyMask_bOverrideTimeDilation;

		// Token: 0x0400ECE8 RID: 60648
		internal static int __PropertyOffset_TimeDilationOverride;

		// Token: 0x0400ECE9 RID: 60649
		internal static int __PropertyOffset_bRainOverrideTimeFreezeSpherize;

		// Token: 0x0400ECEA RID: 60650
		internal static byte __PropertyMask_bRainOverrideTimeFreezeSpherize;

		// Token: 0x0400ECEB RID: 60651
		internal static int __PropertyOffset_RainToSphereTime;

		// Token: 0x0400ECEC RID: 60652
		internal static int __PropertyOffset_RainToRainTime;

		// Token: 0x0400ECED RID: 60653
		internal static int __PropertyOffset_bRainOverrideSphereMask;

		// Token: 0x0400ECEE RID: 60654
		internal static byte __PropertyMask_bRainOverrideSphereMask;

		// Token: 0x0400ECEF RID: 60655
		internal static int __PropertyOffset_RainSphereMaskRadius;

		// Token: 0x0400ECF0 RID: 60656
		internal static int __PropertyOffset_RainSphereMaskOffset;

		// Token: 0x0400ECF1 RID: 60657
		internal static int __PropertyOffset_bRainSphereMaskUseBone;

		// Token: 0x0400ECF2 RID: 60658
		internal static int __PropertyOffset_RainSphereMaskBoneName;

		// Token: 0x0400ECF3 RID: 60659
		internal static int __PropertyOffset_Priority;
	}
}
