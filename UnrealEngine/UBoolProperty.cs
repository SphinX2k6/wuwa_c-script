using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000708 RID: 1800
	[UnrealObjectPath("/Script/CoreUObject.BoolProperty")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UBoolProperty : UProperty, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600617C RID: 24956 RVA: 0x0008BC29 File Offset: 0x00089E29
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBoolProperty._ClassPtr;
		}

		// Token: 0x0600617D RID: 24957 RVA: 0x0008BC38 File Offset: 0x00089E38
		public UBoolProperty() : this(BuiltinUtils.AllocNativeUObject(UBoolProperty.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600617E RID: 24958 RVA: 0x0008BC60 File Offset: 0x00089E60
		[NullableContext(1)]
		public UBoolProperty(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBoolProperty.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600617F RID: 24959 RVA: 0x0008BC93 File Offset: 0x00089E93
		static UBoolProperty()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.BoolProperty");
		}

		// Token: 0x06006180 RID: 24960 RVA: 0x0008BCA1 File Offset: 0x00089EA1
		protected UBoolProperty(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002D96 RID: 11670
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.BoolProperty";

		// Token: 0x04002D97 RID: 11671
		private static IntPtr _ClassPtr;

		// Token: 0x04002D98 RID: 11672
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
