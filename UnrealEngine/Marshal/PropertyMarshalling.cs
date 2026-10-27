using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine.Marshal
{
	// Token: 0x02002B0B RID: 11019
	[NullableContext(2)]
	[Nullable(0)]
	internal static class PropertyMarshalling
	{
		// Token: 0x060284A4 RID: 165028 RVA: 0x003D4BEC File Offset: 0x003D2DEC
		internal static int SizeOf<T>()
		{
			Type typeFromHandle = typeof(T);
			if (typeFromHandle.IsValueType || typeFromHandle.StructLayoutAttribute != null)
			{
				return UnmanagedTypeMarshallingProcessor<T>.Size;
			}
			if (typeFromHandle.IsSubclassOf(typeof(UnrealUObject)))
			{
				return UnrealUObjectMarshallingProcessor<T>.Size;
			}
			if (typeFromHandle.IsSubclassOf(typeof(UnrealProxyObject)))
			{
				return UnrealStructObjectMarshallingProcessor<T>.Size;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 1);
			defaultInterpolatedStringHandler.AppendFormatted<Type>(typeFromHandle);
			defaultInterpolatedStringHandler.AppendLiteral(" is not supported");
			throw new NotSupportedException(defaultInterpolatedStringHandler.ToStringAndClear());
		}

		// Token: 0x060284A5 RID: 165029 RVA: 0x003D4C74 File Offset: 0x003D2E74
		internal static int SizeOf<T1, T2>()
		{
			return PropertyMarshalling.SizeOf<T1>() + PropertyMarshalling.SizeOf<T2>();
		}

		// Token: 0x060284A6 RID: 165030 RVA: 0x003D4C81 File Offset: 0x003D2E81
		internal static int SizeOf<T1, T2, T3>()
		{
			return PropertyMarshalling.SizeOf<T1>() + PropertyMarshalling.SizeOf<T2>() + PropertyMarshalling.SizeOf<T3>();
		}

		// Token: 0x060284A7 RID: 165031 RVA: 0x003D4C94 File Offset: 0x003D2E94
		internal static int SizeOf<T1, T2, T3, T4>()
		{
			return PropertyMarshalling.SizeOf<T1>() + PropertyMarshalling.SizeOf<T2>() + PropertyMarshalling.SizeOf<T3>() + PropertyMarshalling.SizeOf<T4>();
		}

		// Token: 0x060284A8 RID: 165032 RVA: 0x003D4CAD File Offset: 0x003D2EAD
		internal static int SizeOf<T1, T2, T3, T4, T5>()
		{
			return PropertyMarshalling.SizeOf<T1>() + PropertyMarshalling.SizeOf<T2>() + PropertyMarshalling.SizeOf<T3>() + PropertyMarshalling.SizeOf<T4>() + PropertyMarshalling.SizeOf<T5>();
		}

		// Token: 0x060284A9 RID: 165033 RVA: 0x003D4CCC File Offset: 0x003D2ECC
		internal static int SizeOf<T1, T2, T3, T4, T5, T6>()
		{
			return PropertyMarshalling.SizeOf<T1>() + PropertyMarshalling.SizeOf<T2>() + PropertyMarshalling.SizeOf<T3>() + PropertyMarshalling.SizeOf<T4>() + PropertyMarshalling.SizeOf<T5>() + PropertyMarshalling.SizeOf<T6>();
		}

		// Token: 0x060284AA RID: 165034 RVA: 0x003D4CF1 File Offset: 0x003D2EF1
		internal static int SizeOf<T1, T2, T3, T4, T5, T6, T7>()
		{
			return PropertyMarshalling.SizeOf<T1>() + PropertyMarshalling.SizeOf<T2>() + PropertyMarshalling.SizeOf<T3>() + PropertyMarshalling.SizeOf<T4>() + PropertyMarshalling.SizeOf<T5>() + PropertyMarshalling.SizeOf<T6>() + PropertyMarshalling.SizeOf<T7>();
		}

		// Token: 0x060284AB RID: 165035 RVA: 0x003D4D1C File Offset: 0x003D2F1C
		internal static int SizeOf<T1, T2, T3, T4, T5, T6, T7, T8>()
		{
			return PropertyMarshalling.SizeOf<T1>() + PropertyMarshalling.SizeOf<T2>() + PropertyMarshalling.SizeOf<T3>() + PropertyMarshalling.SizeOf<T4>() + PropertyMarshalling.SizeOf<T5>() + PropertyMarshalling.SizeOf<T6>() + PropertyMarshalling.SizeOf<T7>() + PropertyMarshalling.SizeOf<T8>();
		}

		// Token: 0x060284AC RID: 165036 RVA: 0x003D4D4D File Offset: 0x003D2F4D
		internal static int SizeOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>()
		{
			return PropertyMarshalling.SizeOf<T1>() + PropertyMarshalling.SizeOf<T2>() + PropertyMarshalling.SizeOf<T3>() + PropertyMarshalling.SizeOf<T4>() + PropertyMarshalling.SizeOf<T5>() + PropertyMarshalling.SizeOf<T6>() + PropertyMarshalling.SizeOf<T7>() + PropertyMarshalling.SizeOf<T8>() + PropertyMarshalling.SizeOf<T9>();
		}

		// Token: 0x060284AD RID: 165037 RVA: 0x003D4D84 File Offset: 0x003D2F84
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		internal unsafe static void Write<[Nullable(2)] T>(byte* buffer, ref int offset, [Nullable(1)] in T value)
		{
			Type typeFromHandle = typeof(T);
			if (typeFromHandle.IsValueType || typeFromHandle.StructLayoutAttribute != null)
			{
				UnmanagedTypeMarshallingProcessor<T>.Write(buffer, ref offset, value);
				return;
			}
			if (typeFromHandle.IsSubclassOf(typeof(UnrealUObject)))
			{
				UnrealUObjectMarshallingProcessor<T>.Write(buffer, ref offset, value);
				return;
			}
			if (typeFromHandle.IsSubclassOf(typeof(UnrealProxyObject)))
			{
				UnrealStructObjectMarshallingProcessor<T>.Write(buffer, ref offset, value);
			}
		}

		// Token: 0x060284AE RID: 165038 RVA: 0x003D4DEA File Offset: 0x003D2FEA
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		internal unsafe static void Write<[Nullable(2)] T1, [Nullable(2)] T2>([Nullable(0)] byte* buffer, ref int offset, in T1 v1, in T2 v2)
		{
			PropertyMarshalling.Write<T1>(buffer, ref offset, v1);
			PropertyMarshalling.Write<T2>(buffer, ref offset, v2);
		}

		// Token: 0x060284AF RID: 165039 RVA: 0x003D4DFC File Offset: 0x003D2FFC
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		internal unsafe static void Write<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3>([Nullable(0)] byte* buffer, ref int offset, in T1 v1, in T2 v2, in T3 v3)
		{
			PropertyMarshalling.Write<T1>(buffer, ref offset, v1);
			PropertyMarshalling.Write<T2>(buffer, ref offset, v2);
			PropertyMarshalling.Write<T3>(buffer, ref offset, v3);
		}

		// Token: 0x060284B0 RID: 165040 RVA: 0x003D4E17 File Offset: 0x003D3017
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		internal unsafe static void Write<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4>([Nullable(0)] byte* buffer, ref int offset, in T1 v1, in T2 v2, in T3 v3, in T4 v4)
		{
			PropertyMarshalling.Write<T1>(buffer, ref offset, v1);
			PropertyMarshalling.Write<T2>(buffer, ref offset, v2);
			PropertyMarshalling.Write<T3>(buffer, ref offset, v3);
			PropertyMarshalling.Write<T4>(buffer, ref offset, v4);
		}

		// Token: 0x060284B1 RID: 165041 RVA: 0x003D4E3B File Offset: 0x003D303B
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		internal unsafe static void Write<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4, [Nullable(2)] T5>([Nullable(0)] byte* buffer, ref int offset, in T1 v1, in T2 v2, in T3 v3, in T4 v4, in T5 v5)
		{
			PropertyMarshalling.Write<T1>(buffer, ref offset, v1);
			PropertyMarshalling.Write<T2>(buffer, ref offset, v2);
			PropertyMarshalling.Write<T3>(buffer, ref offset, v3);
			PropertyMarshalling.Write<T4>(buffer, ref offset, v4);
			PropertyMarshalling.Write<T5>(buffer, ref offset, v5);
		}

		// Token: 0x060284B2 RID: 165042 RVA: 0x003D4E68 File Offset: 0x003D3068
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		internal unsafe static void Write<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4, [Nullable(2)] T5, [Nullable(2)] T6>([Nullable(0)] byte* buffer, ref int offset, in T1 v1, in T2 v2, in T3 v3, in T4 v4, in T5 v5, in T6 v6)
		{
			PropertyMarshalling.Write<T1>(buffer, ref offset, v1);
			PropertyMarshalling.Write<T2>(buffer, ref offset, v2);
			PropertyMarshalling.Write<T3>(buffer, ref offset, v3);
			PropertyMarshalling.Write<T4>(buffer, ref offset, v4);
			PropertyMarshalling.Write<T5>(buffer, ref offset, v5);
			PropertyMarshalling.Write<T6>(buffer, ref offset, v6);
		}

		// Token: 0x060284B3 RID: 165043 RVA: 0x003D4E9E File Offset: 0x003D309E
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		internal unsafe static void Write<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4, [Nullable(2)] T5, [Nullable(2)] T6, [Nullable(2)] T7>([Nullable(0)] byte* buffer, ref int offset, in T1 v1, in T2 v2, in T3 v3, in T4 v4, in T5 v5, in T6 v6, in T7 v7)
		{
			PropertyMarshalling.Write<T1>(buffer, ref offset, v1);
			PropertyMarshalling.Write<T2>(buffer, ref offset, v2);
			PropertyMarshalling.Write<T3>(buffer, ref offset, v3);
			PropertyMarshalling.Write<T4>(buffer, ref offset, v4);
			PropertyMarshalling.Write<T5>(buffer, ref offset, v5);
			PropertyMarshalling.Write<T6>(buffer, ref offset, v6);
			PropertyMarshalling.Write<T7>(buffer, ref offset, v7);
		}

		// Token: 0x060284B4 RID: 165044 RVA: 0x003D4EE0 File Offset: 0x003D30E0
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		internal unsafe static void Write<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4, [Nullable(2)] T5, [Nullable(2)] T6, [Nullable(2)] T7, [Nullable(2)] T8>([Nullable(0)] byte* buffer, ref int offset, in T1 v1, in T2 v2, in T3 v3, in T4 v4, in T5 v5, in T6 v6, in T7 v7, in T8 v8)
		{
			PropertyMarshalling.Write<T1>(buffer, ref offset, v1);
			PropertyMarshalling.Write<T2>(buffer, ref offset, v2);
			PropertyMarshalling.Write<T3>(buffer, ref offset, v3);
			PropertyMarshalling.Write<T4>(buffer, ref offset, v4);
			PropertyMarshalling.Write<T5>(buffer, ref offset, v5);
			PropertyMarshalling.Write<T6>(buffer, ref offset, v6);
			PropertyMarshalling.Write<T7>(buffer, ref offset, v7);
			PropertyMarshalling.Write<T8>(buffer, ref offset, v8);
		}

		// Token: 0x060284B5 RID: 165045 RVA: 0x003D4F34 File Offset: 0x003D3134
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		internal unsafe static void Write<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4, [Nullable(2)] T5, [Nullable(2)] T6, [Nullable(2)] T7, [Nullable(2)] T8, [Nullable(2)] T9>([Nullable(0)] byte* buffer, ref int offset, in T1 v1, in T2 v2, in T3 v3, in T4 v4, in T5 v5, in T6 v6, in T7 v7, in T8 v8, in T9 v9)
		{
			PropertyMarshalling.Write<T1>(buffer, ref offset, v1);
			PropertyMarshalling.Write<T2>(buffer, ref offset, v2);
			PropertyMarshalling.Write<T3>(buffer, ref offset, v3);
			PropertyMarshalling.Write<T4>(buffer, ref offset, v4);
			PropertyMarshalling.Write<T5>(buffer, ref offset, v5);
			PropertyMarshalling.Write<T6>(buffer, ref offset, v6);
			PropertyMarshalling.Write<T7>(buffer, ref offset, v7);
			PropertyMarshalling.Write<T8>(buffer, ref offset, v8);
			PropertyMarshalling.Write<T9>(buffer, ref offset, v9);
		}

		// Token: 0x060284B6 RID: 165046 RVA: 0x003D4F90 File Offset: 0x003D3190
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		internal unsafe static void Read<T>([Nullable(0)] byte* buffer, ref int offset, out T value)
		{
			Type typeFromHandle = typeof(T);
			if (typeFromHandle.IsValueType || typeFromHandle.StructLayoutAttribute != null)
			{
				value = UnmanagedTypeMarshallingProcessor<T>.Read(buffer, ref offset);
			}
			else if (typeFromHandle.IsSubclassOf(typeof(UnrealUObject)))
			{
				value = UnrealUObjectMarshallingProcessor<T>.Read(buffer, ref offset);
			}
			else if (typeFromHandle.IsSubclassOf(typeof(UnrealProxyObject)))
			{
				value = UnrealStructObjectMarshallingProcessor<T>.Read(buffer, ref offset);
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 1);
			defaultInterpolatedStringHandler.AppendFormatted<Type>(typeFromHandle);
			defaultInterpolatedStringHandler.AppendLiteral(" is not supported");
			throw new NotSupportedException(defaultInterpolatedStringHandler.ToStringAndClear());
		}

		// Token: 0x060284B7 RID: 165047 RVA: 0x003D5031 File Offset: 0x003D3231
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		internal unsafe static void Read<T1, T2>([Nullable(0)] byte* buffer, ref int offset, out T1 v1, out T2 v2)
		{
			PropertyMarshalling.Read<T1>(buffer, ref offset, out v1);
			PropertyMarshalling.Read<T2>(buffer, ref offset, out v2);
		}

		// Token: 0x060284B8 RID: 165048 RVA: 0x003D5043 File Offset: 0x003D3243
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		internal unsafe static void Read<T1, T2, T3>([Nullable(0)] byte* buffer, ref int offset, out T1 v1, out T2 v2, out T3 v3)
		{
			PropertyMarshalling.Read<T1>(buffer, ref offset, out v1);
			PropertyMarshalling.Read<T2>(buffer, ref offset, out v2);
			PropertyMarshalling.Read<T3>(buffer, ref offset, out v3);
		}

		// Token: 0x060284B9 RID: 165049 RVA: 0x003D505E File Offset: 0x003D325E
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		internal unsafe static void Read<T1, T2, T3, T4>([Nullable(0)] byte* buffer, ref int offset, out T1 v1, out T2 v2, out T3 v3, out T4 v4)
		{
			PropertyMarshalling.Read<T1>(buffer, ref offset, out v1);
			PropertyMarshalling.Read<T2>(buffer, ref offset, out v2);
			PropertyMarshalling.Read<T3>(buffer, ref offset, out v3);
			PropertyMarshalling.Read<T4>(buffer, ref offset, out v4);
		}

		// Token: 0x060284BA RID: 165050 RVA: 0x003D5082 File Offset: 0x003D3282
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		internal unsafe static void Read<T1, T2, T3, T4, T5>([Nullable(0)] byte* buffer, ref int offset, out T1 v1, out T2 v2, out T3 v3, out T4 v4, out T5 v5)
		{
			PropertyMarshalling.Read<T1>(buffer, ref offset, out v1);
			PropertyMarshalling.Read<T2>(buffer, ref offset, out v2);
			PropertyMarshalling.Read<T3>(buffer, ref offset, out v3);
			PropertyMarshalling.Read<T4>(buffer, ref offset, out v4);
			PropertyMarshalling.Read<T5>(buffer, ref offset, out v5);
		}

		// Token: 0x060284BB RID: 165051 RVA: 0x003D50AF File Offset: 0x003D32AF
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		internal unsafe static void Read<T1, T2, T3, T4, T5, T6>([Nullable(0)] byte* buffer, ref int offset, out T1 v1, out T2 v2, out T3 v3, out T4 v4, out T5 v5, out T6 v6)
		{
			PropertyMarshalling.Read<T1>(buffer, ref offset, out v1);
			PropertyMarshalling.Read<T2>(buffer, ref offset, out v2);
			PropertyMarshalling.Read<T3>(buffer, ref offset, out v3);
			PropertyMarshalling.Read<T4>(buffer, ref offset, out v4);
			PropertyMarshalling.Read<T5>(buffer, ref offset, out v5);
			PropertyMarshalling.Read<T6>(buffer, ref offset, out v6);
		}

		// Token: 0x060284BC RID: 165052 RVA: 0x003D50E5 File Offset: 0x003D32E5
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		internal unsafe static void Read<T1, T2, T3, T4, T5, T6, T7>([Nullable(0)] byte* buffer, ref int offset, out T1 v1, out T2 v2, out T3 v3, out T4 v4, out T5 v5, out T6 v6, out T7 v7)
		{
			PropertyMarshalling.Read<T1>(buffer, ref offset, out v1);
			PropertyMarshalling.Read<T2>(buffer, ref offset, out v2);
			PropertyMarshalling.Read<T3>(buffer, ref offset, out v3);
			PropertyMarshalling.Read<T4>(buffer, ref offset, out v4);
			PropertyMarshalling.Read<T5>(buffer, ref offset, out v5);
			PropertyMarshalling.Read<T6>(buffer, ref offset, out v6);
			PropertyMarshalling.Read<T7>(buffer, ref offset, out v7);
		}

		// Token: 0x060284BD RID: 165053 RVA: 0x003D5124 File Offset: 0x003D3324
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		internal unsafe static void Read<T1, T2, T3, T4, T5, T6, T7, T8>([Nullable(0)] byte* buffer, ref int offset, out T1 v1, out T2 v2, out T3 v3, out T4 v4, out T5 v5, out T6 v6, out T7 v7, out T8 v8)
		{
			PropertyMarshalling.Read<T1>(buffer, ref offset, out v1);
			PropertyMarshalling.Read<T2>(buffer, ref offset, out v2);
			PropertyMarshalling.Read<T3>(buffer, ref offset, out v3);
			PropertyMarshalling.Read<T4>(buffer, ref offset, out v4);
			PropertyMarshalling.Read<T5>(buffer, ref offset, out v5);
			PropertyMarshalling.Read<T6>(buffer, ref offset, out v6);
			PropertyMarshalling.Read<T7>(buffer, ref offset, out v7);
			PropertyMarshalling.Read<T8>(buffer, ref offset, out v8);
		}

		// Token: 0x060284BE RID: 165054 RVA: 0x003D5178 File Offset: 0x003D3378
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		internal unsafe static void Read<T1, T2, T3, T4, T5, T6, T7, T8, T9>([Nullable(0)] byte* buffer, ref int offset, out T1 v1, out T2 v2, out T3 v3, out T4 v4, out T5 v5, out T6 v6, out T7 v7, out T8 v8, out T9 v9)
		{
			PropertyMarshalling.Read<T1>(buffer, ref offset, out v1);
			PropertyMarshalling.Read<T2>(buffer, ref offset, out v2);
			PropertyMarshalling.Read<T3>(buffer, ref offset, out v3);
			PropertyMarshalling.Read<T4>(buffer, ref offset, out v4);
			PropertyMarshalling.Read<T5>(buffer, ref offset, out v5);
			PropertyMarshalling.Read<T6>(buffer, ref offset, out v6);
			PropertyMarshalling.Read<T7>(buffer, ref offset, out v7);
			PropertyMarshalling.Read<T8>(buffer, ref offset, out v8);
			PropertyMarshalling.Read<T9>(buffer, ref offset, out v9);
		}
	}
}
