using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002084 RID: 8324
	public sealed class FLGUILoopScrollViewGridCreateDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F66F RID: 128623 RVA: 0x002EA26A File Offset: 0x002E846A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUILoopScrollViewGridCreateDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601F670 RID: 128624 RVA: 0x002EA276 File Offset: 0x002E8476
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUILoopScrollViewGridCreateDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUILoopScrollViewGridCreateDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUILoopScrollViewGridCreateDelegate__DelegateSignature");
			}
			return FLGUILoopScrollViewGridCreateDelegate._FunctionPtr;
		}

		// Token: 0x0601F671 RID: 128625 RVA: 0x002EA299 File Offset: 0x002E8499
		public FLGUILoopScrollViewGridCreateDelegate()
		{
		}

		// Token: 0x0601F672 RID: 128626 RVA: 0x002EA2A1 File Offset: 0x002E84A1
		[NullableContext(2)]
		public FLGUILoopScrollViewGridCreateDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F673 RID: 128627 RVA: 0x002EA2AB File Offset: 0x002E84AB
		public FLGUILoopScrollViewGridCreateDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F674 RID: 128628 RVA: 0x002EA2B6 File Offset: 0x002E84B6
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int, AUIBaseActor>) ?? ((Action<int, AUIBaseActor>)Delegate.CreateDelegate(typeof(Action<int, AUIBaseActor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F675 RID: 128629 RVA: 0x002EA2E8 File Offset: 0x002E84E8
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind([Nullable(new byte[]
		{
			1,
			2
		})] Action<int, AUIBaseActor> Callback)
		{
			if (FLGUILoopScrollViewGridCreateDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUILoopScrollViewGridCreateDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUILoopScrollViewGridCreateDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUILoopScrollViewGridCreateDelegate.OnScriptCallback));
				}
				FLGUILoopScrollViewGridCreateDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUILoopScrollViewGridCreateDelegate.RegisterId);
		}

		// Token: 0x0601F676 RID: 128630 RVA: 0x002EA324 File Offset: 0x002E8524
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(int DisplayIndex, AUIBaseActor Actor)
		{
			FLGUILoopScrollViewGridCreateDelegate.__FLGUILoopScrollViewGridCreateDelegate_DelegateParams* ptr = stackalloc FLGUILoopScrollViewGridCreateDelegate.__FLGUILoopScrollViewGridCreateDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FLGUILoopScrollViewGridCreateDelegate.__FLGUILoopScrollViewGridCreateDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUILoopScrollViewGridCreateDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->DisplayIndex = DisplayIndex;
			ptr->Actor = ((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601F677 RID: 128631 RVA: 0x002EA378 File Offset: 0x002E8578
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, AUIBaseActor> action = target as Action<int, AUIBaseActor>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			AUIBaseActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AUIBaseActor>(((FLGUILoopScrollViewGridCreateDelegate.__FLGUILoopScrollViewGridCreateDelegate_DelegateParams*)__Parameters)->Actor);
			action(((FLGUILoopScrollViewGridCreateDelegate.__FLGUILoopScrollViewGridCreateDelegate_DelegateParams*)__Parameters)->DisplayIndex, orCreateUObjectByNativePointer);
		}

		// Token: 0x04010F5B RID: 69467
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010F5C RID: 69468
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUILoopScrollViewGridCreateDelegate__DelegateSignature";

		// Token: 0x04010F5D RID: 69469
		private static int RegisterId;

		// Token: 0x02003486 RID: 13446
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FLGUILoopScrollViewGridCreateDelegate_DelegateParams
		{
			// Token: 0x04017474 RID: 95348
			[FieldOffset(0)]
			public int DisplayIndex;

			// Token: 0x04017475 RID: 95349
			[FieldOffset(8)]
			public IntPtr Actor;
		}

		// Token: 0x02003487 RID: 13447
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017476 RID: 95350
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
