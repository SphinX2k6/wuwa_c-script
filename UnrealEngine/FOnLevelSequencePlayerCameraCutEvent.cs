using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000644 RID: 1604
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnLevelSequencePlayerCameraCutEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06008D34 RID: 36148 RVA: 0x000D4607 File Offset: 0x000D2807
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnLevelSequencePlayerCameraCutEvent.StaticFunctionPtr();
		}

		// Token: 0x06008D35 RID: 36149 RVA: 0x000D4613 File Offset: 0x000D2813
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnLevelSequencePlayerCameraCutEvent._FunctionPtr == IntPtr.Zero)
			{
				FOnLevelSequencePlayerCameraCutEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LevelSequence.OnLevelSequencePlayerCameraCutEvent__DelegateSignature");
			}
			return FOnLevelSequencePlayerCameraCutEvent._FunctionPtr;
		}

		// Token: 0x06008D36 RID: 36150 RVA: 0x000D4636 File Offset: 0x000D2836
		public FOnLevelSequencePlayerCameraCutEvent()
		{
		}

		// Token: 0x06008D37 RID: 36151 RVA: 0x000D463E File Offset: 0x000D283E
		[NullableContext(2)]
		public FOnLevelSequencePlayerCameraCutEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008D38 RID: 36152 RVA: 0x000D4648 File Offset: 0x000D2848
		public FOnLevelSequencePlayerCameraCutEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008D39 RID: 36153 RVA: 0x000D4653 File Offset: 0x000D2853
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UCameraComponent>) ?? ((Action<UCameraComponent>)Delegate.CreateDelegate(typeof(Action<UCameraComponent>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06008D3A RID: 36154 RVA: 0x000D4685 File Offset: 0x000D2885
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

		// Token: 0x06008D3B RID: 36155 RVA: 0x000D46BF File Offset: 0x000D28BF
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UCameraComponent> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06008D3C RID: 36156 RVA: 0x000D46C8 File Offset: 0x000D28C8
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(UCameraComponent CameraComponent)
		{
			FOnLevelSequencePlayerCameraCutEvent.__FOnLevelSequencePlayerCameraCutEvent_DelegateParams* ptr = stackalloc FOnLevelSequencePlayerCameraCutEvent.__FOnLevelSequencePlayerCameraCutEvent_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnLevelSequencePlayerCameraCutEvent.__FOnLevelSequencePlayerCameraCutEvent_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnLevelSequencePlayerCameraCutEvent.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->CameraComponent = ((CameraComponent != null) ? CameraComponent.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06008D3D RID: 36157 RVA: 0x000D4714 File Offset: 0x000D2914
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04003D77 RID: 15735
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003D78 RID: 15736
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LevelSequence.OnLevelSequencePlayerCameraCutEvent__DelegateSignature";

		// Token: 0x04003D79 RID: 15737
		private static int RegisterId;

		// Token: 0x02000E62 RID: 3682
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FOnLevelSequencePlayerCameraCutEvent_DelegateParams
		{
			// Token: 0x04006207 RID: 25095
			[FieldOffset(0)]
			public IntPtr CameraComponent;
		}

		// Token: 0x02000E63 RID: 3683
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006208 RID: 25096
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
