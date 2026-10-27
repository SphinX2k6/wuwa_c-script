using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x02001E70 RID: 7792
	public sealed class FOnSkillReady : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601DAD7 RID: 121559 RVA: 0x002BD6DC File Offset: 0x002BB8DC
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnSkillReady.StaticFunctionPtr();
		}

		// Token: 0x0601DAD8 RID: 121560 RVA: 0x002BD6E8 File Offset: 0x002BB8E8
		private static IntPtr StaticFunctionPtr()
		{
			if (AKSC_Entity_AssistMachine.__OnSkillReady__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				AKSC_Entity_AssistMachine.__OnSkillReady__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSimpleCombat.KSC_Entity_AssistMachine:OnSkillReady__DelegateSignature");
			}
			return AKSC_Entity_AssistMachine.__OnSkillReady__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601DAD9 RID: 121561 RVA: 0x002BD70B File Offset: 0x002BB90B
		public FOnSkillReady()
		{
		}

		// Token: 0x0601DADA RID: 121562 RVA: 0x002BD713 File Offset: 0x002BB913
		[NullableContext(2)]
		public FOnSkillReady(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601DADB RID: 121563 RVA: 0x002BD71D File Offset: 0x002BB91D
		public FOnSkillReady(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601DADC RID: 121564 RVA: 0x002BD728 File Offset: 0x002BB928
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601DADD RID: 121565 RVA: 0x002BD75A File Offset: 0x002BB95A
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action Callback)
		{
			if (FOnSkillReady.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnSkillReady.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnSkillReady.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnSkillReady.OnScriptCallback));
				}
				FOnSkillReady.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnSkillReady.RegisterId);
		}

		// Token: 0x0601DADE RID: 121566 RVA: 0x002BD794 File Offset: 0x002BB994
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x0601DADF RID: 121567 RVA: 0x002BD7A0 File Offset: 0x002BB9A0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action action = target as Action;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action();
		}

		// Token: 0x04010130 RID: 65840
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Entity_AssistMachine:OnSkillReady__DelegateSignature";

		// Token: 0x04010131 RID: 65841
		private static int RegisterId;

		// Token: 0x020032C7 RID: 12999
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401716D RID: 94573
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
