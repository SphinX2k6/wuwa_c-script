using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200020E RID: 526
	[UnrealObjectPath("/Script/AkAudio.AkIOSAdvancedInitializationSettings")]
	[UnrealStructLayout(88, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FAkIOSAdvancedInitializationSettings : FAkAdvancedInitializationSettingsWithMultiCoreRendering, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06001F57 RID: 8023 RVA: 0x0002E521 File Offset: 0x0002C721
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAkIOSAdvancedInitializationSettings._ScriptStructPtr != 0) ? FAkIOSAdvancedInitializationSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AkAudio.AkIOSAdvancedInitializationSettings", ref FAkIOSAdvancedInitializationSettings._ScriptStructPtr);
		}

		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x06001F58 RID: 8024 RVA: 0x0002E545 File Offset: 0x0002C745
		// (set) Token: 0x06001F59 RID: 8025 RVA: 0x0002E555 File Offset: 0x0002C755
		public unsafe uint uNumSpatialAudioPointSources
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkIOSAdvancedInitializationSettings.__PropertyOffset_uNumSpatialAudioPointSources);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkIOSAdvancedInitializationSettings.__PropertyOffset_uNumSpatialAudioPointSources) = (int)value;
			}
		}

		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x06001F5A RID: 8026 RVA: 0x0002E566 File Offset: 0x0002C766
		// (set) Token: 0x06001F5B RID: 8027 RVA: 0x0002E576 File Offset: 0x0002C776
		public unsafe bool bVerboseSystemOutput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkIOSAdvancedInitializationSettings.__PropertyOffset_bVerboseSystemOutput) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkIOSAdvancedInitializationSettings.__PropertyOffset_bVerboseSystemOutput) = (value ? 1 : 0);
			}
		}

		// Token: 0x06001F5C RID: 8028 RVA: 0x0002E587 File Offset: 0x0002C787
		public FAkIOSAdvancedInitializationSettings()
		{
		}

		// Token: 0x06001F5D RID: 8029 RVA: 0x0002E590 File Offset: 0x0002C790
		public FAkIOSAdvancedInitializationSettings(uint uNumSpatialAudioPointSources, bool bVerboseSystemOutput, bool EnableMultiCoreRendering, uint MaxNumJobWorkers, uint JobWorkerMaxExecutionTimeUSec, uint IO_MemorySize, uint IO_Granularity, float TargetAutoStreamBufferLength, bool UseStreamCache, uint MaximumPinnedBytesInCache, bool EnableGameSyncPreparation, uint ContinuousPlaybackLookAhead, uint MonitorQueuePoolSize, uint MaximumHardwareTimeoutMs, bool DebugOutOfRangeCheckEnabled, float DebugOutOfRangeLimit, EKuroJobWorkerPriority GenericJobWorkerPriority, EKuroJobWorkerPriority AudioProcessingJobWorkerPriority, EKuroJobWorkerPriority SpatialAudioJobWorkerPriority, bool UseKuroThreadPriority, EKuroSoundEngineThreadPriority SoundEngineThreadPriority, bool ShutdownDeviceOnEngineExit, bool AudioCultureMultiChanges, bool HandleShutdownError, bool AkAudioNonblockingDestroy)
		{
			this.uNumSpatialAudioPointSources = uNumSpatialAudioPointSources;
			this.bVerboseSystemOutput = bVerboseSystemOutput;
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

		// Token: 0x06001F5E RID: 8030 RVA: 0x0002E668 File Offset: 0x0002C868
		protected override IntPtr GetUStructPtr()
		{
			return FAkIOSAdvancedInitializationSettings.StaticStruct();
		}

		// Token: 0x06001F5F RID: 8031 RVA: 0x0002E674 File Offset: 0x0002C874
		[NullableContext(2)]
		public FAkIOSAdvancedInitializationSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001F60 RID: 8032 RVA: 0x0002E67E File Offset: 0x0002C87E
		public FAkIOSAdvancedInitializationSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06001F61 RID: 8033 RVA: 0x0002E689 File Offset: 0x0002C889
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAkIOSAdvancedInitializationSettings(Pointer, false, true);
		}

		// Token: 0x06001F62 RID: 8034 RVA: 0x0002E693 File Offset: 0x0002C893
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAkIOSAdvancedInitializationSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04000A55 RID: 2645
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkIOSAdvancedInitializationSettings";

		// Token: 0x04000A56 RID: 2646
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000A57 RID: 2647
		internal static int __PropertyOffset_uNumSpatialAudioPointSources;

		// Token: 0x04000A58 RID: 2648
		internal static int __PropertyOffset_bVerboseSystemOutput;
	}
}
