using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000F7 RID: 247
	[UnrealObjectPath("/Script/CoreUObject.DelegateFunction")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class UDelegateFunction : UFunction, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060010F9 RID: 4345 RVA: 0x0001AEA6 File Offset: 0x000190A6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDelegateFunction._ClassPtr;
		}

		// Token: 0x060010FA RID: 4346 RVA: 0x0001AEB4 File Offset: 0x000190B4
		public UDelegateFunction() : this(BuiltinUtils.AllocNativeUObject(UDelegateFunction.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060010FB RID: 4347 RVA: 0x0001AEDC File Offset: 0x000190DC
		[NullableContext(1)]
		public UDelegateFunction(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDelegateFunction.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060010FC RID: 4348 RVA: 0x0001AF0F File Offset: 0x0001910F
		static UDelegateFunction()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.DelegateFunction");
		}

		// Token: 0x060010FD RID: 4349 RVA: 0x0001AF1D File Offset: 0x0001911D
		protected UDelegateFunction(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000430 RID: 1072
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.DelegateFunction";

		// Token: 0x04000431 RID: 1073
		private static IntPtr _ClassPtr;

		// Token: 0x04000432 RID: 1074
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
