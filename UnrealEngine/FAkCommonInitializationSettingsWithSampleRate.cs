using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020001FA RID: 506
	[UnrealObjectPath("/Script/AkAudio.AkCommonInitializationSettingsWithSampleRate")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 120)]
	public class FAkCommonInitializationSettingsWithSampleRate : FAkCommonInitializationSettings, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06001DD6 RID: 7638 RVA: 0x0002C5B0 File Offset: 0x0002A7B0
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAkCommonInitializationSettingsWithSampleRate._ScriptStructPtr != 0) ? FAkCommonInitializationSettingsWithSampleRate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AkAudio.AkCommonInitializationSettingsWithSampleRate", ref FAkCommonInitializationSettingsWithSampleRate._ScriptStructPtr);
		}

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x06001DD7 RID: 7639 RVA: 0x0002C5D4 File Offset: 0x0002A7D4
		// (set) Token: 0x06001DD8 RID: 7640 RVA: 0x0002C5E4 File Offset: 0x0002A7E4
		public unsafe uint SampleRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkCommonInitializationSettingsWithSampleRate.__PropertyOffset_SampleRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkCommonInitializationSettingsWithSampleRate.__PropertyOffset_SampleRate) = (int)value;
			}
		}

		// Token: 0x06001DD9 RID: 7641 RVA: 0x0002C5F5 File Offset: 0x0002A7F5
		public FAkCommonInitializationSettingsWithSampleRate()
		{
		}

		// Token: 0x06001DDA RID: 7642 RVA: 0x0002C600 File Offset: 0x0002A800
		[NullableContext(1)]
		public FAkCommonInitializationSettingsWithSampleRate(uint SampleRate, uint MaximumNumberOfMemoryPools, uint MaximumNumberOfPositioningPaths, uint CommandQueueSize, uint SamplesPerFrame, FAkMainOutputSettings MainOutputSettings, float StreamingLookAheadRatio, ushort NumberOfRefillsInVoice, FAkSpatialAudioSettings SpatialAudioSettings, uint WakeupDelayMs)
		{
			this.SampleRate = SampleRate;
			base.MaximumNumberOfMemoryPools = MaximumNumberOfMemoryPools;
			base.MaximumNumberOfPositioningPaths = MaximumNumberOfPositioningPaths;
			base.CommandQueueSize = CommandQueueSize;
			base.SamplesPerFrame = SamplesPerFrame;
			base.MainOutputSettings = MainOutputSettings;
			base.StreamingLookAheadRatio = StreamingLookAheadRatio;
			base.NumberOfRefillsInVoice = NumberOfRefillsInVoice;
			base.SpatialAudioSettings = SpatialAudioSettings;
			base.WakeupDelayMs = WakeupDelayMs;
		}

		// Token: 0x06001DDB RID: 7643 RVA: 0x0002C660 File Offset: 0x0002A860
		protected override IntPtr GetUStructPtr()
		{
			return FAkCommonInitializationSettingsWithSampleRate.StaticStruct();
		}

		// Token: 0x06001DDC RID: 7644 RVA: 0x0002C66C File Offset: 0x0002A86C
		[NullableContext(2)]
		public FAkCommonInitializationSettingsWithSampleRate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001DDD RID: 7645 RVA: 0x0002C676 File Offset: 0x0002A876
		public FAkCommonInitializationSettingsWithSampleRate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06001DDE RID: 7646 RVA: 0x0002C681 File Offset: 0x0002A881
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAkCommonInitializationSettingsWithSampleRate(Pointer, false, true);
		}

		// Token: 0x06001DDF RID: 7647 RVA: 0x0002C68B File Offset: 0x0002A88B
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAkCommonInitializationSettingsWithSampleRate(Pointer, MemoryOwner);
		}

		// Token: 0x040009E3 RID: 2531
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkCommonInitializationSettingsWithSampleRate";

		// Token: 0x040009E4 RID: 2532
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040009E5 RID: 2533
		internal static int __PropertyOffset_SampleRate;
	}
}
