using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200193B RID: 6459
	public sealed class FSkeletalMeshSpecDestroyRenderingComponent : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06017F2C RID: 98092 RVA: 0x00231748 File Offset: 0x0022F948
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSkeletalMeshSpecDestroyRenderingComponent.StaticFunctionPtr();
		}

		// Token: 0x06017F2D RID: 98093 RVA: 0x00231754 File Offset: 0x0022F954
		private static IntPtr StaticFunctionPtr()
		{
			if (FSkeletalMeshSpecDestroyRenderingComponent._FunctionPtr == IntPtr.Zero)
			{
				FSkeletalMeshSpecDestroyRenderingComponent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.SkeletalMeshSpecDestroyRenderingComponent__DelegateSignature");
			}
			return FSkeletalMeshSpecDestroyRenderingComponent._FunctionPtr;
		}

		// Token: 0x06017F2E RID: 98094 RVA: 0x00231777 File Offset: 0x0022F977
		public FSkeletalMeshSpecDestroyRenderingComponent()
		{
		}

		// Token: 0x06017F2F RID: 98095 RVA: 0x0023177F File Offset: 0x0022F97F
		[NullableContext(2)]
		public FSkeletalMeshSpecDestroyRenderingComponent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06017F30 RID: 98096 RVA: 0x00231789 File Offset: 0x0022F989
		public FSkeletalMeshSpecDestroyRenderingComponent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06017F31 RID: 98097 RVA: 0x00231794 File Offset: 0x0022F994
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<AActor, UActorComponent>) ?? ((Action<AActor, UActorComponent>)Delegate.CreateDelegate(typeof(Action<AActor, UActorComponent>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06017F32 RID: 98098 RVA: 0x002317C6 File Offset: 0x0022F9C6
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind([Nullable(new byte[]
		{
			1,
			2,
			2
		})] Action<AActor, UActorComponent> Callback)
		{
			if (FSkeletalMeshSpecDestroyRenderingComponent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSkeletalMeshSpecDestroyRenderingComponent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSkeletalMeshSpecDestroyRenderingComponent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSkeletalMeshSpecDestroyRenderingComponent.OnScriptCallback));
				}
				FSkeletalMeshSpecDestroyRenderingComponent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FSkeletalMeshSpecDestroyRenderingComponent.RegisterId);
		}

		// Token: 0x06017F33 RID: 98099 RVA: 0x00231800 File Offset: 0x0022FA00
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(AActor EffectActor, UActorComponent CharRenderingComponent)
		{
			FSkeletalMeshSpecDestroyRenderingComponent.__FSkeletalMeshSpecDestroyRenderingComponent_DelegateParams* ptr = stackalloc FSkeletalMeshSpecDestroyRenderingComponent.__FSkeletalMeshSpecDestroyRenderingComponent_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FSkeletalMeshSpecDestroyRenderingComponent.__FSkeletalMeshSpecDestroyRenderingComponent_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSkeletalMeshSpecDestroyRenderingComponent.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->EffectActor = ((EffectActor != null) ? EffectActor.NativePtr : IntPtr.Zero);
			ptr->CharRenderingComponent = ((CharRenderingComponent != null) ? CharRenderingComponent.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06017F34 RID: 98100 RVA: 0x00231864 File Offset: 0x0022FA64
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<AActor, UActorComponent> action = target as Action<AActor, UActorComponent>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FSkeletalMeshSpecDestroyRenderingComponent.__FSkeletalMeshSpecDestroyRenderingComponent_DelegateParams*)__Parameters)->EffectActor);
			UActorComponent orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UActorComponent>(((FSkeletalMeshSpecDestroyRenderingComponent.__FSkeletalMeshSpecDestroyRenderingComponent_DelegateParams*)__Parameters)->CharRenderingComponent);
			action(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
		}

		// Token: 0x0400CF5A RID: 53082
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400CF5B RID: 53083
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.SkeletalMeshSpecDestroyRenderingComponent__DelegateSignature";

		// Token: 0x0400CF5C RID: 53084
		private static int RegisterId;

		// Token: 0x02002FFF RID: 12287
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FSkeletalMeshSpecDestroyRenderingComponent_DelegateParams
		{
			// Token: 0x04016C0F RID: 93199
			[FieldOffset(0)]
			public IntPtr EffectActor;

			// Token: 0x04016C10 RID: 93200
			[FieldOffset(8)]
			public IntPtr CharRenderingComponent;
		}

		// Token: 0x02003000 RID: 12288
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016C11 RID: 93201
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
