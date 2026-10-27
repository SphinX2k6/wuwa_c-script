using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000731 RID: 1841
	[UnrealObjectPath("/Script/CoreUObject.Int64Property")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UInt64Property : UNumericProperty, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600621E RID: 25118 RVA: 0x0008CB10 File Offset: 0x0008AD10
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInt64Property._ClassPtr;
		}

		// Token: 0x0600621F RID: 25119 RVA: 0x0008CB1C File Offset: 0x0008AD1C
		public UInt64Property() : this(BuiltinUtils.AllocNativeUObject(UInt64Property.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006220 RID: 25120 RVA: 0x0008CB44 File Offset: 0x0008AD44
		[NullableContext(1)]
		public UInt64Property(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInt64Property.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06006221 RID: 25121 RVA: 0x0008CB77 File Offset: 0x0008AD77
		static UInt64Property()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.Int64Property");
		}

		// Token: 0x06006222 RID: 25122 RVA: 0x0008CB85 File Offset: 0x0008AD85
		protected UInt64Property(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002EDA RID: 11994
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.Int64Property";

		// Token: 0x04002EDB RID: 11995
		private static IntPtr _ClassPtr;

		// Token: 0x04002EDC RID: 11996
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
