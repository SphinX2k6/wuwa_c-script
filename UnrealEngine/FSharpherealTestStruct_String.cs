using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020007F7 RID: 2039
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/SharpherealTest.SharpherealTestStruct_String")]
	[UnrealStructLayout(528, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 528)]
	public class FSharpherealTestStruct_String : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600AED6 RID: 44758 RVA: 0x001038CA File Offset: 0x00101ACA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSharpherealTestStruct_String._ScriptStructPtr != 0) ? FSharpherealTestStruct_String._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SharpherealTest.SharpherealTestStruct_String", ref FSharpherealTestStruct_String._ScriptStructPtr);
		}

		// Token: 0x170020C0 RID: 8384
		// (get) Token: 0x0600AED7 RID: 44759 RVA: 0x001038EE File Offset: 0x00101AEE
		// (set) Token: 0x0600AED8 RID: 44760 RVA: 0x00103902 File Offset: 0x00101B02
		public unsafe string String
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FSharpherealTestStruct_String.__PropertyOffset_String)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FSharpherealTestStruct_String.__PropertyOffset_String)), value);
			}
		}

		// Token: 0x170020C1 RID: 8385
		// (get) Token: 0x0600AED9 RID: 44761 RVA: 0x00103917 File Offset: 0x00101B17
		// (set) Token: 0x0600AEDA RID: 44762 RVA: 0x0010392B File Offset: 0x00101B2B
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSharpherealTestStruct_String.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSharpherealTestStruct_String.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x170020C2 RID: 8386
		// (get) Token: 0x0600AEDB RID: 44763 RVA: 0x00103940 File Offset: 0x00101B40
		// (set) Token: 0x0600AEDC RID: 44764 RVA: 0x00103983 File Offset: 0x00101B83
		public unsafe FText Text
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._Text) == null)
				{
					result = (this._Text = new FText(base.NativePtr + (IntPtr)FSharpherealTestStruct_String.__PropertyOffset_Text, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)FSharpherealTestStruct_String.__PropertyOffset_Text)), value.NativePtr, 1);
			}
		}

		// Token: 0x170020C3 RID: 8387
		// (get) Token: 0x0600AEDD RID: 44765 RVA: 0x001039A0 File Offset: 0x00101BA0
		// (set) Token: 0x0600AEDE RID: 44766 RVA: 0x001039E3 File Offset: 0x00101BE3
		public TArray<string> StringArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._StringArray) == null)
				{
					result = (this._StringArray = new TArray<string>(base.NativePtr + (IntPtr)FSharpherealTestStruct_String.__PropertyOffset_StringArray, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.StringArray.CopyAssign(value);
			}
		}

		// Token: 0x170020C4 RID: 8388
		// (get) Token: 0x0600AEDF RID: 44767 RVA: 0x001039F4 File Offset: 0x00101BF4
		// (set) Token: 0x0600AEE0 RID: 44768 RVA: 0x00103A37 File Offset: 0x00101C37
		public TArray<FName> NameArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._NameArray) == null)
				{
					result = (this._NameArray = new TArray<FName>(base.NativePtr + (IntPtr)FSharpherealTestStruct_String.__PropertyOffset_NameArray, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.NameArray.CopyAssign(value);
			}
		}

		// Token: 0x170020C5 RID: 8389
		// (get) Token: 0x0600AEE1 RID: 44769 RVA: 0x00103A48 File Offset: 0x00101C48
		// (set) Token: 0x0600AEE2 RID: 44770 RVA: 0x00103A8B File Offset: 0x00101C8B
		public TArray<FText> TextArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FText> result;
				if ((result = this._TextArray) == null)
				{
					result = (this._TextArray = new TArray<FText>(base.NativePtr + (IntPtr)FSharpherealTestStruct_String.__PropertyOffset_TextArray, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TextArray.CopyAssign(value);
			}
		}

		// Token: 0x170020C6 RID: 8390
		// (get) Token: 0x0600AEE3 RID: 44771 RVA: 0x00103A9C File Offset: 0x00101C9C
		// (set) Token: 0x0600AEE4 RID: 44772 RVA: 0x00103AE0 File Offset: 0x00101CE0
		public TFixedArray<string> StringFixedArray
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<string> result;
				if ((result = this._StringFixedArray) == null)
				{
					result = (this._StringFixedArray = new TFixedArray<string>(base.NativePtr + (IntPtr)FSharpherealTestStruct_String.__PropertyOffset_StringFixedArray, 2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.StringFixedArray.CopyAssign(value);
			}
		}

		// Token: 0x170020C7 RID: 8391
		// (get) Token: 0x0600AEE5 RID: 44773 RVA: 0x00103AF0 File Offset: 0x00101CF0
		// (set) Token: 0x0600AEE6 RID: 44774 RVA: 0x00103B34 File Offset: 0x00101D34
		public TFixedArray<FName> NameFixedArray
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<FName> result;
				if ((result = this._NameFixedArray) == null)
				{
					result = (this._NameFixedArray = new TFixedArray<FName>(base.NativePtr + (IntPtr)FSharpherealTestStruct_String.__PropertyOffset_NameFixedArray, 2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.NameFixedArray.CopyAssign(value);
			}
		}

		// Token: 0x170020C8 RID: 8392
		// (get) Token: 0x0600AEE7 RID: 44775 RVA: 0x00103B44 File Offset: 0x00101D44
		// (set) Token: 0x0600AEE8 RID: 44776 RVA: 0x00103B88 File Offset: 0x00101D88
		public TFixedArray<FText> TextFixedArray
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<FText> result;
				if ((result = this._TextFixedArray) == null)
				{
					result = (this._TextFixedArray = new TFixedArray<FText>(base.NativePtr + (IntPtr)FSharpherealTestStruct_String.__PropertyOffset_TextFixedArray, 2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TextFixedArray.CopyAssign(value);
			}
		}

		// Token: 0x170020C9 RID: 8393
		// (get) Token: 0x0600AEE9 RID: 44777 RVA: 0x00103B98 File Offset: 0x00101D98
		// (set) Token: 0x0600AEEA RID: 44778 RVA: 0x00103BDB File Offset: 0x00101DDB
		public TSet<string> StringSet
		{
			get
			{
				base.FastCheckIsValid();
				TSet<string> result;
				if ((result = this._StringSet) == null)
				{
					result = (this._StringSet = new TSet<string>(base.NativePtr + (IntPtr)FSharpherealTestStruct_String.__PropertyOffset_StringSet, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.StringSet.CopyAssign(value);
			}
		}

		// Token: 0x170020CA RID: 8394
		// (get) Token: 0x0600AEEB RID: 44779 RVA: 0x00103BEC File Offset: 0x00101DEC
		// (set) Token: 0x0600AEEC RID: 44780 RVA: 0x00103C2F File Offset: 0x00101E2F
		public TSet<FName> NameSet
		{
			get
			{
				base.FastCheckIsValid();
				TSet<FName> result;
				if ((result = this._NameSet) == null)
				{
					result = (this._NameSet = new TSet<FName>(base.NativePtr + (IntPtr)FSharpherealTestStruct_String.__PropertyOffset_NameSet, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.NameSet.CopyAssign(value);
			}
		}

		// Token: 0x170020CB RID: 8395
		// (get) Token: 0x0600AEED RID: 44781 RVA: 0x00103C40 File Offset: 0x00101E40
		// (set) Token: 0x0600AEEE RID: 44782 RVA: 0x00103C83 File Offset: 0x00101E83
		public TMap<string, int> StringMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, int> result;
				if ((result = this._StringMap) == null)
				{
					result = (this._StringMap = new TMap<string, int>(base.NativePtr + (IntPtr)FSharpherealTestStruct_String.__PropertyOffset_StringMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.StringMap.CopyAssign(value);
			}
		}

		// Token: 0x170020CC RID: 8396
		// (get) Token: 0x0600AEEF RID: 44783 RVA: 0x00103C94 File Offset: 0x00101E94
		// (set) Token: 0x0600AEF0 RID: 44784 RVA: 0x00103CD7 File Offset: 0x00101ED7
		public TMap<FName, int> NameMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, int> result;
				if ((result = this._NameMap) == null)
				{
					result = (this._NameMap = new TMap<FName, int>(base.NativePtr + (IntPtr)FSharpherealTestStruct_String.__PropertyOffset_NameMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.NameMap.CopyAssign(value);
			}
		}

		// Token: 0x0600AEF1 RID: 44785 RVA: 0x00103CE5 File Offset: 0x00101EE5
		public FSharpherealTestStruct_String()
		{
		}

		// Token: 0x0600AEF2 RID: 44786 RVA: 0x00103CED File Offset: 0x00101EED
		protected override IntPtr GetUStructPtr()
		{
			return FSharpherealTestStruct_String.StaticStruct();
		}

		// Token: 0x0600AEF3 RID: 44787 RVA: 0x00103CF9 File Offset: 0x00101EF9
		[NullableContext(2)]
		public FSharpherealTestStruct_String(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600AEF4 RID: 44788 RVA: 0x00103D03 File Offset: 0x00101F03
		public FSharpherealTestStruct_String(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600AEF5 RID: 44789 RVA: 0x00103D0E File Offset: 0x00101F0E
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSharpherealTestStruct_String(Pointer, false, true);
		}

		// Token: 0x0600AEF6 RID: 44790 RVA: 0x00103D18 File Offset: 0x00101F18
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSharpherealTestStruct_String(Pointer, MemoryOwner);
		}

		// Token: 0x04004BD5 RID: 19413
		public const string __ObjectPath = "/Script/SharpherealTest.SharpherealTestStruct_String";

		// Token: 0x04004BD6 RID: 19414
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04004BD7 RID: 19415
		internal static int __PropertyOffset_String;

		// Token: 0x04004BD8 RID: 19416
		internal static int __PropertyOffset_Name;

		// Token: 0x04004BD9 RID: 19417
		internal static int __PropertyOffset_Text;

		// Token: 0x04004BDA RID: 19418
		[Nullable(2)]
		private FText _Text;

		// Token: 0x04004BDB RID: 19419
		internal static int __PropertyOffset_StringArray;

		// Token: 0x04004BDC RID: 19420
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _StringArray;

		// Token: 0x04004BDD RID: 19421
		internal static int __PropertyOffset_NameArray;

		// Token: 0x04004BDE RID: 19422
		[Nullable(2)]
		private TArray<FName> _NameArray;

		// Token: 0x04004BDF RID: 19423
		internal static int __PropertyOffset_TextArray;

		// Token: 0x04004BE0 RID: 19424
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FText> _TextArray;

		// Token: 0x04004BE1 RID: 19425
		internal static int __PropertyOffset_StringFixedArray;

		// Token: 0x04004BE2 RID: 19426
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TFixedArray<string> _StringFixedArray;

		// Token: 0x04004BE3 RID: 19427
		internal static int __PropertyOffset_NameFixedArray;

		// Token: 0x04004BE4 RID: 19428
		[Nullable(2)]
		private TFixedArray<FName> _NameFixedArray;

		// Token: 0x04004BE5 RID: 19429
		internal static int __PropertyOffset_TextFixedArray;

		// Token: 0x04004BE6 RID: 19430
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TFixedArray<FText> _TextFixedArray;

		// Token: 0x04004BE7 RID: 19431
		internal static int __PropertyOffset_StringSet;

		// Token: 0x04004BE8 RID: 19432
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<string> _StringSet;

		// Token: 0x04004BE9 RID: 19433
		internal static int __PropertyOffset_NameSet;

		// Token: 0x04004BEA RID: 19434
		[Nullable(2)]
		private TSet<FName> _NameSet;

		// Token: 0x04004BEB RID: 19435
		internal static int __PropertyOffset_StringMap;

		// Token: 0x04004BEC RID: 19436
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, int> _StringMap;

		// Token: 0x04004BED RID: 19437
		internal static int __PropertyOffset_NameMap;

		// Token: 0x04004BEE RID: 19438
		[Nullable(2)]
		private TMap<FName, int> _NameMap;
	}
}
