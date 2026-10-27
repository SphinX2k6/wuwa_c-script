using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020001E7 RID: 487
	[UnrealObjectPath("/Script/AkAudio.AkAdvancedInitializationSettings")]
	[UnrealStructLayout(68, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 68)]
	public class FAkAdvancedInitializationSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06001CA0 RID: 7328 RVA: 0x0002AAC9 File Offset: 0x00028CC9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAkAdvancedInitializationSettings._ScriptStructPtr != 0) ? FAkAdvancedInitializationSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AkAudio.AkAdvancedInitializationSettings", ref FAkAdvancedInitializationSettings._ScriptStructPtr);
		}

		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x06001CA1 RID: 7329 RVA: 0x0002AAED File Offset: 0x00028CED
		// (set) Token: 0x06001CA2 RID: 7330 RVA: 0x0002AAFD File Offset: 0x00028CFD
		public unsafe uint IO_MemorySize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkAdvancedInitializationSettings.__PropertyOffset_IO_MemorySize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkAdvancedInitializationSettings.__PropertyOffset_IO_MemorySize) = (int)value;
			}
		}

		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x06001CA3 RID: 7331 RVA: 0x0002AB0E File Offset: 0x00028D0E
		// (set) Token: 0x06001CA4 RID: 7332 RVA: 0x0002AB1E File Offset: 0x00028D1E
		public unsafe uint IO_Granularity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkAdvancedInitializationSettings.__PropertyOffset_IO_Granularity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkAdvancedInitializationSettings.__PropertyOffset_IO_Granularity) = (int)value;
			}
		}

		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x06001CA5 RID: 7333 RVA: 0x0002AB2F File Offset: 0x00028D2F
		// (set) Token: 0x06001CA6 RID: 7334 RVA: 0x0002AB3F File Offset: 0x00028D3F
		public unsafe float TargetAutoStreamBufferLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkAdvancedInitializationSettings.__PropertyOffset_TargetAutoStreamBufferLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkAdvancedInitializationSettings.__PropertyOffset_TargetAutoStreamBufferLength) = value;
			}
		}

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x06001CA7 RID: 7335 RVA: 0x0002AB50 File Offset: 0x00028D50
		// (set) Token: 0x06001CA8 RID: 7336 RVA: 0x0002AB60 File Offset: 0x00028D60
		public unsafe bool UseStreamCache
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkAdvancedInitializationSettings.__PropertyOffset_UseStreamCache) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkAdvancedInitializationSettings.__PropertyOffset_UseStreamCache) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x06001CA9 RID: 7337 RVA: 0x0002AB71 File Offset: 0x00028D71
		// (set) Token: 0x06001CAA RID: 7338 RVA: 0x0002AB81 File Offset: 0x00028D81
		public unsafe uint MaximumPinnedBytesInCache
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkAdvancedInitializationSettings.__PropertyOffset_MaximumPinnedBytesInCache);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkAdvancedInitializationSettings.__PropertyOffset_MaximumPinnedBytesInCache) = (int)value;
			}
		}

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x06001CAB RID: 7339 RVA: 0x0002AB92 File Offset: 0x00028D92
		// (set) Token: 0x06001CAC RID: 7340 RVA: 0x0002ABA2 File Offset: 0x00028DA2
		public unsafe bool EnableGameSyncPreparation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkAdvancedInitializationSettings.__PropertyOffset_EnableGameSyncPreparation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkAdvancedInitializationSettings.__PropertyOffset_EnableGameSyncPreparation) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x06001CAD RID: 7341 RVA: 0x0002ABB3 File Offset: 0x00028DB3
		// (set) Token: 0x06001CAE RID: 7342 RVA: 0x0002ABC3 File Offset: 0x00028DC3
		public unsafe uint ContinuousPlaybackLookAhead
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkAdvancedInitializationSettings.__PropertyOffset_ContinuousPlaybackLookAhead);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkAdvancedInitializationSettings.__PropertyOffset_ContinuousPlaybackLookAhead) = (int)value;
			}
		}

		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x06001CAF RID: 7343 RVA: 0x0002ABD4 File Offset: 0x00028DD4
		// (set) Token: 0x06001CB0 RID: 7344 RVA: 0x0002ABE4 File Offset: 0x00028DE4
		public unsafe uint MonitorQueuePoolSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkAdvancedInitializationSettings.__PropertyOffset_MonitorQueuePoolSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkAdvancedInitializationSettings.__PropertyOffset_MonitorQueuePoolSize) = (int)value;
			}
		}

		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x06001CB1 RID: 7345 RVA: 0x0002ABF5 File Offset: 0x00028DF5
		// (set) Token: 0x06001CB2 RID: 7346 RVA: 0x0002AC05 File Offset: 0x00028E05
		public unsafe uint MaximumHardwareTimeoutMs
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkAdvancedInitializationSettings.__PropertyOffset_MaximumHardwareTimeoutMs);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkAdvancedInitializationSettings.__PropertyOffset_MaximumHardwareTimeoutMs) = (int)value;
			}
		}

		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x06001CB3 RID: 7347 RVA: 0x0002AC16 File Offset: 0x00028E16
		// (set) Token: 0x06001CB4 RID: 7348 RVA: 0x0002AC26 File Offset: 0x00028E26
		public unsafe bool DebugOutOfRangeCheckEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkAdvancedInitializationSettings.__PropertyOffset_DebugOutOfRangeCheckEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkAdvancedInitializationSettings.__PropertyOffset_DebugOutOfRangeCheckEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x06001CB5 RID: 7349 RVA: 0x0002AC37 File Offset: 0x00028E37
		// (set) Token: 0x06001CB6 RID: 7350 RVA: 0x0002AC47 File Offset: 0x00028E47
		public unsafe float DebugOutOfRangeLimit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkAdvancedInitializationSettings.__PropertyOffset_DebugOutOfRangeLimit);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkAdvancedInitializationSettings.__PropertyOffset_DebugOutOfRangeLimit) = value;
			}
		}

		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x06001CB7 RID: 7351 RVA: 0x0002AC58 File Offset: 0x00028E58
		// (set) Token: 0x06001CB8 RID: 7352 RVA: 0x0002AC68 File Offset: 0x00028E68
		public unsafe EKuroJobWorkerPriority GenericJobWorkerPriority
		{
			get
			{
				return (EKuroJobWorkerPriority)(*(base.NativePtr + (IntPtr)FAkAdvancedInitializationSettings.__PropertyOffset_GenericJobWorkerPriority));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkAdvancedInitializationSettings.__PropertyOffset_GenericJobWorkerPriority) = (int)value;
			}
		}

		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x06001CB9 RID: 7353 RVA: 0x0002AC79 File Offset: 0x00028E79
		// (set) Token: 0x06001CBA RID: 7354 RVA: 0x0002AC89 File Offset: 0x00028E89
		public unsafe EKuroJobWorkerPriority AudioProcessingJobWorkerPriority
		{
			get
			{
				return (EKuroJobWorkerPriority)(*(base.NativePtr + (IntPtr)FAkAdvancedInitializationSettings.__PropertyOffset_AudioProcessingJobWorkerPriority));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkAdvancedInitializationSettings.__PropertyOffset_AudioProcessingJobWorkerPriority) = (int)value;
			}
		}

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x06001CBB RID: 7355 RVA: 0x0002AC9A File Offset: 0x00028E9A
		// (set) Token: 0x06001CBC RID: 7356 RVA: 0x0002ACAA File Offset: 0x00028EAA
		public unsafe EKuroJobWorkerPriority SpatialAudioJobWorkerPriority
		{
			get
			{
				return (EKuroJobWorkerPriority)(*(base.NativePtr + (IntPtr)FAkAdvancedInitializationSettings.__PropertyOffset_SpatialAudioJobWorkerPriority));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkAdvancedInitializationSettings.__PropertyOffset_SpatialAudioJobWorkerPriority) = (int)value;
			}
		}

		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x06001CBD RID: 7357 RVA: 0x0002ACBB File Offset: 0x00028EBB
		// (set) Token: 0x06001CBE RID: 7358 RVA: 0x0002ACCB File Offset: 0x00028ECB
		public unsafe bool UseKuroThreadPriority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkAdvancedInitializationSettings.__PropertyOffset_UseKuroThreadPriority) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkAdvancedInitializationSettings.__PropertyOffset_UseKuroThreadPriority) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x06001CBF RID: 7359 RVA: 0x0002ACDC File Offset: 0x00028EDC
		// (set) Token: 0x06001CC0 RID: 7360 RVA: 0x0002ACEC File Offset: 0x00028EEC
		public unsafe EKuroSoundEngineThreadPriority SoundEngineThreadPriority
		{
			get
			{
				return (EKuroSoundEngineThreadPriority)(*(base.NativePtr + (IntPtr)FAkAdvancedInitializationSettings.__PropertyOffset_SoundEngineThreadPriority));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkAdvancedInitializationSettings.__PropertyOffset_SoundEngineThreadPriority) = (int)value;
			}
		}

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x06001CC1 RID: 7361 RVA: 0x0002ACFD File Offset: 0x00028EFD
		// (set) Token: 0x06001CC2 RID: 7362 RVA: 0x0002AD0D File Offset: 0x00028F0D
		public unsafe bool ShutdownDeviceOnEngineExit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkAdvancedInitializationSettings.__PropertyOffset_ShutdownDeviceOnEngineExit) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkAdvancedInitializationSettings.__PropertyOffset_ShutdownDeviceOnEngineExit) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x06001CC3 RID: 7363 RVA: 0x0002AD1E File Offset: 0x00028F1E
		// (set) Token: 0x06001CC4 RID: 7364 RVA: 0x0002AD2E File Offset: 0x00028F2E
		public unsafe bool AudioCultureMultiChanges
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkAdvancedInitializationSettings.__PropertyOffset_AudioCultureMultiChanges) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkAdvancedInitializationSettings.__PropertyOffset_AudioCultureMultiChanges) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x06001CC5 RID: 7365 RVA: 0x0002AD3F File Offset: 0x00028F3F
		// (set) Token: 0x06001CC6 RID: 7366 RVA: 0x0002AD4F File Offset: 0x00028F4F
		public unsafe bool HandleShutdownError
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkAdvancedInitializationSettings.__PropertyOffset_HandleShutdownError) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkAdvancedInitializationSettings.__PropertyOffset_HandleShutdownError) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x06001CC7 RID: 7367 RVA: 0x0002AD60 File Offset: 0x00028F60
		// (set) Token: 0x06001CC8 RID: 7368 RVA: 0x0002AD70 File Offset: 0x00028F70
		public unsafe bool AkAudioNonblockingDestroy
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkAdvancedInitializationSettings.__PropertyOffset_AkAudioNonblockingDestroy) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkAdvancedInitializationSettings.__PropertyOffset_AkAudioNonblockingDestroy) = (value ? 1 : 0);
			}
		}

		// Token: 0x06001CC9 RID: 7369 RVA: 0x0002AD81 File Offset: 0x00028F81
		public FAkAdvancedInitializationSettings()
		{
		}

		// Token: 0x06001CCA RID: 7370 RVA: 0x0002AD8C File Offset: 0x00028F8C
		public FAkAdvancedInitializationSettings(uint IO_MemorySize, uint IO_Granularity, float TargetAutoStreamBufferLength, bool UseStreamCache, uint MaximumPinnedBytesInCache, bool EnableGameSyncPreparation, uint ContinuousPlaybackLookAhead, uint MonitorQueuePoolSize, uint MaximumHardwareTimeoutMs, bool DebugOutOfRangeCheckEnabled, float DebugOutOfRangeLimit, EKuroJobWorkerPriority GenericJobWorkerPriority, EKuroJobWorkerPriority AudioProcessingJobWorkerPriority, EKuroJobWorkerPriority SpatialAudioJobWorkerPriority, bool UseKuroThreadPriority, EKuroSoundEngineThreadPriority SoundEngineThreadPriority, bool ShutdownDeviceOnEngineExit, bool AudioCultureMultiChanges, bool HandleShutdownError, bool AkAudioNonblockingDestroy)
		{
			this.IO_MemorySize = IO_MemorySize;
			this.IO_Granularity = IO_Granularity;
			this.TargetAutoStreamBufferLength = TargetAutoStreamBufferLength;
			this.UseStreamCache = UseStreamCache;
			this.MaximumPinnedBytesInCache = MaximumPinnedBytesInCache;
			this.EnableGameSyncPreparation = EnableGameSyncPreparation;
			this.ContinuousPlaybackLookAhead = ContinuousPlaybackLookAhead;
			this.MonitorQueuePoolSize = MonitorQueuePoolSize;
			this.MaximumHardwareTimeoutMs = MaximumHardwareTimeoutMs;
			this.DebugOutOfRangeCheckEnabled = DebugOutOfRangeCheckEnabled;
			this.DebugOutOfRangeLimit = DebugOutOfRangeLimit;
			this.GenericJobWorkerPriority = GenericJobWorkerPriority;
			this.AudioProcessingJobWorkerPriority = AudioProcessingJobWorkerPriority;
			this.SpatialAudioJobWorkerPriority = SpatialAudioJobWorkerPriority;
			this.UseKuroThreadPriority = UseKuroThreadPriority;
			this.SoundEngineThreadPriority = SoundEngineThreadPriority;
			this.ShutdownDeviceOnEngineExit = ShutdownDeviceOnEngineExit;
			this.AudioCultureMultiChanges = AudioCultureMultiChanges;
			this.HandleShutdownError = HandleShutdownError;
			this.AkAudioNonblockingDestroy = AkAudioNonblockingDestroy;
		}

		// Token: 0x06001CCB RID: 7371 RVA: 0x0002AE3C File Offset: 0x0002903C
		protected override IntPtr GetUStructPtr()
		{
			return FAkAdvancedInitializationSettings.StaticStruct();
		}

		// Token: 0x06001CCC RID: 7372 RVA: 0x0002AE48 File Offset: 0x00029048
		[NullableContext(2)]
		public FAkAdvancedInitializationSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001CCD RID: 7373 RVA: 0x0002AE52 File Offset: 0x00029052
		public FAkAdvancedInitializationSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06001CCE RID: 7374 RVA: 0x0002AE5D File Offset: 0x0002905D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAkAdvancedInitializationSettings(Pointer, false, true);
		}

		// Token: 0x06001CCF RID: 7375 RVA: 0x0002AE67 File Offset: 0x00029067
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAkAdvancedInitializationSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04000959 RID: 2393
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AkAudio.AkAdvancedInitializationSettings";

		// Token: 0x0400095A RID: 2394
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400095B RID: 2395
		internal static int __PropertyOffset_IO_MemorySize;

		// Token: 0x0400095C RID: 2396
		internal static int __PropertyOffset_IO_Granularity;

		// Token: 0x0400095D RID: 2397
		internal static int __PropertyOffset_TargetAutoStreamBufferLength;

		// Token: 0x0400095E RID: 2398
		internal static int __PropertyOffset_UseStreamCache;

		// Token: 0x0400095F RID: 2399
		internal static int __PropertyOffset_MaximumPinnedBytesInCache;

		// Token: 0x04000960 RID: 2400
		internal static int __PropertyOffset_EnableGameSyncPreparation;

		// Token: 0x04000961 RID: 2401
		internal static int __PropertyOffset_ContinuousPlaybackLookAhead;

		// Token: 0x04000962 RID: 2402
		internal static int __PropertyOffset_MonitorQueuePoolSize;

		// Token: 0x04000963 RID: 2403
		internal static int __PropertyOffset_MaximumHardwareTimeoutMs;

		// Token: 0x04000964 RID: 2404
		internal static int __PropertyOffset_DebugOutOfRangeCheckEnabled;

		// Token: 0x04000965 RID: 2405
		internal static int __PropertyOffset_DebugOutOfRangeLimit;

		// Token: 0x04000966 RID: 2406
		internal static int __PropertyOffset_GenericJobWorkerPriority;

		// Token: 0x04000967 RID: 2407
		internal static int __PropertyOffset_AudioProcessingJobWorkerPriority;

		// Token: 0x04000968 RID: 2408
		internal static int __PropertyOffset_SpatialAudioJobWorkerPriority;

		// Token: 0x04000969 RID: 2409
		internal static int __PropertyOffset_UseKuroThreadPriority;

		// Token: 0x0400096A RID: 2410
		internal static int __PropertyOffset_SoundEngineThreadPriority;

		// Token: 0x0400096B RID: 2411
		internal static int __PropertyOffset_ShutdownDeviceOnEngineExit;

		// Token: 0x0400096C RID: 2412
		internal static int __PropertyOffset_AudioCultureMultiChanges;

		// Token: 0x0400096D RID: 2413
		internal static int __PropertyOffset_HandleShutdownError;

		// Token: 0x0400096E RID: 2414
		internal static int __PropertyOffset_AkAudioNonblockingDestroy;
	}
}
