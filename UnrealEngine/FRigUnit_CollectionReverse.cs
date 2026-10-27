using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000571 RID: 1393
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_CollectionReverse")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FRigUnit_CollectionReverse : FRigUnit_CollectionBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004A32 RID: 18994 RVA: 0x0006E30E File Offset: 0x0006C50E
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_CollectionReverse._ScriptStructPtr != 0) ? FRigUnit_CollectionReverse._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_CollectionReverse", ref FRigUnit_CollectionReverse._ScriptStructPtr);
		}

		// Token: 0x1700122A RID: 4650
		// (get) Token: 0x06004A33 RID: 18995 RVA: 0x0006E334 File Offset: 0x0006C534
		// (set) Token: 0x06004A34 RID: 18996 RVA: 0x0006E377 File Offset: 0x0006C577
		public FRigElementKeyCollection Collection
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKeyCollection result;
				if ((result = this._Collection) == null)
				{
					result = (this._Collection = new FRigElementKeyCollection(base.NativePtr + (IntPtr)FRigUnit_CollectionReverse.__PropertyOffset_Collection, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKeyCollection.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_CollectionReverse.__PropertyOffset_Collection, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700122B RID: 4651
		// (get) Token: 0x06004A35 RID: 18997 RVA: 0x0006E398 File Offset: 0x0006C598
		// (set) Token: 0x06004A36 RID: 18998 RVA: 0x0006E3DB File Offset: 0x0006C5DB
		public FRigElementKeyCollection Reversed
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKeyCollection result;
				if ((result = this._Reversed) == null)
				{
					result = (this._Reversed = new FRigElementKeyCollection(base.NativePtr + (IntPtr)FRigUnit_CollectionReverse.__PropertyOffset_Reversed, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKeyCollection.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_CollectionReverse.__PropertyOffset_Reversed, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06004A37 RID: 18999 RVA: 0x0006E3FC File Offset: 0x0006C5FC
		public FRigUnit_CollectionReverse()
		{
		}

		// Token: 0x06004A38 RID: 19000 RVA: 0x0006E404 File Offset: 0x0006C604
		public FRigUnit_CollectionReverse(FRigElementKeyCollection Collection, FRigElementKeyCollection Reversed)
		{
			this.Collection = Collection;
			this.Reversed = Reversed;
		}

		// Token: 0x06004A39 RID: 19001 RVA: 0x0006E41A File Offset: 0x0006C61A
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_CollectionReverse.StaticStruct();
		}

		// Token: 0x06004A3A RID: 19002 RVA: 0x0006E426 File Offset: 0x0006C626
		[NullableContext(2)]
		public FRigUnit_CollectionReverse(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004A3B RID: 19003 RVA: 0x0006E430 File Offset: 0x0006C630
		public FRigUnit_CollectionReverse(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004A3C RID: 19004 RVA: 0x0006E43B File Offset: 0x0006C63B
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_CollectionReverse(Pointer, false, true);
		}

		// Token: 0x06004A3D RID: 19005 RVA: 0x0006E445 File Offset: 0x0006C645
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_CollectionReverse(Pointer, MemoryOwner);
		}

		// Token: 0x0400240B RID: 9227
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_CollectionReverse";

		// Token: 0x0400240C RID: 9228
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400240D RID: 9229
		internal static int __PropertyOffset_Collection;

		// Token: 0x0400240E RID: 9230
		[Nullable(2)]
		private FRigElementKeyCollection _Collection;

		// Token: 0x0400240F RID: 9231
		internal static int __PropertyOffset_Reversed;

		// Token: 0x04002410 RID: 9232
		[Nullable(2)]
		private FRigElementKeyCollection _Reversed;
	}
}
