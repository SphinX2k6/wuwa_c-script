using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BD0 RID: 7120
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroTODData")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UKuroTODData : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601B539 RID: 111929 RVA: 0x00284248 File Offset: 0x00282448
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroTODData._ClassPtr;
		}

		// Token: 0x0601B53A RID: 111930 RVA: 0x00284254 File Offset: 0x00282454
		public UKuroTODData() : this(BuiltinUtils.AllocNativeUObject(UKuroTODData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601B53B RID: 111931 RVA: 0x0028427C File Offset: 0x0028247C
		public UKuroTODData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroTODData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006DCC RID: 28108
		// (get) Token: 0x0601B53C RID: 111932 RVA: 0x002842B0 File Offset: 0x002824B0
		// (set) Token: 0x0601B53D RID: 111933 RVA: 0x002842E9 File Offset: 0x002824E9
		public TArray<FKuroTODEntryData> EntryDatas
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroTODEntryData> result;
				if ((result = this._EntryDatas) == null)
				{
					result = (this._EntryDatas = new TArray<FKuroTODEntryData>(base.NativePtr + (IntPtr)UKuroTODData.__PropertyOffset_EntryDatas, this));
				}
				return result;
			}
			set
			{
				this.EntryDatas.CopyAssign(value);
			}
		}

		// Token: 0x17006DCD RID: 28109
		// (get) Token: 0x0601B53E RID: 111934 RVA: 0x002842F8 File Offset: 0x002824F8
		// (set) Token: 0x0601B53F RID: 111935 RVA: 0x00284331 File Offset: 0x00282531
		public TArray<UKuroWeatherDataAsset> TODConfigs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UKuroWeatherDataAsset> result;
				if ((result = this._TODConfigs) == null)
				{
					result = (this._TODConfigs = new TArray<UKuroWeatherDataAsset>(base.NativePtr + (IntPtr)UKuroTODData.__PropertyOffset_TODConfigs, this));
				}
				return result;
			}
			set
			{
				this.TODConfigs.CopyAssign(value);
			}
		}

		// Token: 0x17006DCE RID: 28110
		// (get) Token: 0x0601B540 RID: 111936 RVA: 0x0028433F File Offset: 0x0028253F
		// (set) Token: 0x0601B541 RID: 111937 RVA: 0x0028434F File Offset: 0x0028254F
		public unsafe bool bSpecialBlend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroTODData.__PropertyOffset_bSpecialBlend) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroTODData.__PropertyOffset_bSpecialBlend) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006DCF RID: 28111
		// (get) Token: 0x0601B542 RID: 111938 RVA: 0x00284360 File Offset: 0x00282560
		// (set) Token: 0x0601B543 RID: 111939 RVA: 0x00284370 File Offset: 0x00282570
		public unsafe bool bPolarDaynight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroTODData.__PropertyOffset_bPolarDaynight) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroTODData.__PropertyOffset_bPolarDaynight) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006DD0 RID: 28112
		// (get) Token: 0x0601B544 RID: 111940 RVA: 0x00284381 File Offset: 0x00282581
		// (set) Token: 0x0601B545 RID: 111941 RVA: 0x00284391 File Offset: 0x00282591
		public unsafe float FixedSunHorizonAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroTODData.__PropertyOffset_FixedSunHorizonAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroTODData.__PropertyOffset_FixedSunHorizonAngle) = value;
			}
		}

		// Token: 0x17006DD1 RID: 28113
		// (get) Token: 0x0601B546 RID: 111942 RVA: 0x002843A2 File Offset: 0x002825A2
		// (set) Token: 0x0601B547 RID: 111943 RVA: 0x002843B2 File Offset: 0x002825B2
		public unsafe float FixedSunVerticalAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroTODData.__PropertyOffset_FixedSunVerticalAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroTODData.__PropertyOffset_FixedSunVerticalAngle) = value;
			}
		}

		// Token: 0x17006DD2 RID: 28114
		// (get) Token: 0x0601B548 RID: 111944 RVA: 0x002843C3 File Offset: 0x002825C3
		// (set) Token: 0x0601B549 RID: 111945 RVA: 0x002843D3 File Offset: 0x002825D3
		public unsafe float FixedTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroTODData.__PropertyOffset_FixedTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroTODData.__PropertyOffset_FixedTime) = value;
			}
		}

		// Token: 0x17006DD3 RID: 28115
		// (get) Token: 0x0601B54A RID: 111946 RVA: 0x002843E4 File Offset: 0x002825E4
		// (set) Token: 0x0601B54B RID: 111947 RVA: 0x002843F4 File Offset: 0x002825F4
		public unsafe bool bDayNightSwitchInPolarDayNight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroTODData.__PropertyOffset_bDayNightSwitchInPolarDayNight) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroTODData.__PropertyOffset_bDayNightSwitchInPolarDayNight) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006DD4 RID: 28116
		// (get) Token: 0x0601B54C RID: 111948 RVA: 0x00284405 File Offset: 0x00282605
		// (set) Token: 0x0601B54D RID: 111949 RVA: 0x00284415 File Offset: 0x00282615
		public unsafe bool bCustomSunDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroTODData.__PropertyOffset_bCustomSunDirection) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroTODData.__PropertyOffset_bCustomSunDirection) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006DD5 RID: 28117
		// (get) Token: 0x0601B54E RID: 111950 RVA: 0x00284426 File Offset: 0x00282626
		// (set) Token: 0x0601B54F RID: 111951 RVA: 0x00284436 File Offset: 0x00282636
		public unsafe float TODSunHorizonAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroTODData.__PropertyOffset_TODSunHorizonAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroTODData.__PropertyOffset_TODSunHorizonAngle) = value;
			}
		}

		// Token: 0x17006DD6 RID: 28118
		// (get) Token: 0x0601B550 RID: 111952 RVA: 0x00284447 File Offset: 0x00282647
		// (set) Token: 0x0601B551 RID: 111953 RVA: 0x00284457 File Offset: 0x00282657
		public unsafe float TODSunVerticalAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroTODData.__PropertyOffset_TODSunVerticalAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroTODData.__PropertyOffset_TODSunVerticalAngle) = value;
			}
		}

		// Token: 0x0601B552 RID: 111954 RVA: 0x00284468 File Offset: 0x00282668
		static UKuroTODData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroTODData");
		}

		// Token: 0x0601B553 RID: 111955 RVA: 0x00284476 File Offset: 0x00282676
		protected UKuroTODData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400EB68 RID: 60264
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroTODData";

		// Token: 0x0400EB69 RID: 60265
		private static IntPtr _ClassPtr;

		// Token: 0x0400EB6A RID: 60266
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400EB6B RID: 60267
		internal static int __PropertyOffset_EntryDatas;

		// Token: 0x0400EB6C RID: 60268
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroTODEntryData> _EntryDatas;

		// Token: 0x0400EB6D RID: 60269
		internal static int __PropertyOffset_TODConfigs;

		// Token: 0x0400EB6E RID: 60270
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UKuroWeatherDataAsset> _TODConfigs;

		// Token: 0x0400EB6F RID: 60271
		internal static int __PropertyOffset_bSpecialBlend;

		// Token: 0x0400EB70 RID: 60272
		internal static int __PropertyOffset_bPolarDaynight;

		// Token: 0x0400EB71 RID: 60273
		internal static int __PropertyOffset_FixedSunHorizonAngle;

		// Token: 0x0400EB72 RID: 60274
		internal static int __PropertyOffset_FixedSunVerticalAngle;

		// Token: 0x0400EB73 RID: 60275
		internal static int __PropertyOffset_FixedTime;

		// Token: 0x0400EB74 RID: 60276
		internal static int __PropertyOffset_bDayNightSwitchInPolarDayNight;

		// Token: 0x0400EB75 RID: 60277
		internal static int __PropertyOffset_bCustomSunDirection;

		// Token: 0x0400EB76 RID: 60278
		internal static int __PropertyOffset_TODSunHorizonAngle;

		// Token: 0x0400EB77 RID: 60279
		internal static int __PropertyOffset_TODSunVerticalAngle;
	}
}
