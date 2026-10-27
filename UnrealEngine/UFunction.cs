using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200072C RID: 1836
	[UnrealObjectPath("/Script/CoreUObject.Function")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class UFunction : UStruct, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006201 RID: 25089 RVA: 0x0008C837 File Offset: 0x0008AA37
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UFunction._ClassPtr;
		}

		// Token: 0x06006202 RID: 25090 RVA: 0x0008C844 File Offset: 0x0008AA44
		public UFunction() : this(BuiltinUtils.AllocNativeUObject(UFunction.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006203 RID: 25091 RVA: 0x0008C86C File Offset: 0x0008AA6C
		[NullableContext(1)]
		public UFunction(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UFunction.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06006204 RID: 25092 RVA: 0x0008C89F File Offset: 0x0008AA9F
		static UFunction()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.Function");
		}

		// Token: 0x06006205 RID: 25093 RVA: 0x0008C8AD File Offset: 0x0008AAAD
		protected UFunction(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002EC9 RID: 11977
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.Function";

		// Token: 0x04002ECA RID: 11978
		private static IntPtr _ClassPtr;

		// Token: 0x04002ECB RID: 11979
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
