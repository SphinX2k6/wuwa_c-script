using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200056B RID: 1387
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_CollectionIntersection")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FRigUnit_CollectionIntersection : FRigUnit_CollectionBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060049CC RID: 18892 RVA: 0x0006D841 File Offset: 0x0006BA41
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_CollectionIntersection._ScriptStructPtr != 0) ? FRigUnit_CollectionIntersection._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_CollectionIntersection", ref FRigUnit_CollectionIntersection._ScriptStructPtr);
		}

		// Token: 0x1700120F RID: 4623
		// (get) Token: 0x060049CD RID: 18893 RVA: 0x0006D868 File Offset: 0x0006BA68
		// (set) Token: 0x060049CE RID: 18894 RVA: 0x0006D8AB File Offset: 0x0006BAAB
		public FRigElementKeyCollection A
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKeyCollection result;
				if ((result = this._A) == null)
				{
					result = (this._A = new FRigElementKeyCollection(base.NativePtr + (IntPtr)FRigUnit_CollectionIntersection.__PropertyOffset_A, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKeyCollection.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_CollectionIntersection.__PropertyOffset_A, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001210 RID: 4624
		// (get) Token: 0x060049CF RID: 18895 RVA: 0x0006D8CC File Offset: 0x0006BACC
		// (set) Token: 0x060049D0 RID: 18896 RVA: 0x0006D90F File Offset: 0x0006BB0F
		public FRigElementKeyCollection B
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKeyCollection result;
				if ((result = this._B) == null)
				{
					result = (this._B = new FRigElementKeyCollection(base.NativePtr + (IntPtr)FRigUnit_CollectionIntersection.__PropertyOffset_B, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKeyCollection.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_CollectionIntersection.__PropertyOffset_B, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001211 RID: 4625
		// (get) Token: 0x060049D1 RID: 18897 RVA: 0x0006D930 File Offset: 0x0006BB30
		// (set) Token: 0x060049D2 RID: 18898 RVA: 0x0006D973 File Offset: 0x0006BB73
		public FRigElementKeyCollection Collection
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKeyCollection result;
				if ((result = this._Collection) == null)
				{
					result = (this._Collection = new FRigElementKeyCollection(base.NativePtr + (IntPtr)FRigUnit_CollectionIntersection.__PropertyOffset_Collection, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKeyCollection.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_CollectionIntersection.__PropertyOffset_Collection, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060049D3 RID: 18899 RVA: 0x0006D994 File Offset: 0x0006BB94
		public FRigUnit_CollectionIntersection()
		{
		}

		// Token: 0x060049D4 RID: 18900 RVA: 0x0006D99C File Offset: 0x0006BB9C
		public FRigUnit_CollectionIntersection(FRigElementKeyCollection A, FRigElementKeyCollection B, FRigElementKeyCollection Collection)
		{
			this.A = A;
			this.B = B;
			this.Collection = Collection;
		}

		// Token: 0x060049D5 RID: 18901 RVA: 0x0006D9B9 File Offset: 0x0006BBB9
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_CollectionIntersection.StaticStruct();
		}

		// Token: 0x060049D6 RID: 18902 RVA: 0x0006D9C5 File Offset: 0x0006BBC5
		[NullableContext(2)]
		public FRigUnit_CollectionIntersection(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060049D7 RID: 18903 RVA: 0x0006D9CF File Offset: 0x0006BBCF
		public FRigUnit_CollectionIntersection(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060049D8 RID: 18904 RVA: 0x0006D9DA File Offset: 0x0006BBDA
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_CollectionIntersection(Pointer, false, true);
		}

		// Token: 0x060049D9 RID: 18905 RVA: 0x0006D9E4 File Offset: 0x0006BBE4
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_CollectionIntersection(Pointer, MemoryOwner);
		}

		// Token: 0x040023D5 RID: 9173
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_CollectionIntersection";

		// Token: 0x040023D6 RID: 9174
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040023D7 RID: 9175
		internal static int __PropertyOffset_A;

		// Token: 0x040023D8 RID: 9176
		[Nullable(2)]
		private FRigElementKeyCollection _A;

		// Token: 0x040023D9 RID: 9177
		internal static int __PropertyOffset_B;

		// Token: 0x040023DA RID: 9178
		[Nullable(2)]
		private FRigElementKeyCollection _B;

		// Token: 0x040023DB RID: 9179
		internal static int __PropertyOffset_Collection;

		// Token: 0x040023DC RID: 9180
		[Nullable(2)]
		private FRigElementKeyCollection _Collection;
	}
}
