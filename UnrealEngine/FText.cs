using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000089 RID: 137
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.Text, PropertiesSize = 24)]
	public class FText : UnrealProxyObject
	{
		// Token: 0x06000F5C RID: 3932
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern void* AllocText();

		// Token: 0x06000F5D RID: 3933
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void DeallocText(IntPtr NativePtr);

		// Token: 0x06000F5E RID: 3934
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void NativeConstruct(IntPtr Src, int Num = 1);

		// Token: 0x06000F5F RID: 3935
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void NativeDestruct(IntPtr Src, int Num = 1);

		// Token: 0x06000F60 RID: 3936
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe static extern void NativeCopy(void* Dest, void* Src, int Num = 1);

		// Token: 0x06000F61 RID: 3937
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe static extern void NativeMove(void* Dest, void* Src);

		// Token: 0x06000F62 RID: 3938
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int FindIndex(IntPtr Arr, int Num, IntPtr Value);

		// Token: 0x06000F63 RID: 3939 RVA: 0x00016E35 File Offset: 0x00015035
		protected override IntPtr AllocNativePtr()
		{
			return FText.AllocText();
		}

		// Token: 0x06000F64 RID: 3940 RVA: 0x00016E3C File Offset: 0x0001503C
		protected override void DeallocNativePtr()
		{
			FText.DeallocText(this._NativePtr);
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06000F65 RID: 3941 RVA: 0x00016E49 File Offset: 0x00015049
		public override bool AllowMoveAssign
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000F66 RID: 3942 RVA: 0x00016E4C File Offset: 0x0001504C
		public override void MoveAssign(IntPtr FromNativePtr)
		{
			FText.NativeMove(base.NativePtr, FromNativePtr);
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06000F67 RID: 3943 RVA: 0x00016E5A File Offset: 0x0001505A
		public override bool AllowCopyAssign
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000F68 RID: 3944 RVA: 0x00016E5D File Offset: 0x0001505D
		public override void CopyAssign(IntPtr FromNativePtr)
		{
			FText.NativeCopy(base.NativePtr, FromNativePtr, 1);
		}

		// Token: 0x06000F69 RID: 3945 RVA: 0x00016E6C File Offset: 0x0001506C
		public FText()
		{
		}

		// Token: 0x06000F6A RID: 3946 RVA: 0x00016E74 File Offset: 0x00015074
		public FText(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06000F6B RID: 3947 RVA: 0x00016E7E File Offset: 0x0001507E
		public FText(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06000F6C RID: 3948 RVA: 0x00016E8C File Offset: 0x0001508C
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

		// Token: 0x06000F6D RID: 3949 RVA: 0x00016ED8 File Offset: 0x000150D8
		[NullableContext(1)]
		public override string ToString()
		{
			if (this._NativePtr == 0)
			{
				return "(null)";
			}
			return FText.ToString(base.NativePtr);
		}

		// Token: 0x06000F6E RID: 3950 RVA: 0x00016EF4 File Offset: 0x000150F4
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

		// Token: 0x06000F6F RID: 3951
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern string ToString(IntPtr TextPtr);

		// Token: 0x06000F70 RID: 3952
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void FromString(IntPtr TextPtr, in FCSharpStringView view);

		// Token: 0x06000F71 RID: 3953 RVA: 0x00016F4C File Offset: 0x0001514C
		public override void CopyTo(IntPtr DestPtr, UScriptStructStackOnlyPtr NativeUStructPtr = default(UScriptStructStackOnlyPtr))
		{
			FText.NativeCopy(DestPtr, base.NativePtr, 1);
		}

		// Token: 0x06000F72 RID: 3954 RVA: 0x00016F5B File Offset: 0x0001515B
		[NullableContext(1)]
		public static implicit operator FText([Nullable(2)] string String)
		{
			if (String == null)
			{
				String = string.Empty;
			}
			return new FText(String);
		}

		// Token: 0x06000F73 RID: 3955
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int EqualTo(IntPtr TextA, IntPtr TextB, ETextComparisonLevel ComparisonLevel = ETextComparisonLevel.Default);

		// Token: 0x06000F74 RID: 3956 RVA: 0x00016F70 File Offset: 0x00015170
		public static bool operator ==(FText A, FText B)
		{
			return A == B || (A != null && B != null && (A._NativePtr == B._NativePtr || (A._NativePtr != IntPtr.Zero && B._NativePtr != IntPtr.Zero && FText.EqualTo(A.NativePtr, B.NativePtr, ETextComparisonLevel.Default) == 0)));
		}

		// Token: 0x06000F75 RID: 3957 RVA: 0x00016FCC File Offset: 0x000151CC
		public static bool operator !=(FText A, FText B)
		{
			return !(A == B);
		}

		// Token: 0x06000F76 RID: 3958 RVA: 0x00016FD8 File Offset: 0x000151D8
		public override bool Equals(object Obj)
		{
			FText ftext = Obj as FText;
			return ftext != null && this == ftext;
		}

		// Token: 0x040001E0 RID: 480
		[Nullable(1)]
		public static FText Empty = new FText();
	}
}
