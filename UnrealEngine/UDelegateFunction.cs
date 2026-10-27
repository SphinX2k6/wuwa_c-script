using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200070C RID: 1804
	[UnrealObjectPath("/Script/CoreUObject.DelegateFunction")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class UDelegateFunction : UFunction, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006192 RID: 24978 RVA: 0x0008BE0A File Offset: 0x0008A00A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDelegateFunction._ClassPtr;
		}

		// Token: 0x06006193 RID: 24979 RVA: 0x0008BE18 File Offset: 0x0008A018
		public UDelegateFunction() : this(BuiltinUtils.AllocNativeUObject(UDelegateFunction.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006194 RID: 24980 RVA: 0x0008BE40 File Offset: 0x0008A040
		[NullableContext(1)]
		public UDelegateFunction(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDelegateFunction.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06006195 RID: 24981 RVA: 0x0008BE73 File Offset: 0x0008A073
		static UDelegateFunction()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.DelegateFunction");
		}

		// Token: 0x06006196 RID: 24982 RVA: 0x0008BE81 File Offset: 0x0008A081
		protected UDelegateFunction(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002DA1 RID: 11681
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.DelegateFunction";

		// Token: 0x04002DA2 RID: 11682
		private static IntPtr _ClassPtr;

		// Token: 0x04002DA3 RID: 11683
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
