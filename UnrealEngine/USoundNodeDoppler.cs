using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001141 RID: 4417
	[UnrealObjectPath("/Script/Engine.SoundNodeDoppler")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class USoundNodeDoppler : USoundNode, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06010254 RID: 66132 RVA: 0x0017CA7A File Offset: 0x0017AC7A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USoundNodeDoppler._ClassPtr;
		}

		// Token: 0x06010255 RID: 66133 RVA: 0x0017CA88 File Offset: 0x0017AC88
		public USoundNodeDoppler() : this(BuiltinUtils.AllocNativeUObject(USoundNodeDoppler.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010256 RID: 66134 RVA: 0x0017CAB0 File Offset: 0x0017ACB0
		[NullableContext(1)]
		public USoundNodeDoppler(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USoundNodeDoppler.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003F34 RID: 16180
		// (get) Token: 0x06010257 RID: 66135 RVA: 0x0017CAE3 File Offset: 0x0017ACE3
		// (set) Token: 0x06010258 RID: 66136 RVA: 0x0017CAF3 File Offset: 0x0017ACF3
		public unsafe float DopplerIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USoundNodeDoppler.__PropertyOffset_DopplerIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USoundNodeDoppler.__PropertyOffset_DopplerIntensity) = value;
			}
		}

		// Token: 0x17003F35 RID: 16181
		// (get) Token: 0x06010259 RID: 66137 RVA: 0x0017CB04 File Offset: 0x0017AD04
		// (set) Token: 0x0601025A RID: 66138 RVA: 0x0017CB14 File Offset: 0x0017AD14
		public unsafe bool bUseSmoothing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USoundNodeDoppler.__PropertyOffset_bUseSmoothing) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USoundNodeDoppler.__PropertyOffset_bUseSmoothing) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F36 RID: 16182
		// (get) Token: 0x0601025B RID: 66139 RVA: 0x0017CB25 File Offset: 0x0017AD25
		// (set) Token: 0x0601025C RID: 66140 RVA: 0x0017CB35 File Offset: 0x0017AD35
		public unsafe float SmoothingInterpSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USoundNodeDoppler.__PropertyOffset_SmoothingInterpSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USoundNodeDoppler.__PropertyOffset_SmoothingInterpSpeed) = value;
			}
		}

		// Token: 0x0601025D RID: 66141 RVA: 0x0017CB46 File Offset: 0x0017AD46
		static USoundNodeDoppler()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SoundNodeDoppler");
		}

		// Token: 0x0601025E RID: 66142 RVA: 0x0017CB54 File Offset: 0x0017AD54
		protected USoundNodeDoppler(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008AF6 RID: 35574
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SoundNodeDoppler";

		// Token: 0x04008AF7 RID: 35575
		private static IntPtr _ClassPtr;

		// Token: 0x04008AF8 RID: 35576
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008AF9 RID: 35577
		internal static int __PropertyOffset_DopplerIntensity;

		// Token: 0x04008AFA RID: 35578
		internal static int __PropertyOffset_bUseSmoothing;

		// Token: 0x04008AFB RID: 35579
		internal static int __PropertyOffset_SmoothingInterpSpeed;
	}
}
