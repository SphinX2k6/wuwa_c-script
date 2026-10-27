using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000F0E RID: 3854
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnGameUserSettingsUINeedsUpdate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600D07C RID: 53372 RVA: 0x00130825 File Offset: 0x0012EA25
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnGameUserSettingsUINeedsUpdate.StaticFunctionPtr();
		}

		// Token: 0x0600D07D RID: 53373 RVA: 0x00130831 File Offset: 0x0012EA31
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnGameUserSettingsUINeedsUpdate._FunctionPtr == IntPtr.Zero)
			{
				FOnGameUserSettingsUINeedsUpdate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.OnGameUserSettingsUINeedsUpdate__DelegateSignature");
			}
			return FOnGameUserSettingsUINeedsUpdate._FunctionPtr;
		}

		// Token: 0x0600D07E RID: 53374 RVA: 0x00130854 File Offset: 0x0012EA54
		public FOnGameUserSettingsUINeedsUpdate()
		{
		}

		// Token: 0x0600D07F RID: 53375 RVA: 0x0013085C File Offset: 0x0012EA5C
		[NullableContext(2)]
		public FOnGameUserSettingsUINeedsUpdate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600D080 RID: 53376 RVA: 0x00130866 File Offset: 0x0012EA66
		public FOnGameUserSettingsUINeedsUpdate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600D081 RID: 53377 RVA: 0x00130871 File Offset: 0x0012EA71
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600D082 RID: 53378 RVA: 0x001308A3 File Offset: 0x0012EAA3
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FOnGameUserSettingsUINeedsUpdate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnGameUserSettingsUINeedsUpdate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnGameUserSettingsUINeedsUpdate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnGameUserSettingsUINeedsUpdate.OnScriptCallback));
				}
				FOnGameUserSettingsUINeedsUpdate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnGameUserSettingsUINeedsUpdate.RegisterId);
		}

		// Token: 0x0600D083 RID: 53379 RVA: 0x001308DD File Offset: 0x0012EADD
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600D084 RID: 53380 RVA: 0x001308E6 File Offset: 0x0012EAE6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0600D085 RID: 53381 RVA: 0x001308F0 File Offset: 0x0012EAF0
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

		// Token: 0x0400703F RID: 28735
		internal static IntPtr _FunctionPtr;

		// Token: 0x04007040 RID: 28736
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.OnGameUserSettingsUINeedsUpdate__DelegateSignature";

		// Token: 0x04007041 RID: 28737
		private static int RegisterId;

		// Token: 0x02002D6C RID: 11628
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016786 RID: 92038
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
