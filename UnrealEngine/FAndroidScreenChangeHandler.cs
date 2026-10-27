using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x02001E8C RID: 7820
	public sealed class FAndroidScreenChangeHandler : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601DC03 RID: 121859 RVA: 0x002BF480 File Offset: 0x002BD680
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FAndroidScreenChangeHandler.StaticFunctionPtr();
		}

		// Token: 0x0601DC04 RID: 121860 RVA: 0x002BF48C File Offset: 0x002BD68C
		private static IntPtr StaticFunctionPtr()
		{
			if (FAndroidScreenChangeHandler._FunctionPtr == IntPtr.Zero)
			{
				FAndroidScreenChangeHandler._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.AndroidScreenChangeHandler__DelegateSignature");
			}
			return FAndroidScreenChangeHandler._FunctionPtr;
		}

		// Token: 0x0601DC05 RID: 121861 RVA: 0x002BF4AF File Offset: 0x002BD6AF
		public FAndroidScreenChangeHandler()
		{
		}

		// Token: 0x0601DC06 RID: 121862 RVA: 0x002BF4B7 File Offset: 0x002BD6B7
		[NullableContext(2)]
		public FAndroidScreenChangeHandler(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601DC07 RID: 121863 RVA: 0x002BF4C1 File Offset: 0x002BD6C1
		public FAndroidScreenChangeHandler(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601DC08 RID: 121864 RVA: 0x002BF4CC File Offset: 0x002BD6CC
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601DC09 RID: 121865 RVA: 0x002BF4FE File Offset: 0x002BD6FE
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action Callback)
		{
			if (FAndroidScreenChangeHandler.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FAndroidScreenChangeHandler.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FAndroidScreenChangeHandler.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FAndroidScreenChangeHandler.OnScriptCallback));
				}
				FAndroidScreenChangeHandler.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FAndroidScreenChangeHandler.RegisterId);
		}

		// Token: 0x0601DC0A RID: 121866 RVA: 0x002BF538 File Offset: 0x002BD738
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x0601DC0B RID: 121867 RVA: 0x002BF544 File Offset: 0x002BD744
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

		// Token: 0x040101BD RID: 65981
		internal static IntPtr _FunctionPtr;

		// Token: 0x040101BE RID: 65982
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.AndroidScreenChangeHandler__DelegateSignature";

		// Token: 0x040101BF RID: 65983
		private static int RegisterId;

		// Token: 0x020032D9 RID: 13017
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017186 RID: 94598
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
