using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000133 RID: 307
	[UnrealObjectPath("/Script/CoreUObject.MulticastSparseDelegateProperty")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UMulticastSparseDelegateProperty : UMulticastDelegateProperty, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001253 RID: 4691 RVA: 0x0001D016 File Offset: 0x0001B216
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMulticastSparseDelegateProperty._ClassPtr;
		}

		// Token: 0x06001254 RID: 4692 RVA: 0x0001D024 File Offset: 0x0001B224
		public UMulticastSparseDelegateProperty() : this(BuiltinUtils.AllocNativeUObject(UMulticastSparseDelegateProperty.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001255 RID: 4693 RVA: 0x0001D04C File Offset: 0x0001B24C
		[NullableContext(1)]
		public UMulticastSparseDelegateProperty(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMulticastSparseDelegateProperty.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06001256 RID: 4694 RVA: 0x0001D07F File Offset: 0x0001B27F
		static UMulticastSparseDelegateProperty()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.MulticastSparseDelegateProperty");
		}

		// Token: 0x06001257 RID: 4695 RVA: 0x0001D08D File Offset: 0x0001B28D
		protected UMulticastSparseDelegateProperty(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000594 RID: 1428
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.MulticastSparseDelegateProperty";

		// Token: 0x04000595 RID: 1429
		private static IntPtr _ClassPtr;

		// Token: 0x04000596 RID: 1430
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
