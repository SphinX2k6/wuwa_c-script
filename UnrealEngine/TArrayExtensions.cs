using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnrealEngine
{
	// Token: 0x02000071 RID: 113
	[NullableContext(1)]
	[Nullable(0)]
	public static class TArrayExtensions
	{
		// Token: 0x06000DED RID: 3565 RVA: 0x0001460C File Offset: 0x0001280C
		public static void CopyTo<[Nullable(2)] T>(this TArray<T> Self, IntPtr Dest)
		{
			TArray<T>._CopyTo(Dest, Self.ScriptArray);
		}

		// Token: 0x06000DEE RID: 3566 RVA: 0x0001461A File Offset: 0x0001281A
		public static void MoveTo<[Nullable(2)] T>(this TArray<T> Self, IntPtr Dest)
		{
			TArray<T>._MoveTo(Dest, Self.ScriptArray);
		}

		// Token: 0x06000DEF RID: 3567 RVA: 0x00014628 File Offset: 0x00012828
		public static void CopyTo<[Nullable(2)] T>(this TArray<T> Self, TArray<T> Dest)
		{
			TArray<T>._CopyTo(Dest.ScriptArray, Self.ScriptArray);
		}

		// Token: 0x06000DF0 RID: 3568 RVA: 0x0001463B File Offset: 0x0001283B
		public static void CopyAssign<[Nullable(2)] T>(this TArray<T> Self, TArray<T> Src)
		{
			TArray<T>._CopyTo(Self.ScriptArray, Src.ScriptArray);
		}

		// Token: 0x06000DF1 RID: 3569 RVA: 0x0001464E File Offset: 0x0001284E
		public static void MoveTo<[Nullable(2)] T>(this TArray<T> Self, TArray<T> Dest)
		{
			TArray<T>._MoveTo(Dest.ScriptArray, Self.ScriptArray);
		}

		// Token: 0x06000DF2 RID: 3570 RVA: 0x00014661 File Offset: 0x00012861
		public static void MoveAssign<[Nullable(2)] T>(this TArray<T> Self, TArray<T> Src)
		{
			TArray<T>._MoveTo(Self.ScriptArray, Src.ScriptArray);
		}

		// Token: 0x06000DF3 RID: 3571 RVA: 0x00014674 File Offset: 0x00012874
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe static Span<T> AsSpan<[Nullable(2)] T>(this TArray<T> InArr)
		{
			if (!TArray<T>.Processor.CanAsSpan)
			{
				throw new NotSupportedException();
			}
			return InArr.ScriptArray->AsSpan<T>();
		}

		// Token: 0x06000DF4 RID: 3572 RVA: 0x00014693 File Offset: 0x00012893
		[NullableContext(0)]
		public unsafe static Span<U> AsSpan<[Nullable(2)] T, [IsUnmanaged] U>([Nullable(1)] this TArray<T> InArr) where U : struct, ValueType
		{
			return new Span<U>(InArr.ScriptArray->Data, InArr.ScriptArray->ArrayNum * TArray<T>.Processor.Size / sizeof(U));
		}

		// Token: 0x06000DF5 RID: 3573 RVA: 0x000146C4 File Offset: 0x000128C4
		public static T[] ToArray<[Nullable(2)] T>(this TArray<T> InArr)
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

		// Token: 0x06000DF6 RID: 3574 RVA: 0x000146F4 File Offset: 0x000128F4
		public static List<T> ToList<[Nullable(2)] T>(this TArray<T> InArr)
		{
			int num = InArr.Num();
			if (num == 0)
			{
				return new List<T>();
			}
			List<T> list = new List<T>(num);
			if (TArray<T>.Processor.CanAsSpan)
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

		// Token: 0x06000DF7 RID: 3575 RVA: 0x00014751 File Offset: 0x00012951
		[NullableContext(0)]
		public unsafe static ref T GetRefStruct_Unsafe<[IsUnmanaged] T>([Nullable(new byte[]
		{
			1,
			0
		})] this TArray<T> InArray, int Index) where T : struct, ValueType
		{
			InArray.CheckValidIndex(Index);
			if (TArray<T>.Processor.CanAsSpan)
			{
				return InArray.ScriptArray->Data + (IntPtr)Index * (IntPtr)sizeof(T);
			}
			throw new NotImplementedException();
		}

		// Token: 0x06000DF8 RID: 3576 RVA: 0x00014781 File Offset: 0x00012981
		public unsafe static T GetRef_Unsafe<T>(this TArray<T> InArray, int Index) where T : class
		{
			InArray.CheckValidIndex(Index);
			if (TArray<T>.Processor.CanAsSpan)
			{
				throw new NotImplementedException();
			}
			return TArray<T>.Processor.GetRef_Unsafe(InArray.ScriptArray->Data, Index, InArray.MemoryOwner ?? InArray);
		}
	}
}
