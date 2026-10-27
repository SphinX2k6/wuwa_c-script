using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000125 RID: 293
	[UnrealObjectPath("/Script/AIModule.BlackboardKeyType")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public abstract class UBlackboardKeyType : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001560 RID: 5472 RVA: 0x0001F696 File Offset: 0x0001D896
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBlackboardKeyType._ClassPtr;
		}

		// Token: 0x06001561 RID: 5473 RVA: 0x0001F6A2 File Offset: 0x0001D8A2
		static UBlackboardKeyType()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BlackboardKeyType");
		}

		// Token: 0x06001562 RID: 5474 RVA: 0x0001F6B0 File Offset: 0x0001D8B0
		protected UBlackboardKeyType() : this(BuiltinUtils.AllocNativeUObject(UBlackboardKeyType.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001563 RID: 5475 RVA: 0x0001F6D8 File Offset: 0x0001D8D8
		protected UBlackboardKeyType(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000480 RID: 1152
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.BlackboardKeyType";

		// Token: 0x04000481 RID: 1153
		private static IntPtr _ClassPtr;

		// Token: 0x04000482 RID: 1154
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
