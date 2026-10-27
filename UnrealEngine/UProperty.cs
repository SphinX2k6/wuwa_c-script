using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200075E RID: 1886
	[UnrealObjectPath("/Script/CoreUObject.Property")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public abstract class UProperty : UField, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006376 RID: 25462 RVA: 0x0008EC83 File Offset: 0x0008CE83
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UProperty._ClassPtr;
		}

		// Token: 0x06006377 RID: 25463 RVA: 0x0008EC8F File Offset: 0x0008CE8F
		static UProperty()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.Property");
		}

		// Token: 0x06006378 RID: 25464 RVA: 0x0008ECA0 File Offset: 0x0008CEA0
		protected UProperty() : this(BuiltinUtils.AllocNativeUObject(UProperty.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006379 RID: 25465 RVA: 0x0008ECC8 File Offset: 0x0008CEC8
		protected UProperty(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002FA8 RID: 12200
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.Property";

		// Token: 0x04002FA9 RID: 12201
		private static IntPtr _ClassPtr;

		// Token: 0x04002FAA RID: 12202
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
