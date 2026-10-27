using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C9F RID: 3231
	[UnrealObjectPath("/Script/Engine.InterpTrackInstFade")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UInterpTrackInstFade : UInterpTrackInst, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A3A9 RID: 41897 RVA: 0x000E89FB File Offset: 0x000E6BFB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInterpTrackInstFade._ClassPtr;
		}

		// Token: 0x0600A3AA RID: 41898 RVA: 0x000E8A08 File Offset: 0x000E6C08
		public UInterpTrackInstFade() : this(BuiltinUtils.AllocNativeUObject(UInterpTrackInstFade.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A3AB RID: 41899 RVA: 0x000E8A30 File Offset: 0x000E6C30
		[NullableContext(1)]
		public UInterpTrackInstFade(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInterpTrackInstFade.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600A3AC RID: 41900 RVA: 0x000E8A63 File Offset: 0x000E6C63
		static UInterpTrackInstFade()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InterpTrackInstFade");
		}

		// Token: 0x0600A3AD RID: 41901 RVA: 0x000E8A71 File Offset: 0x000E6C71
		protected UInterpTrackInstFade(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040059F1 RID: 23025
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.InterpTrackInstFade";

		// Token: 0x040059F2 RID: 23026
		private static IntPtr _ClassPtr;

		// Token: 0x040059F3 RID: 23027
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
