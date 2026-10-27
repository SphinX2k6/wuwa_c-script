using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200084E RID: 2126
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FApplicationLifetimeDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060072AA RID: 29354 RVA: 0x000A4471 File Offset: 0x000A2671
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FApplicationLifetimeDelegate.StaticFunctionPtr();
		}

		// Token: 0x060072AB RID: 29355 RVA: 0x000A447D File Offset: 0x000A267D
		private static IntPtr StaticFunctionPtr()
		{
			if (UApplicationLifecycleComponent.__ApplicationLifetimeDelegate__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UApplicationLifecycleComponent.__ApplicationLifetimeDelegate__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ApplicationLifecycleComponent:ApplicationLifetimeDelegate__DelegateSignature");
			}
			return UApplicationLifecycleComponent.__ApplicationLifetimeDelegate__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x060072AC RID: 29356 RVA: 0x000A44A0 File Offset: 0x000A26A0
		public FApplicationLifetimeDelegate()
		{
		}

		// Token: 0x060072AD RID: 29357 RVA: 0x000A44A8 File Offset: 0x000A26A8
		[NullableContext(2)]
		public FApplicationLifetimeDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060072AE RID: 29358 RVA: 0x000A44B2 File Offset: 0x000A26B2
		public FApplicationLifetimeDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060072AF RID: 29359 RVA: 0x000A44BD File Offset: 0x000A26BD
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x060072B0 RID: 29360 RVA: 0x000A44EF File Offset: 0x000A26EF
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FApplicationLifetimeDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FApplicationLifetimeDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FApplicationLifetimeDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FApplicationLifetimeDelegate.OnScriptCallback));
				}
				FApplicationLifetimeDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FApplicationLifetimeDelegate.RegisterId);
		}

		// Token: 0x060072B1 RID: 29361 RVA: 0x000A4529 File Offset: 0x000A2729
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060072B2 RID: 29362 RVA: 0x000A4532 File Offset: 0x000A2732
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x060072B3 RID: 29363 RVA: 0x000A453C File Offset: 0x000A273C
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

		// Token: 0x04003720 RID: 14112
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ApplicationLifecycleComponent:ApplicationLifetimeDelegate__DelegateSignature";

		// Token: 0x04003721 RID: 14113
		private static int RegisterId;

		// Token: 0x02002C8C RID: 11404
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040165D1 RID: 91601
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
