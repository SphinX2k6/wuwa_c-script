using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200114A RID: 4426
	[UnrealObjectPath("/Script/Engine.SoundNodeOscillator")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class USoundNodeOscillator : USoundNode, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060102B9 RID: 66233 RVA: 0x0017D415 File Offset: 0x0017B615
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USoundNodeOscillator._ClassPtr;
		}

		// Token: 0x060102BA RID: 66234 RVA: 0x0017D424 File Offset: 0x0017B624
		public USoundNodeOscillator() : this(BuiltinUtils.AllocNativeUObject(USoundNodeOscillator.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060102BB RID: 66235 RVA: 0x0017D44C File Offset: 0x0017B64C
		[NullableContext(1)]
		public USoundNodeOscillator(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USoundNodeOscillator.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003F4F RID: 16207
		// (get) Token: 0x060102BC RID: 66236 RVA: 0x0017D47F File Offset: 0x0017B67F
		// (set) Token: 0x060102BD RID: 66237 RVA: 0x0017D498 File Offset: 0x0017B698
		public unsafe bool bModulateVolume
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USoundNodeOscillator.__PropertyOffset_bModulateVolume) & USoundNodeOscillator.__PropertyMask_bModulateVolume) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USoundNodeOscillator.__PropertyOffset_bModulateVolume) = ((*(base.NativePtr + (IntPtr)USoundNodeOscillator.__PropertyOffset_bModulateVolume) & ~USoundNodeOscillator.__PropertyMask_bModulateVolume) | (value ? USoundNodeOscillator.__PropertyMask_bModulateVolume : 0));
			}
		}

		// Token: 0x17003F50 RID: 16208
		// (get) Token: 0x060102BE RID: 66238 RVA: 0x0017D4C8 File Offset: 0x0017B6C8
		// (set) Token: 0x060102BF RID: 66239 RVA: 0x0017D4E1 File Offset: 0x0017B6E1
		public unsafe bool bModulatePitch
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USoundNodeOscillator.__PropertyOffset_bModulatePitch) & USoundNodeOscillator.__PropertyMask_bModulatePitch) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USoundNodeOscillator.__PropertyOffset_bModulatePitch) = ((*(base.NativePtr + (IntPtr)USoundNodeOscillator.__PropertyOffset_bModulatePitch) & ~USoundNodeOscillator.__PropertyMask_bModulatePitch) | (value ? USoundNodeOscillator.__PropertyMask_bModulatePitch : 0));
			}
		}

		// Token: 0x17003F51 RID: 16209
		// (get) Token: 0x060102C0 RID: 66240 RVA: 0x0017D511 File Offset: 0x0017B711
		// (set) Token: 0x060102C1 RID: 66241 RVA: 0x0017D521 File Offset: 0x0017B721
		public unsafe float AmplitudeMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USoundNodeOscillator.__PropertyOffset_AmplitudeMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USoundNodeOscillator.__PropertyOffset_AmplitudeMin) = value;
			}
		}

		// Token: 0x17003F52 RID: 16210
		// (get) Token: 0x060102C2 RID: 66242 RVA: 0x0017D532 File Offset: 0x0017B732
		// (set) Token: 0x060102C3 RID: 66243 RVA: 0x0017D542 File Offset: 0x0017B742
		public unsafe float AmplitudeMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USoundNodeOscillator.__PropertyOffset_AmplitudeMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USoundNodeOscillator.__PropertyOffset_AmplitudeMax) = value;
			}
		}

		// Token: 0x17003F53 RID: 16211
		// (get) Token: 0x060102C4 RID: 66244 RVA: 0x0017D553 File Offset: 0x0017B753
		// (set) Token: 0x060102C5 RID: 66245 RVA: 0x0017D563 File Offset: 0x0017B763
		public unsafe float FrequencyMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USoundNodeOscillator.__PropertyOffset_FrequencyMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USoundNodeOscillator.__PropertyOffset_FrequencyMin) = value;
			}
		}

		// Token: 0x17003F54 RID: 16212
		// (get) Token: 0x060102C6 RID: 66246 RVA: 0x0017D574 File Offset: 0x0017B774
		// (set) Token: 0x060102C7 RID: 66247 RVA: 0x0017D584 File Offset: 0x0017B784
		public unsafe float FrequencyMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USoundNodeOscillator.__PropertyOffset_FrequencyMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USoundNodeOscillator.__PropertyOffset_FrequencyMax) = value;
			}
		}

		// Token: 0x17003F55 RID: 16213
		// (get) Token: 0x060102C8 RID: 66248 RVA: 0x0017D595 File Offset: 0x0017B795
		// (set) Token: 0x060102C9 RID: 66249 RVA: 0x0017D5A5 File Offset: 0x0017B7A5
		public unsafe float OffsetMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USoundNodeOscillator.__PropertyOffset_OffsetMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USoundNodeOscillator.__PropertyOffset_OffsetMin) = value;
			}
		}

		// Token: 0x17003F56 RID: 16214
		// (get) Token: 0x060102CA RID: 66250 RVA: 0x0017D5B6 File Offset: 0x0017B7B6
		// (set) Token: 0x060102CB RID: 66251 RVA: 0x0017D5C6 File Offset: 0x0017B7C6
		public unsafe float OffsetMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USoundNodeOscillator.__PropertyOffset_OffsetMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USoundNodeOscillator.__PropertyOffset_OffsetMax) = value;
			}
		}

		// Token: 0x17003F57 RID: 16215
		// (get) Token: 0x060102CC RID: 66252 RVA: 0x0017D5D7 File Offset: 0x0017B7D7
		// (set) Token: 0x060102CD RID: 66253 RVA: 0x0017D5E7 File Offset: 0x0017B7E7
		public unsafe float CenterMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USoundNodeOscillator.__PropertyOffset_CenterMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USoundNodeOscillator.__PropertyOffset_CenterMin) = value;
			}
		}

		// Token: 0x17003F58 RID: 16216
		// (get) Token: 0x060102CE RID: 66254 RVA: 0x0017D5F8 File Offset: 0x0017B7F8
		// (set) Token: 0x060102CF RID: 66255 RVA: 0x0017D608 File Offset: 0x0017B808
		public unsafe float CenterMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USoundNodeOscillator.__PropertyOffset_CenterMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USoundNodeOscillator.__PropertyOffset_CenterMax) = value;
			}
		}

		// Token: 0x060102D0 RID: 66256 RVA: 0x0017D619 File Offset: 0x0017B819
		static USoundNodeOscillator()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SoundNodeOscillator");
		}

		// Token: 0x060102D1 RID: 66257 RVA: 0x0017D627 File Offset: 0x0017B827
		protected USoundNodeOscillator(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008B34 RID: 35636
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SoundNodeOscillator";

		// Token: 0x04008B35 RID: 35637
		private static IntPtr _ClassPtr;

		// Token: 0x04008B36 RID: 35638
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008B37 RID: 35639
		internal static int __PropertyOffset_bModulateVolume;

		// Token: 0x04008B38 RID: 35640
		internal static byte __PropertyMask_bModulateVolume;

		// Token: 0x04008B39 RID: 35641
		internal static int __PropertyOffset_bModulatePitch;

		// Token: 0x04008B3A RID: 35642
		internal static byte __PropertyMask_bModulatePitch;

		// Token: 0x04008B3B RID: 35643
		internal static int __PropertyOffset_AmplitudeMin;

		// Token: 0x04008B3C RID: 35644
		internal static int __PropertyOffset_AmplitudeMax;

		// Token: 0x04008B3D RID: 35645
		internal static int __PropertyOffset_FrequencyMin;

		// Token: 0x04008B3E RID: 35646
		internal static int __PropertyOffset_FrequencyMax;

		// Token: 0x04008B3F RID: 35647
		internal static int __PropertyOffset_OffsetMin;

		// Token: 0x04008B40 RID: 35648
		internal static int __PropertyOffset_OffsetMax;

		// Token: 0x04008B41 RID: 35649
		internal static int __PropertyOffset_CenterMin;

		// Token: 0x04008B42 RID: 35650
		internal static int __PropertyOffset_CenterMax;
	}
}
