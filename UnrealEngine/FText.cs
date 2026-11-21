using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200006E RID: 110
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.Text, PropertiesSize = 24)]
	public class FText : UnrealProxyObject
	{
		// Token: 0x06000AEF RID: 2799
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern void* AllocText();

		// Token: 0x06000AF0 RID: 2800
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void DeallocText(IntPtr NativePtr);

		// Token: 0x06000AF1 RID: 2801
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void NativeConstruct(IntPtr Src, int Num = 1);

		// Token: 0x06000AF2 RID: 2802
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void NativeDestruct(IntPtr Src, int Num = 1);

		// Token: 0x06000AF3 RID: 2803
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe static extern void NativeCopy(void* Dest, void* Src, int Num = 1);

		// Token: 0x06000AF4 RID: 2804
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe static extern void NativeMove(void* Dest, void* Src);

		// Token: 0x06000AF5 RID: 2805
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int FindIndex(IntPtr Arr, int Num, IntPtr Value);

		// Token: 0x06000AF6 RID: 2806 RVA: 0x00011B59 File Offset: 0x0000FD59
		protected override IntPtr AllocNativePtr()
		{
			return FText.AllocText();
		}

		// Token: 0x06000AF7 RID: 2807 RVA: 0x00011B60 File Offset: 0x0000FD60
		protected override void DeallocNativePtr()
		{
			FText.DeallocText(this._NativePtr);
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000AF8 RID: 2808 RVA: 0x00011B6D File Offset: 0x0000FD6D
		public override bool AllowMoveAssign
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000AF9 RID: 2809 RVA: 0x00011B70 File Offset: 0x0000FD70
		public override void MoveAssign(IntPtr FromNativePtr)
		{
			FText.NativeMove(base.NativePtr, FromNativePtr);
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000AFA RID: 2810 RVA: 0x00011B7E File Offset: 0x0000FD7E
		public override bool AllowCopyAssign
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000AFB RID: 2811 RVA: 0x00011B81 File Offset: 0x0000FD81
		public override void CopyAssign(IntPtr FromNativePtr)
		{
			FText.NativeCopy(base.NativePtr, FromNativePtr, 1);
		}

		// Token: 0x06000AFC RID: 2812 RVA: 0x00011B90 File Offset: 0x0000FD90
		public FText()
		{
		}

		// Token: 0x06000AFD RID: 2813 RVA: 0x00011B98 File Offset: 0x0000FD98
		public FText(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06000AFE RID: 2814 RVA: 0x00011BA2 File Offset: 0x0000FDA2
		public FText(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06000AFF RID: 2815 RVA: 0x00011BB0 File Offset: 0x0000FDB0
		public unsafe FText(string Text)
		{
			if (Text != null && Text.Length != 0)
			{
				char* ptr;
				if (Text == null)
				{
					ptr = null;
				}
				else
				{
					fixed (char* ptr2 = Text.GetPinnableReference())
					{
						ptr = ptr2;
					}
				}
				char* ptr3 = ptr;
				IntPtr nativePtr = base.NativePtr;
				FCSharpStringView fcsharpStringView = new FCSharpStringView(ptr3, Text.Length);
				FText.FromString(nativePtr, fcsharpStringView);
				char* ptr2 = null;
			}
		}

		// Token: 0x06000B00 RID: 2816 RVA: 0x00011BFC File Offset: 0x0000FDFC
		[NullableContext(1)]
		public override string ToString()
		{
			if (this._NativePtr == 0)
			{
				return "(null)";
			}
			return FText.ToString(base.NativePtr);
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x00011C18 File Offset: 0x0000FE18
		public unsafe void FromString(string Text)
		{
			FCSharpStringView fcsharpStringView;
			if (!string.IsNullOrEmpty(Text))
			{
				char* ptr;
				if (Text == null)
				{
					ptr = null;
				}
				else
				{
					fixed (char* ptr2 = Text.GetPinnableReference())
					{
						ptr = ptr2;
					}
				}
				char* ptr3 = ptr;
				IntPtr nativePtr = base.NativePtr;
				fcsharpStringView = new FCSharpStringView(ptr3, Text.Length);
				FText.FromString(nativePtr, fcsharpStringView);
				char* ptr2 = null;
				return;
			}
			IntPtr nativePtr2 = base.NativePtr;
			fcsharpStringView = default(FCSharpStringView);
			FText.FromString(nativePtr2, fcsharpStringView);
		}

		// Token: 0x06000B02 RID: 2818
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern string ToString(IntPtr TextPtr);

		// Token: 0x06000B03 RID: 2819
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void FromString(IntPtr TextPtr, in FCSharpStringView view);

		// Token: 0x06000B04 RID: 2820 RVA: 0x00011C70 File Offset: 0x0000FE70
		public override void CopyTo(IntPtr DestPtr, UScriptStructStackOnlyPtr NativeUStructPtr = default(UScriptStructStackOnlyPtr))
		{
			FText.NativeCopy(DestPtr, base.NativePtr, 1);
		}

		// Token: 0x06000B05 RID: 2821 RVA: 0x00011C7F File Offset: 0x0000FE7F
		[NullableContext(1)]
		public static implicit operator FText([Nullable(2)] string String)
		{
			if (String == null)
			{
				String = string.Empty;
			}
			return new FText(String);
		}

		// Token: 0x06000B06 RID: 2822
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int EqualTo(IntPtr TextA, IntPtr TextB, ETextComparisonLevel ComparisonLevel = ETextComparisonLevel.Default);

		// Token: 0x06000B07 RID: 2823 RVA: 0x00011C94 File Offset: 0x0000FE94
		public static bool operator ==(FText A, FText B)
		{
			return A == B || (A != null && B != null && (A._NativePtr == B._NativePtr || (A._NativePtr != IntPtr.Zero && B._NativePtr != IntPtr.Zero && FText.EqualTo(A.NativePtr, B.NativePtr, ETextComparisonLevel.Default) == 0)));
		}

		// Token: 0x06000B08 RID: 2824 RVA: 0x00011CF0 File Offset: 0x0000FEF0
		public static bool operator !=(FText A, FText B)
		{
			return !(A == B);
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x00011CFC File Offset: 0x0000FEFC
		public override bool Equals(object Obj)
		{
			FText ftext = Obj as FText;
			return ftext != null && this == ftext;
		}

		// Token: 0x04000199 RID: 409
		[Nullable(1)]
		public static FText Empty = new FText();
	}
}
