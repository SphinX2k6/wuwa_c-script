using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C6A RID: 7274
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnJumpEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601C34E RID: 115534 RVA: 0x00299518 File Offset: 0x00297718
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnJumpEvent.StaticFunctionPtr();
		}

		// Token: 0x0601C34F RID: 115535 RVA: 0x00299524 File Offset: 0x00297724
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnJumpEvent._FunctionPtr == IntPtr.Zero)
			{
				FOnJumpEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroRhythmGame.OnJumpEvent__DelegateSignature");
			}
			return FOnJumpEvent._FunctionPtr;
		}

		// Token: 0x0601C350 RID: 115536 RVA: 0x00299547 File Offset: 0x00297747
		public FOnJumpEvent()
		{
		}

		// Token: 0x0601C351 RID: 115537 RVA: 0x0029954F File Offset: 0x0029774F
		[NullableContext(2)]
		public FOnJumpEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C352 RID: 115538 RVA: 0x00299559 File Offset: 0x00297759
		public FOnJumpEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C353 RID: 115539 RVA: 0x00299564 File Offset: 0x00297764
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<float>) ?? ((Action<float>)Delegate.CreateDelegate(typeof(Action<float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601C354 RID: 115540 RVA: 0x00299596 File Offset: 0x00297796
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<float> Callback)
		{
			if (FOnJumpEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnJumpEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnJumpEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnJumpEvent.OnScriptCallback));
				}
				FOnJumpEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnJumpEvent.RegisterId);
		}

		// Token: 0x0601C355 RID: 115541 RVA: 0x002995D0 File Offset: 0x002977D0
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<float> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601C356 RID: 115542 RVA: 0x002995DC File Offset: 0x002977DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(float BeatDurationMs)
		{
			FOnJumpEvent.__FOnJumpEvent_DelegateParams* ptr = stackalloc FOnJumpEvent.__FOnJumpEvent_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FOnJumpEvent.__FOnJumpEvent_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnJumpEvent.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->BeatDurationMs = BeatDurationMs;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601C357 RID: 115543 RVA: 0x00299618 File Offset: 0x00297818
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<float> action = target as Action<float>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnJumpEvent.__FOnJumpEvent_DelegateParams*)__Parameters)->BeatDurationMs);
		}

		// Token: 0x0400F2C2 RID: 62146
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400F2C3 RID: 62147
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRhythmGame.OnJumpEvent__DelegateSignature";

		// Token: 0x0400F2C4 RID: 62148
		private static int RegisterId;

		// Token: 0x02003202 RID: 12802
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FOnJumpEvent_DelegateParams
		{
			// Token: 0x04017060 RID: 94304
			[FieldOffset(0)]
			public float BeatDurationMs;
		}

		// Token: 0x02003203 RID: 12803
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017061 RID: 94305
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
