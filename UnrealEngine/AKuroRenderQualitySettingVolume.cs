using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BA1 RID: 7073
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroRenderQualitySettingVolume")]
	[UnrealStructLayout(1304, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1304)]
	public class AKuroRenderQualitySettingVolume : AVolume, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601B0D2 RID: 110802 RVA: 0x0027DB31 File Offset: 0x0027BD31
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroRenderQualitySettingVolume._ClassPtr;
		}

		// Token: 0x0601B0D3 RID: 110803 RVA: 0x0027DB40 File Offset: 0x0027BD40
		public AKuroRenderQualitySettingVolume() : this(BuiltinUtils.AllocNativeUObject(AKuroRenderQualitySettingVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601B0D4 RID: 110804 RVA: 0x0027DB68 File Offset: 0x0027BD68
		public AKuroRenderQualitySettingVolume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroRenderQualitySettingVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006C6B RID: 27755
		// (get) Token: 0x0601B0D5 RID: 110805 RVA: 0x0027DB9B File Offset: 0x0027BD9B
		// (set) Token: 0x0601B0D6 RID: 110806 RVA: 0x0027DBAF File Offset: 0x0027BDAF
		public unsafe string VolumeName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)AKuroRenderQualitySettingVolume.__PropertyOffset_VolumeName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)AKuroRenderQualitySettingVolume.__PropertyOffset_VolumeName)), value);
			}
		}

		// Token: 0x17006C6C RID: 27756
		// (get) Token: 0x0601B0D7 RID: 110807 RVA: 0x0027DBC4 File Offset: 0x0027BDC4
		// (set) Token: 0x0601B0D8 RID: 110808 RVA: 0x0027DBD4 File Offset: 0x0027BDD4
		public unsafe int Priority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroRenderQualitySettingVolume.__PropertyOffset_Priority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroRenderQualitySettingVolume.__PropertyOffset_Priority) = value;
			}
		}

		// Token: 0x17006C6D RID: 27757
		// (get) Token: 0x0601B0D9 RID: 110809 RVA: 0x0027DBE5 File Offset: 0x0027BDE5
		// (set) Token: 0x0601B0DA RID: 110810 RVA: 0x0027DBF9 File Offset: 0x0027BDF9
		[Nullable(2)]
		public unsafe UKuroLocalRenderQualitySetting LocalRenderQualitySettingDataAsset
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroLocalRenderQualitySetting>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroRenderQualitySettingVolume.__PropertyOffset_LocalRenderQualitySettingDataAsset);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroRenderQualitySettingVolume.__PropertyOffset_LocalRenderQualitySettingDataAsset, value);
			}
		}

		// Token: 0x17006C6E RID: 27758
		// (get) Token: 0x0601B0DB RID: 110811 RVA: 0x0027DC0E File Offset: 0x0027BE0E
		// (set) Token: 0x0601B0DC RID: 110812 RVA: 0x0027DC1E File Offset: 0x0027BE1E
		public unsafe bool EnableVolumeLightDistanceCullMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroRenderQualitySettingVolume.__PropertyOffset_EnableVolumeLightDistanceCullMode) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroRenderQualitySettingVolume.__PropertyOffset_EnableVolumeLightDistanceCullMode) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006C6F RID: 27759
		// (get) Token: 0x0601B0DD RID: 110813 RVA: 0x0027DC2F File Offset: 0x0027BE2F
		// (set) Token: 0x0601B0DE RID: 110814 RVA: 0x0027DC3F File Offset: 0x0027BE3F
		public unsafe bool DrawVisualizationForLightCullDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroRenderQualitySettingVolume.__PropertyOffset_DrawVisualizationForLightCullDistance) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroRenderQualitySettingVolume.__PropertyOffset_DrawVisualizationForLightCullDistance) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006C70 RID: 27760
		// (get) Token: 0x0601B0DF RID: 110815 RVA: 0x0027DC50 File Offset: 0x0027BE50
		// (set) Token: 0x0601B0E0 RID: 110816 RVA: 0x0027DC60 File Offset: 0x0027BE60
		public unsafe float PCVolumeLightCullDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroRenderQualitySettingVolume.__PropertyOffset_PCVolumeLightCullDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroRenderQualitySettingVolume.__PropertyOffset_PCVolumeLightCullDistance) = value;
			}
		}

		// Token: 0x17006C71 RID: 27761
		// (get) Token: 0x0601B0E1 RID: 110817 RVA: 0x0027DC71 File Offset: 0x0027BE71
		// (set) Token: 0x0601B0E2 RID: 110818 RVA: 0x0027DC81 File Offset: 0x0027BE81
		public unsafe float MobileVolumeLightCullDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroRenderQualitySettingVolume.__PropertyOffset_MobileVolumeLightCullDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroRenderQualitySettingVolume.__PropertyOffset_MobileVolumeLightCullDistance) = value;
			}
		}

		// Token: 0x17006C72 RID: 27762
		// (get) Token: 0x0601B0E3 RID: 110819 RVA: 0x0027DC94 File Offset: 0x0027BE94
		// (set) Token: 0x0601B0E4 RID: 110820 RVA: 0x0027DCCD File Offset: 0x0027BECD
		public TMap<string, string> OriginalCVarValues
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, string> result;
				if ((result = this._OriginalCVarValues) == null)
				{
					result = (this._OriginalCVarValues = new TMap<string, string>(base.NativePtr + (IntPtr)AKuroRenderQualitySettingVolume.__PropertyOffset_OriginalCVarValues, this));
				}
				return result;
			}
			set
			{
				this.OriginalCVarValues.CopyAssign(value);
			}
		}

		// Token: 0x0601B0E5 RID: 110821 RVA: 0x0027DCDB File Offset: 0x0027BEDB
		static AKuroRenderQualitySettingVolume()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroRenderQualitySettingVolume");
		}

		// Token: 0x0601B0E6 RID: 110822 RVA: 0x0027DCE9 File Offset: 0x0027BEE9
		protected AKuroRenderQualitySettingVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E905 RID: 59653
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroRenderQualitySettingVolume";

		// Token: 0x0400E906 RID: 59654
		private static IntPtr _ClassPtr;

		// Token: 0x0400E907 RID: 59655
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E908 RID: 59656
		internal static int __PropertyOffset_VolumeName;

		// Token: 0x0400E909 RID: 59657
		internal static int __PropertyOffset_Priority;

		// Token: 0x0400E90A RID: 59658
		internal static int __PropertyOffset_LocalRenderQualitySettingDataAsset;

		// Token: 0x0400E90B RID: 59659
		internal static int __PropertyOffset_EnableVolumeLightDistanceCullMode;

		// Token: 0x0400E90C RID: 59660
		internal static int __PropertyOffset_DrawVisualizationForLightCullDistance;

		// Token: 0x0400E90D RID: 59661
		internal static int __PropertyOffset_PCVolumeLightCullDistance;

		// Token: 0x0400E90E RID: 59662
		internal static int __PropertyOffset_MobileVolumeLightCullDistance;

		// Token: 0x0400E90F RID: 59663
		internal static int __PropertyOffset_OriginalCVarValues;

		// Token: 0x0400E910 RID: 59664
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, string> _OriginalCVarValues;
	}
}
