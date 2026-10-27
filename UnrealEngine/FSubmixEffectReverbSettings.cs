using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000382 RID: 898
	[UnrealObjectPath("/Script/AudioMixer.SubmixEffectReverbSettings")]
	[UnrealStructLayout(64, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FSubmixEffectReverbSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06003164 RID: 12644 RVA: 0x0004C611 File Offset: 0x0004A811
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSubmixEffectReverbSettings._ScriptStructPtr != 0) ? FSubmixEffectReverbSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AudioMixer.SubmixEffectReverbSettings", ref FSubmixEffectReverbSettings._ScriptStructPtr);
		}

		// Token: 0x17000C04 RID: 3076
		// (get) Token: 0x06003165 RID: 12645 RVA: 0x0004C635 File Offset: 0x0004A835
		// (set) Token: 0x06003166 RID: 12646 RVA: 0x0004C645 File Offset: 0x0004A845
		public unsafe bool bBypassEarlyReflections
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSubmixEffectReverbSettings.__PropertyOffset_bBypassEarlyReflections) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSubmixEffectReverbSettings.__PropertyOffset_bBypassEarlyReflections) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000C05 RID: 3077
		// (get) Token: 0x06003167 RID: 12647 RVA: 0x0004C656 File Offset: 0x0004A856
		// (set) Token: 0x06003168 RID: 12648 RVA: 0x0004C666 File Offset: 0x0004A866
		public unsafe float ReflectionsDelay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSubmixEffectReverbSettings.__PropertyOffset_ReflectionsDelay);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSubmixEffectReverbSettings.__PropertyOffset_ReflectionsDelay) = value;
			}
		}

		// Token: 0x17000C06 RID: 3078
		// (get) Token: 0x06003169 RID: 12649 RVA: 0x0004C677 File Offset: 0x0004A877
		// (set) Token: 0x0600316A RID: 12650 RVA: 0x0004C687 File Offset: 0x0004A887
		public unsafe float GainHF
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSubmixEffectReverbSettings.__PropertyOffset_GainHF);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSubmixEffectReverbSettings.__PropertyOffset_GainHF) = value;
			}
		}

		// Token: 0x17000C07 RID: 3079
		// (get) Token: 0x0600316B RID: 12651 RVA: 0x0004C698 File Offset: 0x0004A898
		// (set) Token: 0x0600316C RID: 12652 RVA: 0x0004C6A8 File Offset: 0x0004A8A8
		public unsafe float ReflectionsGain
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSubmixEffectReverbSettings.__PropertyOffset_ReflectionsGain);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSubmixEffectReverbSettings.__PropertyOffset_ReflectionsGain) = value;
			}
		}

		// Token: 0x17000C08 RID: 3080
		// (get) Token: 0x0600316D RID: 12653 RVA: 0x0004C6B9 File Offset: 0x0004A8B9
		// (set) Token: 0x0600316E RID: 12654 RVA: 0x0004C6C9 File Offset: 0x0004A8C9
		public unsafe bool bBypassLateReflections
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSubmixEffectReverbSettings.__PropertyOffset_bBypassLateReflections) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSubmixEffectReverbSettings.__PropertyOffset_bBypassLateReflections) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000C09 RID: 3081
		// (get) Token: 0x0600316F RID: 12655 RVA: 0x0004C6DA File Offset: 0x0004A8DA
		// (set) Token: 0x06003170 RID: 12656 RVA: 0x0004C6EA File Offset: 0x0004A8EA
		public unsafe float LateDelay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSubmixEffectReverbSettings.__PropertyOffset_LateDelay);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSubmixEffectReverbSettings.__PropertyOffset_LateDelay) = value;
			}
		}

		// Token: 0x17000C0A RID: 3082
		// (get) Token: 0x06003171 RID: 12657 RVA: 0x0004C6FB File Offset: 0x0004A8FB
		// (set) Token: 0x06003172 RID: 12658 RVA: 0x0004C70B File Offset: 0x0004A90B
		public unsafe float DecayTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSubmixEffectReverbSettings.__PropertyOffset_DecayTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSubmixEffectReverbSettings.__PropertyOffset_DecayTime) = value;
			}
		}

		// Token: 0x17000C0B RID: 3083
		// (get) Token: 0x06003173 RID: 12659 RVA: 0x0004C71C File Offset: 0x0004A91C
		// (set) Token: 0x06003174 RID: 12660 RVA: 0x0004C72C File Offset: 0x0004A92C
		public unsafe float Density
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSubmixEffectReverbSettings.__PropertyOffset_Density);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSubmixEffectReverbSettings.__PropertyOffset_Density) = value;
			}
		}

		// Token: 0x17000C0C RID: 3084
		// (get) Token: 0x06003175 RID: 12661 RVA: 0x0004C73D File Offset: 0x0004A93D
		// (set) Token: 0x06003176 RID: 12662 RVA: 0x0004C74D File Offset: 0x0004A94D
		public unsafe float Diffusion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSubmixEffectReverbSettings.__PropertyOffset_Diffusion);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSubmixEffectReverbSettings.__PropertyOffset_Diffusion) = value;
			}
		}

		// Token: 0x17000C0D RID: 3085
		// (get) Token: 0x06003177 RID: 12663 RVA: 0x0004C75E File Offset: 0x0004A95E
		// (set) Token: 0x06003178 RID: 12664 RVA: 0x0004C76E File Offset: 0x0004A96E
		public unsafe float AirAbsorptionGainHF
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSubmixEffectReverbSettings.__PropertyOffset_AirAbsorptionGainHF);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSubmixEffectReverbSettings.__PropertyOffset_AirAbsorptionGainHF) = value;
			}
		}

		// Token: 0x17000C0E RID: 3086
		// (get) Token: 0x06003179 RID: 12665 RVA: 0x0004C77F File Offset: 0x0004A97F
		// (set) Token: 0x0600317A RID: 12666 RVA: 0x0004C78F File Offset: 0x0004A98F
		public unsafe float DecayHFRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSubmixEffectReverbSettings.__PropertyOffset_DecayHFRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSubmixEffectReverbSettings.__PropertyOffset_DecayHFRatio) = value;
			}
		}

		// Token: 0x17000C0F RID: 3087
		// (get) Token: 0x0600317B RID: 12667 RVA: 0x0004C7A0 File Offset: 0x0004A9A0
		// (set) Token: 0x0600317C RID: 12668 RVA: 0x0004C7B0 File Offset: 0x0004A9B0
		public unsafe float LateGain
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSubmixEffectReverbSettings.__PropertyOffset_LateGain);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSubmixEffectReverbSettings.__PropertyOffset_LateGain) = value;
			}
		}

		// Token: 0x17000C10 RID: 3088
		// (get) Token: 0x0600317D RID: 12669 RVA: 0x0004C7C1 File Offset: 0x0004A9C1
		// (set) Token: 0x0600317E RID: 12670 RVA: 0x0004C7D1 File Offset: 0x0004A9D1
		public unsafe float Gain
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSubmixEffectReverbSettings.__PropertyOffset_Gain);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSubmixEffectReverbSettings.__PropertyOffset_Gain) = value;
			}
		}

		// Token: 0x17000C11 RID: 3089
		// (get) Token: 0x0600317F RID: 12671 RVA: 0x0004C7E2 File Offset: 0x0004A9E2
		// (set) Token: 0x06003180 RID: 12672 RVA: 0x0004C7F2 File Offset: 0x0004A9F2
		public unsafe float WetLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSubmixEffectReverbSettings.__PropertyOffset_WetLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSubmixEffectReverbSettings.__PropertyOffset_WetLevel) = value;
			}
		}

		// Token: 0x17000C12 RID: 3090
		// (get) Token: 0x06003181 RID: 12673 RVA: 0x0004C803 File Offset: 0x0004AA03
		// (set) Token: 0x06003182 RID: 12674 RVA: 0x0004C813 File Offset: 0x0004AA13
		public unsafe float DryLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSubmixEffectReverbSettings.__PropertyOffset_DryLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSubmixEffectReverbSettings.__PropertyOffset_DryLevel) = value;
			}
		}

		// Token: 0x17000C13 RID: 3091
		// (get) Token: 0x06003183 RID: 12675 RVA: 0x0004C824 File Offset: 0x0004AA24
		// (set) Token: 0x06003184 RID: 12676 RVA: 0x0004C834 File Offset: 0x0004AA34
		public unsafe bool bBypass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSubmixEffectReverbSettings.__PropertyOffset_bBypass) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSubmixEffectReverbSettings.__PropertyOffset_bBypass) = (value ? 1 : 0);
			}
		}

		// Token: 0x06003185 RID: 12677 RVA: 0x0004C845 File Offset: 0x0004AA45
		public FSubmixEffectReverbSettings()
		{
		}

		// Token: 0x06003186 RID: 12678 RVA: 0x0004C850 File Offset: 0x0004AA50
		public FSubmixEffectReverbSettings(bool bBypassEarlyReflections, float ReflectionsDelay, float GainHF, float ReflectionsGain, bool bBypassLateReflections, float LateDelay, float DecayTime, float Density, float Diffusion, float AirAbsorptionGainHF, float DecayHFRatio, float LateGain, float Gain, float WetLevel, float DryLevel, bool bBypass)
		{
			this.bBypassEarlyReflections = bBypassEarlyReflections;
			this.ReflectionsDelay = ReflectionsDelay;
			this.GainHF = GainHF;
			this.ReflectionsGain = ReflectionsGain;
			this.bBypassLateReflections = bBypassLateReflections;
			this.LateDelay = LateDelay;
			this.DecayTime = DecayTime;
			this.Density = Density;
			this.Diffusion = Diffusion;
			this.AirAbsorptionGainHF = AirAbsorptionGainHF;
			this.DecayHFRatio = DecayHFRatio;
			this.LateGain = LateGain;
			this.Gain = Gain;
			this.WetLevel = WetLevel;
			this.DryLevel = DryLevel;
			this.bBypass = bBypass;
		}

		// Token: 0x06003187 RID: 12679 RVA: 0x0004C8E0 File Offset: 0x0004AAE0
		protected override IntPtr GetUStructPtr()
		{
			return FSubmixEffectReverbSettings.StaticStruct();
		}

		// Token: 0x06003188 RID: 12680 RVA: 0x0004C8EC File Offset: 0x0004AAEC
		[NullableContext(2)]
		public FSubmixEffectReverbSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003189 RID: 12681 RVA: 0x0004C8F6 File Offset: 0x0004AAF6
		public FSubmixEffectReverbSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600318A RID: 12682 RVA: 0x0004C901 File Offset: 0x0004AB01
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSubmixEffectReverbSettings(Pointer, false, true);
		}

		// Token: 0x0600318B RID: 12683 RVA: 0x0004C90B File Offset: 0x0004AB0B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSubmixEffectReverbSettings(Pointer, MemoryOwner);
		}

		// Token: 0x0400157E RID: 5502
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AudioMixer.SubmixEffectReverbSettings";

		// Token: 0x0400157F RID: 5503
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001580 RID: 5504
		internal static int __PropertyOffset_bBypassEarlyReflections;

		// Token: 0x04001581 RID: 5505
		internal static int __PropertyOffset_ReflectionsDelay;

		// Token: 0x04001582 RID: 5506
		internal static int __PropertyOffset_GainHF;

		// Token: 0x04001583 RID: 5507
		internal static int __PropertyOffset_ReflectionsGain;

		// Token: 0x04001584 RID: 5508
		internal static int __PropertyOffset_bBypassLateReflections;

		// Token: 0x04001585 RID: 5509
		internal static int __PropertyOffset_LateDelay;

		// Token: 0x04001586 RID: 5510
		internal static int __PropertyOffset_DecayTime;

		// Token: 0x04001587 RID: 5511
		internal static int __PropertyOffset_Density;

		// Token: 0x04001588 RID: 5512
		internal static int __PropertyOffset_Diffusion;

		// Token: 0x04001589 RID: 5513
		internal static int __PropertyOffset_AirAbsorptionGainHF;

		// Token: 0x0400158A RID: 5514
		internal static int __PropertyOffset_DecayHFRatio;

		// Token: 0x0400158B RID: 5515
		internal static int __PropertyOffset_LateGain;

		// Token: 0x0400158C RID: 5516
		internal static int __PropertyOffset_Gain;

		// Token: 0x0400158D RID: 5517
		internal static int __PropertyOffset_WetLevel;

		// Token: 0x0400158E RID: 5518
		internal static int __PropertyOffset_DryLevel;

		// Token: 0x0400158F RID: 5519
		internal static int __PropertyOffset_bBypass;
	}
}
