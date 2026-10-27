using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005CD RID: 1485
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_Item")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FRigUnit_Item : FRigUnit, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005035 RID: 20533 RVA: 0x000766F1 File Offset: 0x000748F1
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_Item._ScriptStructPtr != 0) ? FRigUnit_Item._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_Item", ref FRigUnit_Item._ScriptStructPtr);
		}

		// Token: 0x170013BD RID: 5053
		// (get) Token: 0x06005036 RID: 20534 RVA: 0x00076718 File Offset: 0x00074918
		// (set) Token: 0x06005037 RID: 20535 RVA: 0x0007675B File Offset: 0x0007495B
		public FRigElementKey Item
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKey result;
				if ((result = this._Item) == null)
				{
					result = (this._Item = new FRigElementKey(base.NativePtr + (IntPtr)FRigUnit_Item.__PropertyOffset_Item, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKey.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_Item.__PropertyOffset_Item, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06005038 RID: 20536 RVA: 0x0007677C File Offset: 0x0007497C
		public FRigUnit_Item()
		{
		}

		// Token: 0x06005039 RID: 20537 RVA: 0x00076784 File Offset: 0x00074984
		public FRigUnit_Item(FRigElementKey Item)
		{
			this.Item = Item;
		}

		// Token: 0x0600503A RID: 20538 RVA: 0x00076793 File Offset: 0x00074993
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_Item.StaticStruct();
		}

		// Token: 0x0600503B RID: 20539 RVA: 0x0007679F File Offset: 0x0007499F
		[NullableContext(2)]
		public FRigUnit_Item(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600503C RID: 20540 RVA: 0x000767A9 File Offset: 0x000749A9
		public FRigUnit_Item(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600503D RID: 20541 RVA: 0x000767B4 File Offset: 0x000749B4
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_Item(Pointer, false, true);
		}

		// Token: 0x0600503E RID: 20542 RVA: 0x000767BE File Offset: 0x000749BE
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_Item(Pointer, MemoryOwner);
		}

		// Token: 0x040026B5 RID: 9909
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_Item";

		// Token: 0x040026B6 RID: 9910
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040026B7 RID: 9911
		internal static int __PropertyOffset_Item;

		// Token: 0x040026B8 RID: 9912
		[Nullable(2)]
		private FRigElementKey _Item;
	}
}
