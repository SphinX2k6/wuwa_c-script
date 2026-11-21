using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnrealEngine
{
	// Token: 0x02000056 RID: 86
	[NullableContext(1)]
	[Nullable(0)]
	public static class TArrayExtensions
	{
		// Token: 0x0600097D RID: 2429 RVA: 0x0000F304 File Offset: 0x0000D504
		public static void CopyTo<[Nullable(2)] T>(this TArray<T> Self, IntPtr Dest)
		{
			TArray<T>._CopyTo(Dest, Self.ScriptArray);
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x0000F312 File Offset: 0x0000D512
		public static void MoveTo<[Nullable(2)] T>(this TArray<T> Self, IntPtr Dest)
		{
			TArray<T>._MoveTo(Dest, Self.ScriptArray);
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x0000F320 File Offset: 0x0000D520
		public static void CopyTo<[Nullable(2)] T>(this TArray<T> Self, TArray<T> Dest)
		{
			TArray<T>._CopyTo(Dest.ScriptArray, Self.ScriptArray);
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x0000F333 File Offset: 0x0000D533
		public static void CopyAssign<[Nullable(2)] T>(this TArray<T> Self, TArray<T> Src)
		{
			TArray<T>._CopyTo(Self.ScriptArray, Src.ScriptArray);
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x0000F346 File Offset: 0x0000D546
		public static void MoveTo<[Nullable(2)] T>(this TArray<T> Self, TArray<T> Dest)
		{
			TArray<T>._MoveTo(Dest.ScriptArray, Self.ScriptArray);
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x0000F359 File Offset: 0x0000D559
		public static void MoveAssign<[Nullable(2)] T>(this TArray<T> Self, TArray<T> Src)
		{
			TArray<T>._MoveTo(Self.ScriptArray, Src.ScriptArray);
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x0000F36C File Offset: 0x0000D56C
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

		// Token: 0x06000984 RID: 2436 RVA: 0x0000F38B File Offset: 0x0000D58B
		[NullableContext(0)]
		public unsafe static Span<U> AsSpan<[Nullable(2)] T, [IsUnmanaged] U>([Nullable(1)] this TArray<T> InArr) where U : struct, ValueType
		{
			return new Span<U>(InArr.ScriptArray->Data, InArr.ScriptArray->ArrayNum * TArray<T>.Processor.Size / sizeof(U));
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x0000F3BC File Offset: 0x0000D5BC
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

		// Token: 0x06000986 RID: 2438 RVA: 0x0000F3EC File Offset: 0x0000D5EC
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

		// Token: 0x06000987 RID: 2439 RVA: 0x0000F449 File Offset: 0x0000D649
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

		// Token: 0x06000988 RID: 2440 RVA: 0x0000F479 File Offset: 0x0000D679
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
