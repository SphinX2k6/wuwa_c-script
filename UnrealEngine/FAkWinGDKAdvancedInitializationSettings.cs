using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200025F RID: 607
	[UnrealObjectPath("/Script/AkAudio.AkWinGDKAdvancedInitializationSettings")]
	[UnrealStructLayout(88, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FAkWinGDKAdvancedInitializationSettings : FAkAdvancedInitializationSettingsWithMultiCoreRendering, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600238B RID: 9099 RVA: 0x00034A06 File Offset: 0x00032C06
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAkWinGDKAdvancedInitializationSettings._ScriptStructPtr != 0) ? FAkWinGDKAdvancedInitializationSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AkAudio.AkWinGDKAdvancedInitializationSettings", ref FAkWinGDKAdvancedInitializationSettings._ScriptStructPtr);
		}

		// Token: 0x17000892 RID: 2194
		// (get) Token: 0x0600238C RID: 9100 RVA: 0x00034A2A File Offset: 0x00032C2A
		// (set) Token: 0x0600238D RID: 9101 RVA: 0x00034A3A File Offset: 0x00032C3A
		public unsafe bool UseHeadMountedDisplayAudioDevice
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkWinGDKAdvancedInitializationSettings.__PropertyOffset_UseHeadMountedDisplayAudioDevice) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkWinGDKAdvancedInitializationSettings.__PropertyOffset_UseHeadMountedDisplayAudioDevice) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000893 RID: 2195
		// (get) Token: 0x0600238E RID: 9102 RVA: 0x00034A4B File Offset: 0x00032C4B
		// (set) Token: 0x0600238F RID: 9103 RVA: 0x00034A5B File Offset: 0x00032C5B
		public unsafe uint uMaxSystemAudioObjects
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkWinGDKAdvancedInitializationSettings.__PropertyOffset_uMaxSystemAudioObjects);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkWinGDKAdvancedInitializationSettings.__PropertyOffset_uMaxSystemAudioObjects) = (int)value;
			}
		}

		// Token: 0x06002390 RID: 9104 RVA: 0x00034A6C File Offset: 0x00032C6C
		public FAkWinGDKAdvancedInitializationSettings()
		{
		}

		// Token: 0x06002391 RID: 9105 RVA: 0x00034A74 File Offset: 0x00032C74
		public FAkWinGDKAdvancedInitializationSettings(bool UseHeadMountedDisplayAudioDevice, uint uMaxSystemAudioObjects, bool EnableMultiCoreRendering, uint MaxNumJobWorkers, uint JobWorkerMaxExecutionTimeUSec, uint IO_MemorySize, uint IO_Granularity, float TargetAutoStreamBufferLength, bool UseStreamCache, uint MaximumPinnedBytesInCache, bool EnableGameSyncPreparation, uint ContinuousPlaybackLookAhead, uint MonitorQueuePoolSize, uint MaximumHardwareTimeoutMs, bool DebugOutOfRangeCheckEnabled, float DebugOutOfRangeLimit, EKuroJobWorkerPriority GenericJobWorkerPriority, EKuroJobWorkerPriority AudioProcessingJobWorkerPriority, EKuroJobWorkerPriority SpatialAudioJobWorkerPriority, bool UseKuroThreadPriority, EKuroSoundEngineThreadPriority SoundEngineThreadPriority, bool ShutdownDeviceOnEngineExit, bool AudioCultureMultiChanges, bool HandleShutdownError, bool AkAudioNonblockingDestroy)
		{
			this.UseHeadMountedDisplayAudioDevice = UseHeadMountedDisplayAudioDevice;
			this.uMaxSystemAudioObjects = uMaxSystemAudioObjects;
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

		// Token: 0x06002392 RID: 9106 RVA: 0x00034B4C File Offset: 0x00032D4C
		protected override IntPtr GetUStructPtr()
		{
			return FAkWinGDKAdvancedInitializationSettings.StaticStruct();
		}

		// Token: 0x06002393 RID: 9107 RVA: 0x00034B58 File Offset: 0x00032D58
		[NullableContext(2)]
		public FAkWinGDKAdvancedInitializationSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002394 RID: 9108 RVA: 0x00034B62 File Offset: 0x00032D62
		public FAkWinGDKAdvancedInitializationSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002395 RID: 9109 RVA: 0x00034B6D File Offset: 0x00032D6D
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAkWinGDKAdvancedInitializationSettings(Pointer, false, true);
		}

		// Token: 0x06002396 RID: 9110 RVA: 0x00034B77 File Offset: 0x00032D77
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAkWinGDKAdvancedInitializationSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04000C4C RID: 3148
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkWinGDKAdvancedInitializationSettings";

		// Token: 0x04000C4D RID: 3149
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000C4E RID: 3150
		internal static int __PropertyOffset_UseHeadMountedDisplayAudioDevice;

		// Token: 0x04000C4F RID: 3151
		internal static int __PropertyOffset_uMaxSystemAudioObjects;
	}
}
