using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200070D RID: 1805
	[UnrealObjectPath("/Script/CoreUObject.DelegateProperty")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UDelegateProperty : UProperty, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006197 RID: 24983 RVA: 0x0008BE8A File Offset: 0x0008A08A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDelegateProperty._ClassPtr;
		}

		// Token: 0x06006198 RID: 24984 RVA: 0x0008BE98 File Offset: 0x0008A098
		public UDelegateProperty() : this(BuiltinUtils.AllocNativeUObject(UDelegateProperty.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006199 RID: 24985 RVA: 0x0008BEC0 File Offset: 0x0008A0C0
		[NullableContext(1)]
		public UDelegateProperty(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDelegateProperty.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600619A RID: 24986 RVA: 0x0008BEF3 File Offset: 0x0008A0F3
		static UDelegateProperty()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.DelegateProperty");
		}

		// Token: 0x0600619B RID: 24987 RVA: 0x0008BF01 File Offset: 0x0008A101
		protected UDelegateProperty(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002DA4 RID: 11684
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.DelegateProperty";

		// Token: 0x04002DA5 RID: 11685
		private static IntPtr _ClassPtr;

		// Token: 0x04002DA6 RID: 11686
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
