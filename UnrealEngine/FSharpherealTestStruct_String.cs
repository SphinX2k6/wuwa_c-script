using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002743 RID: 10051
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/SharpherealTest.SharpherealTestStruct_String")]
	[UnrealStructLayout(528, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 528)]
	public class FSharpherealTestStruct_String : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060253F6 RID: 152566 RVA: 0x00373D04 File Offset: 0x00371F04
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSharpherealTestStruct_String._ScriptStructPtr != 0) ? FSharpherealTestStruct_String._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SharpherealTest.SharpherealTestStruct_String", ref FSharpherealTestStruct_String._ScriptStructPtr);
		}

		// Token: 0x17008FD8 RID: 36824
		// (get) Token: 0x060253F7 RID: 152567 RVA: 0x00373D28 File Offset: 0x00371F28
		// (set) Token: 0x060253F8 RID: 152568 RVA: 0x00373D3C File Offset: 0x00371F3C
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

		// Token: 0x17008FD9 RID: 36825
		// (get) Token: 0x060253F9 RID: 152569 RVA: 0x00373D51 File Offset: 0x00371F51
		// (set) Token: 0x060253FA RID: 152570 RVA: 0x00373D65 File Offset: 0x00371F65
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

		// Token: 0x17008FDA RID: 36826
		// (get) Token: 0x060253FB RID: 152571 RVA: 0x00373D7C File Offset: 0x00371F7C
		// (set) Token: 0x060253FC RID: 152572 RVA: 0x00373DBF File Offset: 0x00371FBF
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

		// Token: 0x17008FDB RID: 36827
		// (get) Token: 0x060253FD RID: 152573 RVA: 0x00373DDC File Offset: 0x00371FDC
		// (set) Token: 0x060253FE RID: 152574 RVA: 0x00373E1F File Offset: 0x0037201F
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

		// Token: 0x17008FDC RID: 36828
		// (get) Token: 0x060253FF RID: 152575 RVA: 0x00373E30 File Offset: 0x00372030
		// (set) Token: 0x06025400 RID: 152576 RVA: 0x00373E73 File Offset: 0x00372073
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

		// Token: 0x17008FDD RID: 36829
		// (get) Token: 0x06025401 RID: 152577 RVA: 0x00373E84 File Offset: 0x00372084
		// (set) Token: 0x06025402 RID: 152578 RVA: 0x00373EC7 File Offset: 0x003720C7
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

		// Token: 0x17008FDE RID: 36830
		// (get) Token: 0x06025403 RID: 152579 RVA: 0x00373ED8 File Offset: 0x003720D8
		// (set) Token: 0x06025404 RID: 152580 RVA: 0x00373F1C File Offset: 0x0037211C
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

		// Token: 0x17008FDF RID: 36831
		// (get) Token: 0x06025405 RID: 152581 RVA: 0x00373F2C File Offset: 0x0037212C
		// (set) Token: 0x06025406 RID: 152582 RVA: 0x00373F70 File Offset: 0x00372170
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

		// Token: 0x17008FE0 RID: 36832
		// (get) Token: 0x06025407 RID: 152583 RVA: 0x00373F80 File Offset: 0x00372180
		// (set) Token: 0x06025408 RID: 152584 RVA: 0x00373FC4 File Offset: 0x003721C4
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

		// Token: 0x17008FE1 RID: 36833
		// (get) Token: 0x06025409 RID: 152585 RVA: 0x00373FD4 File Offset: 0x003721D4
		// (set) Token: 0x0602540A RID: 152586 RVA: 0x00374017 File Offset: 0x00372217
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

		// Token: 0x17008FE2 RID: 36834
		// (get) Token: 0x0602540B RID: 152587 RVA: 0x00374028 File Offset: 0x00372228
		// (set) Token: 0x0602540C RID: 152588 RVA: 0x0037406B File Offset: 0x0037226B
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

		// Token: 0x17008FE3 RID: 36835
		// (get) Token: 0x0602540D RID: 152589 RVA: 0x0037407C File Offset: 0x0037227C
		// (set) Token: 0x0602540E RID: 152590 RVA: 0x003740BF File Offset: 0x003722BF
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

		// Token: 0x17008FE4 RID: 36836
		// (get) Token: 0x0602540F RID: 152591 RVA: 0x003740D0 File Offset: 0x003722D0
		// (set) Token: 0x06025410 RID: 152592 RVA: 0x00374113 File Offset: 0x00372313
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

		// Token: 0x06025411 RID: 152593 RVA: 0x00374121 File Offset: 0x00372321
		public FSharpherealTestStruct_String()
		{
		}

		// Token: 0x06025412 RID: 152594 RVA: 0x0037412C File Offset: 0x0037232C
		public FSharpherealTestStruct_String(string String, FName Name, FText Text, TArray<string> StringArray, TArray<FName> NameArray, TArray<FText> TextArray, TFixedArray<string> StringFixedArray, TFixedArray<FName> NameFixedArray, TFixedArray<FText> TextFixedArray, TSet<string> StringSet, TSet<FName> NameSet, TMap<string, int> StringMap, TMap<FName, int> NameMap)
		{
			this.String = String;
			this.Name = Name;
			this.Text = Text;
			this.StringArray = StringArray;
			this.NameArray = NameArray;
			this.TextArray = TextArray;
			this.StringFixedArray = StringFixedArray;
			this.NameFixedArray = NameFixedArray;
			this.TextFixedArray = TextFixedArray;
			this.StringSet = StringSet;
			this.NameSet = NameSet;
			this.StringMap = StringMap;
			this.NameMap = NameMap;
		}

		// Token: 0x06025413 RID: 152595 RVA: 0x003741A4 File Offset: 0x003723A4
		protected override IntPtr GetUStructPtr()
		{
			return FSharpherealTestStruct_String.StaticStruct();
		}

		// Token: 0x06025414 RID: 152596 RVA: 0x003741B0 File Offset: 0x003723B0
		[NullableContext(2)]
		public FSharpherealTestStruct_String(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025415 RID: 152597 RVA: 0x003741BA File Offset: 0x003723BA
		public FSharpherealTestStruct_String(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025416 RID: 152598 RVA: 0x003741C5 File Offset: 0x003723C5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSharpherealTestStruct_String(Pointer, false, true);
		}

		// Token: 0x06025417 RID: 152599 RVA: 0x003741CF File Offset: 0x003723CF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSharpherealTestStruct_String(Pointer, MemoryOwner);
		}

		// Token: 0x04014176 RID: 82294
		public const string __ObjectPath = "/Script/SharpherealTest.SharpherealTestStruct_String";

		// Token: 0x04014177 RID: 82295
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014178 RID: 82296
		internal static int __PropertyOffset_String;

		// Token: 0x04014179 RID: 82297
		internal static int __PropertyOffset_Name;

		// Token: 0x0401417A RID: 82298
		internal static int __PropertyOffset_Text;

		// Token: 0x0401417B RID: 82299
		[Nullable(2)]
		private FText _Text;

		// Token: 0x0401417C RID: 82300
		internal static int __PropertyOffset_StringArray;

		// Token: 0x0401417D RID: 82301
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _StringArray;

		// Token: 0x0401417E RID: 82302
		internal static int __PropertyOffset_NameArray;

		// Token: 0x0401417F RID: 82303
		[Nullable(2)]
		private TArray<FName> _NameArray;

		// Token: 0x04014180 RID: 82304
		internal static int __PropertyOffset_TextArray;

		// Token: 0x04014181 RID: 82305
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FText> _TextArray;

		// Token: 0x04014182 RID: 82306
		internal static int __PropertyOffset_StringFixedArray;

		// Token: 0x04014183 RID: 82307
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TFixedArray<string> _StringFixedArray;

		// Token: 0x04014184 RID: 82308
		internal static int __PropertyOffset_NameFixedArray;

		// Token: 0x04014185 RID: 82309
		[Nullable(2)]
		private TFixedArray<FName> _NameFixedArray;

		// Token: 0x04014186 RID: 82310
		internal static int __PropertyOffset_TextFixedArray;

		// Token: 0x04014187 RID: 82311
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TFixedArray<FText> _TextFixedArray;

		// Token: 0x04014188 RID: 82312
		internal static int __PropertyOffset_StringSet;

		// Token: 0x04014189 RID: 82313
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<string> _StringSet;

		// Token: 0x0401418A RID: 82314
		internal static int __PropertyOffset_NameSet;

		// Token: 0x0401418B RID: 82315
		[Nullable(2)]
		private TSet<FName> _NameSet;

		// Token: 0x0401418C RID: 82316
		internal static int __PropertyOffset_StringMap;

		// Token: 0x0401418D RID: 82317
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, int> _StringMap;

		// Token: 0x0401418E RID: 82318
		internal static int __PropertyOffset_NameMap;

		// Token: 0x0401418F RID: 82319
		[Nullable(2)]
		private TMap<FName, int> _NameMap;
	}
}
