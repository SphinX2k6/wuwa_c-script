using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020006C1 RID: 1729
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_SetMultiControlBool")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 144)]
	public class FRigUnit_SetMultiControlBool : FRigUnitMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005C71 RID: 23665 RVA: 0x00084B4D File Offset: 0x00082D4D
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_SetMultiControlBool._ScriptStructPtr != 0) ? FRigUnit_SetMultiControlBool._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_SetMultiControlBool", ref FRigUnit_SetMultiControlBool._ScriptStructPtr);
		}

		// Token: 0x17001612 RID: 5650
		// (get) Token: 0x06005C72 RID: 23666 RVA: 0x00084B74 File Offset: 0x00082D74
		// (set) Token: 0x06005C73 RID: 23667 RVA: 0x00084BB7 File Offset: 0x00082DB7
		public TArray<FRigUnit_SetMultiControlBool_Entry> Entries
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRigUnit_SetMultiControlBool_Entry> result;
				if ((result = this._Entries) == null)
				{
					result = (this._Entries = new TArray<FRigUnit_SetMultiControlBool_Entry>(base.NativePtr + (IntPtr)FRigUnit_SetMultiControlBool.__PropertyOffset_Entries, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Entries.CopyAssign(value);
			}
		}

		// Token: 0x17001613 RID: 5651
		// (get) Token: 0x06005C74 RID: 23668 RVA: 0x00084BC8 File Offset: 0x00082DC8
		// (set) Token: 0x06005C75 RID: 23669 RVA: 0x00084C0B File Offset: 0x00082E0B
		public TArray<FCachedRigElement> CachedControlIndices
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FCachedRigElement> result;
				if ((result = this._CachedControlIndices) == null)
				{
					result = (this._CachedControlIndices = new TArray<FCachedRigElement>(base.NativePtr + (IntPtr)FRigUnit_SetMultiControlBool.__PropertyOffset_CachedControlIndices, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CachedControlIndices.CopyAssign(value);
			}
		}

		// Token: 0x06005C76 RID: 23670 RVA: 0x00084C19 File Offset: 0x00082E19
		public FRigUnit_SetMultiControlBool()
		{
		}

		// Token: 0x06005C77 RID: 23671 RVA: 0x00084C21 File Offset: 0x00082E21
		public FRigUnit_SetMultiControlBool(TArray<FRigUnit_SetMultiControlBool_Entry> Entries, TArray<FCachedRigElement> CachedControlIndices, FControlRigExecuteContext ExecuteContext)
		{
			this.Entries = Entries;
			this.CachedControlIndices = CachedControlIndices;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06005C78 RID: 23672 RVA: 0x00084C3E File Offset: 0x00082E3E
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_SetMultiControlBool.StaticStruct();
		}

		// Token: 0x06005C79 RID: 23673 RVA: 0x00084C4A File Offset: 0x00082E4A
		[NullableContext(2)]
		public FRigUnit_SetMultiControlBool(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005C7A RID: 23674 RVA: 0x00084C54 File Offset: 0x00082E54
		public FRigUnit_SetMultiControlBool(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005C7B RID: 23675 RVA: 0x00084C5F File Offset: 0x00082E5F
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_SetMultiControlBool(Pointer, false, true);
		}

		// Token: 0x06005C7C RID: 23676 RVA: 0x00084C69 File Offset: 0x00082E69
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_SetMultiControlBool(Pointer, MemoryOwner);
		}

		// Token: 0x04002B44 RID: 11076
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_SetMultiControlBool";

		// Token: 0x04002B45 RID: 11077
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002B46 RID: 11078
		internal static int __PropertyOffset_Entries;

		// Token: 0x04002B47 RID: 11079
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRigUnit_SetMultiControlBool_Entry> _Entries;

		// Token: 0x04002B48 RID: 11080
		internal static int __PropertyOffset_CachedControlIndices;

		// Token: 0x04002B49 RID: 11081
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FCachedRigElement> _CachedControlIndices;
	}
}
