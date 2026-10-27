using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000761 RID: 1889
	[UnrealObjectPath("/Script/CoreUObject.ScriptStruct")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class UScriptStruct : UStruct, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600638B RID: 25483 RVA: 0x0008EE57 File Offset: 0x0008D057
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UScriptStruct._ClassPtr;
		}

		// Token: 0x0600638C RID: 25484 RVA: 0x0008EE64 File Offset: 0x0008D064
		public UScriptStruct() : this(BuiltinUtils.AllocNativeUObject(UScriptStruct.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600638D RID: 25485 RVA: 0x0008EE8C File Offset: 0x0008D08C
		[NullableContext(1)]
		public UScriptStruct(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UScriptStruct.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600638E RID: 25486 RVA: 0x0008EEBF File Offset: 0x0008D0BF
		static UScriptStruct()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.ScriptStruct");
		}

		// Token: 0x0600638F RID: 25487 RVA: 0x0008EECD File Offset: 0x0008D0CD
		protected UScriptStruct(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002FB3 RID: 12211
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.ScriptStruct";

		// Token: 0x04002FB4 RID: 12212
		private static IntPtr _ClassPtr;

		// Token: 0x04002FB5 RID: 12213
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
