using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000132 RID: 306
	[UnrealObjectPath("/Script/CoreUObject.MulticastInlineDelegatePropertyWrapper")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UMulticastInlineDelegatePropertyWrapper : UMulticastDelegatePropertyWrapper, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600124E RID: 4686 RVA: 0x0001CF96 File Offset: 0x0001B196
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMulticastInlineDelegatePropertyWrapper._ClassPtr;
		}

		// Token: 0x0600124F RID: 4687 RVA: 0x0001CFA4 File Offset: 0x0001B1A4
		public UMulticastInlineDelegatePropertyWrapper() : this(BuiltinUtils.AllocNativeUObject(UMulticastInlineDelegatePropertyWrapper.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001250 RID: 4688 RVA: 0x0001CFCC File Offset: 0x0001B1CC
		[NullableContext(1)]
		public UMulticastInlineDelegatePropertyWrapper(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMulticastInlineDelegatePropertyWrapper.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06001251 RID: 4689 RVA: 0x0001CFFF File Offset: 0x0001B1FF
		static UMulticastInlineDelegatePropertyWrapper()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.MulticastInlineDelegatePropertyWrapper");
		}

		// Token: 0x06001252 RID: 4690 RVA: 0x0001D00D File Offset: 0x0001B20D
		protected UMulticastInlineDelegatePropertyWrapper(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000591 RID: 1425
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.MulticastInlineDelegatePropertyWrapper";

		// Token: 0x04000592 RID: 1426
		private static IntPtr _ClassPtr;

		// Token: 0x04000593 RID: 1427
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
