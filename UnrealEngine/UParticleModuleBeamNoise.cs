using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F58 RID: 3928
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleModuleBeamNoise")]
	[UnrealStructLayout(408, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 408)]
	public class UParticleModuleBeamNoise : UParticleModuleBeamBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D3EC RID: 54252 RVA: 0x00137121 File Offset: 0x00135321
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleBeamNoise._ClassPtr;
		}

		// Token: 0x0600D3ED RID: 54253 RVA: 0x00137130 File Offset: 0x00135330
		public UParticleModuleBeamNoise() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleBeamNoise.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D3EE RID: 54254 RVA: 0x00137158 File Offset: 0x00135358
		public UParticleModuleBeamNoise(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleBeamNoise.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003199 RID: 12697
		// (get) Token: 0x0600D3EF RID: 54255 RVA: 0x0013718B File Offset: 0x0013538B
		// (set) Token: 0x0600D3F0 RID: 54256 RVA: 0x001371A4 File Offset: 0x001353A4
		public unsafe bool bLowFreq_Enabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleBeamNoise.__PropertyOffset_bLowFreq_Enabled) & UParticleModuleBeamNoise.__PropertyMask_bLowFreq_Enabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleBeamNoise.__PropertyOffset_bLowFreq_Enabled) = ((*(base.NativePtr + (IntPtr)UParticleModuleBeamNoise.__PropertyOffset_bLowFreq_Enabled) & ~UParticleModuleBeamNoise.__PropertyMask_bLowFreq_Enabled) | (value ? UParticleModuleBeamNoise.__PropertyMask_bLowFreq_Enabled : 0));
			}
		}

		// Token: 0x1700319A RID: 12698
		// (get) Token: 0x0600D3F1 RID: 54257 RVA: 0x001371D4 File Offset: 0x001353D4
		// (set) Token: 0x0600D3F2 RID: 54258 RVA: 0x001371E4 File Offset: 0x001353E4
		public unsafe int Frequency
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleBeamNoise.__PropertyOffset_Frequency);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleBeamNoise.__PropertyOffset_Frequency) = value;
			}
		}

		// Token: 0x1700319B RID: 12699
		// (get) Token: 0x0600D3F3 RID: 54259 RVA: 0x001371F5 File Offset: 0x001353F5
		// (set) Token: 0x0600D3F4 RID: 54260 RVA: 0x00137205 File Offset: 0x00135405
		public unsafe int Frequency_LowRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleBeamNoise.__PropertyOffset_Frequency_LowRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleBeamNoise.__PropertyOffset_Frequency_LowRange) = value;
			}
		}

		// Token: 0x1700319C RID: 12700
		// (get) Token: 0x0600D3F5 RID: 54261 RVA: 0x00137218 File Offset: 0x00135418
		// (set) Token: 0x0600D3F6 RID: 54262 RVA: 0x00137251 File Offset: 0x00135451
		public FRawDistributionVector NoiseRange
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionVector result;
				if ((result = this._NoiseRange) == null)
				{
					result = (this._NoiseRange = new FRawDistributionVector(base.NativePtr + (IntPtr)UParticleModuleBeamNoise.__PropertyOffset_NoiseRange, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionVector.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleBeamNoise.__PropertyOffset_NoiseRange, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700319D RID: 12701
		// (get) Token: 0x0600D3F7 RID: 54263 RVA: 0x00137274 File Offset: 0x00135474
		// (set) Token: 0x0600D3F8 RID: 54264 RVA: 0x001372AD File Offset: 0x001354AD
		public FRawDistributionFloat NoiseRangeScale
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionFloat result;
				if ((result = this._NoiseRangeScale) == null)
				{
					result = (this._NoiseRangeScale = new FRawDistributionFloat(base.NativePtr + (IntPtr)UParticleModuleBeamNoise.__PropertyOffset_NoiseRangeScale, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionFloat.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleBeamNoise.__PropertyOffset_NoiseRangeScale, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700319E RID: 12702
		// (get) Token: 0x0600D3F9 RID: 54265 RVA: 0x001372CE File Offset: 0x001354CE
		// (set) Token: 0x0600D3FA RID: 54266 RVA: 0x001372E7 File Offset: 0x001354E7
		public unsafe bool bNRScaleEmitterTime
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleBeamNoise.__PropertyOffset_bNRScaleEmitterTime) & UParticleModuleBeamNoise.__PropertyMask_bNRScaleEmitterTime) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleBeamNoise.__PropertyOffset_bNRScaleEmitterTime) = ((*(base.NativePtr + (IntPtr)UParticleModuleBeamNoise.__PropertyOffset_bNRScaleEmitterTime) & ~UParticleModuleBeamNoise.__PropertyMask_bNRScaleEmitterTime) | (value ? UParticleModuleBeamNoise.__PropertyMask_bNRScaleEmitterTime : 0));
			}
		}

		// Token: 0x1700319F RID: 12703
		// (get) Token: 0x0600D3FB RID: 54267 RVA: 0x00137318 File Offset: 0x00135518
		// (set) Token: 0x0600D3FC RID: 54268 RVA: 0x00137351 File Offset: 0x00135551
		public FRawDistributionVector NoiseSpeed
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionVector result;
				if ((result = this._NoiseSpeed) == null)
				{
					result = (this._NoiseSpeed = new FRawDistributionVector(base.NativePtr + (IntPtr)UParticleModuleBeamNoise.__PropertyOffset_NoiseSpeed, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionVector.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleBeamNoise.__PropertyOffset_NoiseSpeed, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170031A0 RID: 12704
		// (get) Token: 0x0600D3FD RID: 54269 RVA: 0x00137372 File Offset: 0x00135572
		// (set) Token: 0x0600D3FE RID: 54270 RVA: 0x0013738B File Offset: 0x0013558B
		public unsafe bool bSmooth
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleBeamNoise.__PropertyOffset_bSmooth) & UParticleModuleBeamNoise.__PropertyMask_bSmooth) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleBeamNoise.__PropertyOffset_bSmooth) = ((*(base.NativePtr + (IntPtr)UParticleModuleBeamNoise.__PropertyOffset_bSmooth) & ~UParticleModuleBeamNoise.__PropertyMask_bSmooth) | (value ? UParticleModuleBeamNoise.__PropertyMask_bSmooth : 0));
			}
		}

		// Token: 0x170031A1 RID: 12705
		// (get) Token: 0x0600D3FF RID: 54271 RVA: 0x001373BB File Offset: 0x001355BB
		// (set) Token: 0x0600D400 RID: 54272 RVA: 0x001373CB File Offset: 0x001355CB
		public unsafe float NoiseLockRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleBeamNoise.__PropertyOffset_NoiseLockRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleBeamNoise.__PropertyOffset_NoiseLockRadius) = value;
			}
		}

		// Token: 0x170031A2 RID: 12706
		// (get) Token: 0x0600D401 RID: 54273 RVA: 0x001373DC File Offset: 0x001355DC
		// (set) Token: 0x0600D402 RID: 54274 RVA: 0x001373F5 File Offset: 0x001355F5
		public unsafe bool bNoiseLock
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleBeamNoise.__PropertyOffset_bNoiseLock) & UParticleModuleBeamNoise.__PropertyMask_bNoiseLock) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleBeamNoise.__PropertyOffset_bNoiseLock) = ((*(base.NativePtr + (IntPtr)UParticleModuleBeamNoise.__PropertyOffset_bNoiseLock) & ~UParticleModuleBeamNoise.__PropertyMask_bNoiseLock) | (value ? UParticleModuleBeamNoise.__PropertyMask_bNoiseLock : 0));
			}
		}

		// Token: 0x170031A3 RID: 12707
		// (get) Token: 0x0600D403 RID: 54275 RVA: 0x00137425 File Offset: 0x00135625
		// (set) Token: 0x0600D404 RID: 54276 RVA: 0x0013743E File Offset: 0x0013563E
		public unsafe bool bOscillate
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleBeamNoise.__PropertyOffset_bOscillate) & UParticleModuleBeamNoise.__PropertyMask_bOscillate) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleBeamNoise.__PropertyOffset_bOscillate) = ((*(base.NativePtr + (IntPtr)UParticleModuleBeamNoise.__PropertyOffset_bOscillate) & ~UParticleModuleBeamNoise.__PropertyMask_bOscillate) | (value ? UParticleModuleBeamNoise.__PropertyMask_bOscillate : 0));
			}
		}

		// Token: 0x170031A4 RID: 12708
		// (get) Token: 0x0600D405 RID: 54277 RVA: 0x0013746E File Offset: 0x0013566E
		// (set) Token: 0x0600D406 RID: 54278 RVA: 0x0013747E File Offset: 0x0013567E
		public unsafe float NoiseLockTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleBeamNoise.__PropertyOffset_NoiseLockTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleBeamNoise.__PropertyOffset_NoiseLockTime) = value;
			}
		}

		// Token: 0x170031A5 RID: 12709
		// (get) Token: 0x0600D407 RID: 54279 RVA: 0x0013748F File Offset: 0x0013568F
		// (set) Token: 0x0600D408 RID: 54280 RVA: 0x0013749F File Offset: 0x0013569F
		public unsafe float NoiseTension
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleBeamNoise.__PropertyOffset_NoiseTension);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleBeamNoise.__PropertyOffset_NoiseTension) = value;
			}
		}

		// Token: 0x170031A6 RID: 12710
		// (get) Token: 0x0600D409 RID: 54281 RVA: 0x001374B0 File Offset: 0x001356B0
		// (set) Token: 0x0600D40A RID: 54282 RVA: 0x001374C9 File Offset: 0x001356C9
		public unsafe bool bUseNoiseTangents
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleBeamNoise.__PropertyOffset_bUseNoiseTangents) & UParticleModuleBeamNoise.__PropertyMask_bUseNoiseTangents) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleBeamNoise.__PropertyOffset_bUseNoiseTangents) = ((*(base.NativePtr + (IntPtr)UParticleModuleBeamNoise.__PropertyOffset_bUseNoiseTangents) & ~UParticleModuleBeamNoise.__PropertyMask_bUseNoiseTangents) | (value ? UParticleModuleBeamNoise.__PropertyMask_bUseNoiseTangents : 0));
			}
		}

		// Token: 0x170031A7 RID: 12711
		// (get) Token: 0x0600D40B RID: 54283 RVA: 0x001374FC File Offset: 0x001356FC
		// (set) Token: 0x0600D40C RID: 54284 RVA: 0x00137535 File Offset: 0x00135735
		public FRawDistributionFloat NoiseTangentStrength
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionFloat result;
				if ((result = this._NoiseTangentStrength) == null)
				{
					result = (this._NoiseTangentStrength = new FRawDistributionFloat(base.NativePtr + (IntPtr)UParticleModuleBeamNoise.__PropertyOffset_NoiseTangentStrength, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionFloat.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleBeamNoise.__PropertyOffset_NoiseTangentStrength, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170031A8 RID: 12712
		// (get) Token: 0x0600D40D RID: 54285 RVA: 0x00137556 File Offset: 0x00135756
		// (set) Token: 0x0600D40E RID: 54286 RVA: 0x00137566 File Offset: 0x00135766
		public unsafe int NoiseTessellation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleBeamNoise.__PropertyOffset_NoiseTessellation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleBeamNoise.__PropertyOffset_NoiseTessellation) = value;
			}
		}

		// Token: 0x170031A9 RID: 12713
		// (get) Token: 0x0600D40F RID: 54287 RVA: 0x00137577 File Offset: 0x00135777
		// (set) Token: 0x0600D410 RID: 54288 RVA: 0x00137590 File Offset: 0x00135790
		public unsafe bool bTargetNoise
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleBeamNoise.__PropertyOffset_bTargetNoise) & UParticleModuleBeamNoise.__PropertyMask_bTargetNoise) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleBeamNoise.__PropertyOffset_bTargetNoise) = ((*(base.NativePtr + (IntPtr)UParticleModuleBeamNoise.__PropertyOffset_bTargetNoise) & ~UParticleModuleBeamNoise.__PropertyMask_bTargetNoise) | (value ? UParticleModuleBeamNoise.__PropertyMask_bTargetNoise : 0));
			}
		}

		// Token: 0x170031AA RID: 12714
		// (get) Token: 0x0600D411 RID: 54289 RVA: 0x001375C0 File Offset: 0x001357C0
		// (set) Token: 0x0600D412 RID: 54290 RVA: 0x001375D0 File Offset: 0x001357D0
		public unsafe float FrequencyDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleBeamNoise.__PropertyOffset_FrequencyDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleBeamNoise.__PropertyOffset_FrequencyDistance) = value;
			}
		}

		// Token: 0x170031AB RID: 12715
		// (get) Token: 0x0600D413 RID: 54291 RVA: 0x001375E1 File Offset: 0x001357E1
		// (set) Token: 0x0600D414 RID: 54292 RVA: 0x001375FA File Offset: 0x001357FA
		public unsafe bool bApplyNoiseScale
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleBeamNoise.__PropertyOffset_bApplyNoiseScale) & UParticleModuleBeamNoise.__PropertyMask_bApplyNoiseScale) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleBeamNoise.__PropertyOffset_bApplyNoiseScale) = ((*(base.NativePtr + (IntPtr)UParticleModuleBeamNoise.__PropertyOffset_bApplyNoiseScale) & ~UParticleModuleBeamNoise.__PropertyMask_bApplyNoiseScale) | (value ? UParticleModuleBeamNoise.__PropertyMask_bApplyNoiseScale : 0));
			}
		}

		// Token: 0x170031AC RID: 12716
		// (get) Token: 0x0600D415 RID: 54293 RVA: 0x0013762C File Offset: 0x0013582C
		// (set) Token: 0x0600D416 RID: 54294 RVA: 0x00137665 File Offset: 0x00135865
		public FRawDistributionFloat NoiseScale
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionFloat result;
				if ((result = this._NoiseScale) == null)
				{
					result = (this._NoiseScale = new FRawDistributionFloat(base.NativePtr + (IntPtr)UParticleModuleBeamNoise.__PropertyOffset_NoiseScale, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionFloat.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleBeamNoise.__PropertyOffset_NoiseScale, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600D417 RID: 54295 RVA: 0x00137686 File Offset: 0x00135886
		static UParticleModuleBeamNoise()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleBeamNoise");
		}

		// Token: 0x0600D418 RID: 54296 RVA: 0x00137694 File Offset: 0x00135894
		protected UParticleModuleBeamNoise(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040071EA RID: 29162
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleBeamNoise";

		// Token: 0x040071EB RID: 29163
		private static IntPtr _ClassPtr;

		// Token: 0x040071EC RID: 29164
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040071ED RID: 29165
		internal static int __PropertyOffset_bLowFreq_Enabled;

		// Token: 0x040071EE RID: 29166
		internal static byte __PropertyMask_bLowFreq_Enabled;

		// Token: 0x040071EF RID: 29167
		internal static int __PropertyOffset_Frequency;

		// Token: 0x040071F0 RID: 29168
		internal static int __PropertyOffset_Frequency_LowRange;

		// Token: 0x040071F1 RID: 29169
		internal static int __PropertyOffset_NoiseRange;

		// Token: 0x040071F2 RID: 29170
		[Nullable(2)]
		private FRawDistributionVector _NoiseRange;

		// Token: 0x040071F3 RID: 29171
		internal static int __PropertyOffset_NoiseRangeScale;

		// Token: 0x040071F4 RID: 29172
		[Nullable(2)]
		private FRawDistributionFloat _NoiseRangeScale;

		// Token: 0x040071F5 RID: 29173
		internal static int __PropertyOffset_bNRScaleEmitterTime;

		// Token: 0x040071F6 RID: 29174
		internal static byte __PropertyMask_bNRScaleEmitterTime;

		// Token: 0x040071F7 RID: 29175
		internal static int __PropertyOffset_NoiseSpeed;

		// Token: 0x040071F8 RID: 29176
		[Nullable(2)]
		private FRawDistributionVector _NoiseSpeed;

		// Token: 0x040071F9 RID: 29177
		internal static int __PropertyOffset_bSmooth;

		// Token: 0x040071FA RID: 29178
		internal static byte __PropertyMask_bSmooth;

		// Token: 0x040071FB RID: 29179
		internal static int __PropertyOffset_NoiseLockRadius;

		// Token: 0x040071FC RID: 29180
		internal static int __PropertyOffset_bNoiseLock;

		// Token: 0x040071FD RID: 29181
		internal static byte __PropertyMask_bNoiseLock;

		// Token: 0x040071FE RID: 29182
		internal static int __PropertyOffset_bOscillate;

		// Token: 0x040071FF RID: 29183
		internal static byte __PropertyMask_bOscillate;

		// Token: 0x04007200 RID: 29184
		internal static int __PropertyOffset_NoiseLockTime;

		// Token: 0x04007201 RID: 29185
		internal static int __PropertyOffset_NoiseTension;

		// Token: 0x04007202 RID: 29186
		internal static int __PropertyOffset_bUseNoiseTangents;

		// Token: 0x04007203 RID: 29187
		internal static byte __PropertyMask_bUseNoiseTangents;

		// Token: 0x04007204 RID: 29188
		internal static int __PropertyOffset_NoiseTangentStrength;

		// Token: 0x04007205 RID: 29189
		[Nullable(2)]
		private FRawDistributionFloat _NoiseTangentStrength;

		// Token: 0x04007206 RID: 29190
		internal static int __PropertyOffset_NoiseTessellation;

		// Token: 0x04007207 RID: 29191
		internal static int __PropertyOffset_bTargetNoise;

		// Token: 0x04007208 RID: 29192
		internal static byte __PropertyMask_bTargetNoise;

		// Token: 0x04007209 RID: 29193
		internal static int __PropertyOffset_FrequencyDistance;

		// Token: 0x0400720A RID: 29194
		internal static int __PropertyOffset_bApplyNoiseScale;

		// Token: 0x0400720B RID: 29195
		internal static byte __PropertyMask_bApplyNoiseScale;

		// Token: 0x0400720C RID: 29196
		internal static int __PropertyOffset_NoiseScale;

		// Token: 0x0400720D RID: 29197
		[Nullable(2)]
		private FRawDistributionFloat _NoiseScale;
	}
}
