using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002901 RID: 10497
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/TASdkPlugin.ThinkingAnalyticsSettings")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class UThinkingAnalyticsSettings : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026EFB RID: 159483 RVA: 0x003B6362 File Offset: 0x003B4562
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UThinkingAnalyticsSettings._ClassPtr;
		}

		// Token: 0x06026EFC RID: 159484 RVA: 0x003B6370 File Offset: 0x003B4570
		public UThinkingAnalyticsSettings() : this(BuiltinUtils.AllocNativeUObject(UThinkingAnalyticsSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026EFD RID: 159485 RVA: 0x003B6398 File Offset: 0x003B4598
		public UThinkingAnalyticsSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UThinkingAnalyticsSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170095ED RID: 38381
		// (get) Token: 0x06026EFE RID: 159486 RVA: 0x003B63CB File Offset: 0x003B45CB
		// (set) Token: 0x06026EFF RID: 159487 RVA: 0x003B63DF File Offset: 0x003B45DF
		public unsafe string ServerUrl
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UThinkingAnalyticsSettings.__PropertyOffset_ServerUrl)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UThinkingAnalyticsSettings.__PropertyOffset_ServerUrl)), value);
			}
		}

		// Token: 0x170095EE RID: 38382
		// (get) Token: 0x06026F00 RID: 159488 RVA: 0x003B63F4 File Offset: 0x003B45F4
		// (set) Token: 0x06026F01 RID: 159489 RVA: 0x003B6408 File Offset: 0x003B4608
		public unsafe string AppID
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UThinkingAnalyticsSettings.__PropertyOffset_AppID)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UThinkingAnalyticsSettings.__PropertyOffset_AppID)), value);
			}
		}

		// Token: 0x170095EF RID: 38383
		// (get) Token: 0x06026F02 RID: 159490 RVA: 0x003B641D File Offset: 0x003B461D
		// (set) Token: 0x06026F03 RID: 159491 RVA: 0x003B642D File Offset: 0x003B462D
		public unsafe bool bEnableLog
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UThinkingAnalyticsSettings.__PropertyOffset_bEnableLog) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UThinkingAnalyticsSettings.__PropertyOffset_bEnableLog) = (value ? 1 : 0);
			}
		}

		// Token: 0x170095F0 RID: 38384
		// (get) Token: 0x06026F04 RID: 159492 RVA: 0x003B643E File Offset: 0x003B463E
		// (set) Token: 0x06026F05 RID: 159493 RVA: 0x003B644E File Offset: 0x003B464E
		public unsafe bool bEnableEncrypt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UThinkingAnalyticsSettings.__PropertyOffset_bEnableEncrypt) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UThinkingAnalyticsSettings.__PropertyOffset_bEnableEncrypt) = (value ? 1 : 0);
			}
		}

		// Token: 0x170095F1 RID: 38385
		// (get) Token: 0x06026F06 RID: 159494 RVA: 0x003B645F File Offset: 0x003B465F
		// (set) Token: 0x06026F07 RID: 159495 RVA: 0x003B6473 File Offset: 0x003B4673
		public unsafe string EncryptPublicKey
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UThinkingAnalyticsSettings.__PropertyOffset_EncryptPublicKey)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UThinkingAnalyticsSettings.__PropertyOffset_EncryptPublicKey)), value);
			}
		}

		// Token: 0x170095F2 RID: 38386
		// (get) Token: 0x06026F08 RID: 159496 RVA: 0x003B6488 File Offset: 0x003B4688
		// (set) Token: 0x06026F09 RID: 159497 RVA: 0x003B6498 File Offset: 0x003B4698
		public unsafe int EncryptVersion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UThinkingAnalyticsSettings.__PropertyOffset_EncryptVersion);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UThinkingAnalyticsSettings.__PropertyOffset_EncryptVersion) = value;
			}
		}

		// Token: 0x170095F3 RID: 38387
		// (get) Token: 0x06026F0A RID: 159498 RVA: 0x003B64A9 File Offset: 0x003B46A9
		// (set) Token: 0x06026F0B RID: 159499 RVA: 0x003B64BD File Offset: 0x003B46BD
		public unsafe string SymmetricEncryption
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UThinkingAnalyticsSettings.__PropertyOffset_SymmetricEncryption)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UThinkingAnalyticsSettings.__PropertyOffset_SymmetricEncryption)), value);
			}
		}

		// Token: 0x170095F4 RID: 38388
		// (get) Token: 0x06026F0C RID: 159500 RVA: 0x003B64D2 File Offset: 0x003B46D2
		// (set) Token: 0x06026F0D RID: 159501 RVA: 0x003B64E6 File Offset: 0x003B46E6
		public unsafe string AsymmetricEncryption
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UThinkingAnalyticsSettings.__PropertyOffset_AsymmetricEncryption)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UThinkingAnalyticsSettings.__PropertyOffset_AsymmetricEncryption)), value);
			}
		}

		// Token: 0x170095F5 RID: 38389
		// (get) Token: 0x06026F0E RID: 159502 RVA: 0x003B64FB File Offset: 0x003B46FB
		// (set) Token: 0x06026F0F RID: 159503 RVA: 0x003B650B File Offset: 0x003B470B
		public unsafe int MaxNumInBatch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UThinkingAnalyticsSettings.__PropertyOffset_MaxNumInBatch);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UThinkingAnalyticsSettings.__PropertyOffset_MaxNumInBatch) = value;
			}
		}

		// Token: 0x170095F6 RID: 38390
		// (get) Token: 0x06026F10 RID: 159504 RVA: 0x003B651C File Offset: 0x003B471C
		// (set) Token: 0x06026F11 RID: 159505 RVA: 0x003B652C File Offset: 0x003B472C
		public unsafe float FlushTimeInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UThinkingAnalyticsSettings.__PropertyOffset_FlushTimeInterval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UThinkingAnalyticsSettings.__PropertyOffset_FlushTimeInterval) = value;
			}
		}

		// Token: 0x06026F12 RID: 159506 RVA: 0x003B653D File Offset: 0x003B473D
		static UThinkingAnalyticsSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/TASdkPlugin.ThinkingAnalyticsSettings");
		}

		// Token: 0x06026F13 RID: 159507 RVA: 0x003B654B File Offset: 0x003B474B
		protected UThinkingAnalyticsSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040155E8 RID: 87528
		public new const string __ObjectPath = "/Script/TASdkPlugin.ThinkingAnalyticsSettings";

		// Token: 0x040155E9 RID: 87529
		private static IntPtr _ClassPtr;

		// Token: 0x040155EA RID: 87530
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040155EB RID: 87531
		internal static int __PropertyOffset_ServerUrl;

		// Token: 0x040155EC RID: 87532
		internal static int __PropertyOffset_AppID;

		// Token: 0x040155ED RID: 87533
		internal static int __PropertyOffset_bEnableLog;

		// Token: 0x040155EE RID: 87534
		internal static int __PropertyOffset_bEnableEncrypt;

		// Token: 0x040155EF RID: 87535
		internal static int __PropertyOffset_EncryptPublicKey;

		// Token: 0x040155F0 RID: 87536
		internal static int __PropertyOffset_EncryptVersion;

		// Token: 0x040155F1 RID: 87537
		internal static int __PropertyOffset_SymmetricEncryption;

		// Token: 0x040155F2 RID: 87538
		internal static int __PropertyOffset_AsymmetricEncryption;

		// Token: 0x040155F3 RID: 87539
		internal static int __PropertyOffset_MaxNumInBatch;

		// Token: 0x040155F4 RID: 87540
		internal static int __PropertyOffset_FlushTimeInterval;
	}
}
