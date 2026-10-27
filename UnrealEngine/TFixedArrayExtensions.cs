using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnrealEngine
{
	// Token: 0x02000073 RID: 115
	[NullableContext(1)]
	[Nullable(0)]
	public static class TFixedArrayExtensions
	{
		// Token: 0x06000E1B RID: 3611 RVA: 0x00014BAE File Offset: 0x00012DAE
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

		// Token: 0x06000E1C RID: 3612 RVA: 0x00014BD3 File Offset: 0x00012DD3
		[NullableContext(0)]
		public unsafe static Span<U> AsSpan<[Nullable(2)] T, [IsUnmanaged] U>([Nullable(1)] this TArray<T> InArr) where U : struct, ValueType
		{
			return new Span<U>(InArr.ScriptArray->Data, InArr.ScriptArray->ArrayNum * TArray<T>.Processor.Size / sizeof(U));
		}

		// Token: 0x06000E1D RID: 3613 RVA: 0x00014C04 File Offset: 0x00012E04
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

		// Token: 0x06000E1E RID: 3614 RVA: 0x00014C34 File Offset: 0x00012E34
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

		// Token: 0x06000E1F RID: 3615 RVA: 0x00014C91 File Offset: 0x00012E91
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

		// Token: 0x06000E20 RID: 3616 RVA: 0x00014CBC File Offset: 0x00012EBC
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
