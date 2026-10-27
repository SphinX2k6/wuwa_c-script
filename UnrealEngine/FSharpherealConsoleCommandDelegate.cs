using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x02002764 RID: 10084
	public sealed class FSharpherealConsoleCommandDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06025B64 RID: 154468 RVA: 0x00392792 File Offset: 0x00390992
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSharpherealConsoleCommandDelegate.StaticFunctionPtr();
		}

		// Token: 0x06025B65 RID: 154469 RVA: 0x0039279E File Offset: 0x0039099E
		private static IntPtr StaticFunctionPtr()
		{
			if (FSharpherealConsoleCommandDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSharpherealConsoleCommandDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Sharphereal.SharpherealConsoleCommandDelegate__DelegateSignature");
			}
			return FSharpherealConsoleCommandDelegate._FunctionPtr;
		}

		// Token: 0x06025B66 RID: 154470 RVA: 0x003927C1 File Offset: 0x003909C1
		public FSharpherealConsoleCommandDelegate()
		{
		}

		// Token: 0x06025B67 RID: 154471 RVA: 0x003927C9 File Offset: 0x003909C9
		[NullableContext(2)]
		public FSharpherealConsoleCommandDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025B68 RID: 154472 RVA: 0x003927D3 File Offset: 0x003909D3
		public FSharpherealConsoleCommandDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025B69 RID: 154473 RVA: 0x003927DE File Offset: 0x003909DE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06025B6A RID: 154474 RVA: 0x00392810 File Offset: 0x00390A10
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action Callback)
		{
			if (FSharpherealConsoleCommandDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSharpherealConsoleCommandDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSharpherealConsoleCommandDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSharpherealConsoleCommandDelegate.OnScriptCallback));
				}
				FSharpherealConsoleCommandDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FSharpherealConsoleCommandDelegate.RegisterId);
		}

		// Token: 0x06025B6B RID: 154475 RVA: 0x0039284A File Offset: 0x00390A4A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x06025B6C RID: 154476 RVA: 0x00392858 File Offset: 0x00390A58
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

		// Token: 0x0401487E RID: 84094
		internal static IntPtr _FunctionPtr;

		// Token: 0x0401487F RID: 84095
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Sharphereal.SharpherealConsoleCommandDelegate__DelegateSignature";

		// Token: 0x04014880 RID: 84096
		private static int RegisterId;

		// Token: 0x02003A59 RID: 14937
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017BB3 RID: 97203
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
