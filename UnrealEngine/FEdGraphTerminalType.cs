using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000A50 RID: 2640
	[UnrealObjectPath("/Script/Engine.EdGraphTerminalType")]
	[UnrealStructLayout(36, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 36)]
	public class FEdGraphTerminalType : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008F75 RID: 36725 RVA: 0x000CD590 File Offset: 0x000CB790
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FEdGraphTerminalType._ScriptStructPtr != 0) ? FEdGraphTerminalType._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.EdGraphTerminalType", ref FEdGraphTerminalType._ScriptStructPtr);
		}

		// Token: 0x170021DE RID: 8670
		// (get) Token: 0x06008F76 RID: 36726 RVA: 0x000CD5B4 File Offset: 0x000CB7B4
		// (set) Token: 0x06008F77 RID: 36727 RVA: 0x000CD5C8 File Offset: 0x000CB7C8
		public unsafe FName TerminalCategory
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEdGraphTerminalType.__PropertyOffset_TerminalCategory);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEdGraphTerminalType.__PropertyOffset_TerminalCategory) = value;
			}
		}

		// Token: 0x170021DF RID: 8671
		// (get) Token: 0x06008F78 RID: 36728 RVA: 0x000CD5DD File Offset: 0x000CB7DD
		// (set) Token: 0x06008F79 RID: 36729 RVA: 0x000CD5F1 File Offset: 0x000CB7F1
		public unsafe FName TerminalSubCategory
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEdGraphTerminalType.__PropertyOffset_TerminalSubCategory);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEdGraphTerminalType.__PropertyOffset_TerminalSubCategory) = value;
			}
		}

		// Token: 0x170021E0 RID: 8672
		// (get) Token: 0x06008F7A RID: 36730 RVA: 0x000CD606 File Offset: 0x000CB806
		// (set) Token: 0x06008F7B RID: 36731 RVA: 0x000CD61A File Offset: 0x000CB81A
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UObject> TerminalSubCategoryObject
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FEdGraphTerminalType.__PropertyOffset_TerminalSubCategoryObject);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FEdGraphTerminalType.__PropertyOffset_TerminalSubCategoryObject) = value;
			}
		}

		// Token: 0x170021E1 RID: 8673
		// (get) Token: 0x06008F7C RID: 36732 RVA: 0x000CD62F File Offset: 0x000CB82F
		// (set) Token: 0x06008F7D RID: 36733 RVA: 0x000CD63F File Offset: 0x000CB83F
		public unsafe bool bTerminalIsConst
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEdGraphTerminalType.__PropertyOffset_bTerminalIsConst) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEdGraphTerminalType.__PropertyOffset_bTerminalIsConst) = (value ? 1 : 0);
			}
		}

		// Token: 0x170021E2 RID: 8674
		// (get) Token: 0x06008F7E RID: 36734 RVA: 0x000CD650 File Offset: 0x000CB850
		// (set) Token: 0x06008F7F RID: 36735 RVA: 0x000CD660 File Offset: 0x000CB860
		public unsafe bool bTerminalIsWeakPointer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEdGraphTerminalType.__PropertyOffset_bTerminalIsWeakPointer) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEdGraphTerminalType.__PropertyOffset_bTerminalIsWeakPointer) = (value ? 1 : 0);
			}
		}

		// Token: 0x170021E3 RID: 8675
		// (get) Token: 0x06008F80 RID: 36736 RVA: 0x000CD671 File Offset: 0x000CB871
		// (set) Token: 0x06008F81 RID: 36737 RVA: 0x000CD681 File Offset: 0x000CB881
		public unsafe bool bTerminalIsUObjectWrapper
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEdGraphTerminalType.__PropertyOffset_bTerminalIsUObjectWrapper) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEdGraphTerminalType.__PropertyOffset_bTerminalIsUObjectWrapper) = (value ? 1 : 0);
			}
		}

		// Token: 0x06008F82 RID: 36738 RVA: 0x000CD692 File Offset: 0x000CB892
		public FEdGraphTerminalType()
		{
		}

		// Token: 0x06008F83 RID: 36739 RVA: 0x000CD69A File Offset: 0x000CB89A
		public FEdGraphTerminalType(FName TerminalCategory, FName TerminalSubCategory, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UObject> TerminalSubCategoryObject, bool bTerminalIsConst, bool bTerminalIsWeakPointer, bool bTerminalIsUObjectWrapper)
		{
			this.TerminalCategory = TerminalCategory;
			this.TerminalSubCategory = TerminalSubCategory;
			this.TerminalSubCategoryObject = TerminalSubCategoryObject;
			this.bTerminalIsConst = bTerminalIsConst;
			this.bTerminalIsWeakPointer = bTerminalIsWeakPointer;
			this.bTerminalIsUObjectWrapper = bTerminalIsUObjectWrapper;
		}

		// Token: 0x06008F84 RID: 36740 RVA: 0x000CD6CF File Offset: 0x000CB8CF
		protected override IntPtr GetUStructPtr()
		{
			return FEdGraphTerminalType.StaticStruct();
		}

		// Token: 0x06008F85 RID: 36741 RVA: 0x000CD6DB File Offset: 0x000CB8DB
		[NullableContext(2)]
		public FEdGraphTerminalType(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008F86 RID: 36742 RVA: 0x000CD6E5 File Offset: 0x000CB8E5
		public FEdGraphTerminalType(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008F87 RID: 36743 RVA: 0x000CD6F0 File Offset: 0x000CB8F0
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FEdGraphTerminalType(Pointer, false, true);
		}

		// Token: 0x06008F88 RID: 36744 RVA: 0x000CD6FA File Offset: 0x000CB8FA
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FEdGraphTerminalType(Pointer, MemoryOwner);
		}

		// Token: 0x040046E0 RID: 18144
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.EdGraphTerminalType";

		// Token: 0x040046E1 RID: 18145
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040046E2 RID: 18146
		internal static int __PropertyOffset_TerminalCategory;

		// Token: 0x040046E3 RID: 18147
		internal static int __PropertyOffset_TerminalSubCategory;

		// Token: 0x040046E4 RID: 18148
		internal static int __PropertyOffset_TerminalSubCategoryObject;

		// Token: 0x040046E5 RID: 18149
		internal static int __PropertyOffset_bTerminalIsConst;

		// Token: 0x040046E6 RID: 18150
		internal static int __PropertyOffset_bTerminalIsWeakPointer;

		// Token: 0x040046E7 RID: 18151
		internal static int __PropertyOffset_bTerminalIsUObjectWrapper;
	}
}
