using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000149 RID: 329
	[UnrealObjectPath("/Script/CoreUObject.SoftClassProperty")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class USoftClassProperty : USoftObjectProperty, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060012ED RID: 4845 RVA: 0x0001DE4A File Offset: 0x0001C04A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USoftClassProperty._ClassPtr;
		}

		// Token: 0x060012EE RID: 4846 RVA: 0x0001DE58 File Offset: 0x0001C058
		public USoftClassProperty() : this(BuiltinUtils.AllocNativeUObject(USoftClassProperty.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060012EF RID: 4847 RVA: 0x0001DE80 File Offset: 0x0001C080
		[NullableContext(1)]
		public USoftClassProperty(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USoftClassProperty.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060012F0 RID: 4848 RVA: 0x0001DEB3 File Offset: 0x0001C0B3
		static USoftClassProperty()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.SoftClassProperty");
		}

		// Token: 0x060012F1 RID: 4849 RVA: 0x0001DEC1 File Offset: 0x0001C0C1
		protected USoftClassProperty(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040005EF RID: 1519
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.SoftClassProperty";

		// Token: 0x040005F0 RID: 1520
		private static IntPtr _ClassPtr;

		// Token: 0x040005F1 RID: 1521
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
