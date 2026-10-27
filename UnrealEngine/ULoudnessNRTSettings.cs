using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000391 RID: 913
	[UnrealObjectPath("/Script/AudioSynesthesia.LoudnessNRTSettings")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class ULoudnessNRTSettings : UAudioSynesthesiaNRTSettings, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003232 RID: 12850 RVA: 0x0004D74A File Offset: 0x0004B94A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULoudnessNRTSettings._ClassPtr;
		}

		// Token: 0x06003233 RID: 12851 RVA: 0x0004D758 File Offset: 0x0004B958
		public ULoudnessNRTSettings() : this(BuiltinUtils.AllocNativeUObject(ULoudnessNRTSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003234 RID: 12852 RVA: 0x0004D780 File Offset: 0x0004B980
		[NullableContext(1)]
		public ULoudnessNRTSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULoudnessNRTSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000C3E RID: 3134
		// (get) Token: 0x06003235 RID: 12853 RVA: 0x0004D7B3 File Offset: 0x0004B9B3
		// (set) Token: 0x06003236 RID: 12854 RVA: 0x0004D7C3 File Offset: 0x0004B9C3
		public unsafe float AnalysisPeriod
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULoudnessNRTSettings.__PropertyOffset_AnalysisPeriod);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULoudnessNRTSettings.__PropertyOffset_AnalysisPeriod) = value;
			}
		}

		// Token: 0x17000C3F RID: 3135
		// (get) Token: 0x06003237 RID: 12855 RVA: 0x0004D7D4 File Offset: 0x0004B9D4
		// (set) Token: 0x06003238 RID: 12856 RVA: 0x0004D7E4 File Offset: 0x0004B9E4
		public unsafe float MinimumFrequency
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULoudnessNRTSettings.__PropertyOffset_MinimumFrequency);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULoudnessNRTSettings.__PropertyOffset_MinimumFrequency) = value;
			}
		}

		// Token: 0x17000C40 RID: 3136
		// (get) Token: 0x06003239 RID: 12857 RVA: 0x0004D7F5 File Offset: 0x0004B9F5
		// (set) Token: 0x0600323A RID: 12858 RVA: 0x0004D805 File Offset: 0x0004BA05
		public unsafe float MaximumFrequency
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULoudnessNRTSettings.__PropertyOffset_MaximumFrequency);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULoudnessNRTSettings.__PropertyOffset_MaximumFrequency) = value;
			}
		}

		// Token: 0x17000C41 RID: 3137
		// (get) Token: 0x0600323B RID: 12859 RVA: 0x0004D816 File Offset: 0x0004BA16
		// (set) Token: 0x0600323C RID: 12860 RVA: 0x0004D826 File Offset: 0x0004BA26
		public unsafe ELoudnessNRTCurveTypeEnum CurveType
		{
			get
			{
				return (ELoudnessNRTCurveTypeEnum)(*(base.NativePtr + (IntPtr)ULoudnessNRTSettings.__PropertyOffset_CurveType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULoudnessNRTSettings.__PropertyOffset_CurveType) = (byte)value;
			}
		}

		// Token: 0x17000C42 RID: 3138
		// (get) Token: 0x0600323D RID: 12861 RVA: 0x0004D837 File Offset: 0x0004BA37
		// (set) Token: 0x0600323E RID: 12862 RVA: 0x0004D847 File Offset: 0x0004BA47
		public unsafe float NoiseFloorDb
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULoudnessNRTSettings.__PropertyOffset_NoiseFloorDb);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULoudnessNRTSettings.__PropertyOffset_NoiseFloorDb) = value;
			}
		}

		// Token: 0x0600323F RID: 12863 RVA: 0x0004D858 File Offset: 0x0004BA58
		static ULoudnessNRTSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AudioSynesthesia.LoudnessNRTSettings");
		}

		// Token: 0x06003240 RID: 12864 RVA: 0x0004D866 File Offset: 0x0004BA66
		protected ULoudnessNRTSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001604 RID: 5636
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AudioSynesthesia.LoudnessNRTSettings";

		// Token: 0x04001605 RID: 5637
		private static IntPtr _ClassPtr;

		// Token: 0x04001606 RID: 5638
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001607 RID: 5639
		internal static int __PropertyOffset_AnalysisPeriod;

		// Token: 0x04001608 RID: 5640
		internal static int __PropertyOffset_MinimumFrequency;

		// Token: 0x04001609 RID: 5641
		internal static int __PropertyOffset_MaximumFrequency;

		// Token: 0x0400160A RID: 5642
		internal static int __PropertyOffset_CurveType;

		// Token: 0x0400160B RID: 5643
		internal static int __PropertyOffset_NoiseFloorDb;
	}
}
