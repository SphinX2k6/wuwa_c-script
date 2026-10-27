using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000388 RID: 904
	[UnrealObjectPath("/Script/AudioPlatformConfiguration.PlatformRuntimeAudioCompressionOverrides")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FPlatformRuntimeAudioCompressionOverrides : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060031E5 RID: 12773 RVA: 0x0004D19B File Offset: 0x0004B39B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPlatformRuntimeAudioCompressionOverrides._ScriptStructPtr != 0) ? FPlatformRuntimeAudioCompressionOverrides._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AudioPlatformConfiguration.PlatformRuntimeAudioCompressionOverrides", ref FPlatformRuntimeAudioCompressionOverrides._ScriptStructPtr);
		}

		// Token: 0x17000C2D RID: 3117
		// (get) Token: 0x060031E6 RID: 12774 RVA: 0x0004D1BF File Offset: 0x0004B3BF
		// (set) Token: 0x060031E7 RID: 12775 RVA: 0x0004D1CF File Offset: 0x0004B3CF
		public unsafe bool bOverrideCompressionTimes
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPlatformRuntimeAudioCompressionOverrides.__PropertyOffset_bOverrideCompressionTimes) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPlatformRuntimeAudioCompressionOverrides.__PropertyOffset_bOverrideCompressionTimes) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000C2E RID: 3118
		// (get) Token: 0x060031E8 RID: 12776 RVA: 0x0004D1E0 File Offset: 0x0004B3E0
		// (set) Token: 0x060031E9 RID: 12777 RVA: 0x0004D1F0 File Offset: 0x0004B3F0
		public unsafe float DurationThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPlatformRuntimeAudioCompressionOverrides.__PropertyOffset_DurationThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPlatformRuntimeAudioCompressionOverrides.__PropertyOffset_DurationThreshold) = value;
			}
		}

		// Token: 0x17000C2F RID: 3119
		// (get) Token: 0x060031EA RID: 12778 RVA: 0x0004D201 File Offset: 0x0004B401
		// (set) Token: 0x060031EB RID: 12779 RVA: 0x0004D211 File Offset: 0x0004B411
		public unsafe int MaxNumRandomBranches
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPlatformRuntimeAudioCompressionOverrides.__PropertyOffset_MaxNumRandomBranches);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPlatformRuntimeAudioCompressionOverrides.__PropertyOffset_MaxNumRandomBranches) = value;
			}
		}

		// Token: 0x17000C30 RID: 3120
		// (get) Token: 0x060031EC RID: 12780 RVA: 0x0004D222 File Offset: 0x0004B422
		// (set) Token: 0x060031ED RID: 12781 RVA: 0x0004D232 File Offset: 0x0004B432
		public unsafe int SoundCueQualityIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPlatformRuntimeAudioCompressionOverrides.__PropertyOffset_SoundCueQualityIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPlatformRuntimeAudioCompressionOverrides.__PropertyOffset_SoundCueQualityIndex) = value;
			}
		}

		// Token: 0x060031EE RID: 12782 RVA: 0x0004D243 File Offset: 0x0004B443
		public FPlatformRuntimeAudioCompressionOverrides()
		{
		}

		// Token: 0x060031EF RID: 12783 RVA: 0x0004D24B File Offset: 0x0004B44B
		public FPlatformRuntimeAudioCompressionOverrides(bool bOverrideCompressionTimes, float DurationThreshold, int MaxNumRandomBranches, int SoundCueQualityIndex)
		{
			this.bOverrideCompressionTimes = bOverrideCompressionTimes;
			this.DurationThreshold = DurationThreshold;
			this.MaxNumRandomBranches = MaxNumRandomBranches;
			this.SoundCueQualityIndex = SoundCueQualityIndex;
		}

		// Token: 0x060031F0 RID: 12784 RVA: 0x0004D270 File Offset: 0x0004B470
		protected override IntPtr GetUStructPtr()
		{
			return FPlatformRuntimeAudioCompressionOverrides.StaticStruct();
		}

		// Token: 0x060031F1 RID: 12785 RVA: 0x0004D27C File Offset: 0x0004B47C
		[NullableContext(2)]
		public FPlatformRuntimeAudioCompressionOverrides(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060031F2 RID: 12786 RVA: 0x0004D286 File Offset: 0x0004B486
		public FPlatformRuntimeAudioCompressionOverrides(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060031F3 RID: 12787 RVA: 0x0004D291 File Offset: 0x0004B491
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPlatformRuntimeAudioCompressionOverrides(Pointer, false, true);
		}

		// Token: 0x060031F4 RID: 12788 RVA: 0x0004D29B File Offset: 0x0004B49B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPlatformRuntimeAudioCompressionOverrides(Pointer, MemoryOwner);
		}

		// Token: 0x040015CB RID: 5579
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AudioPlatformConfiguration.PlatformRuntimeAudioCompressionOverrides";

		// Token: 0x040015CC RID: 5580
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040015CD RID: 5581
		internal static int __PropertyOffset_bOverrideCompressionTimes;

		// Token: 0x040015CE RID: 5582
		internal static int __PropertyOffset_DurationThreshold;

		// Token: 0x040015CF RID: 5583
		internal static int __PropertyOffset_MaxNumRandomBranches;

		// Token: 0x040015D0 RID: 5584
		internal static int __PropertyOffset_SoundCueQualityIndex;
	}
}
