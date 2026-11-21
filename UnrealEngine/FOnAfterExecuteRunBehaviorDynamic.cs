using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002DD RID: 733
	public sealed class FOnAfterExecuteRunBehaviorDynamic : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06004EEA RID: 20202 RVA: 0x0006E89F File Offset: 0x0006CA9F
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnAfterExecuteRunBehaviorDynamic.StaticFunctionPtr();
		}

		// Token: 0x06004EEB RID: 20203 RVA: 0x0006E8AB File Offset: 0x0006CAAB
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnAfterExecuteRunBehaviorDynamic._FunctionPtr == IntPtr.Zero)
			{
				FOnAfterExecuteRunBehaviorDynamic._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroAI.OnAfterExecuteRunBehaviorDynamic__DelegateSignature");
			}
			return FOnAfterExecuteRunBehaviorDynamic._FunctionPtr;
		}

		// Token: 0x06004EEC RID: 20204 RVA: 0x0006E8CE File Offset: 0x0006CACE
		public FOnAfterExecuteRunBehaviorDynamic()
		{
		}

		// Token: 0x06004EED RID: 20205 RVA: 0x0006E8D6 File Offset: 0x0006CAD6
		[NullableContext(2)]
		public FOnAfterExecuteRunBehaviorDynamic(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004EEE RID: 20206 RVA: 0x0006E8E0 File Offset: 0x0006CAE0
		public FOnAfterExecuteRunBehaviorDynamic(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004EEF RID: 20207 RVA: 0x0006E8EB File Offset: 0x0006CAEB
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<UBehaviorTreeComponent, int>) ?? ((Action<UBehaviorTreeComponent, int>)Delegate.CreateDelegate(typeof(Action<UBehaviorTreeComponent, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06004EF0 RID: 20208 RVA: 0x0006E91D File Offset: 0x0006CB1D
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

		// Token: 0x06004EF1 RID: 20209 RVA: 0x0006E958 File Offset: 0x0006CB58
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Execute(UBehaviorTreeComponent OwnerComp, int NodeId)
		{
			FOnAfterExecuteRunBehaviorDynamic.__FOnAfterExecuteRunBehaviorDynamic_DelegateParams* ptr = stackalloc FOnAfterExecuteRunBehaviorDynamic.__FOnAfterExecuteRunBehaviorDynamic_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnAfterExecuteRunBehaviorDynamic.__FOnAfterExecuteRunBehaviorDynamic_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnAfterExecuteRunBehaviorDynamic.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->OwnerComp = ((OwnerComp != null) ? OwnerComp.NativePtr : IntPtr.Zero);
			ptr->NodeId = NodeId;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06004EF2 RID: 20210 RVA: 0x0006E9AC File Offset: 0x0006CBAC
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04001F9B RID: 8091
		internal static IntPtr _FunctionPtr;

		// Token: 0x04001F9C RID: 8092
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroAI.OnAfterExecuteRunBehaviorDynamic__DelegateSignature";

		// Token: 0x04001F9D RID: 8093
		private static int RegisterId;

		// Token: 0x02000A10 RID: 2576
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FOnAfterExecuteRunBehaviorDynamic_DelegateParams
		{
			// Token: 0x040059CE RID: 22990
			[FieldOffset(0)]
			public IntPtr OwnerComp;

			// Token: 0x040059CF RID: 22991
			[FieldOffset(8)]
			public int NodeId;
		}

		// Token: 0x02000A11 RID: 2577
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040059D0 RID: 22992
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
