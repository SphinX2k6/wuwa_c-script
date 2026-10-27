using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000087 RID: 135
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.String)]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.String, PropertiesSize = 16)]
	[StructLayout(LayoutKind.Explicit, Pack = 8, Size = 16)]
	public readonly struct FString : IEqualityOperators<FString, FString, bool>, IEquatable<FString>
	{
		// Token: 0x06000F47 RID: 3911
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe static extern FString* Alloc(in FCSharpStringView Src);

		// Token: 0x06000F48 RID: 3912 RVA: 0x00016CDC File Offset: 0x00014EDC
		[NullableContext(1)]
		public unsafe static FString AllocTemp(string Src)
		{
			FString result;
			FString.CopyFrom((void*)(&result), Src);
			return result;
		}

		// Token: 0x06000F49 RID: 3913
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe static extern void Delete(FString* Ptr);

		// Token: 0x06000F4A RID: 3914
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe static extern void NativeConstruct(FString* Dest, int ArrDim = 1);

		// Token: 0x06000F4B RID: 3915
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe static extern void NativeDestruct(FString* Dest, int ArrDim = 1);

		// Token: 0x06000F4C RID: 3916
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe static extern void NativeCopy(FString* Dest, FString* Src, int Count = 1);

		// Token: 0x06000F4D RID: 3917 RVA: 0x00016CF4 File Offset: 0x00014EF4
		public unsafe static void CopyFrom(void* Dest, [Nullable(2)] string Src)
		{
			FCSharpStringView fcsharpStringView;
			if (Src == null || Src.Length == 0)
			{
				fcsharpStringView = default(FCSharpStringView);
				FString.CopyFromStringView(Dest, fcsharpStringView);
				return;
			}
			char* ptr;
			if (Src == null)
			{
				ptr = null;
			}
			else
			{
				fixed (char* ptr2 = Src.GetPinnableReference())
				{
					ptr = ptr2;
				}
			}
			char* ptr3 = ptr;
			fcsharpStringView = new FCSharpStringView(ptr3, Src.Length);
			FString.CopyFromStringView(Dest, fcsharpStringView);
			char* ptr2 = null;
		}

		// Token: 0x06000F4E RID: 3918
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern void CopyFromStringView(void* Dest, in FCSharpStringView Src);

		// Token: 0x06000F4F RID: 3919
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int FindIndex(IntPtr Arr, int ArrDim, in FCSharpStringView Value);

		// Token: 0x06000F50 RID: 3920 RVA: 0x00016D45 File Offset: 0x00014F45
		[return: Nullable(1)]
		public unsafe static string ToString(void* NativePtr)
		{
			return ((FString*)NativePtr)->ToString();
		}

		// Token: 0x06000F51 RID: 3921 RVA: 0x00016D53 File Offset: 0x00014F53
		[NullableContext(1)]
		public static string ToString(in FString NativePtr)
		{
			return NativePtr.ToString();
		}

		// Token: 0x06000F52 RID: 3922 RVA: 0x00016D61 File Offset: 0x00014F61
		[return: Nullable(1)]
		public unsafe static string ToStringAndDeleteNativePtr(FString* NativePtr)
		{
			string result = FString.ToString((void*)NativePtr);
			FString.Delete(NativePtr);
			return result;
		}

		// Token: 0x06000F53 RID: 3923
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern bool Equals(FString* A, FString* B);

		// Token: 0x06000F54 RID: 3924 RVA: 0x00016D70 File Offset: 0x00014F70
		public unsafe bool Equals(FString other)
		{
			fixed (FString* ptr = &this)
			{
				return FString.Equals(ptr, &other);
			}
		}

		// Token: 0x06000F55 RID: 3925 RVA: 0x00016D89 File Offset: 0x00014F89
		[NullableContext(1)]
		public override string ToString()
		{
			if (this.ArrayNum <= 1)
			{
				return string.Empty;
			}
			return new string(this.Data, 0, this.ArrayNum - 1);
		}

		// Token: 0x06000F56 RID: 3926 RVA: 0x00016DAE File Offset: 0x00014FAE
		[NullableContext(1)]
		public static implicit operator string(in FString UnrealString)
		{
			return UnrealString.ToString();
		}

		// Token: 0x06000F57 RID: 3927 RVA: 0x00016DBC File Offset: 0x00014FBC
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FString)
			{
				FString other = (FString)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06000F58 RID: 3928 RVA: 0x00016DE1 File Offset: 0x00014FE1
		public override int GetHashCode()
		{
			if (this.Data == IntPtr.Zero || this.ArrayNum == 0)
			{
				return 0;
			}
			return string.GetHashCode(new ReadOnlySpan<char>(this.Data, this.ArrayNum));
		}

		// Token: 0x06000F59 RID: 3929 RVA: 0x00016E10 File Offset: 0x00015010
		public static bool operator ==(FString left, FString right)
		{
			return left.Equals(right);
		}

		// Token: 0x06000F5A RID: 3930 RVA: 0x00016E1A File Offset: 0x0001501A
		public static bool operator !=(FString left, FString right)
		{
			return !left.Equals(right);
		}

		// Token: 0x06000F5B RID: 3931 RVA: 0x00016E27 File Offset: 0x00015027
		public bool IsEmpty()
		{
			return this.ArrayNum <= 1;
		}

		// Token: 0x040001D6 RID: 470
		[FieldOffset(0)]
		private readonly IntPtr Data;

		// Token: 0x040001D7 RID: 471
		[FieldOffset(8)]
		public readonly int ArrayNum;

		// Token: 0x040001D8 RID: 472
		[FieldOffset(12)]
		public readonly int ArrayMax;
	}
}
