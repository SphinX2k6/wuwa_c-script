using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000D3D RID: 3389
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FLevelStreamingLoadedStatus : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600B5A6 RID: 46502 RVA: 0x00103252 File Offset: 0x00101452
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLevelStreamingLoadedStatus.StaticFunctionPtr();
		}

		// Token: 0x0600B5A7 RID: 46503 RVA: 0x0010325E File Offset: 0x0010145E
		private static IntPtr StaticFunctionPtr()
		{
			if (FLevelStreamingLoadedStatus._FunctionPtr == IntPtr.Zero)
			{
				FLevelStreamingLoadedStatus._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.LevelStreamingLoadedStatus__DelegateSignature");
			}
			return FLevelStreamingLoadedStatus._FunctionPtr;
		}

		// Token: 0x0600B5A8 RID: 46504 RVA: 0x00103281 File Offset: 0x00101481
		public FLevelStreamingLoadedStatus()
		{
		}

		// Token: 0x0600B5A9 RID: 46505 RVA: 0x00103289 File Offset: 0x00101489
		[NullableContext(2)]
		public FLevelStreamingLoadedStatus(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B5AA RID: 46506 RVA: 0x00103293 File Offset: 0x00101493
		public FLevelStreamingLoadedStatus(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B5AB RID: 46507 RVA: 0x0010329E File Offset: 0x0010149E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600B5AC RID: 46508 RVA: 0x001032D0 File Offset: 0x001014D0
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FLevelStreamingLoadedStatus.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLevelStreamingLoadedStatus.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLevelStreamingLoadedStatus.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLevelStreamingLoadedStatus.OnScriptCallback));
				}
				FLevelStreamingLoadedStatus.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FLevelStreamingLoadedStatus.RegisterId);
		}

		// Token: 0x0600B5AD RID: 46509 RVA: 0x0010330A File Offset: 0x0010150A
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600B5AE RID: 46510 RVA: 0x00103313 File Offset: 0x00101513
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0600B5AF RID: 46511 RVA: 0x00103320 File Offset: 0x00101520
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

		// Token: 0x04005F79 RID: 24441
		internal static IntPtr _FunctionPtr;

		// Token: 0x04005F7A RID: 24442
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.LevelStreamingLoadedStatus__DelegateSignature";

		// Token: 0x04005F7B RID: 24443
		private static int RegisterId;

		// Token: 0x02002D3E RID: 11582
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016742 RID: 91970
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
