using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200012B RID: 299
	[UnrealObjectPath("/Script/AIModule.BlackboardKeyType_Name")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UBlackboardKeyType_Name : UBlackboardKeyType, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001585 RID: 5509 RVA: 0x0001FA26 File Offset: 0x0001DC26
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBlackboardKeyType_Name._ClassPtr;
		}

		// Token: 0x06001586 RID: 5510 RVA: 0x0001FA34 File Offset: 0x0001DC34
		public UBlackboardKeyType_Name() : this(BuiltinUtils.AllocNativeUObject(UBlackboardKeyType_Name.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001587 RID: 5511 RVA: 0x0001FA5C File Offset: 0x0001DC5C
		[NullableContext(1)]
		public UBlackboardKeyType_Name(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBlackboardKeyType_Name.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06001588 RID: 5512 RVA: 0x0001FA8F File Offset: 0x0001DC8F
		static UBlackboardKeyType_Name()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BlackboardKeyType_Name");
		}

		// Token: 0x06001589 RID: 5513 RVA: 0x0001FA9D File Offset: 0x0001DC9D
		protected UBlackboardKeyType_Name(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000497 RID: 1175
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.BlackboardKeyType_Name";

		// Token: 0x04000498 RID: 1176
		private static IntPtr _ClassPtr;

		// Token: 0x04000499 RID: 1177
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
