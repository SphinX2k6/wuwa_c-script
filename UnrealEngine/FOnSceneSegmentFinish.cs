using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x02001E6D RID: 7789
	public sealed class FOnSceneSegmentFinish : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601DABC RID: 121532 RVA: 0x002BD33A File Offset: 0x002BB53A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnSceneSegmentFinish.StaticFunctionPtr();
		}

		// Token: 0x0601DABD RID: 121533 RVA: 0x002BD346 File Offset: 0x002BB546
		private static IntPtr StaticFunctionPtr()
		{
			if (UKSC_SceneMovement.__OnSceneSegmentFinish__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UKSC_SceneMovement.__OnSceneSegmentFinish__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSimpleCombat.KSC_SceneMovement:OnSceneSegmentFinish__DelegateSignature");
			}
			return UKSC_SceneMovement.__OnSceneSegmentFinish__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601DABE RID: 121534 RVA: 0x002BD369 File Offset: 0x002BB569
		public FOnSceneSegmentFinish()
		{
		}

		// Token: 0x0601DABF RID: 121535 RVA: 0x002BD371 File Offset: 0x002BB571
		[NullableContext(2)]
		public FOnSceneSegmentFinish(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601DAC0 RID: 121536 RVA: 0x002BD37B File Offset: 0x002BB57B
		public FOnSceneSegmentFinish(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601DAC1 RID: 121537 RVA: 0x002BD386 File Offset: 0x002BB586
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601DAC2 RID: 121538 RVA: 0x002BD3B8 File Offset: 0x002BB5B8
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action Callback)
		{
			if (FOnSceneSegmentFinish.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnSceneSegmentFinish.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnSceneSegmentFinish.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnSceneSegmentFinish.OnScriptCallback));
				}
				FOnSceneSegmentFinish.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnSceneSegmentFinish.RegisterId);
		}

		// Token: 0x0601DAC3 RID: 121539 RVA: 0x002BD3F2 File Offset: 0x002BB5F2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x0601DAC4 RID: 121540 RVA: 0x002BD400 File Offset: 0x002BB600
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

		// Token: 0x04010129 RID: 65833
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_SceneMovement:OnSceneSegmentFinish__DelegateSignature";

		// Token: 0x0401012A RID: 65834
		private static int RegisterId;

		// Token: 0x020032C2 RID: 12994
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017166 RID: 94566
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
