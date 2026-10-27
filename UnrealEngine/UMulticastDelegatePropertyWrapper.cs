using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200074A RID: 1866
	[UnrealObjectPath("/Script/CoreUObject.MulticastDelegatePropertyWrapper")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UMulticastDelegatePropertyWrapper : UPropertyWrapper, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060062E8 RID: 25320 RVA: 0x0008DF15 File Offset: 0x0008C115
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMulticastDelegatePropertyWrapper._ClassPtr;
		}

		// Token: 0x060062E9 RID: 25321 RVA: 0x0008DF24 File Offset: 0x0008C124
		public UMulticastDelegatePropertyWrapper() : this(BuiltinUtils.AllocNativeUObject(UMulticastDelegatePropertyWrapper.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060062EA RID: 25322 RVA: 0x0008DF4C File Offset: 0x0008C14C
		[NullableContext(1)]
		public UMulticastDelegatePropertyWrapper(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMulticastDelegatePropertyWrapper.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060062EB RID: 25323 RVA: 0x0008DF7F File Offset: 0x0008C17F
		static UMulticastDelegatePropertyWrapper()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.MulticastDelegatePropertyWrapper");
		}

		// Token: 0x060062EC RID: 25324 RVA: 0x0008DF8D File Offset: 0x0008C18D
		protected UMulticastDelegatePropertyWrapper(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002F55 RID: 12117
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.MulticastDelegatePropertyWrapper";

		// Token: 0x04002F56 RID: 12118
		private static IntPtr _ClassPtr;

		// Token: 0x04002F57 RID: 12119
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
