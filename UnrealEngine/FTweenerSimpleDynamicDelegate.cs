using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x0200225C RID: 8796
	public sealed class FTweenerSimpleDynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060216CB RID: 136907 RVA: 0x00314516 File Offset: 0x00312716
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FTweenerSimpleDynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x060216CC RID: 136908 RVA: 0x00314522 File Offset: 0x00312722
		private static IntPtr StaticFunctionPtr()
		{
			if (FTweenerSimpleDynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FTweenerSimpleDynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LTween.TweenerSimpleDynamicDelegate__DelegateSignature");
			}
			return FTweenerSimpleDynamicDelegate._FunctionPtr;
		}

		// Token: 0x060216CD RID: 136909 RVA: 0x00314545 File Offset: 0x00312745
		public FTweenerSimpleDynamicDelegate()
		{
		}

		// Token: 0x060216CE RID: 136910 RVA: 0x0031454D File Offset: 0x0031274D
		[NullableContext(2)]
		public FTweenerSimpleDynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060216CF RID: 136911 RVA: 0x00314557 File Offset: 0x00312757
		public FTweenerSimpleDynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060216D0 RID: 136912 RVA: 0x00314562 File Offset: 0x00312762
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x060216D1 RID: 136913 RVA: 0x00314594 File Offset: 0x00312794
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action Callback)
		{
			if (FTweenerSimpleDynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FTweenerSimpleDynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FTweenerSimpleDynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FTweenerSimpleDynamicDelegate.OnScriptCallback));
				}
				FTweenerSimpleDynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FTweenerSimpleDynamicDelegate.RegisterId);
		}

		// Token: 0x060216D2 RID: 136914 RVA: 0x003145CE File Offset: 0x003127CE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x060216D3 RID: 136915 RVA: 0x003145DC File Offset: 0x003127DC
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

		// Token: 0x04011CFC RID: 72956
		internal static IntPtr _FunctionPtr;

		// Token: 0x04011CFD RID: 72957
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LTween.TweenerSimpleDynamicDelegate__DelegateSignature";

		// Token: 0x04011CFE RID: 72958
		private static int RegisterId;

		// Token: 0x02003521 RID: 13601
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017553 RID: 95571
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
