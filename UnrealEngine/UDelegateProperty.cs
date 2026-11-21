using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000F8 RID: 248
	[UnrealObjectPath("/Script/CoreUObject.DelegateProperty")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UDelegateProperty : UProperty, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060010FE RID: 4350 RVA: 0x0001AF26 File Offset: 0x00019126
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDelegateProperty._ClassPtr;
		}

		// Token: 0x060010FF RID: 4351 RVA: 0x0001AF34 File Offset: 0x00019134
		public UDelegateProperty() : this(BuiltinUtils.AllocNativeUObject(UDelegateProperty.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001100 RID: 4352 RVA: 0x0001AF5C File Offset: 0x0001915C
		[NullableContext(1)]
		public UDelegateProperty(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDelegateProperty.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06001101 RID: 4353 RVA: 0x0001AF8F File Offset: 0x0001918F
		static UDelegateProperty()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.DelegateProperty");
		}

		// Token: 0x06001102 RID: 4354 RVA: 0x0001AF9D File Offset: 0x0001919D
		protected UDelegateProperty(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000433 RID: 1075
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.DelegateProperty";

		// Token: 0x04000434 RID: 1076
		private static IntPtr _ClassPtr;

		// Token: 0x04000435 RID: 1077
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
