using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020001EA RID: 490
	[UnrealObjectPath("/Script/AkAudio.AkAndroidAdvancedInitializationSettings")]
	[UnrealStructLayout(96, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FAkAndroidAdvancedInitializationSettings : FAkAdvancedInitializationSettingsWithMultiCoreRendering, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06001CEF RID: 7407 RVA: 0x0002B128 File Offset: 0x00029328
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAkAndroidAdvancedInitializationSettings._ScriptStructPtr != 0) ? FAkAndroidAdvancedInitializationSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AkAudio.AkAndroidAdvancedInitializationSettings", ref FAkAndroidAdvancedInitializationSettings._ScriptStructPtr);
		}

		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x06001CF0 RID: 7408 RVA: 0x0002B14C File Offset: 0x0002934C
		// (set) Token: 0x06001CF1 RID: 7409 RVA: 0x0002B15C File Offset: 0x0002935C
		public unsafe uint AudioAPI
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkAndroidAdvancedInitializationSettings.__PropertyOffset_AudioAPI);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkAndroidAdvancedInitializationSettings.__PropertyOffset_AudioAPI) = (int)value;
			}
		}

		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x06001CF2 RID: 7410 RVA: 0x0002B16D File Offset: 0x0002936D
		// (set) Token: 0x06001CF3 RID: 7411 RVA: 0x0002B17D File Offset: 0x0002937D
		public unsafe uint SpatializerAPI
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkAndroidAdvancedInitializationSettings.__PropertyOffset_SpatializerAPI);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkAndroidAdvancedInitializationSettings.__PropertyOffset_SpatializerAPI) = (int)value;
			}
		}

		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x06001CF4 RID: 7412 RVA: 0x0002B18E File Offset: 0x0002938E
		// (set) Token: 0x06001CF5 RID: 7413 RVA: 0x0002B19E File Offset: 0x0002939E
		public unsafe EAkAndroidAudioPath AudioPath
		{
			get
			{
				return (EAkAndroidAudioPath)(*(base.NativePtr + (IntPtr)FAkAndroidAdvancedInitializationSettings.__PropertyOffset_AudioPath));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkAndroidAdvancedInitializationSettings.__PropertyOffset_AudioPath) = (int)value;
			}
		}

		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x06001CF6 RID: 7414 RVA: 0x0002B1AF File Offset: 0x000293AF
		// (set) Token: 0x06001CF7 RID: 7415 RVA: 0x0002B1BF File Offset: 0x000293BF
		public unsafe bool RoundFrameSizeToHardwareSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkAndroidAdvancedInitializationSettings.__PropertyOffset_RoundFrameSizeToHardwareSize) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkAndroidAdvancedInitializationSettings.__PropertyOffset_RoundFrameSizeToHardwareSize) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x06001CF8 RID: 7416 RVA: 0x0002B1D0 File Offset: 0x000293D0
		// (set) Token: 0x06001CF9 RID: 7417 RVA: 0x0002B1E0 File Offset: 0x000293E0
		public unsafe bool UseLowLatencyMode_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkAndroidAdvancedInitializationSettings.__PropertyOffset_UseLowLatencyMode_DEPRECATED) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkAndroidAdvancedInitializationSettings.__PropertyOffset_UseLowLatencyMode_DEPRECATED) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x06001CFA RID: 7418 RVA: 0x0002B1F1 File Offset: 0x000293F1
		// (set) Token: 0x06001CFB RID: 7419 RVA: 0x0002B201 File Offset: 0x00029401
		public unsafe bool bVerboseSink
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkAndroidAdvancedInitializationSettings.__PropertyOffset_bVerboseSink) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkAndroidAdvancedInitializationSettings.__PropertyOffset_bVerboseSink) = (value ? 1 : 0);
			}
		}

		// Token: 0x06001CFC RID: 7420 RVA: 0x0002B212 File Offset: 0x00029412
		public FAkAndroidAdvancedInitializationSettings()
		{
		}

		// Token: 0x06001CFD RID: 7421 RVA: 0x0002B21C File Offset: 0x0002941C
		public FAkAndroidAdvancedInitializationSettings(uint AudioAPI, uint SpatializerAPI, EAkAndroidAudioPath AudioPath, bool RoundFrameSizeToHardwareSize, bool UseLowLatencyMode_DEPRECATED, bool bVerboseSink, bool EnableMultiCoreRendering, uint MaxNumJobWorkers, uint JobWorkerMaxExecutionTimeUSec, uint IO_MemorySize, uint IO_Granularity, float TargetAutoStreamBufferLength, bool UseStreamCache, uint MaximumPinnedBytesInCache, bool EnableGameSyncPreparation, uint ContinuousPlaybackLookAhead, uint MonitorQueuePoolSize, uint MaximumHardwareTimeoutMs, bool DebugOutOfRangeCheckEnabled, float DebugOutOfRangeLimit, EKuroJobWorkerPriority GenericJobWorkerPriority, EKuroJobWorkerPriority AudioProcessingJobWorkerPriority, EKuroJobWorkerPriority SpatialAudioJobWorkerPriority, bool UseKuroThreadPriority, EKuroSoundEngineThreadPriority SoundEngineThreadPriority, bool ShutdownDeviceOnEngineExit, bool AudioCultureMultiChanges, bool HandleShutdownError, bool AkAudioNonblockingDestroy)
		{
			this.AudioAPI = AudioAPI;
			this.SpatializerAPI = SpatializerAPI;
			this.AudioPath = AudioPath;
			this.RoundFrameSizeToHardwareSize = RoundFrameSizeToHardwareSize;
			this.UseLowLatencyMode_DEPRECATED = UseLowLatencyMode_DEPRECATED;
			this.bVerboseSink = bVerboseSink;
			base.EnableMultiCoreRendering = EnableMultiCoreRendering;
			base.MaxNumJobWorkers = MaxNumJobWorkers;
			base.JobWorkerMaxExecutionTimeUSec = JobWorkerMaxExecutionTimeUSec;
			base.IO_MemorySize = IO_MemorySize;
			base.IO_Granularity = IO_Granularity;
			base.TargetAutoStreamBufferLength = TargetAutoStreamBufferLength;
			base.UseStreamCache = UseStreamCache;
			base.MaximumPinnedBytesInCache = MaximumPinnedBytesInCache;
			base.EnableGameSyncPreparation = EnableGameSyncPreparation;
			base.ContinuousPlaybackLookAhead = ContinuousPlaybackLookAhead;
			base.MonitorQueuePoolSize = MonitorQueuePoolSize;
			base.MaximumHardwareTimeoutMs = MaximumHardwareTimeoutMs;
			base.DebugOutOfRangeCheckEnabled = DebugOutOfRangeCheckEnabled;
			base.DebugOutOfRangeLimit = DebugOutOfRangeLimit;
			base.GenericJobWorkerPriority = GenericJobWorkerPriority;
			base.AudioProcessingJobWorkerPriority = AudioProcessingJobWorkerPriority;
			base.SpatialAudioJobWorkerPriority = SpatialAudioJobWorkerPriority;
			base.UseKuroThreadPriority = UseKuroThreadPriority;
			base.SoundEngineThreadPriority = SoundEngineThreadPriority;
			base.ShutdownDeviceOnEngineExit = ShutdownDeviceOnEngineExit;
			base.AudioCultureMultiChanges = AudioCultureMultiChanges;
			base.HandleShutdownError = HandleShutdownError;
			base.AkAudioNonblockingDestroy = AkAudioNonblockingDestroy;
		}

		// Token: 0x06001CFE RID: 7422 RVA: 0x0002B314 File Offset: 0x00029514
		protected override IntPtr GetUStructPtr()
		{
			return FAkAndroidAdvancedInitializationSettings.StaticStruct();
		}

		// Token: 0x06001CFF RID: 7423 RVA: 0x0002B320 File Offset: 0x00029520
		[NullableContext(2)]
		public FAkAndroidAdvancedInitializationSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001D00 RID: 7424 RVA: 0x0002B32A File Offset: 0x0002952A
		public FAkAndroidAdvancedInitializationSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06001D01 RID: 7425 RVA: 0x0002B335 File Offset: 0x00029535
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAkAndroidAdvancedInitializationSettings(Pointer, false, true);
		}

		// Token: 0x06001D02 RID: 7426 RVA: 0x0002B33F File Offset: 0x0002953F
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAkAndroidAdvancedInitializationSettings(Pointer, MemoryOwner);
		}

		// Token: 0x0400097B RID: 2427
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkAndroidAdvancedInitializationSettings";

		// Token: 0x0400097C RID: 2428
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400097D RID: 2429
		internal static int __PropertyOffset_AudioAPI;

		// Token: 0x0400097E RID: 2430
		internal static int __PropertyOffset_SpatializerAPI;

		// Token: 0x0400097F RID: 2431
		internal static int __PropertyOffset_AudioPath;

		// Token: 0x04000980 RID: 2432
		internal static int __PropertyOffset_RoundFrameSizeToHardwareSize;

		// Token: 0x04000981 RID: 2433
		internal static int __PropertyOffset_UseLowLatencyMode_DEPRECATED;

		// Token: 0x04000982 RID: 2434
		internal static int __PropertyOffset_bVerboseSink;
	}
}
