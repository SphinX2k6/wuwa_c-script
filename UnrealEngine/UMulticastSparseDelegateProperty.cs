using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200074D RID: 1869
	[UnrealObjectPath("/Script/CoreUObject.MulticastSparseDelegateProperty")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UMulticastSparseDelegateProperty : UMulticastDelegateProperty, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060062F7 RID: 25335 RVA: 0x0008E096 File Offset: 0x0008C296
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMulticastSparseDelegateProperty._ClassPtr;
		}

		// Token: 0x060062F8 RID: 25336 RVA: 0x0008E0A4 File Offset: 0x0008C2A4
		public UMulticastSparseDelegateProperty() : this(BuiltinUtils.AllocNativeUObject(UMulticastSparseDelegateProperty.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060062F9 RID: 25337 RVA: 0x0008E0CC File Offset: 0x0008C2CC
		[NullableContext(1)]
		public UMulticastSparseDelegateProperty(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMulticastSparseDelegateProperty.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060062FA RID: 25338 RVA: 0x0008E0FF File Offset: 0x0008C2FF
		static UMulticastSparseDelegateProperty()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.MulticastSparseDelegateProperty");
		}

		// Token: 0x060062FB RID: 25339 RVA: 0x0008E10D File Offset: 0x0008C30D
		protected UMulticastSparseDelegateProperty(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002F5E RID: 12126
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.MulticastSparseDelegateProperty";

		// Token: 0x04002F5F RID: 12127
		private static IntPtr _ClassPtr;

		// Token: 0x04002F60 RID: 12128
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
