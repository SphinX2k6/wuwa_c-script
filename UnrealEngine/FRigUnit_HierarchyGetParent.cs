using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005C5 RID: 1477
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_HierarchyGetParent")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FRigUnit_HierarchyGetParent : FRigUnit_HierarchyBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004FD4 RID: 20436 RVA: 0x00075D81 File Offset: 0x00073F81
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_HierarchyGetParent._ScriptStructPtr != 0) ? FRigUnit_HierarchyGetParent._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_HierarchyGetParent", ref FRigUnit_HierarchyGetParent._ScriptStructPtr);
		}

		// Token: 0x170013AC RID: 5036
		// (get) Token: 0x06004FD5 RID: 20437 RVA: 0x00075DA8 File Offset: 0x00073FA8
		// (set) Token: 0x06004FD6 RID: 20438 RVA: 0x00075DEB File Offset: 0x00073FEB
		public FRigElementKey Child
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKey result;
				if ((result = this._Child) == null)
				{
					result = (this._Child = new FRigElementKey(base.NativePtr + (IntPtr)FRigUnit_HierarchyGetParent.__PropertyOffset_Child, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKey.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_HierarchyGetParent.__PropertyOffset_Child, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170013AD RID: 5037
		// (get) Token: 0x06004FD7 RID: 20439 RVA: 0x00075E0C File Offset: 0x0007400C
		// (set) Token: 0x06004FD8 RID: 20440 RVA: 0x00075E4F File Offset: 0x0007404F
		public FRigElementKey Parent
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKey result;
				if ((result = this._Parent) == null)
				{
					result = (this._Parent = new FRigElementKey(base.NativePtr + (IntPtr)FRigUnit_HierarchyGetParent.__PropertyOffset_Parent, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKey.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_HierarchyGetParent.__PropertyOffset_Parent, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170013AE RID: 5038
		// (get) Token: 0x06004FD9 RID: 20441 RVA: 0x00075E70 File Offset: 0x00074070
		// (set) Token: 0x06004FDA RID: 20442 RVA: 0x00075EB3 File Offset: 0x000740B3
		public FCachedRigElement CachedChild
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._CachedChild) == null)
				{
					result = (this._CachedChild = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_HierarchyGetParent.__PropertyOffset_CachedChild, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_HierarchyGetParent.__PropertyOffset_CachedChild, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170013AF RID: 5039
		// (get) Token: 0x06004FDB RID: 20443 RVA: 0x00075ED4 File Offset: 0x000740D4
		// (set) Token: 0x06004FDC RID: 20444 RVA: 0x00075F17 File Offset: 0x00074117
		public FCachedRigElement CachedParent
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._CachedParent) == null)
				{
					result = (this._CachedParent = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_HierarchyGetParent.__PropertyOffset_CachedParent, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_HierarchyGetParent.__PropertyOffset_CachedParent, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06004FDD RID: 20445 RVA: 0x00075F38 File Offset: 0x00074138
		public FRigUnit_HierarchyGetParent()
		{
		}

		// Token: 0x06004FDE RID: 20446 RVA: 0x00075F40 File Offset: 0x00074140
		public FRigUnit_HierarchyGetParent(FRigElementKey Child, FRigElementKey Parent, FCachedRigElement CachedChild, FCachedRigElement CachedParent)
		{
			this.Child = Child;
			this.Parent = Parent;
			this.CachedChild = CachedChild;
			this.CachedParent = CachedParent;
		}

		// Token: 0x06004FDF RID: 20447 RVA: 0x00075F65 File Offset: 0x00074165
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_HierarchyGetParent.StaticStruct();
		}

		// Token: 0x06004FE0 RID: 20448 RVA: 0x00075F71 File Offset: 0x00074171
		[NullableContext(2)]
		public FRigUnit_HierarchyGetParent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004FE1 RID: 20449 RVA: 0x00075F7B File Offset: 0x0007417B
		public FRigUnit_HierarchyGetParent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004FE2 RID: 20450 RVA: 0x00075F86 File Offset: 0x00074186
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_HierarchyGetParent(Pointer, false, true);
		}

		// Token: 0x06004FE3 RID: 20451 RVA: 0x00075F90 File Offset: 0x00074190
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_HierarchyGetParent(Pointer, MemoryOwner);
		}

		// Token: 0x04002687 RID: 9863
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_HierarchyGetParent";

		// Token: 0x04002688 RID: 9864
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002689 RID: 9865
		internal static int __PropertyOffset_Child;

		// Token: 0x0400268A RID: 9866
		[Nullable(2)]
		private FRigElementKey _Child;

		// Token: 0x0400268B RID: 9867
		internal static int __PropertyOffset_Parent;

		// Token: 0x0400268C RID: 9868
		[Nullable(2)]
		private FRigElementKey _Parent;

		// Token: 0x0400268D RID: 9869
		internal static int __PropertyOffset_CachedChild;

		// Token: 0x0400268E RID: 9870
		[Nullable(2)]
		private FCachedRigElement _CachedChild;

		// Token: 0x0400268F RID: 9871
		internal static int __PropertyOffset_CachedParent;

		// Token: 0x04002690 RID: 9872
		[Nullable(2)]
		private FCachedRigElement _CachedParent;
	}
}
