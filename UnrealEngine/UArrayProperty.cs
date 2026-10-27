using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000702 RID: 1794
	[UnrealObjectPath("/Script/CoreUObject.ArrayProperty")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UArrayProperty : UProperty, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600612D RID: 24877 RVA: 0x0008B574 File Offset: 0x00089774
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UArrayProperty._ClassPtr;
		}

		// Token: 0x0600612E RID: 24878 RVA: 0x0008B580 File Offset: 0x00089780
		public UArrayProperty() : this(BuiltinUtils.AllocNativeUObject(UArrayProperty.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600612F RID: 24879 RVA: 0x0008B5A8 File Offset: 0x000897A8
		[NullableContext(1)]
		public UArrayProperty(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UArrayProperty.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06006130 RID: 24880 RVA: 0x0008B5DB File Offset: 0x000897DB
		static UArrayProperty()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.ArrayProperty");
		}

		// Token: 0x06006131 RID: 24881 RVA: 0x0008B5E9 File Offset: 0x000897E9
		protected UArrayProperty(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002D73 RID: 11635
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.ArrayProperty";

		// Token: 0x04002D74 RID: 11636
		private static IntPtr _ClassPtr;

		// Token: 0x04002D75 RID: 11637
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
