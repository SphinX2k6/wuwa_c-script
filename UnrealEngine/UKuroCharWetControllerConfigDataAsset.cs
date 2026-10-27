using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001AC8 RID: 6856
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroCharWetControllerConfigDataAsset")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 216)]
	public class UKuroCharWetControllerConfigDataAsset : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060197A7 RID: 104359 RVA: 0x0025A61D File Offset: 0x0025881D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroCharWetControllerConfigDataAsset._ClassPtr;
		}

		// Token: 0x060197A8 RID: 104360 RVA: 0x0025A62C File Offset: 0x0025882C
		public UKuroCharWetControllerConfigDataAsset() : this(BuiltinUtils.AllocNativeUObject(UKuroCharWetControllerConfigDataAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060197A9 RID: 104361 RVA: 0x0025A654 File Offset: 0x00258854
		public UKuroCharWetControllerConfigDataAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroCharWetControllerConfigDataAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006590 RID: 26000
		// (get) Token: 0x060197AA RID: 104362 RVA: 0x0025A687 File Offset: 0x00258887
		// (set) Token: 0x060197AB RID: 104363 RVA: 0x0025A69B File Offset: 0x0025889B
		[Nullable(2)]
		public unsafe UMaterialParameterCollection GlobalCharWetMPC
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroCharWetControllerConfigDataAsset.__PropertyOffset_GlobalCharWetMPC);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroCharWetControllerConfigDataAsset.__PropertyOffset_GlobalCharWetMPC, value);
			}
		}

		// Token: 0x17006591 RID: 26001
		// (get) Token: 0x060197AC RID: 104364 RVA: 0x0025A6B0 File Offset: 0x002588B0
		// (set) Token: 0x060197AD RID: 104365 RVA: 0x0025A6C4 File Offset: 0x002588C4
		public unsafe FName CharWetRenderFootPrintInt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCharWetControllerConfigDataAsset.__PropertyOffset_CharWetRenderFootPrintInt);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCharWetControllerConfigDataAsset.__PropertyOffset_CharWetRenderFootPrintInt) = value;
			}
		}

		// Token: 0x17006592 RID: 26002
		// (get) Token: 0x060197AE RID: 104366 RVA: 0x0025A6D9 File Offset: 0x002588D9
		// (set) Token: 0x060197AF RID: 104367 RVA: 0x0025A6ED File Offset: 0x002588ED
		public unsafe FName CharWetRenderBlackRainInt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCharWetControllerConfigDataAsset.__PropertyOffset_CharWetRenderBlackRainInt);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCharWetControllerConfigDataAsset.__PropertyOffset_CharWetRenderBlackRainInt) = value;
			}
		}

		// Token: 0x17006593 RID: 26003
		// (get) Token: 0x060197B0 RID: 104368 RVA: 0x0025A702 File Offset: 0x00258902
		// (set) Token: 0x060197B1 RID: 104369 RVA: 0x0025A716 File Offset: 0x00258916
		public unsafe FVector2D GlobalCharWetMappingRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCharWetControllerConfigDataAsset.__PropertyOffset_GlobalCharWetMappingRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCharWetControllerConfigDataAsset.__PropertyOffset_GlobalCharWetMappingRange) = value;
			}
		}

		// Token: 0x17006594 RID: 26004
		// (get) Token: 0x060197B2 RID: 104370 RVA: 0x0025A72B File Offset: 0x0025892B
		// (set) Token: 0x060197B3 RID: 104371 RVA: 0x0025A73F File Offset: 0x0025893F
		public unsafe FName CharWatRenderInWater
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCharWetControllerConfigDataAsset.__PropertyOffset_CharWatRenderInWater);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCharWetControllerConfigDataAsset.__PropertyOffset_CharWatRenderInWater) = value;
			}
		}

		// Token: 0x17006595 RID: 26005
		// (get) Token: 0x060197B4 RID: 104372 RVA: 0x0025A754 File Offset: 0x00258954
		// (set) Token: 0x060197B5 RID: 104373 RVA: 0x0025A78D File Offset: 0x0025898D
		public TArray<FKuroCharWetBodyMeshConfig> CharWetBodyMeshConfigs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCharWetBodyMeshConfig> result;
				if ((result = this._CharWetBodyMeshConfigs) == null)
				{
					result = (this._CharWetBodyMeshConfigs = new TArray<FKuroCharWetBodyMeshConfig>(base.NativePtr + (IntPtr)UKuroCharWetControllerConfigDataAsset.__PropertyOffset_CharWetBodyMeshConfigs, this));
				}
				return result;
			}
			set
			{
				this.CharWetBodyMeshConfigs.CopyAssign(value);
			}
		}

		// Token: 0x17006596 RID: 26006
		// (get) Token: 0x060197B6 RID: 104374 RVA: 0x0025A79C File Offset: 0x0025899C
		// (set) Token: 0x060197B7 RID: 104375 RVA: 0x0025A7D5 File Offset: 0x002589D5
		public TArray<FKuroCharWetControllerComponentEntry> Entries
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCharWetControllerComponentEntry> result;
				if ((result = this._Entries) == null)
				{
					result = (this._Entries = new TArray<FKuroCharWetControllerComponentEntry>(base.NativePtr + (IntPtr)UKuroCharWetControllerConfigDataAsset.__PropertyOffset_Entries, this));
				}
				return result;
			}
			set
			{
				this.Entries.CopyAssign(value);
			}
		}

		// Token: 0x17006597 RID: 26007
		// (get) Token: 0x060197B8 RID: 104376 RVA: 0x0025A7E4 File Offset: 0x002589E4
		// (set) Token: 0x060197B9 RID: 104377 RVA: 0x0025A81D File Offset: 0x00258A1D
		public TArray<FKuroCharWetMorphEntry> WetMorph
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCharWetMorphEntry> result;
				if ((result = this._WetMorph) == null)
				{
					result = (this._WetMorph = new TArray<FKuroCharWetMorphEntry>(base.NativePtr + (IntPtr)UKuroCharWetControllerConfigDataAsset.__PropertyOffset_WetMorph, this));
				}
				return result;
			}
			set
			{
				this.WetMorph.CopyAssign(value);
			}
		}

		// Token: 0x17006598 RID: 26008
		// (get) Token: 0x060197BA RID: 104378 RVA: 0x0025A82B File Offset: 0x00258A2B
		// (set) Token: 0x060197BB RID: 104379 RVA: 0x0025A83B File Offset: 0x00258A3B
		public unsafe float WetDecayDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCharWetControllerConfigDataAsset.__PropertyOffset_WetDecayDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCharWetControllerConfigDataAsset.__PropertyOffset_WetDecayDuration) = value;
			}
		}

		// Token: 0x17006599 RID: 26009
		// (get) Token: 0x060197BC RID: 104380 RVA: 0x0025A84C File Offset: 0x00258A4C
		// (set) Token: 0x060197BD RID: 104381 RVA: 0x0025A85C File Offset: 0x00258A5C
		public unsafe float RainWetEnterDelay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCharWetControllerConfigDataAsset.__PropertyOffset_RainWetEnterDelay);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCharWetControllerConfigDataAsset.__PropertyOffset_RainWetEnterDelay) = value;
			}
		}

		// Token: 0x1700659A RID: 26010
		// (get) Token: 0x060197BE RID: 104382 RVA: 0x0025A86D File Offset: 0x00258A6D
		// (set) Token: 0x060197BF RID: 104383 RVA: 0x0025A87D File Offset: 0x00258A7D
		public unsafe float RainWetEnterDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCharWetControllerConfigDataAsset.__PropertyOffset_RainWetEnterDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCharWetControllerConfigDataAsset.__PropertyOffset_RainWetEnterDuration) = value;
			}
		}

		// Token: 0x1700659B RID: 26011
		// (get) Token: 0x060197C0 RID: 104384 RVA: 0x0025A88E File Offset: 0x00258A8E
		// (set) Token: 0x060197C1 RID: 104385 RVA: 0x0025A89E File Offset: 0x00258A9E
		public unsafe float CharHalfHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCharWetControllerConfigDataAsset.__PropertyOffset_CharHalfHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCharWetControllerConfigDataAsset.__PropertyOffset_CharHalfHeight) = value;
			}
		}

		// Token: 0x1700659C RID: 26012
		// (get) Token: 0x060197C2 RID: 104386 RVA: 0x0025A8AF File Offset: 0x00258AAF
		// (set) Token: 0x060197C3 RID: 104387 RVA: 0x0025A8BF File Offset: 0x00258ABF
		public unsafe float SwimWaterRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCharWetControllerConfigDataAsset.__PropertyOffset_SwimWaterRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCharWetControllerConfigDataAsset.__PropertyOffset_SwimWaterRatio) = value;
			}
		}

		// Token: 0x1700659D RID: 26013
		// (get) Token: 0x060197C4 RID: 104388 RVA: 0x0025A8D0 File Offset: 0x00258AD0
		// (set) Token: 0x060197C5 RID: 104389 RVA: 0x0025A8E0 File Offset: 0x00258AE0
		public unsafe float WaterRatioOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCharWetControllerConfigDataAsset.__PropertyOffset_WaterRatioOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCharWetControllerConfigDataAsset.__PropertyOffset_WaterRatioOffset) = value;
			}
		}

		// Token: 0x1700659E RID: 26014
		// (get) Token: 0x060197C6 RID: 104390 RVA: 0x0025A8F1 File Offset: 0x00258AF1
		// (set) Token: 0x060197C7 RID: 104391 RVA: 0x0025A901 File Offset: 0x00258B01
		public unsafe float WaterExitHoldDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCharWetControllerConfigDataAsset.__PropertyOffset_WaterExitHoldDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCharWetControllerConfigDataAsset.__PropertyOffset_WaterExitHoldDuration) = value;
			}
		}

		// Token: 0x1700659F RID: 26015
		// (get) Token: 0x060197C8 RID: 104392 RVA: 0x0025A912 File Offset: 0x00258B12
		// (set) Token: 0x060197C9 RID: 104393 RVA: 0x0025A922 File Offset: 0x00258B22
		public unsafe float WaterWetFadeDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCharWetControllerConfigDataAsset.__PropertyOffset_WaterWetFadeDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCharWetControllerConfigDataAsset.__PropertyOffset_WaterWetFadeDuration) = value;
			}
		}

		// Token: 0x060197CA RID: 104394 RVA: 0x0025A933 File Offset: 0x00258B33
		static UKuroCharWetControllerConfigDataAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroCharWetControllerConfigDataAsset");
		}

		// Token: 0x060197CB RID: 104395 RVA: 0x0025A941 File Offset: 0x00258B41
		protected UKuroCharWetControllerConfigDataAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400DDDC RID: 56796
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroCharWetControllerConfigDataAsset";

		// Token: 0x0400DDDD RID: 56797
		private static IntPtr _ClassPtr;

		// Token: 0x0400DDDE RID: 56798
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400DDDF RID: 56799
		internal static int __PropertyOffset_GlobalCharWetMPC;

		// Token: 0x0400DDE0 RID: 56800
		internal static int __PropertyOffset_CharWetRenderFootPrintInt;

		// Token: 0x0400DDE1 RID: 56801
		internal static int __PropertyOffset_CharWetRenderBlackRainInt;

		// Token: 0x0400DDE2 RID: 56802
		internal static int __PropertyOffset_GlobalCharWetMappingRange;

		// Token: 0x0400DDE3 RID: 56803
		internal static int __PropertyOffset_CharWatRenderInWater;

		// Token: 0x0400DDE4 RID: 56804
		internal static int __PropertyOffset_CharWetBodyMeshConfigs;

		// Token: 0x0400DDE5 RID: 56805
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCharWetBodyMeshConfig> _CharWetBodyMeshConfigs;

		// Token: 0x0400DDE6 RID: 56806
		internal static int __PropertyOffset_Entries;

		// Token: 0x0400DDE7 RID: 56807
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCharWetControllerComponentEntry> _Entries;

		// Token: 0x0400DDE8 RID: 56808
		internal static int __PropertyOffset_WetMorph;

		// Token: 0x0400DDE9 RID: 56809
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCharWetMorphEntry> _WetMorph;

		// Token: 0x0400DDEA RID: 56810
		internal static int __PropertyOffset_WetDecayDuration;

		// Token: 0x0400DDEB RID: 56811
		internal static int __PropertyOffset_RainWetEnterDelay;

		// Token: 0x0400DDEC RID: 56812
		internal static int __PropertyOffset_RainWetEnterDuration;

		// Token: 0x0400DDED RID: 56813
		internal static int __PropertyOffset_CharHalfHeight;

		// Token: 0x0400DDEE RID: 56814
		internal static int __PropertyOffset_SwimWaterRatio;

		// Token: 0x0400DDEF RID: 56815
		internal static int __PropertyOffset_WaterRatioOffset;

		// Token: 0x0400DDF0 RID: 56816
		internal static int __PropertyOffset_WaterExitHoldDuration;

		// Token: 0x0400DDF1 RID: 56817
		internal static int __PropertyOffset_WaterWetFadeDuration;
	}
}
