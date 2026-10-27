using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020015FD RID: 5629
	public sealed class FOnAfterExecuteRunBehaviorDynamic : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06014429 RID: 82985 RVA: 0x001DC428 File Offset: 0x001DA628
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnAfterExecuteRunBehaviorDynamic.StaticFunctionPtr();
		}

		// Token: 0x0601442A RID: 82986 RVA: 0x001DC434 File Offset: 0x001DA634
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnAfterExecuteRunBehaviorDynamic._FunctionPtr == IntPtr.Zero)
			{
				FOnAfterExecuteRunBehaviorDynamic._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroAI.OnAfterExecuteRunBehaviorDynamic__DelegateSignature");
			}
			return FOnAfterExecuteRunBehaviorDynamic._FunctionPtr;
		}

		// Token: 0x0601442B RID: 82987 RVA: 0x001DC457 File Offset: 0x001DA657
		public FOnAfterExecuteRunBehaviorDynamic()
		{
		}

		// Token: 0x0601442C RID: 82988 RVA: 0x001DC45F File Offset: 0x001DA65F
		[NullableContext(2)]
		public FOnAfterExecuteRunBehaviorDynamic(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601442D RID: 82989 RVA: 0x001DC469 File Offset: 0x001DA669
		public FOnAfterExecuteRunBehaviorDynamic(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601442E RID: 82990 RVA: 0x001DC474 File Offset: 0x001DA674
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<UBehaviorTreeComponent, int>) ?? ((Action<UBehaviorTreeComponent, int>)Delegate.CreateDelegate(typeof(Action<UBehaviorTreeComponent, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601442F RID: 82991 RVA: 0x001DC4A6 File Offset: 0x001DA6A6
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind([Nullable(new byte[]
		{
			1,
			2
		})] Action<UBehaviorTreeComponent, int> Callback)
		{
			if (FOnAfterExecuteRunBehaviorDynamic.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnAfterExecuteRunBehaviorDynamic.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnAfterExecuteRunBehaviorDynamic.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnAfterExecuteRunBehaviorDynamic.OnScriptCallback));
				}
				FOnAfterExecuteRunBehaviorDynamic.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnAfterExecuteRunBehaviorDynamic.RegisterId);
		}

		// Token: 0x06014430 RID: 82992 RVA: 0x001DC4E0 File Offset: 0x001DA6E0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(UBehaviorTreeComponent OwnerComp, int NodeId)
		{
			FOnAfterExecuteRunBehaviorDynamic.__FOnAfterExecuteRunBehaviorDynamic_DelegateParams* ptr = stackalloc FOnAfterExecuteRunBehaviorDynamic.__FOnAfterExecuteRunBehaviorDynamic_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnAfterExecuteRunBehaviorDynamic.__FOnAfterExecuteRunBehaviorDynamic_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnAfterExecuteRunBehaviorDynamic.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->OwnerComp = ((OwnerComp != null) ? OwnerComp.NativePtr : IntPtr.Zero);
			ptr->NodeId = NodeId;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06014431 RID: 82993 RVA: 0x001DC534 File Offset: 0x001DA734
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UBehaviorTreeComponent, int> action = target as Action<UBehaviorTreeComponent, int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UBehaviorTreeComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UBehaviorTreeComponent>(((FOnAfterExecuteRunBehaviorDynamic.__FOnAfterExecuteRunBehaviorDynamic_DelegateParams*)__Parameters)->OwnerComp);
			action(orCreateUObjectByNativePointer, ((FOnAfterExecuteRunBehaviorDynamic.__FOnAfterExecuteRunBehaviorDynamic_DelegateParams*)__Parameters)->NodeId);
		}

		// Token: 0x0400B060 RID: 45152
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400B061 RID: 45153
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroAI.OnAfterExecuteRunBehaviorDynamic__DelegateSignature";

		// Token: 0x0400B062 RID: 45154
		private static int RegisterId;

		// Token: 0x02002ED7 RID: 11991
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FOnAfterExecuteRunBehaviorDynamic_DelegateParams
		{
			// Token: 0x040169F3 RID: 92659
			[FieldOffset(0)]
			public IntPtr OwnerComp;

			// Token: 0x040169F4 RID: 92660
			[FieldOffset(8)]
			public int NodeId;
		}

		// Token: 0x02002ED8 RID: 11992
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040169F5 RID: 92661
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
