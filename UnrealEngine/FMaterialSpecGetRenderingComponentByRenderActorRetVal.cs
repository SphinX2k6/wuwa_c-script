using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001920 RID: 6432
	public sealed class FMaterialSpecGetRenderingComponentByRenderActorRetVal : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06017DC9 RID: 97737 RVA: 0x0022F3F3 File Offset: 0x0022D5F3
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FMaterialSpecGetRenderingComponentByRenderActorRetVal.StaticFunctionPtr();
		}

		// Token: 0x06017DCA RID: 97738 RVA: 0x0022F3FF File Offset: 0x0022D5FF
		private static IntPtr StaticFunctionPtr()
		{
			if (FMaterialSpecGetRenderingComponentByRenderActorRetVal._FunctionPtr == IntPtr.Zero)
			{
				FMaterialSpecGetRenderingComponentByRenderActorRetVal._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.MaterialSpecGetRenderingComponentByRenderActorRetVal__DelegateSignature");
			}
			return FMaterialSpecGetRenderingComponentByRenderActorRetVal._FunctionPtr;
		}

		// Token: 0x06017DCB RID: 97739 RVA: 0x0022F422 File Offset: 0x0022D622
		public FMaterialSpecGetRenderingComponentByRenderActorRetVal()
		{
		}

		// Token: 0x06017DCC RID: 97740 RVA: 0x0022F42A File Offset: 0x0022D62A
		[NullableContext(2)]
		public FMaterialSpecGetRenderingComponentByRenderActorRetVal(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06017DCD RID: 97741 RVA: 0x0022F434 File Offset: 0x0022D634
		public FMaterialSpecGetRenderingComponentByRenderActorRetVal(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06017DCE RID: 97742 RVA: 0x0022F43F File Offset: 0x0022D63F
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<AActor, USkeletalMeshComponent, UKuroCharRenderingComponent>) ?? ((Func<AActor, USkeletalMeshComponent, UKuroCharRenderingComponent>)Delegate.CreateDelegate(typeof(Func<AActor, USkeletalMeshComponent, UKuroCharRenderingComponent>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06017DCF RID: 97743 RVA: 0x0022F471 File Offset: 0x0022D671
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind([Nullable(new byte[]
		{
			1,
			2,
			2,
			2
		})] Func<AActor, USkeletalMeshComponent, UKuroCharRenderingComponent> Callback)
		{
			if (FMaterialSpecGetRenderingComponentByRenderActorRetVal.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FMaterialSpecGetRenderingComponentByRenderActorRetVal.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FMaterialSpecGetRenderingComponentByRenderActorRetVal.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FMaterialSpecGetRenderingComponentByRenderActorRetVal.OnScriptCallback));
				}
				FMaterialSpecGetRenderingComponentByRenderActorRetVal.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FMaterialSpecGetRenderingComponentByRenderActorRetVal.RegisterId);
		}

		// Token: 0x06017DD0 RID: 97744 RVA: 0x0022F4AC File Offset: 0x0022D6AC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe UKuroCharRenderingComponent Execute(AActor Actor, USkeletalMeshComponent SkeletalMeshComponent)
		{
			FMaterialSpecGetRenderingComponentByRenderActorRetVal.__FMaterialSpecGetRenderingComponentByRenderActorRetVal_DelegateParams* ptr = stackalloc FMaterialSpecGetRenderingComponentByRenderActorRetVal.__FMaterialSpecGetRenderingComponentByRenderActorRetVal_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FMaterialSpecGetRenderingComponentByRenderActorRetVal.__FMaterialSpecGetRenderingComponentByRenderActorRetVal_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FMaterialSpecGetRenderingComponentByRenderActorRetVal.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Actor = ((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
			ptr->SkeletalMeshComponent = ((SkeletalMeshComponent != null) ? SkeletalMeshComponent.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroCharRenderingComponent>(ptr->__Result);
		}

		// Token: 0x06017DD1 RID: 97745 RVA: 0x0022F51C File Offset: 0x0022D71C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Func<AActor, USkeletalMeshComponent, UKuroCharRenderingComponent> func = target as Func<AActor, USkeletalMeshComponent, UKuroCharRenderingComponent>;
			if (func == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FMaterialSpecGetRenderingComponentByRenderActorRetVal.__FMaterialSpecGetRenderingComponentByRenderActorRetVal_DelegateParams*)__Parameters)->Actor);
			USkeletalMeshComponent orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(((FMaterialSpecGetRenderingComponentByRenderActorRetVal.__FMaterialSpecGetRenderingComponentByRenderActorRetVal_DelegateParams*)__Parameters)->SkeletalMeshComponent);
			UKuroCharRenderingComponent ukuroCharRenderingComponent = func(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
			((FMaterialSpecGetRenderingComponentByRenderActorRetVal.__FMaterialSpecGetRenderingComponentByRenderActorRetVal_DelegateParams*)__Parameters)->__Result = ((ukuroCharRenderingComponent != null) ? ukuroCharRenderingComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0400CED1 RID: 52945
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400CED2 RID: 52946
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.MaterialSpecGetRenderingComponentByRenderActorRetVal__DelegateSignature";

		// Token: 0x0400CED3 RID: 52947
		private static int RegisterId;

		// Token: 0x02002FE9 RID: 12265
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FMaterialSpecGetRenderingComponentByRenderActorRetVal_DelegateParams
		{
			// Token: 0x04016BE7 RID: 93159
			[FieldOffset(0)]
			public IntPtr Actor;

			// Token: 0x04016BE8 RID: 93160
			[FieldOffset(8)]
			public IntPtr SkeletalMeshComponent;

			// Token: 0x04016BE9 RID: 93161
			[FieldOffset(16)]
			public IntPtr __Result;
		}

		// Token: 0x02002FEA RID: 12266
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016BEA RID: 93162
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
