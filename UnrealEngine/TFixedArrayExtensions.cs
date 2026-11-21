using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnrealEngine
{
	// Token: 0x02000058 RID: 88
	[NullableContext(1)]
	[Nullable(0)]
	public static class TFixedArrayExtensions
	{
		// Token: 0x060009AC RID: 2476 RVA: 0x0000F8AE File Offset: 0x0000DAAE
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Span<T> AsSpan<[Nullable(2)] T>(this TFixedArray<T> InArr)
		{
			if (!TFixedArray<T>.Processor.CanAsSpan)
			{
				throw new NotSupportedException();
			}
			return new Span<T>(InArr.NativePtr, InArr.Num());
		}

		// Token: 0x060009AD RID: 2477 RVA: 0x0000F8D3 File Offset: 0x0000DAD3
		[NullableContext(0)]
		public unsafe static Span<U> AsSpan<[Nullable(2)] T, [IsUnmanaged] U>([Nullable(1)] this TArray<T> InArr) where U : struct, ValueType
		{
			return new Span<U>(InArr.ScriptArray->Data, InArr.ScriptArray->ArrayNum * TArray<T>.Processor.Size / sizeof(U));
		}

		// Token: 0x060009AE RID: 2478 RVA: 0x0000F904 File Offset: 0x0000DB04
		public static T[] ToArray<[Nullable(2)] T>(this TFixedArray<T> InArr)
		{
			int num = InArr.Num();
			if (num == 0)
			{
				return Array.Empty<T>();
			}
			T[] array = new T[num];
			InArr.CopyTo(array, 0);
			return array;
		}

		// Token: 0x060009AF RID: 2479 RVA: 0x0000F934 File Offset: 0x0000DB34
		public static List<T> ToList<[Nullable(2)] T>(this TFixedArray<T> InArr)
		{
			int num = InArr.Num();
			if (num == 0)
			{
				return new List<T>();
			}
			List<T> list = new List<T>(num);
			if (TFixedArray<T>.Processor.CanAsSpan)
			{
				list.AddRange(InArr.AsSpan<T>());
			}
			else
			{
				for (int i = 0; i < num; i++)
				{
					list.Add(InArr[i]);
				}
			}
			return list;
		}

		// Token: 0x060009B0 RID: 2480 RVA: 0x0000F991 File Offset: 0x0000DB91
		[NullableContext(0)]
		public static ref T GetRefStruct_Unsafe<[IsUnmanaged] T>([Nullable(new byte[]
		{
			1,
			0
		})] this TFixedArray<T> InArray, int Index) where T : struct, ValueType
		{
			InArray.CheckValidIndex(Index);
			if (TFixedArray<T>.Processor.CanAsSpan)
			{
				return InArray.NativePtr + (IntPtr)Index * (IntPtr)sizeof(T);
			}
			throw new NotImplementedException();
		}

		// Token: 0x060009B1 RID: 2481 RVA: 0x0000F9BC File Offset: 0x0000DBBC
		public static T GetRef_Unsafe<T>(this TFixedArray<T> InArray, int Index) where T : class
		{
			if (TFixedArray<T>.Processor.CanAsSpan)
			{
				throw new NotImplementedException();
			}
			return TFixedArray<T>.Processor.GetRef_Unsafe(InArray.NativePtr, Index, InArray.MemoryOwner ?? InArray);
		}
	}
}
