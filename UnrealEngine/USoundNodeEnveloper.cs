using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001143 RID: 4419
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SoundNodeEnveloper")]
	[UnrealStructLayout(416, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 416)]
	public class USoundNodeEnveloper : USoundNode, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06010266 RID: 66150 RVA: 0x0017CBBD File Offset: 0x0017ADBD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USoundNodeEnveloper._ClassPtr;
		}

		// Token: 0x06010267 RID: 66151 RVA: 0x0017CBCC File Offset: 0x0017ADCC
		public USoundNodeEnveloper() : this(BuiltinUtils.AllocNativeUObject(USoundNodeEnveloper.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010268 RID: 66152 RVA: 0x0017CBF4 File Offset: 0x0017ADF4
		public USoundNodeEnveloper(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USoundNodeEnveloper.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003F37 RID: 16183
		// (get) Token: 0x06010269 RID: 66153 RVA: 0x0017CC27 File Offset: 0x0017AE27
		// (set) Token: 0x0601026A RID: 66154 RVA: 0x0017CC37 File Offset: 0x0017AE37
		public unsafe float LoopStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USoundNodeEnveloper.__PropertyOffset_LoopStart);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USoundNodeEnveloper.__PropertyOffset_LoopStart) = value;
			}
		}

		// Token: 0x17003F38 RID: 16184
		// (get) Token: 0x0601026B RID: 66155 RVA: 0x0017CC48 File Offset: 0x0017AE48
		// (set) Token: 0x0601026C RID: 66156 RVA: 0x0017CC58 File Offset: 0x0017AE58
		public unsafe float LoopEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USoundNodeEnveloper.__PropertyOffset_LoopEnd);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USoundNodeEnveloper.__PropertyOffset_LoopEnd) = value;
			}
		}

		// Token: 0x17003F39 RID: 16185
		// (get) Token: 0x0601026D RID: 66157 RVA: 0x0017CC69 File Offset: 0x0017AE69
		// (set) Token: 0x0601026E RID: 66158 RVA: 0x0017CC79 File Offset: 0x0017AE79
		public unsafe float DurationAfterLoop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USoundNodeEnveloper.__PropertyOffset_DurationAfterLoop);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USoundNodeEnveloper.__PropertyOffset_DurationAfterLoop) = value;
			}
		}

		// Token: 0x17003F3A RID: 16186
		// (get) Token: 0x0601026F RID: 66159 RVA: 0x0017CC8A File Offset: 0x0017AE8A
		// (set) Token: 0x06010270 RID: 66160 RVA: 0x0017CC9A File Offset: 0x0017AE9A
		public unsafe int LoopCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USoundNodeEnveloper.__PropertyOffset_LoopCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USoundNodeEnveloper.__PropertyOffset_LoopCount) = value;
			}
		}

		// Token: 0x17003F3B RID: 16187
		// (get) Token: 0x06010271 RID: 66161 RVA: 0x0017CCAB File Offset: 0x0017AEAB
		// (set) Token: 0x06010272 RID: 66162 RVA: 0x0017CCC4 File Offset: 0x0017AEC4
		public unsafe bool bLoopIndefinitely
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USoundNodeEnveloper.__PropertyOffset_bLoopIndefinitely) & USoundNodeEnveloper.__PropertyMask_bLoopIndefinitely) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USoundNodeEnveloper.__PropertyOffset_bLoopIndefinitely) = ((*(base.NativePtr + (IntPtr)USoundNodeEnveloper.__PropertyOffset_bLoopIndefinitely) & ~USoundNodeEnveloper.__PropertyMask_bLoopIndefinitely) | (value ? USoundNodeEnveloper.__PropertyMask_bLoopIndefinitely : 0));
			}
		}

		// Token: 0x17003F3C RID: 16188
		// (get) Token: 0x06010273 RID: 66163 RVA: 0x0017CCF4 File Offset: 0x0017AEF4
		// (set) Token: 0x06010274 RID: 66164 RVA: 0x0017CD0D File Offset: 0x0017AF0D
		public unsafe bool bLoop
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USoundNodeEnveloper.__PropertyOffset_bLoop) & USoundNodeEnveloper.__PropertyMask_bLoop) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USoundNodeEnveloper.__PropertyOffset_bLoop) = ((*(base.NativePtr + (IntPtr)USoundNodeEnveloper.__PropertyOffset_bLoop) & ~USoundNodeEnveloper.__PropertyMask_bLoop) | (value ? USoundNodeEnveloper.__PropertyMask_bLoop : 0));
			}
		}

		// Token: 0x17003F3D RID: 16189
		// (get) Token: 0x06010275 RID: 66165 RVA: 0x0017CD3D File Offset: 0x0017AF3D
		// (set) Token: 0x06010276 RID: 66166 RVA: 0x0017CD51 File Offset: 0x0017AF51
		[Nullable(2)]
		public unsafe UDistributionFloatConstantCurve VolumeInterpCurve_DEPRECATED
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDistributionFloatConstantCurve>(base.NativePtr / (IntPtr)sizeof(void*) + USoundNodeEnveloper.__PropertyOffset_VolumeInterpCurve_DEPRECATED);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USoundNodeEnveloper.__PropertyOffset_VolumeInterpCurve_DEPRECATED, value);
			}
		}

		// Token: 0x17003F3E RID: 16190
		// (get) Token: 0x06010277 RID: 66167 RVA: 0x0017CD66 File Offset: 0x0017AF66
		// (set) Token: 0x06010278 RID: 66168 RVA: 0x0017CD7A File Offset: 0x0017AF7A
		[Nullable(2)]
		public unsafe UDistributionFloatConstantCurve PitchInterpCurve_DEPRECATED
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDistributionFloatConstantCurve>(base.NativePtr / (IntPtr)sizeof(void*) + USoundNodeEnveloper.__PropertyOffset_PitchInterpCurve_DEPRECATED);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USoundNodeEnveloper.__PropertyOffset_PitchInterpCurve_DEPRECATED, value);
			}
		}

		// Token: 0x17003F3F RID: 16191
		// (get) Token: 0x06010279 RID: 66169 RVA: 0x0017CD90 File Offset: 0x0017AF90
		// (set) Token: 0x0601027A RID: 66170 RVA: 0x0017CDC9 File Offset: 0x0017AFC9
		public FRuntimeFloatCurve VolumeCurve
		{
			get
			{
				base.FastCheckIsValid();
				FRuntimeFloatCurve result;
				if ((result = this._VolumeCurve) == null)
				{
					result = (this._VolumeCurve = new FRuntimeFloatCurve(base.NativePtr + (IntPtr)USoundNodeEnveloper.__PropertyOffset_VolumeCurve, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRuntimeFloatCurve.StaticStruct(), base.NativePtr + (IntPtr)USoundNodeEnveloper.__PropertyOffset_VolumeCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003F40 RID: 16192
		// (get) Token: 0x0601027B RID: 66171 RVA: 0x0017CDEC File Offset: 0x0017AFEC
		// (set) Token: 0x0601027C RID: 66172 RVA: 0x0017CE25 File Offset: 0x0017B025
		public FRuntimeFloatCurve PitchCurve
		{
			get
			{
				base.FastCheckIsValid();
				FRuntimeFloatCurve result;
				if ((result = this._PitchCurve) == null)
				{
					result = (this._PitchCurve = new FRuntimeFloatCurve(base.NativePtr + (IntPtr)USoundNodeEnveloper.__PropertyOffset_PitchCurve, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRuntimeFloatCurve.StaticStruct(), base.NativePtr + (IntPtr)USoundNodeEnveloper.__PropertyOffset_PitchCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003F41 RID: 16193
		// (get) Token: 0x0601027D RID: 66173 RVA: 0x0017CE46 File Offset: 0x0017B046
		// (set) Token: 0x0601027E RID: 66174 RVA: 0x0017CE56 File Offset: 0x0017B056
		public unsafe float PitchMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USoundNodeEnveloper.__PropertyOffset_PitchMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USoundNodeEnveloper.__PropertyOffset_PitchMin) = value;
			}
		}

		// Token: 0x17003F42 RID: 16194
		// (get) Token: 0x0601027F RID: 66175 RVA: 0x0017CE67 File Offset: 0x0017B067
		// (set) Token: 0x06010280 RID: 66176 RVA: 0x0017CE77 File Offset: 0x0017B077
		public unsafe float PitchMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USoundNodeEnveloper.__PropertyOffset_PitchMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USoundNodeEnveloper.__PropertyOffset_PitchMax) = value;
			}
		}

		// Token: 0x17003F43 RID: 16195
		// (get) Token: 0x06010281 RID: 66177 RVA: 0x0017CE88 File Offset: 0x0017B088
		// (set) Token: 0x06010282 RID: 66178 RVA: 0x0017CE98 File Offset: 0x0017B098
		public unsafe float VolumeMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USoundNodeEnveloper.__PropertyOffset_VolumeMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USoundNodeEnveloper.__PropertyOffset_VolumeMin) = value;
			}
		}

		// Token: 0x17003F44 RID: 16196
		// (get) Token: 0x06010283 RID: 66179 RVA: 0x0017CEA9 File Offset: 0x0017B0A9
		// (set) Token: 0x06010284 RID: 66180 RVA: 0x0017CEB9 File Offset: 0x0017B0B9
		public unsafe float VolumeMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USoundNodeEnveloper.__PropertyOffset_VolumeMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USoundNodeEnveloper.__PropertyOffset_VolumeMax) = value;
			}
		}

		// Token: 0x06010285 RID: 66181 RVA: 0x0017CECA File Offset: 0x0017B0CA
		static USoundNodeEnveloper()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SoundNodeEnveloper");
		}

		// Token: 0x06010286 RID: 66182 RVA: 0x0017CED8 File Offset: 0x0017B0D8
		protected USoundNodeEnveloper(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008AFE RID: 35582
		public new const string __ObjectPath = "/Script/Engine.SoundNodeEnveloper";

		// Token: 0x04008AFF RID: 35583
		private static IntPtr _ClassPtr;

		// Token: 0x04008B00 RID: 35584
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008B01 RID: 35585
		internal static int __PropertyOffset_LoopStart;

		// Token: 0x04008B02 RID: 35586
		internal static int __PropertyOffset_LoopEnd;

		// Token: 0x04008B03 RID: 35587
		internal static int __PropertyOffset_DurationAfterLoop;

		// Token: 0x04008B04 RID: 35588
		internal static int __PropertyOffset_LoopCount;

		// Token: 0x04008B05 RID: 35589
		internal static int __PropertyOffset_bLoopIndefinitely;

		// Token: 0x04008B06 RID: 35590
		internal static byte __PropertyMask_bLoopIndefinitely;

		// Token: 0x04008B07 RID: 35591
		internal static int __PropertyOffset_bLoop;

		// Token: 0x04008B08 RID: 35592
		internal static byte __PropertyMask_bLoop;

		// Token: 0x04008B09 RID: 35593
		internal static int __PropertyOffset_VolumeInterpCurve_DEPRECATED;

		// Token: 0x04008B0A RID: 35594
		internal static int __PropertyOffset_PitchInterpCurve_DEPRECATED;

		// Token: 0x04008B0B RID: 35595
		internal static int __PropertyOffset_VolumeCurve;

		// Token: 0x04008B0C RID: 35596
		[Nullable(2)]
		private FRuntimeFloatCurve _VolumeCurve;

		// Token: 0x04008B0D RID: 35597
		internal static int __PropertyOffset_PitchCurve;

		// Token: 0x04008B0E RID: 35598
		[Nullable(2)]
		private FRuntimeFloatCurve _PitchCurve;

		// Token: 0x04008B0F RID: 35599
		internal static int __PropertyOffset_PitchMin;

		// Token: 0x04008B10 RID: 35600
		internal static int __PropertyOffset_PitchMax;

		// Token: 0x04008B11 RID: 35601
		internal static int __PropertyOffset_VolumeMin;

		// Token: 0x04008B12 RID: 35602
		internal static int __PropertyOffset_VolumeMax;
	}
}
