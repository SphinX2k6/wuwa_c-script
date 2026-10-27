using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020019C3 RID: 6595
	[UnrealObjectPath("/Script/KuroMath.KuroBitwiseLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroBitwiseLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06018811 RID: 100369 RVA: 0x00241B8D File Offset: 0x0023FD8D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroBitwiseLibrary._ClassPtr;
		}

		// Token: 0x06018812 RID: 100370 RVA: 0x00241B9C File Offset: 0x0023FD9C
		public UKuroBitwiseLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroBitwiseLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06018813 RID: 100371 RVA: 0x00241BC4 File Offset: 0x0023FDC4
		[NullableContext(1)]
		public UKuroBitwiseLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroBitwiseLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06018814 RID: 100372
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long LongBitwiseXOr(long Num1, long Num2);

		// Token: 0x06018815 RID: 100373
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long LongBitwiseOr(long Num1, long Num2);

		// Token: 0x06018816 RID: 100374
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long LongBitwiseNot(long Num);

		// Token: 0x06018817 RID: 100375
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long LongBitwiseAnd(long Num1, long Num2);

		// Token: 0x06018818 RID: 100376 RVA: 0x00241BF8 File Offset: 0x0023FDF8
		[NullableContext(1)]
		public unsafe static long KuroStringToInt64(string StringNum)
		{
			FString fstring = FString.AllocTemp(StringNum);
			long result = UKuroBitwiseLibrary.__KuroStringToInt64_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06018819 RID: 100377
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int IntBitwiseXOr(int Num1, int Num2);

		// Token: 0x0601881A RID: 100378
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int IntBitwiseOr(int Num1, int Num2);

		// Token: 0x0601881B RID: 100379
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int IntBitwiseNot(int Num);

		// Token: 0x0601881C RID: 100380
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int IntBitwiseAnd(int Num1, int Num2);

		// Token: 0x0601881D RID: 100381
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long BitwiseRightShift(long Source, int Bit);

		// Token: 0x0601881E RID: 100382
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long BitwiseLeftShift(long Source, int Bit);

		// Token: 0x0601881F RID: 100383
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern long __KuroStringToInt64_Internal(in FString StringNum);

		// Token: 0x06018820 RID: 100384 RVA: 0x00241C1C File Offset: 0x0023FE1C
		static UKuroBitwiseLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroMath.KuroBitwiseLibrary");
		}

		// Token: 0x06018821 RID: 100385 RVA: 0x00241C2A File Offset: 0x0023FE2A
		protected UKuroBitwiseLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D400 RID: 54272
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroMath.KuroBitwiseLibrary";

		// Token: 0x0400D401 RID: 54273
		private static IntPtr _ClassPtr;

		// Token: 0x0400D402 RID: 54274
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
