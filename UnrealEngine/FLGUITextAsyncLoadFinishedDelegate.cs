using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x020006C1 RID: 1729
	public sealed class FLGUITextAsyncLoadFinishedDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060093EE RID: 37870 RVA: 0x000DEF49 File Offset: 0x000DD149
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUITextAsyncLoadFinishedDelegate.StaticFunctionPtr();
		}

		// Token: 0x060093EF RID: 37871 RVA: 0x000DEF55 File Offset: 0x000DD155
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUITextAsyncLoadFinishedDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUITextAsyncLoadFinishedDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUITextAsyncLoadFinishedDelegate__DelegateSignature");
			}
			return FLGUITextAsyncLoadFinishedDelegate._FunctionPtr;
		}

		// Token: 0x060093F0 RID: 37872 RVA: 0x000DEF78 File Offset: 0x000DD178
		public FLGUITextAsyncLoadFinishedDelegate()
		{
		}

		// Token: 0x060093F1 RID: 37873 RVA: 0x000DEF80 File Offset: 0x000DD180
		[NullableContext(2)]
		public FLGUITextAsyncLoadFinishedDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060093F2 RID: 37874 RVA: 0x000DEF8A File Offset: 0x000DD18A
		public FLGUITextAsyncLoadFinishedDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060093F3 RID: 37875 RVA: 0x000DEF95 File Offset: 0x000DD195
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x060093F4 RID: 37876 RVA: 0x000DEFC7 File Offset: 0x000DD1C7
		[NullableContext(1)]
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

		// Token: 0x060093F5 RID: 37877 RVA: 0x000DF001 File Offset: 0x000DD201
		[SkipLocalsInit]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x060093F6 RID: 37878 RVA: 0x000DF00C File Offset: 0x000DD20C
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

		// Token: 0x04004078 RID: 16504
		internal static IntPtr _FunctionPtr;

		// Token: 0x04004079 RID: 16505
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUITextAsyncLoadFinishedDelegate__DelegateSignature";

		// Token: 0x0400407A RID: 16506
		private static int RegisterId;

		// Token: 0x02000EEF RID: 3823
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040062B1 RID: 25265
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
