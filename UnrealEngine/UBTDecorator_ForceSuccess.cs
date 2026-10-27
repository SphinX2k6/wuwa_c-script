using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000143 RID: 323
	[UnrealObjectPath("/Script/AIModule.BTDecorator_ForceSuccess")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UBTDecorator_ForceSuccess : UBTDecorator, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001687 RID: 5767 RVA: 0x00021290 File Offset: 0x0001F490
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTDecorator_ForceSuccess._ClassPtr;
		}

		// Token: 0x06001688 RID: 5768 RVA: 0x0002129C File Offset: 0x0001F49C
		public UBTDecorator_ForceSuccess() : this(BuiltinUtils.AllocNativeUObject(UBTDecorator_ForceSuccess.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001689 RID: 5769 RVA: 0x000212C4 File Offset: 0x0001F4C4
		[NullableContext(1)]
		public UBTDecorator_ForceSuccess(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBTDecorator_ForceSuccess.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600168A RID: 5770 RVA: 0x000212F7 File Offset: 0x0001F4F7
		static UBTDecorator_ForceSuccess()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BTDecorator_ForceSuccess");
		}

		// Token: 0x0600168B RID: 5771 RVA: 0x00021305 File Offset: 0x0001F505
		protected UBTDecorator_ForceSuccess(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000525 RID: 1317
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.BTDecorator_ForceSuccess";

		// Token: 0x04000526 RID: 1318
		private static IntPtr _ClassPtr;

		// Token: 0x04000527 RID: 1319
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
