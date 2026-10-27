using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000CA6 RID: 3238
	[UnrealObjectPath("/Script/Engine.InterpTrackInstParticleReplay")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UInterpTrackInstParticleReplay : UInterpTrackInst, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A3E2 RID: 41954 RVA: 0x000E8F7C File Offset: 0x000E717C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInterpTrackInstParticleReplay._ClassPtr;
		}

		// Token: 0x0600A3E3 RID: 41955 RVA: 0x000E8F88 File Offset: 0x000E7188
		public UInterpTrackInstParticleReplay() : this(BuiltinUtils.AllocNativeUObject(UInterpTrackInstParticleReplay.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A3E4 RID: 41956 RVA: 0x000E8FB0 File Offset: 0x000E71B0
		[NullableContext(1)]
		public UInterpTrackInstParticleReplay(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInterpTrackInstParticleReplay.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170026FA RID: 9978
		// (get) Token: 0x0600A3E5 RID: 41957 RVA: 0x000E8FE3 File Offset: 0x000E71E3
		// (set) Token: 0x0600A3E6 RID: 41958 RVA: 0x000E8FF3 File Offset: 0x000E71F3
		public unsafe float LastUpdatePosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInterpTrackInstParticleReplay.__PropertyOffset_LastUpdatePosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInterpTrackInstParticleReplay.__PropertyOffset_LastUpdatePosition) = value;
			}
		}

		// Token: 0x0600A3E7 RID: 41959 RVA: 0x000E9004 File Offset: 0x000E7204
		static UInterpTrackInstParticleReplay()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InterpTrackInstParticleReplay");
		}

		// Token: 0x0600A3E8 RID: 41960 RVA: 0x000E9012 File Offset: 0x000E7212
		protected UInterpTrackInstParticleReplay(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005A14 RID: 23060
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.InterpTrackInstParticleReplay";

		// Token: 0x04005A15 RID: 23061
		private static IntPtr _ClassPtr;

		// Token: 0x04005A16 RID: 23062
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005A17 RID: 23063
		internal static int __PropertyOffset_LastUpdatePosition;
	}
}
