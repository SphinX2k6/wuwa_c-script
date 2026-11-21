using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000145 RID: 325
	[UnrealObjectPath("/Script/CoreUObject.PropertyWrapper")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UPropertyWrapper : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060012D3 RID: 4819 RVA: 0x0001DBD9 File Offset: 0x0001BDD9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPropertyWrapper._ClassPtr;
		}

		// Token: 0x060012D4 RID: 4820 RVA: 0x0001DBE8 File Offset: 0x0001BDE8
		public UPropertyWrapper() : this(BuiltinUtils.AllocNativeUObject(UPropertyWrapper.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060012D5 RID: 4821 RVA: 0x0001DC10 File Offset: 0x0001BE10
		[NullableContext(1)]
		public UPropertyWrapper(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPropertyWrapper.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060012D6 RID: 4822 RVA: 0x0001DC43 File Offset: 0x0001BE43
		static UPropertyWrapper()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.PropertyWrapper");
		}

		// Token: 0x060012D7 RID: 4823 RVA: 0x0001DC51 File Offset: 0x0001BE51
		protected UPropertyWrapper(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040005E1 RID: 1505
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.PropertyWrapper";

		// Token: 0x040005E2 RID: 1506
		private static IntPtr _ClassPtr;

		// Token: 0x040005E3 RID: 1507
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
