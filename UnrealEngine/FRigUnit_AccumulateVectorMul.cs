using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200053A RID: 1338
	[UnrealObjectPath("/Script/ControlRig.RigUnit_AccumulateVectorMul")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FRigUnit_AccumulateVectorMul : FRigUnit_SimBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004650 RID: 18000 RVA: 0x000685D9 File Offset: 0x000667D9
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_AccumulateVectorMul._ScriptStructPtr != 0) ? FRigUnit_AccumulateVectorMul._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_AccumulateVectorMul", ref FRigUnit_AccumulateVectorMul._ScriptStructPtr);
		}

		// Token: 0x17001114 RID: 4372
		// (get) Token: 0x06004651 RID: 18001 RVA: 0x000685FD File Offset: 0x000667FD
		// (set) Token: 0x06004652 RID: 18002 RVA: 0x00068611 File Offset: 0x00066811
		public unsafe FVector Multiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AccumulateVectorMul.__PropertyOffset_Multiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AccumulateVectorMul.__PropertyOffset_Multiplier) = value;
			}
		}

		// Token: 0x17001115 RID: 4373
		// (get) Token: 0x06004653 RID: 18003 RVA: 0x00068626 File Offset: 0x00066826
		// (set) Token: 0x06004654 RID: 18004 RVA: 0x0006863A File Offset: 0x0006683A
		public unsafe FVector InitialValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AccumulateVectorMul.__PropertyOffset_InitialValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AccumulateVectorMul.__PropertyOffset_InitialValue) = value;
			}
		}

		// Token: 0x17001116 RID: 4374
		// (get) Token: 0x06004655 RID: 18005 RVA: 0x0006864F File Offset: 0x0006684F
		// (set) Token: 0x06004656 RID: 18006 RVA: 0x0006865F File Offset: 0x0006685F
		public unsafe bool bIntegrateDeltaTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AccumulateVectorMul.__PropertyOffset_bIntegrateDeltaTime) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AccumulateVectorMul.__PropertyOffset_bIntegrateDeltaTime) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001117 RID: 4375
		// (get) Token: 0x06004657 RID: 18007 RVA: 0x00068670 File Offset: 0x00066870
		// (set) Token: 0x06004658 RID: 18008 RVA: 0x00068684 File Offset: 0x00066884
		public unsafe FVector Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AccumulateVectorMul.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AccumulateVectorMul.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x17001118 RID: 4376
		// (get) Token: 0x06004659 RID: 18009 RVA: 0x00068699 File Offset: 0x00066899
		// (set) Token: 0x0600465A RID: 18010 RVA: 0x000686AD File Offset: 0x000668AD
		public unsafe FVector AccumulatedValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AccumulateVectorMul.__PropertyOffset_AccumulatedValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AccumulateVectorMul.__PropertyOffset_AccumulatedValue) = value;
			}
		}

		// Token: 0x0600465B RID: 18011 RVA: 0x000686C2 File Offset: 0x000668C2
		public FRigUnit_AccumulateVectorMul()
		{
		}

		// Token: 0x0600465C RID: 18012 RVA: 0x000686CA File Offset: 0x000668CA
		public FRigUnit_AccumulateVectorMul(FVector Multiplier, FVector InitialValue, bool bIntegrateDeltaTime, FVector Result, FVector AccumulatedValue)
		{
			this.Multiplier = Multiplier;
			this.InitialValue = InitialValue;
			this.bIntegrateDeltaTime = bIntegrateDeltaTime;
			this.Result = Result;
			this.AccumulatedValue = AccumulatedValue;
		}

		// Token: 0x0600465D RID: 18013 RVA: 0x000686F7 File Offset: 0x000668F7
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_AccumulateVectorMul.StaticStruct();
		}

		// Token: 0x0600465E RID: 18014 RVA: 0x00068703 File Offset: 0x00066903
		[NullableContext(2)]
		public FRigUnit_AccumulateVectorMul(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600465F RID: 18015 RVA: 0x0006870D File Offset: 0x0006690D
		public FRigUnit_AccumulateVectorMul(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004660 RID: 18016 RVA: 0x00068718 File Offset: 0x00066918
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_AccumulateVectorMul(Pointer, false, true);
		}

		// Token: 0x06004661 RID: 18017 RVA: 0x00068722 File Offset: 0x00066922
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_AccumulateVectorMul(Pointer, MemoryOwner);
		}

		// Token: 0x04002229 RID: 8745
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_AccumulateVectorMul";

		// Token: 0x0400222A RID: 8746
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400222B RID: 8747
		internal static int __PropertyOffset_Multiplier;

		// Token: 0x0400222C RID: 8748
		internal static int __PropertyOffset_InitialValue;

		// Token: 0x0400222D RID: 8749
		internal static int __PropertyOffset_bIntegrateDeltaTime;

		// Token: 0x0400222E RID: 8750
		internal static int __PropertyOffset_Result;

		// Token: 0x0400222F RID: 8751
		internal static int __PropertyOffset_AccumulatedValue;
	}
}
