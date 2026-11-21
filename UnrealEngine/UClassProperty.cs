using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000F5 RID: 245
	[UnrealObjectPath("/Script/CoreUObject.ClassProperty")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class UClassProperty : UObjectProperty, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060010ED RID: 4333 RVA: 0x0001ADC6 File Offset: 0x00018FC6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UClassProperty._ClassPtr;
		}

		// Token: 0x060010EE RID: 4334 RVA: 0x0001ADD4 File Offset: 0x00018FD4
		public UClassProperty() : this(BuiltinUtils.AllocNativeUObject(UClassProperty.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060010EF RID: 4335 RVA: 0x0001ADFC File Offset: 0x00018FFC
		[NullableContext(1)]
		public UClassProperty(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UClassProperty.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060010F0 RID: 4336 RVA: 0x0001AE2F File Offset: 0x0001902F
		static UClassProperty()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.ClassProperty");
		}

		// Token: 0x060010F1 RID: 4337 RVA: 0x0001AE3D File Offset: 0x0001903D
		protected UClassProperty(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400042B RID: 1067
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.ClassProperty";

		// Token: 0x0400042C RID: 1068
		private static IntPtr _ClassPtr;

		// Token: 0x0400042D RID: 1069
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
