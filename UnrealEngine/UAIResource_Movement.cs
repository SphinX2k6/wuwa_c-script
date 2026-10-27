using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000FA RID: 250
	[UnrealObjectPath("/Script/AIModule.AIResource_Movement")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UAIResource_Movement : UGameplayTaskResource, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001356 RID: 4950 RVA: 0x0001C8C2 File Offset: 0x0001AAC2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAIResource_Movement._ClassPtr;
		}

		// Token: 0x06001357 RID: 4951 RVA: 0x0001C8D0 File Offset: 0x0001AAD0
		public UAIResource_Movement() : this(BuiltinUtils.AllocNativeUObject(UAIResource_Movement.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001358 RID: 4952 RVA: 0x0001C8F8 File Offset: 0x0001AAF8
		[NullableContext(1)]
		public UAIResource_Movement(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAIResource_Movement.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06001359 RID: 4953 RVA: 0x0001C92B File Offset: 0x0001AB2B
		static UAIResource_Movement()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.AIResource_Movement");
		}

		// Token: 0x0600135A RID: 4954 RVA: 0x0001C939 File Offset: 0x0001AB39
		protected UAIResource_Movement(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000380 RID: 896
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.AIResource_Movement";

		// Token: 0x04000381 RID: 897
		private static IntPtr _ClassPtr;

		// Token: 0x04000382 RID: 898
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
