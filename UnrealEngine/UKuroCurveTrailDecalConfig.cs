using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001AD6 RID: 6870
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroCurveTrailDecalConfig")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UKuroCurveTrailDecalConfig : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06019967 RID: 104807 RVA: 0x0025D36F File Offset: 0x0025B56F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroCurveTrailDecalConfig._ClassPtr;
		}

		// Token: 0x06019968 RID: 104808 RVA: 0x0025D37C File Offset: 0x0025B57C
		public UKuroCurveTrailDecalConfig() : this(BuiltinUtils.AllocNativeUObject(UKuroCurveTrailDecalConfig.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06019969 RID: 104809 RVA: 0x0025D3A4 File Offset: 0x0025B5A4
		[NullableContext(1)]
		public UKuroCurveTrailDecalConfig(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroCurveTrailDecalConfig.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700662F RID: 26159
		// (get) Token: 0x0601996A RID: 104810 RVA: 0x0025D3D7 File Offset: 0x0025B5D7
		// (set) Token: 0x0601996B RID: 104811 RVA: 0x0025D3EB File Offset: 0x0025B5EB
		[Nullable(2)]
		public unsafe UMaterialInterface Material
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroCurveTrailDecalConfig.__PropertyOffset_Material);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroCurveTrailDecalConfig.__PropertyOffset_Material, value);
			}
		}

		// Token: 0x17006630 RID: 26160
		// (get) Token: 0x0601996C RID: 104812 RVA: 0x0025D400 File Offset: 0x0025B600
		// (set) Token: 0x0601996D RID: 104813 RVA: 0x0025D410 File Offset: 0x0025B610
		public unsafe bool DoTrace
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCurveTrailDecalConfig.__PropertyOffset_DoTrace) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCurveTrailDecalConfig.__PropertyOffset_DoTrace) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006631 RID: 26161
		// (get) Token: 0x0601996E RID: 104814 RVA: 0x0025D421 File Offset: 0x0025B621
		// (set) Token: 0x0601996F RID: 104815 RVA: 0x0025D435 File Offset: 0x0025B635
		public unsafe FVector TraceStartLocal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCurveTrailDecalConfig.__PropertyOffset_TraceStartLocal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCurveTrailDecalConfig.__PropertyOffset_TraceStartLocal) = value;
			}
		}

		// Token: 0x17006632 RID: 26162
		// (get) Token: 0x06019970 RID: 104816 RVA: 0x0025D44A File Offset: 0x0025B64A
		// (set) Token: 0x06019971 RID: 104817 RVA: 0x0025D45E File Offset: 0x0025B65E
		public unsafe FVector TraceEndLocal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCurveTrailDecalConfig.__PropertyOffset_TraceEndLocal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCurveTrailDecalConfig.__PropertyOffset_TraceEndLocal) = value;
			}
		}

		// Token: 0x17006633 RID: 26163
		// (get) Token: 0x06019972 RID: 104818 RVA: 0x0025D473 File Offset: 0x0025B673
		// (set) Token: 0x06019973 RID: 104819 RVA: 0x0025D483 File Offset: 0x0025B683
		public unsafe float TraceRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCurveTrailDecalConfig.__PropertyOffset_TraceRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCurveTrailDecalConfig.__PropertyOffset_TraceRadius) = value;
			}
		}

		// Token: 0x17006634 RID: 26164
		// (get) Token: 0x06019974 RID: 104820 RVA: 0x0025D494 File Offset: 0x0025B694
		// (set) Token: 0x06019975 RID: 104821 RVA: 0x0025D4A4 File Offset: 0x0025B6A4
		public unsafe float TraceCorrect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCurveTrailDecalConfig.__PropertyOffset_TraceCorrect);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCurveTrailDecalConfig.__PropertyOffset_TraceCorrect) = value;
			}
		}

		// Token: 0x17006635 RID: 26165
		// (get) Token: 0x06019976 RID: 104822 RVA: 0x0025D4B5 File Offset: 0x0025B6B5
		// (set) Token: 0x06019977 RID: 104823 RVA: 0x0025D4C5 File Offset: 0x0025B6C5
		public unsafe float SpawnThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCurveTrailDecalConfig.__PropertyOffset_SpawnThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCurveTrailDecalConfig.__PropertyOffset_SpawnThreshold) = value;
			}
		}

		// Token: 0x17006636 RID: 26166
		// (get) Token: 0x06019978 RID: 104824 RVA: 0x0025D4D6 File Offset: 0x0025B6D6
		// (set) Token: 0x06019979 RID: 104825 RVA: 0x0025D4E6 File Offset: 0x0025B6E6
		public unsafe float CurveLifeTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCurveTrailDecalConfig.__PropertyOffset_CurveLifeTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCurveTrailDecalConfig.__PropertyOffset_CurveLifeTime) = value;
			}
		}

		// Token: 0x17006637 RID: 26167
		// (get) Token: 0x0601997A RID: 104826 RVA: 0x0025D4F7 File Offset: 0x0025B6F7
		// (set) Token: 0x0601997B RID: 104827 RVA: 0x0025D507 File Offset: 0x0025B707
		public unsafe float MinRecycleTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCurveTrailDecalConfig.__PropertyOffset_MinRecycleTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCurveTrailDecalConfig.__PropertyOffset_MinRecycleTime) = value;
			}
		}

		// Token: 0x0601997C RID: 104828 RVA: 0x0025D518 File Offset: 0x0025B718
		static UKuroCurveTrailDecalConfig()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroCurveTrailDecalConfig");
		}

		// Token: 0x0601997D RID: 104829 RVA: 0x0025D526 File Offset: 0x0025B726
		protected UKuroCurveTrailDecalConfig(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400DED8 RID: 57048
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroCurveTrailDecalConfig";

		// Token: 0x0400DED9 RID: 57049
		private static IntPtr _ClassPtr;

		// Token: 0x0400DEDA RID: 57050
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400DEDB RID: 57051
		internal static int __PropertyOffset_Material;

		// Token: 0x0400DEDC RID: 57052
		internal static int __PropertyOffset_DoTrace;

		// Token: 0x0400DEDD RID: 57053
		internal static int __PropertyOffset_TraceStartLocal;

		// Token: 0x0400DEDE RID: 57054
		internal static int __PropertyOffset_TraceEndLocal;

		// Token: 0x0400DEDF RID: 57055
		internal static int __PropertyOffset_TraceRadius;

		// Token: 0x0400DEE0 RID: 57056
		internal static int __PropertyOffset_TraceCorrect;

		// Token: 0x0400DEE1 RID: 57057
		internal static int __PropertyOffset_SpawnThreshold;

		// Token: 0x0400DEE2 RID: 57058
		internal static int __PropertyOffset_CurveLifeTime;

		// Token: 0x0400DEE3 RID: 57059
		internal static int __PropertyOffset_MinRecycleTime;
	}
}
