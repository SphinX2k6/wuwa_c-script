using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200071B RID: 1819
	[UnrealObjectPath("/Script/CoreUObject.EnumProperty")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class UEnumProperty : UProperty, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060061AB RID: 25003 RVA: 0x0008C08A File Offset: 0x0008A28A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEnumProperty._ClassPtr;
		}

		// Token: 0x060061AC RID: 25004 RVA: 0x0008C098 File Offset: 0x0008A298
		public UEnumProperty() : this(BuiltinUtils.AllocNativeUObject(UEnumProperty.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060061AD RID: 25005 RVA: 0x0008C0C0 File Offset: 0x0008A2C0
		[NullableContext(1)]
		public UEnumProperty(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEnumProperty.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060061AE RID: 25006 RVA: 0x0008C0F3 File Offset: 0x0008A2F3
		static UEnumProperty()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.EnumProperty");
		}

		// Token: 0x060061AF RID: 25007 RVA: 0x0008C101 File Offset: 0x0008A301
		protected UEnumProperty(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002E0D RID: 11789
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.EnumProperty";

		// Token: 0x04002E0E RID: 11790
		private static IntPtr _ClassPtr;

		// Token: 0x04002E0F RID: 11791
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
