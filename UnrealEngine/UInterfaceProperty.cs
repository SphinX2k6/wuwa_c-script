using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000734 RID: 1844
	[UnrealObjectPath("/Script/CoreUObject.InterfaceProperty")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UInterfaceProperty : UProperty, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600622C RID: 25132 RVA: 0x0008CC59 File Offset: 0x0008AE59
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInterfaceProperty._ClassPtr;
		}

		// Token: 0x0600622D RID: 25133 RVA: 0x0008CC68 File Offset: 0x0008AE68
		public UInterfaceProperty() : this(BuiltinUtils.AllocNativeUObject(UInterfaceProperty.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600622E RID: 25134 RVA: 0x0008CC90 File Offset: 0x0008AE90
		[NullableContext(1)]
		public UInterfaceProperty(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInterfaceProperty.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600622F RID: 25135 RVA: 0x0008CCC3 File Offset: 0x0008AEC3
		static UInterfaceProperty()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.InterfaceProperty");
		}

		// Token: 0x06006230 RID: 25136 RVA: 0x0008CCD1 File Offset: 0x0008AED1
		protected UInterfaceProperty(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002EE3 RID: 12003
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.InterfaceProperty";

		// Token: 0x04002EE4 RID: 12004
		private static IntPtr _ClassPtr;

		// Token: 0x04002EE5 RID: 12005
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
