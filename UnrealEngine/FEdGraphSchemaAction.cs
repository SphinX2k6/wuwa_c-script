using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000A4E RID: 2638
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.EdGraphSchemaAction")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 256)]
	public class FEdGraphSchemaAction : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008F45 RID: 36677 RVA: 0x000CCF01 File Offset: 0x000CB101
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FEdGraphSchemaAction._ScriptStructPtr != 0) ? FEdGraphSchemaAction._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.EdGraphSchemaAction", ref FEdGraphSchemaAction._ScriptStructPtr);
		}

		// Token: 0x170021CE RID: 8654
		// (get) Token: 0x06008F46 RID: 36678 RVA: 0x000CCF28 File Offset: 0x000CB128
		// (set) Token: 0x06008F47 RID: 36679 RVA: 0x000CCF6B File Offset: 0x000CB16B
		public unsafe FText MenuDescription
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._MenuDescription) == null)
				{
					result = (this._MenuDescription = new FText(base.NativePtr + (IntPtr)FEdGraphSchemaAction.__PropertyOffset_MenuDescription, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)FEdGraphSchemaAction.__PropertyOffset_MenuDescription)), value.NativePtr, 1);
			}
		}

		// Token: 0x170021CF RID: 8655
		// (get) Token: 0x06008F48 RID: 36680 RVA: 0x000CCF88 File Offset: 0x000CB188
		// (set) Token: 0x06008F49 RID: 36681 RVA: 0x000CCFCB File Offset: 0x000CB1CB
		public unsafe FText TooltipDescription
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._TooltipDescription) == null)
				{
					result = (this._TooltipDescription = new FText(base.NativePtr + (IntPtr)FEdGraphSchemaAction.__PropertyOffset_TooltipDescription, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)FEdGraphSchemaAction.__PropertyOffset_TooltipDescription)), value.NativePtr, 1);
			}
		}

		// Token: 0x170021D0 RID: 8656
		// (get) Token: 0x06008F4A RID: 36682 RVA: 0x000CCFE8 File Offset: 0x000CB1E8
		// (set) Token: 0x06008F4B RID: 36683 RVA: 0x000CD02B File Offset: 0x000CB22B
		public unsafe FText Category
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._Category) == null)
				{
					result = (this._Category = new FText(base.NativePtr + (IntPtr)FEdGraphSchemaAction.__PropertyOffset_Category, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)FEdGraphSchemaAction.__PropertyOffset_Category)), value.NativePtr, 1);
			}
		}

		// Token: 0x170021D1 RID: 8657
		// (get) Token: 0x06008F4C RID: 36684 RVA: 0x000CD048 File Offset: 0x000CB248
		// (set) Token: 0x06008F4D RID: 36685 RVA: 0x000CD08B File Offset: 0x000CB28B
		public unsafe FText Keywords
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._Keywords) == null)
				{
					result = (this._Keywords = new FText(base.NativePtr + (IntPtr)FEdGraphSchemaAction.__PropertyOffset_Keywords, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)FEdGraphSchemaAction.__PropertyOffset_Keywords)), value.NativePtr, 1);
			}
		}

		// Token: 0x170021D2 RID: 8658
		// (get) Token: 0x06008F4E RID: 36686 RVA: 0x000CD0A6 File Offset: 0x000CB2A6
		// (set) Token: 0x06008F4F RID: 36687 RVA: 0x000CD0B6 File Offset: 0x000CB2B6
		public unsafe int Grouping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEdGraphSchemaAction.__PropertyOffset_Grouping);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEdGraphSchemaAction.__PropertyOffset_Grouping) = value;
			}
		}

		// Token: 0x170021D3 RID: 8659
		// (get) Token: 0x06008F50 RID: 36688 RVA: 0x000CD0C7 File Offset: 0x000CB2C7
		// (set) Token: 0x06008F51 RID: 36689 RVA: 0x000CD0D7 File Offset: 0x000CB2D7
		public unsafe int SectionID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEdGraphSchemaAction.__PropertyOffset_SectionID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEdGraphSchemaAction.__PropertyOffset_SectionID) = value;
			}
		}

		// Token: 0x170021D4 RID: 8660
		// (get) Token: 0x06008F52 RID: 36690 RVA: 0x000CD0E8 File Offset: 0x000CB2E8
		// (set) Token: 0x06008F53 RID: 36691 RVA: 0x000CD12B File Offset: 0x000CB32B
		public TArray<string> MenuDescriptionArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._MenuDescriptionArray) == null)
				{
					result = (this._MenuDescriptionArray = new TArray<string>(base.NativePtr + (IntPtr)FEdGraphSchemaAction.__PropertyOffset_MenuDescriptionArray, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MenuDescriptionArray.CopyAssign(value);
			}
		}

		// Token: 0x170021D5 RID: 8661
		// (get) Token: 0x06008F54 RID: 36692 RVA: 0x000CD13C File Offset: 0x000CB33C
		// (set) Token: 0x06008F55 RID: 36693 RVA: 0x000CD17F File Offset: 0x000CB37F
		public TArray<string> FullSearchTitlesArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._FullSearchTitlesArray) == null)
				{
					result = (this._FullSearchTitlesArray = new TArray<string>(base.NativePtr + (IntPtr)FEdGraphSchemaAction.__PropertyOffset_FullSearchTitlesArray, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FullSearchTitlesArray.CopyAssign(value);
			}
		}

		// Token: 0x170021D6 RID: 8662
		// (get) Token: 0x06008F56 RID: 36694 RVA: 0x000CD190 File Offset: 0x000CB390
		// (set) Token: 0x06008F57 RID: 36695 RVA: 0x000CD1D3 File Offset: 0x000CB3D3
		public TArray<string> FullSearchKeywordsArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._FullSearchKeywordsArray) == null)
				{
					result = (this._FullSearchKeywordsArray = new TArray<string>(base.NativePtr + (IntPtr)FEdGraphSchemaAction.__PropertyOffset_FullSearchKeywordsArray, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FullSearchKeywordsArray.CopyAssign(value);
			}
		}

		// Token: 0x170021D7 RID: 8663
		// (get) Token: 0x06008F58 RID: 36696 RVA: 0x000CD1E4 File Offset: 0x000CB3E4
		// (set) Token: 0x06008F59 RID: 36697 RVA: 0x000CD227 File Offset: 0x000CB427
		public TArray<string> FullSearchCategoryArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._FullSearchCategoryArray) == null)
				{
					result = (this._FullSearchCategoryArray = new TArray<string>(base.NativePtr + (IntPtr)FEdGraphSchemaAction.__PropertyOffset_FullSearchCategoryArray, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FullSearchCategoryArray.CopyAssign(value);
			}
		}

		// Token: 0x170021D8 RID: 8664
		// (get) Token: 0x06008F5A RID: 36698 RVA: 0x000CD238 File Offset: 0x000CB438
		// (set) Token: 0x06008F5B RID: 36699 RVA: 0x000CD27B File Offset: 0x000CB47B
		public TArray<string> LocalizedMenuDescriptionArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._LocalizedMenuDescriptionArray) == null)
				{
					result = (this._LocalizedMenuDescriptionArray = new TArray<string>(base.NativePtr + (IntPtr)FEdGraphSchemaAction.__PropertyOffset_LocalizedMenuDescriptionArray, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.LocalizedMenuDescriptionArray.CopyAssign(value);
			}
		}

		// Token: 0x170021D9 RID: 8665
		// (get) Token: 0x06008F5C RID: 36700 RVA: 0x000CD28C File Offset: 0x000CB48C
		// (set) Token: 0x06008F5D RID: 36701 RVA: 0x000CD2CF File Offset: 0x000CB4CF
		public TArray<string> LocalizedFullSearchTitlesArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._LocalizedFullSearchTitlesArray) == null)
				{
					result = (this._LocalizedFullSearchTitlesArray = new TArray<string>(base.NativePtr + (IntPtr)FEdGraphSchemaAction.__PropertyOffset_LocalizedFullSearchTitlesArray, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.LocalizedFullSearchTitlesArray.CopyAssign(value);
			}
		}

		// Token: 0x170021DA RID: 8666
		// (get) Token: 0x06008F5E RID: 36702 RVA: 0x000CD2E0 File Offset: 0x000CB4E0
		// (set) Token: 0x06008F5F RID: 36703 RVA: 0x000CD323 File Offset: 0x000CB523
		public TArray<string> LocalizedFullSearchKeywordsArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._LocalizedFullSearchKeywordsArray) == null)
				{
					result = (this._LocalizedFullSearchKeywordsArray = new TArray<string>(base.NativePtr + (IntPtr)FEdGraphSchemaAction.__PropertyOffset_LocalizedFullSearchKeywordsArray, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.LocalizedFullSearchKeywordsArray.CopyAssign(value);
			}
		}

		// Token: 0x170021DB RID: 8667
		// (get) Token: 0x06008F60 RID: 36704 RVA: 0x000CD334 File Offset: 0x000CB534
		// (set) Token: 0x06008F61 RID: 36705 RVA: 0x000CD377 File Offset: 0x000CB577
		public TArray<string> LocalizedFullSearchCategoryArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._LocalizedFullSearchCategoryArray) == null)
				{
					result = (this._LocalizedFullSearchCategoryArray = new TArray<string>(base.NativePtr + (IntPtr)FEdGraphSchemaAction.__PropertyOffset_LocalizedFullSearchCategoryArray, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.LocalizedFullSearchCategoryArray.CopyAssign(value);
			}
		}

		// Token: 0x170021DC RID: 8668
		// (get) Token: 0x06008F62 RID: 36706 RVA: 0x000CD385 File Offset: 0x000CB585
		// (set) Token: 0x06008F63 RID: 36707 RVA: 0x000CD399 File Offset: 0x000CB599
		public unsafe string SearchText
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FEdGraphSchemaAction.__PropertyOffset_SearchText)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FEdGraphSchemaAction.__PropertyOffset_SearchText)), value);
			}
		}

		// Token: 0x06008F64 RID: 36708 RVA: 0x000CD3AE File Offset: 0x000CB5AE
		public FEdGraphSchemaAction()
		{
		}

		// Token: 0x06008F65 RID: 36709 RVA: 0x000CD3B8 File Offset: 0x000CB5B8
		public FEdGraphSchemaAction(FText MenuDescription, FText TooltipDescription, FText Category, FText Keywords, int Grouping, int SectionID, TArray<string> MenuDescriptionArray, TArray<string> FullSearchTitlesArray, TArray<string> FullSearchKeywordsArray, TArray<string> FullSearchCategoryArray, TArray<string> LocalizedMenuDescriptionArray, TArray<string> LocalizedFullSearchTitlesArray, TArray<string> LocalizedFullSearchKeywordsArray, TArray<string> LocalizedFullSearchCategoryArray, string SearchText)
		{
			this.MenuDescription = MenuDescription;
			this.TooltipDescription = TooltipDescription;
			this.Category = Category;
			this.Keywords = Keywords;
			this.Grouping = Grouping;
			this.SectionID = SectionID;
			this.MenuDescriptionArray = MenuDescriptionArray;
			this.FullSearchTitlesArray = FullSearchTitlesArray;
			this.FullSearchKeywordsArray = FullSearchKeywordsArray;
			this.FullSearchCategoryArray = FullSearchCategoryArray;
			this.LocalizedMenuDescriptionArray = LocalizedMenuDescriptionArray;
			this.LocalizedFullSearchTitlesArray = LocalizedFullSearchTitlesArray;
			this.LocalizedFullSearchKeywordsArray = LocalizedFullSearchKeywordsArray;
			this.LocalizedFullSearchCategoryArray = LocalizedFullSearchCategoryArray;
			this.SearchText = SearchText;
		}

		// Token: 0x06008F66 RID: 36710 RVA: 0x000CD440 File Offset: 0x000CB640
		protected override IntPtr GetUStructPtr()
		{
			return FEdGraphSchemaAction.StaticStruct();
		}

		// Token: 0x06008F67 RID: 36711 RVA: 0x000CD44C File Offset: 0x000CB64C
		[NullableContext(2)]
		public FEdGraphSchemaAction(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008F68 RID: 36712 RVA: 0x000CD456 File Offset: 0x000CB656
		public FEdGraphSchemaAction(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008F69 RID: 36713 RVA: 0x000CD461 File Offset: 0x000CB661
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FEdGraphSchemaAction(Pointer, false, true);
		}

		// Token: 0x06008F6A RID: 36714 RVA: 0x000CD46B File Offset: 0x000CB66B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FEdGraphSchemaAction(Pointer, MemoryOwner);
		}

		// Token: 0x040046C0 RID: 18112
		public const string __ObjectPath = "/Script/Engine.EdGraphSchemaAction";

		// Token: 0x040046C1 RID: 18113
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040046C2 RID: 18114
		internal static int __PropertyOffset_MenuDescription;

		// Token: 0x040046C3 RID: 18115
		[Nullable(2)]
		private FText _MenuDescription;

		// Token: 0x040046C4 RID: 18116
		internal static int __PropertyOffset_TooltipDescription;

		// Token: 0x040046C5 RID: 18117
		[Nullable(2)]
		private FText _TooltipDescription;

		// Token: 0x040046C6 RID: 18118
		internal static int __PropertyOffset_Category;

		// Token: 0x040046C7 RID: 18119
		[Nullable(2)]
		private FText _Category;

		// Token: 0x040046C8 RID: 18120
		internal static int __PropertyOffset_Keywords;

		// Token: 0x040046C9 RID: 18121
		[Nullable(2)]
		private FText _Keywords;

		// Token: 0x040046CA RID: 18122
		internal static int __PropertyOffset_Grouping;

		// Token: 0x040046CB RID: 18123
		internal static int __PropertyOffset_SectionID;

		// Token: 0x040046CC RID: 18124
		internal static int __PropertyOffset_MenuDescriptionArray;

		// Token: 0x040046CD RID: 18125
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _MenuDescriptionArray;

		// Token: 0x040046CE RID: 18126
		internal static int __PropertyOffset_FullSearchTitlesArray;

		// Token: 0x040046CF RID: 18127
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _FullSearchTitlesArray;

		// Token: 0x040046D0 RID: 18128
		internal static int __PropertyOffset_FullSearchKeywordsArray;

		// Token: 0x040046D1 RID: 18129
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _FullSearchKeywordsArray;

		// Token: 0x040046D2 RID: 18130
		internal static int __PropertyOffset_FullSearchCategoryArray;

		// Token: 0x040046D3 RID: 18131
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _FullSearchCategoryArray;

		// Token: 0x040046D4 RID: 18132
		internal static int __PropertyOffset_LocalizedMenuDescriptionArray;

		// Token: 0x040046D5 RID: 18133
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _LocalizedMenuDescriptionArray;

		// Token: 0x040046D6 RID: 18134
		internal static int __PropertyOffset_LocalizedFullSearchTitlesArray;

		// Token: 0x040046D7 RID: 18135
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _LocalizedFullSearchTitlesArray;

		// Token: 0x040046D8 RID: 18136
		internal static int __PropertyOffset_LocalizedFullSearchKeywordsArray;

		// Token: 0x040046D9 RID: 18137
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _LocalizedFullSearchKeywordsArray;

		// Token: 0x040046DA RID: 18138
		internal static int __PropertyOffset_LocalizedFullSearchCategoryArray;

		// Token: 0x040046DB RID: 18139
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _LocalizedFullSearchCategoryArray;

		// Token: 0x040046DC RID: 18140
		internal static int __PropertyOffset_SearchText;
	}
}
