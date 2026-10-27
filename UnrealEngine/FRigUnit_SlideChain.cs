using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006D5 RID: 1749
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_SlideChain")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 216)]
	public class FRigUnit_SlideChain : FRigUnit_HighlevelBaseMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005DA6 RID: 23974 RVA: 0x0008669C File Offset: 0x0008489C
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_SlideChain._ScriptStructPtr != 0) ? FRigUnit_SlideChain._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_SlideChain", ref FRigUnit_SlideChain._ScriptStructPtr);
		}

		// Token: 0x1700165D RID: 5725
		// (get) Token: 0x06005DA7 RID: 23975 RVA: 0x000866C0 File Offset: 0x000848C0
		// (set) Token: 0x06005DA8 RID: 23976 RVA: 0x000866D4 File Offset: 0x000848D4
		public unsafe FName StartBone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SlideChain.__PropertyOffset_StartBone);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SlideChain.__PropertyOffset_StartBone) = value;
			}
		}

		// Token: 0x1700165E RID: 5726
		// (get) Token: 0x06005DA9 RID: 23977 RVA: 0x000866E9 File Offset: 0x000848E9
		// (set) Token: 0x06005DAA RID: 23978 RVA: 0x000866FD File Offset: 0x000848FD
		public unsafe FName EndBone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SlideChain.__PropertyOffset_EndBone);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SlideChain.__PropertyOffset_EndBone) = value;
			}
		}

		// Token: 0x1700165F RID: 5727
		// (get) Token: 0x06005DAB RID: 23979 RVA: 0x00086712 File Offset: 0x00084912
		// (set) Token: 0x06005DAC RID: 23980 RVA: 0x00086722 File Offset: 0x00084922
		public unsafe float SlideAmount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SlideChain.__PropertyOffset_SlideAmount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SlideChain.__PropertyOffset_SlideAmount) = value;
			}
		}

		// Token: 0x17001660 RID: 5728
		// (get) Token: 0x06005DAD RID: 23981 RVA: 0x00086733 File Offset: 0x00084933
		// (set) Token: 0x06005DAE RID: 23982 RVA: 0x00086743 File Offset: 0x00084943
		public unsafe bool bPropagateToChildren
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SlideChain.__PropertyOffset_bPropagateToChildren) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SlideChain.__PropertyOffset_bPropagateToChildren) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001661 RID: 5729
		// (get) Token: 0x06005DAF RID: 23983 RVA: 0x00086754 File Offset: 0x00084954
		// (set) Token: 0x06005DB0 RID: 23984 RVA: 0x00086797 File Offset: 0x00084997
		public FRigUnit_SlideChain_WorkData WorkData
		{
			get
			{
				base.FastCheckIsValid();
				FRigUnit_SlideChain_WorkData result;
				if ((result = this._WorkData) == null)
				{
					result = (this._WorkData = new FRigUnit_SlideChain_WorkData(base.NativePtr + (IntPtr)FRigUnit_SlideChain.__PropertyOffset_WorkData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigUnit_SlideChain_WorkData.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_SlideChain.__PropertyOffset_WorkData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06005DB1 RID: 23985 RVA: 0x000867B8 File Offset: 0x000849B8
		public FRigUnit_SlideChain()
		{
		}

		// Token: 0x06005DB2 RID: 23986 RVA: 0x000867C0 File Offset: 0x000849C0
		public FRigUnit_SlideChain(FName StartBone, FName EndBone, float SlideAmount, bool bPropagateToChildren, FRigUnit_SlideChain_WorkData WorkData, FControlRigExecuteContext ExecuteContext)
		{
			this.StartBone = StartBone;
			this.EndBone = EndBone;
			this.SlideAmount = SlideAmount;
			this.bPropagateToChildren = bPropagateToChildren;
			this.WorkData = WorkData;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06005DB3 RID: 23987 RVA: 0x000867F5 File Offset: 0x000849F5
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_SlideChain.StaticStruct();
		}

		// Token: 0x06005DB4 RID: 23988 RVA: 0x00086801 File Offset: 0x00084A01
		[NullableContext(2)]
		public FRigUnit_SlideChain(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005DB5 RID: 23989 RVA: 0x0008680B File Offset: 0x00084A0B
		public FRigUnit_SlideChain(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005DB6 RID: 23990 RVA: 0x00086816 File Offset: 0x00084A16
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_SlideChain(Pointer, false, true);
		}

		// Token: 0x06005DB7 RID: 23991 RVA: 0x00086820 File Offset: 0x00084A20
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_SlideChain(Pointer, MemoryOwner);
		}

		// Token: 0x04002BD1 RID: 11217
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_SlideChain";

		// Token: 0x04002BD2 RID: 11218
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002BD3 RID: 11219
		internal static int __PropertyOffset_StartBone;

		// Token: 0x04002BD4 RID: 11220
		internal static int __PropertyOffset_EndBone;

		// Token: 0x04002BD5 RID: 11221
		internal static int __PropertyOffset_SlideAmount;

		// Token: 0x04002BD6 RID: 11222
		internal static int __PropertyOffset_bPropagateToChildren;

		// Token: 0x04002BD7 RID: 11223
		internal static int __PropertyOffset_WorkData;

		// Token: 0x04002BD8 RID: 11224
		[Nullable(2)]
		private FRigUnit_SlideChain_WorkData _WorkData;
	}
}
