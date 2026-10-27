using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x02001AE0 RID: 6880
	public sealed class FKuroDestructibleActorDelegateSignature : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06019A44 RID: 105028 RVA: 0x0025E491 File Offset: 0x0025C691
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroDestructibleActorDelegateSignature.StaticFunctionPtr();
		}

		// Token: 0x06019A45 RID: 105029 RVA: 0x0025E49D File Offset: 0x0025C69D
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroDestructibleActorDelegateSignature._FunctionPtr == IntPtr.Zero)
			{
				FKuroDestructibleActorDelegateSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroDestructibleActorDelegateSignature__DelegateSignature");
			}
			return FKuroDestructibleActorDelegateSignature._FunctionPtr;
		}

		// Token: 0x06019A46 RID: 105030 RVA: 0x0025E4C0 File Offset: 0x0025C6C0
		public FKuroDestructibleActorDelegateSignature()
		{
		}

		// Token: 0x06019A47 RID: 105031 RVA: 0x0025E4C8 File Offset: 0x0025C6C8
		[NullableContext(2)]
		public FKuroDestructibleActorDelegateSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06019A48 RID: 105032 RVA: 0x0025E4D2 File Offset: 0x0025C6D2
		public FKuroDestructibleActorDelegateSignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06019A49 RID: 105033 RVA: 0x0025E4DD File Offset: 0x0025C6DD
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06019A4A RID: 105034 RVA: 0x0025E50F File Offset: 0x0025C70F
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action Callback)
		{
			if (FKuroDestructibleActorDelegateSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FKuroDestructibleActorDelegateSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FKuroDestructibleActorDelegateSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FKuroDestructibleActorDelegateSignature.OnScriptCallback));
				}
				FKuroDestructibleActorDelegateSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FKuroDestructibleActorDelegateSignature.RegisterId);
		}

		// Token: 0x06019A4B RID: 105035 RVA: 0x0025E549 File Offset: 0x0025C749
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x06019A4C RID: 105036 RVA: 0x0025E554 File Offset: 0x0025C754
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

		// Token: 0x0400DF35 RID: 57141
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400DF36 RID: 57142
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroDestructibleActorDelegateSignature__DelegateSignature";

		// Token: 0x0400DF37 RID: 57143
		private static int RegisterId;

		// Token: 0x02003138 RID: 12600
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016F48 RID: 94024
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
