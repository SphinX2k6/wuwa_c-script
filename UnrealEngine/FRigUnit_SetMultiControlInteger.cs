using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020006C5 RID: 1733
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_SetMultiControlInteger")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 152)]
	public class FRigUnit_SetMultiControlInteger : FRigUnitMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005CA3 RID: 23715 RVA: 0x00084F3E File Offset: 0x0008313E
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_SetMultiControlInteger._ScriptStructPtr != 0) ? FRigUnit_SetMultiControlInteger._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_SetMultiControlInteger", ref FRigUnit_SetMultiControlInteger._ScriptStructPtr);
		}

		// Token: 0x1700161B RID: 5659
		// (get) Token: 0x06005CA4 RID: 23716 RVA: 0x00084F64 File Offset: 0x00083164
		// (set) Token: 0x06005CA5 RID: 23717 RVA: 0x00084FA7 File Offset: 0x000831A7
		public TArray<FRigUnit_SetMultiControlInteger_Entry> Entries
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRigUnit_SetMultiControlInteger_Entry> result;
				if ((result = this._Entries) == null)
				{
					result = (this._Entries = new TArray<FRigUnit_SetMultiControlInteger_Entry>(base.NativePtr + (IntPtr)FRigUnit_SetMultiControlInteger.__PropertyOffset_Entries, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Entries.CopyAssign(value);
			}
		}

		// Token: 0x1700161C RID: 5660
		// (get) Token: 0x06005CA6 RID: 23718 RVA: 0x00084FB5 File Offset: 0x000831B5
		// (set) Token: 0x06005CA7 RID: 23719 RVA: 0x00084FC5 File Offset: 0x000831C5
		public unsafe float Weight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetMultiControlInteger.__PropertyOffset_Weight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetMultiControlInteger.__PropertyOffset_Weight) = value;
			}
		}

		// Token: 0x1700161D RID: 5661
		// (get) Token: 0x06005CA8 RID: 23720 RVA: 0x00084FD8 File Offset: 0x000831D8
		// (set) Token: 0x06005CA9 RID: 23721 RVA: 0x0008501B File Offset: 0x0008321B
		public TArray<FCachedRigElement> CachedControlIndices
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FCachedRigElement> result;
				if ((result = this._CachedControlIndices) == null)
				{
					result = (this._CachedControlIndices = new TArray<FCachedRigElement>(base.NativePtr + (IntPtr)FRigUnit_SetMultiControlInteger.__PropertyOffset_CachedControlIndices, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CachedControlIndices.CopyAssign(value);
			}
		}

		// Token: 0x06005CAA RID: 23722 RVA: 0x00085029 File Offset: 0x00083229
		public FRigUnit_SetMultiControlInteger()
		{
		}

		// Token: 0x06005CAB RID: 23723 RVA: 0x00085031 File Offset: 0x00083231
		public FRigUnit_SetMultiControlInteger(TArray<FRigUnit_SetMultiControlInteger_Entry> Entries, float Weight, TArray<FCachedRigElement> CachedControlIndices, FControlRigExecuteContext ExecuteContext)
		{
			this.Entries = Entries;
			this.Weight = Weight;
			this.CachedControlIndices = CachedControlIndices;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06005CAC RID: 23724 RVA: 0x00085056 File Offset: 0x00083256
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_SetMultiControlInteger.StaticStruct();
		}

		// Token: 0x06005CAD RID: 23725 RVA: 0x00085062 File Offset: 0x00083262
		[NullableContext(2)]
		public FRigUnit_SetMultiControlInteger(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005CAE RID: 23726 RVA: 0x0008506C File Offset: 0x0008326C
		public FRigUnit_SetMultiControlInteger(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005CAF RID: 23727 RVA: 0x00085077 File Offset: 0x00083277
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_SetMultiControlInteger(Pointer, false, true);
		}

		// Token: 0x06005CB0 RID: 23728 RVA: 0x00085081 File Offset: 0x00083281
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_SetMultiControlInteger(Pointer, MemoryOwner);
		}

		// Token: 0x04002B59 RID: 11097
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_SetMultiControlInteger";

		// Token: 0x04002B5A RID: 11098
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002B5B RID: 11099
		internal static int __PropertyOffset_Entries;

		// Token: 0x04002B5C RID: 11100
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRigUnit_SetMultiControlInteger_Entry> _Entries;

		// Token: 0x04002B5D RID: 11101
		internal static int __PropertyOffset_Weight;

		// Token: 0x04002B5E RID: 11102
		internal static int __PropertyOffset_CachedControlIndices;

		// Token: 0x04002B5F RID: 11103
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FCachedRigElement> _CachedControlIndices;
	}
}
