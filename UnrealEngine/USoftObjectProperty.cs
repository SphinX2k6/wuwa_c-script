using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200014A RID: 330
	[UnrealObjectPath("/Script/CoreUObject.SoftObjectProperty")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class USoftObjectProperty : UObjectPropertyBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060012F2 RID: 4850 RVA: 0x0001DECA File Offset: 0x0001C0CA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USoftObjectProperty._ClassPtr;
		}

		// Token: 0x060012F3 RID: 4851 RVA: 0x0001DED8 File Offset: 0x0001C0D8
		public USoftObjectProperty() : this(BuiltinUtils.AllocNativeUObject(USoftObjectProperty.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060012F4 RID: 4852 RVA: 0x0001DF00 File Offset: 0x0001C100
		[NullableContext(1)]
		public USoftObjectProperty(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USoftObjectProperty.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060012F5 RID: 4853 RVA: 0x0001DF33 File Offset: 0x0001C133
		static USoftObjectProperty()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.SoftObjectProperty");
		}

		// Token: 0x060012F6 RID: 4854 RVA: 0x0001DF41 File Offset: 0x0001C141
		protected USoftObjectProperty(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040005F2 RID: 1522
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.SoftObjectProperty";

		// Token: 0x040005F3 RID: 1523
		private static IntPtr _ClassPtr;

		// Token: 0x040005F4 RID: 1524
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
