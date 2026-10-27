using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020019B1 RID: 6577
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroLevelStateMachine.KuroLevelState")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 152)]
	public class FKuroLevelState : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601877F RID: 100223 RVA: 0x00240E37 File Offset: 0x0023F037
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroLevelState._ScriptStructPtr != 0) ? FKuroLevelState._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroLevelStateMachine.KuroLevelState", ref FKuroLevelState._ScriptStructPtr);
		}

		// Token: 0x170061B5 RID: 25013
		// (get) Token: 0x06018780 RID: 100224 RVA: 0x00240E5B File Offset: 0x0023F05B
		// (set) Token: 0x06018781 RID: 100225 RVA: 0x00240E6F File Offset: 0x0023F06F
		public unsafe FName StateName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroLevelState.__PropertyOffset_StateName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLevelState.__PropertyOffset_StateName) = value;
			}
		}

		// Token: 0x170061B6 RID: 25014
		// (get) Token: 0x06018782 RID: 100226 RVA: 0x00240E84 File Offset: 0x0023F084
		// (set) Token: 0x06018783 RID: 100227 RVA: 0x00240E94 File Offset: 0x0023F094
		public unsafe float Duration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroLevelState.__PropertyOffset_Duration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLevelState.__PropertyOffset_Duration) = value;
			}
		}

		// Token: 0x170061B7 RID: 25015
		// (get) Token: 0x06018784 RID: 100228 RVA: 0x00240EA5 File Offset: 0x0023F0A5
		// (set) Token: 0x06018785 RID: 100229 RVA: 0x00240EB5 File Offset: 0x0023F0B5
		public unsafe bool bBreakTransition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroLevelState.__PropertyOffset_bBreakTransition) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLevelState.__PropertyOffset_bBreakTransition) = (value ? 1 : 0);
			}
		}

		// Token: 0x170061B8 RID: 25016
		// (get) Token: 0x06018786 RID: 100230 RVA: 0x00240EC8 File Offset: 0x0023F0C8
		// (set) Token: 0x06018787 RID: 100231 RVA: 0x00240F0B File Offset: 0x0023F10B
		public TMap<FName, FName> Transitions
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FName> result;
				if ((result = this._Transitions) == null)
				{
					result = (this._Transitions = new TMap<FName, FName>(base.NativePtr + (IntPtr)FKuroLevelState.__PropertyOffset_Transitions, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Transitions.CopyAssign(value);
			}
		}

		// Token: 0x170061B9 RID: 25017
		// (get) Token: 0x06018788 RID: 100232 RVA: 0x00240F1C File Offset: 0x0023F11C
		// (set) Token: 0x06018789 RID: 100233 RVA: 0x00240F5F File Offset: 0x0023F15F
		public TArray<UKuroLevelStateAction> Actions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UKuroLevelStateAction> result;
				if ((result = this._Actions) == null)
				{
					result = (this._Actions = new TArray<UKuroLevelStateAction>(base.NativePtr + (IntPtr)FKuroLevelState.__PropertyOffset_Actions, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Actions.CopyAssign(value);
			}
		}

		// Token: 0x170061BA RID: 25018
		// (get) Token: 0x0601878A RID: 100234 RVA: 0x00240F70 File Offset: 0x0023F170
		// (set) Token: 0x0601878B RID: 100235 RVA: 0x00240FB3 File Offset: 0x0023F1B3
		public TArray<UKuroLevelStateAction> TickActions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UKuroLevelStateAction> result;
				if ((result = this._TickActions) == null)
				{
					result = (this._TickActions = new TArray<UKuroLevelStateAction>(base.NativePtr + (IntPtr)FKuroLevelState.__PropertyOffset_TickActions, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TickActions.CopyAssign(value);
			}
		}

		// Token: 0x0601878C RID: 100236 RVA: 0x00240FC1 File Offset: 0x0023F1C1
		public FKuroLevelState()
		{
		}

		// Token: 0x0601878D RID: 100237 RVA: 0x00240FC9 File Offset: 0x0023F1C9
		public FKuroLevelState(FName StateName, float Duration, bool bBreakTransition, TMap<FName, FName> Transitions, TArray<UKuroLevelStateAction> Actions, TArray<UKuroLevelStateAction> TickActions)
		{
			this.StateName = StateName;
			this.Duration = Duration;
			this.bBreakTransition = bBreakTransition;
			this.Transitions = Transitions;
			this.Actions = Actions;
			this.TickActions = TickActions;
		}

		// Token: 0x0601878E RID: 100238 RVA: 0x00240FFE File Offset: 0x0023F1FE
		protected override IntPtr GetUStructPtr()
		{
			return FKuroLevelState.StaticStruct();
		}

		// Token: 0x0601878F RID: 100239 RVA: 0x0024100A File Offset: 0x0023F20A
		[NullableContext(2)]
		public FKuroLevelState(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018790 RID: 100240 RVA: 0x00241014 File Offset: 0x0023F214
		public FKuroLevelState(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018791 RID: 100241 RVA: 0x0024101F File Offset: 0x0023F21F
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroLevelState(Pointer, false, true);
		}

		// Token: 0x06018792 RID: 100242 RVA: 0x00241029 File Offset: 0x0023F229
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroLevelState(Pointer, MemoryOwner);
		}

		// Token: 0x0400D37D RID: 54141
		public const string __ObjectPath = "/Script/KuroLevelStateMachine.KuroLevelState";

		// Token: 0x0400D37E RID: 54142
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400D37F RID: 54143
		internal static int __PropertyOffset_StateName;

		// Token: 0x0400D380 RID: 54144
		internal static int __PropertyOffset_Duration;

		// Token: 0x0400D381 RID: 54145
		internal static int __PropertyOffset_bBreakTransition;

		// Token: 0x0400D382 RID: 54146
		internal static int __PropertyOffset_Transitions;

		// Token: 0x0400D383 RID: 54147
		[Nullable(2)]
		private TMap<FName, FName> _Transitions;

		// Token: 0x0400D384 RID: 54148
		internal static int __PropertyOffset_Actions;

		// Token: 0x0400D385 RID: 54149
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UKuroLevelStateAction> _Actions;

		// Token: 0x0400D386 RID: 54150
		internal static int __PropertyOffset_TickActions;

		// Token: 0x0400D387 RID: 54151
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UKuroLevelStateAction> _TickActions;
	}
}
