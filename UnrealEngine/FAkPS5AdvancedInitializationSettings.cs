using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000237 RID: 567
	[UnrealObjectPath("/Script/AkAudio.AkPS5AdvancedInitializationSettings")]
	[UnrealStructLayout(100, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 100)]
	public class FAkPS5AdvancedInitializationSettings : FAkAdvancedInitializationSettingsWithMultiCoreRendering, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002119 RID: 8473 RVA: 0x00031274 File Offset: 0x0002F474
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAkPS5AdvancedInitializationSettings._ScriptStructPtr != 0) ? FAkPS5AdvancedInitializationSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AkAudio.AkPS5AdvancedInitializationSettings", ref FAkPS5AdvancedInitializationSettings._ScriptStructPtr);
		}

		// Token: 0x170007FB RID: 2043
		// (get) Token: 0x0600211A RID: 8474 RVA: 0x00031298 File Offset: 0x0002F498
		// (set) Token: 0x0600211B RID: 8475 RVA: 0x000312A8 File Offset: 0x0002F4A8
		public unsafe bool UseHardwareCodecLowLatencyMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkPS5AdvancedInitializationSettings.__PropertyOffset_UseHardwareCodecLowLatencyMode) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkPS5AdvancedInitializationSettings.__PropertyOffset_UseHardwareCodecLowLatencyMode) = (value ? 1 : 0);
			}
		}

		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x0600211C RID: 8476 RVA: 0x000312B9 File Offset: 0x0002F4B9
		// (set) Token: 0x0600211D RID: 8477 RVA: 0x000312C9 File Offset: 0x0002F4C9
		public unsafe bool bVorbisHwAcceleration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkPS5AdvancedInitializationSettings.__PropertyOffset_bVorbisHwAcceleration) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkPS5AdvancedInitializationSettings.__PropertyOffset_bVorbisHwAcceleration) = (value ? 1 : 0);
			}
		}

		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x0600211E RID: 8478 RVA: 0x000312DA File Offset: 0x0002F4DA
		// (set) Token: 0x0600211F RID: 8479 RVA: 0x000312EA File Offset: 0x0002F4EA
		public unsafe bool bEnable3DAudioSync
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkPS5AdvancedInitializationSettings.__PropertyOffset_bEnable3DAudioSync) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkPS5AdvancedInitializationSettings.__PropertyOffset_bEnable3DAudioSync) = (value ? 1 : 0);
			}
		}

		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x06002120 RID: 8480 RVA: 0x000312FB File Offset: 0x0002F4FB
		// (set) Token: 0x06002121 RID: 8481 RVA: 0x0003130B File Offset: 0x0002F50B
		public unsafe uint uNumOperationsForHwMixing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkPS5AdvancedInitializationSettings.__PropertyOffset_uNumOperationsForHwMixing);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkPS5AdvancedInitializationSettings.__PropertyOffset_uNumOperationsForHwMixing) = (int)value;
			}
		}

		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x06002122 RID: 8482 RVA: 0x0003131C File Offset: 0x0002F51C
		// (set) Token: 0x06002123 RID: 8483 RVA: 0x0003132C File Offset: 0x0002F52C
		public unsafe bool bPlotQueueLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkPS5AdvancedInitializationSettings.__PropertyOffset_bPlotQueueLevel) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkPS5AdvancedInitializationSettings.__PropertyOffset_bPlotQueueLevel) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x06002124 RID: 8484 RVA: 0x0003133D File Offset: 0x0002F53D
		// (set) Token: 0x06002125 RID: 8485 RVA: 0x0003134D File Offset: 0x0002F54D
		public unsafe uint NumAudioOut2Ports
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkPS5AdvancedInitializationSettings.__PropertyOffset_NumAudioOut2Ports);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkPS5AdvancedInitializationSettings.__PropertyOffset_NumAudioOut2Ports) = (int)value;
			}
		}

		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x06002126 RID: 8486 RVA: 0x0003135E File Offset: 0x0002F55E
		// (set) Token: 0x06002127 RID: 8487 RVA: 0x0003136E File Offset: 0x0002F56E
		public unsafe uint NumAudioOut2ObjectPorts
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkPS5AdvancedInitializationSettings.__PropertyOffset_NumAudioOut2ObjectPorts);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkPS5AdvancedInitializationSettings.__PropertyOffset_NumAudioOut2ObjectPorts) = (int)value;
			}
		}

		// Token: 0x06002128 RID: 8488 RVA: 0x0003137F File Offset: 0x0002F57F
		public FAkPS5AdvancedInitializationSettings()
		{
		}

		// Token: 0x06002129 RID: 8489 RVA: 0x00031388 File Offset: 0x0002F588
		public FAkPS5AdvancedInitializationSettings(bool UseHardwareCodecLowLatencyMode, bool bVorbisHwAcceleration, bool bEnable3DAudioSync, uint uNumOperationsForHwMixing, bool bPlotQueueLevel, uint NumAudioOut2Ports, uint NumAudioOut2ObjectPorts, bool EnableMultiCoreRendering, uint MaxNumJobWorkers, uint JobWorkerMaxExecutionTimeUSec, uint IO_MemorySize, uint IO_Granularity, float TargetAutoStreamBufferLength, bool UseStreamCache, uint MaximumPinnedBytesInCache, bool EnableGameSyncPreparation, uint ContinuousPlaybackLookAhead, uint MonitorQueuePoolSize, uint MaximumHardwareTimeoutMs, bool DebugOutOfRangeCheckEnabled, float DebugOutOfRangeLimit, EKuroJobWorkerPriority GenericJobWorkerPriority, EKuroJobWorkerPriority AudioProcessingJobWorkerPriority, EKuroJobWorkerPriority SpatialAudioJobWorkerPriority, bool UseKuroThreadPriority, EKuroSoundEngineThreadPriority SoundEngineThreadPriority, bool ShutdownDeviceOnEngineExit, bool AudioCultureMultiChanges, bool HandleShutdownError, bool AkAudioNonblockingDestroy)
		{
			this.UseHardwareCodecLowLatencyMode = UseHardwareCodecLowLatencyMode;
			this.bVorbisHwAcceleration = bVorbisHwAcceleration;
			this.bEnable3DAudioSync = bEnable3DAudioSync;
			this.uNumOperationsForHwMixing = uNumOperationsForHwMixing;
			this.bPlotQueueLevel = bPlotQueueLevel;
			this.NumAudioOut2Ports = NumAudioOut2Ports;
			this.NumAudioOut2ObjectPorts = NumAudioOut2ObjectPorts;
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

		// Token: 0x0600212A RID: 8490 RVA: 0x00031488 File Offset: 0x0002F688
		protected override IntPtr GetUStructPtr()
		{
			return FAkPS5AdvancedInitializationSettings.StaticStruct();
		}

		// Token: 0x0600212B RID: 8491 RVA: 0x00031494 File Offset: 0x0002F694
		[NullableContext(2)]
		public FAkPS5AdvancedInitializationSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600212C RID: 8492 RVA: 0x0003149E File Offset: 0x0002F69E
		public FAkPS5AdvancedInitializationSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600212D RID: 8493 RVA: 0x000314A9 File Offset: 0x0002F6A9
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAkPS5AdvancedInitializationSettings(Pointer, false, true);
		}

		// Token: 0x0600212E RID: 8494 RVA: 0x000314B3 File Offset: 0x0002F6B3
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAkPS5AdvancedInitializationSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04000B2A RID: 2858
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkPS5AdvancedInitializationSettings";

		// Token: 0x04000B2B RID: 2859
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000B2C RID: 2860
		internal static int __PropertyOffset_UseHardwareCodecLowLatencyMode;

		// Token: 0x04000B2D RID: 2861
		internal static int __PropertyOffset_bVorbisHwAcceleration;

		// Token: 0x04000B2E RID: 2862
		internal static int __PropertyOffset_bEnable3DAudioSync;

		// Token: 0x04000B2F RID: 2863
		internal static int __PropertyOffset_uNumOperationsForHwMixing;

		// Token: 0x04000B30 RID: 2864
		internal static int __PropertyOffset_bPlotQueueLevel;

		// Token: 0x04000B31 RID: 2865
		internal static int __PropertyOffset_NumAudioOut2Ports;

		// Token: 0x04000B32 RID: 2866
		internal static int __PropertyOffset_NumAudioOut2ObjectPorts;
	}
}
