using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001C17 RID: 7191
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnEnterVolumeBlueprintEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601BBD3 RID: 113619 RVA: 0x0028D1A2 File Offset: 0x0028B3A2
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnEnterVolumeBlueprintEvent.StaticFunctionPtr();
		}

		// Token: 0x0601BBD4 RID: 113620 RVA: 0x0028D1AE File Offset: 0x0028B3AE
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnEnterVolumeBlueprintEvent._FunctionPtr == IntPtr.Zero)
			{
				FOnEnterVolumeBlueprintEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroRenderingRuntimeBPPlugin.OnEnterVolumeBlueprintEvent__DelegateSignature");
			}
			return FOnEnterVolumeBlueprintEvent._FunctionPtr;
		}

		// Token: 0x0601BBD5 RID: 113621 RVA: 0x0028D1D1 File Offset: 0x0028B3D1
		public FOnEnterVolumeBlueprintEvent()
		{
		}

		// Token: 0x0601BBD6 RID: 113622 RVA: 0x0028D1D9 File Offset: 0x0028B3D9
		[NullableContext(2)]
		public FOnEnterVolumeBlueprintEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601BBD7 RID: 113623 RVA: 0x0028D1E3 File Offset: 0x0028B3E3
		public FOnEnterVolumeBlueprintEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601BBD8 RID: 113624 RVA: 0x0028D1EE File Offset: 0x0028B3EE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601BBD9 RID: 113625 RVA: 0x0028D220 File Offset: 0x0028B420
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FOnEnterVolumeBlueprintEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnEnterVolumeBlueprintEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnEnterVolumeBlueprintEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnEnterVolumeBlueprintEvent.OnScriptCallback));
				}
				FOnEnterVolumeBlueprintEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnEnterVolumeBlueprintEvent.RegisterId);
		}

		// Token: 0x0601BBDA RID: 113626 RVA: 0x0028D25A File Offset: 0x0028B45A
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601BBDB RID: 113627 RVA: 0x0028D263 File Offset: 0x0028B463
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601BBDC RID: 113628 RVA: 0x0028D270 File Offset: 0x0028B470
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

		// Token: 0x0400EE96 RID: 61078
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400EE97 RID: 61079
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.OnEnterVolumeBlueprintEvent__DelegateSignature";

		// Token: 0x0400EE98 RID: 61080
		private static int RegisterId;

		// Token: 0x0200319B RID: 12699
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016FD9 RID: 94169
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
