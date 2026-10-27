using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200074C RID: 1868
	[UnrealObjectPath("/Script/CoreUObject.MulticastInlineDelegatePropertyWrapper")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UMulticastInlineDelegatePropertyWrapper : UMulticastDelegatePropertyWrapper, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060062F2 RID: 25330 RVA: 0x0008E016 File Offset: 0x0008C216
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMulticastInlineDelegatePropertyWrapper._ClassPtr;
		}

		// Token: 0x060062F3 RID: 25331 RVA: 0x0008E024 File Offset: 0x0008C224
		public UMulticastInlineDelegatePropertyWrapper() : this(BuiltinUtils.AllocNativeUObject(UMulticastInlineDelegatePropertyWrapper.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060062F4 RID: 25332 RVA: 0x0008E04C File Offset: 0x0008C24C
		[NullableContext(1)]
		public UMulticastInlineDelegatePropertyWrapper(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMulticastInlineDelegatePropertyWrapper.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060062F5 RID: 25333 RVA: 0x0008E07F File Offset: 0x0008C27F
		static UMulticastInlineDelegatePropertyWrapper()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.MulticastInlineDelegatePropertyWrapper");
		}

		// Token: 0x060062F6 RID: 25334 RVA: 0x0008E08D File Offset: 0x0008C28D
		protected UMulticastInlineDelegatePropertyWrapper(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002F5B RID: 12123
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.MulticastInlineDelegatePropertyWrapper";

		// Token: 0x04002F5C RID: 12124
		private static IntPtr _ClassPtr;

		// Token: 0x04002F5D RID: 12125
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
