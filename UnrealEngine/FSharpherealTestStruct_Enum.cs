using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020007F3 RID: 2035
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/SharpherealTest.SharpherealTestStruct_Enum")]
	[UnrealStructLayout(368, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 368)]
	public class FSharpherealTestStruct_Enum : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600AE6E RID: 44654 RVA: 0x00102C24 File Offset: 0x00100E24
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSharpherealTestStruct_Enum._ScriptStructPtr != 0) ? FSharpherealTestStruct_Enum._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SharpherealTest.SharpherealTestStruct_Enum", ref FSharpherealTestStruct_Enum._ScriptStructPtr);
		}

		// Token: 0x1700209A RID: 8346
		// (get) Token: 0x0600AE6F RID: 44655 RVA: 0x00102C48 File Offset: 0x00100E48
		// (set) Token: 0x0600AE70 RID: 44656 RVA: 0x00102C5C File Offset: 0x00100E5C
		[Nullable(0)]
		public unsafe TEnumAsByte<FSharpherealTestCEnum> EnumAsByte
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)FSharpherealTestStruct_Enum.__PropertyOffset_EnumAsByte);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)FSharpherealTestStruct_Enum.__PropertyOffset_EnumAsByte) = value;
			}
		}

		// Token: 0x1700209B RID: 8347
		// (get) Token: 0x0600AE71 RID: 44657 RVA: 0x00102C71 File Offset: 0x00100E71
		// (set) Token: 0x0600AE72 RID: 44658 RVA: 0x00102C81 File Offset: 0x00100E81
		public unsafe FSharpherealTestEnum Enum
		{
			get
			{
				return (FSharpherealTestEnum)(*(base.NativePtr + (IntPtr)FSharpherealTestStruct_Enum.__PropertyOffset_Enum));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSharpherealTestStruct_Enum.__PropertyOffset_Enum) = (byte)value;
			}
		}

		// Token: 0x1700209C RID: 8348
		// (get) Token: 0x0600AE73 RID: 44659 RVA: 0x00102C94 File Offset: 0x00100E94
		// (set) Token: 0x0600AE74 RID: 44660 RVA: 0x00102CD7 File Offset: 0x00100ED7
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TArray<TEnumAsByte<FSharpherealTestCEnum>> EnumAsByteArray
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TEnumAsByte<FSharpherealTestCEnum>> result;
				if ((result = this._EnumAsByteArray) == null)
				{
					result = (this._EnumAsByteArray = new TArray<TEnumAsByte<FSharpherealTestCEnum>>(base.NativePtr + (IntPtr)FSharpherealTestStruct_Enum.__PropertyOffset_EnumAsByteArray, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.EnumAsByteArray.CopyAssign(value);
			}
		}

		// Token: 0x1700209D RID: 8349
		// (get) Token: 0x0600AE75 RID: 44661 RVA: 0x00102CE8 File Offset: 0x00100EE8
		// (set) Token: 0x0600AE76 RID: 44662 RVA: 0x00102D2B File Offset: 0x00100F2B
		public TArray<FSharpherealTestEnum> EnumArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSharpherealTestEnum> result;
				if ((result = this._EnumArray) == null)
				{
					result = (this._EnumArray = new TArray<FSharpherealTestEnum>(base.NativePtr + (IntPtr)FSharpherealTestStruct_Enum.__PropertyOffset_EnumArray, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.EnumArray.CopyAssign(value);
			}
		}

		// Token: 0x1700209E RID: 8350
		// (get) Token: 0x0600AE77 RID: 44663 RVA: 0x00102D3C File Offset: 0x00100F3C
		// (set) Token: 0x0600AE78 RID: 44664 RVA: 0x00102D80 File Offset: 0x00100F80
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TFixedArray<TEnumAsByte<FSharpherealTestCEnum>> EnumAsByteFixedArray
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TFixedArray<TEnumAsByte<FSharpherealTestCEnum>> result;
				if ((result = this._EnumAsByteFixedArray) == null)
				{
					result = (this._EnumAsByteFixedArray = new TFixedArray<TEnumAsByte<FSharpherealTestCEnum>>(base.NativePtr + (IntPtr)FSharpherealTestStruct_Enum.__PropertyOffset_EnumAsByteFixedArray, 2, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.EnumAsByteFixedArray.CopyAssign(value);
			}
		}

		// Token: 0x1700209F RID: 8351
		// (get) Token: 0x0600AE79 RID: 44665 RVA: 0x00102D90 File Offset: 0x00100F90
		// (set) Token: 0x0600AE7A RID: 44666 RVA: 0x00102DD4 File Offset: 0x00100FD4
		public TFixedArray<FSharpherealTestEnum> EnumFixedArray
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<FSharpherealTestEnum> result;
				if ((result = this._EnumFixedArray) == null)
				{
					result = (this._EnumFixedArray = new TFixedArray<FSharpherealTestEnum>(base.NativePtr + (IntPtr)FSharpherealTestStruct_Enum.__PropertyOffset_EnumFixedArray, 2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.EnumFixedArray.CopyAssign(value);
			}
		}

		// Token: 0x170020A0 RID: 8352
		// (get) Token: 0x0600AE7B RID: 44667 RVA: 0x00102DE4 File Offset: 0x00100FE4
		// (set) Token: 0x0600AE7C RID: 44668 RVA: 0x00102E27 File Offset: 0x00101027
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TSet<TEnumAsByte<FSharpherealTestCEnum>> EnumAsByteSet
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TSet<TEnumAsByte<FSharpherealTestCEnum>> result;
				if ((result = this._EnumAsByteSet) == null)
				{
					result = (this._EnumAsByteSet = new TSet<TEnumAsByte<FSharpherealTestCEnum>>(base.NativePtr + (IntPtr)FSharpherealTestStruct_Enum.__PropertyOffset_EnumAsByteSet, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.EnumAsByteSet.CopyAssign(value);
			}
		}

		// Token: 0x170020A1 RID: 8353
		// (get) Token: 0x0600AE7D RID: 44669 RVA: 0x00102E38 File Offset: 0x00101038
		// (set) Token: 0x0600AE7E RID: 44670 RVA: 0x00102E7B File Offset: 0x0010107B
		public TSet<FSharpherealTestEnum> EnumSet
		{
			get
			{
				base.FastCheckIsValid();
				TSet<FSharpherealTestEnum> result;
				if ((result = this._EnumSet) == null)
				{
					result = (this._EnumSet = new TSet<FSharpherealTestEnum>(base.NativePtr + (IntPtr)FSharpherealTestStruct_Enum.__PropertyOffset_EnumSet, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.EnumSet.CopyAssign(value);
			}
		}

		// Token: 0x170020A2 RID: 8354
		// (get) Token: 0x0600AE7F RID: 44671 RVA: 0x00102E8C File Offset: 0x0010108C
		// (set) Token: 0x0600AE80 RID: 44672 RVA: 0x00102ECF File Offset: 0x001010CF
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TMap<TEnumAsByte<FSharpherealTestCEnum>, int> EnumAsByteMap
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TEnumAsByte<FSharpherealTestCEnum>, int> result;
				if ((result = this._EnumAsByteMap) == null)
				{
					result = (this._EnumAsByteMap = new TMap<TEnumAsByte<FSharpherealTestCEnum>, int>(base.NativePtr + (IntPtr)FSharpherealTestStruct_Enum.__PropertyOffset_EnumAsByteMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.EnumAsByteMap.CopyAssign(value);
			}
		}

		// Token: 0x170020A3 RID: 8355
		// (get) Token: 0x0600AE81 RID: 44673 RVA: 0x00102EE0 File Offset: 0x001010E0
		// (set) Token: 0x0600AE82 RID: 44674 RVA: 0x00102F23 File Offset: 0x00101123
		public TMap<FSharpherealTestEnum, int> EnumMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FSharpherealTestEnum, int> result;
				if ((result = this._EnumMap) == null)
				{
					result = (this._EnumMap = new TMap<FSharpherealTestEnum, int>(base.NativePtr + (IntPtr)FSharpherealTestStruct_Enum.__PropertyOffset_EnumMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.EnumMap.CopyAssign(value);
			}
		}

		// Token: 0x0600AE83 RID: 44675 RVA: 0x00102F31 File Offset: 0x00101131
		public FSharpherealTestStruct_Enum()
		{
		}

		// Token: 0x0600AE84 RID: 44676 RVA: 0x00102F39 File Offset: 0x00101139
		protected override IntPtr GetUStructPtr()
		{
			return FSharpherealTestStruct_Enum.StaticStruct();
		}

		// Token: 0x0600AE85 RID: 44677 RVA: 0x00102F45 File Offset: 0x00101145
		[NullableContext(2)]
		public FSharpherealTestStruct_Enum(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600AE86 RID: 44678 RVA: 0x00102F4F File Offset: 0x0010114F
		public FSharpherealTestStruct_Enum(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600AE87 RID: 44679 RVA: 0x00102F5A File Offset: 0x0010115A
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSharpherealTestStruct_Enum(Pointer, false, true);
		}

		// Token: 0x0600AE88 RID: 44680 RVA: 0x00102F64 File Offset: 0x00101164
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSharpherealTestStruct_Enum(Pointer, MemoryOwner);
		}

		// Token: 0x04004B8A RID: 19338
		public const string __ObjectPath = "/Script/SharpherealTest.SharpherealTestStruct_Enum";

		// Token: 0x04004B8B RID: 19339
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04004B8C RID: 19340
		internal static int __PropertyOffset_EnumAsByte;

		// Token: 0x04004B8D RID: 19341
		internal static int __PropertyOffset_Enum;

		// Token: 0x04004B8E RID: 19342
		internal static int __PropertyOffset_EnumAsByteArray;

		// Token: 0x04004B8F RID: 19343
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<FSharpherealTestCEnum>> _EnumAsByteArray;

		// Token: 0x04004B90 RID: 19344
		internal static int __PropertyOffset_EnumArray;

		// Token: 0x04004B91 RID: 19345
		[Nullable(2)]
		private TArray<FSharpherealTestEnum> _EnumArray;

		// Token: 0x04004B92 RID: 19346
		internal static int __PropertyOffset_EnumAsByteFixedArray;

		// Token: 0x04004B93 RID: 19347
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TFixedArray<TEnumAsByte<FSharpherealTestCEnum>> _EnumAsByteFixedArray;

		// Token: 0x04004B94 RID: 19348
		internal static int __PropertyOffset_EnumFixedArray;

		// Token: 0x04004B95 RID: 19349
		[Nullable(2)]
		private TFixedArray<FSharpherealTestEnum> _EnumFixedArray;

		// Token: 0x04004B96 RID: 19350
		internal static int __PropertyOffset_EnumAsByteSet;

		// Token: 0x04004B97 RID: 19351
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TSet<TEnumAsByte<FSharpherealTestCEnum>> _EnumAsByteSet;

		// Token: 0x04004B98 RID: 19352
		internal static int __PropertyOffset_EnumSet;

		// Token: 0x04004B99 RID: 19353
		[Nullable(2)]
		private TSet<FSharpherealTestEnum> _EnumSet;

		// Token: 0x04004B9A RID: 19354
		internal static int __PropertyOffset_EnumAsByteMap;

		// Token: 0x04004B9B RID: 19355
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<FSharpherealTestCEnum>, int> _EnumAsByteMap;

		// Token: 0x04004B9C RID: 19356
		internal static int __PropertyOffset_EnumMap;

		// Token: 0x04004B9D RID: 19357
		[Nullable(2)]
		private TMap<FSharpherealTestEnum, int> _EnumMap;
	}
}
