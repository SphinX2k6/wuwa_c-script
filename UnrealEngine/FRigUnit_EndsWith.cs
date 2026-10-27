using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020005A4 RID: 1444
	[UnrealObjectPath("/Script/ControlRig.RigUnit_EndsWith")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FRigUnit_EndsWith : FRigUnit_NameBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004D77 RID: 19831 RVA: 0x0007266A File Offset: 0x0007086A
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_EndsWith._ScriptStructPtr != 0) ? FRigUnit_EndsWith._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_EndsWith", ref FRigUnit_EndsWith._ScriptStructPtr);
		}

		// Token: 0x17001301 RID: 4865
		// (get) Token: 0x06004D78 RID: 19832 RVA: 0x0007268E File Offset: 0x0007088E
		// (set) Token: 0x06004D79 RID: 19833 RVA: 0x000726A2 File Offset: 0x000708A2
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_EndsWith.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_EndsWith.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x17001302 RID: 4866
		// (get) Token: 0x06004D7A RID: 19834 RVA: 0x000726B7 File Offset: 0x000708B7
		// (set) Token: 0x06004D7B RID: 19835 RVA: 0x000726CB File Offset: 0x000708CB
		public unsafe FName Ending
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_EndsWith.__PropertyOffset_Ending);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_EndsWith.__PropertyOffset_Ending) = value;
			}
		}

		// Token: 0x17001303 RID: 4867
		// (get) Token: 0x06004D7C RID: 19836 RVA: 0x000726E0 File Offset: 0x000708E0
		// (set) Token: 0x06004D7D RID: 19837 RVA: 0x000726F0 File Offset: 0x000708F0
		public unsafe bool Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_EndsWith.__PropertyOffset_Result) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_EndsWith.__PropertyOffset_Result) = (value ? 1 : 0);
			}
		}

		// Token: 0x06004D7E RID: 19838 RVA: 0x00072701 File Offset: 0x00070901
		public FRigUnit_EndsWith()
		{
		}

		// Token: 0x06004D7F RID: 19839 RVA: 0x00072709 File Offset: 0x00070909
		public FRigUnit_EndsWith(FName Name, FName Ending, bool Result)
		{
			this.Name = Name;
			this.Ending = Ending;
			this.Result = Result;
		}

		// Token: 0x06004D80 RID: 19840 RVA: 0x00072726 File Offset: 0x00070926
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_EndsWith.StaticStruct();
		}

		// Token: 0x06004D81 RID: 19841 RVA: 0x00072732 File Offset: 0x00070932
		[NullableContext(2)]
		public FRigUnit_EndsWith(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004D82 RID: 19842 RVA: 0x0007273C File Offset: 0x0007093C
		public FRigUnit_EndsWith(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004D83 RID: 19843 RVA: 0x00072747 File Offset: 0x00070947
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_EndsWith(Pointer, false, true);
		}

		// Token: 0x06004D84 RID: 19844 RVA: 0x00072751 File Offset: 0x00070951
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_EndsWith(Pointer, MemoryOwner);
		}

		// Token: 0x04002568 RID: 9576
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_EndsWith";

		// Token: 0x04002569 RID: 9577
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400256A RID: 9578
		internal static int __PropertyOffset_Name;

		// Token: 0x0400256B RID: 9579
		internal static int __PropertyOffset_Ending;

		// Token: 0x0400256C RID: 9580
		internal static int __PropertyOffset_Result;
	}
}
