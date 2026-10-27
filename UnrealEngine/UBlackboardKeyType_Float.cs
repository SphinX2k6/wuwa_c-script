using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000129 RID: 297
	[UnrealObjectPath("/Script/AIModule.BlackboardKeyType_Float")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UBlackboardKeyType_Float : UBlackboardKeyType, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600157B RID: 5499 RVA: 0x0001F925 File Offset: 0x0001DB25
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBlackboardKeyType_Float._ClassPtr;
		}

		// Token: 0x0600157C RID: 5500 RVA: 0x0001F934 File Offset: 0x0001DB34
		public UBlackboardKeyType_Float() : this(BuiltinUtils.AllocNativeUObject(UBlackboardKeyType_Float.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600157D RID: 5501 RVA: 0x0001F95C File Offset: 0x0001DB5C
		[NullableContext(1)]
		public UBlackboardKeyType_Float(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBlackboardKeyType_Float.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600157E RID: 5502 RVA: 0x0001F98F File Offset: 0x0001DB8F
		static UBlackboardKeyType_Float()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BlackboardKeyType_Float");
		}

		// Token: 0x0600157F RID: 5503 RVA: 0x0001F99D File Offset: 0x0001DB9D
		protected UBlackboardKeyType_Float(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000491 RID: 1169
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.BlackboardKeyType_Float";

		// Token: 0x04000492 RID: 1170
		private static IntPtr _ClassPtr;

		// Token: 0x04000493 RID: 1171
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
