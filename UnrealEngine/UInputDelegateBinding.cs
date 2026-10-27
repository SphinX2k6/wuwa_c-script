using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C5A RID: 3162
	[UnrealObjectPath("/Script/Engine.InputDelegateBinding")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UInputDelegateBinding : UDynamicBlueprintBinding, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A058 RID: 41048 RVA: 0x000E3CF7 File Offset: 0x000E1EF7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInputDelegateBinding._ClassPtr;
		}

		// Token: 0x0600A059 RID: 41049 RVA: 0x000E3D03 File Offset: 0x000E1F03
		static UInputDelegateBinding()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InputDelegateBinding");
		}

		// Token: 0x0600A05A RID: 41050 RVA: 0x000E3D14 File Offset: 0x000E1F14
		protected UInputDelegateBinding() : this(BuiltinUtils.AllocNativeUObject(UInputDelegateBinding.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A05B RID: 41051 RVA: 0x000E3D3C File Offset: 0x000E1F3C
		protected UInputDelegateBinding(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400582A RID: 22570
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.InputDelegateBinding";

		// Token: 0x0400582B RID: 22571
		private static IntPtr _ClassPtr;

		// Token: 0x0400582C RID: 22572
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
