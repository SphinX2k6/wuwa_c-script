using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C97 RID: 3223
	[UnrealObjectPath("/Script/Engine.InterpTrackInst")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UInterpTrackInst : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A377 RID: 41847 RVA: 0x000E854B File Offset: 0x000E674B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInterpTrackInst._ClassPtr;
		}

		// Token: 0x0600A378 RID: 41848 RVA: 0x000E8558 File Offset: 0x000E6758
		public UInterpTrackInst() : this(BuiltinUtils.AllocNativeUObject(UInterpTrackInst.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A379 RID: 41849 RVA: 0x000E8580 File Offset: 0x000E6780
		[NullableContext(1)]
		public UInterpTrackInst(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInterpTrackInst.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600A37A RID: 41850 RVA: 0x000E85B3 File Offset: 0x000E67B3
		static UInterpTrackInst()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InterpTrackInst");
		}

		// Token: 0x0600A37B RID: 41851 RVA: 0x000E85C1 File Offset: 0x000E67C1
		protected UInterpTrackInst(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040059D4 RID: 22996
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.InterpTrackInst";

		// Token: 0x040059D5 RID: 22997
		private static IntPtr _ClassPtr;

		// Token: 0x040059D6 RID: 22998
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
