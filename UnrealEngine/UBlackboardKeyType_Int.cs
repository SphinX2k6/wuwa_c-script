using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200012A RID: 298
	[UnrealObjectPath("/Script/AIModule.BlackboardKeyType_Int")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UBlackboardKeyType_Int : UBlackboardKeyType, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001580 RID: 5504 RVA: 0x0001F9A6 File Offset: 0x0001DBA6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBlackboardKeyType_Int._ClassPtr;
		}

		// Token: 0x06001581 RID: 5505 RVA: 0x0001F9B4 File Offset: 0x0001DBB4
		public UBlackboardKeyType_Int() : this(BuiltinUtils.AllocNativeUObject(UBlackboardKeyType_Int.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001582 RID: 5506 RVA: 0x0001F9DC File Offset: 0x0001DBDC
		[NullableContext(1)]
		public UBlackboardKeyType_Int(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBlackboardKeyType_Int.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06001583 RID: 5507 RVA: 0x0001FA0F File Offset: 0x0001DC0F
		static UBlackboardKeyType_Int()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BlackboardKeyType_Int");
		}

		// Token: 0x06001584 RID: 5508 RVA: 0x0001FA1D File Offset: 0x0001DC1D
		protected UBlackboardKeyType_Int(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000494 RID: 1172
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.BlackboardKeyType_Int";

		// Token: 0x04000495 RID: 1173
		private static IntPtr _ClassPtr;

		// Token: 0x04000496 RID: 1174
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
