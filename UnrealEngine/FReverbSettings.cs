using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200108F RID: 4239
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ReverbSettings")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FReverbSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600F24B RID: 62027 RVA: 0x00167774 File Offset: 0x00165974
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FReverbSettings._ScriptStructPtr != 0) ? FReverbSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ReverbSettings", ref FReverbSettings._ScriptStructPtr);
		}

		// Token: 0x17003B02 RID: 15106
		// (get) Token: 0x0600F24C RID: 62028 RVA: 0x00167798 File Offset: 0x00165998
		// (set) Token: 0x0600F24D RID: 62029 RVA: 0x001677A8 File Offset: 0x001659A8
		public unsafe bool bApplyReverb
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FReverbSettings.__PropertyOffset_bApplyReverb) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FReverbSettings.__PropertyOffset_bApplyReverb) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003B03 RID: 15107
		// (get) Token: 0x0600F24E RID: 62030 RVA: 0x001677B9 File Offset: 0x001659B9
		// (set) Token: 0x0600F24F RID: 62031 RVA: 0x001677CD File Offset: 0x001659CD
		public unsafe UReverbEffect ReverbEffect
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UReverbEffect>(base.NativePtr / (IntPtr)sizeof(void*) + FReverbSettings.__PropertyOffset_ReverbEffect);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FReverbSettings.__PropertyOffset_ReverbEffect, value);
			}
		}

		// Token: 0x17003B04 RID: 15108
		// (get) Token: 0x0600F250 RID: 62032 RVA: 0x001677E2 File Offset: 0x001659E2
		// (set) Token: 0x0600F251 RID: 62033 RVA: 0x001677F6 File Offset: 0x001659F6
		public unsafe USoundEffectSubmixPreset ReverbPluginEffect
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USoundEffectSubmixPreset>(base.NativePtr / (IntPtr)sizeof(void*) + FReverbSettings.__PropertyOffset_ReverbPluginEffect);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FReverbSettings.__PropertyOffset_ReverbPluginEffect, value);
			}
		}

		// Token: 0x17003B05 RID: 15109
		// (get) Token: 0x0600F252 RID: 62034 RVA: 0x0016780B File Offset: 0x00165A0B
		// (set) Token: 0x0600F253 RID: 62035 RVA: 0x0016781B File Offset: 0x00165A1B
		public unsafe float Volume
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FReverbSettings.__PropertyOffset_Volume);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FReverbSettings.__PropertyOffset_Volume) = value;
			}
		}

		// Token: 0x17003B06 RID: 15110
		// (get) Token: 0x0600F254 RID: 62036 RVA: 0x0016782C File Offset: 0x00165A2C
		// (set) Token: 0x0600F255 RID: 62037 RVA: 0x0016783C File Offset: 0x00165A3C
		public unsafe float FadeTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FReverbSettings.__PropertyOffset_FadeTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FReverbSettings.__PropertyOffset_FadeTime) = value;
			}
		}

		// Token: 0x0600F256 RID: 62038 RVA: 0x0016784D File Offset: 0x00165A4D
		public FReverbSettings()
		{
		}

		// Token: 0x0600F257 RID: 62039 RVA: 0x00167855 File Offset: 0x00165A55
		[NullableContext(1)]
		public FReverbSettings(bool bApplyReverb, [Nullable(0)] TEnumAsByte<ReverbPreset> ReverbType_DEPRECATED, UReverbEffect ReverbEffect, USoundEffectSubmixPreset ReverbPluginEffect, float Volume, float FadeTime)
		{
			this.bApplyReverb = bApplyReverb;
			this.ReverbEffect = ReverbEffect;
			this.ReverbPluginEffect = ReverbPluginEffect;
			this.Volume = Volume;
			this.FadeTime = FadeTime;
		}

		// Token: 0x0600F258 RID: 62040 RVA: 0x00167883 File Offset: 0x00165A83
		protected override IntPtr GetUStructPtr()
		{
			return FReverbSettings.StaticStruct();
		}

		// Token: 0x0600F259 RID: 62041 RVA: 0x0016788F File Offset: 0x00165A8F
		public FReverbSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600F25A RID: 62042 RVA: 0x00167899 File Offset: 0x00165A99
		public FReverbSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600F25B RID: 62043 RVA: 0x001678A4 File Offset: 0x00165AA4
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FReverbSettings(Pointer, false, true);
		}

		// Token: 0x0600F25C RID: 62044 RVA: 0x001678AE File Offset: 0x00165AAE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FReverbSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04008374 RID: 33652
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ReverbSettings";

		// Token: 0x04008375 RID: 33653
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008376 RID: 33654
		internal static int __PropertyOffset_bApplyReverb;

		// Token: 0x04008377 RID: 33655
		internal static int __PropertyOffset_ReverbEffect;

		// Token: 0x04008378 RID: 33656
		internal static int __PropertyOffset_ReverbPluginEffect;

		// Token: 0x04008379 RID: 33657
		internal static int __PropertyOffset_Volume;

		// Token: 0x0400837A RID: 33658
		internal static int __PropertyOffset_FadeTime;
	}
}
