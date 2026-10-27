using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000CB4 RID: 3252
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.InterpTrackSound")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 224)]
	public class UInterpTrackSound : UInterpTrackVectorBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A46D RID: 42093 RVA: 0x000E9DEA File Offset: 0x000E7FEA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInterpTrackSound._ClassPtr;
		}

		// Token: 0x0600A46E RID: 42094 RVA: 0x000E9DF8 File Offset: 0x000E7FF8
		public UInterpTrackSound() : this(BuiltinUtils.AllocNativeUObject(UInterpTrackSound.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A46F RID: 42095 RVA: 0x000E9E20 File Offset: 0x000E8020
		public UInterpTrackSound(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInterpTrackSound.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700271D RID: 10013
		// (get) Token: 0x0600A470 RID: 42096 RVA: 0x000E9E54 File Offset: 0x000E8054
		// (set) Token: 0x0600A471 RID: 42097 RVA: 0x000E9E8D File Offset: 0x000E808D
		public TArray<FSoundTrackKey> Sounds
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSoundTrackKey> result;
				if ((result = this._Sounds) == null)
				{
					result = (this._Sounds = new TArray<FSoundTrackKey>(base.NativePtr + (IntPtr)UInterpTrackSound.__PropertyOffset_Sounds, this));
				}
				return result;
			}
			set
			{
				this.Sounds.CopyAssign(value);
			}
		}

		// Token: 0x1700271E RID: 10014
		// (get) Token: 0x0600A472 RID: 42098 RVA: 0x000E9E9B File Offset: 0x000E809B
		// (set) Token: 0x0600A473 RID: 42099 RVA: 0x000E9EB4 File Offset: 0x000E80B4
		public unsafe bool bPlayOnReverse
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UInterpTrackSound.__PropertyOffset_bPlayOnReverse) & UInterpTrackSound.__PropertyMask_bPlayOnReverse) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UInterpTrackSound.__PropertyOffset_bPlayOnReverse) = ((*(base.NativePtr + (IntPtr)UInterpTrackSound.__PropertyOffset_bPlayOnReverse) & ~UInterpTrackSound.__PropertyMask_bPlayOnReverse) | (value ? UInterpTrackSound.__PropertyMask_bPlayOnReverse : 0));
			}
		}

		// Token: 0x1700271F RID: 10015
		// (get) Token: 0x0600A474 RID: 42100 RVA: 0x000E9EE4 File Offset: 0x000E80E4
		// (set) Token: 0x0600A475 RID: 42101 RVA: 0x000E9EFD File Offset: 0x000E80FD
		public unsafe bool bContinueSoundOnMatineeEnd
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UInterpTrackSound.__PropertyOffset_bContinueSoundOnMatineeEnd) & UInterpTrackSound.__PropertyMask_bContinueSoundOnMatineeEnd) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UInterpTrackSound.__PropertyOffset_bContinueSoundOnMatineeEnd) = ((*(base.NativePtr + (IntPtr)UInterpTrackSound.__PropertyOffset_bContinueSoundOnMatineeEnd) & ~UInterpTrackSound.__PropertyMask_bContinueSoundOnMatineeEnd) | (value ? UInterpTrackSound.__PropertyMask_bContinueSoundOnMatineeEnd : 0));
			}
		}

		// Token: 0x17002720 RID: 10016
		// (get) Token: 0x0600A476 RID: 42102 RVA: 0x000E9F2D File Offset: 0x000E812D
		// (set) Token: 0x0600A477 RID: 42103 RVA: 0x000E9F46 File Offset: 0x000E8146
		public unsafe bool bSuppressSubtitles
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UInterpTrackSound.__PropertyOffset_bSuppressSubtitles) & UInterpTrackSound.__PropertyMask_bSuppressSubtitles) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UInterpTrackSound.__PropertyOffset_bSuppressSubtitles) = ((*(base.NativePtr + (IntPtr)UInterpTrackSound.__PropertyOffset_bSuppressSubtitles) & ~UInterpTrackSound.__PropertyMask_bSuppressSubtitles) | (value ? UInterpTrackSound.__PropertyMask_bSuppressSubtitles : 0));
			}
		}

		// Token: 0x17002721 RID: 10017
		// (get) Token: 0x0600A478 RID: 42104 RVA: 0x000E9F76 File Offset: 0x000E8176
		// (set) Token: 0x0600A479 RID: 42105 RVA: 0x000E9F8F File Offset: 0x000E818F
		public unsafe bool bTreatAsDialogue
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UInterpTrackSound.__PropertyOffset_bTreatAsDialogue) & UInterpTrackSound.__PropertyMask_bTreatAsDialogue) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UInterpTrackSound.__PropertyOffset_bTreatAsDialogue) = ((*(base.NativePtr + (IntPtr)UInterpTrackSound.__PropertyOffset_bTreatAsDialogue) & ~UInterpTrackSound.__PropertyMask_bTreatAsDialogue) | (value ? UInterpTrackSound.__PropertyMask_bTreatAsDialogue : 0));
			}
		}

		// Token: 0x17002722 RID: 10018
		// (get) Token: 0x0600A47A RID: 42106 RVA: 0x000E9FBF File Offset: 0x000E81BF
		// (set) Token: 0x0600A47B RID: 42107 RVA: 0x000E9FD8 File Offset: 0x000E81D8
		public unsafe bool bAttach
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UInterpTrackSound.__PropertyOffset_bAttach) & UInterpTrackSound.__PropertyMask_bAttach) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UInterpTrackSound.__PropertyOffset_bAttach) = ((*(base.NativePtr + (IntPtr)UInterpTrackSound.__PropertyOffset_bAttach) & ~UInterpTrackSound.__PropertyMask_bAttach) | (value ? UInterpTrackSound.__PropertyMask_bAttach : 0));
			}
		}

		// Token: 0x0600A47C RID: 42108 RVA: 0x000EA008 File Offset: 0x000E8208
		static UInterpTrackSound()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InterpTrackSound");
		}

		// Token: 0x0600A47D RID: 42109 RVA: 0x000EA016 File Offset: 0x000E8216
		protected UInterpTrackSound(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005A71 RID: 23153
		public new const string __ObjectPath = "/Script/Engine.InterpTrackSound";

		// Token: 0x04005A72 RID: 23154
		private static IntPtr _ClassPtr;

		// Token: 0x04005A73 RID: 23155
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005A74 RID: 23156
		internal static int __PropertyOffset_Sounds;

		// Token: 0x04005A75 RID: 23157
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSoundTrackKey> _Sounds;

		// Token: 0x04005A76 RID: 23158
		internal static int __PropertyOffset_bPlayOnReverse;

		// Token: 0x04005A77 RID: 23159
		internal static byte __PropertyMask_bPlayOnReverse;

		// Token: 0x04005A78 RID: 23160
		internal static int __PropertyOffset_bContinueSoundOnMatineeEnd;

		// Token: 0x04005A79 RID: 23161
		internal static byte __PropertyMask_bContinueSoundOnMatineeEnd;

		// Token: 0x04005A7A RID: 23162
		internal static int __PropertyOffset_bSuppressSubtitles;

		// Token: 0x04005A7B RID: 23163
		internal static byte __PropertyMask_bSuppressSubtitles;

		// Token: 0x04005A7C RID: 23164
		internal static int __PropertyOffset_bTreatAsDialogue;

		// Token: 0x04005A7D RID: 23165
		internal static byte __PropertyMask_bTreatAsDialogue;

		// Token: 0x04005A7E RID: 23166
		internal static int __PropertyOffset_bAttach;

		// Token: 0x04005A7F RID: 23167
		internal static byte __PropertyMask_bAttach;
	}
}
