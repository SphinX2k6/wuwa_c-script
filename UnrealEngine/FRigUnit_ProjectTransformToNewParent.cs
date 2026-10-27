using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006A8 RID: 1704
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_ProjectTransformToNewParent")]
	[UnrealStructLayout(208, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 208)]
	public class FRigUnit_ProjectTransformToNewParent : FRigUnit, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005AB7 RID: 23223 RVA: 0x0008244B File Offset: 0x0008064B
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_ProjectTransformToNewParent._ScriptStructPtr != 0) ? FRigUnit_ProjectTransformToNewParent._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_ProjectTransformToNewParent", ref FRigUnit_ProjectTransformToNewParent._ScriptStructPtr);
		}

		// Token: 0x17001599 RID: 5529
		// (get) Token: 0x06005AB8 RID: 23224 RVA: 0x00082470 File Offset: 0x00080670
		// (set) Token: 0x06005AB9 RID: 23225 RVA: 0x000824B3 File Offset: 0x000806B3
		public FRigElementKey Child
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKey result;
				if ((result = this._Child) == null)
				{
					result = (this._Child = new FRigElementKey(base.NativePtr + (IntPtr)FRigUnit_ProjectTransformToNewParent.__PropertyOffset_Child, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKey.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_ProjectTransformToNewParent.__PropertyOffset_Child, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700159A RID: 5530
		// (get) Token: 0x06005ABA RID: 23226 RVA: 0x000824D4 File Offset: 0x000806D4
		// (set) Token: 0x06005ABB RID: 23227 RVA: 0x000824E4 File Offset: 0x000806E4
		public unsafe bool bChildInitial
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ProjectTransformToNewParent.__PropertyOffset_bChildInitial) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ProjectTransformToNewParent.__PropertyOffset_bChildInitial) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700159B RID: 5531
		// (get) Token: 0x06005ABC RID: 23228 RVA: 0x000824F8 File Offset: 0x000806F8
		// (set) Token: 0x06005ABD RID: 23229 RVA: 0x0008253B File Offset: 0x0008073B
		public FRigElementKey OldParent
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKey result;
				if ((result = this._OldParent) == null)
				{
					result = (this._OldParent = new FRigElementKey(base.NativePtr + (IntPtr)FRigUnit_ProjectTransformToNewParent.__PropertyOffset_OldParent, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKey.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_ProjectTransformToNewParent.__PropertyOffset_OldParent, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700159C RID: 5532
		// (get) Token: 0x06005ABE RID: 23230 RVA: 0x0008255C File Offset: 0x0008075C
		// (set) Token: 0x06005ABF RID: 23231 RVA: 0x0008256C File Offset: 0x0008076C
		public unsafe bool bOldParentInitial
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ProjectTransformToNewParent.__PropertyOffset_bOldParentInitial) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ProjectTransformToNewParent.__PropertyOffset_bOldParentInitial) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700159D RID: 5533
		// (get) Token: 0x06005AC0 RID: 23232 RVA: 0x00082580 File Offset: 0x00080780
		// (set) Token: 0x06005AC1 RID: 23233 RVA: 0x000825C3 File Offset: 0x000807C3
		public FRigElementKey NewParent
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKey result;
				if ((result = this._NewParent) == null)
				{
					result = (this._NewParent = new FRigElementKey(base.NativePtr + (IntPtr)FRigUnit_ProjectTransformToNewParent.__PropertyOffset_NewParent, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKey.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_ProjectTransformToNewParent.__PropertyOffset_NewParent, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700159E RID: 5534
		// (get) Token: 0x06005AC2 RID: 23234 RVA: 0x000825E4 File Offset: 0x000807E4
		// (set) Token: 0x06005AC3 RID: 23235 RVA: 0x000825F4 File Offset: 0x000807F4
		public unsafe bool bNewParentInitial
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ProjectTransformToNewParent.__PropertyOffset_bNewParentInitial) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ProjectTransformToNewParent.__PropertyOffset_bNewParentInitial) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700159F RID: 5535
		// (get) Token: 0x06005AC4 RID: 23236 RVA: 0x00082605 File Offset: 0x00080805
		// (set) Token: 0x06005AC5 RID: 23237 RVA: 0x00082619 File Offset: 0x00080819
		public unsafe FTransform Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ProjectTransformToNewParent.__PropertyOffset_Transform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ProjectTransformToNewParent.__PropertyOffset_Transform) = value;
			}
		}

		// Token: 0x170015A0 RID: 5536
		// (get) Token: 0x06005AC6 RID: 23238 RVA: 0x00082630 File Offset: 0x00080830
		// (set) Token: 0x06005AC7 RID: 23239 RVA: 0x00082673 File Offset: 0x00080873
		public FCachedRigElement CachedChild
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._CachedChild) == null)
				{
					result = (this._CachedChild = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_ProjectTransformToNewParent.__PropertyOffset_CachedChild, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_ProjectTransformToNewParent.__PropertyOffset_CachedChild, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170015A1 RID: 5537
		// (get) Token: 0x06005AC8 RID: 23240 RVA: 0x00082694 File Offset: 0x00080894
		// (set) Token: 0x06005AC9 RID: 23241 RVA: 0x000826D7 File Offset: 0x000808D7
		public FCachedRigElement CachedOldParent
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._CachedOldParent) == null)
				{
					result = (this._CachedOldParent = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_ProjectTransformToNewParent.__PropertyOffset_CachedOldParent, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_ProjectTransformToNewParent.__PropertyOffset_CachedOldParent, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170015A2 RID: 5538
		// (get) Token: 0x06005ACA RID: 23242 RVA: 0x000826F8 File Offset: 0x000808F8
		// (set) Token: 0x06005ACB RID: 23243 RVA: 0x0008273B File Offset: 0x0008093B
		public FCachedRigElement CachedNewParent
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._CachedNewParent) == null)
				{
					result = (this._CachedNewParent = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_ProjectTransformToNewParent.__PropertyOffset_CachedNewParent, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_ProjectTransformToNewParent.__PropertyOffset_CachedNewParent, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06005ACC RID: 23244 RVA: 0x0008275C File Offset: 0x0008095C
		public FRigUnit_ProjectTransformToNewParent()
		{
		}

		// Token: 0x06005ACD RID: 23245 RVA: 0x00082764 File Offset: 0x00080964
		public FRigUnit_ProjectTransformToNewParent(FRigElementKey Child, bool bChildInitial, FRigElementKey OldParent, bool bOldParentInitial, FRigElementKey NewParent, bool bNewParentInitial, FTransform Transform, FCachedRigElement CachedChild, FCachedRigElement CachedOldParent, FCachedRigElement CachedNewParent)
		{
			this.Child = Child;
			this.bChildInitial = bChildInitial;
			this.OldParent = OldParent;
			this.bOldParentInitial = bOldParentInitial;
			this.NewParent = NewParent;
			this.bNewParentInitial = bNewParentInitial;
			this.Transform = Transform;
			this.CachedChild = CachedChild;
			this.CachedOldParent = CachedOldParent;
			this.CachedNewParent = CachedNewParent;
		}

		// Token: 0x06005ACE RID: 23246 RVA: 0x000827C4 File Offset: 0x000809C4
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_ProjectTransformToNewParent.StaticStruct();
		}

		// Token: 0x06005ACF RID: 23247 RVA: 0x000827D0 File Offset: 0x000809D0
		[NullableContext(2)]
		public FRigUnit_ProjectTransformToNewParent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005AD0 RID: 23248 RVA: 0x000827DA File Offset: 0x000809DA
		public FRigUnit_ProjectTransformToNewParent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005AD1 RID: 23249 RVA: 0x000827E5 File Offset: 0x000809E5
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_ProjectTransformToNewParent(Pointer, false, true);
		}

		// Token: 0x06005AD2 RID: 23250 RVA: 0x000827EF File Offset: 0x000809EF
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_ProjectTransformToNewParent(Pointer, MemoryOwner);
		}

		// Token: 0x04002A7B RID: 10875
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_ProjectTransformToNewParent";

		// Token: 0x04002A7C RID: 10876
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002A7D RID: 10877
		internal static int __PropertyOffset_Child;

		// Token: 0x04002A7E RID: 10878
		[Nullable(2)]
		private FRigElementKey _Child;

		// Token: 0x04002A7F RID: 10879
		internal static int __PropertyOffset_bChildInitial;

		// Token: 0x04002A80 RID: 10880
		internal static int __PropertyOffset_OldParent;

		// Token: 0x04002A81 RID: 10881
		[Nullable(2)]
		private FRigElementKey _OldParent;

		// Token: 0x04002A82 RID: 10882
		internal static int __PropertyOffset_bOldParentInitial;

		// Token: 0x04002A83 RID: 10883
		internal static int __PropertyOffset_NewParent;

		// Token: 0x04002A84 RID: 10884
		[Nullable(2)]
		private FRigElementKey _NewParent;

		// Token: 0x04002A85 RID: 10885
		internal static int __PropertyOffset_bNewParentInitial;

		// Token: 0x04002A86 RID: 10886
		internal static int __PropertyOffset_Transform;

		// Token: 0x04002A87 RID: 10887
		internal static int __PropertyOffset_CachedChild;

		// Token: 0x04002A88 RID: 10888
		[Nullable(2)]
		private FCachedRigElement _CachedChild;

		// Token: 0x04002A89 RID: 10889
		internal static int __PropertyOffset_CachedOldParent;

		// Token: 0x04002A8A RID: 10890
		[Nullable(2)]
		private FCachedRigElement _CachedOldParent;

		// Token: 0x04002A8B RID: 10891
		internal static int __PropertyOffset_CachedNewParent;

		// Token: 0x04002A8C RID: 10892
		[Nullable(2)]
		private FCachedRigElement _CachedNewParent;
	}
}
