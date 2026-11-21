using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000150 RID: 336
	[UnrealObjectPath("/Script/CoreUObject.TextProperty")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UTextProperty : UProperty, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001310 RID: 4880 RVA: 0x0001E1CA File Offset: 0x0001C3CA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTextProperty._ClassPtr;
		}

		// Token: 0x06001311 RID: 4881 RVA: 0x0001E1D8 File Offset: 0x0001C3D8
		public UTextProperty() : this(BuiltinUtils.AllocNativeUObject(UTextProperty.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001312 RID: 4882 RVA: 0x0001E200 File Offset: 0x0001C400
		[NullableContext(1)]
		public UTextProperty(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTextProperty.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06001313 RID: 4883 RVA: 0x0001E233 File Offset: 0x0001C433
		static UTextProperty()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.TextProperty");
		}

		// Token: 0x06001314 RID: 4884 RVA: 0x0001E241 File Offset: 0x0001C441
		protected UTextProperty(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000604 RID: 1540
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.TextProperty";

		// Token: 0x04000605 RID: 1541
		private static IntPtr _ClassPtr;

		// Token: 0x04000606 RID: 1542
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
