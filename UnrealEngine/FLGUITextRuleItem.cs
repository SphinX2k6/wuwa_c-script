using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020020D3 RID: 8403
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.LGUITextRuleItem")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 216)]
	public class FLGUITextRuleItem : FTableRowBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FA70 RID: 129648 RVA: 0x002F124E File Offset: 0x002EF44E
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLGUITextRuleItem._ScriptStructPtr != 0) ? FLGUITextRuleItem._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.LGUITextRuleItem", ref FLGUITextRuleItem._ScriptStructPtr);
		}

		// Token: 0x17007CCA RID: 31946
		// (get) Token: 0x0601FA71 RID: 129649 RVA: 0x002F1272 File Offset: 0x002EF472
		// (set) Token: 0x0601FA72 RID: 129650 RVA: 0x002F1286 File Offset: 0x002EF486
		public unsafe string KeyWord
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FLGUITextRuleItem.__PropertyOffset_KeyWord)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FLGUITextRuleItem.__PropertyOffset_KeyWord)), value);
			}
		}

		// Token: 0x17007CCB RID: 31947
		// (get) Token: 0x0601FA73 RID: 129651 RVA: 0x002F129B File Offset: 0x002EF49B
		// (set) Token: 0x0601FA74 RID: 129652 RVA: 0x002F12AF File Offset: 0x002EF4AF
		public unsafe string Zh_KeyWord
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FLGUITextRuleItem.__PropertyOffset_Zh_KeyWord)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FLGUITextRuleItem.__PropertyOffset_Zh_KeyWord)), value);
			}
		}

		// Token: 0x17007CCC RID: 31948
		// (get) Token: 0x0601FA75 RID: 129653 RVA: 0x002F12C4 File Offset: 0x002EF4C4
		// (set) Token: 0x0601FA76 RID: 129654 RVA: 0x002F12D8 File Offset: 0x002EF4D8
		public unsafe string En_KeyWord
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FLGUITextRuleItem.__PropertyOffset_En_KeyWord)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FLGUITextRuleItem.__PropertyOffset_En_KeyWord)), value);
			}
		}

		// Token: 0x17007CCD RID: 31949
		// (get) Token: 0x0601FA77 RID: 129655 RVA: 0x002F12ED File Offset: 0x002EF4ED
		// (set) Token: 0x0601FA78 RID: 129656 RVA: 0x002F1301 File Offset: 0x002EF501
		public unsafe string Ja_KeyWord
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FLGUITextRuleItem.__PropertyOffset_Ja_KeyWord)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FLGUITextRuleItem.__PropertyOffset_Ja_KeyWord)), value);
			}
		}

		// Token: 0x17007CCE RID: 31950
		// (get) Token: 0x0601FA79 RID: 129657 RVA: 0x002F1316 File Offset: 0x002EF516
		// (set) Token: 0x0601FA7A RID: 129658 RVA: 0x002F132A File Offset: 0x002EF52A
		public unsafe string Ko_KeyWord
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FLGUITextRuleItem.__PropertyOffset_Ko_KeyWord)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FLGUITextRuleItem.__PropertyOffset_Ko_KeyWord)), value);
			}
		}

		// Token: 0x17007CCF RID: 31951
		// (get) Token: 0x0601FA7B RID: 129659 RVA: 0x002F133F File Offset: 0x002EF53F
		// (set) Token: 0x0601FA7C RID: 129660 RVA: 0x002F1353 File Offset: 0x002EF553
		public unsafe string Ru_KeyWord
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FLGUITextRuleItem.__PropertyOffset_Ru_KeyWord)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FLGUITextRuleItem.__PropertyOffset_Ru_KeyWord)), value);
			}
		}

		// Token: 0x17007CD0 RID: 31952
		// (get) Token: 0x0601FA7D RID: 129661 RVA: 0x002F1368 File Offset: 0x002EF568
		// (set) Token: 0x0601FA7E RID: 129662 RVA: 0x002F137C File Offset: 0x002EF57C
		public unsafe string De_KeyWord
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FLGUITextRuleItem.__PropertyOffset_De_KeyWord)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FLGUITextRuleItem.__PropertyOffset_De_KeyWord)), value);
			}
		}

		// Token: 0x17007CD1 RID: 31953
		// (get) Token: 0x0601FA7F RID: 129663 RVA: 0x002F1391 File Offset: 0x002EF591
		// (set) Token: 0x0601FA80 RID: 129664 RVA: 0x002F13A5 File Offset: 0x002EF5A5
		public unsafe string Es_KeyWord
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FLGUITextRuleItem.__PropertyOffset_Es_KeyWord)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FLGUITextRuleItem.__PropertyOffset_Es_KeyWord)), value);
			}
		}

		// Token: 0x17007CD2 RID: 31954
		// (get) Token: 0x0601FA81 RID: 129665 RVA: 0x002F13BA File Offset: 0x002EF5BA
		// (set) Token: 0x0601FA82 RID: 129666 RVA: 0x002F13CE File Offset: 0x002EF5CE
		public unsafe string Pt_KeyWord
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FLGUITextRuleItem.__PropertyOffset_Pt_KeyWord)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FLGUITextRuleItem.__PropertyOffset_Pt_KeyWord)), value);
			}
		}

		// Token: 0x17007CD3 RID: 31955
		// (get) Token: 0x0601FA83 RID: 129667 RVA: 0x002F13E3 File Offset: 0x002EF5E3
		// (set) Token: 0x0601FA84 RID: 129668 RVA: 0x002F13F7 File Offset: 0x002EF5F7
		public unsafe string Id_KeyWord
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FLGUITextRuleItem.__PropertyOffset_Id_KeyWord)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FLGUITextRuleItem.__PropertyOffset_Id_KeyWord)), value);
			}
		}

		// Token: 0x17007CD4 RID: 31956
		// (get) Token: 0x0601FA85 RID: 129669 RVA: 0x002F140C File Offset: 0x002EF60C
		// (set) Token: 0x0601FA86 RID: 129670 RVA: 0x002F1420 File Offset: 0x002EF620
		public unsafe string Fr_KeyWord
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FLGUITextRuleItem.__PropertyOffset_Fr_KeyWord)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FLGUITextRuleItem.__PropertyOffset_Fr_KeyWord)), value);
			}
		}

		// Token: 0x17007CD5 RID: 31957
		// (get) Token: 0x0601FA87 RID: 129671 RVA: 0x002F1435 File Offset: 0x002EF635
		// (set) Token: 0x0601FA88 RID: 129672 RVA: 0x002F1449 File Offset: 0x002EF649
		public unsafe string Vi_KeyWord
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FLGUITextRuleItem.__PropertyOffset_Vi_KeyWord)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FLGUITextRuleItem.__PropertyOffset_Vi_KeyWord)), value);
			}
		}

		// Token: 0x17007CD6 RID: 31958
		// (get) Token: 0x0601FA89 RID: 129673 RVA: 0x002F145E File Offset: 0x002EF65E
		// (set) Token: 0x0601FA8A RID: 129674 RVA: 0x002F1472 File Offset: 0x002EF672
		public unsafe string Th_KeyWord
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FLGUITextRuleItem.__PropertyOffset_Th_KeyWord)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FLGUITextRuleItem.__PropertyOffset_Th_KeyWord)), value);
			}
		}

		// Token: 0x0601FA8B RID: 129675 RVA: 0x002F1487 File Offset: 0x002EF687
		public FLGUITextRuleItem()
		{
		}

		// Token: 0x0601FA8C RID: 129676 RVA: 0x002F1490 File Offset: 0x002EF690
		public FLGUITextRuleItem(string KeyWord, string Zh_KeyWord, string En_KeyWord, string Ja_KeyWord, string Ko_KeyWord, string Ru_KeyWord, string De_KeyWord, string Es_KeyWord, string Pt_KeyWord, string Id_KeyWord, string Fr_KeyWord, string Vi_KeyWord, string Th_KeyWord)
		{
			this.KeyWord = KeyWord;
			this.Zh_KeyWord = Zh_KeyWord;
			this.En_KeyWord = En_KeyWord;
			this.Ja_KeyWord = Ja_KeyWord;
			this.Ko_KeyWord = Ko_KeyWord;
			this.Ru_KeyWord = Ru_KeyWord;
			this.De_KeyWord = De_KeyWord;
			this.Es_KeyWord = Es_KeyWord;
			this.Pt_KeyWord = Pt_KeyWord;
			this.Id_KeyWord = Id_KeyWord;
			this.Fr_KeyWord = Fr_KeyWord;
			this.Vi_KeyWord = Vi_KeyWord;
			this.Th_KeyWord = Th_KeyWord;
		}

		// Token: 0x0601FA8D RID: 129677 RVA: 0x002F1508 File Offset: 0x002EF708
		protected override IntPtr GetUStructPtr()
		{
			return FLGUITextRuleItem.StaticStruct();
		}

		// Token: 0x0601FA8E RID: 129678 RVA: 0x002F1514 File Offset: 0x002EF714
		[NullableContext(2)]
		public FLGUITextRuleItem(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FA8F RID: 129679 RVA: 0x002F151E File Offset: 0x002EF71E
		public FLGUITextRuleItem(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FA90 RID: 129680 RVA: 0x002F1529 File Offset: 0x002EF729
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLGUITextRuleItem(Pointer, false, true);
		}

		// Token: 0x0601FA91 RID: 129681 RVA: 0x002F1533 File Offset: 0x002EF733
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLGUITextRuleItem(Pointer, MemoryOwner);
		}

		// Token: 0x04011144 RID: 69956
		public new const string __ObjectPath = "/Script/LGUI.LGUITextRuleItem";

		// Token: 0x04011145 RID: 69957
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011146 RID: 69958
		internal static int __PropertyOffset_KeyWord;

		// Token: 0x04011147 RID: 69959
		internal static int __PropertyOffset_Zh_KeyWord;

		// Token: 0x04011148 RID: 69960
		internal static int __PropertyOffset_En_KeyWord;

		// Token: 0x04011149 RID: 69961
		internal static int __PropertyOffset_Ja_KeyWord;

		// Token: 0x0401114A RID: 69962
		internal static int __PropertyOffset_Ko_KeyWord;

		// Token: 0x0401114B RID: 69963
		internal static int __PropertyOffset_Ru_KeyWord;

		// Token: 0x0401114C RID: 69964
		internal static int __PropertyOffset_De_KeyWord;

		// Token: 0x0401114D RID: 69965
		internal static int __PropertyOffset_Es_KeyWord;

		// Token: 0x0401114E RID: 69966
		internal static int __PropertyOffset_Pt_KeyWord;

		// Token: 0x0401114F RID: 69967
		internal static int __PropertyOffset_Id_KeyWord;

		// Token: 0x04011150 RID: 69968
		internal static int __PropertyOffset_Fr_KeyWord;

		// Token: 0x04011151 RID: 69969
		internal static int __PropertyOffset_Vi_KeyWord;

		// Token: 0x04011152 RID: 69970
		internal static int __PropertyOffset_Th_KeyWord;
	}
}
