using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001D6 RID: 470
	[UnrealObjectPath("/Script/AIModule.PawnActionsComponent")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class UPawnActionsComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001BBC RID: 7100 RVA: 0x00029585 File Offset: 0x00027785
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPawnActionsComponent._ClassPtr;
		}

		// Token: 0x06001BBD RID: 7101 RVA: 0x00029594 File Offset: 0x00027794
		public UPawnActionsComponent() : this(BuiltinUtils.AllocNativeUObject(UPawnActionsComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001BBE RID: 7102 RVA: 0x000295BC File Offset: 0x000277BC
		[NullableContext(1)]
		public UPawnActionsComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPawnActionsComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x06001BBF RID: 7103 RVA: 0x000295EF File Offset: 0x000277EF
		// (set) Token: 0x06001BC0 RID: 7104 RVA: 0x00029603 File Offset: 0x00027803
		[Nullable(2)]
		public unsafe APawn ControlledPawn
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<APawn>(base.NativePtr / (IntPtr)sizeof(void*) + UPawnActionsComponent.__PropertyOffset_ControlledPawn);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UPawnActionsComponent.__PropertyOffset_ControlledPawn, value);
			}
		}

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x06001BC1 RID: 7105 RVA: 0x00029618 File Offset: 0x00027818
		// (set) Token: 0x06001BC2 RID: 7106 RVA: 0x00029651 File Offset: 0x00027851
		[Nullable(1)]
		public TArray<FPawnActionStack> ActionStacks
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FPawnActionStack> result;
				if ((result = this._ActionStacks) == null)
				{
					result = (this._ActionStacks = new TArray<FPawnActionStack>(base.NativePtr + (IntPtr)UPawnActionsComponent.__PropertyOffset_ActionStacks, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ActionStacks.CopyAssign(value);
			}
		}

		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x06001BC3 RID: 7107 RVA: 0x00029660 File Offset: 0x00027860
		// (set) Token: 0x06001BC4 RID: 7108 RVA: 0x00029699 File Offset: 0x00027899
		[Nullable(1)]
		public TArray<FPawnActionEvent> ActionEvents
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FPawnActionEvent> result;
				if ((result = this._ActionEvents) == null)
				{
					result = (this._ActionEvents = new TArray<FPawnActionEvent>(base.NativePtr + (IntPtr)UPawnActionsComponent.__PropertyOffset_ActionEvents, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ActionEvents.CopyAssign(value);
			}
		}

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x06001BC5 RID: 7109 RVA: 0x000296A7 File Offset: 0x000278A7
		// (set) Token: 0x06001BC6 RID: 7110 RVA: 0x000296BB File Offset: 0x000278BB
		[Nullable(2)]
		public unsafe UPawnAction CurrentAction
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPawnAction>(base.NativePtr / (IntPtr)sizeof(void*) + UPawnActionsComponent.__PropertyOffset_CurrentAction);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UPawnActionsComponent.__PropertyOffset_CurrentAction, value);
			}
		}

		// Token: 0x06001BC7 RID: 7111 RVA: 0x000296D0 File Offset: 0x000278D0
		[NullableContext(2)]
		public bool K2_PushAction(UPawnAction NewAction, EAIRequestPriority Priority, UObject Instigator = null)
		{
			return UPawnActionsComponent.__K2_PushAction_Internal(base.NativePtr, (NewAction != null) ? NewAction.NativePtr : IntPtr.Zero, Priority, (Instigator != null) ? Instigator.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06001BC8 RID: 7112 RVA: 0x00029703 File Offset: 0x00027903
		[NullableContext(2)]
		public static bool K2_PerformAction(APawn Pawn, UPawnAction Action, EAIRequestPriority Priority = EAIRequestPriority.HardScript)
		{
			return UPawnActionsComponent.__K2_PerformAction_Internal((Pawn != null) ? Pawn.NativePtr : IntPtr.Zero, (Action != null) ? Action.NativePtr : IntPtr.Zero, Priority);
		}

		// Token: 0x06001BC9 RID: 7113 RVA: 0x00029730 File Offset: 0x00027930
		public TEnumAsByte<EPawnActionAbortState> K2_ForceAbortAction([Nullable(2)] UPawnAction ActionToAbort)
		{
			return UPawnActionsComponent.__K2_ForceAbortAction_Internal(base.NativePtr, (ActionToAbort != null) ? ActionToAbort.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06001BCA RID: 7114 RVA: 0x0002974D File Offset: 0x0002794D
		public TEnumAsByte<EPawnActionAbortState> K2_AbortAction([Nullable(2)] UPawnAction ActionToAbort)
		{
			return UPawnActionsComponent.__K2_AbortAction_Internal(base.NativePtr, (ActionToAbort != null) ? ActionToAbort.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06001BCB RID: 7115
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_PushAction_Internal(IntPtr @this, IntPtr NewAction, TEnumAsByte<EAIRequestPriority> Priority, IntPtr Instigator);

		// Token: 0x06001BCC RID: 7116
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_PerformAction_Internal(IntPtr Pawn, IntPtr Action, TEnumAsByte<EAIRequestPriority> Priority);

		// Token: 0x06001BCD RID: 7117
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern TEnumAsByte<EPawnActionAbortState> __K2_ForceAbortAction_Internal(IntPtr @this, IntPtr ActionToAbort);

		// Token: 0x06001BCE RID: 7118
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern TEnumAsByte<EPawnActionAbortState> __K2_AbortAction_Internal(IntPtr @this, IntPtr ActionToAbort);

		// Token: 0x06001BCF RID: 7119 RVA: 0x0002976A File Offset: 0x0002796A
		static UPawnActionsComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.PawnActionsComponent");
		}

		// Token: 0x06001BD0 RID: 7120 RVA: 0x00029778 File Offset: 0x00027978
		protected UPawnActionsComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040008EB RID: 2283
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.PawnActionsComponent";

		// Token: 0x040008EC RID: 2284
		private static IntPtr _ClassPtr;

		// Token: 0x040008ED RID: 2285
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040008EE RID: 2286
		internal static int __PropertyOffset_ControlledPawn;

		// Token: 0x040008EF RID: 2287
		internal static int __PropertyOffset_ActionStacks;

		// Token: 0x040008F0 RID: 2288
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FPawnActionStack> _ActionStacks;

		// Token: 0x040008F1 RID: 2289
		internal static int __PropertyOffset_ActionEvents;

		// Token: 0x040008F2 RID: 2290
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FPawnActionEvent> _ActionEvents;

		// Token: 0x040008F3 RID: 2291
		internal static int __PropertyOffset_CurrentAction;
	}
}
