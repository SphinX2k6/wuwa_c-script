using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F0A RID: 7946
	public sealed class FTickableHandler : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601E281 RID: 123521 RVA: 0x002CD622 File Offset: 0x002CB822
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FTickableHandler.StaticFunctionPtr();
		}

		// Token: 0x0601E282 RID: 123522 RVA: 0x002CD62E File Offset: 0x002CB82E
		private static IntPtr StaticFunctionPtr()
		{
			if (FTickableHandler._FunctionPtr == IntPtr.Zero)
			{
				FTickableHandler._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.TickableHandler__DelegateSignature");
			}
			return FTickableHandler._FunctionPtr;
		}

		// Token: 0x0601E283 RID: 123523 RVA: 0x002CD651 File Offset: 0x002CB851
		public FTickableHandler()
		{
		}

		// Token: 0x0601E284 RID: 123524 RVA: 0x002CD659 File Offset: 0x002CB859
		[NullableContext(2)]
		public FTickableHandler(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E285 RID: 123525 RVA: 0x002CD663 File Offset: 0x002CB863
		public FTickableHandler(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E286 RID: 123526 RVA: 0x002CD66E File Offset: 0x002CB86E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<float>) ?? ((Action<float>)Delegate.CreateDelegate(typeof(Action<float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601E287 RID: 123527 RVA: 0x002CD6A0 File Offset: 0x002CB8A0
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<float> Callback)
		{
			if (FTickableHandler.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FTickableHandler.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FTickableHandler.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FTickableHandler.OnScriptCallback));
				}
				FTickableHandler.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FTickableHandler.RegisterId);
		}

		// Token: 0x0601E288 RID: 123528 RVA: 0x002CD6DC File Offset: 0x002CB8DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(float DeltaSeconds)
		{
			FTickableHandler.__FTickableHandler_DelegateParams* ptr = stackalloc FTickableHandler.__FTickableHandler_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FTickableHandler.__FTickableHandler_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FTickableHandler.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601E289 RID: 123529 RVA: 0x002CD71C File Offset: 0x002CB91C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<float> action = target as Action<float>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FTickableHandler.__FTickableHandler_DelegateParams*)__Parameters)->DeltaSeconds);
		}

		// Token: 0x0401048C RID: 66700
		internal static IntPtr _FunctionPtr;

		// Token: 0x0401048D RID: 66701
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.TickableHandler__DelegateSignature";

		// Token: 0x0401048E RID: 66702
		private static int RegisterId;

		// Token: 0x020033F9 RID: 13305
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FTickableHandler_DelegateParams
		{
			// Token: 0x040173B3 RID: 95155
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x020033FA RID: 13306
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040173B4 RID: 95156
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
