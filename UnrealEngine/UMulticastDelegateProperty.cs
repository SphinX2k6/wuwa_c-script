using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000749 RID: 1865
	[UnrealObjectPath("/Script/CoreUObject.MulticastDelegateProperty")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public abstract class UMulticastDelegateProperty : UProperty, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060062E4 RID: 25316 RVA: 0x0008DECA File Offset: 0x0008C0CA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMulticastDelegateProperty._ClassPtr;
		}

		// Token: 0x060062E5 RID: 25317 RVA: 0x0008DED6 File Offset: 0x0008C0D6
		static UMulticastDelegateProperty()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.MulticastDelegateProperty");
		}

		// Token: 0x060062E6 RID: 25318 RVA: 0x0008DEE4 File Offset: 0x0008C0E4
		protected UMulticastDelegateProperty() : this(BuiltinUtils.AllocNativeUObject(UMulticastDelegateProperty.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060062E7 RID: 25319 RVA: 0x0008DF0C File Offset: 0x0008C10C
		protected UMulticastDelegateProperty(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002F52 RID: 12114
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.MulticastDelegateProperty";

		// Token: 0x04002F53 RID: 12115
		private static IntPtr _ClassPtr;

		// Token: 0x04002F54 RID: 12116
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
