using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020011AD RID: 4525
	[UnrealObjectPath("/Script/Engine.StreamingSettings")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class UStreamingSettings : UDeveloperSettings, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06010AEA RID: 68330 RVA: 0x00187FEE File Offset: 0x001861EE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UStreamingSettings._ClassPtr;
		}

		// Token: 0x06010AEB RID: 68331 RVA: 0x00187FFC File Offset: 0x001861FC
		public UStreamingSettings() : this(BuiltinUtils.AllocNativeUObject(UStreamingSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010AEC RID: 68332 RVA: 0x00188024 File Offset: 0x00186224
		[NullableContext(1)]
		public UStreamingSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UStreamingSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004123 RID: 16675
		// (get) Token: 0x06010AED RID: 68333 RVA: 0x00188057 File Offset: 0x00186257
		// (set) Token: 0x06010AEE RID: 68334 RVA: 0x00188070 File Offset: 0x00186270
		public unsafe bool AsyncLoadingThreadEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStreamingSettings.__PropertyOffset_AsyncLoadingThreadEnabled) & UStreamingSettings.__PropertyMask_AsyncLoadingThreadEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStreamingSettings.__PropertyOffset_AsyncLoadingThreadEnabled) = ((*(base.NativePtr + (IntPtr)UStreamingSettings.__PropertyOffset_AsyncLoadingThreadEnabled) & ~UStreamingSettings.__PropertyMask_AsyncLoadingThreadEnabled) | (value ? UStreamingSettings.__PropertyMask_AsyncLoadingThreadEnabled : 0));
			}
		}

		// Token: 0x17004124 RID: 16676
		// (get) Token: 0x06010AEF RID: 68335 RVA: 0x001880A0 File Offset: 0x001862A0
		// (set) Token: 0x06010AF0 RID: 68336 RVA: 0x001880B9 File Offset: 0x001862B9
		public unsafe bool WarnIfTimeLimitExceeded
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStreamingSettings.__PropertyOffset_WarnIfTimeLimitExceeded) & UStreamingSettings.__PropertyMask_WarnIfTimeLimitExceeded) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStreamingSettings.__PropertyOffset_WarnIfTimeLimitExceeded) = ((*(base.NativePtr + (IntPtr)UStreamingSettings.__PropertyOffset_WarnIfTimeLimitExceeded) & ~UStreamingSettings.__PropertyMask_WarnIfTimeLimitExceeded) | (value ? UStreamingSettings.__PropertyMask_WarnIfTimeLimitExceeded : 0));
			}
		}

		// Token: 0x17004125 RID: 16677
		// (get) Token: 0x06010AF1 RID: 68337 RVA: 0x001880E9 File Offset: 0x001862E9
		// (set) Token: 0x06010AF2 RID: 68338 RVA: 0x001880F9 File Offset: 0x001862F9
		public unsafe float TimeLimitExceededMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStreamingSettings.__PropertyOffset_TimeLimitExceededMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStreamingSettings.__PropertyOffset_TimeLimitExceededMultiplier) = value;
			}
		}

		// Token: 0x17004126 RID: 16678
		// (get) Token: 0x06010AF3 RID: 68339 RVA: 0x0018810A File Offset: 0x0018630A
		// (set) Token: 0x06010AF4 RID: 68340 RVA: 0x0018811A File Offset: 0x0018631A
		public unsafe float TimeLimitExceededMinTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStreamingSettings.__PropertyOffset_TimeLimitExceededMinTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStreamingSettings.__PropertyOffset_TimeLimitExceededMinTime) = value;
			}
		}

		// Token: 0x17004127 RID: 16679
		// (get) Token: 0x06010AF5 RID: 68341 RVA: 0x0018812B File Offset: 0x0018632B
		// (set) Token: 0x06010AF6 RID: 68342 RVA: 0x0018813B File Offset: 0x0018633B
		public unsafe int MinBulkDataSizeForAsyncLoading
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStreamingSettings.__PropertyOffset_MinBulkDataSizeForAsyncLoading);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStreamingSettings.__PropertyOffset_MinBulkDataSizeForAsyncLoading) = value;
			}
		}

		// Token: 0x17004128 RID: 16680
		// (get) Token: 0x06010AF7 RID: 68343 RVA: 0x0018814C File Offset: 0x0018634C
		// (set) Token: 0x06010AF8 RID: 68344 RVA: 0x00188165 File Offset: 0x00186365
		public unsafe bool UseBackgroundLevelStreaming
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStreamingSettings.__PropertyOffset_UseBackgroundLevelStreaming) & UStreamingSettings.__PropertyMask_UseBackgroundLevelStreaming) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStreamingSettings.__PropertyOffset_UseBackgroundLevelStreaming) = ((*(base.NativePtr + (IntPtr)UStreamingSettings.__PropertyOffset_UseBackgroundLevelStreaming) & ~UStreamingSettings.__PropertyMask_UseBackgroundLevelStreaming) | (value ? UStreamingSettings.__PropertyMask_UseBackgroundLevelStreaming : 0));
			}
		}

		// Token: 0x17004129 RID: 16681
		// (get) Token: 0x06010AF9 RID: 68345 RVA: 0x00188195 File Offset: 0x00186395
		// (set) Token: 0x06010AFA RID: 68346 RVA: 0x001881AE File Offset: 0x001863AE
		public unsafe bool AsyncLoadingUseFullTimeLimit
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStreamingSettings.__PropertyOffset_AsyncLoadingUseFullTimeLimit) & UStreamingSettings.__PropertyMask_AsyncLoadingUseFullTimeLimit) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStreamingSettings.__PropertyOffset_AsyncLoadingUseFullTimeLimit) = ((*(base.NativePtr + (IntPtr)UStreamingSettings.__PropertyOffset_AsyncLoadingUseFullTimeLimit) & ~UStreamingSettings.__PropertyMask_AsyncLoadingUseFullTimeLimit) | (value ? UStreamingSettings.__PropertyMask_AsyncLoadingUseFullTimeLimit : 0));
			}
		}

		// Token: 0x1700412A RID: 16682
		// (get) Token: 0x06010AFB RID: 68347 RVA: 0x001881DE File Offset: 0x001863DE
		// (set) Token: 0x06010AFC RID: 68348 RVA: 0x001881EE File Offset: 0x001863EE
		public unsafe float AsyncLoadingTimeLimit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStreamingSettings.__PropertyOffset_AsyncLoadingTimeLimit);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStreamingSettings.__PropertyOffset_AsyncLoadingTimeLimit) = value;
			}
		}

		// Token: 0x1700412B RID: 16683
		// (get) Token: 0x06010AFD RID: 68349 RVA: 0x001881FF File Offset: 0x001863FF
		// (set) Token: 0x06010AFE RID: 68350 RVA: 0x0018820F File Offset: 0x0018640F
		public unsafe float PriorityAsyncLoadingExtraTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStreamingSettings.__PropertyOffset_PriorityAsyncLoadingExtraTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStreamingSettings.__PropertyOffset_PriorityAsyncLoadingExtraTime) = value;
			}
		}

		// Token: 0x1700412C RID: 16684
		// (get) Token: 0x06010AFF RID: 68351 RVA: 0x00188220 File Offset: 0x00186420
		// (set) Token: 0x06010B00 RID: 68352 RVA: 0x00188230 File Offset: 0x00186430
		public unsafe float LevelStreamingActorsUpdateTimeLimit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStreamingSettings.__PropertyOffset_LevelStreamingActorsUpdateTimeLimit);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStreamingSettings.__PropertyOffset_LevelStreamingActorsUpdateTimeLimit) = value;
			}
		}

		// Token: 0x1700412D RID: 16685
		// (get) Token: 0x06010B01 RID: 68353 RVA: 0x00188241 File Offset: 0x00186441
		// (set) Token: 0x06010B02 RID: 68354 RVA: 0x00188251 File Offset: 0x00186451
		public unsafe float PriorityLevelStreamingActorsUpdateExtraTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStreamingSettings.__PropertyOffset_PriorityLevelStreamingActorsUpdateExtraTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStreamingSettings.__PropertyOffset_PriorityLevelStreamingActorsUpdateExtraTime) = value;
			}
		}

		// Token: 0x1700412E RID: 16686
		// (get) Token: 0x06010B03 RID: 68355 RVA: 0x00188262 File Offset: 0x00186462
		// (set) Token: 0x06010B04 RID: 68356 RVA: 0x00188272 File Offset: 0x00186472
		public unsafe int LevelStreamingComponentsRegistrationGranularity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStreamingSettings.__PropertyOffset_LevelStreamingComponentsRegistrationGranularity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStreamingSettings.__PropertyOffset_LevelStreamingComponentsRegistrationGranularity) = value;
			}
		}

		// Token: 0x1700412F RID: 16687
		// (get) Token: 0x06010B05 RID: 68357 RVA: 0x00188283 File Offset: 0x00186483
		// (set) Token: 0x06010B06 RID: 68358 RVA: 0x00188293 File Offset: 0x00186493
		public unsafe float LevelStreamingUnregisterComponentsTimeLimit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStreamingSettings.__PropertyOffset_LevelStreamingUnregisterComponentsTimeLimit);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStreamingSettings.__PropertyOffset_LevelStreamingUnregisterComponentsTimeLimit) = value;
			}
		}

		// Token: 0x17004130 RID: 16688
		// (get) Token: 0x06010B07 RID: 68359 RVA: 0x001882A4 File Offset: 0x001864A4
		// (set) Token: 0x06010B08 RID: 68360 RVA: 0x001882B4 File Offset: 0x001864B4
		public unsafe int LevelStreamingComponentsUnregistrationGranularity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStreamingSettings.__PropertyOffset_LevelStreamingComponentsUnregistrationGranularity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStreamingSettings.__PropertyOffset_LevelStreamingComponentsUnregistrationGranularity) = value;
			}
		}

		// Token: 0x17004131 RID: 16689
		// (get) Token: 0x06010B09 RID: 68361 RVA: 0x001882C5 File Offset: 0x001864C5
		// (set) Token: 0x06010B0A RID: 68362 RVA: 0x001882DE File Offset: 0x001864DE
		public unsafe bool FlushStreamingOnExit
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStreamingSettings.__PropertyOffset_FlushStreamingOnExit) & UStreamingSettings.__PropertyMask_FlushStreamingOnExit) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStreamingSettings.__PropertyOffset_FlushStreamingOnExit) = ((*(base.NativePtr + (IntPtr)UStreamingSettings.__PropertyOffset_FlushStreamingOnExit) & ~UStreamingSettings.__PropertyMask_FlushStreamingOnExit) | (value ? UStreamingSettings.__PropertyMask_FlushStreamingOnExit : 0));
			}
		}

		// Token: 0x17004132 RID: 16690
		// (get) Token: 0x06010B0B RID: 68363 RVA: 0x0018830E File Offset: 0x0018650E
		// (set) Token: 0x06010B0C RID: 68364 RVA: 0x00188327 File Offset: 0x00186527
		public unsafe bool EventDrivenLoaderEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStreamingSettings.__PropertyOffset_EventDrivenLoaderEnabled) & UStreamingSettings.__PropertyMask_EventDrivenLoaderEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStreamingSettings.__PropertyOffset_EventDrivenLoaderEnabled) = ((*(base.NativePtr + (IntPtr)UStreamingSettings.__PropertyOffset_EventDrivenLoaderEnabled) & ~UStreamingSettings.__PropertyMask_EventDrivenLoaderEnabled) | (value ? UStreamingSettings.__PropertyMask_EventDrivenLoaderEnabled : 0));
			}
		}

		// Token: 0x06010B0D RID: 68365 RVA: 0x00188357 File Offset: 0x00186557
		static UStreamingSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.StreamingSettings");
		}

		// Token: 0x06010B0E RID: 68366 RVA: 0x00188365 File Offset: 0x00186565
		protected UStreamingSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008EBE RID: 36542
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.StreamingSettings";

		// Token: 0x04008EBF RID: 36543
		private static IntPtr _ClassPtr;

		// Token: 0x04008EC0 RID: 36544
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008EC1 RID: 36545
		internal static int __PropertyOffset_AsyncLoadingThreadEnabled;

		// Token: 0x04008EC2 RID: 36546
		internal static byte __PropertyMask_AsyncLoadingThreadEnabled;

		// Token: 0x04008EC3 RID: 36547
		internal static int __PropertyOffset_WarnIfTimeLimitExceeded;

		// Token: 0x04008EC4 RID: 36548
		internal static byte __PropertyMask_WarnIfTimeLimitExceeded;

		// Token: 0x04008EC5 RID: 36549
		internal static int __PropertyOffset_TimeLimitExceededMultiplier;

		// Token: 0x04008EC6 RID: 36550
		internal static int __PropertyOffset_TimeLimitExceededMinTime;

		// Token: 0x04008EC7 RID: 36551
		internal static int __PropertyOffset_MinBulkDataSizeForAsyncLoading;

		// Token: 0x04008EC8 RID: 36552
		internal static int __PropertyOffset_UseBackgroundLevelStreaming;

		// Token: 0x04008EC9 RID: 36553
		internal static byte __PropertyMask_UseBackgroundLevelStreaming;

		// Token: 0x04008ECA RID: 36554
		internal static int __PropertyOffset_AsyncLoadingUseFullTimeLimit;

		// Token: 0x04008ECB RID: 36555
		internal static byte __PropertyMask_AsyncLoadingUseFullTimeLimit;

		// Token: 0x04008ECC RID: 36556
		internal static int __PropertyOffset_AsyncLoadingTimeLimit;

		// Token: 0x04008ECD RID: 36557
		internal static int __PropertyOffset_PriorityAsyncLoadingExtraTime;

		// Token: 0x04008ECE RID: 36558
		internal static int __PropertyOffset_LevelStreamingActorsUpdateTimeLimit;

		// Token: 0x04008ECF RID: 36559
		internal static int __PropertyOffset_PriorityLevelStreamingActorsUpdateExtraTime;

		// Token: 0x04008ED0 RID: 36560
		internal static int __PropertyOffset_LevelStreamingComponentsRegistrationGranularity;

		// Token: 0x04008ED1 RID: 36561
		internal static int __PropertyOffset_LevelStreamingUnregisterComponentsTimeLimit;

		// Token: 0x04008ED2 RID: 36562
		internal static int __PropertyOffset_LevelStreamingComponentsUnregistrationGranularity;

		// Token: 0x04008ED3 RID: 36563
		internal static int __PropertyOffset_FlushStreamingOnExit;

		// Token: 0x04008ED4 RID: 36564
		internal static byte __PropertyMask_FlushStreamingOnExit;

		// Token: 0x04008ED5 RID: 36565
		internal static int __PropertyOffset_EventDrivenLoaderEnabled;

		// Token: 0x04008ED6 RID: 36566
		internal static byte __PropertyMask_EventDrivenLoaderEnabled;
	}
}
