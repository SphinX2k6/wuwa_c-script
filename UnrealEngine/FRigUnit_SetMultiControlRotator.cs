using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020006C7 RID: 1735
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_SetMultiControlRotator")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 152)]
	public class FRigUnit_SetMultiControlRotator : FRigUnitMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005CBD RID: 23741 RVA: 0x0008514A File Offset: 0x0008334A
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_SetMultiControlRotator._ScriptStructPtr != 0) ? FRigUnit_SetMultiControlRotator._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_SetMultiControlRotator", ref FRigUnit_SetMultiControlRotator._ScriptStructPtr);
		}

		// Token: 0x17001620 RID: 5664
		// (get) Token: 0x06005CBE RID: 23742 RVA: 0x00085170 File Offset: 0x00083370
		// (set) Token: 0x06005CBF RID: 23743 RVA: 0x000851B3 File Offset: 0x000833B3
		public TArray<FRigUnit_SetMultiControlRotator_Entry> Entries
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRigUnit_SetMultiControlRotator_Entry> result;
				if ((result = this._Entries) == null)
				{
					result = (this._Entries = new TArray<FRigUnit_SetMultiControlRotator_Entry>(base.NativePtr + (IntPtr)FRigUnit_SetMultiControlRotator.__PropertyOffset_Entries, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Entries.CopyAssign(value);
			}
		}

		// Token: 0x17001621 RID: 5665
		// (get) Token: 0x06005CC0 RID: 23744 RVA: 0x000851C1 File Offset: 0x000833C1
		// (set) Token: 0x06005CC1 RID: 23745 RVA: 0x000851D1 File Offset: 0x000833D1
		public unsafe float Weight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetMultiControlRotator.__PropertyOffset_Weight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetMultiControlRotator.__PropertyOffset_Weight) = value;
			}
		}

		// Token: 0x17001622 RID: 5666
		// (get) Token: 0x06005CC2 RID: 23746 RVA: 0x000851E4 File Offset: 0x000833E4
		// (set) Token: 0x06005CC3 RID: 23747 RVA: 0x00085227 File Offset: 0x00083427
		public TArray<FCachedRigElement> CachedControlIndices
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FCachedRigElement> result;
				if ((result = this._CachedControlIndices) == null)
				{
					result = (this._CachedControlIndices = new TArray<FCachedRigElement>(base.NativePtr + (IntPtr)FRigUnit_SetMultiControlRotator.__PropertyOffset_CachedControlIndices, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CachedControlIndices.CopyAssign(value);
			}
		}

		// Token: 0x06005CC4 RID: 23748 RVA: 0x00085235 File Offset: 0x00083435
		public FRigUnit_SetMultiControlRotator()
		{
		}

		// Token: 0x06005CC5 RID: 23749 RVA: 0x0008523D File Offset: 0x0008343D
		public FRigUnit_SetMultiControlRotator(TArray<FRigUnit_SetMultiControlRotator_Entry> Entries, float Weight, TArray<FCachedRigElement> CachedControlIndices, FControlRigExecuteContext ExecuteContext)
		{
			this.Entries = Entries;
			this.Weight = Weight;
			this.CachedControlIndices = CachedControlIndices;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06005CC6 RID: 23750 RVA: 0x00085262 File Offset: 0x00083462
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_SetMultiControlRotator.StaticStruct();
		}

		// Token: 0x06005CC7 RID: 23751 RVA: 0x0008526E File Offset: 0x0008346E
		[NullableContext(2)]
		public FRigUnit_SetMultiControlRotator(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005CC8 RID: 23752 RVA: 0x00085278 File Offset: 0x00083478
		public FRigUnit_SetMultiControlRotator(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005CC9 RID: 23753 RVA: 0x00085283 File Offset: 0x00083483
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_SetMultiControlRotator(Pointer, false, true);
		}

		// Token: 0x06005CCA RID: 23754 RVA: 0x0008528D File Offset: 0x0008348D
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_SetMultiControlRotator(Pointer, MemoryOwner);
		}

		// Token: 0x04002B64 RID: 11108
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_SetMultiControlRotator";

		// Token: 0x04002B65 RID: 11109
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002B66 RID: 11110
		internal static int __PropertyOffset_Entries;

		// Token: 0x04002B67 RID: 11111
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRigUnit_SetMultiControlRotator_Entry> _Entries;

		// Token: 0x04002B68 RID: 11112
		internal static int __PropertyOffset_Weight;

		// Token: 0x04002B69 RID: 11113
		internal static int __PropertyOffset_CachedControlIndices;

		// Token: 0x04002B6A RID: 11114
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FCachedRigElement> _CachedControlIndices;
	}
}
