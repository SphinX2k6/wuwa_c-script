using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C8B RID: 3211
	[UnrealObjectPath("/Script/Engine.InterpTrackAudioMaster")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 200)]
	public class UInterpTrackAudioMaster : UInterpTrackVectorBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A310 RID: 41744 RVA: 0x000E7A73 File Offset: 0x000E5C73
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInterpTrackAudioMaster._ClassPtr;
		}

		// Token: 0x0600A311 RID: 41745 RVA: 0x000E7A80 File Offset: 0x000E5C80
		public UInterpTrackAudioMaster() : this(BuiltinUtils.AllocNativeUObject(UInterpTrackAudioMaster.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A312 RID: 41746 RVA: 0x000E7AA8 File Offset: 0x000E5CA8
		[NullableContext(1)]
		public UInterpTrackAudioMaster(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInterpTrackAudioMaster.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600A313 RID: 41747 RVA: 0x000E7ADB File Offset: 0x000E5CDB
		static UInterpTrackAudioMaster()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InterpTrackAudioMaster");
		}

		// Token: 0x0600A314 RID: 41748 RVA: 0x000E7AE9 File Offset: 0x000E5CE9
		protected UInterpTrackAudioMaster(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400598E RID: 22926
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.InterpTrackAudioMaster";

		// Token: 0x0400598F RID: 22927
		private static IntPtr _ClassPtr;

		// Token: 0x04005990 RID: 22928
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
