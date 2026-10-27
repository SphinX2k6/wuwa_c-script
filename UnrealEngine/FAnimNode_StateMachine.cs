using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000821 RID: 2081
	[UnrealObjectPath("/Script/Engine.AnimNode_StateMachine")]
	[UnrealStructLayout(488, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 488)]
	public class FAnimNode_StateMachine : FAnimNode_Base, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006FEE RID: 28654 RVA: 0x000A0A4B File Offset: 0x0009EC4B
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_StateMachine._ScriptStructPtr != 0) ? FAnimNode_StateMachine._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AnimNode_StateMachine", ref FAnimNode_StateMachine._ScriptStructPtr);
		}

		// Token: 0x17001A55 RID: 6741
		// (get) Token: 0x06006FEF RID: 28655 RVA: 0x000A0A6F File Offset: 0x0009EC6F
		// (set) Token: 0x06006FF0 RID: 28656 RVA: 0x000A0A7F File Offset: 0x0009EC7F
		public unsafe int StateMachineIndexInClass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_StateMachine.__PropertyOffset_StateMachineIndexInClass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_StateMachine.__PropertyOffset_StateMachineIndexInClass) = value;
			}
		}

		// Token: 0x17001A56 RID: 6742
		// (get) Token: 0x06006FF1 RID: 28657 RVA: 0x000A0A90 File Offset: 0x0009EC90
		// (set) Token: 0x06006FF2 RID: 28658 RVA: 0x000A0AA0 File Offset: 0x0009ECA0
		public unsafe int MaxTransitionsPerFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_StateMachine.__PropertyOffset_MaxTransitionsPerFrame);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_StateMachine.__PropertyOffset_MaxTransitionsPerFrame) = value;
			}
		}

		// Token: 0x17001A57 RID: 6743
		// (get) Token: 0x06006FF3 RID: 28659 RVA: 0x000A0AB1 File Offset: 0x0009ECB1
		// (set) Token: 0x06006FF4 RID: 28660 RVA: 0x000A0AC1 File Offset: 0x0009ECC1
		public unsafe bool bSkipFirstUpdateTransition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_StateMachine.__PropertyOffset_bSkipFirstUpdateTransition) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_StateMachine.__PropertyOffset_bSkipFirstUpdateTransition) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001A58 RID: 6744
		// (get) Token: 0x06006FF5 RID: 28661 RVA: 0x000A0AD2 File Offset: 0x0009ECD2
		// (set) Token: 0x06006FF6 RID: 28662 RVA: 0x000A0AE2 File Offset: 0x0009ECE2
		public unsafe bool bReinitializeOnBecomingRelevant
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_StateMachine.__PropertyOffset_bReinitializeOnBecomingRelevant) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_StateMachine.__PropertyOffset_bReinitializeOnBecomingRelevant) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001A59 RID: 6745
		// (get) Token: 0x06006FF7 RID: 28663 RVA: 0x000A0AF3 File Offset: 0x0009ECF3
		// (set) Token: 0x06006FF8 RID: 28664 RVA: 0x000A0B03 File Offset: 0x0009ED03
		public unsafe bool bForceDisableNetMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_StateMachine.__PropertyOffset_bForceDisableNetMode) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_StateMachine.__PropertyOffset_bForceDisableNetMode) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001A5A RID: 6746
		// (get) Token: 0x06006FF9 RID: 28665 RVA: 0x000A0B14 File Offset: 0x0009ED14
		// (set) Token: 0x06006FFA RID: 28666 RVA: 0x000A0B24 File Offset: 0x0009ED24
		public unsafe bool bNeverInherit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_StateMachine.__PropertyOffset_bNeverInherit) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_StateMachine.__PropertyOffset_bNeverInherit) = (value ? 1 : 0);
			}
		}

		// Token: 0x06006FFB RID: 28667 RVA: 0x000A0B35 File Offset: 0x0009ED35
		public FAnimNode_StateMachine()
		{
		}

		// Token: 0x06006FFC RID: 28668 RVA: 0x000A0B3D File Offset: 0x0009ED3D
		public FAnimNode_StateMachine(int StateMachineIndexInClass, int MaxTransitionsPerFrame, bool bSkipFirstUpdateTransition, bool bReinitializeOnBecomingRelevant, bool bForceDisableNetMode, bool bNeverInherit)
		{
			this.StateMachineIndexInClass = StateMachineIndexInClass;
			this.MaxTransitionsPerFrame = MaxTransitionsPerFrame;
			this.bSkipFirstUpdateTransition = bSkipFirstUpdateTransition;
			this.bReinitializeOnBecomingRelevant = bReinitializeOnBecomingRelevant;
			this.bForceDisableNetMode = bForceDisableNetMode;
			this.bNeverInherit = bNeverInherit;
		}

		// Token: 0x06006FFD RID: 28669 RVA: 0x000A0B72 File Offset: 0x0009ED72
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_StateMachine.StaticStruct();
		}

		// Token: 0x06006FFE RID: 28670 RVA: 0x000A0B7E File Offset: 0x0009ED7E
		[NullableContext(2)]
		public FAnimNode_StateMachine(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006FFF RID: 28671 RVA: 0x000A0B88 File Offset: 0x0009ED88
		public FAnimNode_StateMachine(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007000 RID: 28672 RVA: 0x000A0B93 File Offset: 0x0009ED93
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_StateMachine(Pointer, false, true);
		}

		// Token: 0x06007001 RID: 28673 RVA: 0x000A0B9D File Offset: 0x0009ED9D
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_StateMachine(Pointer, MemoryOwner);
		}

		// Token: 0x040035C7 RID: 13767
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.AnimNode_StateMachine";

		// Token: 0x040035C8 RID: 13768
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040035C9 RID: 13769
		internal static int __PropertyOffset_StateMachineIndexInClass;

		// Token: 0x040035CA RID: 13770
		internal static int __PropertyOffset_MaxTransitionsPerFrame;

		// Token: 0x040035CB RID: 13771
		internal static int __PropertyOffset_bSkipFirstUpdateTransition;

		// Token: 0x040035CC RID: 13772
		internal static int __PropertyOffset_bReinitializeOnBecomingRelevant;

		// Token: 0x040035CD RID: 13773
		internal static int __PropertyOffset_bForceDisableNetMode;

		// Token: 0x040035CE RID: 13774
		internal static int __PropertyOffset_bNeverInherit;
	}
}
