using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C61 RID: 3169
	[UnrealObjectPath("/Script/Engine.InputVectorAxisDelegateBinding")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UInputVectorAxisDelegateBinding : UInputAxisKeyDelegateBinding, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A0FE RID: 41214 RVA: 0x000E4C12 File Offset: 0x000E2E12
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInputVectorAxisDelegateBinding._ClassPtr;
		}

		// Token: 0x0600A0FF RID: 41215 RVA: 0x000E4C20 File Offset: 0x000E2E20
		public UInputVectorAxisDelegateBinding() : this(BuiltinUtils.AllocNativeUObject(UInputVectorAxisDelegateBinding.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A100 RID: 41216 RVA: 0x000E4C48 File Offset: 0x000E2E48
		[NullableContext(1)]
		public UInputVectorAxisDelegateBinding(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInputVectorAxisDelegateBinding.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600A101 RID: 41217 RVA: 0x000E4C7B File Offset: 0x000E2E7B
		static UInputVectorAxisDelegateBinding()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InputVectorAxisDelegateBinding");
		}

		// Token: 0x0600A102 RID: 41218 RVA: 0x000E4C89 File Offset: 0x000E2E89
		protected UInputVectorAxisDelegateBinding(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005880 RID: 22656
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.InputVectorAxisDelegateBinding";

		// Token: 0x04005881 RID: 22657
		private static IntPtr _ClassPtr;

		// Token: 0x04005882 RID: 22658
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
