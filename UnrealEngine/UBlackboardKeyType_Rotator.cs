using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200012E RID: 302
	[UnrealObjectPath("/Script/AIModule.BlackboardKeyType_Rotator")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UBlackboardKeyType_Rotator : UBlackboardKeyType, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600159A RID: 5530 RVA: 0x0001FC1F File Offset: 0x0001DE1F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBlackboardKeyType_Rotator._ClassPtr;
		}

		// Token: 0x0600159B RID: 5531 RVA: 0x0001FC2C File Offset: 0x0001DE2C
		public UBlackboardKeyType_Rotator() : this(BuiltinUtils.AllocNativeUObject(UBlackboardKeyType_Rotator.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600159C RID: 5532 RVA: 0x0001FC54 File Offset: 0x0001DE54
		[NullableContext(1)]
		public UBlackboardKeyType_Rotator(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBlackboardKeyType_Rotator.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600159D RID: 5533 RVA: 0x0001FC87 File Offset: 0x0001DE87
		static UBlackboardKeyType_Rotator()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BlackboardKeyType_Rotator");
		}

		// Token: 0x0600159E RID: 5534 RVA: 0x0001FC95 File Offset: 0x0001DE95
		protected UBlackboardKeyType_Rotator(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040004A3 RID: 1187
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.BlackboardKeyType_Rotator";

		// Token: 0x040004A4 RID: 1188
		private static IntPtr _ClassPtr;

		// Token: 0x040004A5 RID: 1189
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
