using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000129 RID: 297
	[UnrealObjectPath("/Script/CoreUObject.LazyObjectProperty")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class ULazyObjectProperty : UObjectPropertyBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001222 RID: 4642 RVA: 0x0001CB4A File Offset: 0x0001AD4A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULazyObjectProperty._ClassPtr;
		}

		// Token: 0x06001223 RID: 4643 RVA: 0x0001CB58 File Offset: 0x0001AD58
		public ULazyObjectProperty() : this(BuiltinUtils.AllocNativeUObject(ULazyObjectProperty.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001224 RID: 4644 RVA: 0x0001CB80 File Offset: 0x0001AD80
		[NullableContext(1)]
		public ULazyObjectProperty(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULazyObjectProperty.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06001225 RID: 4645 RVA: 0x0001CBB3 File Offset: 0x0001ADB3
		static ULazyObjectProperty()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.LazyObjectProperty");
		}

		// Token: 0x06001226 RID: 4646 RVA: 0x0001CBC1 File Offset: 0x0001ADC1
		protected ULazyObjectProperty(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000576 RID: 1398
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.LazyObjectProperty";

		// Token: 0x04000577 RID: 1399
		private static IntPtr _ClassPtr;

		// Token: 0x04000578 RID: 1400
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
