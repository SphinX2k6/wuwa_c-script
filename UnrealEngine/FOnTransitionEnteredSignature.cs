using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200287B RID: 10363
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnTransitionEnteredSignature : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060265CF RID: 157135 RVA: 0x003A4BE7 File Offset: 0x003A2DE7
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnTransitionEnteredSignature.StaticFunctionPtr();
		}

		// Token: 0x060265D0 RID: 157136 RVA: 0x003A4BF3 File Offset: 0x003A2DF3
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnTransitionEnteredSignature._FunctionPtr == IntPtr.Zero)
			{
				FOnTransitionEnteredSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/SMSystem.OnTransitionEnteredSignature__DelegateSignature");
			}
			return FOnTransitionEnteredSignature._FunctionPtr;
		}

		// Token: 0x060265D1 RID: 157137 RVA: 0x003A4C16 File Offset: 0x003A2E16
		public FOnTransitionEnteredSignature()
		{
		}

		// Token: 0x060265D2 RID: 157138 RVA: 0x003A4C1E File Offset: 0x003A2E1E
		[NullableContext(2)]
		public FOnTransitionEnteredSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060265D3 RID: 157139 RVA: 0x003A4C28 File Offset: 0x003A2E28
		public FOnTransitionEnteredSignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060265D4 RID: 157140 RVA: 0x003A4C33 File Offset: 0x003A2E33
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<USMTransitionInstance>) ?? ((Action<USMTransitionInstance>)Delegate.CreateDelegate(typeof(Action<USMTransitionInstance>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060265D5 RID: 157141 RVA: 0x003A4C65 File Offset: 0x003A2E65
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<USMTransitionInstance> Callback)
		{
			if (FOnTransitionEnteredSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnTransitionEnteredSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnTransitionEnteredSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnTransitionEnteredSignature.OnScriptCallback));
				}
				FOnTransitionEnteredSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnTransitionEnteredSignature.RegisterId);
		}

		// Token: 0x060265D6 RID: 157142 RVA: 0x003A4C9F File Offset: 0x003A2E9F
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<USMTransitionInstance> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060265D7 RID: 157143 RVA: 0x003A4CA8 File Offset: 0x003A2EA8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(USMTransitionInstance TransitionInstance)
		{
			FOnTransitionEnteredSignature.__FOnTransitionEnteredSignature_DelegateParams* ptr = stackalloc FOnTransitionEnteredSignature.__FOnTransitionEnteredSignature_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnTransitionEnteredSignature.__FOnTransitionEnteredSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnTransitionEnteredSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->TransitionInstance = ((TransitionInstance != null) ? TransitionInstance.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060265D8 RID: 157144 RVA: 0x003A4CF4 File Offset: 0x003A2EF4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<USMTransitionInstance> action = target as Action<USMTransitionInstance>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			USMTransitionInstance orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USMTransitionInstance>(((FOnTransitionEnteredSignature.__FOnTransitionEnteredSignature_DelegateParams*)__Parameters)->TransitionInstance);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x040150A4 RID: 86180
		internal static IntPtr _FunctionPtr;

		// Token: 0x040150A5 RID: 86181
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SMSystem.OnTransitionEnteredSignature__DelegateSignature";

		// Token: 0x040150A6 RID: 86182
		private static int RegisterId;

		// Token: 0x02003A79 RID: 14969
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FOnTransitionEnteredSignature_DelegateParams
		{
			// Token: 0x04017BDC RID: 97244
			[FieldOffset(0)]
			public IntPtr TransitionInstance;
		}

		// Token: 0x02003A7A RID: 14970
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017BDD RID: 97245
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
