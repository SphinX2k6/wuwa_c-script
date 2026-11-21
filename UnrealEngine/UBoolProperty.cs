using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000F3 RID: 243
	[UnrealObjectPath("/Script/CoreUObject.BoolProperty")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UBoolProperty : UProperty, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060010E3 RID: 4323 RVA: 0x0001ACC8 File Offset: 0x00018EC8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBoolProperty._ClassPtr;
		}

		// Token: 0x060010E4 RID: 4324 RVA: 0x0001ACD4 File Offset: 0x00018ED4
		public UBoolProperty() : this(BuiltinUtils.AllocNativeUObject(UBoolProperty.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060010E5 RID: 4325 RVA: 0x0001ACFC File Offset: 0x00018EFC
		[NullableContext(1)]
		public UBoolProperty(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBoolProperty.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060010E6 RID: 4326 RVA: 0x0001AD2F File Offset: 0x00018F2F
		static UBoolProperty()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.BoolProperty");
		}

		// Token: 0x060010E7 RID: 4327 RVA: 0x0001AD3D File Offset: 0x00018F3D
		protected UBoolProperty(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000425 RID: 1061
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.BoolProperty";

		// Token: 0x04000426 RID: 1062
		private static IntPtr _ClassPtr;

		// Token: 0x04000427 RID: 1063
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
