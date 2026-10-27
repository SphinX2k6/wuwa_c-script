using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002864 RID: 10340
	[UnrealObjectPath("/Script/SMSystem.ASMAction")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UASMAction : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602654B RID: 157003 RVA: 0x003A3A1D File Offset: 0x003A1C1D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UASMAction._ClassPtr;
		}

		// Token: 0x0602654C RID: 157004 RVA: 0x003A3A29 File Offset: 0x003A1C29
		static UASMAction()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SMSystem.ASMAction");
		}

		// Token: 0x0602654D RID: 157005 RVA: 0x003A3A38 File Offset: 0x003A1C38
		protected UASMAction() : this(BuiltinUtils.AllocNativeUObject(UASMAction.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602654E RID: 157006 RVA: 0x003A3A60 File Offset: 0x003A1C60
		protected UASMAction(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015048 RID: 86088
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SMSystem.ASMAction";

		// Token: 0x04015049 RID: 86089
		private static IntPtr _ClassPtr;

		// Token: 0x0401504A RID: 86090
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
