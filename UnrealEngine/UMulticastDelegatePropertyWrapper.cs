using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000130 RID: 304
	[UnrealObjectPath("/Script/CoreUObject.MulticastDelegatePropertyWrapper")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UMulticastDelegatePropertyWrapper : UPropertyWrapper, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001244 RID: 4676 RVA: 0x0001CE95 File Offset: 0x0001B095
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMulticastDelegatePropertyWrapper._ClassPtr;
		}

		// Token: 0x06001245 RID: 4677 RVA: 0x0001CEA4 File Offset: 0x0001B0A4
		public UMulticastDelegatePropertyWrapper() : this(BuiltinUtils.AllocNativeUObject(UMulticastDelegatePropertyWrapper.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001246 RID: 4678 RVA: 0x0001CECC File Offset: 0x0001B0CC
		[NullableContext(1)]
		public UMulticastDelegatePropertyWrapper(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMulticastDelegatePropertyWrapper.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06001247 RID: 4679 RVA: 0x0001CEFF File Offset: 0x0001B0FF
		static UMulticastDelegatePropertyWrapper()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.MulticastDelegatePropertyWrapper");
		}

		// Token: 0x06001248 RID: 4680 RVA: 0x0001CF0D File Offset: 0x0001B10D
		protected UMulticastDelegatePropertyWrapper(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400058B RID: 1419
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.MulticastDelegatePropertyWrapper";

		// Token: 0x0400058C RID: 1420
		private static IntPtr _ClassPtr;

		// Token: 0x0400058D RID: 1421
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
