using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200056D RID: 1389
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_CollectionItems")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FRigUnit_CollectionItems : FRigUnit_CollectionBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060049E8 RID: 18920 RVA: 0x0006DB59 File Offset: 0x0006BD59
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_CollectionItems._ScriptStructPtr != 0) ? FRigUnit_CollectionItems._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_CollectionItems", ref FRigUnit_CollectionItems._ScriptStructPtr);
		}

		// Token: 0x17001215 RID: 4629
		// (get) Token: 0x060049E9 RID: 18921 RVA: 0x0006DB80 File Offset: 0x0006BD80
		// (set) Token: 0x060049EA RID: 18922 RVA: 0x0006DBC3 File Offset: 0x0006BDC3
		public TArray<FRigElementKey> Items
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRigElementKey> result;
				if ((result = this._Items) == null)
				{
					result = (this._Items = new TArray<FRigElementKey>(base.NativePtr + (IntPtr)FRigUnit_CollectionItems.__PropertyOffset_Items, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Items.CopyAssign(value);
			}
		}

		// Token: 0x17001216 RID: 4630
		// (get) Token: 0x060049EB RID: 18923 RVA: 0x0006DBD4 File Offset: 0x0006BDD4
		// (set) Token: 0x060049EC RID: 18924 RVA: 0x0006DC17 File Offset: 0x0006BE17
		public FRigElementKeyCollection Collection
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKeyCollection result;
				if ((result = this._Collection) == null)
				{
					result = (this._Collection = new FRigElementKeyCollection(base.NativePtr + (IntPtr)FRigUnit_CollectionItems.__PropertyOffset_Collection, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKeyCollection.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_CollectionItems.__PropertyOffset_Collection, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060049ED RID: 18925 RVA: 0x0006DC38 File Offset: 0x0006BE38
		public FRigUnit_CollectionItems()
		{
		}

		// Token: 0x060049EE RID: 18926 RVA: 0x0006DC40 File Offset: 0x0006BE40
		public FRigUnit_CollectionItems(TArray<FRigElementKey> Items, FRigElementKeyCollection Collection)
		{
			this.Items = Items;
			this.Collection = Collection;
		}

		// Token: 0x060049EF RID: 18927 RVA: 0x0006DC56 File Offset: 0x0006BE56
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_CollectionItems.StaticStruct();
		}

		// Token: 0x060049F0 RID: 18928 RVA: 0x0006DC62 File Offset: 0x0006BE62
		[NullableContext(2)]
		public FRigUnit_CollectionItems(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060049F1 RID: 18929 RVA: 0x0006DC6C File Offset: 0x0006BE6C
		public FRigUnit_CollectionItems(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060049F2 RID: 18930 RVA: 0x0006DC77 File Offset: 0x0006BE77
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_CollectionItems(Pointer, false, true);
		}

		// Token: 0x060049F3 RID: 18931 RVA: 0x0006DC81 File Offset: 0x0006BE81
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_CollectionItems(Pointer, MemoryOwner);
		}

		// Token: 0x040023E4 RID: 9188
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_CollectionItems";

		// Token: 0x040023E5 RID: 9189
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040023E6 RID: 9190
		internal static int __PropertyOffset_Items;

		// Token: 0x040023E7 RID: 9191
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRigElementKey> _Items;

		// Token: 0x040023E8 RID: 9192
		internal static int __PropertyOffset_Collection;

		// Token: 0x040023E9 RID: 9193
		[Nullable(2)]
		private FRigElementKeyCollection _Collection;
	}
}
