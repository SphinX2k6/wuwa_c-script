using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000572 RID: 1394
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_CollectionUnion")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FRigUnit_CollectionUnion : FRigUnit_CollectionBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004A3E RID: 19006 RVA: 0x0006E44E File Offset: 0x0006C64E
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_CollectionUnion._ScriptStructPtr != 0) ? FRigUnit_CollectionUnion._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_CollectionUnion", ref FRigUnit_CollectionUnion._ScriptStructPtr);
		}

		// Token: 0x1700122C RID: 4652
		// (get) Token: 0x06004A3F RID: 19007 RVA: 0x0006E474 File Offset: 0x0006C674
		// (set) Token: 0x06004A40 RID: 19008 RVA: 0x0006E4B7 File Offset: 0x0006C6B7
		public FRigElementKeyCollection A
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKeyCollection result;
				if ((result = this._A) == null)
				{
					result = (this._A = new FRigElementKeyCollection(base.NativePtr + (IntPtr)FRigUnit_CollectionUnion.__PropertyOffset_A, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKeyCollection.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_CollectionUnion.__PropertyOffset_A, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700122D RID: 4653
		// (get) Token: 0x06004A41 RID: 19009 RVA: 0x0006E4D8 File Offset: 0x0006C6D8
		// (set) Token: 0x06004A42 RID: 19010 RVA: 0x0006E51B File Offset: 0x0006C71B
		public FRigElementKeyCollection B
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKeyCollection result;
				if ((result = this._B) == null)
				{
					result = (this._B = new FRigElementKeyCollection(base.NativePtr + (IntPtr)FRigUnit_CollectionUnion.__PropertyOffset_B, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKeyCollection.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_CollectionUnion.__PropertyOffset_B, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700122E RID: 4654
		// (get) Token: 0x06004A43 RID: 19011 RVA: 0x0006E53C File Offset: 0x0006C73C
		// (set) Token: 0x06004A44 RID: 19012 RVA: 0x0006E57F File Offset: 0x0006C77F
		public FRigElementKeyCollection Collection
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKeyCollection result;
				if ((result = this._Collection) == null)
				{
					result = (this._Collection = new FRigElementKeyCollection(base.NativePtr + (IntPtr)FRigUnit_CollectionUnion.__PropertyOffset_Collection, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKeyCollection.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_CollectionUnion.__PropertyOffset_Collection, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06004A45 RID: 19013 RVA: 0x0006E5A0 File Offset: 0x0006C7A0
		public FRigUnit_CollectionUnion()
		{
		}

		// Token: 0x06004A46 RID: 19014 RVA: 0x0006E5A8 File Offset: 0x0006C7A8
		public FRigUnit_CollectionUnion(FRigElementKeyCollection A, FRigElementKeyCollection B, FRigElementKeyCollection Collection)
		{
			this.A = A;
			this.B = B;
			this.Collection = Collection;
		}

		// Token: 0x06004A47 RID: 19015 RVA: 0x0006E5C5 File Offset: 0x0006C7C5
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_CollectionUnion.StaticStruct();
		}

		// Token: 0x06004A48 RID: 19016 RVA: 0x0006E5D1 File Offset: 0x0006C7D1
		[NullableContext(2)]
		public FRigUnit_CollectionUnion(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004A49 RID: 19017 RVA: 0x0006E5DB File Offset: 0x0006C7DB
		public FRigUnit_CollectionUnion(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004A4A RID: 19018 RVA: 0x0006E5E6 File Offset: 0x0006C7E6
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_CollectionUnion(Pointer, false, true);
		}

		// Token: 0x06004A4B RID: 19019 RVA: 0x0006E5F0 File Offset: 0x0006C7F0
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_CollectionUnion(Pointer, MemoryOwner);
		}

		// Token: 0x04002411 RID: 9233
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_CollectionUnion";

		// Token: 0x04002412 RID: 9234
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002413 RID: 9235
		internal static int __PropertyOffset_A;

		// Token: 0x04002414 RID: 9236
		[Nullable(2)]
		private FRigElementKeyCollection _A;

		// Token: 0x04002415 RID: 9237
		internal static int __PropertyOffset_B;

		// Token: 0x04002416 RID: 9238
		[Nullable(2)]
		private FRigElementKeyCollection _B;

		// Token: 0x04002417 RID: 9239
		internal static int __PropertyOffset_Collection;

		// Token: 0x04002418 RID: 9240
		[Nullable(2)]
		private FRigElementKeyCollection _Collection;
	}
}
