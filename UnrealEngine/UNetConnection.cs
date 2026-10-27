using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000EE6 RID: 3814
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.NetConnection")]
	[UnrealStructLayout(7032, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 7032)]
	public abstract class UNetConnection : UPlayer, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600CE97 RID: 52887 RVA: 0x0012D7A0 File Offset: 0x0012B9A0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNetConnection._ClassPtr;
		}

		// Token: 0x170030AB RID: 12459
		// (get) Token: 0x0600CE98 RID: 52888 RVA: 0x0012D7AC File Offset: 0x0012B9AC
		// (set) Token: 0x0600CE99 RID: 52889 RVA: 0x0012D7E5 File Offset: 0x0012B9E5
		public TArray<UChildConnection> Children
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UChildConnection> result;
				if ((result = this._Children) == null)
				{
					result = (this._Children = new TArray<UChildConnection>(base.NativePtr + (IntPtr)UNetConnection.__PropertyOffset_Children, this));
				}
				return result;
			}
			set
			{
				this.Children.CopyAssign(value);
			}
		}

		// Token: 0x170030AC RID: 12460
		// (get) Token: 0x0600CE9A RID: 52890 RVA: 0x0012D7F3 File Offset: 0x0012B9F3
		// (set) Token: 0x0600CE9B RID: 52891 RVA: 0x0012D807 File Offset: 0x0012BA07
		[Nullable(2)]
		public unsafe UNetDriver Driver
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNetDriver>(base.NativePtr / (IntPtr)sizeof(void*) + UNetConnection.__PropertyOffset_Driver);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNetConnection.__PropertyOffset_Driver, value);
			}
		}

		// Token: 0x170030AD RID: 12461
		// (get) Token: 0x0600CE9C RID: 52892 RVA: 0x0012D81C File Offset: 0x0012BA1C
		// (set) Token: 0x0600CE9D RID: 52893 RVA: 0x0012D830 File Offset: 0x0012BA30
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UPackageMap> PackageMapClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UNetConnection.__PropertyOffset_PackageMapClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UNetConnection.__PropertyOffset_PackageMapClass) = value;
			}
		}

		// Token: 0x170030AE RID: 12462
		// (get) Token: 0x0600CE9E RID: 52894 RVA: 0x0012D845 File Offset: 0x0012BA45
		// (set) Token: 0x0600CE9F RID: 52895 RVA: 0x0012D859 File Offset: 0x0012BA59
		[Nullable(2)]
		public unsafe UPackageMap PackageMap
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPackageMap>(base.NativePtr / (IntPtr)sizeof(void*) + UNetConnection.__PropertyOffset_PackageMap);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNetConnection.__PropertyOffset_PackageMap, value);
			}
		}

		// Token: 0x170030AF RID: 12463
		// (get) Token: 0x0600CEA0 RID: 52896 RVA: 0x0012D870 File Offset: 0x0012BA70
		// (set) Token: 0x0600CEA1 RID: 52897 RVA: 0x0012D8A9 File Offset: 0x0012BAA9
		public TArray<UChannel> OpenChannels
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UChannel> result;
				if ((result = this._OpenChannels) == null)
				{
					result = (this._OpenChannels = new TArray<UChannel>(base.NativePtr + (IntPtr)UNetConnection.__PropertyOffset_OpenChannels, this));
				}
				return result;
			}
			set
			{
				this.OpenChannels.CopyAssign(value);
			}
		}

		// Token: 0x170030B0 RID: 12464
		// (get) Token: 0x0600CEA2 RID: 52898 RVA: 0x0012D8B8 File Offset: 0x0012BAB8
		// (set) Token: 0x0600CEA3 RID: 52899 RVA: 0x0012D8F1 File Offset: 0x0012BAF1
		public TArray<AActor> SentTemporaries
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._SentTemporaries) == null)
				{
					result = (this._SentTemporaries = new TArray<AActor>(base.NativePtr + (IntPtr)UNetConnection.__PropertyOffset_SentTemporaries, this));
				}
				return result;
			}
			set
			{
				this.SentTemporaries.CopyAssign(value);
			}
		}

		// Token: 0x170030B1 RID: 12465
		// (get) Token: 0x0600CEA4 RID: 52900 RVA: 0x0012D8FF File Offset: 0x0012BAFF
		// (set) Token: 0x0600CEA5 RID: 52901 RVA: 0x0012D913 File Offset: 0x0012BB13
		[Nullable(2)]
		public unsafe AActor ViewTarget
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + UNetConnection.__PropertyOffset_ViewTarget);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNetConnection.__PropertyOffset_ViewTarget, value);
			}
		}

		// Token: 0x170030B2 RID: 12466
		// (get) Token: 0x0600CEA6 RID: 52902 RVA: 0x0012D928 File Offset: 0x0012BB28
		// (set) Token: 0x0600CEA7 RID: 52903 RVA: 0x0012D93C File Offset: 0x0012BB3C
		[Nullable(2)]
		public unsafe AActor OwningActor
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + UNetConnection.__PropertyOffset_OwningActor);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNetConnection.__PropertyOffset_OwningActor, value);
			}
		}

		// Token: 0x170030B3 RID: 12467
		// (get) Token: 0x0600CEA8 RID: 52904 RVA: 0x0012D951 File Offset: 0x0012BB51
		// (set) Token: 0x0600CEA9 RID: 52905 RVA: 0x0012D961 File Offset: 0x0012BB61
		public unsafe int MaxPacket
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNetConnection.__PropertyOffset_MaxPacket);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNetConnection.__PropertyOffset_MaxPacket) = value;
			}
		}

		// Token: 0x170030B4 RID: 12468
		// (get) Token: 0x0600CEAA RID: 52906 RVA: 0x0012D972 File Offset: 0x0012BB72
		// (set) Token: 0x0600CEAB RID: 52907 RVA: 0x0012D98B File Offset: 0x0012BB8B
		public unsafe bool InternalAck
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNetConnection.__PropertyOffset_InternalAck) & UNetConnection.__PropertyMask_InternalAck) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNetConnection.__PropertyOffset_InternalAck) = ((*(base.NativePtr + (IntPtr)UNetConnection.__PropertyOffset_InternalAck) & ~UNetConnection.__PropertyMask_InternalAck) | (value ? UNetConnection.__PropertyMask_InternalAck : 0));
			}
		}

		// Token: 0x170030B5 RID: 12469
		// (get) Token: 0x0600CEAC RID: 52908 RVA: 0x0012D9BC File Offset: 0x0012BBBC
		// (set) Token: 0x0600CEAD RID: 52909 RVA: 0x0012D9F5 File Offset: 0x0012BBF5
		public FUniqueNetIdRepl PlayerId
		{
			get
			{
				base.FastCheckIsValid();
				FUniqueNetIdRepl result;
				if ((result = this._PlayerId) == null)
				{
					result = (this._PlayerId = new FUniqueNetIdRepl(base.NativePtr + (IntPtr)UNetConnection.__PropertyOffset_PlayerId, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FUniqueNetIdRepl.StaticStruct(), base.NativePtr + (IntPtr)UNetConnection.__PropertyOffset_PlayerId, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170030B6 RID: 12470
		// (get) Token: 0x0600CEAE RID: 52910 RVA: 0x0012DA16 File Offset: 0x0012BC16
		// (set) Token: 0x0600CEAF RID: 52911 RVA: 0x0012DA26 File Offset: 0x0012BC26
		public unsafe double LastReceiveTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNetConnection.__PropertyOffset_LastReceiveTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNetConnection.__PropertyOffset_LastReceiveTime) = value;
			}
		}

		// Token: 0x170030B7 RID: 12471
		// (get) Token: 0x0600CEB0 RID: 52912 RVA: 0x0012DA38 File Offset: 0x0012BC38
		// (set) Token: 0x0600CEB1 RID: 52913 RVA: 0x0012DA71 File Offset: 0x0012BC71
		public TArray<UChannel> ChannelsToTick
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UChannel> result;
				if ((result = this._ChannelsToTick) == null)
				{
					result = (this._ChannelsToTick = new TArray<UChannel>(base.NativePtr + (IntPtr)UNetConnection.__PropertyOffset_ChannelsToTick, this));
				}
				return result;
			}
			set
			{
				this.ChannelsToTick.CopyAssign(value);
			}
		}

		// Token: 0x0600CEB2 RID: 52914 RVA: 0x0012DA7F File Offset: 0x0012BC7F
		static UNetConnection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.NetConnection");
		}

		// Token: 0x0600CEB3 RID: 52915 RVA: 0x0012DA90 File Offset: 0x0012BC90
		protected UNetConnection() : this(BuiltinUtils.AllocNativeUObject(UNetConnection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600CEB4 RID: 52916 RVA: 0x0012DAB8 File Offset: 0x0012BCB8
		protected UNetConnection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006F68 RID: 28520
		public new const string __ObjectPath = "/Script/Engine.NetConnection";

		// Token: 0x04006F69 RID: 28521
		private static IntPtr _ClassPtr;

		// Token: 0x04006F6A RID: 28522
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006F6B RID: 28523
		internal static int __PropertyOffset_Children;

		// Token: 0x04006F6C RID: 28524
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UChildConnection> _Children;

		// Token: 0x04006F6D RID: 28525
		internal static int __PropertyOffset_Driver;

		// Token: 0x04006F6E RID: 28526
		internal static int __PropertyOffset_PackageMapClass;

		// Token: 0x04006F6F RID: 28527
		internal static int __PropertyOffset_PackageMap;

		// Token: 0x04006F70 RID: 28528
		internal static int __PropertyOffset_OpenChannels;

		// Token: 0x04006F71 RID: 28529
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UChannel> _OpenChannels;

		// Token: 0x04006F72 RID: 28530
		internal static int __PropertyOffset_SentTemporaries;

		// Token: 0x04006F73 RID: 28531
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _SentTemporaries;

		// Token: 0x04006F74 RID: 28532
		internal static int __PropertyOffset_ViewTarget;

		// Token: 0x04006F75 RID: 28533
		internal static int __PropertyOffset_OwningActor;

		// Token: 0x04006F76 RID: 28534
		internal static int __PropertyOffset_MaxPacket;

		// Token: 0x04006F77 RID: 28535
		internal static int __PropertyOffset_InternalAck;

		// Token: 0x04006F78 RID: 28536
		internal static byte __PropertyMask_InternalAck;

		// Token: 0x04006F79 RID: 28537
		internal static int __PropertyOffset_PlayerId;

		// Token: 0x04006F7A RID: 28538
		[Nullable(2)]
		private FUniqueNetIdRepl _PlayerId;

		// Token: 0x04006F7B RID: 28539
		internal static int __PropertyOffset_LastReceiveTime;

		// Token: 0x04006F7C RID: 28540
		internal static int __PropertyOffset_ChannelsToTick;

		// Token: 0x04006F7D RID: 28541
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UChannel> _ChannelsToTick;
	}
}
