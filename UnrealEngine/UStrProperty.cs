using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200014C RID: 332
	[UnrealObjectPath("/Script/CoreUObject.StrProperty")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UStrProperty : UProperty, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060012FC RID: 4860 RVA: 0x0001DFCA File Offset: 0x0001C1CA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UStrProperty._ClassPtr;
		}

		// Token: 0x060012FD RID: 4861 RVA: 0x0001DFD8 File Offset: 0x0001C1D8
		public UStrProperty() : this(BuiltinUtils.AllocNativeUObject(UStrProperty.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060012FE RID: 4862 RVA: 0x0001E000 File Offset: 0x0001C200
		[NullableContext(1)]
		public UStrProperty(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UStrProperty.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060012FF RID: 4863 RVA: 0x0001E033 File Offset: 0x0001C233
		static UStrProperty()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.StrProperty");
		}

		// Token: 0x06001300 RID: 4864 RVA: 0x0001E041 File Offset: 0x0001C241
		protected UStrProperty(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040005F8 RID: 1528
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.StrProperty";

		// Token: 0x040005F9 RID: 1529
		private static IntPtr _ClassPtr;

		// Token: 0x040005FA RID: 1530
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
