using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004E6 RID: 1254
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroTODData")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UKuroTODData : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007661 RID: 30305 RVA: 0x000ACD4A File Offset: 0x000AAF4A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroTODData._ClassPtr;
		}

		// Token: 0x06007662 RID: 30306 RVA: 0x000ACD58 File Offset: 0x000AAF58
		public UKuroTODData() : this(BuiltinUtils.AllocNativeUObject(UKuroTODData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007663 RID: 30307 RVA: 0x000ACD80 File Offset: 0x000AAF80
		public UKuroTODData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroTODData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170016D0 RID: 5840
		// (get) Token: 0x06007664 RID: 30308 RVA: 0x000ACDB4 File Offset: 0x000AAFB4
		// (set) Token: 0x06007665 RID: 30309 RVA: 0x000ACDED File Offset: 0x000AAFED
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

		// Token: 0x170016D1 RID: 5841
		// (get) Token: 0x06007666 RID: 30310 RVA: 0x000ACDFB File Offset: 0x000AAFFB
		// (set) Token: 0x06007667 RID: 30311 RVA: 0x000ACE0B File Offset: 0x000AB00B
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

		// Token: 0x170016D2 RID: 5842
		// (get) Token: 0x06007668 RID: 30312 RVA: 0x000ACE1C File Offset: 0x000AB01C
		// (set) Token: 0x06007669 RID: 30313 RVA: 0x000ACE2C File Offset: 0x000AB02C
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

		// Token: 0x170016D3 RID: 5843
		// (get) Token: 0x0600766A RID: 30314 RVA: 0x000ACE3D File Offset: 0x000AB03D
		// (set) Token: 0x0600766B RID: 30315 RVA: 0x000ACE4D File Offset: 0x000AB04D
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

		// Token: 0x170016D4 RID: 5844
		// (get) Token: 0x0600766C RID: 30316 RVA: 0x000ACE5E File Offset: 0x000AB05E
		// (set) Token: 0x0600766D RID: 30317 RVA: 0x000ACE6E File Offset: 0x000AB06E
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

		// Token: 0x170016D5 RID: 5845
		// (get) Token: 0x0600766E RID: 30318 RVA: 0x000ACE7F File Offset: 0x000AB07F
		// (set) Token: 0x0600766F RID: 30319 RVA: 0x000ACE8F File Offset: 0x000AB08F
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

		// Token: 0x170016D6 RID: 5846
		// (get) Token: 0x06007670 RID: 30320 RVA: 0x000ACEA0 File Offset: 0x000AB0A0
		// (set) Token: 0x06007671 RID: 30321 RVA: 0x000ACEB0 File Offset: 0x000AB0B0
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

		// Token: 0x170016D7 RID: 5847
		// (get) Token: 0x06007672 RID: 30322 RVA: 0x000ACEC1 File Offset: 0x000AB0C1
		// (set) Token: 0x06007673 RID: 30323 RVA: 0x000ACED1 File Offset: 0x000AB0D1
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

		// Token: 0x170016D8 RID: 5848
		// (get) Token: 0x06007674 RID: 30324 RVA: 0x000ACEE2 File Offset: 0x000AB0E2
		// (set) Token: 0x06007675 RID: 30325 RVA: 0x000ACEF2 File Offset: 0x000AB0F2
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

		// Token: 0x170016D9 RID: 5849
		// (get) Token: 0x06007676 RID: 30326 RVA: 0x000ACF03 File Offset: 0x000AB103
		// (set) Token: 0x06007677 RID: 30327 RVA: 0x000ACF13 File Offset: 0x000AB113
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

		// Token: 0x06007678 RID: 30328 RVA: 0x000ACF24 File Offset: 0x000AB124
		static UKuroTODData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroTODData");
		}

		// Token: 0x06007679 RID: 30329 RVA: 0x000ACF32 File Offset: 0x000AB132
		protected UKuroTODData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040031E3 RID: 12771
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroTODData";

		// Token: 0x040031E4 RID: 12772
		private static IntPtr _ClassPtr;

		// Token: 0x040031E5 RID: 12773
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040031E6 RID: 12774
		internal static int __PropertyOffset_TODConfigs;

		// Token: 0x040031E7 RID: 12775
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UKuroWeatherDataAsset> _TODConfigs;

		// Token: 0x040031E8 RID: 12776
		internal static int __PropertyOffset_bSpecialBlend;

		// Token: 0x040031E9 RID: 12777
		internal static int __PropertyOffset_bPolarDaynight;

		// Token: 0x040031EA RID: 12778
		internal static int __PropertyOffset_FixedSunHorizonAngle;

		// Token: 0x040031EB RID: 12779
		internal static int __PropertyOffset_FixedSunVerticalAngle;

		// Token: 0x040031EC RID: 12780
		internal static int __PropertyOffset_FixedTime;

		// Token: 0x040031ED RID: 12781
		internal static int __PropertyOffset_bDayNightSwitchInPolarDayNight;

		// Token: 0x040031EE RID: 12782
		internal static int __PropertyOffset_bCustomSunDirection;

		// Token: 0x040031EF RID: 12783
		internal static int __PropertyOffset_TODSunHorizonAngle;

		// Token: 0x040031F0 RID: 12784
		internal static int __PropertyOffset_TODSunVerticalAngle;
	}
}
