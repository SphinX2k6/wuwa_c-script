using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200021B RID: 539
	[UnrealObjectPath("/Script/AkAudio.AkMacAdvancedInitializationSettings")]
	[UnrealStructLayout(88, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FAkMacAdvancedInitializationSettings : FAkAdvancedInitializationSettingsWithMultiCoreRendering, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06001FE5 RID: 8165 RVA: 0x0002F406 File Offset: 0x0002D606
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAkMacAdvancedInitializationSettings._ScriptStructPtr != 0) ? FAkMacAdvancedInitializationSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AkAudio.AkMacAdvancedInitializationSettings", ref FAkMacAdvancedInitializationSettings._ScriptStructPtr);
		}

		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x06001FE6 RID: 8166 RVA: 0x0002F42A File Offset: 0x0002D62A
		// (set) Token: 0x06001FE7 RID: 8167 RVA: 0x0002F43A File Offset: 0x0002D63A
		public unsafe uint uNumSpatialAudioPointSources
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkMacAdvancedInitializationSettings.__PropertyOffset_uNumSpatialAudioPointSources);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkMacAdvancedInitializationSettings.__PropertyOffset_uNumSpatialAudioPointSources) = (int)value;
			}
		}

		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x06001FE8 RID: 8168 RVA: 0x0002F44B File Offset: 0x0002D64B
		// (set) Token: 0x06001FE9 RID: 8169 RVA: 0x0002F45B File Offset: 0x0002D65B
		public unsafe bool bVerboseSystemOutput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkMacAdvancedInitializationSettings.__PropertyOffset_bVerboseSystemOutput) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkMacAdvancedInitializationSettings.__PropertyOffset_bVerboseSystemOutput) = (value ? 1 : 0);
			}
		}

		// Token: 0x06001FEA RID: 8170 RVA: 0x0002F46C File Offset: 0x0002D66C
		public FAkMacAdvancedInitializationSettings()
		{
		}

		// Token: 0x06001FEB RID: 8171 RVA: 0x0002F474 File Offset: 0x0002D674
		public FAkMacAdvancedInitializationSettings(uint uNumSpatialAudioPointSources, bool bVerboseSystemOutput, bool EnableMultiCoreRendering, uint MaxNumJobWorkers, uint JobWorkerMaxExecutionTimeUSec, uint IO_MemorySize, uint IO_Granularity, float TargetAutoStreamBufferLength, bool UseStreamCache, uint MaximumPinnedBytesInCache, bool EnableGameSyncPreparation, uint ContinuousPlaybackLookAhead, uint MonitorQueuePoolSize, uint MaximumHardwareTimeoutMs, bool DebugOutOfRangeCheckEnabled, float DebugOutOfRangeLimit, EKuroJobWorkerPriority GenericJobWorkerPriority, EKuroJobWorkerPriority AudioProcessingJobWorkerPriority, EKuroJobWorkerPriority SpatialAudioJobWorkerPriority, bool UseKuroThreadPriority, EKuroSoundEngineThreadPriority SoundEngineThreadPriority, bool ShutdownDeviceOnEngineExit, bool AudioCultureMultiChanges, bool HandleShutdownError, bool AkAudioNonblockingDestroy)
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

		// Token: 0x06001FEC RID: 8172 RVA: 0x0002F54C File Offset: 0x0002D74C
		protected override IntPtr GetUStructPtr()
		{
			return FAkMacAdvancedInitializationSettings.StaticStruct();
		}

		// Token: 0x06001FED RID: 8173 RVA: 0x0002F558 File Offset: 0x0002D758
		[NullableContext(2)]
		public FAkMacAdvancedInitializationSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001FEE RID: 8174 RVA: 0x0002F562 File Offset: 0x0002D762
		public FAkMacAdvancedInitializationSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06001FEF RID: 8175 RVA: 0x0002F56D File Offset: 0x0002D76D
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAkMacAdvancedInitializationSettings(Pointer, false, true);
		}

		// Token: 0x06001FF0 RID: 8176 RVA: 0x0002F577 File Offset: 0x0002D777
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAkMacAdvancedInitializationSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04000AA1 RID: 2721
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkMacAdvancedInitializationSettings";

		// Token: 0x04000AA2 RID: 2722
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000AA3 RID: 2723
		internal static int __PropertyOffset_uNumSpatialAudioPointSources;

		// Token: 0x04000AA4 RID: 2724
		internal static int __PropertyOffset_bVerboseSystemOutput;
	}
}
