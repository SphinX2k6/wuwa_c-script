using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020006C3 RID: 1731
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_SetMultiControlFloat")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 152)]
	public class FRigUnit_SetMultiControlFloat : FRigUnitMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005C89 RID: 23689 RVA: 0x00084D32 File Offset: 0x00082F32
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_SetMultiControlFloat._ScriptStructPtr != 0) ? FRigUnit_SetMultiControlFloat._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_SetMultiControlFloat", ref FRigUnit_SetMultiControlFloat._ScriptStructPtr);
		}

		// Token: 0x17001616 RID: 5654
		// (get) Token: 0x06005C8A RID: 23690 RVA: 0x00084D58 File Offset: 0x00082F58
		// (set) Token: 0x06005C8B RID: 23691 RVA: 0x00084D9B File Offset: 0x00082F9B
		public TArray<FRigUnit_SetMultiControlFloat_Entry> Entries
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRigUnit_SetMultiControlFloat_Entry> result;
				if ((result = this._Entries) == null)
				{
					result = (this._Entries = new TArray<FRigUnit_SetMultiControlFloat_Entry>(base.NativePtr + (IntPtr)FRigUnit_SetMultiControlFloat.__PropertyOffset_Entries, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Entries.CopyAssign(value);
			}
		}

		// Token: 0x17001617 RID: 5655
		// (get) Token: 0x06005C8C RID: 23692 RVA: 0x00084DA9 File Offset: 0x00082FA9
		// (set) Token: 0x06005C8D RID: 23693 RVA: 0x00084DB9 File Offset: 0x00082FB9
		public unsafe float Weight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetMultiControlFloat.__PropertyOffset_Weight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetMultiControlFloat.__PropertyOffset_Weight) = value;
			}
		}

		// Token: 0x17001618 RID: 5656
		// (get) Token: 0x06005C8E RID: 23694 RVA: 0x00084DCC File Offset: 0x00082FCC
		// (set) Token: 0x06005C8F RID: 23695 RVA: 0x00084E0F File Offset: 0x0008300F
		public TArray<FCachedRigElement> CachedControlIndices
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FCachedRigElement> result;
				if ((result = this._CachedControlIndices) == null)
				{
					result = (this._CachedControlIndices = new TArray<FCachedRigElement>(base.NativePtr + (IntPtr)FRigUnit_SetMultiControlFloat.__PropertyOffset_CachedControlIndices, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CachedControlIndices.CopyAssign(value);
			}
		}

		// Token: 0x06005C90 RID: 23696 RVA: 0x00084E1D File Offset: 0x0008301D
		public FRigUnit_SetMultiControlFloat()
		{
		}

		// Token: 0x06005C91 RID: 23697 RVA: 0x00084E25 File Offset: 0x00083025
		public FRigUnit_SetMultiControlFloat(TArray<FRigUnit_SetMultiControlFloat_Entry> Entries, float Weight, TArray<FCachedRigElement> CachedControlIndices, FControlRigExecuteContext ExecuteContext)
		{
			this.Entries = Entries;
			this.Weight = Weight;
			this.CachedControlIndices = CachedControlIndices;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06005C92 RID: 23698 RVA: 0x00084E4A File Offset: 0x0008304A
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_SetMultiControlFloat.StaticStruct();
		}

		// Token: 0x06005C93 RID: 23699 RVA: 0x00084E56 File Offset: 0x00083056
		[NullableContext(2)]
		public FRigUnit_SetMultiControlFloat(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005C94 RID: 23700 RVA: 0x00084E60 File Offset: 0x00083060
		public FRigUnit_SetMultiControlFloat(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005C95 RID: 23701 RVA: 0x00084E6B File Offset: 0x0008306B
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_SetMultiControlFloat(Pointer, false, true);
		}

		// Token: 0x06005C96 RID: 23702 RVA: 0x00084E75 File Offset: 0x00083075
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_SetMultiControlFloat(Pointer, MemoryOwner);
		}

		// Token: 0x04002B4E RID: 11086
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_SetMultiControlFloat";

		// Token: 0x04002B4F RID: 11087
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002B50 RID: 11088
		internal static int __PropertyOffset_Entries;

		// Token: 0x04002B51 RID: 11089
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRigUnit_SetMultiControlFloat_Entry> _Entries;

		// Token: 0x04002B52 RID: 11090
		internal static int __PropertyOffset_Weight;

		// Token: 0x04002B53 RID: 11091
		internal static int __PropertyOffset_CachedControlIndices;

		// Token: 0x04002B54 RID: 11092
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FCachedRigElement> _CachedControlIndices;
	}
}
