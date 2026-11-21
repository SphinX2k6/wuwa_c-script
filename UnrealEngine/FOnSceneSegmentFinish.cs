using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x020005A0 RID: 1440
	public sealed class FOnSceneSegmentFinish : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06008226 RID: 33318 RVA: 0x000C0616 File Offset: 0x000BE816
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnSceneSegmentFinish.StaticFunctionPtr();
		}

		// Token: 0x06008227 RID: 33319 RVA: 0x000C0622 File Offset: 0x000BE822
		private static IntPtr StaticFunctionPtr()
		{
			if (UKSC_SceneMovement.__OnSceneSegmentFinish__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UKSC_SceneMovement.__OnSceneSegmentFinish__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSimpleCombat.KSC_SceneMovement:OnSceneSegmentFinish__DelegateSignature");
			}
			return UKSC_SceneMovement.__OnSceneSegmentFinish__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x06008228 RID: 33320 RVA: 0x000C0645 File Offset: 0x000BE845
		public FOnSceneSegmentFinish()
		{
		}

		// Token: 0x06008229 RID: 33321 RVA: 0x000C064D File Offset: 0x000BE84D
		[NullableContext(2)]
		public FOnSceneSegmentFinish(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600822A RID: 33322 RVA: 0x000C0657 File Offset: 0x000BE857
		public FOnSceneSegmentFinish(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600822B RID: 33323 RVA: 0x000C0662 File Offset: 0x000BE862
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600822C RID: 33324 RVA: 0x000C0694 File Offset: 0x000BE894
		[NullableContext(1)]
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

		// Token: 0x0600822D RID: 33325 RVA: 0x000C06CE File Offset: 0x000BE8CE
		[SkipLocalsInit]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x0600822E RID: 33326 RVA: 0x000C06DC File Offset: 0x000BE8DC
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

		// Token: 0x040038BE RID: 14526
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_SceneMovement:OnSceneSegmentFinish__DelegateSignature";

		// Token: 0x040038BF RID: 14527
		private static int RegisterId;

		// Token: 0x02000D21 RID: 3361
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005FB2 RID: 24498
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
