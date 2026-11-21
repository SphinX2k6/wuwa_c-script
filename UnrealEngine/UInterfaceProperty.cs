using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200011A RID: 282
	[UnrealObjectPath("/Script/CoreUObject.InterfaceProperty")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UInterfaceProperty : UProperty, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600118F RID: 4495 RVA: 0x0001BCAD File Offset: 0x00019EAD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInterfaceProperty._ClassPtr;
		}

		// Token: 0x06001190 RID: 4496 RVA: 0x0001BCBC File Offset: 0x00019EBC
		public UInterfaceProperty() : this(BuiltinUtils.AllocNativeUObject(UInterfaceProperty.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001191 RID: 4497 RVA: 0x0001BCE4 File Offset: 0x00019EE4
		[NullableContext(1)]
		public UInterfaceProperty(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInterfaceProperty.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06001192 RID: 4498 RVA: 0x0001BD17 File Offset: 0x00019F17
		static UInterfaceProperty()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.InterfaceProperty");
		}

		// Token: 0x06001193 RID: 4499 RVA: 0x0001BD25 File Offset: 0x00019F25
		protected UInterfaceProperty(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000519 RID: 1305
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.InterfaceProperty";

		// Token: 0x0400051A RID: 1306
		private static IntPtr _ClassPtr;

		// Token: 0x0400051B RID: 1307
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
