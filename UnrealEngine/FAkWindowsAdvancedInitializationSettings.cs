using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200025C RID: 604
	[UnrealObjectPath("/Script/AkAudio.AkWindowsAdvancedInitializationSettings")]
	[UnrealStructLayout(88, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FAkWindowsAdvancedInitializationSettings : FAkAdvancedInitializationSettingsWithMultiCoreRendering, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600236D RID: 9069 RVA: 0x0003466E File Offset: 0x0003286E
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAkWindowsAdvancedInitializationSettings._ScriptStructPtr != 0) ? FAkWindowsAdvancedInitializationSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AkAudio.AkWindowsAdvancedInitializationSettings", ref FAkWindowsAdvancedInitializationSettings._ScriptStructPtr);
		}

		// Token: 0x1700088D RID: 2189
		// (get) Token: 0x0600236E RID: 9070 RVA: 0x00034692 File Offset: 0x00032892
		// (set) Token: 0x0600236F RID: 9071 RVA: 0x000346A2 File Offset: 0x000328A2
		public unsafe bool UseHeadMountedDisplayAudioDevice
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkWindowsAdvancedInitializationSettings.__PropertyOffset_UseHeadMountedDisplayAudioDevice) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkWindowsAdvancedInitializationSettings.__PropertyOffset_UseHeadMountedDisplayAudioDevice) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700088E RID: 2190
		// (get) Token: 0x06002370 RID: 9072 RVA: 0x000346B3 File Offset: 0x000328B3
		// (set) Token: 0x06002371 RID: 9073 RVA: 0x000346C3 File Offset: 0x000328C3
		public unsafe uint MaxSystemAudioObjects
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkWindowsAdvancedInitializationSettings.__PropertyOffset_MaxSystemAudioObjects);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkWindowsAdvancedInitializationSettings.__PropertyOffset_MaxSystemAudioObjects) = (int)value;
			}
		}

		// Token: 0x06002372 RID: 9074 RVA: 0x000346D4 File Offset: 0x000328D4
		public FAkWindowsAdvancedInitializationSettings()
		{
		}

		// Token: 0x06002373 RID: 9075 RVA: 0x000346DC File Offset: 0x000328DC
		public FAkWindowsAdvancedInitializationSettings(bool UseHeadMountedDisplayAudioDevice, uint MaxSystemAudioObjects, bool EnableMultiCoreRendering, uint MaxNumJobWorkers, uint JobWorkerMaxExecutionTimeUSec, uint IO_MemorySize, uint IO_Granularity, float TargetAutoStreamBufferLength, bool UseStreamCache, uint MaximumPinnedBytesInCache, bool EnableGameSyncPreparation, uint ContinuousPlaybackLookAhead, uint MonitorQueuePoolSize, uint MaximumHardwareTimeoutMs, bool DebugOutOfRangeCheckEnabled, float DebugOutOfRangeLimit, EKuroJobWorkerPriority GenericJobWorkerPriority, EKuroJobWorkerPriority AudioProcessingJobWorkerPriority, EKuroJobWorkerPriority SpatialAudioJobWorkerPriority, bool UseKuroThreadPriority, EKuroSoundEngineThreadPriority SoundEngineThreadPriority, bool ShutdownDeviceOnEngineExit, bool AudioCultureMultiChanges, bool HandleShutdownError, bool AkAudioNonblockingDestroy)
		{
			this.UseHeadMountedDisplayAudioDevice = UseHeadMountedDisplayAudioDevice;
			this.MaxSystemAudioObjects = MaxSystemAudioObjects;
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

		// Token: 0x06002374 RID: 9076 RVA: 0x000347B4 File Offset: 0x000329B4
		protected override IntPtr GetUStructPtr()
		{
			return FAkWindowsAdvancedInitializationSettings.StaticStruct();
		}

		// Token: 0x06002375 RID: 9077 RVA: 0x000347C0 File Offset: 0x000329C0
		[NullableContext(2)]
		public FAkWindowsAdvancedInitializationSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002376 RID: 9078 RVA: 0x000347CA File Offset: 0x000329CA
		public FAkWindowsAdvancedInitializationSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002377 RID: 9079 RVA: 0x000347D5 File Offset: 0x000329D5
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAkWindowsAdvancedInitializationSettings(Pointer, false, true);
		}

		// Token: 0x06002378 RID: 9080 RVA: 0x000347DF File Offset: 0x000329DF
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAkWindowsAdvancedInitializationSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04000C3C RID: 3132
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkWindowsAdvancedInitializationSettings";

		// Token: 0x04000C3D RID: 3133
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000C3E RID: 3134
		internal static int __PropertyOffset_UseHeadMountedDisplayAudioDevice;

		// Token: 0x04000C3F RID: 3135
		internal static int __PropertyOffset_MaxSystemAudioObjects;
	}
}
