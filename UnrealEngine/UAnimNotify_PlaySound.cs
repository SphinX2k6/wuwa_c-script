using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000831 RID: 2097
	[UnrealObjectPath("/Script/Engine.AnimNotify_PlaySound")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UAnimNotify_PlaySound : UAnimNotify, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060070E7 RID: 28903 RVA: 0x000A1DD4 File Offset: 0x0009FFD4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnimNotify_PlaySound._ClassPtr;
		}

		// Token: 0x060070E8 RID: 28904 RVA: 0x000A1DE0 File Offset: 0x0009FFE0
		public UAnimNotify_PlaySound() : this(BuiltinUtils.AllocNativeUObject(UAnimNotify_PlaySound.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060070E9 RID: 28905 RVA: 0x000A1E08 File Offset: 0x000A0008
		[NullableContext(1)]
		public UAnimNotify_PlaySound(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAnimNotify_PlaySound.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001A92 RID: 6802
		// (get) Token: 0x060070EA RID: 28906 RVA: 0x000A1E3B File Offset: 0x000A003B
		// (set) Token: 0x060070EB RID: 28907 RVA: 0x000A1E4F File Offset: 0x000A004F
		[Nullable(2)]
		public unsafe USoundBase Sound
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USoundBase>(base.NativePtr / (IntPtr)sizeof(void*) + UAnimNotify_PlaySound.__PropertyOffset_Sound);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAnimNotify_PlaySound.__PropertyOffset_Sound, value);
			}
		}

		// Token: 0x17001A93 RID: 6803
		// (get) Token: 0x060070EC RID: 28908 RVA: 0x000A1E64 File Offset: 0x000A0064
		// (set) Token: 0x060070ED RID: 28909 RVA: 0x000A1E74 File Offset: 0x000A0074
		public unsafe float VolumeMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimNotify_PlaySound.__PropertyOffset_VolumeMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimNotify_PlaySound.__PropertyOffset_VolumeMultiplier) = value;
			}
		}

		// Token: 0x17001A94 RID: 6804
		// (get) Token: 0x060070EE RID: 28910 RVA: 0x000A1E85 File Offset: 0x000A0085
		// (set) Token: 0x060070EF RID: 28911 RVA: 0x000A1E95 File Offset: 0x000A0095
		public unsafe float PitchMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimNotify_PlaySound.__PropertyOffset_PitchMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimNotify_PlaySound.__PropertyOffset_PitchMultiplier) = value;
			}
		}

		// Token: 0x17001A95 RID: 6805
		// (get) Token: 0x060070F0 RID: 28912 RVA: 0x000A1EA6 File Offset: 0x000A00A6
		// (set) Token: 0x060070F1 RID: 28913 RVA: 0x000A1EBF File Offset: 0x000A00BF
		public unsafe bool bFollow
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UAnimNotify_PlaySound.__PropertyOffset_bFollow) & UAnimNotify_PlaySound.__PropertyMask_bFollow) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UAnimNotify_PlaySound.__PropertyOffset_bFollow) = ((*(base.NativePtr + (IntPtr)UAnimNotify_PlaySound.__PropertyOffset_bFollow) & ~UAnimNotify_PlaySound.__PropertyMask_bFollow) | (value ? UAnimNotify_PlaySound.__PropertyMask_bFollow : 0));
			}
		}

		// Token: 0x17001A96 RID: 6806
		// (get) Token: 0x060070F2 RID: 28914 RVA: 0x000A1EEF File Offset: 0x000A00EF
		// (set) Token: 0x060070F3 RID: 28915 RVA: 0x000A1F03 File Offset: 0x000A0103
		public unsafe FName AttachName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimNotify_PlaySound.__PropertyOffset_AttachName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimNotify_PlaySound.__PropertyOffset_AttachName) = value;
			}
		}

		// Token: 0x060070F4 RID: 28916 RVA: 0x000A1F18 File Offset: 0x000A0118
		static UAnimNotify_PlaySound()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AnimNotify_PlaySound");
		}

		// Token: 0x060070F5 RID: 28917 RVA: 0x000A1F26 File Offset: 0x000A0126
		protected UAnimNotify_PlaySound(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003632 RID: 13874
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.AnimNotify_PlaySound";

		// Token: 0x04003633 RID: 13875
		private static IntPtr _ClassPtr;

		// Token: 0x04003634 RID: 13876
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003635 RID: 13877
		internal static int __PropertyOffset_Sound;

		// Token: 0x04003636 RID: 13878
		internal static int __PropertyOffset_VolumeMultiplier;

		// Token: 0x04003637 RID: 13879
		internal static int __PropertyOffset_PitchMultiplier;

		// Token: 0x04003638 RID: 13880
		internal static int __PropertyOffset_bFollow;

		// Token: 0x04003639 RID: 13881
		internal static byte __PropertyMask_bFollow;

		// Token: 0x0400363A RID: 13882
		internal static int __PropertyOffset_AttachName;
	}
}
