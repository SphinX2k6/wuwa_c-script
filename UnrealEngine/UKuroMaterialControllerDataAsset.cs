using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004CF RID: 1231
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerDataAsset")]
	[UnrealStructLayout(3160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 3160)]
	public class UKuroMaterialControllerDataAsset : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007332 RID: 29490 RVA: 0x000A8DC7 File Offset: 0x000A6FC7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroMaterialControllerDataAsset._ClassPtr;
		}

		// Token: 0x06007333 RID: 29491 RVA: 0x000A8DD4 File Offset: 0x000A6FD4
		public UKuroMaterialControllerDataAsset() : this(BuiltinUtils.AllocNativeUObject(UKuroMaterialControllerDataAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007334 RID: 29492 RVA: 0x000A8DFC File Offset: 0x000A6FFC
		public UKuroMaterialControllerDataAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroMaterialControllerDataAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001691 RID: 5777
		// (get) Token: 0x06007335 RID: 29493 RVA: 0x000A8E2F File Offset: 0x000A702F
		// (set) Token: 0x06007336 RID: 29494 RVA: 0x000A8E3F File Offset: 0x000A703F
		public unsafe bool bUseAbsoluteSpaceCurve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMaterialControllerDataAsset.__PropertyOffset_bUseAbsoluteSpaceCurve) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMaterialControllerDataAsset.__PropertyOffset_bUseAbsoluteSpaceCurve) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001692 RID: 5778
		// (get) Token: 0x06007337 RID: 29495 RVA: 0x000A8E50 File Offset: 0x000A7050
		// (set) Token: 0x06007338 RID: 29496 RVA: 0x000A8E60 File Offset: 0x000A7060
		public unsafe bool CleanOriginEffect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMaterialControllerDataAsset.__PropertyOffset_CleanOriginEffect) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMaterialControllerDataAsset.__PropertyOffset_CleanOriginEffect) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001693 RID: 5779
		// (get) Token: 0x06007339 RID: 29497 RVA: 0x000A8E71 File Offset: 0x000A7071
		// (set) Token: 0x0600733A RID: 29498 RVA: 0x000A8E81 File Offset: 0x000A7081
		public unsafe bool NeverBeCleanedByOthers
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMaterialControllerDataAsset.__PropertyOffset_NeverBeCleanedByOthers) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMaterialControllerDataAsset.__PropertyOffset_NeverBeCleanedByOthers) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001694 RID: 5780
		// (get) Token: 0x0600733B RID: 29499 RVA: 0x000A8E92 File Offset: 0x000A7092
		// (set) Token: 0x0600733C RID: 29500 RVA: 0x000A8EA2 File Offset: 0x000A70A2
		public unsafe bool HighPriority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMaterialControllerDataAsset.__PropertyOffset_HighPriority) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMaterialControllerDataAsset.__PropertyOffset_HighPriority) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001695 RID: 5781
		// (get) Token: 0x0600733D RID: 29501 RVA: 0x000A8EB3 File Offset: 0x000A70B3
		// (set) Token: 0x0600733E RID: 29502 RVA: 0x000A8EC3 File Offset: 0x000A70C3
		public unsafe bool bReceiveLogicalTimeDilation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMaterialControllerDataAsset.__PropertyOffset_bReceiveLogicalTimeDilation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMaterialControllerDataAsset.__PropertyOffset_bReceiveLogicalTimeDilation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001696 RID: 5782
		// (get) Token: 0x0600733F RID: 29503 RVA: 0x000A8ED4 File Offset: 0x000A70D4
		// (set) Token: 0x06007340 RID: 29504 RVA: 0x000A8EE4 File Offset: 0x000A70E4
		public unsafe bool ForceBattle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMaterialControllerDataAsset.__PropertyOffset_ForceBattle) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMaterialControllerDataAsset.__PropertyOffset_ForceBattle) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001697 RID: 5783
		// (get) Token: 0x06007341 RID: 29505 RVA: 0x000A8EF5 File Offset: 0x000A70F5
		// (set) Token: 0x06007342 RID: 29506 RVA: 0x000A8F05 File Offset: 0x000A7105
		public unsafe bool ForceBattleMask
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMaterialControllerDataAsset.__PropertyOffset_ForceBattleMask) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMaterialControllerDataAsset.__PropertyOffset_ForceBattleMask) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001698 RID: 5784
		// (get) Token: 0x06007343 RID: 29507 RVA: 0x000A8F16 File Offset: 0x000A7116
		// (set) Token: 0x06007344 RID: 29508 RVA: 0x000A8F26 File Offset: 0x000A7126
		public unsafe bool ForceAlphaTest
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMaterialControllerDataAsset.__PropertyOffset_ForceAlphaTest) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMaterialControllerDataAsset.__PropertyOffset_ForceAlphaTest) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001699 RID: 5785
		// (get) Token: 0x06007345 RID: 29509 RVA: 0x000A8F37 File Offset: 0x000A7137
		// (set) Token: 0x06007346 RID: 29510 RVA: 0x000A8F47 File Offset: 0x000A7147
		public unsafe bool bAllowMaterialUnreverted
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMaterialControllerDataAsset.__PropertyOffset_bAllowMaterialUnreverted) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMaterialControllerDataAsset.__PropertyOffset_bAllowMaterialUnreverted) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700169A RID: 5786
		// (get) Token: 0x06007347 RID: 29511 RVA: 0x000A8F58 File Offset: 0x000A7158
		// (set) Token: 0x06007348 RID: 29512 RVA: 0x000A8F68 File Offset: 0x000A7168
		public unsafe bool bMaterialReplaceReceiveEffects
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMaterialControllerDataAsset.__PropertyOffset_bMaterialReplaceReceiveEffects) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMaterialControllerDataAsset.__PropertyOffset_bMaterialReplaceReceiveEffects) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700169B RID: 5787
		// (get) Token: 0x06007349 RID: 29513 RVA: 0x000A8F7C File Offset: 0x000A717C
		// (set) Token: 0x0600734A RID: 29514 RVA: 0x000A8FB5 File Offset: 0x000A71B5
		public TArray<FName> ExtraBodyNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._ExtraBodyNames) == null)
				{
					result = (this._ExtraBodyNames = new TArray<FName>(base.NativePtr + (IntPtr)UKuroMaterialControllerDataAsset.__PropertyOffset_ExtraBodyNames, this));
				}
				return result;
			}
			set
			{
				this.ExtraBodyNames.CopyAssign(value);
			}
		}

		// Token: 0x1700169C RID: 5788
		// (get) Token: 0x0600734B RID: 29515 RVA: 0x000A8FC3 File Offset: 0x000A71C3
		// (set) Token: 0x0600734C RID: 29516 RVA: 0x000A8FD3 File Offset: 0x000A71D3
		public unsafe bool AlwaysApplyToExtraBodies
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMaterialControllerDataAsset.__PropertyOffset_AlwaysApplyToExtraBodies) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMaterialControllerDataAsset.__PropertyOffset_AlwaysApplyToExtraBodies) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700169D RID: 5789
		// (get) Token: 0x0600734D RID: 29517 RVA: 0x000A8FE4 File Offset: 0x000A71E4
		// (set) Token: 0x0600734E RID: 29518 RVA: 0x000A8FF8 File Offset: 0x000A71F8
		[Nullable(2)]
		public unsafe UMaterialInterface ReplaceMaterialMac
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroMaterialControllerDataAsset.__PropertyOffset_ReplaceMaterialMac);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroMaterialControllerDataAsset.__PropertyOffset_ReplaceMaterialMac, value);
			}
		}

		// Token: 0x1700169E RID: 5790
		// (get) Token: 0x0600734F RID: 29519 RVA: 0x000A900D File Offset: 0x000A720D
		// (set) Token: 0x06007350 RID: 29520 RVA: 0x000A901D File Offset: 0x000A721D
		public unsafe bool bMatchMaterialIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMaterialControllerDataAsset.__PropertyOffset_bMatchMaterialIndex) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMaterialControllerDataAsset.__PropertyOffset_bMatchMaterialIndex) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700169F RID: 5791
		// (get) Token: 0x06007351 RID: 29521 RVA: 0x000A9030 File Offset: 0x000A7230
		// (set) Token: 0x06007352 RID: 29522 RVA: 0x000A9069 File Offset: 0x000A7269
		public TArray<UMaterialInterface> ReplaceBaseMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInterface> result;
				if ((result = this._ReplaceBaseMaterials) == null)
				{
					result = (this._ReplaceBaseMaterials = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)UKuroMaterialControllerDataAsset.__PropertyOffset_ReplaceBaseMaterials, this));
				}
				return result;
			}
			set
			{
				this.ReplaceBaseMaterials.CopyAssign(value);
			}
		}

		// Token: 0x170016A0 RID: 5792
		// (get) Token: 0x06007353 RID: 29523 RVA: 0x000A9078 File Offset: 0x000A7278
		// (set) Token: 0x06007354 RID: 29524 RVA: 0x000A90B1 File Offset: 0x000A72B1
		public TArray<UMaterialInterface> ReplaceBaseMaterialsMobile
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInterface> result;
				if ((result = this._ReplaceBaseMaterialsMobile) == null)
				{
					result = (this._ReplaceBaseMaterialsMobile = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)UKuroMaterialControllerDataAsset.__PropertyOffset_ReplaceBaseMaterialsMobile, this));
				}
				return result;
			}
			set
			{
				this.ReplaceBaseMaterialsMobile.CopyAssign(value);
			}
		}

		// Token: 0x170016A1 RID: 5793
		// (get) Token: 0x06007355 RID: 29525 RVA: 0x000A90BF File Offset: 0x000A72BF
		// (set) Token: 0x06007356 RID: 29526 RVA: 0x000A90CF File Offset: 0x000A72CF
		public unsafe bool bUseBodyOpacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMaterialControllerDataAsset.__PropertyOffset_bUseBodyOpacity) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMaterialControllerDataAsset.__PropertyOffset_bUseBodyOpacity) = (value ? 1 : 0);
			}
		}

		// Token: 0x170016A2 RID: 5794
		// (get) Token: 0x06007357 RID: 29527 RVA: 0x000A90E0 File Offset: 0x000A72E0
		// (set) Token: 0x06007358 RID: 29528 RVA: 0x000A90F0 File Offset: 0x000A72F0
		public unsafe bool bUseXRay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMaterialControllerDataAsset.__PropertyOffset_bUseXRay) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMaterialControllerDataAsset.__PropertyOffset_bUseXRay) = (value ? 1 : 0);
			}
		}

		// Token: 0x06007359 RID: 29529 RVA: 0x000A9101 File Offset: 0x000A7301
		public void ResetDataCache(bool bForce = false)
		{
			UKuroMaterialControllerDataAsset.__ResetDataCache_Internal(base.NativePtr, bForce);
		}

		// Token: 0x0600735A RID: 29530 RVA: 0x000A910F File Offset: 0x000A730F
		public bool IsDataCacheValid()
		{
			return UKuroMaterialControllerDataAsset.__IsDataCacheValid_Internal(base.NativePtr);
		}

		// Token: 0x0600735B RID: 29531
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetDataCache_Internal(IntPtr @this, bool bForce);

		// Token: 0x0600735C RID: 29532
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsDataCacheValid_Internal(IntPtr @this);

		// Token: 0x0600735D RID: 29533 RVA: 0x000A911C File Offset: 0x000A731C
		static UKuroMaterialControllerDataAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerDataAsset");
		}

		// Token: 0x0600735E RID: 29534 RVA: 0x000A912A File Offset: 0x000A732A
		protected UKuroMaterialControllerDataAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003158 RID: 12632
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerDataAsset";

		// Token: 0x04003159 RID: 12633
		private static IntPtr _ClassPtr;

		// Token: 0x0400315A RID: 12634
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400315B RID: 12635
		internal static int __PropertyOffset_bUseAbsoluteSpaceCurve;

		// Token: 0x0400315C RID: 12636
		internal static int __PropertyOffset_CleanOriginEffect;

		// Token: 0x0400315D RID: 12637
		internal static int __PropertyOffset_NeverBeCleanedByOthers;

		// Token: 0x0400315E RID: 12638
		internal static int __PropertyOffset_HighPriority;

		// Token: 0x0400315F RID: 12639
		internal static int __PropertyOffset_bReceiveLogicalTimeDilation;

		// Token: 0x04003160 RID: 12640
		internal static int __PropertyOffset_ForceBattle;

		// Token: 0x04003161 RID: 12641
		internal static int __PropertyOffset_ForceBattleMask;

		// Token: 0x04003162 RID: 12642
		internal static int __PropertyOffset_ForceAlphaTest;

		// Token: 0x04003163 RID: 12643
		internal static int __PropertyOffset_bAllowMaterialUnreverted;

		// Token: 0x04003164 RID: 12644
		internal static int __PropertyOffset_bMaterialReplaceReceiveEffects;

		// Token: 0x04003165 RID: 12645
		internal static int __PropertyOffset_ExtraBodyNames;

		// Token: 0x04003166 RID: 12646
		[Nullable(2)]
		private TArray<FName> _ExtraBodyNames;

		// Token: 0x04003167 RID: 12647
		internal static int __PropertyOffset_AlwaysApplyToExtraBodies;

		// Token: 0x04003168 RID: 12648
		internal static int __PropertyOffset_ReplaceMaterialMac;

		// Token: 0x04003169 RID: 12649
		internal static int __PropertyOffset_bMatchMaterialIndex;

		// Token: 0x0400316A RID: 12650
		internal static int __PropertyOffset_ReplaceBaseMaterials;

		// Token: 0x0400316B RID: 12651
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _ReplaceBaseMaterials;

		// Token: 0x0400316C RID: 12652
		internal static int __PropertyOffset_ReplaceBaseMaterialsMobile;

		// Token: 0x0400316D RID: 12653
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _ReplaceBaseMaterialsMobile;

		// Token: 0x0400316E RID: 12654
		internal static int __PropertyOffset_bUseBodyOpacity;

		// Token: 0x0400316F RID: 12655
		internal static int __PropertyOffset_bUseXRay;
	}
}
