using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000743 RID: 1859
	[UnrealObjectPath("/Script/CoreUObject.LazyObjectProperty")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class ULazyObjectProperty : UObjectPropertyBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060062C6 RID: 25286 RVA: 0x0008DBCA File Offset: 0x0008BDCA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULazyObjectProperty._ClassPtr;
		}

		// Token: 0x060062C7 RID: 25287 RVA: 0x0008DBD8 File Offset: 0x0008BDD8
		public ULazyObjectProperty() : this(BuiltinUtils.AllocNativeUObject(ULazyObjectProperty.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060062C8 RID: 25288 RVA: 0x0008DC00 File Offset: 0x0008BE00
		[NullableContext(1)]
		public ULazyObjectProperty(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULazyObjectProperty.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060062C9 RID: 25289 RVA: 0x0008DC33 File Offset: 0x0008BE33
		static ULazyObjectProperty()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.LazyObjectProperty");
		}

		// Token: 0x060062CA RID: 25290 RVA: 0x0008DC41 File Offset: 0x0008BE41
		protected ULazyObjectProperty(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002F40 RID: 12096
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.LazyObjectProperty";

		// Token: 0x04002F41 RID: 12097
		private static IntPtr _ClassPtr;

		// Token: 0x04002F42 RID: 12098
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
