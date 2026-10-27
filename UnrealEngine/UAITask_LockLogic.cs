using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000116 RID: 278
	[UnrealObjectPath("/Script/AIModule.AITask_LockLogic")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UAITask_LockLogic : UAITask, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600148B RID: 5259 RVA: 0x0001E3F1 File Offset: 0x0001C5F1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAITask_LockLogic._ClassPtr;
		}

		// Token: 0x0600148C RID: 5260 RVA: 0x0001E400 File Offset: 0x0001C600
		public UAITask_LockLogic() : this(BuiltinUtils.AllocNativeUObject(UAITask_LockLogic.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600148D RID: 5261 RVA: 0x0001E428 File Offset: 0x0001C628
		[NullableContext(1)]
		public UAITask_LockLogic(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAITask_LockLogic.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600148E RID: 5262 RVA: 0x0001E45B File Offset: 0x0001C65B
		static UAITask_LockLogic()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.AITask_LockLogic");
		}

		// Token: 0x0600148F RID: 5263 RVA: 0x0001E469 File Offset: 0x0001C669
		protected UAITask_LockLogic(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000428 RID: 1064
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.AITask_LockLogic";

		// Token: 0x04000429 RID: 1065
		private static IntPtr _ClassPtr;

		// Token: 0x0400042A RID: 1066
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
