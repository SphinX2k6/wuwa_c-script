using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200056F RID: 1391
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_CollectionNameSearch")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FRigUnit_CollectionNameSearch : FRigUnit_CollectionBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004A0A RID: 18954 RVA: 0x0006DEEC File Offset: 0x0006C0EC
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_CollectionNameSearch._ScriptStructPtr != 0) ? FRigUnit_CollectionNameSearch._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_CollectionNameSearch", ref FRigUnit_CollectionNameSearch._ScriptStructPtr);
		}

		// Token: 0x1700121E RID: 4638
		// (get) Token: 0x06004A0B RID: 18955 RVA: 0x0006DF10 File Offset: 0x0006C110
		// (set) Token: 0x06004A0C RID: 18956 RVA: 0x0006DF24 File Offset: 0x0006C124
		public unsafe FName PartialName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_CollectionNameSearch.__PropertyOffset_PartialName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_CollectionNameSearch.__PropertyOffset_PartialName) = value;
			}
		}

		// Token: 0x1700121F RID: 4639
		// (get) Token: 0x06004A0D RID: 18957 RVA: 0x0006DF39 File Offset: 0x0006C139
		// (set) Token: 0x06004A0E RID: 18958 RVA: 0x0006DF49 File Offset: 0x0006C149
		public unsafe ERigElementType TypeToSearch
		{
			get
			{
				return (ERigElementType)(*(base.NativePtr + (IntPtr)FRigUnit_CollectionNameSearch.__PropertyOffset_TypeToSearch));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_CollectionNameSearch.__PropertyOffset_TypeToSearch) = (byte)value;
			}
		}

		// Token: 0x17001220 RID: 4640
		// (get) Token: 0x06004A0F RID: 18959 RVA: 0x0006DF5C File Offset: 0x0006C15C
		// (set) Token: 0x06004A10 RID: 18960 RVA: 0x0006DF9F File Offset: 0x0006C19F
		public FRigElementKeyCollection Collection
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKeyCollection result;
				if ((result = this._Collection) == null)
				{
					result = (this._Collection = new FRigElementKeyCollection(base.NativePtr + (IntPtr)FRigUnit_CollectionNameSearch.__PropertyOffset_Collection, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKeyCollection.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_CollectionNameSearch.__PropertyOffset_Collection, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001221 RID: 4641
		// (get) Token: 0x06004A11 RID: 18961 RVA: 0x0006DFC0 File Offset: 0x0006C1C0
		// (set) Token: 0x06004A12 RID: 18962 RVA: 0x0006E003 File Offset: 0x0006C203
		public FRigElementKeyCollection CachedCollection
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKeyCollection result;
				if ((result = this._CachedCollection) == null)
				{
					result = (this._CachedCollection = new FRigElementKeyCollection(base.NativePtr + (IntPtr)FRigUnit_CollectionNameSearch.__PropertyOffset_CachedCollection, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKeyCollection.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_CollectionNameSearch.__PropertyOffset_CachedCollection, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001222 RID: 4642
		// (get) Token: 0x06004A13 RID: 18963 RVA: 0x0006E024 File Offset: 0x0006C224
		// (set) Token: 0x06004A14 RID: 18964 RVA: 0x0006E034 File Offset: 0x0006C234
		public unsafe int CachedHierarchyHash
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_CollectionNameSearch.__PropertyOffset_CachedHierarchyHash);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_CollectionNameSearch.__PropertyOffset_CachedHierarchyHash) = value;
			}
		}

		// Token: 0x06004A15 RID: 18965 RVA: 0x0006E045 File Offset: 0x0006C245
		public FRigUnit_CollectionNameSearch()
		{
		}

		// Token: 0x06004A16 RID: 18966 RVA: 0x0006E04D File Offset: 0x0006C24D
		public FRigUnit_CollectionNameSearch(FName PartialName, ERigElementType TypeToSearch, FRigElementKeyCollection Collection, FRigElementKeyCollection CachedCollection, int CachedHierarchyHash)
		{
			this.PartialName = PartialName;
			this.TypeToSearch = TypeToSearch;
			this.Collection = Collection;
			this.CachedCollection = CachedCollection;
			this.CachedHierarchyHash = CachedHierarchyHash;
		}

		// Token: 0x06004A17 RID: 18967 RVA: 0x0006E07A File Offset: 0x0006C27A
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_CollectionNameSearch.StaticStruct();
		}

		// Token: 0x06004A18 RID: 18968 RVA: 0x0006E086 File Offset: 0x0006C286
		[NullableContext(2)]
		public FRigUnit_CollectionNameSearch(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004A19 RID: 18969 RVA: 0x0006E090 File Offset: 0x0006C290
		public FRigUnit_CollectionNameSearch(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004A1A RID: 18970 RVA: 0x0006E09B File Offset: 0x0006C29B
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_CollectionNameSearch(Pointer, false, true);
		}

		// Token: 0x06004A1B RID: 18971 RVA: 0x0006E0A5 File Offset: 0x0006C2A5
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_CollectionNameSearch(Pointer, MemoryOwner);
		}

		// Token: 0x040023F6 RID: 9206
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_CollectionNameSearch";

		// Token: 0x040023F7 RID: 9207
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040023F8 RID: 9208
		internal static int __PropertyOffset_PartialName;

		// Token: 0x040023F9 RID: 9209
		internal static int __PropertyOffset_TypeToSearch;

		// Token: 0x040023FA RID: 9210
		internal static int __PropertyOffset_Collection;

		// Token: 0x040023FB RID: 9211
		[Nullable(2)]
		private FRigElementKeyCollection _Collection;

		// Token: 0x040023FC RID: 9212
		internal static int __PropertyOffset_CachedCollection;

		// Token: 0x040023FD RID: 9213
		[Nullable(2)]
		private FRigElementKeyCollection _CachedCollection;

		// Token: 0x040023FE RID: 9214
		internal static int __PropertyOffset_CachedHierarchyHash;
	}
}
