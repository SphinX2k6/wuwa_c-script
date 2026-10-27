using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200022F RID: 559
	[UnrealObjectPath("/Script/AkAudio.AkOpenHarmonyAdvancedInitializationSettings")]
	[UnrealStructLayout(88, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FAkOpenHarmonyAdvancedInitializationSettings : FAkAdvancedInitializationSettingsWithMultiCoreRendering, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060020C1 RID: 8385 RVA: 0x00030B16 File Offset: 0x0002ED16
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAkOpenHarmonyAdvancedInitializationSettings._ScriptStructPtr != 0) ? FAkOpenHarmonyAdvancedInitializationSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AkAudio.AkOpenHarmonyAdvancedInitializationSettings", ref FAkOpenHarmonyAdvancedInitializationSettings._ScriptStructPtr);
		}

		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x060020C2 RID: 8386 RVA: 0x00030B3A File Offset: 0x0002ED3A
		// (set) Token: 0x060020C3 RID: 8387 RVA: 0x00030B4A File Offset: 0x0002ED4A
		public unsafe uint AudioAPI
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkOpenHarmonyAdvancedInitializationSettings.__PropertyOffset_AudioAPI);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkOpenHarmonyAdvancedInitializationSettings.__PropertyOffset_AudioAPI) = (int)value;
			}
		}

		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x060020C4 RID: 8388 RVA: 0x00030B5B File Offset: 0x0002ED5B
		// (set) Token: 0x060020C5 RID: 8389 RVA: 0x00030B6B File Offset: 0x0002ED6B
		public unsafe bool RoundFrameSizeToHardwareSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkOpenHarmonyAdvancedInitializationSettings.__PropertyOffset_RoundFrameSizeToHardwareSize) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkOpenHarmonyAdvancedInitializationSettings.__PropertyOffset_RoundFrameSizeToHardwareSize) = (value ? 1 : 0);
			}
		}

		// Token: 0x060020C6 RID: 8390 RVA: 0x00030B7C File Offset: 0x0002ED7C
		public FAkOpenHarmonyAdvancedInitializationSettings()
		{
		}

		// Token: 0x060020C7 RID: 8391 RVA: 0x00030B84 File Offset: 0x0002ED84
		public FAkOpenHarmonyAdvancedInitializationSettings(uint AudioAPI, bool RoundFrameSizeToHardwareSize, bool EnableMultiCoreRendering, uint MaxNumJobWorkers, uint JobWorkerMaxExecutionTimeUSec, uint IO_MemorySize, uint IO_Granularity, float TargetAutoStreamBufferLength, bool UseStreamCache, uint MaximumPinnedBytesInCache, bool EnableGameSyncPreparation, uint ContinuousPlaybackLookAhead, uint MonitorQueuePoolSize, uint MaximumHardwareTimeoutMs, bool DebugOutOfRangeCheckEnabled, float DebugOutOfRangeLimit, EKuroJobWorkerPriority GenericJobWorkerPriority, EKuroJobWorkerPriority AudioProcessingJobWorkerPriority, EKuroJobWorkerPriority SpatialAudioJobWorkerPriority, bool UseKuroThreadPriority, EKuroSoundEngineThreadPriority SoundEngineThreadPriority, bool ShutdownDeviceOnEngineExit, bool AudioCultureMultiChanges, bool HandleShutdownError, bool AkAudioNonblockingDestroy)
		{
			this.AudioAPI = AudioAPI;
			this.RoundFrameSizeToHardwareSize = RoundFrameSizeToHardwareSize;
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

		// Token: 0x060020C8 RID: 8392 RVA: 0x00030C5C File Offset: 0x0002EE5C
		protected override IntPtr GetUStructPtr()
		{
			return FAkOpenHarmonyAdvancedInitializationSettings.StaticStruct();
		}

		// Token: 0x060020C9 RID: 8393 RVA: 0x00030C68 File Offset: 0x0002EE68
		[NullableContext(2)]
		public FAkOpenHarmonyAdvancedInitializationSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060020CA RID: 8394 RVA: 0x00030C72 File Offset: 0x0002EE72
		public FAkOpenHarmonyAdvancedInitializationSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060020CB RID: 8395 RVA: 0x00030C7D File Offset: 0x0002EE7D
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAkOpenHarmonyAdvancedInitializationSettings(Pointer, false, true);
		}

		// Token: 0x060020CC RID: 8396 RVA: 0x00030C87 File Offset: 0x0002EE87
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAkOpenHarmonyAdvancedInitializationSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04000B04 RID: 2820
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkOpenHarmonyAdvancedInitializationSettings";

		// Token: 0x04000B05 RID: 2821
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000B06 RID: 2822
		internal static int __PropertyOffset_AudioAPI;

		// Token: 0x04000B07 RID: 2823
		internal static int __PropertyOffset_RoundFrameSizeToHardwareSize;
	}
}
