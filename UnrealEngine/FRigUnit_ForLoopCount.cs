using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005AD RID: 1453
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_ForLoopCount")]
	[UnrealStructLayout(232, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 232)]
	public class FRigUnit_ForLoopCount : FRigUnitMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004E49 RID: 20041 RVA: 0x00073B68 File Offset: 0x00071D68
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_ForLoopCount._ScriptStructPtr != 0) ? FRigUnit_ForLoopCount._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_ForLoopCount", ref FRigUnit_ForLoopCount._ScriptStructPtr);
		}

		// Token: 0x17001346 RID: 4934
		// (get) Token: 0x06004E4A RID: 20042 RVA: 0x00073B8C File Offset: 0x00071D8C
		// (set) Token: 0x06004E4B RID: 20043 RVA: 0x00073B9C File Offset: 0x00071D9C
		public unsafe int Count
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ForLoopCount.__PropertyOffset_Count);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ForLoopCount.__PropertyOffset_Count) = value;
			}
		}

		// Token: 0x17001347 RID: 4935
		// (get) Token: 0x06004E4C RID: 20044 RVA: 0x00073BAD File Offset: 0x00071DAD
		// (set) Token: 0x06004E4D RID: 20045 RVA: 0x00073BBD File Offset: 0x00071DBD
		public unsafe int Index
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ForLoopCount.__PropertyOffset_Index);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ForLoopCount.__PropertyOffset_Index) = value;
			}
		}

		// Token: 0x17001348 RID: 4936
		// (get) Token: 0x06004E4E RID: 20046 RVA: 0x00073BCE File Offset: 0x00071DCE
		// (set) Token: 0x06004E4F RID: 20047 RVA: 0x00073BDE File Offset: 0x00071DDE
		public unsafe float Ratio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ForLoopCount.__PropertyOffset_Ratio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ForLoopCount.__PropertyOffset_Ratio) = value;
			}
		}

		// Token: 0x17001349 RID: 4937
		// (get) Token: 0x06004E50 RID: 20048 RVA: 0x00073BEF File Offset: 0x00071DEF
		// (set) Token: 0x06004E51 RID: 20049 RVA: 0x00073BFF File Offset: 0x00071DFF
		public unsafe bool Continue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ForLoopCount.__PropertyOffset_Continue) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ForLoopCount.__PropertyOffset_Continue) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700134A RID: 4938
		// (get) Token: 0x06004E52 RID: 20050 RVA: 0x00073C10 File Offset: 0x00071E10
		// (set) Token: 0x06004E53 RID: 20051 RVA: 0x00073C53 File Offset: 0x00071E53
		public FControlRigExecuteContext Completed
		{
			get
			{
				base.FastCheckIsValid();
				FControlRigExecuteContext result;
				if ((result = this._Completed) == null)
				{
					result = (this._Completed = new FControlRigExecuteContext(base.NativePtr + (IntPtr)FRigUnit_ForLoopCount.__PropertyOffset_Completed, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FControlRigExecuteContext.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_ForLoopCount.__PropertyOffset_Completed, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06004E54 RID: 20052 RVA: 0x00073C74 File Offset: 0x00071E74
		public FRigUnit_ForLoopCount()
		{
		}

		// Token: 0x06004E55 RID: 20053 RVA: 0x00073C7C File Offset: 0x00071E7C
		public FRigUnit_ForLoopCount(int Count, int Index, float Ratio, bool Continue, FControlRigExecuteContext Completed, FControlRigExecuteContext ExecuteContext)
		{
			this.Count = Count;
			this.Index = Index;
			this.Ratio = Ratio;
			this.Continue = Continue;
			this.Completed = Completed;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06004E56 RID: 20054 RVA: 0x00073CB1 File Offset: 0x00071EB1
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_ForLoopCount.StaticStruct();
		}

		// Token: 0x06004E57 RID: 20055 RVA: 0x00073CBD File Offset: 0x00071EBD
		[NullableContext(2)]
		public FRigUnit_ForLoopCount(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004E58 RID: 20056 RVA: 0x00073CC7 File Offset: 0x00071EC7
		public FRigUnit_ForLoopCount(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004E59 RID: 20057 RVA: 0x00073CD2 File Offset: 0x00071ED2
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_ForLoopCount(Pointer, false, true);
		}

		// Token: 0x06004E5A RID: 20058 RVA: 0x00073CDC File Offset: 0x00071EDC
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_ForLoopCount(Pointer, MemoryOwner);
		}

		// Token: 0x040025D7 RID: 9687
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_ForLoopCount";

		// Token: 0x040025D8 RID: 9688
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040025D9 RID: 9689
		internal static int __PropertyOffset_Count;

		// Token: 0x040025DA RID: 9690
		internal static int __PropertyOffset_Index;

		// Token: 0x040025DB RID: 9691
		internal static int __PropertyOffset_Ratio;

		// Token: 0x040025DC RID: 9692
		internal static int __PropertyOffset_Continue;

		// Token: 0x040025DD RID: 9693
		internal static int __PropertyOffset_Completed;

		// Token: 0x040025DE RID: 9694
		[Nullable(2)]
		private FControlRigExecuteContext _Completed;
	}
}
