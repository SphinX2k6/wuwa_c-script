using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020012D2 RID: 4818
	[UnrealObjectPath("/Script/Foliage.InteractiveFoliageComponent")]
	[UnrealStructLayout(2032, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2032)]
	public class UInteractiveFoliageComponent : UStaticMeshComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011AD1 RID: 72401 RVA: 0x0019F472 File Offset: 0x0019D672
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInteractiveFoliageComponent._ClassPtr;
		}

		// Token: 0x06011AD2 RID: 72402 RVA: 0x0019F480 File Offset: 0x0019D680
		public UInteractiveFoliageComponent() : this(BuiltinUtils.AllocNativeUObject(UInteractiveFoliageComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011AD3 RID: 72403 RVA: 0x0019F4A8 File Offset: 0x0019D6A8
		[NullableContext(1)]
		public UInteractiveFoliageComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInteractiveFoliageComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06011AD4 RID: 72404 RVA: 0x0019F4DB File Offset: 0x0019D6DB
		static UInteractiveFoliageComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Foliage.InteractiveFoliageComponent");
		}

		// Token: 0x06011AD5 RID: 72405 RVA: 0x0019F4E9 File Offset: 0x0019D6E9
		protected UInteractiveFoliageComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040097B6 RID: 38838
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Foliage.InteractiveFoliageComponent";

		// Token: 0x040097B7 RID: 38839
		private static IntPtr _ClassPtr;

		// Token: 0x040097B8 RID: 38840
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
