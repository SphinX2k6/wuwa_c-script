using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020006C9 RID: 1737
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_SetMultiControlVector2D")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 152)]
	public class FRigUnit_SetMultiControlVector2D : FRigUnitMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005CD9 RID: 23769 RVA: 0x00085386 File Offset: 0x00083586
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_SetMultiControlVector2D._ScriptStructPtr != 0) ? FRigUnit_SetMultiControlVector2D._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_SetMultiControlVector2D", ref FRigUnit_SetMultiControlVector2D._ScriptStructPtr);
		}

		// Token: 0x17001626 RID: 5670
		// (get) Token: 0x06005CDA RID: 23770 RVA: 0x000853AC File Offset: 0x000835AC
		// (set) Token: 0x06005CDB RID: 23771 RVA: 0x000853EF File Offset: 0x000835EF
		public TArray<FRigUnit_SetMultiControlVector2D_Entry> Entries
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRigUnit_SetMultiControlVector2D_Entry> result;
				if ((result = this._Entries) == null)
				{
					result = (this._Entries = new TArray<FRigUnit_SetMultiControlVector2D_Entry>(base.NativePtr + (IntPtr)FRigUnit_SetMultiControlVector2D.__PropertyOffset_Entries, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Entries.CopyAssign(value);
			}
		}

		// Token: 0x17001627 RID: 5671
		// (get) Token: 0x06005CDC RID: 23772 RVA: 0x000853FD File Offset: 0x000835FD
		// (set) Token: 0x06005CDD RID: 23773 RVA: 0x0008540D File Offset: 0x0008360D
		public unsafe float Weight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetMultiControlVector2D.__PropertyOffset_Weight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetMultiControlVector2D.__PropertyOffset_Weight) = value;
			}
		}

		// Token: 0x17001628 RID: 5672
		// (get) Token: 0x06005CDE RID: 23774 RVA: 0x00085420 File Offset: 0x00083620
		// (set) Token: 0x06005CDF RID: 23775 RVA: 0x00085463 File Offset: 0x00083663
		public TArray<FCachedRigElement> CachedControlIndices
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FCachedRigElement> result;
				if ((result = this._CachedControlIndices) == null)
				{
					result = (this._CachedControlIndices = new TArray<FCachedRigElement>(base.NativePtr + (IntPtr)FRigUnit_SetMultiControlVector2D.__PropertyOffset_CachedControlIndices, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CachedControlIndices.CopyAssign(value);
			}
		}

		// Token: 0x06005CE0 RID: 23776 RVA: 0x00085471 File Offset: 0x00083671
		public FRigUnit_SetMultiControlVector2D()
		{
		}

		// Token: 0x06005CE1 RID: 23777 RVA: 0x00085479 File Offset: 0x00083679
		public FRigUnit_SetMultiControlVector2D(TArray<FRigUnit_SetMultiControlVector2D_Entry> Entries, float Weight, TArray<FCachedRigElement> CachedControlIndices, FControlRigExecuteContext ExecuteContext)
		{
			this.Entries = Entries;
			this.Weight = Weight;
			this.CachedControlIndices = CachedControlIndices;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06005CE2 RID: 23778 RVA: 0x0008549E File Offset: 0x0008369E
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_SetMultiControlVector2D.StaticStruct();
		}

		// Token: 0x06005CE3 RID: 23779 RVA: 0x000854AA File Offset: 0x000836AA
		[NullableContext(2)]
		public FRigUnit_SetMultiControlVector2D(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005CE4 RID: 23780 RVA: 0x000854B4 File Offset: 0x000836B4
		public FRigUnit_SetMultiControlVector2D(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005CE5 RID: 23781 RVA: 0x000854BF File Offset: 0x000836BF
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_SetMultiControlVector2D(Pointer, false, true);
		}

		// Token: 0x06005CE6 RID: 23782 RVA: 0x000854C9 File Offset: 0x000836C9
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_SetMultiControlVector2D(Pointer, MemoryOwner);
		}

		// Token: 0x04002B70 RID: 11120
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_SetMultiControlVector2D";

		// Token: 0x04002B71 RID: 11121
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002B72 RID: 11122
		internal static int __PropertyOffset_Entries;

		// Token: 0x04002B73 RID: 11123
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRigUnit_SetMultiControlVector2D_Entry> _Entries;

		// Token: 0x04002B74 RID: 11124
		internal static int __PropertyOffset_Weight;

		// Token: 0x04002B75 RID: 11125
		internal static int __PropertyOffset_CachedControlIndices;

		// Token: 0x04002B76 RID: 11126
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FCachedRigElement> _CachedControlIndices;
	}
}
