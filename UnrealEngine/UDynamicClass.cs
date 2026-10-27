using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200070F RID: 1807
	[UnrealObjectPath("/Script/CoreUObject.DynamicClass")]
	[UnrealStructLayout(760, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 760)]
	public class UDynamicClass : UClass, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060061A1 RID: 24993 RVA: 0x0008BF8A File Offset: 0x0008A18A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDynamicClass._ClassPtr;
		}

		// Token: 0x060061A2 RID: 24994 RVA: 0x0008BF98 File Offset: 0x0008A198
		public UDynamicClass() : this(BuiltinUtils.AllocNativeUObject(UDynamicClass.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060061A3 RID: 24995 RVA: 0x0008BFC0 File Offset: 0x0008A1C0
		[NullableContext(1)]
		public UDynamicClass(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDynamicClass.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060061A4 RID: 24996 RVA: 0x0008BFF3 File Offset: 0x0008A1F3
		static UDynamicClass()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.DynamicClass");
		}

		// Token: 0x060061A5 RID: 24997 RVA: 0x0008C001 File Offset: 0x0008A201
		protected UDynamicClass(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002DAA RID: 11690
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.DynamicClass";

		// Token: 0x04002DAB RID: 11691
		private static IntPtr _ClassPtr;

		// Token: 0x04002DAC RID: 11692
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
