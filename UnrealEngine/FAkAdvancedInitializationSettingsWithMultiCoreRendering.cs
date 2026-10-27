using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020001E8 RID: 488
	[UnrealObjectPath("/Script/AkAudio.AkAdvancedInitializationSettingsWithMultiCoreRendering")]
	[UnrealStructLayout(80, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FAkAdvancedInitializationSettingsWithMultiCoreRendering : FAkAdvancedInitializationSettings, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06001CD0 RID: 7376 RVA: 0x0002AE70 File Offset: 0x00029070
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAkAdvancedInitializationSettingsWithMultiCoreRendering._ScriptStructPtr != 0) ? FAkAdvancedInitializationSettingsWithMultiCoreRendering._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AkAudio.AkAdvancedInitializationSettingsWithMultiCoreRendering", ref FAkAdvancedInitializationSettingsWithMultiCoreRendering._ScriptStructPtr);
		}

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x06001CD1 RID: 7377 RVA: 0x0002AE94 File Offset: 0x00029094
		// (set) Token: 0x06001CD2 RID: 7378 RVA: 0x0002AEA4 File Offset: 0x000290A4
		public unsafe bool EnableMultiCoreRendering
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkAdvancedInitializationSettingsWithMultiCoreRendering.__PropertyOffset_EnableMultiCoreRendering) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkAdvancedInitializationSettingsWithMultiCoreRendering.__PropertyOffset_EnableMultiCoreRendering) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x06001CD3 RID: 7379 RVA: 0x0002AEB5 File Offset: 0x000290B5
		// (set) Token: 0x06001CD4 RID: 7380 RVA: 0x0002AEC5 File Offset: 0x000290C5
		public unsafe uint MaxNumJobWorkers
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkAdvancedInitializationSettingsWithMultiCoreRendering.__PropertyOffset_MaxNumJobWorkers);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkAdvancedInitializationSettingsWithMultiCoreRendering.__PropertyOffset_MaxNumJobWorkers) = (int)value;
			}
		}

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x06001CD5 RID: 7381 RVA: 0x0002AED6 File Offset: 0x000290D6
		// (set) Token: 0x06001CD6 RID: 7382 RVA: 0x0002AEE6 File Offset: 0x000290E6
		public unsafe uint JobWorkerMaxExecutionTimeUSec
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkAdvancedInitializationSettingsWithMultiCoreRendering.__PropertyOffset_JobWorkerMaxExecutionTimeUSec);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkAdvancedInitializationSettingsWithMultiCoreRendering.__PropertyOffset_JobWorkerMaxExecutionTimeUSec) = (int)value;
			}
		}

		// Token: 0x06001CD7 RID: 7383 RVA: 0x0002AEF7 File Offset: 0x000290F7
		public FAkAdvancedInitializationSettingsWithMultiCoreRendering()
		{
		}

		// Token: 0x06001CD8 RID: 7384 RVA: 0x0002AF00 File Offset: 0x00029100
		public FAkAdvancedInitializationSettingsWithMultiCoreRendering(bool EnableMultiCoreRendering, uint MaxNumJobWorkers, uint JobWorkerMaxExecutionTimeUSec, uint IO_MemorySize, uint IO_Granularity, float TargetAutoStreamBufferLength, bool UseStreamCache, uint MaximumPinnedBytesInCache, bool EnableGameSyncPreparation, uint ContinuousPlaybackLookAhead, uint MonitorQueuePoolSize, uint MaximumHardwareTimeoutMs, bool DebugOutOfRangeCheckEnabled, float DebugOutOfRangeLimit, EKuroJobWorkerPriority GenericJobWorkerPriority, EKuroJobWorkerPriority AudioProcessingJobWorkerPriority, EKuroJobWorkerPriority SpatialAudioJobWorkerPriority, bool UseKuroThreadPriority, EKuroSoundEngineThreadPriority SoundEngineThreadPriority, bool ShutdownDeviceOnEngineExit, bool AudioCultureMultiChanges, bool HandleShutdownError, bool AkAudioNonblockingDestroy)
		{
			this.EnableMultiCoreRendering = EnableMultiCoreRendering;
			this.MaxNumJobWorkers = MaxNumJobWorkers;
			this.JobWorkerMaxExecutionTimeUSec = JobWorkerMaxExecutionTimeUSec;
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

		// Token: 0x06001CD9 RID: 7385 RVA: 0x0002AFC8 File Offset: 0x000291C8
		protected override IntPtr GetUStructPtr()
		{
			return FAkAdvancedInitializationSettingsWithMultiCoreRendering.StaticStruct();
		}

		// Token: 0x06001CDA RID: 7386 RVA: 0x0002AFD4 File Offset: 0x000291D4
		[NullableContext(2)]
		public FAkAdvancedInitializationSettingsWithMultiCoreRendering(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001CDB RID: 7387 RVA: 0x0002AFDE File Offset: 0x000291DE
		public FAkAdvancedInitializationSettingsWithMultiCoreRendering(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06001CDC RID: 7388 RVA: 0x0002AFE9 File Offset: 0x000291E9
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAkAdvancedInitializationSettingsWithMultiCoreRendering(Pointer, false, true);
		}

		// Token: 0x06001CDD RID: 7389 RVA: 0x0002AFF3 File Offset: 0x000291F3
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAkAdvancedInitializationSettingsWithMultiCoreRendering(Pointer, MemoryOwner);
		}

		// Token: 0x0400096F RID: 2415
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkAdvancedInitializationSettingsWithMultiCoreRendering";

		// Token: 0x04000970 RID: 2416
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000971 RID: 2417
		internal static int __PropertyOffset_EnableMultiCoreRendering;

		// Token: 0x04000972 RID: 2418
		internal static int __PropertyOffset_MaxNumJobWorkers;

		// Token: 0x04000973 RID: 2419
		internal static int __PropertyOffset_JobWorkerMaxExecutionTimeUSec;
	}
}
