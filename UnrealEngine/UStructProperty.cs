using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200014E RID: 334
	[UnrealObjectPath("/Script/CoreUObject.StructProperty")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UStructProperty : UProperty, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001306 RID: 4870 RVA: 0x0001E0CA File Offset: 0x0001C2CA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UStructProperty._ClassPtr;
		}

		// Token: 0x06001307 RID: 4871 RVA: 0x0001E0D8 File Offset: 0x0001C2D8
		public UStructProperty() : this(BuiltinUtils.AllocNativeUObject(UStructProperty.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001308 RID: 4872 RVA: 0x0001E100 File Offset: 0x0001C300
		[NullableContext(1)]
		public UStructProperty(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UStructProperty.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06001309 RID: 4873 RVA: 0x0001E133 File Offset: 0x0001C333
		static UStructProperty()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.StructProperty");
		}

		// Token: 0x0600130A RID: 4874 RVA: 0x0001E141 File Offset: 0x0001C341
		protected UStructProperty(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040005FE RID: 1534
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.StructProperty";

		// Token: 0x040005FF RID: 1535
		private static IntPtr _ClassPtr;

		// Token: 0x04000600 RID: 1536
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
