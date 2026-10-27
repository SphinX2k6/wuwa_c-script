using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005BE RID: 1470
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_GetRelativeTransformForItem")]
	[UnrealStructLayout(144, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 144)]
	public class FRigUnit_GetRelativeTransformForItem : FRigUnit, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004F5D RID: 20317 RVA: 0x00075242 File Offset: 0x00073442
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_GetRelativeTransformForItem._ScriptStructPtr != 0) ? FRigUnit_GetRelativeTransformForItem._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_GetRelativeTransformForItem", ref FRigUnit_GetRelativeTransformForItem._ScriptStructPtr);
		}

		// Token: 0x1700138C RID: 5004
		// (get) Token: 0x06004F5E RID: 20318 RVA: 0x00075268 File Offset: 0x00073468
		// (set) Token: 0x06004F5F RID: 20319 RVA: 0x000752AB File Offset: 0x000734AB
		public FRigElementKey Child
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKey result;
				if ((result = this._Child) == null)
				{
					result = (this._Child = new FRigElementKey(base.NativePtr + (IntPtr)FRigUnit_GetRelativeTransformForItem.__PropertyOffset_Child, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKey.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_GetRelativeTransformForItem.__PropertyOffset_Child, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700138D RID: 5005
		// (get) Token: 0x06004F60 RID: 20320 RVA: 0x000752CC File Offset: 0x000734CC
		// (set) Token: 0x06004F61 RID: 20321 RVA: 0x000752DC File Offset: 0x000734DC
		public unsafe bool bChildInitial
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_GetRelativeTransformForItem.__PropertyOffset_bChildInitial) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_GetRelativeTransformForItem.__PropertyOffset_bChildInitial) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700138E RID: 5006
		// (get) Token: 0x06004F62 RID: 20322 RVA: 0x000752F0 File Offset: 0x000734F0
		// (set) Token: 0x06004F63 RID: 20323 RVA: 0x00075333 File Offset: 0x00073533
		public FRigElementKey Parent
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKey result;
				if ((result = this._Parent) == null)
				{
					result = (this._Parent = new FRigElementKey(base.NativePtr + (IntPtr)FRigUnit_GetRelativeTransformForItem.__PropertyOffset_Parent, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKey.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_GetRelativeTransformForItem.__PropertyOffset_Parent, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700138F RID: 5007
		// (get) Token: 0x06004F64 RID: 20324 RVA: 0x00075354 File Offset: 0x00073554
		// (set) Token: 0x06004F65 RID: 20325 RVA: 0x00075364 File Offset: 0x00073564
		public unsafe bool bParentInitial
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_GetRelativeTransformForItem.__PropertyOffset_bParentInitial) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_GetRelativeTransformForItem.__PropertyOffset_bParentInitial) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001390 RID: 5008
		// (get) Token: 0x06004F66 RID: 20326 RVA: 0x00075375 File Offset: 0x00073575
		// (set) Token: 0x06004F67 RID: 20327 RVA: 0x00075389 File Offset: 0x00073589
		public unsafe FTransform RelativeTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_GetRelativeTransformForItem.__PropertyOffset_RelativeTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_GetRelativeTransformForItem.__PropertyOffset_RelativeTransform) = value;
			}
		}

		// Token: 0x17001391 RID: 5009
		// (get) Token: 0x06004F68 RID: 20328 RVA: 0x000753A0 File Offset: 0x000735A0
		// (set) Token: 0x06004F69 RID: 20329 RVA: 0x000753E3 File Offset: 0x000735E3
		public FCachedRigElement CachedChild
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._CachedChild) == null)
				{
					result = (this._CachedChild = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_GetRelativeTransformForItem.__PropertyOffset_CachedChild, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_GetRelativeTransformForItem.__PropertyOffset_CachedChild, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001392 RID: 5010
		// (get) Token: 0x06004F6A RID: 20330 RVA: 0x00075404 File Offset: 0x00073604
		// (set) Token: 0x06004F6B RID: 20331 RVA: 0x00075447 File Offset: 0x00073647
		public FCachedRigElement CachedParent
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._CachedParent) == null)
				{
					result = (this._CachedParent = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_GetRelativeTransformForItem.__PropertyOffset_CachedParent, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_GetRelativeTransformForItem.__PropertyOffset_CachedParent, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06004F6C RID: 20332 RVA: 0x00075468 File Offset: 0x00073668
		public FRigUnit_GetRelativeTransformForItem()
		{
		}

		// Token: 0x06004F6D RID: 20333 RVA: 0x00075470 File Offset: 0x00073670
		public FRigUnit_GetRelativeTransformForItem(FRigElementKey Child, bool bChildInitial, FRigElementKey Parent, bool bParentInitial, FTransform RelativeTransform, FCachedRigElement CachedChild, FCachedRigElement CachedParent)
		{
			this.Child = Child;
			this.bChildInitial = bChildInitial;
			this.Parent = Parent;
			this.bParentInitial = bParentInitial;
			this.RelativeTransform = RelativeTransform;
			this.CachedChild = CachedChild;
			this.CachedParent = CachedParent;
		}

		// Token: 0x06004F6E RID: 20334 RVA: 0x000754AD File Offset: 0x000736AD
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_GetRelativeTransformForItem.StaticStruct();
		}

		// Token: 0x06004F6F RID: 20335 RVA: 0x000754B9 File Offset: 0x000736B9
		[NullableContext(2)]
		public FRigUnit_GetRelativeTransformForItem(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004F70 RID: 20336 RVA: 0x000754C3 File Offset: 0x000736C3
		public FRigUnit_GetRelativeTransformForItem(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004F71 RID: 20337 RVA: 0x000754CE File Offset: 0x000736CE
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_GetRelativeTransformForItem(Pointer, false, true);
		}

		// Token: 0x06004F72 RID: 20338 RVA: 0x000754D8 File Offset: 0x000736D8
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_GetRelativeTransformForItem(Pointer, MemoryOwner);
		}

		// Token: 0x0400264D RID: 9805
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_GetRelativeTransformForItem";

		// Token: 0x0400264E RID: 9806
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400264F RID: 9807
		internal static int __PropertyOffset_Child;

		// Token: 0x04002650 RID: 9808
		[Nullable(2)]
		private FRigElementKey _Child;

		// Token: 0x04002651 RID: 9809
		internal static int __PropertyOffset_bChildInitial;

		// Token: 0x04002652 RID: 9810
		internal static int __PropertyOffset_Parent;

		// Token: 0x04002653 RID: 9811
		[Nullable(2)]
		private FRigElementKey _Parent;

		// Token: 0x04002654 RID: 9812
		internal static int __PropertyOffset_bParentInitial;

		// Token: 0x04002655 RID: 9813
		internal static int __PropertyOffset_RelativeTransform;

		// Token: 0x04002656 RID: 9814
		internal static int __PropertyOffset_CachedChild;

		// Token: 0x04002657 RID: 9815
		[Nullable(2)]
		private FCachedRigElement _CachedChild;

		// Token: 0x04002658 RID: 9816
		internal static int __PropertyOffset_CachedParent;

		// Token: 0x04002659 RID: 9817
		[Nullable(2)]
		private FCachedRigElement _CachedParent;
	}
}
