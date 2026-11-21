using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000131 RID: 305
	[UnrealObjectPath("/Script/CoreUObject.MulticastInlineDelegateProperty")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UMulticastInlineDelegateProperty : UMulticastDelegateProperty, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001249 RID: 4681 RVA: 0x0001CF16 File Offset: 0x0001B116
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMulticastInlineDelegateProperty._ClassPtr;
		}

		// Token: 0x0600124A RID: 4682 RVA: 0x0001CF24 File Offset: 0x0001B124
		public UMulticastInlineDelegateProperty() : this(BuiltinUtils.AllocNativeUObject(UMulticastInlineDelegateProperty.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600124B RID: 4683 RVA: 0x0001CF4C File Offset: 0x0001B14C
		[NullableContext(1)]
		public UMulticastInlineDelegateProperty(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMulticastInlineDelegateProperty.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600124C RID: 4684 RVA: 0x0001CF7F File Offset: 0x0001B17F
		static UMulticastInlineDelegateProperty()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.MulticastInlineDelegateProperty");
		}

		// Token: 0x0600124D RID: 4685 RVA: 0x0001CF8D File Offset: 0x0001B18D
		protected UMulticastInlineDelegateProperty(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400058E RID: 1422
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.MulticastInlineDelegateProperty";

		// Token: 0x0400058F RID: 1423
		private static IntPtr _ClassPtr;

		// Token: 0x04000590 RID: 1424
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
