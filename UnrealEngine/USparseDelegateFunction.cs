using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000765 RID: 1893
	[UnrealObjectPath("/Script/CoreUObject.SparseDelegateFunction")]
	[UnrealStructLayout(264, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 264)]
	public class USparseDelegateFunction : UDelegateFunction, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600639F RID: 25503 RVA: 0x0008F056 File Offset: 0x0008D256
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USparseDelegateFunction._ClassPtr;
		}

		// Token: 0x060063A0 RID: 25504 RVA: 0x0008F064 File Offset: 0x0008D264
		public USparseDelegateFunction() : this(BuiltinUtils.AllocNativeUObject(USparseDelegateFunction.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060063A1 RID: 25505 RVA: 0x0008F08C File Offset: 0x0008D28C
		[NullableContext(1)]
		public USparseDelegateFunction(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USparseDelegateFunction.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060063A2 RID: 25506 RVA: 0x0008F0BF File Offset: 0x0008D2BF
		static USparseDelegateFunction()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.SparseDelegateFunction");
		}

		// Token: 0x060063A3 RID: 25507 RVA: 0x0008F0CD File Offset: 0x0008D2CD
		protected USparseDelegateFunction(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002FBF RID: 12223
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.SparseDelegateFunction";

		// Token: 0x04002FC0 RID: 12224
		private static IntPtr _ClassPtr;

		// Token: 0x04002FC1 RID: 12225
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
