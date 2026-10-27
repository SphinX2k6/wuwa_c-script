using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200070A RID: 1802
	[UnrealObjectPath("/Script/CoreUObject.ClassProperty")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class UClassProperty : UObjectProperty, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006186 RID: 24966 RVA: 0x0008BD2A File Offset: 0x00089F2A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UClassProperty._ClassPtr;
		}

		// Token: 0x06006187 RID: 24967 RVA: 0x0008BD38 File Offset: 0x00089F38
		public UClassProperty() : this(BuiltinUtils.AllocNativeUObject(UClassProperty.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006188 RID: 24968 RVA: 0x0008BD60 File Offset: 0x00089F60
		[NullableContext(1)]
		public UClassProperty(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UClassProperty.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06006189 RID: 24969 RVA: 0x0008BD93 File Offset: 0x00089F93
		static UClassProperty()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.ClassProperty");
		}

		// Token: 0x0600618A RID: 24970 RVA: 0x0008BDA1 File Offset: 0x00089FA1
		protected UClassProperty(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002D9C RID: 11676
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.ClassProperty";

		// Token: 0x04002D9D RID: 11677
		private static IntPtr _ClassPtr;

		// Token: 0x04002D9E RID: 11678
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
