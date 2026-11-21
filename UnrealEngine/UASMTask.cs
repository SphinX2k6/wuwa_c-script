using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000825 RID: 2085
	[UnrealObjectPath("/Script/SMSystem.ASMTask")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UASMTask : UASMConfigBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B616 RID: 46614 RVA: 0x00121A51 File Offset: 0x0011FC51
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UASMTask._ClassPtr;
		}

		// Token: 0x0600B617 RID: 46615 RVA: 0x00121A5D File Offset: 0x0011FC5D
		static UASMTask()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SMSystem.ASMTask");
		}

		// Token: 0x0600B618 RID: 46616 RVA: 0x00121A6C File Offset: 0x0011FC6C
		protected UASMTask() : this(BuiltinUtils.AllocNativeUObject(UASMTask.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B619 RID: 46617 RVA: 0x00121A94 File Offset: 0x0011FC94
		protected UASMTask(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400524C RID: 21068
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SMSystem.ASMTask";

		// Token: 0x0400524D RID: 21069
		private static IntPtr _ClassPtr;

		// Token: 0x0400524E RID: 21070
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
