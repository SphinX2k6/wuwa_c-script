using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200012F RID: 303
	[UnrealObjectPath("/Script/CoreUObject.MulticastDelegateProperty")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public abstract class UMulticastDelegateProperty : UProperty, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001240 RID: 4672 RVA: 0x0001CE4A File Offset: 0x0001B04A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMulticastDelegateProperty._ClassPtr;
		}

		// Token: 0x06001241 RID: 4673 RVA: 0x0001CE56 File Offset: 0x0001B056
		static UMulticastDelegateProperty()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.MulticastDelegateProperty");
		}

		// Token: 0x06001242 RID: 4674 RVA: 0x0001CE64 File Offset: 0x0001B064
		protected UMulticastDelegateProperty() : this(BuiltinUtils.AllocNativeUObject(UMulticastDelegateProperty.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001243 RID: 4675 RVA: 0x0001CE8C File Offset: 0x0001B08C
		protected UMulticastDelegateProperty(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000588 RID: 1416
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.MulticastDelegateProperty";

		// Token: 0x04000589 RID: 1417
		private static IntPtr _ClassPtr;

		// Token: 0x0400058A RID: 1418
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
