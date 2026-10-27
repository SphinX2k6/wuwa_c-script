using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x02001E6C RID: 7788
	public sealed class FOnSceneMoveThreshold : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601DAB3 RID: 121523 RVA: 0x002BD232 File Offset: 0x002BB432
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnSceneMoveThreshold.StaticFunctionPtr();
		}

		// Token: 0x0601DAB4 RID: 121524 RVA: 0x002BD23E File Offset: 0x002BB43E
		private static IntPtr StaticFunctionPtr()
		{
			if (UKSC_SceneMovement.__OnSceneMoveThreshold__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UKSC_SceneMovement.__OnSceneMoveThreshold__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSimpleCombat.KSC_SceneMovement:OnSceneMoveThreshold__DelegateSignature");
			}
			return UKSC_SceneMovement.__OnSceneMoveThreshold__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601DAB5 RID: 121525 RVA: 0x002BD261 File Offset: 0x002BB461
		public FOnSceneMoveThreshold()
		{
		}

		// Token: 0x0601DAB6 RID: 121526 RVA: 0x002BD269 File Offset: 0x002BB469
		[NullableContext(2)]
		public FOnSceneMoveThreshold(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601DAB7 RID: 121527 RVA: 0x002BD273 File Offset: 0x002BB473
		public FOnSceneMoveThreshold(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601DAB8 RID: 121528 RVA: 0x002BD27E File Offset: 0x002BB47E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601DAB9 RID: 121529 RVA: 0x002BD2B0 File Offset: 0x002BB4B0
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action Callback)
		{
			if (FOnSceneMoveThreshold.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnSceneMoveThreshold.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnSceneMoveThreshold.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnSceneMoveThreshold.OnScriptCallback));
				}
				FOnSceneMoveThreshold.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnSceneMoveThreshold.RegisterId);
		}

		// Token: 0x0601DABA RID: 121530 RVA: 0x002BD2EA File Offset: 0x002BB4EA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x0601DABB RID: 121531 RVA: 0x002BD2F8 File Offset: 0x002BB4F8
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

		// Token: 0x04010127 RID: 65831
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_SceneMovement:OnSceneMoveThreshold__DelegateSignature";

		// Token: 0x04010128 RID: 65832
		private static int RegisterId;

		// Token: 0x020032C1 RID: 12993
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017165 RID: 94565
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
