using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x020028F6 RID: 10486
	public sealed class FUpdateGameCancelHandle : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06026E37 RID: 159287 RVA: 0x003B52AD File Offset: 0x003B34AD
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FUpdateGameCancelHandle.StaticFunctionPtr();
		}

		// Token: 0x06026E38 RID: 159288 RVA: 0x003B52B9 File Offset: 0x003B34B9
		private static IntPtr StaticFunctionPtr()
		{
			if (FUpdateGameCancelHandle._FunctionPtr == IntPtr.Zero)
			{
				FUpdateGameCancelHandle._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/TapUpdate.UpdateGameCancelHandle__DelegateSignature");
			}
			return FUpdateGameCancelHandle._FunctionPtr;
		}

		// Token: 0x06026E39 RID: 159289 RVA: 0x003B52DC File Offset: 0x003B34DC
		public FUpdateGameCancelHandle()
		{
		}

		// Token: 0x06026E3A RID: 159290 RVA: 0x003B52E4 File Offset: 0x003B34E4
		[NullableContext(2)]
		public FUpdateGameCancelHandle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026E3B RID: 159291 RVA: 0x003B52EE File Offset: 0x003B34EE
		public FUpdateGameCancelHandle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026E3C RID: 159292 RVA: 0x003B52F9 File Offset: 0x003B34F9
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06026E3D RID: 159293 RVA: 0x003B532B File Offset: 0x003B352B
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action Callback)
		{
			if (FUpdateGameCancelHandle.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FUpdateGameCancelHandle.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FUpdateGameCancelHandle.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FUpdateGameCancelHandle.OnScriptCallback));
				}
				FUpdateGameCancelHandle.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FUpdateGameCancelHandle.RegisterId);
		}

		// Token: 0x06026E3E RID: 159294 RVA: 0x003B5365 File Offset: 0x003B3565
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x06026E3F RID: 159295 RVA: 0x003B5370 File Offset: 0x003B3570
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

		// Token: 0x0401559D RID: 87453
		internal static IntPtr _FunctionPtr;

		// Token: 0x0401559E RID: 87454
		[Nullable(1)]
		public const string __ObjectPath = "/Script/TapUpdate.UpdateGameCancelHandle__DelegateSignature";

		// Token: 0x0401559F RID: 87455
		private static int RegisterId;

		// Token: 0x02003B57 RID: 15191
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017D01 RID: 97537
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
