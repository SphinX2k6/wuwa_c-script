using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002F4 RID: 756
	[UnrealObjectPath("/Script/KuroAnim.KuroAnimMathLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroAnimMathLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005248 RID: 21064 RVA: 0x000731BF File Offset: 0x000713BF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroAnimMathLibrary._ClassPtr;
		}

		// Token: 0x06005249 RID: 21065 RVA: 0x000731CC File Offset: 0x000713CC
		public UKuroAnimMathLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroAnimMathLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600524A RID: 21066 RVA: 0x000731F4 File Offset: 0x000713F4
		[NullableContext(1)]
		public UKuroAnimMathLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroAnimMathLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600524B RID: 21067 RVA: 0x00073228 File Offset: 0x00071428
		public unsafe static FQuat Slerp(in FQuat From, in FQuat To, float Slerp)
		{
			ref FQuat ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = From;
			ref FQuat ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr2 = To;
			return UKuroAnimMathLibrary.__Slerp_Internal(ptr, ptr2, Slerp);
		}

		// Token: 0x0600524C RID: 21068
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator Quat_FindBetween(in FVector V1, in FVector V2);

		// Token: 0x0600524D RID: 21069
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator LookRotation_UpFirst(in FVector Forward, in FVector Up);

		// Token: 0x0600524E RID: 21070
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator LookRotation_ForwardFirst(in FVector Forward, in FVector Up);

		// Token: 0x0600524F RID: 21071
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FQuat LookQuat_UpFirst(in FVector Forward, in FVector Up);

		// Token: 0x06005250 RID: 21072
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FQuat LookQuat_ForwardFirst(in FVector Forward, in FVector Up);

		// Token: 0x06005251 RID: 21073
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FQuat FindBetween(in FVector V1, in FVector V2);

		// Token: 0x06005252 RID: 21074
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat __Slerp_Internal(in FQuat From, in FQuat To, float Slerp);

		// Token: 0x06005253 RID: 21075 RVA: 0x00073275 File Offset: 0x00071475
		static UKuroAnimMathLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAnim.KuroAnimMathLibrary");
		}

		// Token: 0x06005254 RID: 21076 RVA: 0x00073283 File Offset: 0x00071483
		protected UKuroAnimMathLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002180 RID: 8576
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroAnim.KuroAnimMathLibrary";

		// Token: 0x04002181 RID: 8577
		private static IntPtr _ClassPtr;

		// Token: 0x04002182 RID: 8578
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
