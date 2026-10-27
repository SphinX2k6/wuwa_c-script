using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200112B RID: 4395
	[UnrealObjectPath("/Script/Engine.SoundConcurrencySettings")]
	[UnrealStructLayout(40, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FSoundConcurrencySettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06010159 RID: 65881 RVA: 0x0017B259 File Offset: 0x00179459
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSoundConcurrencySettings._ScriptStructPtr != 0) ? FSoundConcurrencySettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SoundConcurrencySettings", ref FSoundConcurrencySettings._ScriptStructPtr);
		}

		// Token: 0x17003EF2 RID: 16114
		// (get) Token: 0x0601015A RID: 65882 RVA: 0x0017B27D File Offset: 0x0017947D
		// (set) Token: 0x0601015B RID: 65883 RVA: 0x0017B28D File Offset: 0x0017948D
		public unsafe int MaxCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundConcurrencySettings.__PropertyOffset_MaxCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundConcurrencySettings.__PropertyOffset_MaxCount) = value;
			}
		}

		// Token: 0x17003EF3 RID: 16115
		// (get) Token: 0x0601015C RID: 65884 RVA: 0x0017B29E File Offset: 0x0017949E
		// (set) Token: 0x0601015D RID: 65885 RVA: 0x0017B2B7 File Offset: 0x001794B7
		public unsafe bool bLimitToOwner
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSoundConcurrencySettings.__PropertyOffset_bLimitToOwner) & FSoundConcurrencySettings.__PropertyMask_bLimitToOwner) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSoundConcurrencySettings.__PropertyOffset_bLimitToOwner) = ((*(base.NativePtr + (IntPtr)FSoundConcurrencySettings.__PropertyOffset_bLimitToOwner) & ~FSoundConcurrencySettings.__PropertyMask_bLimitToOwner) | (value ? FSoundConcurrencySettings.__PropertyMask_bLimitToOwner : 0));
			}
		}

		// Token: 0x17003EF4 RID: 16116
		// (get) Token: 0x0601015E RID: 65886 RVA: 0x0017B2E7 File Offset: 0x001794E7
		// (set) Token: 0x0601015F RID: 65887 RVA: 0x0017B2FB File Offset: 0x001794FB
		public unsafe TEnumAsByte<EMaxConcurrentResolutionRule> ResolutionRule
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundConcurrencySettings.__PropertyOffset_ResolutionRule);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundConcurrencySettings.__PropertyOffset_ResolutionRule) = value;
			}
		}

		// Token: 0x17003EF5 RID: 16117
		// (get) Token: 0x06010160 RID: 65888 RVA: 0x0017B310 File Offset: 0x00179510
		// (set) Token: 0x06010161 RID: 65889 RVA: 0x0017B320 File Offset: 0x00179520
		public unsafe float RetriggerTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundConcurrencySettings.__PropertyOffset_RetriggerTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundConcurrencySettings.__PropertyOffset_RetriggerTime) = value;
			}
		}

		// Token: 0x17003EF6 RID: 16118
		// (get) Token: 0x06010162 RID: 65890 RVA: 0x0017B331 File Offset: 0x00179531
		// (set) Token: 0x06010163 RID: 65891 RVA: 0x0017B341 File Offset: 0x00179541
		public unsafe float VolumeScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundConcurrencySettings.__PropertyOffset_VolumeScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundConcurrencySettings.__PropertyOffset_VolumeScale) = value;
			}
		}

		// Token: 0x17003EF7 RID: 16119
		// (get) Token: 0x06010164 RID: 65892 RVA: 0x0017B352 File Offset: 0x00179552
		// (set) Token: 0x06010165 RID: 65893 RVA: 0x0017B362 File Offset: 0x00179562
		public unsafe EConcurrencyVolumeScaleMode VolumeScaleMode
		{
			get
			{
				return (EConcurrencyVolumeScaleMode)(*(base.NativePtr + (IntPtr)FSoundConcurrencySettings.__PropertyOffset_VolumeScaleMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundConcurrencySettings.__PropertyOffset_VolumeScaleMode) = (int)value;
			}
		}

		// Token: 0x17003EF8 RID: 16120
		// (get) Token: 0x06010166 RID: 65894 RVA: 0x0017B373 File Offset: 0x00179573
		// (set) Token: 0x06010167 RID: 65895 RVA: 0x0017B383 File Offset: 0x00179583
		public unsafe float VolumeScaleAttackTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundConcurrencySettings.__PropertyOffset_VolumeScaleAttackTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundConcurrencySettings.__PropertyOffset_VolumeScaleAttackTime) = value;
			}
		}

		// Token: 0x17003EF9 RID: 16121
		// (get) Token: 0x06010168 RID: 65896 RVA: 0x0017B394 File Offset: 0x00179594
		// (set) Token: 0x06010169 RID: 65897 RVA: 0x0017B3AD File Offset: 0x001795AD
		public unsafe bool bVolumeScaleCanRelease
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSoundConcurrencySettings.__PropertyOffset_bVolumeScaleCanRelease) & FSoundConcurrencySettings.__PropertyMask_bVolumeScaleCanRelease) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSoundConcurrencySettings.__PropertyOffset_bVolumeScaleCanRelease) = ((*(base.NativePtr + (IntPtr)FSoundConcurrencySettings.__PropertyOffset_bVolumeScaleCanRelease) & ~FSoundConcurrencySettings.__PropertyMask_bVolumeScaleCanRelease) | (value ? FSoundConcurrencySettings.__PropertyMask_bVolumeScaleCanRelease : 0));
			}
		}

		// Token: 0x17003EFA RID: 16122
		// (get) Token: 0x0601016A RID: 65898 RVA: 0x0017B3DD File Offset: 0x001795DD
		// (set) Token: 0x0601016B RID: 65899 RVA: 0x0017B3ED File Offset: 0x001795ED
		public unsafe float VolumeScaleReleaseTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundConcurrencySettings.__PropertyOffset_VolumeScaleReleaseTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundConcurrencySettings.__PropertyOffset_VolumeScaleReleaseTime) = value;
			}
		}

		// Token: 0x17003EFB RID: 16123
		// (get) Token: 0x0601016C RID: 65900 RVA: 0x0017B3FE File Offset: 0x001795FE
		// (set) Token: 0x0601016D RID: 65901 RVA: 0x0017B40E File Offset: 0x0017960E
		public unsafe float VoiceStealReleaseTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundConcurrencySettings.__PropertyOffset_VoiceStealReleaseTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundConcurrencySettings.__PropertyOffset_VoiceStealReleaseTime) = value;
			}
		}

		// Token: 0x0601016E RID: 65902 RVA: 0x0017B41F File Offset: 0x0017961F
		public FSoundConcurrencySettings()
		{
		}

		// Token: 0x0601016F RID: 65903 RVA: 0x0017B428 File Offset: 0x00179628
		public FSoundConcurrencySettings(int MaxCount, bool bLimitToOwner, TEnumAsByte<EMaxConcurrentResolutionRule> ResolutionRule, float RetriggerTime, float VolumeScale, EConcurrencyVolumeScaleMode VolumeScaleMode, float VolumeScaleAttackTime, bool bVolumeScaleCanRelease, float VolumeScaleReleaseTime, float VoiceStealReleaseTime)
		{
			this.MaxCount = MaxCount;
			this.bLimitToOwner = bLimitToOwner;
			this.ResolutionRule = ResolutionRule;
			this.RetriggerTime = RetriggerTime;
			this.VolumeScale = VolumeScale;
			this.VolumeScaleMode = VolumeScaleMode;
			this.VolumeScaleAttackTime = VolumeScaleAttackTime;
			this.bVolumeScaleCanRelease = bVolumeScaleCanRelease;
			this.VolumeScaleReleaseTime = VolumeScaleReleaseTime;
			this.VoiceStealReleaseTime = VoiceStealReleaseTime;
		}

		// Token: 0x06010170 RID: 65904 RVA: 0x0017B488 File Offset: 0x00179688
		protected override IntPtr GetUStructPtr()
		{
			return FSoundConcurrencySettings.StaticStruct();
		}

		// Token: 0x06010171 RID: 65905 RVA: 0x0017B494 File Offset: 0x00179694
		[NullableContext(2)]
		public FSoundConcurrencySettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010172 RID: 65906 RVA: 0x0017B49E File Offset: 0x0017969E
		public FSoundConcurrencySettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06010173 RID: 65907 RVA: 0x0017B4A9 File Offset: 0x001796A9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSoundConcurrencySettings(Pointer, false, true);
		}

		// Token: 0x06010174 RID: 65908 RVA: 0x0017B4B3 File Offset: 0x001796B3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSoundConcurrencySettings(Pointer, MemoryOwner);
		}

		// Token: 0x04008A5C RID: 35420
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.SoundConcurrencySettings";

		// Token: 0x04008A5D RID: 35421
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008A5E RID: 35422
		internal static int __PropertyOffset_MaxCount;

		// Token: 0x04008A5F RID: 35423
		internal static int __PropertyOffset_bLimitToOwner;

		// Token: 0x04008A60 RID: 35424
		internal static byte __PropertyMask_bLimitToOwner;

		// Token: 0x04008A61 RID: 35425
		internal static int __PropertyOffset_ResolutionRule;

		// Token: 0x04008A62 RID: 35426
		internal static int __PropertyOffset_RetriggerTime;

		// Token: 0x04008A63 RID: 35427
		internal static int __PropertyOffset_VolumeScale;

		// Token: 0x04008A64 RID: 35428
		internal static int __PropertyOffset_VolumeScaleMode;

		// Token: 0x04008A65 RID: 35429
		internal static int __PropertyOffset_VolumeScaleAttackTime;

		// Token: 0x04008A66 RID: 35430
		internal static int __PropertyOffset_bVolumeScaleCanRelease;

		// Token: 0x04008A67 RID: 35431
		internal static byte __PropertyMask_bVolumeScaleCanRelease;

		// Token: 0x04008A68 RID: 35432
		internal static int __PropertyOffset_VolumeScaleReleaseTime;

		// Token: 0x04008A69 RID: 35433
		internal static int __PropertyOffset_VoiceStealReleaseTime;
	}
}
