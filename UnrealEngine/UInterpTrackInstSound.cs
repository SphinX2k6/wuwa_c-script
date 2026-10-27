using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000CA9 RID: 3241
	[UnrealObjectPath("/Script/Engine.InterpTrackInstSound")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UInterpTrackInstSound : UInterpTrackInst, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A3F9 RID: 41977 RVA: 0x000E9183 File Offset: 0x000E7383
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInterpTrackInstSound._ClassPtr;
		}

		// Token: 0x0600A3FA RID: 41978 RVA: 0x000E9190 File Offset: 0x000E7390
		public UInterpTrackInstSound() : this(BuiltinUtils.AllocNativeUObject(UInterpTrackInstSound.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A3FB RID: 41979 RVA: 0x000E91B8 File Offset: 0x000E73B8
		[NullableContext(1)]
		public UInterpTrackInstSound(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInterpTrackInstSound.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170026FE RID: 9982
		// (get) Token: 0x0600A3FC RID: 41980 RVA: 0x000E91EB File Offset: 0x000E73EB
		// (set) Token: 0x0600A3FD RID: 41981 RVA: 0x000E91FB File Offset: 0x000E73FB
		public unsafe float LastUpdatePosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInterpTrackInstSound.__PropertyOffset_LastUpdatePosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInterpTrackInstSound.__PropertyOffset_LastUpdatePosition) = value;
			}
		}

		// Token: 0x170026FF RID: 9983
		// (get) Token: 0x0600A3FE RID: 41982 RVA: 0x000E920C File Offset: 0x000E740C
		// (set) Token: 0x0600A3FF RID: 41983 RVA: 0x000E9220 File Offset: 0x000E7420
		[Nullable(2)]
		public unsafe UAudioComponent PlayAudioComp
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAudioComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UInterpTrackInstSound.__PropertyOffset_PlayAudioComp);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UInterpTrackInstSound.__PropertyOffset_PlayAudioComp, value);
			}
		}

		// Token: 0x0600A400 RID: 41984 RVA: 0x000E9235 File Offset: 0x000E7435
		static UInterpTrackInstSound()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InterpTrackInstSound");
		}

		// Token: 0x0600A401 RID: 41985 RVA: 0x000E9243 File Offset: 0x000E7443
		protected UInterpTrackInstSound(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005A21 RID: 23073
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.InterpTrackInstSound";

		// Token: 0x04005A22 RID: 23074
		private static IntPtr _ClassPtr;

		// Token: 0x04005A23 RID: 23075
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005A24 RID: 23076
		internal static int __PropertyOffset_LastUpdatePosition;

		// Token: 0x04005A25 RID: 23077
		internal static int __PropertyOffset_PlayAudioComp;
	}
}
