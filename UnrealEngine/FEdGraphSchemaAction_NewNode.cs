using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000A4F RID: 2639
	[UnrealObjectPath("/Script/Engine.EdGraphSchemaAction_NewNode")]
	[UnrealStructLayout(264, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 264)]
	public class FEdGraphSchemaAction_NewNode : FEdGraphSchemaAction, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008F6B RID: 36715 RVA: 0x000CD474 File Offset: 0x000CB674
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FEdGraphSchemaAction_NewNode._ScriptStructPtr != 0) ? FEdGraphSchemaAction_NewNode._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.EdGraphSchemaAction_NewNode", ref FEdGraphSchemaAction_NewNode._ScriptStructPtr);
		}

		// Token: 0x170021DD RID: 8669
		// (get) Token: 0x06008F6C RID: 36716 RVA: 0x000CD498 File Offset: 0x000CB698
		// (set) Token: 0x06008F6D RID: 36717 RVA: 0x000CD4AC File Offset: 0x000CB6AC
		[Nullable(2)]
		public unsafe UEdGraphNode NodeTemplate
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEdGraphNode>(base.NativePtr / (IntPtr)sizeof(void*) + FEdGraphSchemaAction_NewNode.__PropertyOffset_NodeTemplate);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FEdGraphSchemaAction_NewNode.__PropertyOffset_NodeTemplate, value);
			}
		}

		// Token: 0x06008F6E RID: 36718 RVA: 0x000CD4C1 File Offset: 0x000CB6C1
		public FEdGraphSchemaAction_NewNode()
		{
		}

		// Token: 0x06008F6F RID: 36719 RVA: 0x000CD4CC File Offset: 0x000CB6CC
		[NullableContext(1)]
		public FEdGraphSchemaAction_NewNode(UEdGraphNode NodeTemplate, FText MenuDescription, FText TooltipDescription, FText Category, FText Keywords, int Grouping, int SectionID, TArray<string> MenuDescriptionArray, TArray<string> FullSearchTitlesArray, TArray<string> FullSearchKeywordsArray, TArray<string> FullSearchCategoryArray, TArray<string> LocalizedMenuDescriptionArray, TArray<string> LocalizedFullSearchTitlesArray, TArray<string> LocalizedFullSearchKeywordsArray, TArray<string> LocalizedFullSearchCategoryArray, string SearchText)
		{
			this.NodeTemplate = NodeTemplate;
			base.MenuDescription = MenuDescription;
			base.TooltipDescription = TooltipDescription;
			base.Category = Category;
			base.Keywords = Keywords;
			base.Grouping = Grouping;
			base.SectionID = SectionID;
			base.MenuDescriptionArray = MenuDescriptionArray;
			base.FullSearchTitlesArray = FullSearchTitlesArray;
			base.FullSearchKeywordsArray = FullSearchKeywordsArray;
			base.FullSearchCategoryArray = FullSearchCategoryArray;
			base.LocalizedMenuDescriptionArray = LocalizedMenuDescriptionArray;
			base.LocalizedFullSearchTitlesArray = LocalizedFullSearchTitlesArray;
			base.LocalizedFullSearchKeywordsArray = LocalizedFullSearchKeywordsArray;
			base.LocalizedFullSearchCategoryArray = LocalizedFullSearchCategoryArray;
			base.SearchText = SearchText;
		}

		// Token: 0x06008F70 RID: 36720 RVA: 0x000CD55C File Offset: 0x000CB75C
		protected override IntPtr GetUStructPtr()
		{
			return FEdGraphSchemaAction_NewNode.StaticStruct();
		}

		// Token: 0x06008F71 RID: 36721 RVA: 0x000CD568 File Offset: 0x000CB768
		[NullableContext(2)]
		public FEdGraphSchemaAction_NewNode(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008F72 RID: 36722 RVA: 0x000CD572 File Offset: 0x000CB772
		public FEdGraphSchemaAction_NewNode(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008F73 RID: 36723 RVA: 0x000CD57D File Offset: 0x000CB77D
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FEdGraphSchemaAction_NewNode(Pointer, false, true);
		}

		// Token: 0x06008F74 RID: 36724 RVA: 0x000CD587 File Offset: 0x000CB787
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FEdGraphSchemaAction_NewNode(Pointer, MemoryOwner);
		}

		// Token: 0x040046DD RID: 18141
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.EdGraphSchemaAction_NewNode";

		// Token: 0x040046DE RID: 18142
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040046DF RID: 18143
		internal static int __PropertyOffset_NodeTemplate;
	}
}
