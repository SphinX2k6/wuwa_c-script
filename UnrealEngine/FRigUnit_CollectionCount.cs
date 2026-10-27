using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000569 RID: 1385
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_CollectionCount")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FRigUnit_CollectionCount : FRigUnit_CollectionBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060049B2 RID: 18866 RVA: 0x0006D59A File Offset: 0x0006B79A
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_CollectionCount._ScriptStructPtr != 0) ? FRigUnit_CollectionCount._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_CollectionCount", ref FRigUnit_CollectionCount._ScriptStructPtr);
		}

		// Token: 0x1700120A RID: 4618
		// (get) Token: 0x060049B3 RID: 18867 RVA: 0x0006D5C0 File Offset: 0x0006B7C0
		// (set) Token: 0x060049B4 RID: 18868 RVA: 0x0006D603 File Offset: 0x0006B803
		public FRigElementKeyCollection Collection
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKeyCollection result;
				if ((result = this._Collection) == null)
				{
					result = (this._Collection = new FRigElementKeyCollection(base.NativePtr + (IntPtr)FRigUnit_CollectionCount.__PropertyOffset_Collection, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKeyCollection.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_CollectionCount.__PropertyOffset_Collection, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700120B RID: 4619
		// (get) Token: 0x060049B5 RID: 18869 RVA: 0x0006D624 File Offset: 0x0006B824
		// (set) Token: 0x060049B6 RID: 18870 RVA: 0x0006D634 File Offset: 0x0006B834
		public unsafe int Count
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_CollectionCount.__PropertyOffset_Count);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_CollectionCount.__PropertyOffset_Count) = value;
			}
		}

		// Token: 0x060049B7 RID: 18871 RVA: 0x0006D645 File Offset: 0x0006B845
		public FRigUnit_CollectionCount()
		{
		}

		// Token: 0x060049B8 RID: 18872 RVA: 0x0006D64D File Offset: 0x0006B84D
		public FRigUnit_CollectionCount(FRigElementKeyCollection Collection, int Count)
		{
			this.Collection = Collection;
			this.Count = Count;
		}

		// Token: 0x060049B9 RID: 18873 RVA: 0x0006D663 File Offset: 0x0006B863
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_CollectionCount.StaticStruct();
		}

		// Token: 0x060049BA RID: 18874 RVA: 0x0006D66F File Offset: 0x0006B86F
		[NullableContext(2)]
		public FRigUnit_CollectionCount(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060049BB RID: 18875 RVA: 0x0006D679 File Offset: 0x0006B879
		public FRigUnit_CollectionCount(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060049BC RID: 18876 RVA: 0x0006D684 File Offset: 0x0006B884
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_CollectionCount(Pointer, false, true);
		}

		// Token: 0x060049BD RID: 18877 RVA: 0x0006D68E File Offset: 0x0006B88E
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_CollectionCount(Pointer, MemoryOwner);
		}

		// Token: 0x040023C8 RID: 9160
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_CollectionCount";

		// Token: 0x040023C9 RID: 9161
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040023CA RID: 9162
		internal static int __PropertyOffset_Collection;

		// Token: 0x040023CB RID: 9163
		[Nullable(2)]
		private FRigElementKeyCollection _Collection;

		// Token: 0x040023CC RID: 9164
		internal static int __PropertyOffset_Count;
	}
}
