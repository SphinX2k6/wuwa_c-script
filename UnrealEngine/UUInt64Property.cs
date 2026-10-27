using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000770 RID: 1904
	[UnrealObjectPath("/Script/CoreUObject.UInt64Property")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UUInt64Property : UNumericProperty, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060063E1 RID: 25569 RVA: 0x0008F686 File Offset: 0x0008D886
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUInt64Property._ClassPtr;
		}

		// Token: 0x060063E2 RID: 25570 RVA: 0x0008F694 File Offset: 0x0008D894
		public UUInt64Property() : this(BuiltinUtils.AllocNativeUObject(UUInt64Property.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060063E3 RID: 25571 RVA: 0x0008F6BC File Offset: 0x0008D8BC
		[NullableContext(1)]
		public UUInt64Property(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUInt64Property.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060063E4 RID: 25572 RVA: 0x0008F6EF File Offset: 0x0008D8EF
		static UUInt64Property()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.UInt64Property");
		}

		// Token: 0x060063E5 RID: 25573 RVA: 0x0008F6FD File Offset: 0x0008D8FD
		protected UUInt64Property(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002FE4 RID: 12260
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.UInt64Property";

		// Token: 0x04002FE5 RID: 12261
		private static IntPtr _ClassPtr;

		// Token: 0x04002FE6 RID: 12262
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
