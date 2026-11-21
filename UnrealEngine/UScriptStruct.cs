using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000147 RID: 327
	[UnrealObjectPath("/Script/CoreUObject.ScriptStruct")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class UScriptStruct : UStruct, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060012E3 RID: 4835 RVA: 0x0001DD49 File Offset: 0x0001BF49
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UScriptStruct._ClassPtr;
		}

		// Token: 0x060012E4 RID: 4836 RVA: 0x0001DD58 File Offset: 0x0001BF58
		public UScriptStruct() : this(BuiltinUtils.AllocNativeUObject(UScriptStruct.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060012E5 RID: 4837 RVA: 0x0001DD80 File Offset: 0x0001BF80
		[NullableContext(1)]
		public UScriptStruct(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UScriptStruct.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060012E6 RID: 4838 RVA: 0x0001DDB3 File Offset: 0x0001BFB3
		static UScriptStruct()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.ScriptStruct");
		}

		// Token: 0x060012E7 RID: 4839 RVA: 0x0001DDC1 File Offset: 0x0001BFC1
		protected UScriptStruct(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040005E9 RID: 1513
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.ScriptStruct";

		// Token: 0x040005EA RID: 1514
		private static IntPtr _ClassPtr;

		// Token: 0x040005EB RID: 1515
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
