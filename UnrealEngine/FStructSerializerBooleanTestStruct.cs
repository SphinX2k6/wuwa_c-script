using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200271D RID: 10013
	[UnrealObjectPath("/Script/Serialization.StructSerializerBooleanTestStruct")]
	[UnrealStructLayout(3, 1, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 3)]
	public class FStructSerializerBooleanTestStruct : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602517C RID: 151932 RVA: 0x0036EE0A File Offset: 0x0036D00A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FStructSerializerBooleanTestStruct._ScriptStructPtr != 0) ? FStructSerializerBooleanTestStruct._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Serialization.StructSerializerBooleanTestStruct", ref FStructSerializerBooleanTestStruct._ScriptStructPtr);
		}

		// Token: 0x17008F1B RID: 36635
		// (get) Token: 0x0602517D RID: 151933 RVA: 0x0036EE2E File Offset: 0x0036D02E
		// (set) Token: 0x0602517E RID: 151934 RVA: 0x0036EE3E File Offset: 0x0036D03E
		public unsafe bool BoolFalse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStructSerializerBooleanTestStruct.__PropertyOffset_BoolFalse) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStructSerializerBooleanTestStruct.__PropertyOffset_BoolFalse) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008F1C RID: 36636
		// (get) Token: 0x0602517F RID: 151935 RVA: 0x0036EE4F File Offset: 0x0036D04F
		// (set) Token: 0x06025180 RID: 151936 RVA: 0x0036EE5F File Offset: 0x0036D05F
		public unsafe bool BoolTrue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStructSerializerBooleanTestStruct.__PropertyOffset_BoolTrue) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStructSerializerBooleanTestStruct.__PropertyOffset_BoolTrue) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008F1D RID: 36637
		// (get) Token: 0x06025181 RID: 151937 RVA: 0x0036EE70 File Offset: 0x0036D070
		// (set) Token: 0x06025182 RID: 151938 RVA: 0x0036EE89 File Offset: 0x0036D089
		public unsafe bool Bitfield0
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FStructSerializerBooleanTestStruct.__PropertyOffset_Bitfield0) & FStructSerializerBooleanTestStruct.__PropertyMask_Bitfield0) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FStructSerializerBooleanTestStruct.__PropertyOffset_Bitfield0) = ((*(base.NativePtr + (IntPtr)FStructSerializerBooleanTestStruct.__PropertyOffset_Bitfield0) & ~FStructSerializerBooleanTestStruct.__PropertyMask_Bitfield0) | (value ? FStructSerializerBooleanTestStruct.__PropertyMask_Bitfield0 : 0));
			}
		}

		// Token: 0x17008F1E RID: 36638
		// (get) Token: 0x06025183 RID: 151939 RVA: 0x0036EEB9 File Offset: 0x0036D0B9
		// (set) Token: 0x06025184 RID: 151940 RVA: 0x0036EED2 File Offset: 0x0036D0D2
		public unsafe bool Bitfield1
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FStructSerializerBooleanTestStruct.__PropertyOffset_Bitfield1) & FStructSerializerBooleanTestStruct.__PropertyMask_Bitfield1) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FStructSerializerBooleanTestStruct.__PropertyOffset_Bitfield1) = ((*(base.NativePtr + (IntPtr)FStructSerializerBooleanTestStruct.__PropertyOffset_Bitfield1) & ~FStructSerializerBooleanTestStruct.__PropertyMask_Bitfield1) | (value ? FStructSerializerBooleanTestStruct.__PropertyMask_Bitfield1 : 0));
			}
		}

		// Token: 0x17008F1F RID: 36639
		// (get) Token: 0x06025185 RID: 151941 RVA: 0x0036EF02 File Offset: 0x0036D102
		// (set) Token: 0x06025186 RID: 151942 RVA: 0x0036EF1B File Offset: 0x0036D11B
		public unsafe bool Bitfield2Set
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FStructSerializerBooleanTestStruct.__PropertyOffset_Bitfield2Set) & FStructSerializerBooleanTestStruct.__PropertyMask_Bitfield2Set) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FStructSerializerBooleanTestStruct.__PropertyOffset_Bitfield2Set) = ((*(base.NativePtr + (IntPtr)FStructSerializerBooleanTestStruct.__PropertyOffset_Bitfield2Set) & ~FStructSerializerBooleanTestStruct.__PropertyMask_Bitfield2Set) | (value ? FStructSerializerBooleanTestStruct.__PropertyMask_Bitfield2Set : 0));
			}
		}

		// Token: 0x17008F20 RID: 36640
		// (get) Token: 0x06025187 RID: 151943 RVA: 0x0036EF4B File Offset: 0x0036D14B
		// (set) Token: 0x06025188 RID: 151944 RVA: 0x0036EF64 File Offset: 0x0036D164
		public unsafe bool Bitfield3
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FStructSerializerBooleanTestStruct.__PropertyOffset_Bitfield3) & FStructSerializerBooleanTestStruct.__PropertyMask_Bitfield3) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FStructSerializerBooleanTestStruct.__PropertyOffset_Bitfield3) = ((*(base.NativePtr + (IntPtr)FStructSerializerBooleanTestStruct.__PropertyOffset_Bitfield3) & ~FStructSerializerBooleanTestStruct.__PropertyMask_Bitfield3) | (value ? FStructSerializerBooleanTestStruct.__PropertyMask_Bitfield3 : 0));
			}
		}

		// Token: 0x17008F21 RID: 36641
		// (get) Token: 0x06025189 RID: 151945 RVA: 0x0036EF94 File Offset: 0x0036D194
		// (set) Token: 0x0602518A RID: 151946 RVA: 0x0036EFAD File Offset: 0x0036D1AD
		public unsafe bool Bitfield4Set
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FStructSerializerBooleanTestStruct.__PropertyOffset_Bitfield4Set) & FStructSerializerBooleanTestStruct.__PropertyMask_Bitfield4Set) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FStructSerializerBooleanTestStruct.__PropertyOffset_Bitfield4Set) = ((*(base.NativePtr + (IntPtr)FStructSerializerBooleanTestStruct.__PropertyOffset_Bitfield4Set) & ~FStructSerializerBooleanTestStruct.__PropertyMask_Bitfield4Set) | (value ? FStructSerializerBooleanTestStruct.__PropertyMask_Bitfield4Set : 0));
			}
		}

		// Token: 0x17008F22 RID: 36642
		// (get) Token: 0x0602518B RID: 151947 RVA: 0x0036EFDD File Offset: 0x0036D1DD
		// (set) Token: 0x0602518C RID: 151948 RVA: 0x0036EFF6 File Offset: 0x0036D1F6
		public unsafe bool Bitfield5Set
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FStructSerializerBooleanTestStruct.__PropertyOffset_Bitfield5Set) & FStructSerializerBooleanTestStruct.__PropertyMask_Bitfield5Set) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FStructSerializerBooleanTestStruct.__PropertyOffset_Bitfield5Set) = ((*(base.NativePtr + (IntPtr)FStructSerializerBooleanTestStruct.__PropertyOffset_Bitfield5Set) & ~FStructSerializerBooleanTestStruct.__PropertyMask_Bitfield5Set) | (value ? FStructSerializerBooleanTestStruct.__PropertyMask_Bitfield5Set : 0));
			}
		}

		// Token: 0x17008F23 RID: 36643
		// (get) Token: 0x0602518D RID: 151949 RVA: 0x0036F026 File Offset: 0x0036D226
		// (set) Token: 0x0602518E RID: 151950 RVA: 0x0036F03F File Offset: 0x0036D23F
		public unsafe bool Bitfield6
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FStructSerializerBooleanTestStruct.__PropertyOffset_Bitfield6) & FStructSerializerBooleanTestStruct.__PropertyMask_Bitfield6) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FStructSerializerBooleanTestStruct.__PropertyOffset_Bitfield6) = ((*(base.NativePtr + (IntPtr)FStructSerializerBooleanTestStruct.__PropertyOffset_Bitfield6) & ~FStructSerializerBooleanTestStruct.__PropertyMask_Bitfield6) | (value ? FStructSerializerBooleanTestStruct.__PropertyMask_Bitfield6 : 0));
			}
		}

		// Token: 0x17008F24 RID: 36644
		// (get) Token: 0x0602518F RID: 151951 RVA: 0x0036F06F File Offset: 0x0036D26F
		// (set) Token: 0x06025190 RID: 151952 RVA: 0x0036F088 File Offset: 0x0036D288
		public unsafe bool Bitfield7Set
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FStructSerializerBooleanTestStruct.__PropertyOffset_Bitfield7Set) & FStructSerializerBooleanTestStruct.__PropertyMask_Bitfield7Set) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FStructSerializerBooleanTestStruct.__PropertyOffset_Bitfield7Set) = ((*(base.NativePtr + (IntPtr)FStructSerializerBooleanTestStruct.__PropertyOffset_Bitfield7Set) & ~FStructSerializerBooleanTestStruct.__PropertyMask_Bitfield7Set) | (value ? FStructSerializerBooleanTestStruct.__PropertyMask_Bitfield7Set : 0));
			}
		}

		// Token: 0x06025191 RID: 151953 RVA: 0x0036F0B8 File Offset: 0x0036D2B8
		public FStructSerializerBooleanTestStruct()
		{
		}

		// Token: 0x06025192 RID: 151954 RVA: 0x0036F0C0 File Offset: 0x0036D2C0
		public FStructSerializerBooleanTestStruct(bool BoolFalse, bool BoolTrue, bool Bitfield0, bool Bitfield1, bool Bitfield2Set, bool Bitfield3, bool Bitfield4Set, bool Bitfield5Set, bool Bitfield6, bool Bitfield7Set)
		{
			this.BoolFalse = BoolFalse;
			this.BoolTrue = BoolTrue;
			this.Bitfield0 = Bitfield0;
			this.Bitfield1 = Bitfield1;
			this.Bitfield2Set = Bitfield2Set;
			this.Bitfield3 = Bitfield3;
			this.Bitfield4Set = Bitfield4Set;
			this.Bitfield5Set = Bitfield5Set;
			this.Bitfield6 = Bitfield6;
			this.Bitfield7Set = Bitfield7Set;
		}

		// Token: 0x06025193 RID: 151955 RVA: 0x0036F120 File Offset: 0x0036D320
		protected override IntPtr GetUStructPtr()
		{
			return FStructSerializerBooleanTestStruct.StaticStruct();
		}

		// Token: 0x06025194 RID: 151956 RVA: 0x0036F12C File Offset: 0x0036D32C
		[NullableContext(2)]
		public FStructSerializerBooleanTestStruct(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025195 RID: 151957 RVA: 0x0036F136 File Offset: 0x0036D336
		public FStructSerializerBooleanTestStruct(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025196 RID: 151958 RVA: 0x0036F141 File Offset: 0x0036D341
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FStructSerializerBooleanTestStruct(Pointer, false, true);
		}

		// Token: 0x06025197 RID: 151959 RVA: 0x0036F14B File Offset: 0x0036D34B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FStructSerializerBooleanTestStruct(Pointer, MemoryOwner);
		}

		// Token: 0x04013FCF RID: 81871
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Serialization.StructSerializerBooleanTestStruct";

		// Token: 0x04013FD0 RID: 81872
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013FD1 RID: 81873
		internal static int __PropertyOffset_BoolFalse;

		// Token: 0x04013FD2 RID: 81874
		internal static int __PropertyOffset_BoolTrue;

		// Token: 0x04013FD3 RID: 81875
		internal static int __PropertyOffset_Bitfield0;

		// Token: 0x04013FD4 RID: 81876
		internal static byte __PropertyMask_Bitfield0;

		// Token: 0x04013FD5 RID: 81877
		internal static int __PropertyOffset_Bitfield1;

		// Token: 0x04013FD6 RID: 81878
		internal static byte __PropertyMask_Bitfield1;

		// Token: 0x04013FD7 RID: 81879
		internal static int __PropertyOffset_Bitfield2Set;

		// Token: 0x04013FD8 RID: 81880
		internal static byte __PropertyMask_Bitfield2Set;

		// Token: 0x04013FD9 RID: 81881
		internal static int __PropertyOffset_Bitfield3;

		// Token: 0x04013FDA RID: 81882
		internal static byte __PropertyMask_Bitfield3;

		// Token: 0x04013FDB RID: 81883
		internal static int __PropertyOffset_Bitfield4Set;

		// Token: 0x04013FDC RID: 81884
		internal static byte __PropertyMask_Bitfield4Set;

		// Token: 0x04013FDD RID: 81885
		internal static int __PropertyOffset_Bitfield5Set;

		// Token: 0x04013FDE RID: 81886
		internal static byte __PropertyMask_Bitfield5Set;

		// Token: 0x04013FDF RID: 81887
		internal static int __PropertyOffset_Bitfield6;

		// Token: 0x04013FE0 RID: 81888
		internal static byte __PropertyMask_Bitfield6;

		// Token: 0x04013FE1 RID: 81889
		internal static int __PropertyOffset_Bitfield7Set;

		// Token: 0x04013FE2 RID: 81890
		internal static byte __PropertyMask_Bitfield7Set;
	}
}
