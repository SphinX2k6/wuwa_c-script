using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x020004BE RID: 1214
	public sealed class FKuroDestructibleActorDelegateSignature : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06006FE4 RID: 28644 RVA: 0x000A55B1 File Offset: 0x000A37B1
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroDestructibleActorDelegateSignature.StaticFunctionPtr();
		}

		// Token: 0x06006FE5 RID: 28645 RVA: 0x000A55BD File Offset: 0x000A37BD
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroDestructibleActorDelegateSignature._FunctionPtr == IntPtr.Zero)
			{
				FKuroDestructibleActorDelegateSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroDestructibleActorDelegateSignature__DelegateSignature");
			}
			return FKuroDestructibleActorDelegateSignature._FunctionPtr;
		}

		// Token: 0x06006FE6 RID: 28646 RVA: 0x000A55E0 File Offset: 0x000A37E0
		public FKuroDestructibleActorDelegateSignature()
		{
		}

		// Token: 0x06006FE7 RID: 28647 RVA: 0x000A55E8 File Offset: 0x000A37E8
		[NullableContext(2)]
		public FKuroDestructibleActorDelegateSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006FE8 RID: 28648 RVA: 0x000A55F2 File Offset: 0x000A37F2
		public FKuroDestructibleActorDelegateSignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006FE9 RID: 28649 RVA: 0x000A55FD File Offset: 0x000A37FD
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06006FEA RID: 28650 RVA: 0x000A562F File Offset: 0x000A382F
		[NullableContext(1)]
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

		// Token: 0x06006FEB RID: 28651 RVA: 0x000A5669 File Offset: 0x000A3869
		[SkipLocalsInit]
		public void Execute()
		{
			base.ExecuteInternal(null);
		}

		// Token: 0x06006FEC RID: 28652 RVA: 0x000A5674 File Offset: 0x000A3874
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action action = target as Action;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action();
		}

		// Token: 0x0400304F RID: 12367
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003050 RID: 12368
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroDestructibleActorDelegateSignature__DelegateSignature";

		// Token: 0x04003051 RID: 12369
		private static int RegisterId;

		// Token: 0x02000C06 RID: 3078
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005E3B RID: 24123
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
