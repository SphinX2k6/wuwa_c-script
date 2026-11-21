using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000F9 RID: 249
	[UnrealObjectPath("/Script/CoreUObject.DoubleProperty")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UDoubleProperty : UNumericProperty, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001103 RID: 4355 RVA: 0x0001AFA6 File Offset: 0x000191A6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDoubleProperty._ClassPtr;
		}

		// Token: 0x06001104 RID: 4356 RVA: 0x0001AFB4 File Offset: 0x000191B4
		public UDoubleProperty() : this(BuiltinUtils.AllocNativeUObject(UDoubleProperty.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001105 RID: 4357 RVA: 0x0001AFDC File Offset: 0x000191DC
		[NullableContext(1)]
		public UDoubleProperty(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDoubleProperty.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06001106 RID: 4358 RVA: 0x0001B00F File Offset: 0x0001920F
		static UDoubleProperty()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.DoubleProperty");
		}

		// Token: 0x06001107 RID: 4359 RVA: 0x0001B01D File Offset: 0x0001921D
		protected UDoubleProperty(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000436 RID: 1078
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.DoubleProperty";

		// Token: 0x04000437 RID: 1079
		private static IntPtr _ClassPtr;

		// Token: 0x04000438 RID: 1080
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
