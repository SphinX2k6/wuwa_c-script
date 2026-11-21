using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x020005A3 RID: 1443
	public sealed class FOnSkillReady : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06008241 RID: 33345 RVA: 0x000C09B8 File Offset: 0x000BEBB8
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnSkillReady.StaticFunctionPtr();
		}

		// Token: 0x06008242 RID: 33346 RVA: 0x000C09C4 File Offset: 0x000BEBC4
		private static IntPtr StaticFunctionPtr()
		{
			if (AKSC_Entity_AssistMachine.__OnSkillReady__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				AKSC_Entity_AssistMachine.__OnSkillReady__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSimpleCombat.KSC_Entity_AssistMachine:OnSkillReady__DelegateSignature");
			}
			return AKSC_Entity_AssistMachine.__OnSkillReady__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x06008243 RID: 33347 RVA: 0x000C09E7 File Offset: 0x000BEBE7
		public FOnSkillReady()
		{
		}

		// Token: 0x06008244 RID: 33348 RVA: 0x000C09EF File Offset: 0x000BEBEF
		[NullableContext(2)]
		public FOnSkillReady(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008245 RID: 33349 RVA: 0x000C09F9 File Offset: 0x000BEBF9
		public FOnSkillReady(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008246 RID: 33350 RVA: 0x000C0A04 File Offset: 0x000BEC04
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06008247 RID: 33351 RVA: 0x000C0A36 File Offset: 0x000BEC36
		[NullableContext(1)]
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

		// Token: 0x06008248 RID: 33352 RVA: 0x000C0A70 File Offset: 0x000BEC70
		[SkipLocalsInit]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x06008249 RID: 33353 RVA: 0x000C0A7C File Offset: 0x000BEC7C
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action action = target as Action;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action();
		}

		// Token: 0x040038C5 RID: 14533
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Entity_AssistMachine:OnSkillReady__DelegateSignature";

		// Token: 0x040038C6 RID: 14534
		private static int RegisterId;

		// Token: 0x02000D26 RID: 3366
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005FB9 RID: 24505
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
