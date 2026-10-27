using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x020020CE RID: 8398
	public sealed class FLGUITextAsyncLoadFinishedDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601FA43 RID: 129603 RVA: 0x002F0BAE File Offset: 0x002EEDAE
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUITextAsyncLoadFinishedDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601FA44 RID: 129604 RVA: 0x002F0BBA File Offset: 0x002EEDBA
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUITextAsyncLoadFinishedDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUITextAsyncLoadFinishedDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUITextAsyncLoadFinishedDelegate__DelegateSignature");
			}
			return FLGUITextAsyncLoadFinishedDelegate._FunctionPtr;
		}

		// Token: 0x0601FA45 RID: 129605 RVA: 0x002F0BDD File Offset: 0x002EEDDD
		public FLGUITextAsyncLoadFinishedDelegate()
		{
		}

		// Token: 0x0601FA46 RID: 129606 RVA: 0x002F0BE5 File Offset: 0x002EEDE5
		[NullableContext(2)]
		public FLGUITextAsyncLoadFinishedDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FA47 RID: 129607 RVA: 0x002F0BEF File Offset: 0x002EEDEF
		public FLGUITextAsyncLoadFinishedDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FA48 RID: 129608 RVA: 0x002F0BFA File Offset: 0x002EEDFA
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601FA49 RID: 129609 RVA: 0x002F0C2C File Offset: 0x002EEE2C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action Callback)
		{
			if (FLGUITextAsyncLoadFinishedDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUITextAsyncLoadFinishedDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUITextAsyncLoadFinishedDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUITextAsyncLoadFinishedDelegate.OnScriptCallback));
				}
				FLGUITextAsyncLoadFinishedDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUITextAsyncLoadFinishedDelegate.RegisterId);
		}

		// Token: 0x0601FA4A RID: 129610 RVA: 0x002F0C66 File Offset: 0x002EEE66
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x0601FA4B RID: 129611 RVA: 0x002F0C74 File Offset: 0x002EEE74
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

		// Token: 0x04011135 RID: 69941
		internal static IntPtr _FunctionPtr;

		// Token: 0x04011136 RID: 69942
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUITextAsyncLoadFinishedDelegate__DelegateSignature";

		// Token: 0x04011137 RID: 69943
		private static int RegisterId;

		// Token: 0x020034C1 RID: 13505
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040174CA RID: 95434
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
