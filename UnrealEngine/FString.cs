using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200006C RID: 108
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.String)]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.String, PropertiesSize = 16)]
	[StructLayout(LayoutKind.Explicit, Pack = 8, Size = 16)]
	public readonly struct FString : IEqualityOperators<FString, FString, bool>, IEquatable<FString>
	{
		// Token: 0x06000ADA RID: 2778
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe static extern FString* Alloc(in FCSharpStringView Src);

		// Token: 0x06000ADB RID: 2779 RVA: 0x00011A00 File Offset: 0x0000FC00
		[NullableContext(1)]
		public unsafe static FString AllocTemp(string Src)
		{
			FString result;
			FString.CopyFrom((void*)(&result), Src);
			return result;
		}

		// Token: 0x06000ADC RID: 2780
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe static extern void Delete(FString* Ptr);

		// Token: 0x06000ADD RID: 2781
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe static extern void NativeConstruct(FString* Dest, int ArrDim = 1);

		// Token: 0x06000ADE RID: 2782
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe static extern void NativeDestruct(FString* Dest, int ArrDim = 1);

		// Token: 0x06000ADF RID: 2783
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe static extern void NativeCopy(FString* Dest, FString* Src, int Count = 1);

		// Token: 0x06000AE0 RID: 2784 RVA: 0x00011A18 File Offset: 0x0000FC18
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

		// Token: 0x06000AE1 RID: 2785
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern void CopyFromStringView(void* Dest, in FCSharpStringView Src);

		// Token: 0x06000AE2 RID: 2786
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int FindIndex(IntPtr Arr, int ArrDim, in FCSharpStringView Value);

		// Token: 0x06000AE3 RID: 2787 RVA: 0x00011A69 File Offset: 0x0000FC69
		[return: Nullable(1)]
		public unsafe static string ToString(void* NativePtr)
		{
			return ((FString*)NativePtr)->ToString();
		}

		// Token: 0x06000AE4 RID: 2788 RVA: 0x00011A77 File Offset: 0x0000FC77
		[NullableContext(1)]
		public static string ToString(in FString NativePtr)
		{
			return NativePtr.ToString();
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x00011A85 File Offset: 0x0000FC85
		[return: Nullable(1)]
		public unsafe static string ToStringAndDeleteNativePtr(FString* NativePtr)
		{
			string result = FString.ToString((void*)NativePtr);
			FString.Delete(NativePtr);
			return result;
		}

		// Token: 0x06000AE6 RID: 2790
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern bool Equals(FString* A, FString* B);

		// Token: 0x06000AE7 RID: 2791 RVA: 0x00011A94 File Offset: 0x0000FC94
		public unsafe bool Equals(FString other)
		{
			fixed (FString* ptr = &this)
			{
				return FString.Equals(ptr, &other);
			}
		}

		// Token: 0x06000AE8 RID: 2792 RVA: 0x00011AAD File Offset: 0x0000FCAD
		[NullableContext(1)]
		public override string ToString()
		{
			if (this.ArrayNum <= 1)
			{
				return string.Empty;
			}
			return new string(this.Data, 0, this.ArrayNum - 1);
		}

		// Token: 0x06000AE9 RID: 2793 RVA: 0x00011AD2 File Offset: 0x0000FCD2
		[NullableContext(1)]
		public static implicit operator string(in FString UnrealString)
		{
			return UnrealString.ToString();
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x00011AE0 File Offset: 0x0000FCE0
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

		// Token: 0x06000AEB RID: 2795 RVA: 0x00011B05 File Offset: 0x0000FD05
		public override int GetHashCode()
		{
			if (this.Data == IntPtr.Zero || this.ArrayNum == 0)
			{
				return 0;
			}
			return string.GetHashCode(new ReadOnlySpan<char>(this.Data, this.ArrayNum));
		}

		// Token: 0x06000AEC RID: 2796 RVA: 0x00011B34 File Offset: 0x0000FD34
		public static bool operator ==(FString left, FString right)
		{
			return left.Equals(right);
		}

		// Token: 0x06000AED RID: 2797 RVA: 0x00011B3E File Offset: 0x0000FD3E
		public static bool operator !=(FString left, FString right)
		{
			return !left.Equals(right);
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x00011B4B File Offset: 0x0000FD4B
		public bool IsEmpty()
		{
			return this.ArrayNum <= 1;
		}

		// Token: 0x0400018F RID: 399
		[FieldOffset(0)]
		private readonly IntPtr Data;

		// Token: 0x04000190 RID: 400
		[FieldOffset(8)]
		public readonly int ArrayNum;

		// Token: 0x04000191 RID: 401
		[FieldOffset(12)]
		public readonly int ArrayMax;
	}
}
