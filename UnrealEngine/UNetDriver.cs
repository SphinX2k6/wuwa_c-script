using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000EE7 RID: 3815
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.NetDriver")]
	[UnrealStructLayout(1952, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1952)]
	public abstract class UNetDriver : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600CEB5 RID: 52917 RVA: 0x0012DAC1 File Offset: 0x0012BCC1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNetDriver._ClassPtr;
		}

		// Token: 0x170030B8 RID: 12472
		// (get) Token: 0x0600CEB6 RID: 52918 RVA: 0x0012DACD File Offset: 0x0012BCCD
		// (set) Token: 0x0600CEB7 RID: 52919 RVA: 0x0012DAE1 File Offset: 0x0012BCE1
		public unsafe string NetConnectionClassName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UNetDriver.__PropertyOffset_NetConnectionClassName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UNetDriver.__PropertyOffset_NetConnectionClassName)), value);
			}
		}

		// Token: 0x170030B9 RID: 12473
		// (get) Token: 0x0600CEB8 RID: 52920 RVA: 0x0012DAF6 File Offset: 0x0012BCF6
		// (set) Token: 0x0600CEB9 RID: 52921 RVA: 0x0012DB0A File Offset: 0x0012BD0A
		public unsafe string ReplicationDriverClassName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UNetDriver.__PropertyOffset_ReplicationDriverClassName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UNetDriver.__PropertyOffset_ReplicationDriverClassName)), value);
			}
		}

		// Token: 0x170030BA RID: 12474
		// (get) Token: 0x0600CEBA RID: 52922 RVA: 0x0012DB1F File Offset: 0x0012BD1F
		// (set) Token: 0x0600CEBB RID: 52923 RVA: 0x0012DB2F File Offset: 0x0012BD2F
		public unsafe int MaxDownloadSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNetDriver.__PropertyOffset_MaxDownloadSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNetDriver.__PropertyOffset_MaxDownloadSize) = value;
			}
		}

		// Token: 0x170030BB RID: 12475
		// (get) Token: 0x0600CEBC RID: 52924 RVA: 0x0012DB40 File Offset: 0x0012BD40
		// (set) Token: 0x0600CEBD RID: 52925 RVA: 0x0012DB59 File Offset: 0x0012BD59
		public unsafe bool bClampListenServerTickRate
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNetDriver.__PropertyOffset_bClampListenServerTickRate) & UNetDriver.__PropertyMask_bClampListenServerTickRate) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNetDriver.__PropertyOffset_bClampListenServerTickRate) = ((*(base.NativePtr + (IntPtr)UNetDriver.__PropertyOffset_bClampListenServerTickRate) & ~UNetDriver.__PropertyMask_bClampListenServerTickRate) | (value ? UNetDriver.__PropertyMask_bClampListenServerTickRate : 0));
			}
		}

		// Token: 0x170030BC RID: 12476
		// (get) Token: 0x0600CEBE RID: 52926 RVA: 0x0012DB89 File Offset: 0x0012BD89
		// (set) Token: 0x0600CEBF RID: 52927 RVA: 0x0012DB99 File Offset: 0x0012BD99
		public unsafe int NetServerMaxTickRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNetDriver.__PropertyOffset_NetServerMaxTickRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNetDriver.__PropertyOffset_NetServerMaxTickRate) = value;
			}
		}

		// Token: 0x170030BD RID: 12477
		// (get) Token: 0x0600CEC0 RID: 52928 RVA: 0x0012DBAA File Offset: 0x0012BDAA
		// (set) Token: 0x0600CEC1 RID: 52929 RVA: 0x0012DBBA File Offset: 0x0012BDBA
		public unsafe int MaxNetTickRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNetDriver.__PropertyOffset_MaxNetTickRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNetDriver.__PropertyOffset_MaxNetTickRate) = value;
			}
		}

		// Token: 0x170030BE RID: 12478
		// (get) Token: 0x0600CEC2 RID: 52930 RVA: 0x0012DBCB File Offset: 0x0012BDCB
		// (set) Token: 0x0600CEC3 RID: 52931 RVA: 0x0012DBDB File Offset: 0x0012BDDB
		public unsafe int MaxInternetClientRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNetDriver.__PropertyOffset_MaxInternetClientRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNetDriver.__PropertyOffset_MaxInternetClientRate) = value;
			}
		}

		// Token: 0x170030BF RID: 12479
		// (get) Token: 0x0600CEC4 RID: 52932 RVA: 0x0012DBEC File Offset: 0x0012BDEC
		// (set) Token: 0x0600CEC5 RID: 52933 RVA: 0x0012DBFC File Offset: 0x0012BDFC
		public unsafe int MaxClientRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNetDriver.__PropertyOffset_MaxClientRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNetDriver.__PropertyOffset_MaxClientRate) = value;
			}
		}

		// Token: 0x170030C0 RID: 12480
		// (get) Token: 0x0600CEC6 RID: 52934 RVA: 0x0012DC0D File Offset: 0x0012BE0D
		// (set) Token: 0x0600CEC7 RID: 52935 RVA: 0x0012DC1D File Offset: 0x0012BE1D
		public unsafe float ServerTravelPause
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNetDriver.__PropertyOffset_ServerTravelPause);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNetDriver.__PropertyOffset_ServerTravelPause) = value;
			}
		}

		// Token: 0x170030C1 RID: 12481
		// (get) Token: 0x0600CEC8 RID: 52936 RVA: 0x0012DC2E File Offset: 0x0012BE2E
		// (set) Token: 0x0600CEC9 RID: 52937 RVA: 0x0012DC3E File Offset: 0x0012BE3E
		public unsafe float SpawnPrioritySeconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNetDriver.__PropertyOffset_SpawnPrioritySeconds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNetDriver.__PropertyOffset_SpawnPrioritySeconds) = value;
			}
		}

		// Token: 0x170030C2 RID: 12482
		// (get) Token: 0x0600CECA RID: 52938 RVA: 0x0012DC4F File Offset: 0x0012BE4F
		// (set) Token: 0x0600CECB RID: 52939 RVA: 0x0012DC5F File Offset: 0x0012BE5F
		public unsafe float RelevantTimeout
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNetDriver.__PropertyOffset_RelevantTimeout);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNetDriver.__PropertyOffset_RelevantTimeout) = value;
			}
		}

		// Token: 0x170030C3 RID: 12483
		// (get) Token: 0x0600CECC RID: 52940 RVA: 0x0012DC70 File Offset: 0x0012BE70
		// (set) Token: 0x0600CECD RID: 52941 RVA: 0x0012DC80 File Offset: 0x0012BE80
		public unsafe float KeepAliveTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNetDriver.__PropertyOffset_KeepAliveTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNetDriver.__PropertyOffset_KeepAliveTime) = value;
			}
		}

		// Token: 0x170030C4 RID: 12484
		// (get) Token: 0x0600CECE RID: 52942 RVA: 0x0012DC91 File Offset: 0x0012BE91
		// (set) Token: 0x0600CECF RID: 52943 RVA: 0x0012DCA1 File Offset: 0x0012BEA1
		public unsafe float InitialConnectTimeout
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNetDriver.__PropertyOffset_InitialConnectTimeout);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNetDriver.__PropertyOffset_InitialConnectTimeout) = value;
			}
		}

		// Token: 0x170030C5 RID: 12485
		// (get) Token: 0x0600CED0 RID: 52944 RVA: 0x0012DCB2 File Offset: 0x0012BEB2
		// (set) Token: 0x0600CED1 RID: 52945 RVA: 0x0012DCC2 File Offset: 0x0012BEC2
		public unsafe float ConnectionTimeout
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNetDriver.__PropertyOffset_ConnectionTimeout);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNetDriver.__PropertyOffset_ConnectionTimeout) = value;
			}
		}

		// Token: 0x170030C6 RID: 12486
		// (get) Token: 0x0600CED2 RID: 52946 RVA: 0x0012DCD3 File Offset: 0x0012BED3
		// (set) Token: 0x0600CED3 RID: 52947 RVA: 0x0012DCE3 File Offset: 0x0012BEE3
		public unsafe float TimeoutMultiplierForUnoptimizedBuilds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNetDriver.__PropertyOffset_TimeoutMultiplierForUnoptimizedBuilds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNetDriver.__PropertyOffset_TimeoutMultiplierForUnoptimizedBuilds) = value;
			}
		}

		// Token: 0x170030C7 RID: 12487
		// (get) Token: 0x0600CED4 RID: 52948 RVA: 0x0012DCF4 File Offset: 0x0012BEF4
		// (set) Token: 0x0600CED5 RID: 52949 RVA: 0x0012DD04 File Offset: 0x0012BF04
		public unsafe bool bNoTimeouts
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNetDriver.__PropertyOffset_bNoTimeouts) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNetDriver.__PropertyOffset_bNoTimeouts) = (value ? 1 : 0);
			}
		}

		// Token: 0x170030C8 RID: 12488
		// (get) Token: 0x0600CED6 RID: 52950 RVA: 0x0012DD15 File Offset: 0x0012BF15
		// (set) Token: 0x0600CED7 RID: 52951 RVA: 0x0012DD25 File Offset: 0x0012BF25
		public unsafe bool bNeverApplyNetworkEmulationSettings
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNetDriver.__PropertyOffset_bNeverApplyNetworkEmulationSettings) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNetDriver.__PropertyOffset_bNeverApplyNetworkEmulationSettings) = (value ? 1 : 0);
			}
		}

		// Token: 0x170030C9 RID: 12489
		// (get) Token: 0x0600CED8 RID: 52952 RVA: 0x0012DD36 File Offset: 0x0012BF36
		// (set) Token: 0x0600CED9 RID: 52953 RVA: 0x0012DD4A File Offset: 0x0012BF4A
		[Nullable(2)]
		public unsafe UNetConnection ServerConnection
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNetConnection>(base.NativePtr / (IntPtr)sizeof(void*) + UNetDriver.__PropertyOffset_ServerConnection);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNetDriver.__PropertyOffset_ServerConnection, value);
			}
		}

		// Token: 0x170030CA RID: 12490
		// (get) Token: 0x0600CEDA RID: 52954 RVA: 0x0012DD60 File Offset: 0x0012BF60
		// (set) Token: 0x0600CEDB RID: 52955 RVA: 0x0012DD99 File Offset: 0x0012BF99
		public TArray<UNetConnection> ClientConnections
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UNetConnection> result;
				if ((result = this._ClientConnections) == null)
				{
					result = (this._ClientConnections = new TArray<UNetConnection>(base.NativePtr + (IntPtr)UNetDriver.__PropertyOffset_ClientConnections, this));
				}
				return result;
			}
			set
			{
				this.ClientConnections.CopyAssign(value);
			}
		}

		// Token: 0x170030CB RID: 12491
		// (get) Token: 0x0600CEDC RID: 52956 RVA: 0x0012DDA7 File Offset: 0x0012BFA7
		// (set) Token: 0x0600CEDD RID: 52957 RVA: 0x0012DDB7 File Offset: 0x0012BFB7
		public unsafe int RecentlyDisconnectedTrackingTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNetDriver.__PropertyOffset_RecentlyDisconnectedTrackingTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNetDriver.__PropertyOffset_RecentlyDisconnectedTrackingTime) = value;
			}
		}

		// Token: 0x170030CC RID: 12492
		// (get) Token: 0x0600CEDE RID: 52958 RVA: 0x0012DDC8 File Offset: 0x0012BFC8
		// (set) Token: 0x0600CEDF RID: 52959 RVA: 0x0012DDDC File Offset: 0x0012BFDC
		[Nullable(2)]
		public unsafe UWorld World
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UWorld>(base.NativePtr / (IntPtr)sizeof(void*) + UNetDriver.__PropertyOffset_World);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNetDriver.__PropertyOffset_World, value);
			}
		}

		// Token: 0x170030CD RID: 12493
		// (get) Token: 0x0600CEE0 RID: 52960 RVA: 0x0012DDF1 File Offset: 0x0012BFF1
		// (set) Token: 0x0600CEE1 RID: 52961 RVA: 0x0012DE05 File Offset: 0x0012C005
		[Nullable(2)]
		public unsafe UPackage WorldPackage
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPackage>(base.NativePtr / (IntPtr)sizeof(void*) + UNetDriver.__PropertyOffset_WorldPackage);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNetDriver.__PropertyOffset_WorldPackage, value);
			}
		}

		// Token: 0x170030CE RID: 12494
		// (get) Token: 0x0600CEE2 RID: 52962 RVA: 0x0012DE1A File Offset: 0x0012C01A
		// (set) Token: 0x0600CEE3 RID: 52963 RVA: 0x0012DE2E File Offset: 0x0012C02E
		public unsafe UClassStackOnlyPtr NetConnectionClass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNetDriver.__PropertyOffset_NetConnectionClass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNetDriver.__PropertyOffset_NetConnectionClass) = value;
			}
		}

		// Token: 0x170030CF RID: 12495
		// (get) Token: 0x0600CEE4 RID: 52964 RVA: 0x0012DE43 File Offset: 0x0012C043
		// (set) Token: 0x0600CEE5 RID: 52965 RVA: 0x0012DE57 File Offset: 0x0012C057
		public unsafe UClassStackOnlyPtr ReplicationDriverClass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNetDriver.__PropertyOffset_ReplicationDriverClass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNetDriver.__PropertyOffset_ReplicationDriverClass) = value;
			}
		}

		// Token: 0x170030D0 RID: 12496
		// (get) Token: 0x0600CEE6 RID: 52966 RVA: 0x0012DE6C File Offset: 0x0012C06C
		// (set) Token: 0x0600CEE7 RID: 52967 RVA: 0x0012DE80 File Offset: 0x0012C080
		public unsafe FName NetDriverName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNetDriver.__PropertyOffset_NetDriverName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNetDriver.__PropertyOffset_NetDriverName) = value;
			}
		}

		// Token: 0x170030D1 RID: 12497
		// (get) Token: 0x0600CEE8 RID: 52968 RVA: 0x0012DE98 File Offset: 0x0012C098
		// (set) Token: 0x0600CEE9 RID: 52969 RVA: 0x0012DED1 File Offset: 0x0012C0D1
		public TArray<FChannelDefinition> ChannelDefinitions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FChannelDefinition> result;
				if ((result = this._ChannelDefinitions) == null)
				{
					result = (this._ChannelDefinitions = new TArray<FChannelDefinition>(base.NativePtr + (IntPtr)UNetDriver.__PropertyOffset_ChannelDefinitions, this));
				}
				return result;
			}
			set
			{
				this.ChannelDefinitions.CopyAssign(value);
			}
		}

		// Token: 0x170030D2 RID: 12498
		// (get) Token: 0x0600CEEA RID: 52970 RVA: 0x0012DEE0 File Offset: 0x0012C0E0
		// (set) Token: 0x0600CEEB RID: 52971 RVA: 0x0012DF19 File Offset: 0x0012C119
		public TMap<FName, FChannelDefinition> ChannelDefinitionMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FChannelDefinition> result;
				if ((result = this._ChannelDefinitionMap) == null)
				{
					result = (this._ChannelDefinitionMap = new TMap<FName, FChannelDefinition>(base.NativePtr + (IntPtr)UNetDriver.__PropertyOffset_ChannelDefinitionMap, this));
				}
				return result;
			}
			set
			{
				this.ChannelDefinitionMap.CopyAssign(value);
			}
		}

		// Token: 0x170030D3 RID: 12499
		// (get) Token: 0x0600CEEC RID: 52972 RVA: 0x0012DF28 File Offset: 0x0012C128
		// (set) Token: 0x0600CEED RID: 52973 RVA: 0x0012DF61 File Offset: 0x0012C161
		public TArray<UChannel> ActorChannelPool
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UChannel> result;
				if ((result = this._ActorChannelPool) == null)
				{
					result = (this._ActorChannelPool = new TArray<UChannel>(base.NativePtr + (IntPtr)UNetDriver.__PropertyOffset_ActorChannelPool, this));
				}
				return result;
			}
			set
			{
				this.ActorChannelPool.CopyAssign(value);
			}
		}

		// Token: 0x170030D4 RID: 12500
		// (get) Token: 0x0600CEEE RID: 52974 RVA: 0x0012DF6F File Offset: 0x0012C16F
		// (set) Token: 0x0600CEEF RID: 52975 RVA: 0x0012DF7F File Offset: 0x0012C17F
		public unsafe float Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNetDriver.__PropertyOffset_Time);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNetDriver.__PropertyOffset_Time) = value;
			}
		}

		// Token: 0x170030D5 RID: 12501
		// (get) Token: 0x0600CEF0 RID: 52976 RVA: 0x0012DF90 File Offset: 0x0012C190
		// (set) Token: 0x0600CEF1 RID: 52977 RVA: 0x0012DFA4 File Offset: 0x0012C1A4
		[Nullable(2)]
		public unsafe UReplicationDriver ReplicationDriver
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UReplicationDriver>(base.NativePtr / (IntPtr)sizeof(void*) + UNetDriver.__PropertyOffset_ReplicationDriver);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNetDriver.__PropertyOffset_ReplicationDriver, value);
			}
		}

		// Token: 0x0600CEF2 RID: 52978 RVA: 0x0012DFB9 File Offset: 0x0012C1B9
		static UNetDriver()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.NetDriver");
		}

		// Token: 0x0600CEF3 RID: 52979 RVA: 0x0012DFC8 File Offset: 0x0012C1C8
		protected UNetDriver() : this(BuiltinUtils.AllocNativeUObject(UNetDriver.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600CEF4 RID: 52980 RVA: 0x0012DFF0 File Offset: 0x0012C1F0
		protected UNetDriver(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006F7E RID: 28542
		public new const string __ObjectPath = "/Script/Engine.NetDriver";

		// Token: 0x04006F7F RID: 28543
		private static IntPtr _ClassPtr;

		// Token: 0x04006F80 RID: 28544
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006F81 RID: 28545
		internal static int __PropertyOffset_NetConnectionClassName;

		// Token: 0x04006F82 RID: 28546
		internal static int __PropertyOffset_ReplicationDriverClassName;

		// Token: 0x04006F83 RID: 28547
		internal static int __PropertyOffset_MaxDownloadSize;

		// Token: 0x04006F84 RID: 28548
		internal static int __PropertyOffset_bClampListenServerTickRate;

		// Token: 0x04006F85 RID: 28549
		internal static byte __PropertyMask_bClampListenServerTickRate;

		// Token: 0x04006F86 RID: 28550
		internal static int __PropertyOffset_NetServerMaxTickRate;

		// Token: 0x04006F87 RID: 28551
		internal static int __PropertyOffset_MaxNetTickRate;

		// Token: 0x04006F88 RID: 28552
		internal static int __PropertyOffset_MaxInternetClientRate;

		// Token: 0x04006F89 RID: 28553
		internal static int __PropertyOffset_MaxClientRate;

		// Token: 0x04006F8A RID: 28554
		internal static int __PropertyOffset_ServerTravelPause;

		// Token: 0x04006F8B RID: 28555
		internal static int __PropertyOffset_SpawnPrioritySeconds;

		// Token: 0x04006F8C RID: 28556
		internal static int __PropertyOffset_RelevantTimeout;

		// Token: 0x04006F8D RID: 28557
		internal static int __PropertyOffset_KeepAliveTime;

		// Token: 0x04006F8E RID: 28558
		internal static int __PropertyOffset_InitialConnectTimeout;

		// Token: 0x04006F8F RID: 28559
		internal static int __PropertyOffset_ConnectionTimeout;

		// Token: 0x04006F90 RID: 28560
		internal static int __PropertyOffset_TimeoutMultiplierForUnoptimizedBuilds;

		// Token: 0x04006F91 RID: 28561
		internal static int __PropertyOffset_bNoTimeouts;

		// Token: 0x04006F92 RID: 28562
		internal static int __PropertyOffset_bNeverApplyNetworkEmulationSettings;

		// Token: 0x04006F93 RID: 28563
		internal static int __PropertyOffset_ServerConnection;

		// Token: 0x04006F94 RID: 28564
		internal static int __PropertyOffset_ClientConnections;

		// Token: 0x04006F95 RID: 28565
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UNetConnection> _ClientConnections;

		// Token: 0x04006F96 RID: 28566
		internal static int __PropertyOffset_RecentlyDisconnectedTrackingTime;

		// Token: 0x04006F97 RID: 28567
		internal static int __PropertyOffset_World;

		// Token: 0x04006F98 RID: 28568
		internal static int __PropertyOffset_WorldPackage;

		// Token: 0x04006F99 RID: 28569
		internal static int __PropertyOffset_NetConnectionClass;

		// Token: 0x04006F9A RID: 28570
		internal static int __PropertyOffset_ReplicationDriverClass;

		// Token: 0x04006F9B RID: 28571
		internal static int __PropertyOffset_NetDriverName;

		// Token: 0x04006F9C RID: 28572
		internal static int __PropertyOffset_ChannelDefinitions;

		// Token: 0x04006F9D RID: 28573
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FChannelDefinition> _ChannelDefinitions;

		// Token: 0x04006F9E RID: 28574
		internal static int __PropertyOffset_ChannelDefinitionMap;

		// Token: 0x04006F9F RID: 28575
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FChannelDefinition> _ChannelDefinitionMap;

		// Token: 0x04006FA0 RID: 28576
		internal static int __PropertyOffset_ActorChannelPool;

		// Token: 0x04006FA1 RID: 28577
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UChannel> _ActorChannelPool;

		// Token: 0x04006FA2 RID: 28578
		internal static int __PropertyOffset_Time;

		// Token: 0x04006FA3 RID: 28579
		internal static int __PropertyOffset_ReplicationDriver;
	}
}
