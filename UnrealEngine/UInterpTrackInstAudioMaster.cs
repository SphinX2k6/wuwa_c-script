using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C99 RID: 3225
	[UnrealObjectPath("/Script/Engine.InterpTrackInstAudioMaster")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UInterpTrackInstAudioMaster : UInterpTrackInst, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A383 RID: 41859 RVA: 0x000E866B File Offset: 0x000E686B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInterpTrackInstAudioMaster._ClassPtr;
		}

		// Token: 0x0600A384 RID: 41860 RVA: 0x000E8678 File Offset: 0x000E6878
		public UInterpTrackInstAudioMaster() : this(BuiltinUtils.AllocNativeUObject(UInterpTrackInstAudioMaster.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A385 RID: 41861 RVA: 0x000E86A0 File Offset: 0x000E68A0
		[NullableContext(1)]
		public UInterpTrackInstAudioMaster(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInterpTrackInstAudioMaster.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600A386 RID: 41862 RVA: 0x000E86D3 File Offset: 0x000E68D3
		static UInterpTrackInstAudioMaster()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InterpTrackInstAudioMaster");
		}

		// Token: 0x0600A387 RID: 41863 RVA: 0x000E86E1 File Offset: 0x000E68E1
		protected UInterpTrackInstAudioMaster(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040059DB RID: 23003
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.InterpTrackInstAudioMaster";

		// Token: 0x040059DC RID: 23004
		private static IntPtr _ClassPtr;

		// Token: 0x040059DD RID: 23005
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
