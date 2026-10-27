using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200108D RID: 4237
	[UnrealObjectPath("/Script/Engine.ReverbEffect")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UReverbEffect : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600F22A RID: 61994 RVA: 0x00167528 File Offset: 0x00165728
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UReverbEffect._ClassPtr;
		}

		// Token: 0x0600F22B RID: 61995 RVA: 0x00167534 File Offset: 0x00165734
		public UReverbEffect() : this(BuiltinUtils.AllocNativeUObject(UReverbEffect.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600F22C RID: 61996 RVA: 0x0016755C File Offset: 0x0016575C
		[NullableContext(1)]
		public UReverbEffect(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UReverbEffect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003AF4 RID: 15092
		// (get) Token: 0x0600F22D RID: 61997 RVA: 0x0016758F File Offset: 0x0016578F
		// (set) Token: 0x0600F22E RID: 61998 RVA: 0x0016759F File Offset: 0x0016579F
		public unsafe bool bBypassEarlyReflections
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UReverbEffect.__PropertyOffset_bBypassEarlyReflections) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UReverbEffect.__PropertyOffset_bBypassEarlyReflections) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003AF5 RID: 15093
		// (get) Token: 0x0600F22F RID: 61999 RVA: 0x001675B0 File Offset: 0x001657B0
		// (set) Token: 0x0600F230 RID: 62000 RVA: 0x001675C0 File Offset: 0x001657C0
		public unsafe float ReflectionsDelay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UReverbEffect.__PropertyOffset_ReflectionsDelay);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UReverbEffect.__PropertyOffset_ReflectionsDelay) = value;
			}
		}

		// Token: 0x17003AF6 RID: 15094
		// (get) Token: 0x0600F231 RID: 62001 RVA: 0x001675D1 File Offset: 0x001657D1
		// (set) Token: 0x0600F232 RID: 62002 RVA: 0x001675E1 File Offset: 0x001657E1
		public unsafe float GainHF
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UReverbEffect.__PropertyOffset_GainHF);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UReverbEffect.__PropertyOffset_GainHF) = value;
			}
		}

		// Token: 0x17003AF7 RID: 15095
		// (get) Token: 0x0600F233 RID: 62003 RVA: 0x001675F2 File Offset: 0x001657F2
		// (set) Token: 0x0600F234 RID: 62004 RVA: 0x00167602 File Offset: 0x00165802
		public unsafe float ReflectionsGain
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UReverbEffect.__PropertyOffset_ReflectionsGain);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UReverbEffect.__PropertyOffset_ReflectionsGain) = value;
			}
		}

		// Token: 0x17003AF8 RID: 15096
		// (get) Token: 0x0600F235 RID: 62005 RVA: 0x00167613 File Offset: 0x00165813
		// (set) Token: 0x0600F236 RID: 62006 RVA: 0x00167623 File Offset: 0x00165823
		public unsafe bool bBypassLateReflections
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UReverbEffect.__PropertyOffset_bBypassLateReflections) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UReverbEffect.__PropertyOffset_bBypassLateReflections) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003AF9 RID: 15097
		// (get) Token: 0x0600F237 RID: 62007 RVA: 0x00167634 File Offset: 0x00165834
		// (set) Token: 0x0600F238 RID: 62008 RVA: 0x00167644 File Offset: 0x00165844
		public unsafe float LateDelay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UReverbEffect.__PropertyOffset_LateDelay);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UReverbEffect.__PropertyOffset_LateDelay) = value;
			}
		}

		// Token: 0x17003AFA RID: 15098
		// (get) Token: 0x0600F239 RID: 62009 RVA: 0x00167655 File Offset: 0x00165855
		// (set) Token: 0x0600F23A RID: 62010 RVA: 0x00167665 File Offset: 0x00165865
		public unsafe float DecayTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UReverbEffect.__PropertyOffset_DecayTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UReverbEffect.__PropertyOffset_DecayTime) = value;
			}
		}

		// Token: 0x17003AFB RID: 15099
		// (get) Token: 0x0600F23B RID: 62011 RVA: 0x00167676 File Offset: 0x00165876
		// (set) Token: 0x0600F23C RID: 62012 RVA: 0x00167686 File Offset: 0x00165886
		public unsafe float Density
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UReverbEffect.__PropertyOffset_Density);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UReverbEffect.__PropertyOffset_Density) = value;
			}
		}

		// Token: 0x17003AFC RID: 15100
		// (get) Token: 0x0600F23D RID: 62013 RVA: 0x00167697 File Offset: 0x00165897
		// (set) Token: 0x0600F23E RID: 62014 RVA: 0x001676A7 File Offset: 0x001658A7
		public unsafe float Diffusion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UReverbEffect.__PropertyOffset_Diffusion);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UReverbEffect.__PropertyOffset_Diffusion) = value;
			}
		}

		// Token: 0x17003AFD RID: 15101
		// (get) Token: 0x0600F23F RID: 62015 RVA: 0x001676B8 File Offset: 0x001658B8
		// (set) Token: 0x0600F240 RID: 62016 RVA: 0x001676C8 File Offset: 0x001658C8
		public unsafe float AirAbsorptionGainHF
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UReverbEffect.__PropertyOffset_AirAbsorptionGainHF);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UReverbEffect.__PropertyOffset_AirAbsorptionGainHF) = value;
			}
		}

		// Token: 0x17003AFE RID: 15102
		// (get) Token: 0x0600F241 RID: 62017 RVA: 0x001676D9 File Offset: 0x001658D9
		// (set) Token: 0x0600F242 RID: 62018 RVA: 0x001676E9 File Offset: 0x001658E9
		public unsafe float DecayHFRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UReverbEffect.__PropertyOffset_DecayHFRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UReverbEffect.__PropertyOffset_DecayHFRatio) = value;
			}
		}

		// Token: 0x17003AFF RID: 15103
		// (get) Token: 0x0600F243 RID: 62019 RVA: 0x001676FA File Offset: 0x001658FA
		// (set) Token: 0x0600F244 RID: 62020 RVA: 0x0016770A File Offset: 0x0016590A
		public unsafe float LateGain
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UReverbEffect.__PropertyOffset_LateGain);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UReverbEffect.__PropertyOffset_LateGain) = value;
			}
		}

		// Token: 0x17003B00 RID: 15104
		// (get) Token: 0x0600F245 RID: 62021 RVA: 0x0016771B File Offset: 0x0016591B
		// (set) Token: 0x0600F246 RID: 62022 RVA: 0x0016772B File Offset: 0x0016592B
		public unsafe float Gain
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UReverbEffect.__PropertyOffset_Gain);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UReverbEffect.__PropertyOffset_Gain) = value;
			}
		}

		// Token: 0x17003B01 RID: 15105
		// (get) Token: 0x0600F247 RID: 62023 RVA: 0x0016773C File Offset: 0x0016593C
		// (set) Token: 0x0600F248 RID: 62024 RVA: 0x0016774C File Offset: 0x0016594C
		public unsafe float RoomRolloffFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UReverbEffect.__PropertyOffset_RoomRolloffFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UReverbEffect.__PropertyOffset_RoomRolloffFactor) = value;
			}
		}

		// Token: 0x0600F249 RID: 62025 RVA: 0x0016775D File Offset: 0x0016595D
		static UReverbEffect()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ReverbEffect");
		}

		// Token: 0x0600F24A RID: 62026 RVA: 0x0016776B File Offset: 0x0016596B
		protected UReverbEffect(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400834A RID: 33610
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ReverbEffect";

		// Token: 0x0400834B RID: 33611
		private static IntPtr _ClassPtr;

		// Token: 0x0400834C RID: 33612
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400834D RID: 33613
		internal static int __PropertyOffset_bBypassEarlyReflections;

		// Token: 0x0400834E RID: 33614
		internal static int __PropertyOffset_ReflectionsDelay;

		// Token: 0x0400834F RID: 33615
		internal static int __PropertyOffset_GainHF;

		// Token: 0x04008350 RID: 33616
		internal static int __PropertyOffset_ReflectionsGain;

		// Token: 0x04008351 RID: 33617
		internal static int __PropertyOffset_bBypassLateReflections;

		// Token: 0x04008352 RID: 33618
		internal static int __PropertyOffset_LateDelay;

		// Token: 0x04008353 RID: 33619
		internal static int __PropertyOffset_DecayTime;

		// Token: 0x04008354 RID: 33620
		internal static int __PropertyOffset_Density;

		// Token: 0x04008355 RID: 33621
		internal static int __PropertyOffset_Diffusion;

		// Token: 0x04008356 RID: 33622
		internal static int __PropertyOffset_AirAbsorptionGainHF;

		// Token: 0x04008357 RID: 33623
		internal static int __PropertyOffset_DecayHFRatio;

		// Token: 0x04008358 RID: 33624
		internal static int __PropertyOffset_LateGain;

		// Token: 0x04008359 RID: 33625
		internal static int __PropertyOffset_Gain;

		// Token: 0x0400835A RID: 33626
		internal static int __PropertyOffset_RoomRolloffFactor;
	}
}
