using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001FC3 RID: 8131
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnLevelSequencePlayerCameraCutEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601EDB2 RID: 126386 RVA: 0x002DDB08 File Offset: 0x002DBD08
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnLevelSequencePlayerCameraCutEvent.StaticFunctionPtr();
		}

		// Token: 0x0601EDB3 RID: 126387 RVA: 0x002DDB14 File Offset: 0x002DBD14
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnLevelSequencePlayerCameraCutEvent._FunctionPtr == IntPtr.Zero)
			{
				FOnLevelSequencePlayerCameraCutEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LevelSequence.OnLevelSequencePlayerCameraCutEvent__DelegateSignature");
			}
			return FOnLevelSequencePlayerCameraCutEvent._FunctionPtr;
		}

		// Token: 0x0601EDB4 RID: 126388 RVA: 0x002DDB37 File Offset: 0x002DBD37
		public FOnLevelSequencePlayerCameraCutEvent()
		{
		}

		// Token: 0x0601EDB5 RID: 126389 RVA: 0x002DDB3F File Offset: 0x002DBD3F
		[NullableContext(2)]
		public FOnLevelSequencePlayerCameraCutEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601EDB6 RID: 126390 RVA: 0x002DDB49 File Offset: 0x002DBD49
		public FOnLevelSequencePlayerCameraCutEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601EDB7 RID: 126391 RVA: 0x002DDB54 File Offset: 0x002DBD54
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UCameraComponent>) ?? ((Action<UCameraComponent>)Delegate.CreateDelegate(typeof(Action<UCameraComponent>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601EDB8 RID: 126392 RVA: 0x002DDB86 File Offset: 0x002DBD86
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<UCameraComponent> Callback)
		{
			if (FOnLevelSequencePlayerCameraCutEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnLevelSequencePlayerCameraCutEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnLevelSequencePlayerCameraCutEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnLevelSequencePlayerCameraCutEvent.OnScriptCallback));
				}
				FOnLevelSequencePlayerCameraCutEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnLevelSequencePlayerCameraCutEvent.RegisterId);
		}

		// Token: 0x0601EDB9 RID: 126393 RVA: 0x002DDBC0 File Offset: 0x002DBDC0
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UCameraComponent> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601EDBA RID: 126394 RVA: 0x002DDBCC File Offset: 0x002DBDCC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UCameraComponent CameraComponent)
		{
			FOnLevelSequencePlayerCameraCutEvent.__FOnLevelSequencePlayerCameraCutEvent_DelegateParams* ptr = stackalloc FOnLevelSequencePlayerCameraCutEvent.__FOnLevelSequencePlayerCameraCutEvent_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnLevelSequencePlayerCameraCutEvent.__FOnLevelSequencePlayerCameraCutEvent_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnLevelSequencePlayerCameraCutEvent.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->CameraComponent = ((CameraComponent != null) ? CameraComponent.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601EDBB RID: 126395 RVA: 0x002DDC18 File Offset: 0x002DBE18
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UCameraComponent> action = target as Action<UCameraComponent>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UCameraComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UCameraComponent>(((FOnLevelSequencePlayerCameraCutEvent.__FOnLevelSequencePlayerCameraCutEvent_DelegateParams*)__Parameters)->CameraComponent);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x04010AC2 RID: 68290
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010AC3 RID: 68291
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LevelSequence.OnLevelSequencePlayerCameraCutEvent__DelegateSignature";

		// Token: 0x04010AC4 RID: 68292
		private static int RegisterId;

		// Token: 0x0200341F RID: 13343
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FOnLevelSequencePlayerCameraCutEvent_DelegateParams
		{
			// Token: 0x040173F8 RID: 95224
			[FieldOffset(0)]
			public IntPtr CameraComponent;
		}

		// Token: 0x02003420 RID: 13344
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040173F9 RID: 95225
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
