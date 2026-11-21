using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200014B RID: 331
	[UnrealObjectPath("/Script/CoreUObject.SparseDelegateFunction")]
	[UnrealStructLayout(264, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 264)]
	public class USparseDelegateFunction : UDelegateFunction, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060012F7 RID: 4855 RVA: 0x0001DF4A File Offset: 0x0001C14A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USparseDelegateFunction._ClassPtr;
		}

		// Token: 0x060012F8 RID: 4856 RVA: 0x0001DF58 File Offset: 0x0001C158
		public USparseDelegateFunction() : this(BuiltinUtils.AllocNativeUObject(USparseDelegateFunction.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060012F9 RID: 4857 RVA: 0x0001DF80 File Offset: 0x0001C180
		[NullableContext(1)]
		public USparseDelegateFunction(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USparseDelegateFunction.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060012FA RID: 4858 RVA: 0x0001DFB3 File Offset: 0x0001C1B3
		static USparseDelegateFunction()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.SparseDelegateFunction");
		}

		// Token: 0x060012FB RID: 4859 RVA: 0x0001DFC1 File Offset: 0x0001C1C1
		protected USparseDelegateFunction(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040005F5 RID: 1525
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.SparseDelegateFunction";

		// Token: 0x040005F6 RID: 1526
		private static IntPtr _ClassPtr;

		// Token: 0x040005F7 RID: 1527
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
