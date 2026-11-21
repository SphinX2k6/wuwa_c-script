using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200012D RID: 301
	[UnrealObjectPath("/Script/CoreUObject.MapProperty")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 176)]
	public class UMapProperty : UProperty, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001236 RID: 4662 RVA: 0x0001CD4A File Offset: 0x0001AF4A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMapProperty._ClassPtr;
		}

		// Token: 0x06001237 RID: 4663 RVA: 0x0001CD58 File Offset: 0x0001AF58
		public UMapProperty() : this(BuiltinUtils.AllocNativeUObject(UMapProperty.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001238 RID: 4664 RVA: 0x0001CD80 File Offset: 0x0001AF80
		[NullableContext(1)]
		public UMapProperty(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMapProperty.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06001239 RID: 4665 RVA: 0x0001CDB3 File Offset: 0x0001AFB3
		static UMapProperty()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.MapProperty");
		}

		// Token: 0x0600123A RID: 4666 RVA: 0x0001CDC1 File Offset: 0x0001AFC1
		protected UMapProperty(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000582 RID: 1410
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.MapProperty";

		// Token: 0x04000583 RID: 1411
		private static IntPtr _ClassPtr;

		// Token: 0x04000584 RID: 1412
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
