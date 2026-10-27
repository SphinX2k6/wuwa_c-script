using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000268 RID: 616
	[UnrealObjectPath("/Script/AkAudio.AkXSXAdvancedInitializationSettings")]
	[UnrealStructLayout(100, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 100)]
	public class FAkXSXAdvancedInitializationSettings : FAkAdvancedInitializationSettingsWithMultiCoreRendering, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060023ED RID: 9197 RVA: 0x0003547A File Offset: 0x0003367A
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAkXSXAdvancedInitializationSettings._ScriptStructPtr != 0) ? FAkXSXAdvancedInitializationSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AkAudio.AkXSXAdvancedInitializationSettings", ref FAkXSXAdvancedInitializationSettings._ScriptStructPtr);
		}

		// Token: 0x170008A3 RID: 2211
		// (get) Token: 0x060023EE RID: 9198 RVA: 0x0003549E File Offset: 0x0003369E
		// (set) Token: 0x060023EF RID: 9199 RVA: 0x000354AE File Offset: 0x000336AE
		public unsafe bool UseHardwareCodecLowLatencyMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkXSXAdvancedInitializationSettings.__PropertyOffset_UseHardwareCodecLowLatencyMode) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkXSXAdvancedInitializationSettings.__PropertyOffset_UseHardwareCodecLowLatencyMode) = (value ? 1 : 0);
			}
		}

		// Token: 0x170008A4 RID: 2212
		// (get) Token: 0x060023F0 RID: 9200 RVA: 0x000354BF File Offset: 0x000336BF
		// (set) Token: 0x060023F1 RID: 9201 RVA: 0x000354CF File Offset: 0x000336CF
		public unsafe ushort MaximumNumberOfOpusVoices
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkXSXAdvancedInitializationSettings.__PropertyOffset_MaximumNumberOfOpusVoices);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkXSXAdvancedInitializationSettings.__PropertyOffset_MaximumNumberOfOpusVoices) = (short)value;
			}
		}

		// Token: 0x170008A5 RID: 2213
		// (get) Token: 0x060023F2 RID: 9202 RVA: 0x000354E0 File Offset: 0x000336E0
		// (set) Token: 0x060023F3 RID: 9203 RVA: 0x000354F0 File Offset: 0x000336F0
		public unsafe uint uMaxSystemAudioObjects
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkXSXAdvancedInitializationSettings.__PropertyOffset_uMaxSystemAudioObjects);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkXSXAdvancedInitializationSettings.__PropertyOffset_uMaxSystemAudioObjects) = (int)value;
			}
		}

		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x060023F4 RID: 9204 RVA: 0x00035501 File Offset: 0x00033701
		// (set) Token: 0x060023F5 RID: 9205 RVA: 0x00035511 File Offset: 0x00033711
		public unsafe uint MaxXdspStreams
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkXSXAdvancedInitializationSettings.__PropertyOffset_MaxXdspStreams);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkXSXAdvancedInitializationSettings.__PropertyOffset_MaxXdspStreams) = (int)value;
			}
		}

		// Token: 0x170008A7 RID: 2215
		// (get) Token: 0x060023F6 RID: 9206 RVA: 0x00035522 File Offset: 0x00033722
		// (set) Token: 0x060023F7 RID: 9207 RVA: 0x00035532 File Offset: 0x00033732
		public unsafe uint MaxXdspAggregateStreamLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkXSXAdvancedInitializationSettings.__PropertyOffset_MaxXdspAggregateStreamLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkXSXAdvancedInitializationSettings.__PropertyOffset_MaxXdspAggregateStreamLength) = (int)value;
			}
		}

		// Token: 0x170008A8 RID: 2216
		// (get) Token: 0x060023F8 RID: 9208 RVA: 0x00035543 File Offset: 0x00033743
		// (set) Token: 0x060023F9 RID: 9209 RVA: 0x00035553 File Offset: 0x00033753
		public unsafe bool EnableXdspOnLockhart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkXSXAdvancedInitializationSettings.__PropertyOffset_EnableXdspOnLockhart) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkXSXAdvancedInitializationSettings.__PropertyOffset_EnableXdspOnLockhart) = (value ? 1 : 0);
			}
		}

		// Token: 0x060023FA RID: 9210 RVA: 0x00035564 File Offset: 0x00033764
		public FAkXSXAdvancedInitializationSettings()
		{
		}

		// Token: 0x060023FB RID: 9211 RVA: 0x0003556C File Offset: 0x0003376C
		public FAkXSXAdvancedInitializationSettings(bool UseHardwareCodecLowLatencyMode, ushort MaximumNumberOfOpusVoices, uint uMaxSystemAudioObjects, uint MaxXdspStreams, uint MaxXdspAggregateStreamLength, bool EnableXdspOnLockhart, bool EnableMultiCoreRendering, uint MaxNumJobWorkers, uint JobWorkerMaxExecutionTimeUSec, uint IO_MemorySize, uint IO_Granularity, float TargetAutoStreamBufferLength, bool UseStreamCache, uint MaximumPinnedBytesInCache, bool EnableGameSyncPreparation, uint ContinuousPlaybackLookAhead, uint MonitorQueuePoolSize, uint MaximumHardwareTimeoutMs, bool DebugOutOfRangeCheckEnabled, float DebugOutOfRangeLimit, EKuroJobWorkerPriority GenericJobWorkerPriority, EKuroJobWorkerPriority AudioProcessingJobWorkerPriority, EKuroJobWorkerPriority SpatialAudioJobWorkerPriority, bool UseKuroThreadPriority, EKuroSoundEngineThreadPriority SoundEngineThreadPriority, bool ShutdownDeviceOnEngineExit, bool AudioCultureMultiChanges, bool HandleShutdownError, bool AkAudioNonblockingDestroy)
		{
			this.UseHardwareCodecLowLatencyMode = UseHardwareCodecLowLatencyMode;
			this.MaximumNumberOfOpusVoices = MaximumNumberOfOpusVoices;
			this.uMaxSystemAudioObjects = uMaxSystemAudioObjects;
			this.MaxXdspStreams = MaxXdspStreams;
			this.MaxXdspAggregateStreamLength = MaxXdspAggregateStreamLength;
			this.EnableXdspOnLockhart = EnableXdspOnLockhart;
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

		// Token: 0x060023FC RID: 9212 RVA: 0x00035664 File Offset: 0x00033864
		protected override IntPtr GetUStructPtr()
		{
			return FAkXSXAdvancedInitializationSettings.StaticStruct();
		}

		// Token: 0x060023FD RID: 9213 RVA: 0x00035670 File Offset: 0x00033870
		[NullableContext(2)]
		public FAkXSXAdvancedInitializationSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060023FE RID: 9214 RVA: 0x0003567A File Offset: 0x0003387A
		public FAkXSXAdvancedInitializationSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060023FF RID: 9215 RVA: 0x00035685 File Offset: 0x00033885
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAkXSXAdvancedInitializationSettings(Pointer, false, true);
		}

		// Token: 0x06002400 RID: 9216 RVA: 0x0003568F File Offset: 0x0003388F
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAkXSXAdvancedInitializationSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04000C80 RID: 3200
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkXSXAdvancedInitializationSettings";

		// Token: 0x04000C81 RID: 3201
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000C82 RID: 3202
		internal static int __PropertyOffset_UseHardwareCodecLowLatencyMode;

		// Token: 0x04000C83 RID: 3203
		internal static int __PropertyOffset_MaximumNumberOfOpusVoices;

		// Token: 0x04000C84 RID: 3204
		internal static int __PropertyOffset_uMaxSystemAudioObjects;

		// Token: 0x04000C85 RID: 3205
		internal static int __PropertyOffset_MaxXdspStreams;

		// Token: 0x04000C86 RID: 3206
		internal static int __PropertyOffset_MaxXdspAggregateStreamLength;

		// Token: 0x04000C87 RID: 3207
		internal static int __PropertyOffset_EnableXdspOnLockhart;
	}
}
