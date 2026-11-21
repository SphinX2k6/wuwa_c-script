using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200041D RID: 1053
	public sealed class FSkeletalMeshSpecDestroyRenderingComponent : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060065E0 RID: 26080 RVA: 0x00091ED8 File Offset: 0x000900D8
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSkeletalMeshSpecDestroyRenderingComponent.StaticFunctionPtr();
		}

		// Token: 0x060065E1 RID: 26081 RVA: 0x00091EE4 File Offset: 0x000900E4
		private static IntPtr StaticFunctionPtr()
		{
			if (FSkeletalMeshSpecDestroyRenderingComponent._FunctionPtr == IntPtr.Zero)
			{
				FSkeletalMeshSpecDestroyRenderingComponent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.SkeletalMeshSpecDestroyRenderingComponent__DelegateSignature");
			}
			return FSkeletalMeshSpecDestroyRenderingComponent._FunctionPtr;
		}

		// Token: 0x060065E2 RID: 26082 RVA: 0x00091F07 File Offset: 0x00090107
		public FSkeletalMeshSpecDestroyRenderingComponent()
		{
		}

		// Token: 0x060065E3 RID: 26083 RVA: 0x00091F0F File Offset: 0x0009010F
		[NullableContext(2)]
		public FSkeletalMeshSpecDestroyRenderingComponent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060065E4 RID: 26084 RVA: 0x00091F19 File Offset: 0x00090119
		public FSkeletalMeshSpecDestroyRenderingComponent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060065E5 RID: 26085 RVA: 0x00091F24 File Offset: 0x00090124
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<AActor, UActorComponent>) ?? ((Action<AActor, UActorComponent>)Delegate.CreateDelegate(typeof(Action<AActor, UActorComponent>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060065E6 RID: 26086 RVA: 0x00091F56 File Offset: 0x00090156
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

		// Token: 0x060065E7 RID: 26087 RVA: 0x00091F90 File Offset: 0x00090190
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Execute(AActor EffectActor, UActorComponent CharRenderingComponent)
		{
			FSkeletalMeshSpecDestroyRenderingComponent.__FSkeletalMeshSpecDestroyRenderingComponent_DelegateParams* ptr = stackalloc FSkeletalMeshSpecDestroyRenderingComponent.__FSkeletalMeshSpecDestroyRenderingComponent_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FSkeletalMeshSpecDestroyRenderingComponent.__FSkeletalMeshSpecDestroyRenderingComponent_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSkeletalMeshSpecDestroyRenderingComponent.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->EffectActor = ((EffectActor != null) ? EffectActor.NativePtr : IntPtr.Zero);
			ptr->CharRenderingComponent = ((CharRenderingComponent != null) ? CharRenderingComponent.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x060065E8 RID: 26088 RVA: 0x00091FF4 File Offset: 0x000901F4
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04002ADB RID: 10971
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002ADC RID: 10972
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.SkeletalMeshSpecDestroyRenderingComponent__DelegateSignature";

		// Token: 0x04002ADD RID: 10973
		private static int RegisterId;

		// Token: 0x02000B13 RID: 2835
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FSkeletalMeshSpecDestroyRenderingComponent_DelegateParams
		{
			// Token: 0x04005BB8 RID: 23480
			[FieldOffset(0)]
			public IntPtr EffectActor;

			// Token: 0x04005BB9 RID: 23481
			[FieldOffset(8)]
			public IntPtr CharRenderingComponent;
		}

		// Token: 0x02000B14 RID: 2836
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005BBA RID: 23482
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
