using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EBF RID: 7871
	[UnrealObjectPath("/Script/KuroUtility.KuroMathLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroMathLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DDE7 RID: 122343 RVA: 0x002C2E10 File Offset: 0x002C1010
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroMathLibrary._ClassPtr;
		}

		// Token: 0x0601DDE8 RID: 122344 RVA: 0x002C2E1C File Offset: 0x002C101C
		public UKuroMathLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroMathLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DDE9 RID: 122345 RVA: 0x002C2E44 File Offset: 0x002C1044
		[NullableContext(1)]
		public UKuroMathLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroMathLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601DDEA RID: 122346
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D Min(in FVector2D A, in FVector2D B);

		// Token: 0x0601DDEB RID: 122347
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D Max(in FVector2D A, in FVector2D B);

		// Token: 0x0601DDEC RID: 122348
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long BitwiseRightShift(long Source, int Bit);

		// Token: 0x0601DDED RID: 122349
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long BitwiseLeftShift(long Source, int Bit);

		// Token: 0x0601DDEE RID: 122350 RVA: 0x002C2E77 File Offset: 0x002C1077
		static UKuroMathLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroMathLibrary");
		}

		// Token: 0x0601DDEF RID: 122351 RVA: 0x002C2E85 File Offset: 0x002C1085
		protected UKuroMathLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040102E7 RID: 66279
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroUtility.KuroMathLibrary";

		// Token: 0x040102E8 RID: 66280
		private static IntPtr _ClassPtr;

		// Token: 0x040102E9 RID: 66281
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
