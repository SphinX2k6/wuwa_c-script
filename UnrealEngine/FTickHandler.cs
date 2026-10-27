using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F0B RID: 7947
	public sealed class FTickHandler : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601E28A RID: 123530 RVA: 0x002CD766 File Offset: 0x002CB966
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FTickHandler.StaticFunctionPtr();
		}

		// Token: 0x0601E28B RID: 123531 RVA: 0x002CD772 File Offset: 0x002CB972
		private static IntPtr StaticFunctionPtr()
		{
			if (FTickHandler._FunctionPtr == IntPtr.Zero)
			{
				FTickHandler._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.TickHandler__DelegateSignature");
			}
			return FTickHandler._FunctionPtr;
		}

		// Token: 0x0601E28C RID: 123532 RVA: 0x002CD795 File Offset: 0x002CB995
		public FTickHandler()
		{
		}

		// Token: 0x0601E28D RID: 123533 RVA: 0x002CD79D File Offset: 0x002CB99D
		[NullableContext(2)]
		public FTickHandler(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E28E RID: 123534 RVA: 0x002CD7A7 File Offset: 0x002CB9A7
		public FTickHandler(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E28F RID: 123535 RVA: 0x002CD7B2 File Offset: 0x002CB9B2
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<float>) ?? ((Action<float>)Delegate.CreateDelegate(typeof(Action<float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601E290 RID: 123536 RVA: 0x002CD7E4 File Offset: 0x002CB9E4
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<float> Callback)
		{
			if (FTickHandler.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FTickHandler.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FTickHandler.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FTickHandler.OnScriptCallback));
				}
				FTickHandler.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FTickHandler.RegisterId);
		}

		// Token: 0x0601E291 RID: 123537 RVA: 0x002CD820 File Offset: 0x002CBA20
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(float DeltaSeconds)
		{
			FTickHandler.__FTickHandler_DelegateParams* ptr = stackalloc FTickHandler.__FTickHandler_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FTickHandler.__FTickHandler_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FTickHandler.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601E292 RID: 123538 RVA: 0x002CD860 File Offset: 0x002CBA60
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
			action(((FTickHandler.__FTickHandler_DelegateParams*)__Parameters)->DeltaSeconds);
		}

		// Token: 0x0401048F RID: 66703
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010490 RID: 66704
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.TickHandler__DelegateSignature";

		// Token: 0x04010491 RID: 66705
		private static int RegisterId;

		// Token: 0x020033FB RID: 13307
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FTickHandler_DelegateParams
		{
			// Token: 0x040173B5 RID: 95157
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x020033FC RID: 13308
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040173B6 RID: 95158
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
