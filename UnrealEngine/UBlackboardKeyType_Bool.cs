using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000126 RID: 294
	[UnrealObjectPath("/Script/AIModule.BlackboardKeyType_Bool")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UBlackboardKeyType_Bool : UBlackboardKeyType, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001564 RID: 5476 RVA: 0x0001F6E1 File Offset: 0x0001D8E1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBlackboardKeyType_Bool._ClassPtr;
		}

		// Token: 0x06001565 RID: 5477 RVA: 0x0001F6F0 File Offset: 0x0001D8F0
		public UBlackboardKeyType_Bool() : this(BuiltinUtils.AllocNativeUObject(UBlackboardKeyType_Bool.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001566 RID: 5478 RVA: 0x0001F718 File Offset: 0x0001D918
		[NullableContext(1)]
		public UBlackboardKeyType_Bool(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBlackboardKeyType_Bool.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06001567 RID: 5479 RVA: 0x0001F74B File Offset: 0x0001D94B
		static UBlackboardKeyType_Bool()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BlackboardKeyType_Bool");
		}

		// Token: 0x06001568 RID: 5480 RVA: 0x0001F759 File Offset: 0x0001D959
		protected UBlackboardKeyType_Bool(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000483 RID: 1155
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.BlackboardKeyType_Bool";

		// Token: 0x04000484 RID: 1156
		private static IntPtr _ClassPtr;

		// Token: 0x04000485 RID: 1157
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
