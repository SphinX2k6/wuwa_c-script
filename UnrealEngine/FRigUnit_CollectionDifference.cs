using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200056A RID: 1386
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_CollectionDifference")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FRigUnit_CollectionDifference : FRigUnit_CollectionBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060049BE RID: 18878 RVA: 0x0006D697 File Offset: 0x0006B897
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_CollectionDifference._ScriptStructPtr != 0) ? FRigUnit_CollectionDifference._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_CollectionDifference", ref FRigUnit_CollectionDifference._ScriptStructPtr);
		}

		// Token: 0x1700120C RID: 4620
		// (get) Token: 0x060049BF RID: 18879 RVA: 0x0006D6BC File Offset: 0x0006B8BC
		// (set) Token: 0x060049C0 RID: 18880 RVA: 0x0006D6FF File Offset: 0x0006B8FF
		public FRigElementKeyCollection A
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKeyCollection result;
				if ((result = this._A) == null)
				{
					result = (this._A = new FRigElementKeyCollection(base.NativePtr + (IntPtr)FRigUnit_CollectionDifference.__PropertyOffset_A, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKeyCollection.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_CollectionDifference.__PropertyOffset_A, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700120D RID: 4621
		// (get) Token: 0x060049C1 RID: 18881 RVA: 0x0006D720 File Offset: 0x0006B920
		// (set) Token: 0x060049C2 RID: 18882 RVA: 0x0006D763 File Offset: 0x0006B963
		public FRigElementKeyCollection B
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKeyCollection result;
				if ((result = this._B) == null)
				{
					result = (this._B = new FRigElementKeyCollection(base.NativePtr + (IntPtr)FRigUnit_CollectionDifference.__PropertyOffset_B, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKeyCollection.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_CollectionDifference.__PropertyOffset_B, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700120E RID: 4622
		// (get) Token: 0x060049C3 RID: 18883 RVA: 0x0006D784 File Offset: 0x0006B984
		// (set) Token: 0x060049C4 RID: 18884 RVA: 0x0006D7C7 File Offset: 0x0006B9C7
		public FRigElementKeyCollection Collection
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKeyCollection result;
				if ((result = this._Collection) == null)
				{
					result = (this._Collection = new FRigElementKeyCollection(base.NativePtr + (IntPtr)FRigUnit_CollectionDifference.__PropertyOffset_Collection, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKeyCollection.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_CollectionDifference.__PropertyOffset_Collection, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060049C5 RID: 18885 RVA: 0x0006D7E8 File Offset: 0x0006B9E8
		public FRigUnit_CollectionDifference()
		{
		}

		// Token: 0x060049C6 RID: 18886 RVA: 0x0006D7F0 File Offset: 0x0006B9F0
		public FRigUnit_CollectionDifference(FRigElementKeyCollection A, FRigElementKeyCollection B, FRigElementKeyCollection Collection)
		{
			this.A = A;
			this.B = B;
			this.Collection = Collection;
		}

		// Token: 0x060049C7 RID: 18887 RVA: 0x0006D80D File Offset: 0x0006BA0D
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_CollectionDifference.StaticStruct();
		}

		// Token: 0x060049C8 RID: 18888 RVA: 0x0006D819 File Offset: 0x0006BA19
		[NullableContext(2)]
		public FRigUnit_CollectionDifference(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060049C9 RID: 18889 RVA: 0x0006D823 File Offset: 0x0006BA23
		public FRigUnit_CollectionDifference(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060049CA RID: 18890 RVA: 0x0006D82E File Offset: 0x0006BA2E
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_CollectionDifference(Pointer, false, true);
		}

		// Token: 0x060049CB RID: 18891 RVA: 0x0006D838 File Offset: 0x0006BA38
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_CollectionDifference(Pointer, MemoryOwner);
		}

		// Token: 0x040023CD RID: 9165
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_CollectionDifference";

		// Token: 0x040023CE RID: 9166
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040023CF RID: 9167
		internal static int __PropertyOffset_A;

		// Token: 0x040023D0 RID: 9168
		[Nullable(2)]
		private FRigElementKeyCollection _A;

		// Token: 0x040023D1 RID: 9169
		internal static int __PropertyOffset_B;

		// Token: 0x040023D2 RID: 9170
		[Nullable(2)]
		private FRigElementKeyCollection _B;

		// Token: 0x040023D3 RID: 9171
		internal static int __PropertyOffset_Collection;

		// Token: 0x040023D4 RID: 9172
		[Nullable(2)]
		private FRigElementKeyCollection _Collection;
	}
}
