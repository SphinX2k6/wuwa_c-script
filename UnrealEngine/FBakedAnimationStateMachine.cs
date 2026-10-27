using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000878 RID: 2168
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BakedAnimationStateMachine")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FBakedAnimationStateMachine : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007608 RID: 30216 RVA: 0x000A9560 File Offset: 0x000A7760
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBakedAnimationStateMachine._ScriptStructPtr != 0) ? FBakedAnimationStateMachine._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BakedAnimationStateMachine", ref FBakedAnimationStateMachine._ScriptStructPtr);
		}

		// Token: 0x17001BEF RID: 7151
		// (get) Token: 0x06007609 RID: 30217 RVA: 0x000A9584 File Offset: 0x000A7784
		// (set) Token: 0x0600760A RID: 30218 RVA: 0x000A9598 File Offset: 0x000A7798
		public unsafe FName MachineName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBakedAnimationStateMachine.__PropertyOffset_MachineName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBakedAnimationStateMachine.__PropertyOffset_MachineName) = value;
			}
		}

		// Token: 0x17001BF0 RID: 7152
		// (get) Token: 0x0600760B RID: 30219 RVA: 0x000A95AD File Offset: 0x000A77AD
		// (set) Token: 0x0600760C RID: 30220 RVA: 0x000A95BD File Offset: 0x000A77BD
		public unsafe int InitialState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBakedAnimationStateMachine.__PropertyOffset_InitialState);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBakedAnimationStateMachine.__PropertyOffset_InitialState) = value;
			}
		}

		// Token: 0x17001BF1 RID: 7153
		// (get) Token: 0x0600760D RID: 30221 RVA: 0x000A95D0 File Offset: 0x000A77D0
		// (set) Token: 0x0600760E RID: 30222 RVA: 0x000A9613 File Offset: 0x000A7813
		public TArray<FBakedAnimationState> States
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBakedAnimationState> result;
				if ((result = this._States) == null)
				{
					result = (this._States = new TArray<FBakedAnimationState>(base.NativePtr + (IntPtr)FBakedAnimationStateMachine.__PropertyOffset_States, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.States.CopyAssign(value);
			}
		}

		// Token: 0x17001BF2 RID: 7154
		// (get) Token: 0x0600760F RID: 30223 RVA: 0x000A9624 File Offset: 0x000A7824
		// (set) Token: 0x06007610 RID: 30224 RVA: 0x000A9667 File Offset: 0x000A7867
		public TArray<FAnimationTransitionBetweenStates> Transitions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FAnimationTransitionBetweenStates> result;
				if ((result = this._Transitions) == null)
				{
					result = (this._Transitions = new TArray<FAnimationTransitionBetweenStates>(base.NativePtr + (IntPtr)FBakedAnimationStateMachine.__PropertyOffset_Transitions, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Transitions.CopyAssign(value);
			}
		}

		// Token: 0x06007611 RID: 30225 RVA: 0x000A9675 File Offset: 0x000A7875
		public FBakedAnimationStateMachine()
		{
		}

		// Token: 0x06007612 RID: 30226 RVA: 0x000A967D File Offset: 0x000A787D
		public FBakedAnimationStateMachine(FName MachineName, int InitialState, TArray<FBakedAnimationState> States, TArray<FAnimationTransitionBetweenStates> Transitions)
		{
			this.MachineName = MachineName;
			this.InitialState = InitialState;
			this.States = States;
			this.Transitions = Transitions;
		}

		// Token: 0x06007613 RID: 30227 RVA: 0x000A96A2 File Offset: 0x000A78A2
		protected override IntPtr GetUStructPtr()
		{
			return FBakedAnimationStateMachine.StaticStruct();
		}

		// Token: 0x06007614 RID: 30228 RVA: 0x000A96AE File Offset: 0x000A78AE
		[NullableContext(2)]
		public FBakedAnimationStateMachine(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007615 RID: 30229 RVA: 0x000A96B8 File Offset: 0x000A78B8
		public FBakedAnimationStateMachine(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007616 RID: 30230 RVA: 0x000A96C3 File Offset: 0x000A78C3
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBakedAnimationStateMachine(Pointer, false, true);
		}

		// Token: 0x06007617 RID: 30231 RVA: 0x000A96CD File Offset: 0x000A78CD
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBakedAnimationStateMachine(Pointer, MemoryOwner);
		}

		// Token: 0x040038D6 RID: 14550
		public const string __ObjectPath = "/Script/Engine.BakedAnimationStateMachine";

		// Token: 0x040038D7 RID: 14551
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040038D8 RID: 14552
		internal static int __PropertyOffset_MachineName;

		// Token: 0x040038D9 RID: 14553
		internal static int __PropertyOffset_InitialState;

		// Token: 0x040038DA RID: 14554
		internal static int __PropertyOffset_States;

		// Token: 0x040038DB RID: 14555
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBakedAnimationState> _States;

		// Token: 0x040038DC RID: 14556
		internal static int __PropertyOffset_Transitions;

		// Token: 0x040038DD RID: 14557
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAnimationTransitionBetweenStates> _Transitions;
	}
}
