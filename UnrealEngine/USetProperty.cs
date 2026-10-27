using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000762 RID: 1890
	[UnrealObjectPath("/Script/CoreUObject.SetProperty")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 168)]
	public class USetProperty : UProperty, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006390 RID: 25488 RVA: 0x0008EED6 File Offset: 0x0008D0D6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USetProperty._ClassPtr;
		}

		// Token: 0x06006391 RID: 25489 RVA: 0x0008EEE4 File Offset: 0x0008D0E4
		public USetProperty() : this(BuiltinUtils.AllocNativeUObject(USetProperty.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006392 RID: 25490 RVA: 0x0008EF0C File Offset: 0x0008D10C
		[NullableContext(1)]
		public USetProperty(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USetProperty.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06006393 RID: 25491 RVA: 0x0008EF3F File Offset: 0x0008D13F
		static USetProperty()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.SetProperty");
		}

		// Token: 0x06006394 RID: 25492 RVA: 0x0008EF4D File Offset: 0x0008D14D
		protected USetProperty(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002FB6 RID: 12214
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.SetProperty";

		// Token: 0x04002FB7 RID: 12215
		private static IntPtr _ClassPtr;

		// Token: 0x04002FB8 RID: 12216
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
