using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000539 RID: 1337
	[UnrealObjectPath("/Script/ControlRig.RigUnit_AccumulateVectorLerp")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FRigUnit_AccumulateVectorLerp : FRigUnit_SimBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600463C RID: 17980 RVA: 0x0006845E File Offset: 0x0006665E
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_AccumulateVectorLerp._ScriptStructPtr != 0) ? FRigUnit_AccumulateVectorLerp._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_AccumulateVectorLerp", ref FRigUnit_AccumulateVectorLerp._ScriptStructPtr);
		}

		// Token: 0x1700110E RID: 4366
		// (get) Token: 0x0600463D RID: 17981 RVA: 0x00068482 File Offset: 0x00066682
		// (set) Token: 0x0600463E RID: 17982 RVA: 0x00068496 File Offset: 0x00066696
		public unsafe FVector TargetValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AccumulateVectorLerp.__PropertyOffset_TargetValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AccumulateVectorLerp.__PropertyOffset_TargetValue) = value;
			}
		}

		// Token: 0x1700110F RID: 4367
		// (get) Token: 0x0600463F RID: 17983 RVA: 0x000684AB File Offset: 0x000666AB
		// (set) Token: 0x06004640 RID: 17984 RVA: 0x000684BF File Offset: 0x000666BF
		public unsafe FVector InitialValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AccumulateVectorLerp.__PropertyOffset_InitialValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AccumulateVectorLerp.__PropertyOffset_InitialValue) = value;
			}
		}

		// Token: 0x17001110 RID: 4368
		// (get) Token: 0x06004641 RID: 17985 RVA: 0x000684D4 File Offset: 0x000666D4
		// (set) Token: 0x06004642 RID: 17986 RVA: 0x000684E4 File Offset: 0x000666E4
		public unsafe float Blend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AccumulateVectorLerp.__PropertyOffset_Blend);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AccumulateVectorLerp.__PropertyOffset_Blend) = value;
			}
		}

		// Token: 0x17001111 RID: 4369
		// (get) Token: 0x06004643 RID: 17987 RVA: 0x000684F5 File Offset: 0x000666F5
		// (set) Token: 0x06004644 RID: 17988 RVA: 0x00068505 File Offset: 0x00066705
		public unsafe bool bIntegrateDeltaTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AccumulateVectorLerp.__PropertyOffset_bIntegrateDeltaTime) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AccumulateVectorLerp.__PropertyOffset_bIntegrateDeltaTime) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001112 RID: 4370
		// (get) Token: 0x06004645 RID: 17989 RVA: 0x00068516 File Offset: 0x00066716
		// (set) Token: 0x06004646 RID: 17990 RVA: 0x0006852A File Offset: 0x0006672A
		public unsafe FVector Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AccumulateVectorLerp.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AccumulateVectorLerp.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x17001113 RID: 4371
		// (get) Token: 0x06004647 RID: 17991 RVA: 0x0006853F File Offset: 0x0006673F
		// (set) Token: 0x06004648 RID: 17992 RVA: 0x00068553 File Offset: 0x00066753
		public unsafe FVector AccumulatedValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AccumulateVectorLerp.__PropertyOffset_AccumulatedValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AccumulateVectorLerp.__PropertyOffset_AccumulatedValue) = value;
			}
		}

		// Token: 0x06004649 RID: 17993 RVA: 0x00068568 File Offset: 0x00066768
		public FRigUnit_AccumulateVectorLerp()
		{
		}

		// Token: 0x0600464A RID: 17994 RVA: 0x00068570 File Offset: 0x00066770
		public FRigUnit_AccumulateVectorLerp(FVector TargetValue, FVector InitialValue, float Blend, bool bIntegrateDeltaTime, FVector Result, FVector AccumulatedValue)
		{
			this.TargetValue = TargetValue;
			this.InitialValue = InitialValue;
			this.Blend = Blend;
			this.bIntegrateDeltaTime = bIntegrateDeltaTime;
			this.Result = Result;
			this.AccumulatedValue = AccumulatedValue;
		}

		// Token: 0x0600464B RID: 17995 RVA: 0x000685A5 File Offset: 0x000667A5
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_AccumulateVectorLerp.StaticStruct();
		}

		// Token: 0x0600464C RID: 17996 RVA: 0x000685B1 File Offset: 0x000667B1
		[NullableContext(2)]
		public FRigUnit_AccumulateVectorLerp(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600464D RID: 17997 RVA: 0x000685BB File Offset: 0x000667BB
		public FRigUnit_AccumulateVectorLerp(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600464E RID: 17998 RVA: 0x000685C6 File Offset: 0x000667C6
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_AccumulateVectorLerp(Pointer, false, true);
		}

		// Token: 0x0600464F RID: 17999 RVA: 0x000685D0 File Offset: 0x000667D0
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_AccumulateVectorLerp(Pointer, MemoryOwner);
		}

		// Token: 0x04002221 RID: 8737
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_AccumulateVectorLerp";

		// Token: 0x04002222 RID: 8738
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002223 RID: 8739
		internal static int __PropertyOffset_TargetValue;

		// Token: 0x04002224 RID: 8740
		internal static int __PropertyOffset_InitialValue;

		// Token: 0x04002225 RID: 8741
		internal static int __PropertyOffset_Blend;

		// Token: 0x04002226 RID: 8742
		internal static int __PropertyOffset_bIntegrateDeltaTime;

		// Token: 0x04002227 RID: 8743
		internal static int __PropertyOffset_Result;

		// Token: 0x04002228 RID: 8744
		internal static int __PropertyOffset_AccumulatedValue;
	}
}
