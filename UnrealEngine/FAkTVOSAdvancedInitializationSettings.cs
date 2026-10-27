using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200024E RID: 590
	[UnrealObjectPath("/Script/AkAudio.AkTVOSAdvancedInitializationSettings")]
	[UnrealStructLayout(88, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FAkTVOSAdvancedInitializationSettings : FAkAdvancedInitializationSettingsWithMultiCoreRendering, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060022D8 RID: 8920 RVA: 0x000338F9 File Offset: 0x00031AF9
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAkTVOSAdvancedInitializationSettings._ScriptStructPtr != 0) ? FAkTVOSAdvancedInitializationSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AkAudio.AkTVOSAdvancedInitializationSettings", ref FAkTVOSAdvancedInitializationSettings._ScriptStructPtr);
		}

		// Token: 0x17000885 RID: 2181
		// (get) Token: 0x060022D9 RID: 8921 RVA: 0x0003391D File Offset: 0x00031B1D
		// (set) Token: 0x060022DA RID: 8922 RVA: 0x0003392D File Offset: 0x00031B2D
		public unsafe uint uNumSpatialAudioPointSources
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkTVOSAdvancedInitializationSettings.__PropertyOffset_uNumSpatialAudioPointSources);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkTVOSAdvancedInitializationSettings.__PropertyOffset_uNumSpatialAudioPointSources) = (int)value;
			}
		}

		// Token: 0x17000886 RID: 2182
		// (get) Token: 0x060022DB RID: 8923 RVA: 0x0003393E File Offset: 0x00031B3E
		// (set) Token: 0x060022DC RID: 8924 RVA: 0x0003394E File Offset: 0x00031B4E
		public unsafe bool bVerboseSystemOutput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkTVOSAdvancedInitializationSettings.__PropertyOffset_bVerboseSystemOutput) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkTVOSAdvancedInitializationSettings.__PropertyOffset_bVerboseSystemOutput) = (value ? 1 : 0);
			}
		}

		// Token: 0x060022DD RID: 8925 RVA: 0x0003395F File Offset: 0x00031B5F
		public FAkTVOSAdvancedInitializationSettings()
		{
		}

		// Token: 0x060022DE RID: 8926 RVA: 0x00033968 File Offset: 0x00031B68
		public FAkTVOSAdvancedInitializationSettings(uint uNumSpatialAudioPointSources, bool bVerboseSystemOutput, bool EnableMultiCoreRendering, uint MaxNumJobWorkers, uint JobWorkerMaxExecutionTimeUSec, uint IO_MemorySize, uint IO_Granularity, float TargetAutoStreamBufferLength, bool UseStreamCache, uint MaximumPinnedBytesInCache, bool EnableGameSyncPreparation, uint ContinuousPlaybackLookAhead, uint MonitorQueuePoolSize, uint MaximumHardwareTimeoutMs, bool DebugOutOfRangeCheckEnabled, float DebugOutOfRangeLimit, EKuroJobWorkerPriority GenericJobWorkerPriority, EKuroJobWorkerPriority AudioProcessingJobWorkerPriority, EKuroJobWorkerPriority SpatialAudioJobWorkerPriority, bool UseKuroThreadPriority, EKuroSoundEngineThreadPriority SoundEngineThreadPriority, bool ShutdownDeviceOnEngineExit, bool AudioCultureMultiChanges, bool HandleShutdownError, bool AkAudioNonblockingDestroy)
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

		// Token: 0x060022DF RID: 8927 RVA: 0x00033A40 File Offset: 0x00031C40
		protected override IntPtr GetUStructPtr()
		{
			return FAkTVOSAdvancedInitializationSettings.StaticStruct();
		}

		// Token: 0x060022E0 RID: 8928 RVA: 0x00033A4C File Offset: 0x00031C4C
		[NullableContext(2)]
		public FAkTVOSAdvancedInitializationSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060022E1 RID: 8929 RVA: 0x00033A56 File Offset: 0x00031C56
		public FAkTVOSAdvancedInitializationSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060022E2 RID: 8930 RVA: 0x00033A61 File Offset: 0x00031C61
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAkTVOSAdvancedInitializationSettings(Pointer, false, true);
		}

		// Token: 0x060022E3 RID: 8931 RVA: 0x00033A6B File Offset: 0x00031C6B
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAkTVOSAdvancedInitializationSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04000C0B RID: 3083
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkTVOSAdvancedInitializationSettings";

		// Token: 0x04000C0C RID: 3084
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000C0D RID: 3085
		internal static int __PropertyOffset_uNumSpatialAudioPointSources;

		// Token: 0x04000C0E RID: 3086
		internal static int __PropertyOffset_bVerboseSystemOutput;
	}
}
