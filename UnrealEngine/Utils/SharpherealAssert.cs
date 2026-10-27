using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnrealEngine.Utils
{
	// Token: 0x02002AF4 RID: 10996
	[NullableContext(1)]
	[Nullable(0)]
	public static class SharpherealAssert
	{
		// Token: 0x0602847C RID: 164988 RVA: 0x003D4948 File Offset: 0x003D2B48
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool Ensure(bool Condition, string Fmt, params object[] Args)
		{
			if (!Condition)
			{
				UnrealLogger.Warn(string.Format(Fmt, Args));
				return false;
			}
			return true;
		}

		// Token: 0x0602847D RID: 164989 RVA: 0x003D495C File Offset: 0x003D2B5C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool Ensure(bool Condition)
		{
			return Condition;
		}

		// Token: 0x0602847E RID: 164990 RVA: 0x003D4964 File Offset: 0x003D2B64
		[Conditional("SHARPHEREAL_ASSERT_ENABLED")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Assert(bool Condition, string Message)
		{
			if (!Condition)
			{
				throw new Exception(Message);
			}
		}

		// Token: 0x0602847F RID: 164991 RVA: 0x003D4970 File Offset: 0x003D2B70
		[Conditional("SHARPHEREAL_ASSERT_ENABLED")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Assert(bool Condition, string Fmt, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			2
		})] ReadOnlySpan<object> Args)
		{
			if (!Condition)
			{
				throw new Exception(string.Format(Fmt, Args));
			}
		}

		// Token: 0x06028480 RID: 164992 RVA: 0x003D4982 File Offset: 0x003D2B82
		[Conditional("SHARPHEREAL_ASSERT_ENABLED")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Assert(bool Condition)
		{
			if (!Condition)
			{
				throw new Exception();
			}
		}

		// Token: 0x06028481 RID: 164993 RVA: 0x003D498D File Offset: 0x003D2B8D
		[Conditional("SHARPHEREAL_NATIVE_PTR_ASSERT_ENABLED")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void NativePtrAssert(IntPtr NativePtr)
		{
			if (NativePtr == 0 || NativePtr <= (IntPtr)256)
			{
				throw new InvalidUObjectOwnerException();
			}
		}

		// Token: 0x06028482 RID: 164994 RVA: 0x003D49A1 File Offset: 0x003D2BA1
		[Conditional("SHARPHEREAL_NATIVE_PTR_ASSERT_ENABLED")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void FastNativePtrAssert(IntPtr NativePtr)
		{
			if (NativePtr == 0)
			{
				throw new InvalidUObjectOwnerException();
			}
		}

		// Token: 0x040162A2 RID: 90786
		public static bool EnableEnsureBreak = true;
	}
}
