using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200076E RID: 1902
	[UnrealObjectPath("/Script/CoreUObject.UInt16Property")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UUInt16Property : UNumericProperty, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060063D7 RID: 25559 RVA: 0x0008F586 File Offset: 0x0008D786
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUInt16Property._ClassPtr;
		}

		// Token: 0x060063D8 RID: 25560 RVA: 0x0008F594 File Offset: 0x0008D794
		public UUInt16Property() : this(BuiltinUtils.AllocNativeUObject(UUInt16Property.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060063D9 RID: 25561 RVA: 0x0008F5BC File Offset: 0x0008D7BC
		[NullableContext(1)]
		public UUInt16Property(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUInt16Property.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060063DA RID: 25562 RVA: 0x0008F5EF File Offset: 0x0008D7EF
		static UUInt16Property()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.UInt16Property");
		}

		// Token: 0x060063DB RID: 25563 RVA: 0x0008F5FD File Offset: 0x0008D7FD
		protected UUInt16Property(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002FDE RID: 12254
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.UInt16Property";

		// Token: 0x04002FDF RID: 12255
		private static IntPtr _ClassPtr;

		// Token: 0x04002FE0 RID: 12256
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
