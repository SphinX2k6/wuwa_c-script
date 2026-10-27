using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002869 RID: 10345
	[UnrealObjectPath("/Script/SMSystem.ASMTask")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UASMTask : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026567 RID: 157031 RVA: 0x003A3CB6 File Offset: 0x003A1EB6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UASMTask._ClassPtr;
		}

		// Token: 0x06026568 RID: 157032 RVA: 0x003A3CC2 File Offset: 0x003A1EC2
		static UASMTask()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SMSystem.ASMTask");
		}

		// Token: 0x06026569 RID: 157033 RVA: 0x003A3CD0 File Offset: 0x003A1ED0
		protected UASMTask() : this(BuiltinUtils.AllocNativeUObject(UASMTask.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602656A RID: 157034 RVA: 0x003A3CF8 File Offset: 0x003A1EF8
		protected UASMTask(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401505C RID: 86108
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SMSystem.ASMTask";

		// Token: 0x0401505D RID: 86109
		private static IntPtr _ClassPtr;

		// Token: 0x0401505E RID: 86110
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
