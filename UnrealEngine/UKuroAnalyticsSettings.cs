using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020015E7 RID: 5607
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KRDataAnalyticsPlugin.KuroAnalyticsSettings")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class UKuroAnalyticsSettings : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060143A4 RID: 82852 RVA: 0x001DB3DA File Offset: 0x001D95DA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroAnalyticsSettings._ClassPtr;
		}

		// Token: 0x060143A5 RID: 82853 RVA: 0x001DB3E8 File Offset: 0x001D95E8
		public UKuroAnalyticsSettings() : this(BuiltinUtils.AllocNativeUObject(UKuroAnalyticsSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060143A6 RID: 82854 RVA: 0x001DB410 File Offset: 0x001D9610
		public UKuroAnalyticsSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroAnalyticsSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004F43 RID: 20291
		// (get) Token: 0x060143A7 RID: 82855 RVA: 0x001DB443 File Offset: 0x001D9643
		// (set) Token: 0x060143A8 RID: 82856 RVA: 0x001DB457 File Offset: 0x001D9657
		public unsafe string ServerUrl
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UKuroAnalyticsSettings.__PropertyOffset_ServerUrl)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UKuroAnalyticsSettings.__PropertyOffset_ServerUrl)), value);
			}
		}

		// Token: 0x17004F44 RID: 20292
		// (get) Token: 0x060143A9 RID: 82857 RVA: 0x001DB46C File Offset: 0x001D966C
		// (set) Token: 0x060143AA RID: 82858 RVA: 0x001DB480 File Offset: 0x001D9680
		public unsafe string AppID
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UKuroAnalyticsSettings.__PropertyOffset_AppID)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UKuroAnalyticsSettings.__PropertyOffset_AppID)), value);
			}
		}

		// Token: 0x17004F45 RID: 20293
		// (get) Token: 0x060143AB RID: 82859 RVA: 0x001DB495 File Offset: 0x001D9695
		// (set) Token: 0x060143AC RID: 82860 RVA: 0x001DB4A5 File Offset: 0x001D96A5
		public unsafe bool bEnableLog
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnalyticsSettings.__PropertyOffset_bEnableLog) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnalyticsSettings.__PropertyOffset_bEnableLog) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004F46 RID: 20294
		// (get) Token: 0x060143AD RID: 82861 RVA: 0x001DB4B6 File Offset: 0x001D96B6
		// (set) Token: 0x060143AE RID: 82862 RVA: 0x001DB4C6 File Offset: 0x001D96C6
		public unsafe bool bEnableEncrypt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnalyticsSettings.__PropertyOffset_bEnableEncrypt) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnalyticsSettings.__PropertyOffset_bEnableEncrypt) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004F47 RID: 20295
		// (get) Token: 0x060143AF RID: 82863 RVA: 0x001DB4D7 File Offset: 0x001D96D7
		// (set) Token: 0x060143B0 RID: 82864 RVA: 0x001DB4EB File Offset: 0x001D96EB
		public unsafe string EncryptPublicKey
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UKuroAnalyticsSettings.__PropertyOffset_EncryptPublicKey)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UKuroAnalyticsSettings.__PropertyOffset_EncryptPublicKey)), value);
			}
		}

		// Token: 0x17004F48 RID: 20296
		// (get) Token: 0x060143B1 RID: 82865 RVA: 0x001DB500 File Offset: 0x001D9700
		// (set) Token: 0x060143B2 RID: 82866 RVA: 0x001DB510 File Offset: 0x001D9710
		public unsafe int EncryptVersion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnalyticsSettings.__PropertyOffset_EncryptVersion);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnalyticsSettings.__PropertyOffset_EncryptVersion) = value;
			}
		}

		// Token: 0x17004F49 RID: 20297
		// (get) Token: 0x060143B3 RID: 82867 RVA: 0x001DB521 File Offset: 0x001D9721
		// (set) Token: 0x060143B4 RID: 82868 RVA: 0x001DB535 File Offset: 0x001D9735
		public unsafe string SymmetricEncryption
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UKuroAnalyticsSettings.__PropertyOffset_SymmetricEncryption)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UKuroAnalyticsSettings.__PropertyOffset_SymmetricEncryption)), value);
			}
		}

		// Token: 0x17004F4A RID: 20298
		// (get) Token: 0x060143B5 RID: 82869 RVA: 0x001DB54A File Offset: 0x001D974A
		// (set) Token: 0x060143B6 RID: 82870 RVA: 0x001DB55E File Offset: 0x001D975E
		public unsafe string AsymmetricEncryption
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UKuroAnalyticsSettings.__PropertyOffset_AsymmetricEncryption)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UKuroAnalyticsSettings.__PropertyOffset_AsymmetricEncryption)), value);
			}
		}

		// Token: 0x17004F4B RID: 20299
		// (get) Token: 0x060143B7 RID: 82871 RVA: 0x001DB573 File Offset: 0x001D9773
		// (set) Token: 0x060143B8 RID: 82872 RVA: 0x001DB583 File Offset: 0x001D9783
		public unsafe int MaxNumInBatch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnalyticsSettings.__PropertyOffset_MaxNumInBatch);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnalyticsSettings.__PropertyOffset_MaxNumInBatch) = value;
			}
		}

		// Token: 0x17004F4C RID: 20300
		// (get) Token: 0x060143B9 RID: 82873 RVA: 0x001DB594 File Offset: 0x001D9794
		// (set) Token: 0x060143BA RID: 82874 RVA: 0x001DB5A4 File Offset: 0x001D97A4
		public unsafe float FlushTimeInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnalyticsSettings.__PropertyOffset_FlushTimeInterval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnalyticsSettings.__PropertyOffset_FlushTimeInterval) = value;
			}
		}

		// Token: 0x060143BB RID: 82875 RVA: 0x001DB5B5 File Offset: 0x001D97B5
		static UKuroAnalyticsSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KRDataAnalyticsPlugin.KuroAnalyticsSettings");
		}

		// Token: 0x060143BC RID: 82876 RVA: 0x001DB5C3 File Offset: 0x001D97C3
		protected UKuroAnalyticsSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AFDF RID: 45023
		public new const string __ObjectPath = "/Script/KRDataAnalyticsPlugin.KuroAnalyticsSettings";

		// Token: 0x0400AFE0 RID: 45024
		private static IntPtr _ClassPtr;

		// Token: 0x0400AFE1 RID: 45025
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400AFE2 RID: 45026
		internal static int __PropertyOffset_ServerUrl;

		// Token: 0x0400AFE3 RID: 45027
		internal static int __PropertyOffset_AppID;

		// Token: 0x0400AFE4 RID: 45028
		internal static int __PropertyOffset_bEnableLog;

		// Token: 0x0400AFE5 RID: 45029
		internal static int __PropertyOffset_bEnableEncrypt;

		// Token: 0x0400AFE6 RID: 45030
		internal static int __PropertyOffset_EncryptPublicKey;

		// Token: 0x0400AFE7 RID: 45031
		internal static int __PropertyOffset_EncryptVersion;

		// Token: 0x0400AFE8 RID: 45032
		internal static int __PropertyOffset_SymmetricEncryption;

		// Token: 0x0400AFE9 RID: 45033
		internal static int __PropertyOffset_AsymmetricEncryption;

		// Token: 0x0400AFEA RID: 45034
		internal static int __PropertyOffset_MaxNumInBatch;

		// Token: 0x0400AFEB RID: 45035
		internal static int __PropertyOffset_FlushTimeInterval;
	}
}
