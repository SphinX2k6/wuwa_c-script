using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001148 RID: 4424
	[UnrealObjectPath("/Script/Engine.SoundNodeModulator")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class USoundNodeModulator : USoundNode, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060102A3 RID: 66211 RVA: 0x0017D1DA File Offset: 0x0017B3DA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USoundNodeModulator._ClassPtr;
		}

		// Token: 0x060102A4 RID: 66212 RVA: 0x0017D1E8 File Offset: 0x0017B3E8
		public USoundNodeModulator() : this(BuiltinUtils.AllocNativeUObject(USoundNodeModulator.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060102A5 RID: 66213 RVA: 0x0017D210 File Offset: 0x0017B410
		[NullableContext(1)]
		public USoundNodeModulator(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USoundNodeModulator.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003F49 RID: 16201
		// (get) Token: 0x060102A6 RID: 66214 RVA: 0x0017D243 File Offset: 0x0017B443
		// (set) Token: 0x060102A7 RID: 66215 RVA: 0x0017D253 File Offset: 0x0017B453
		public unsafe float PitchMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USoundNodeModulator.__PropertyOffset_PitchMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USoundNodeModulator.__PropertyOffset_PitchMin) = value;
			}
		}

		// Token: 0x17003F4A RID: 16202
		// (get) Token: 0x060102A8 RID: 66216 RVA: 0x0017D264 File Offset: 0x0017B464
		// (set) Token: 0x060102A9 RID: 66217 RVA: 0x0017D274 File Offset: 0x0017B474
		public unsafe float PitchMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USoundNodeModulator.__PropertyOffset_PitchMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USoundNodeModulator.__PropertyOffset_PitchMax) = value;
			}
		}

		// Token: 0x17003F4B RID: 16203
		// (get) Token: 0x060102AA RID: 66218 RVA: 0x0017D285 File Offset: 0x0017B485
		// (set) Token: 0x060102AB RID: 66219 RVA: 0x0017D295 File Offset: 0x0017B495
		public unsafe float VolumeMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USoundNodeModulator.__PropertyOffset_VolumeMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USoundNodeModulator.__PropertyOffset_VolumeMin) = value;
			}
		}

		// Token: 0x17003F4C RID: 16204
		// (get) Token: 0x060102AC RID: 66220 RVA: 0x0017D2A6 File Offset: 0x0017B4A6
		// (set) Token: 0x060102AD RID: 66221 RVA: 0x0017D2B6 File Offset: 0x0017B4B6
		public unsafe float VolumeMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USoundNodeModulator.__PropertyOffset_VolumeMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USoundNodeModulator.__PropertyOffset_VolumeMax) = value;
			}
		}

		// Token: 0x060102AE RID: 66222 RVA: 0x0017D2C7 File Offset: 0x0017B4C7
		static USoundNodeModulator()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SoundNodeModulator");
		}

		// Token: 0x060102AF RID: 66223 RVA: 0x0017D2D5 File Offset: 0x0017B4D5
		protected USoundNodeModulator(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008B26 RID: 35622
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SoundNodeModulator";

		// Token: 0x04008B27 RID: 35623
		private static IntPtr _ClassPtr;

		// Token: 0x04008B28 RID: 35624
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008B29 RID: 35625
		internal static int __PropertyOffset_PitchMin;

		// Token: 0x04008B2A RID: 35626
		internal static int __PropertyOffset_PitchMax;

		// Token: 0x04008B2B RID: 35627
		internal static int __PropertyOffset_VolumeMin;

		// Token: 0x04008B2C RID: 35628
		internal static int __PropertyOffset_VolumeMax;
	}
}
