using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006D6 RID: 1750
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_SlideChainPerItem")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 208)]
	public class FRigUnit_SlideChainPerItem : FRigUnit_HighlevelBaseMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005DB8 RID: 23992 RVA: 0x00086829 File Offset: 0x00084A29
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_SlideChainPerItem._ScriptStructPtr != 0) ? FRigUnit_SlideChainPerItem._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_SlideChainPerItem", ref FRigUnit_SlideChainPerItem._ScriptStructPtr);
		}

		// Token: 0x17001662 RID: 5730
		// (get) Token: 0x06005DB9 RID: 23993 RVA: 0x00086850 File Offset: 0x00084A50
		// (set) Token: 0x06005DBA RID: 23994 RVA: 0x00086893 File Offset: 0x00084A93
		public FRigElementKeyCollection Items
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKeyCollection result;
				if ((result = this._Items) == null)
				{
					result = (this._Items = new FRigElementKeyCollection(base.NativePtr + (IntPtr)FRigUnit_SlideChainPerItem.__PropertyOffset_Items, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKeyCollection.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_SlideChainPerItem.__PropertyOffset_Items, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001663 RID: 5731
		// (get) Token: 0x06005DBB RID: 23995 RVA: 0x000868B4 File Offset: 0x00084AB4
		// (set) Token: 0x06005DBC RID: 23996 RVA: 0x000868C4 File Offset: 0x00084AC4
		public unsafe float SlideAmount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SlideChainPerItem.__PropertyOffset_SlideAmount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SlideChainPerItem.__PropertyOffset_SlideAmount) = value;
			}
		}

		// Token: 0x17001664 RID: 5732
		// (get) Token: 0x06005DBD RID: 23997 RVA: 0x000868D5 File Offset: 0x00084AD5
		// (set) Token: 0x06005DBE RID: 23998 RVA: 0x000868E5 File Offset: 0x00084AE5
		public unsafe bool bPropagateToChildren
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SlideChainPerItem.__PropertyOffset_bPropagateToChildren) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SlideChainPerItem.__PropertyOffset_bPropagateToChildren) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001665 RID: 5733
		// (get) Token: 0x06005DBF RID: 23999 RVA: 0x000868F8 File Offset: 0x00084AF8
		// (set) Token: 0x06005DC0 RID: 24000 RVA: 0x0008693B File Offset: 0x00084B3B
		public FRigUnit_SlideChain_WorkData WorkData
		{
			get
			{
				base.FastCheckIsValid();
				FRigUnit_SlideChain_WorkData result;
				if ((result = this._WorkData) == null)
				{
					result = (this._WorkData = new FRigUnit_SlideChain_WorkData(base.NativePtr + (IntPtr)FRigUnit_SlideChainPerItem.__PropertyOffset_WorkData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigUnit_SlideChain_WorkData.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_SlideChainPerItem.__PropertyOffset_WorkData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06005DC1 RID: 24001 RVA: 0x0008695C File Offset: 0x00084B5C
		public FRigUnit_SlideChainPerItem()
		{
		}

		// Token: 0x06005DC2 RID: 24002 RVA: 0x00086964 File Offset: 0x00084B64
		public FRigUnit_SlideChainPerItem(FRigElementKeyCollection Items, float SlideAmount, bool bPropagateToChildren, FRigUnit_SlideChain_WorkData WorkData, FControlRigExecuteContext ExecuteContext)
		{
			this.Items = Items;
			this.SlideAmount = SlideAmount;
			this.bPropagateToChildren = bPropagateToChildren;
			this.WorkData = WorkData;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06005DC3 RID: 24003 RVA: 0x00086991 File Offset: 0x00084B91
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_SlideChainPerItem.StaticStruct();
		}

		// Token: 0x06005DC4 RID: 24004 RVA: 0x0008699D File Offset: 0x00084B9D
		[NullableContext(2)]
		public FRigUnit_SlideChainPerItem(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005DC5 RID: 24005 RVA: 0x000869A7 File Offset: 0x00084BA7
		public FRigUnit_SlideChainPerItem(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005DC6 RID: 24006 RVA: 0x000869B2 File Offset: 0x00084BB2
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_SlideChainPerItem(Pointer, false, true);
		}

		// Token: 0x06005DC7 RID: 24007 RVA: 0x000869BC File Offset: 0x00084BBC
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_SlideChainPerItem(Pointer, MemoryOwner);
		}

		// Token: 0x04002BD9 RID: 11225
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_SlideChainPerItem";

		// Token: 0x04002BDA RID: 11226
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002BDB RID: 11227
		internal static int __PropertyOffset_Items;

		// Token: 0x04002BDC RID: 11228
		[Nullable(2)]
		private FRigElementKeyCollection _Items;

		// Token: 0x04002BDD RID: 11229
		internal static int __PropertyOffset_SlideAmount;

		// Token: 0x04002BDE RID: 11230
		internal static int __PropertyOffset_bPropagateToChildren;

		// Token: 0x04002BDF RID: 11231
		internal static int __PropertyOffset_WorkData;

		// Token: 0x04002BE0 RID: 11232
		[Nullable(2)]
		private FRigUnit_SlideChain_WorkData _WorkData;
	}
}
