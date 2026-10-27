using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x0200188C RID: 6284
	public sealed class FAIAsyncPerceptionCallback : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601727D RID: 94845 RVA: 0x0021BF06 File Offset: 0x0021A106
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FAIAsyncPerceptionCallback.StaticFunctionPtr();
		}

		// Token: 0x0601727E RID: 94846 RVA: 0x0021BF12 File Offset: 0x0021A112
		private static IntPtr StaticFunctionPtr()
		{
			if (FAIAsyncPerceptionCallback._FunctionPtr == IntPtr.Zero)
			{
				FAIAsyncPerceptionCallback._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.AIAsyncPerceptionCallback__DelegateSignature");
			}
			return FAIAsyncPerceptionCallback._FunctionPtr;
		}

		// Token: 0x0601727F RID: 94847 RVA: 0x0021BF35 File Offset: 0x0021A135
		public FAIAsyncPerceptionCallback()
		{
		}

		// Token: 0x06017280 RID: 94848 RVA: 0x0021BF3D File Offset: 0x0021A13D
		[NullableContext(2)]
		public FAIAsyncPerceptionCallback(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06017281 RID: 94849 RVA: 0x0021BF47 File Offset: 0x0021A147
		public FAIAsyncPerceptionCallback(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06017282 RID: 94850 RVA: 0x0021BF52 File Offset: 0x0021A152
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06017283 RID: 94851 RVA: 0x0021BF84 File Offset: 0x0021A184
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action Callback)
		{
			if (FAIAsyncPerceptionCallback.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FAIAsyncPerceptionCallback.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FAIAsyncPerceptionCallback.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FAIAsyncPerceptionCallback.OnScriptCallback));
				}
				FAIAsyncPerceptionCallback.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FAIAsyncPerceptionCallback.RegisterId);
		}

		// Token: 0x06017284 RID: 94852 RVA: 0x0021BFBE File Offset: 0x0021A1BE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x06017285 RID: 94853 RVA: 0x0021BFCC File Offset: 0x0021A1CC
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

		// Token: 0x0400C8EC RID: 51436
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400C8ED RID: 51437
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.AIAsyncPerceptionCallback__DelegateSignature";

		// Token: 0x0400C8EE RID: 51438
		private static int RegisterId;

		// Token: 0x02002F89 RID: 12169
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016B4C RID: 93004
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
