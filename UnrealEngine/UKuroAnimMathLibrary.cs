using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200165E RID: 5726
	[UnrealObjectPath("/Script/KuroAnim.KuroAnimMathLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroAnimMathLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06014BE4 RID: 84964 RVA: 0x001E8172 File Offset: 0x001E6372
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroAnimMathLibrary._ClassPtr;
		}

		// Token: 0x06014BE5 RID: 84965 RVA: 0x001E8180 File Offset: 0x001E6380
		public UKuroAnimMathLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroAnimMathLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06014BE6 RID: 84966 RVA: 0x001E81A8 File Offset: 0x001E63A8
		[NullableContext(1)]
		public UKuroAnimMathLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroAnimMathLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06014BE7 RID: 84967 RVA: 0x001E81DC File Offset: 0x001E63DC
		public unsafe static FQuat Slerp(in FQuat From, in FQuat To, float Slerp)
		{
			ref FQuat ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = From;
			ref FQuat ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr2 = To;
			return UKuroAnimMathLibrary.__Slerp_Internal(ptr, ptr2, Slerp);
		}

		// Token: 0x06014BE8 RID: 84968
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator Quat_FindBetween(in FVector V1, in FVector V2);

		// Token: 0x06014BE9 RID: 84969
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator LookRotation_UpFirst(in FVector Forward, in FVector Up);

		// Token: 0x06014BEA RID: 84970
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator LookRotation_ForwardFirst(in FVector Forward, in FVector Up);

		// Token: 0x06014BEB RID: 84971
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FQuat LookQuat_UpFirst(in FVector Forward, in FVector Up);

		// Token: 0x06014BEC RID: 84972
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FQuat LookQuat_ForwardFirst(in FVector Forward, in FVector Up);

		// Token: 0x06014BED RID: 84973
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FQuat FindBetween(in FVector V1, in FVector V2);

		// Token: 0x06014BEE RID: 84974
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat __Slerp_Internal(in FQuat From, in FQuat To, float Slerp);

		// Token: 0x06014BEF RID: 84975 RVA: 0x001E8229 File Offset: 0x001E6429
		static UKuroAnimMathLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAnim.KuroAnimMathLibrary");
		}

		// Token: 0x06014BF0 RID: 84976 RVA: 0x001E8237 File Offset: 0x001E6437
		protected UKuroAnimMathLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B4F0 RID: 46320
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroAnim.KuroAnimMathLibrary";

		// Token: 0x0400B4F1 RID: 46321
		private static IntPtr _ClassPtr;

		// Token: 0x0400B4F2 RID: 46322
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
