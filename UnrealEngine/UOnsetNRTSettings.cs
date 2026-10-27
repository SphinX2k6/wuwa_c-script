using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000393 RID: 915
	[UnrealObjectPath("/Script/AudioSynesthesia.OnsetNRTSettings")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UOnsetNRTSettings : UAudioSynesthesiaNRTSettings, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600324C RID: 12876 RVA: 0x0004D97B File Offset: 0x0004BB7B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UOnsetNRTSettings._ClassPtr;
		}

		// Token: 0x0600324D RID: 12877 RVA: 0x0004D988 File Offset: 0x0004BB88
		public UOnsetNRTSettings() : this(BuiltinUtils.AllocNativeUObject(UOnsetNRTSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600324E RID: 12878 RVA: 0x0004D9B0 File Offset: 0x0004BBB0
		[NullableContext(1)]
		public UOnsetNRTSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UOnsetNRTSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000C44 RID: 3140
		// (get) Token: 0x0600324F RID: 12879 RVA: 0x0004D9E3 File Offset: 0x0004BBE3
		// (set) Token: 0x06003250 RID: 12880 RVA: 0x0004D9F3 File Offset: 0x0004BBF3
		public unsafe bool bDownmixToMono
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UOnsetNRTSettings.__PropertyOffset_bDownmixToMono) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UOnsetNRTSettings.__PropertyOffset_bDownmixToMono) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000C45 RID: 3141
		// (get) Token: 0x06003251 RID: 12881 RVA: 0x0004DA04 File Offset: 0x0004BC04
		// (set) Token: 0x06003252 RID: 12882 RVA: 0x0004DA14 File Offset: 0x0004BC14
		public unsafe float GranularityInSeconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UOnsetNRTSettings.__PropertyOffset_GranularityInSeconds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UOnsetNRTSettings.__PropertyOffset_GranularityInSeconds) = value;
			}
		}

		// Token: 0x17000C46 RID: 3142
		// (get) Token: 0x06003253 RID: 12883 RVA: 0x0004DA25 File Offset: 0x0004BC25
		// (set) Token: 0x06003254 RID: 12884 RVA: 0x0004DA35 File Offset: 0x0004BC35
		public unsafe float Sensitivity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UOnsetNRTSettings.__PropertyOffset_Sensitivity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UOnsetNRTSettings.__PropertyOffset_Sensitivity) = value;
			}
		}

		// Token: 0x17000C47 RID: 3143
		// (get) Token: 0x06003255 RID: 12885 RVA: 0x0004DA46 File Offset: 0x0004BC46
		// (set) Token: 0x06003256 RID: 12886 RVA: 0x0004DA56 File Offset: 0x0004BC56
		public unsafe float MinimumFrequency
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UOnsetNRTSettings.__PropertyOffset_MinimumFrequency);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UOnsetNRTSettings.__PropertyOffset_MinimumFrequency) = value;
			}
		}

		// Token: 0x17000C48 RID: 3144
		// (get) Token: 0x06003257 RID: 12887 RVA: 0x0004DA67 File Offset: 0x0004BC67
		// (set) Token: 0x06003258 RID: 12888 RVA: 0x0004DA77 File Offset: 0x0004BC77
		public unsafe float MaximumFrequency
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UOnsetNRTSettings.__PropertyOffset_MaximumFrequency);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UOnsetNRTSettings.__PropertyOffset_MaximumFrequency) = value;
			}
		}

		// Token: 0x06003259 RID: 12889 RVA: 0x0004DA88 File Offset: 0x0004BC88
		static UOnsetNRTSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AudioSynesthesia.OnsetNRTSettings");
		}

		// Token: 0x0600325A RID: 12890 RVA: 0x0004DA96 File Offset: 0x0004BC96
		protected UOnsetNRTSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001610 RID: 5648
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AudioSynesthesia.OnsetNRTSettings";

		// Token: 0x04001611 RID: 5649
		private static IntPtr _ClassPtr;

		// Token: 0x04001612 RID: 5650
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001613 RID: 5651
		internal static int __PropertyOffset_bDownmixToMono;

		// Token: 0x04001614 RID: 5652
		internal static int __PropertyOffset_GranularityInSeconds;

		// Token: 0x04001615 RID: 5653
		internal static int __PropertyOffset_Sensitivity;

		// Token: 0x04001616 RID: 5654
		internal static int __PropertyOffset_MinimumFrequency;

		// Token: 0x04001617 RID: 5655
		internal static int __PropertyOffset_MaximumFrequency;
	}
}
