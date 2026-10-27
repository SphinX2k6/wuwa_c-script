using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200056C RID: 1388
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_CollectionItemAtIndex")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FRigUnit_CollectionItemAtIndex : FRigUnit_CollectionBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060049DA RID: 18906 RVA: 0x0006D9ED File Offset: 0x0006BBED
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_CollectionItemAtIndex._ScriptStructPtr != 0) ? FRigUnit_CollectionItemAtIndex._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_CollectionItemAtIndex", ref FRigUnit_CollectionItemAtIndex._ScriptStructPtr);
		}

		// Token: 0x17001212 RID: 4626
		// (get) Token: 0x060049DB RID: 18907 RVA: 0x0006DA14 File Offset: 0x0006BC14
		// (set) Token: 0x060049DC RID: 18908 RVA: 0x0006DA57 File Offset: 0x0006BC57
		public FRigElementKeyCollection Collection
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKeyCollection result;
				if ((result = this._Collection) == null)
				{
					result = (this._Collection = new FRigElementKeyCollection(base.NativePtr + (IntPtr)FRigUnit_CollectionItemAtIndex.__PropertyOffset_Collection, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKeyCollection.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_CollectionItemAtIndex.__PropertyOffset_Collection, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001213 RID: 4627
		// (get) Token: 0x060049DD RID: 18909 RVA: 0x0006DA78 File Offset: 0x0006BC78
		// (set) Token: 0x060049DE RID: 18910 RVA: 0x0006DA88 File Offset: 0x0006BC88
		public unsafe int Index
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_CollectionItemAtIndex.__PropertyOffset_Index);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_CollectionItemAtIndex.__PropertyOffset_Index) = value;
			}
		}

		// Token: 0x17001214 RID: 4628
		// (get) Token: 0x060049DF RID: 18911 RVA: 0x0006DA9C File Offset: 0x0006BC9C
		// (set) Token: 0x060049E0 RID: 18912 RVA: 0x0006DADF File Offset: 0x0006BCDF
		public FRigElementKey Item
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKey result;
				if ((result = this._Item) == null)
				{
					result = (this._Item = new FRigElementKey(base.NativePtr + (IntPtr)FRigUnit_CollectionItemAtIndex.__PropertyOffset_Item, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKey.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_CollectionItemAtIndex.__PropertyOffset_Item, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060049E1 RID: 18913 RVA: 0x0006DB00 File Offset: 0x0006BD00
		public FRigUnit_CollectionItemAtIndex()
		{
		}

		// Token: 0x060049E2 RID: 18914 RVA: 0x0006DB08 File Offset: 0x0006BD08
		public FRigUnit_CollectionItemAtIndex(FRigElementKeyCollection Collection, int Index, FRigElementKey Item)
		{
			this.Collection = Collection;
			this.Index = Index;
			this.Item = Item;
		}

		// Token: 0x060049E3 RID: 18915 RVA: 0x0006DB25 File Offset: 0x0006BD25
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_CollectionItemAtIndex.StaticStruct();
		}

		// Token: 0x060049E4 RID: 18916 RVA: 0x0006DB31 File Offset: 0x0006BD31
		[NullableContext(2)]
		public FRigUnit_CollectionItemAtIndex(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060049E5 RID: 18917 RVA: 0x0006DB3B File Offset: 0x0006BD3B
		public FRigUnit_CollectionItemAtIndex(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060049E6 RID: 18918 RVA: 0x0006DB46 File Offset: 0x0006BD46
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_CollectionItemAtIndex(Pointer, false, true);
		}

		// Token: 0x060049E7 RID: 18919 RVA: 0x0006DB50 File Offset: 0x0006BD50
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_CollectionItemAtIndex(Pointer, MemoryOwner);
		}

		// Token: 0x040023DD RID: 9181
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_CollectionItemAtIndex";

		// Token: 0x040023DE RID: 9182
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040023DF RID: 9183
		internal static int __PropertyOffset_Collection;

		// Token: 0x040023E0 RID: 9184
		[Nullable(2)]
		private FRigElementKeyCollection _Collection;

		// Token: 0x040023E1 RID: 9185
		internal static int __PropertyOffset_Index;

		// Token: 0x040023E2 RID: 9186
		internal static int __PropertyOffset_Item;

		// Token: 0x040023E3 RID: 9187
		[Nullable(2)]
		private FRigElementKey _Item;
	}
}
