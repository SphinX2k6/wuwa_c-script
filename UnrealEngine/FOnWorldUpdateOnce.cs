using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x02001E72 RID: 7794
	public sealed class FOnWorldUpdateOnce : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601DAE9 RID: 121577 RVA: 0x002BD8EA File Offset: 0x002BBAEA
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnWorldUpdateOnce.StaticFunctionPtr();
		}

		// Token: 0x0601DAEA RID: 121578 RVA: 0x002BD8F6 File Offset: 0x002BBAF6
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnWorldUpdateOnce._FunctionPtr == IntPtr.Zero)
			{
				FOnWorldUpdateOnce._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSimpleCombat.OnWorldUpdateOnce__DelegateSignature");
			}
			return FOnWorldUpdateOnce._FunctionPtr;
		}

		// Token: 0x0601DAEB RID: 121579 RVA: 0x002BD919 File Offset: 0x002BBB19
		public FOnWorldUpdateOnce()
		{
		}

		// Token: 0x0601DAEC RID: 121580 RVA: 0x002BD921 File Offset: 0x002BBB21
		[NullableContext(2)]
		public FOnWorldUpdateOnce(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601DAED RID: 121581 RVA: 0x002BD92B File Offset: 0x002BBB2B
		public FOnWorldUpdateOnce(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601DAEE RID: 121582 RVA: 0x002BD936 File Offset: 0x002BBB36
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601DAEF RID: 121583 RVA: 0x002BD968 File Offset: 0x002BBB68
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action Callback)
		{
			if (FOnWorldUpdateOnce.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnWorldUpdateOnce.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnWorldUpdateOnce.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnWorldUpdateOnce.OnScriptCallback));
				}
				FOnWorldUpdateOnce.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnWorldUpdateOnce.RegisterId);
		}

		// Token: 0x0601DAF0 RID: 121584 RVA: 0x002BD9A2 File Offset: 0x002BBBA2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x0601DAF1 RID: 121585 RVA: 0x002BD9B0 File Offset: 0x002BBBB0
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

		// Token: 0x04010135 RID: 65845
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010136 RID: 65846
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.OnWorldUpdateOnce__DelegateSignature";

		// Token: 0x04010137 RID: 65847
		private static int RegisterId;

		// Token: 0x020032C9 RID: 13001
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401716F RID: 94575
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
