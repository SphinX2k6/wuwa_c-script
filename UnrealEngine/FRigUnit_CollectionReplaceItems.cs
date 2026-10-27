using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000570 RID: 1392
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_CollectionReplaceItems")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FRigUnit_CollectionReplaceItems : FRigUnit_CollectionBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004A1C RID: 18972 RVA: 0x0006E0AE File Offset: 0x0006C2AE
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_CollectionReplaceItems._ScriptStructPtr != 0) ? FRigUnit_CollectionReplaceItems._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_CollectionReplaceItems", ref FRigUnit_CollectionReplaceItems._ScriptStructPtr);
		}

		// Token: 0x17001223 RID: 4643
		// (get) Token: 0x06004A1D RID: 18973 RVA: 0x0006E0D4 File Offset: 0x0006C2D4
		// (set) Token: 0x06004A1E RID: 18974 RVA: 0x0006E117 File Offset: 0x0006C317
		public FRigElementKeyCollection Items
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKeyCollection result;
				if ((result = this._Items) == null)
				{
					result = (this._Items = new FRigElementKeyCollection(base.NativePtr + (IntPtr)FRigUnit_CollectionReplaceItems.__PropertyOffset_Items, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKeyCollection.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_CollectionReplaceItems.__PropertyOffset_Items, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001224 RID: 4644
		// (get) Token: 0x06004A1F RID: 18975 RVA: 0x0006E138 File Offset: 0x0006C338
		// (set) Token: 0x06004A20 RID: 18976 RVA: 0x0006E14C File Offset: 0x0006C34C
		public unsafe FName Old
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_CollectionReplaceItems.__PropertyOffset_Old);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_CollectionReplaceItems.__PropertyOffset_Old) = value;
			}
		}

		// Token: 0x17001225 RID: 4645
		// (get) Token: 0x06004A21 RID: 18977 RVA: 0x0006E161 File Offset: 0x0006C361
		// (set) Token: 0x06004A22 RID: 18978 RVA: 0x0006E175 File Offset: 0x0006C375
		public unsafe FName New
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_CollectionReplaceItems.__PropertyOffset_New);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_CollectionReplaceItems.__PropertyOffset_New) = value;
			}
		}

		// Token: 0x17001226 RID: 4646
		// (get) Token: 0x06004A23 RID: 18979 RVA: 0x0006E18A File Offset: 0x0006C38A
		// (set) Token: 0x06004A24 RID: 18980 RVA: 0x0006E19A File Offset: 0x0006C39A
		public unsafe bool RemoveInvalidItems
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_CollectionReplaceItems.__PropertyOffset_RemoveInvalidItems) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_CollectionReplaceItems.__PropertyOffset_RemoveInvalidItems) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001227 RID: 4647
		// (get) Token: 0x06004A25 RID: 18981 RVA: 0x0006E1AC File Offset: 0x0006C3AC
		// (set) Token: 0x06004A26 RID: 18982 RVA: 0x0006E1EF File Offset: 0x0006C3EF
		public FRigElementKeyCollection Collection
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKeyCollection result;
				if ((result = this._Collection) == null)
				{
					result = (this._Collection = new FRigElementKeyCollection(base.NativePtr + (IntPtr)FRigUnit_CollectionReplaceItems.__PropertyOffset_Collection, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKeyCollection.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_CollectionReplaceItems.__PropertyOffset_Collection, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001228 RID: 4648
		// (get) Token: 0x06004A27 RID: 18983 RVA: 0x0006E210 File Offset: 0x0006C410
		// (set) Token: 0x06004A28 RID: 18984 RVA: 0x0006E253 File Offset: 0x0006C453
		public FRigElementKeyCollection CachedCollection
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKeyCollection result;
				if ((result = this._CachedCollection) == null)
				{
					result = (this._CachedCollection = new FRigElementKeyCollection(base.NativePtr + (IntPtr)FRigUnit_CollectionReplaceItems.__PropertyOffset_CachedCollection, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKeyCollection.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_CollectionReplaceItems.__PropertyOffset_CachedCollection, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001229 RID: 4649
		// (get) Token: 0x06004A29 RID: 18985 RVA: 0x0006E274 File Offset: 0x0006C474
		// (set) Token: 0x06004A2A RID: 18986 RVA: 0x0006E284 File Offset: 0x0006C484
		public unsafe int CachedHierarchyHash
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_CollectionReplaceItems.__PropertyOffset_CachedHierarchyHash);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_CollectionReplaceItems.__PropertyOffset_CachedHierarchyHash) = value;
			}
		}

		// Token: 0x06004A2B RID: 18987 RVA: 0x0006E295 File Offset: 0x0006C495
		public FRigUnit_CollectionReplaceItems()
		{
		}

		// Token: 0x06004A2C RID: 18988 RVA: 0x0006E29D File Offset: 0x0006C49D
		public FRigUnit_CollectionReplaceItems(FRigElementKeyCollection Items, FName Old, FName New, bool RemoveInvalidItems, FRigElementKeyCollection Collection, FRigElementKeyCollection CachedCollection, int CachedHierarchyHash)
		{
			this.Items = Items;
			this.Old = Old;
			this.New = New;
			this.RemoveInvalidItems = RemoveInvalidItems;
			this.Collection = Collection;
			this.CachedCollection = CachedCollection;
			this.CachedHierarchyHash = CachedHierarchyHash;
		}

		// Token: 0x06004A2D RID: 18989 RVA: 0x0006E2DA File Offset: 0x0006C4DA
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_CollectionReplaceItems.StaticStruct();
		}

		// Token: 0x06004A2E RID: 18990 RVA: 0x0006E2E6 File Offset: 0x0006C4E6
		[NullableContext(2)]
		public FRigUnit_CollectionReplaceItems(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004A2F RID: 18991 RVA: 0x0006E2F0 File Offset: 0x0006C4F0
		public FRigUnit_CollectionReplaceItems(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004A30 RID: 18992 RVA: 0x0006E2FB File Offset: 0x0006C4FB
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_CollectionReplaceItems(Pointer, false, true);
		}

		// Token: 0x06004A31 RID: 18993 RVA: 0x0006E305 File Offset: 0x0006C505
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_CollectionReplaceItems(Pointer, MemoryOwner);
		}

		// Token: 0x040023FF RID: 9215
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_CollectionReplaceItems";

		// Token: 0x04002400 RID: 9216
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002401 RID: 9217
		internal static int __PropertyOffset_Items;

		// Token: 0x04002402 RID: 9218
		[Nullable(2)]
		private FRigElementKeyCollection _Items;

		// Token: 0x04002403 RID: 9219
		internal static int __PropertyOffset_Old;

		// Token: 0x04002404 RID: 9220
		internal static int __PropertyOffset_New;

		// Token: 0x04002405 RID: 9221
		internal static int __PropertyOffset_RemoveInvalidItems;

		// Token: 0x04002406 RID: 9222
		internal static int __PropertyOffset_Collection;

		// Token: 0x04002407 RID: 9223
		[Nullable(2)]
		private FRigElementKeyCollection _Collection;

		// Token: 0x04002408 RID: 9224
		internal static int __PropertyOffset_CachedCollection;

		// Token: 0x04002409 RID: 9225
		[Nullable(2)]
		private FRigElementKeyCollection _CachedCollection;

		// Token: 0x0400240A RID: 9226
		internal static int __PropertyOffset_CachedHierarchyHash;
	}
}
