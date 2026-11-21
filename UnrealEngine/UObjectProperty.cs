using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000139 RID: 313
	[UnrealObjectPath("/Script/CoreUObject.ObjectProperty")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UObjectProperty : UObjectPropertyBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001278 RID: 4728 RVA: 0x0001D3F8 File Offset: 0x0001B5F8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UObjectProperty._ClassPtr;
		}

		// Token: 0x06001279 RID: 4729 RVA: 0x0001D404 File Offset: 0x0001B604
		public UObjectProperty() : this(BuiltinUtils.AllocNativeUObject(UObjectProperty.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600127A RID: 4730 RVA: 0x0001D42C File Offset: 0x0001B62C
		[NullableContext(1)]
		public UObjectProperty(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UObjectProperty.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600127B RID: 4731 RVA: 0x0001D45F File Offset: 0x0001B65F
		static UObjectProperty()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.ObjectProperty");
		}

		// Token: 0x0600127C RID: 4732 RVA: 0x0001D46D File Offset: 0x0001B66D
		protected UObjectProperty(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040005AE RID: 1454
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.ObjectProperty";

		// Token: 0x040005AF RID: 1455
		private static IntPtr _ClassPtr;

		// Token: 0x040005B0 RID: 1456
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
