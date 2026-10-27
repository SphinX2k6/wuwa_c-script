using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002865 RID: 10341
	[UnrealObjectPath("/Script/SMSystem.ASMBindState")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UASMBindState : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602654F RID: 157007 RVA: 0x003A3A69 File Offset: 0x003A1C69
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UASMBindState._ClassPtr;
		}

		// Token: 0x06026550 RID: 157008 RVA: 0x003A3A75 File Offset: 0x003A1C75
		static UASMBindState()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SMSystem.ASMBindState");
		}

		// Token: 0x06026551 RID: 157009 RVA: 0x003A3A84 File Offset: 0x003A1C84
		protected UASMBindState() : this(BuiltinUtils.AllocNativeUObject(UASMBindState.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026552 RID: 157010 RVA: 0x003A3AAC File Offset: 0x003A1CAC
		protected UASMBindState(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401504B RID: 86091
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SMSystem.ASMBindState";

		// Token: 0x0401504C RID: 86092
		private static IntPtr _ClassPtr;

		// Token: 0x0401504D RID: 86093
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
