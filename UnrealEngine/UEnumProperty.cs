using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000102 RID: 258
	[UnrealObjectPath("/Script/CoreUObject.EnumProperty")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class UEnumProperty : UProperty, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001112 RID: 4370 RVA: 0x0001B126 File Offset: 0x00019326
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEnumProperty._ClassPtr;
		}

		// Token: 0x06001113 RID: 4371 RVA: 0x0001B134 File Offset: 0x00019334
		public UEnumProperty() : this(BuiltinUtils.AllocNativeUObject(UEnumProperty.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001114 RID: 4372 RVA: 0x0001B15C File Offset: 0x0001935C
		[NullableContext(1)]
		public UEnumProperty(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEnumProperty.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06001115 RID: 4373 RVA: 0x0001B18F File Offset: 0x0001938F
		static UEnumProperty()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.EnumProperty");
		}

		// Token: 0x06001116 RID: 4374 RVA: 0x0001B19D File Offset: 0x0001939D
		protected UEnumProperty(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000477 RID: 1143
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.EnumProperty";

		// Token: 0x04000478 RID: 1144
		private static IntPtr _ClassPtr;

		// Token: 0x04000479 RID: 1145
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
