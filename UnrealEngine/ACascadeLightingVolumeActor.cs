using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000920 RID: 2336
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.CascadeLightingVolumeActor")]
	[UnrealStructLayout(1616, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1616)]
	public class ACascadeLightingVolumeActor : AVolume, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060080D3 RID: 32979 RVA: 0x000B8B14 File Offset: 0x000B6D14
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ACascadeLightingVolumeActor._ClassPtr;
		}

		// Token: 0x060080D4 RID: 32980 RVA: 0x000B8B20 File Offset: 0x000B6D20
		public ACascadeLightingVolumeActor() : this(BuiltinUtils.AllocNativeUObject(ACascadeLightingVolumeActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060080D5 RID: 32981 RVA: 0x000B8B48 File Offset: 0x000B6D48
		public ACascadeLightingVolumeActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ACascadeLightingVolumeActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001E41 RID: 7745
		// (get) Token: 0x060080D6 RID: 32982 RVA: 0x000B8B7B File Offset: 0x000B6D7B
		// (set) Token: 0x060080D7 RID: 32983 RVA: 0x000B8B94 File Offset: 0x000B6D94
		public unsafe bool bEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ACascadeLightingVolumeActor.__PropertyOffset_bEnabled) & ACascadeLightingVolumeActor.__PropertyMask_bEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ACascadeLightingVolumeActor.__PropertyOffset_bEnabled) = ((*(base.NativePtr + (IntPtr)ACascadeLightingVolumeActor.__PropertyOffset_bEnabled) & ~ACascadeLightingVolumeActor.__PropertyMask_bEnabled) | (value ? ACascadeLightingVolumeActor.__PropertyMask_bEnabled : 0));
			}
		}

		// Token: 0x17001E42 RID: 7746
		// (get) Token: 0x060080D8 RID: 32984 RVA: 0x000B8BC4 File Offset: 0x000B6DC4
		// (set) Token: 0x060080D9 RID: 32985 RVA: 0x000B8BD4 File Offset: 0x000B6DD4
		public unsafe float ClvOcclusionScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACascadeLightingVolumeActor.__PropertyOffset_ClvOcclusionScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACascadeLightingVolumeActor.__PropertyOffset_ClvOcclusionScale) = value;
			}
		}

		// Token: 0x17001E43 RID: 7747
		// (get) Token: 0x060080DA RID: 32986 RVA: 0x000B8BE5 File Offset: 0x000B6DE5
		// (set) Token: 0x060080DB RID: 32987 RVA: 0x000B8BF5 File Offset: 0x000B6DF5
		public unsafe float ClvIndirectLightIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACascadeLightingVolumeActor.__PropertyOffset_ClvIndirectLightIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACascadeLightingVolumeActor.__PropertyOffset_ClvIndirectLightIntensity) = value;
			}
		}

		// Token: 0x17001E44 RID: 7748
		// (get) Token: 0x060080DC RID: 32988 RVA: 0x000B8C06 File Offset: 0x000B6E06
		// (set) Token: 0x060080DD RID: 32989 RVA: 0x000B8C16 File Offset: 0x000B6E16
		public unsafe bool bBakeSkyLight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACascadeLightingVolumeActor.__PropertyOffset_bBakeSkyLight) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACascadeLightingVolumeActor.__PropertyOffset_bBakeSkyLight) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001E45 RID: 7749
		// (get) Token: 0x060080DE RID: 32990 RVA: 0x000B8C27 File Offset: 0x000B6E27
		// (set) Token: 0x060080DF RID: 32991 RVA: 0x000B8C37 File Offset: 0x000B6E37
		public unsafe bool bStrictSkyLightName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACascadeLightingVolumeActor.__PropertyOffset_bStrictSkyLightName) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACascadeLightingVolumeActor.__PropertyOffset_bStrictSkyLightName) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001E46 RID: 7750
		// (get) Token: 0x060080E0 RID: 32992 RVA: 0x000B8C48 File Offset: 0x000B6E48
		// (set) Token: 0x060080E1 RID: 32993 RVA: 0x000B8C58 File Offset: 0x000B6E58
		public unsafe float BakeSkyLightIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACascadeLightingVolumeActor.__PropertyOffset_BakeSkyLightIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACascadeLightingVolumeActor.__PropertyOffset_BakeSkyLightIntensity) = value;
			}
		}

		// Token: 0x17001E47 RID: 7751
		// (get) Token: 0x060080E2 RID: 32994 RVA: 0x000B8C69 File Offset: 0x000B6E69
		// (set) Token: 0x060080E3 RID: 32995 RVA: 0x000B8C7D File Offset: 0x000B6E7D
		public unsafe FLinearColor BakeSkyLightColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACascadeLightingVolumeActor.__PropertyOffset_BakeSkyLightColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACascadeLightingVolumeActor.__PropertyOffset_BakeSkyLightColor) = value;
			}
		}

		// Token: 0x17001E48 RID: 7752
		// (get) Token: 0x060080E4 RID: 32996 RVA: 0x000B8C92 File Offset: 0x000B6E92
		// (set) Token: 0x060080E5 RID: 32997 RVA: 0x000B8CA2 File Offset: 0x000B6EA2
		public unsafe bool bBakeDirectLight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACascadeLightingVolumeActor.__PropertyOffset_bBakeDirectLight) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACascadeLightingVolumeActor.__PropertyOffset_bBakeDirectLight) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001E49 RID: 7753
		// (get) Token: 0x060080E6 RID: 32998 RVA: 0x000B8CB3 File Offset: 0x000B6EB3
		// (set) Token: 0x060080E7 RID: 32999 RVA: 0x000B8CC3 File Offset: 0x000B6EC3
		public unsafe bool bStrictDirectLightName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACascadeLightingVolumeActor.__PropertyOffset_bStrictDirectLightName) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACascadeLightingVolumeActor.__PropertyOffset_bStrictDirectLightName) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001E4A RID: 7754
		// (get) Token: 0x060080E8 RID: 33000 RVA: 0x000B8CD4 File Offset: 0x000B6ED4
		// (set) Token: 0x060080E9 RID: 33001 RVA: 0x000B8CE4 File Offset: 0x000B6EE4
		public unsafe float BakeDirectLightIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACascadeLightingVolumeActor.__PropertyOffset_BakeDirectLightIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACascadeLightingVolumeActor.__PropertyOffset_BakeDirectLightIntensity) = value;
			}
		}

		// Token: 0x17001E4B RID: 7755
		// (get) Token: 0x060080EA RID: 33002 RVA: 0x000B8CF5 File Offset: 0x000B6EF5
		// (set) Token: 0x060080EB RID: 33003 RVA: 0x000B8D05 File Offset: 0x000B6F05
		public unsafe int SamplesPerPixel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACascadeLightingVolumeActor.__PropertyOffset_SamplesPerPixel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACascadeLightingVolumeActor.__PropertyOffset_SamplesPerPixel) = value;
			}
		}

		// Token: 0x17001E4C RID: 7756
		// (get) Token: 0x060080EC RID: 33004 RVA: 0x000B8D16 File Offset: 0x000B6F16
		// (set) Token: 0x060080ED RID: 33005 RVA: 0x000B8D26 File Offset: 0x000B6F26
		public unsafe int MaxBounces
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACascadeLightingVolumeActor.__PropertyOffset_MaxBounces);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACascadeLightingVolumeActor.__PropertyOffset_MaxBounces) = value;
			}
		}

		// Token: 0x17001E4D RID: 7757
		// (get) Token: 0x060080EE RID: 33006 RVA: 0x000B8D37 File Offset: 0x000B6F37
		// (set) Token: 0x060080EF RID: 33007 RVA: 0x000B8D47 File Offset: 0x000B6F47
		public unsafe bool bEnableAdvancedMaterialExport
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACascadeLightingVolumeActor.__PropertyOffset_bEnableAdvancedMaterialExport) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACascadeLightingVolumeActor.__PropertyOffset_bEnableAdvancedMaterialExport) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001E4E RID: 7758
		// (get) Token: 0x060080F0 RID: 33008 RVA: 0x000B8D58 File Offset: 0x000B6F58
		// (set) Token: 0x060080F1 RID: 33009 RVA: 0x000B8D68 File Offset: 0x000B6F68
		public unsafe bool bOverrideMBDCompressEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACascadeLightingVolumeActor.__PropertyOffset_bOverrideMBDCompressEnable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACascadeLightingVolumeActor.__PropertyOffset_bOverrideMBDCompressEnable) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001E4F RID: 7759
		// (get) Token: 0x060080F2 RID: 33010 RVA: 0x000B8D79 File Offset: 0x000B6F79
		// (set) Token: 0x060080F3 RID: 33011 RVA: 0x000B8D89 File Offset: 0x000B6F89
		public unsafe bool bMBDCompressEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACascadeLightingVolumeActor.__PropertyOffset_bMBDCompressEnable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACascadeLightingVolumeActor.__PropertyOffset_bMBDCompressEnable) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001E50 RID: 7760
		// (get) Token: 0x060080F4 RID: 33012 RVA: 0x000B8D9A File Offset: 0x000B6F9A
		// (set) Token: 0x060080F5 RID: 33013 RVA: 0x000B8DAA File Offset: 0x000B6FAA
		public unsafe bool bBakeOptimizedLightVolumePartition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACascadeLightingVolumeActor.__PropertyOffset_bBakeOptimizedLightVolumePartition) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACascadeLightingVolumeActor.__PropertyOffset_bBakeOptimizedLightVolumePartition) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001E51 RID: 7761
		// (get) Token: 0x060080F6 RID: 33014 RVA: 0x000B8DBB File Offset: 0x000B6FBB
		// (set) Token: 0x060080F7 RID: 33015 RVA: 0x000B8DCB File Offset: 0x000B6FCB
		public unsafe bool bOverrideClvProbePlacement
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACascadeLightingVolumeActor.__PropertyOffset_bOverrideClvProbePlacement) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACascadeLightingVolumeActor.__PropertyOffset_bOverrideClvProbePlacement) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001E52 RID: 7762
		// (get) Token: 0x060080F8 RID: 33016 RVA: 0x000B8DDC File Offset: 0x000B6FDC
		// (set) Token: 0x060080F9 RID: 33017 RVA: 0x000B8E15 File Offset: 0x000B7015
		public TArray<float> CascadeLightingVolumeBlockSizes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._CascadeLightingVolumeBlockSizes) == null)
				{
					result = (this._CascadeLightingVolumeBlockSizes = new TArray<float>(base.NativePtr + (IntPtr)ACascadeLightingVolumeActor.__PropertyOffset_CascadeLightingVolumeBlockSizes, this));
				}
				return result;
			}
			set
			{
				this.CascadeLightingVolumeBlockSizes.CopyAssign(value);
			}
		}

		// Token: 0x17001E53 RID: 7763
		// (get) Token: 0x060080FA RID: 33018 RVA: 0x000B8E23 File Offset: 0x000B7023
		// (set) Token: 0x060080FB RID: 33019 RVA: 0x000B8E33 File Offset: 0x000B7033
		public unsafe bool bEnableStaticProbeVolumeFilter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACascadeLightingVolumeActor.__PropertyOffset_bEnableStaticProbeVolumeFilter) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACascadeLightingVolumeActor.__PropertyOffset_bEnableStaticProbeVolumeFilter) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001E54 RID: 7764
		// (get) Token: 0x060080FC RID: 33020 RVA: 0x000B8E44 File Offset: 0x000B7044
		// (set) Token: 0x060080FD RID: 33021 RVA: 0x000B8E54 File Offset: 0x000B7054
		public unsafe bool bEnableStaticProbeIntensityFilter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACascadeLightingVolumeActor.__PropertyOffset_bEnableStaticProbeIntensityFilter) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACascadeLightingVolumeActor.__PropertyOffset_bEnableStaticProbeIntensityFilter) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001E55 RID: 7765
		// (get) Token: 0x060080FE RID: 33022 RVA: 0x000B8E65 File Offset: 0x000B7065
		// (set) Token: 0x060080FF RID: 33023 RVA: 0x000B8E75 File Offset: 0x000B7075
		public unsafe float MinStaticProbeIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACascadeLightingVolumeActor.__PropertyOffset_MinStaticProbeIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACascadeLightingVolumeActor.__PropertyOffset_MinStaticProbeIntensity) = value;
			}
		}

		// Token: 0x17001E56 RID: 7766
		// (get) Token: 0x06008100 RID: 33024 RVA: 0x000B8E88 File Offset: 0x000B7088
		// (set) Token: 0x06008101 RID: 33025 RVA: 0x000B8EC1 File Offset: 0x000B70C1
		public TArray<AOptimizedLightVolumeActor> OptimizedLightVolumeActors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AOptimizedLightVolumeActor> result;
				if ((result = this._OptimizedLightVolumeActors) == null)
				{
					result = (this._OptimizedLightVolumeActors = new TArray<AOptimizedLightVolumeActor>(base.NativePtr + (IntPtr)ACascadeLightingVolumeActor.__PropertyOffset_OptimizedLightVolumeActors, this));
				}
				return result;
			}
			set
			{
				this.OptimizedLightVolumeActors.CopyAssign(value);
			}
		}

		// Token: 0x06008102 RID: 33026 RVA: 0x000B8ECF File Offset: 0x000B70CF
		static ACascadeLightingVolumeActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.CascadeLightingVolumeActor");
		}

		// Token: 0x06008103 RID: 33027 RVA: 0x000B8EDD File Offset: 0x000B70DD
		protected ACascadeLightingVolumeActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003DA0 RID: 15776
		public new const string __ObjectPath = "/Script/Engine.CascadeLightingVolumeActor";

		// Token: 0x04003DA1 RID: 15777
		private static IntPtr _ClassPtr;

		// Token: 0x04003DA2 RID: 15778
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003DA3 RID: 15779
		internal static int __PropertyOffset_bEnabled;

		// Token: 0x04003DA4 RID: 15780
		internal static byte __PropertyMask_bEnabled;

		// Token: 0x04003DA5 RID: 15781
		internal static int __PropertyOffset_ClvOcclusionScale;

		// Token: 0x04003DA6 RID: 15782
		internal static int __PropertyOffset_ClvIndirectLightIntensity;

		// Token: 0x04003DA7 RID: 15783
		internal static int __PropertyOffset_bBakeSkyLight;

		// Token: 0x04003DA8 RID: 15784
		internal static int __PropertyOffset_bStrictSkyLightName;

		// Token: 0x04003DA9 RID: 15785
		internal static int __PropertyOffset_BakeSkyLightIntensity;

		// Token: 0x04003DAA RID: 15786
		internal static int __PropertyOffset_BakeSkyLightColor;

		// Token: 0x04003DAB RID: 15787
		internal static int __PropertyOffset_bBakeDirectLight;

		// Token: 0x04003DAC RID: 15788
		internal static int __PropertyOffset_bStrictDirectLightName;

		// Token: 0x04003DAD RID: 15789
		internal static int __PropertyOffset_BakeDirectLightIntensity;

		// Token: 0x04003DAE RID: 15790
		internal static int __PropertyOffset_SamplesPerPixel;

		// Token: 0x04003DAF RID: 15791
		internal static int __PropertyOffset_MaxBounces;

		// Token: 0x04003DB0 RID: 15792
		internal static int __PropertyOffset_bEnableAdvancedMaterialExport;

		// Token: 0x04003DB1 RID: 15793
		internal static int __PropertyOffset_bOverrideMBDCompressEnable;

		// Token: 0x04003DB2 RID: 15794
		internal static int __PropertyOffset_bMBDCompressEnable;

		// Token: 0x04003DB3 RID: 15795
		internal static int __PropertyOffset_bBakeOptimizedLightVolumePartition;

		// Token: 0x04003DB4 RID: 15796
		internal static int __PropertyOffset_bOverrideClvProbePlacement;

		// Token: 0x04003DB5 RID: 15797
		internal static int __PropertyOffset_CascadeLightingVolumeBlockSizes;

		// Token: 0x04003DB6 RID: 15798
		[Nullable(2)]
		private TArray<float> _CascadeLightingVolumeBlockSizes;

		// Token: 0x04003DB7 RID: 15799
		internal static int __PropertyOffset_bEnableStaticProbeVolumeFilter;

		// Token: 0x04003DB8 RID: 15800
		internal static int __PropertyOffset_bEnableStaticProbeIntensityFilter;

		// Token: 0x04003DB9 RID: 15801
		internal static int __PropertyOffset_MinStaticProbeIntensity;

		// Token: 0x04003DBA RID: 15802
		internal static int __PropertyOffset_OptimizedLightVolumeActors;

		// Token: 0x04003DBB RID: 15803
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AOptimizedLightVolumeActor> _OptimizedLightVolumeActors;
	}
}
