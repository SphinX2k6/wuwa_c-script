using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001C1B RID: 7195
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnLeaveVolumeBlueprintEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601BBF9 RID: 113657 RVA: 0x0028D6A4 File Offset: 0x0028B8A4
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnLeaveVolumeBlueprintEvent.StaticFunctionPtr();
		}

		// Token: 0x0601BBFA RID: 113658 RVA: 0x0028D6B0 File Offset: 0x0028B8B0
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnLeaveVolumeBlueprintEvent._FunctionPtr == IntPtr.Zero)
			{
				FOnLeaveVolumeBlueprintEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroRenderingRuntimeBPPlugin.OnLeaveVolumeBlueprintEvent__DelegateSignature");
			}
			return FOnLeaveVolumeBlueprintEvent._FunctionPtr;
		}

		// Token: 0x0601BBFB RID: 113659 RVA: 0x0028D6D3 File Offset: 0x0028B8D3
		public FOnLeaveVolumeBlueprintEvent()
		{
		}

		// Token: 0x0601BBFC RID: 113660 RVA: 0x0028D6DB File Offset: 0x0028B8DB
		[NullableContext(2)]
		public FOnLeaveVolumeBlueprintEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601BBFD RID: 113661 RVA: 0x0028D6E5 File Offset: 0x0028B8E5
		public FOnLeaveVolumeBlueprintEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601BBFE RID: 113662 RVA: 0x0028D6F0 File Offset: 0x0028B8F0
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601BBFF RID: 113663 RVA: 0x0028D722 File Offset: 0x0028B922
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (FOnLeaveVolumeBlueprintEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnLeaveVolumeBlueprintEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnLeaveVolumeBlueprintEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnLeaveVolumeBlueprintEvent.OnScriptCallback));
				}
				FOnLeaveVolumeBlueprintEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnLeaveVolumeBlueprintEvent.RegisterId);
		}

		// Token: 0x0601BC00 RID: 113664 RVA: 0x0028D75C File Offset: 0x0028B95C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601BC01 RID: 113665 RVA: 0x0028D765 File Offset: 0x0028B965
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601BC02 RID: 113666 RVA: 0x0028D770 File Offset: 0x0028B970
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

		// Token: 0x0400EEA0 RID: 61088
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400EEA1 RID: 61089
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.OnLeaveVolumeBlueprintEvent__DelegateSignature";

		// Token: 0x0400EEA2 RID: 61090
		private static int RegisterId;

		// Token: 0x020031A2 RID: 12706
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016FE1 RID: 94177
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
