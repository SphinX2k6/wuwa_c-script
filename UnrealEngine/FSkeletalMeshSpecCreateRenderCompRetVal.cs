using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200193A RID: 6458
	public sealed class FSkeletalMeshSpecCreateRenderCompRetVal : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06017F23 RID: 98083 RVA: 0x00231581 File Offset: 0x0022F781
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSkeletalMeshSpecCreateRenderCompRetVal.StaticFunctionPtr();
		}

		// Token: 0x06017F24 RID: 98084 RVA: 0x0023158D File Offset: 0x0022F78D
		private static IntPtr StaticFunctionPtr()
		{
			if (FSkeletalMeshSpecCreateRenderCompRetVal._FunctionPtr == IntPtr.Zero)
			{
				FSkeletalMeshSpecCreateRenderCompRetVal._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.SkeletalMeshSpecCreateRenderCompRetVal__DelegateSignature");
			}
			return FSkeletalMeshSpecCreateRenderCompRetVal._FunctionPtr;
		}

		// Token: 0x06017F25 RID: 98085 RVA: 0x002315B0 File Offset: 0x0022F7B0
		public FSkeletalMeshSpecCreateRenderCompRetVal()
		{
		}

		// Token: 0x06017F26 RID: 98086 RVA: 0x002315B8 File Offset: 0x0022F7B8
		[NullableContext(2)]
		public FSkeletalMeshSpecCreateRenderCompRetVal(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06017F27 RID: 98087 RVA: 0x002315C2 File Offset: 0x0022F7C2
		public FSkeletalMeshSpecCreateRenderCompRetVal(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06017F28 RID: 98088 RVA: 0x002315CD File Offset: 0x0022F7CD
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<UActorComponent, USkeletalMeshComponent, AActor, UActorComponent>) ?? ((Func<UActorComponent, USkeletalMeshComponent, AActor, UActorComponent>)Delegate.CreateDelegate(typeof(Func<UActorComponent, USkeletalMeshComponent, AActor, UActorComponent>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06017F29 RID: 98089 RVA: 0x002315FF File Offset: 0x0022F7FF
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind([Nullable(new byte[]
		{
			1,
			2,
			2,
			2,
			2
		})] Func<UActorComponent, USkeletalMeshComponent, AActor, UActorComponent> Callback)
		{
			if (FSkeletalMeshSpecCreateRenderCompRetVal.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSkeletalMeshSpecCreateRenderCompRetVal.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSkeletalMeshSpecCreateRenderCompRetVal.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSkeletalMeshSpecCreateRenderCompRetVal.OnScriptCallback));
				}
				FSkeletalMeshSpecCreateRenderCompRetVal.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FSkeletalMeshSpecCreateRenderCompRetVal.RegisterId);
		}

		// Token: 0x06017F2A RID: 98090 RVA: 0x0023163C File Offset: 0x0022F83C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe UActorComponent Execute(UActorComponent CharRenderingComponent, USkeletalMeshComponent SkeletalMeshComponent, AActor Owner)
		{
			FSkeletalMeshSpecCreateRenderCompRetVal.__FSkeletalMeshSpecCreateRenderCompRetVal_DelegateParams* ptr = stackalloc FSkeletalMeshSpecCreateRenderCompRetVal.__FSkeletalMeshSpecCreateRenderCompRetVal_DelegateParams[(UIntPtr)47] + 15L / (long)sizeof(FSkeletalMeshSpecCreateRenderCompRetVal.__FSkeletalMeshSpecCreateRenderCompRetVal_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSkeletalMeshSpecCreateRenderCompRetVal.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->CharRenderingComponent = ((CharRenderingComponent != null) ? CharRenderingComponent.NativePtr : IntPtr.Zero);
			ptr->SkeletalMeshComponent = ((SkeletalMeshComponent != null) ? SkeletalMeshComponent.NativePtr : IntPtr.Zero);
			ptr->Owner = ((Owner != null) ? Owner.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UActorComponent>(ptr->__Result);
		}

		// Token: 0x06017F2B RID: 98091 RVA: 0x002316C0 File Offset: 0x0022F8C0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Func<UActorComponent, USkeletalMeshComponent, AActor, UActorComponent> func = target as Func<UActorComponent, USkeletalMeshComponent, AActor, UActorComponent>;
			if (func == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UActorComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UActorComponent>(((FSkeletalMeshSpecCreateRenderCompRetVal.__FSkeletalMeshSpecCreateRenderCompRetVal_DelegateParams*)__Parameters)->CharRenderingComponent);
			USkeletalMeshComponent orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(((FSkeletalMeshSpecCreateRenderCompRetVal.__FSkeletalMeshSpecCreateRenderCompRetVal_DelegateParams*)__Parameters)->SkeletalMeshComponent);
			AActor orCreateUObjectByNativePointer3 = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FSkeletalMeshSpecCreateRenderCompRetVal.__FSkeletalMeshSpecCreateRenderCompRetVal_DelegateParams*)__Parameters)->Owner);
			UActorComponent uactorComponent = func(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, orCreateUObjectByNativePointer3);
			((FSkeletalMeshSpecCreateRenderCompRetVal.__FSkeletalMeshSpecCreateRenderCompRetVal_DelegateParams*)__Parameters)->__Result = ((uactorComponent != null) ? uactorComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0400CF57 RID: 53079
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400CF58 RID: 53080
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.SkeletalMeshSpecCreateRenderCompRetVal__DelegateSignature";

		// Token: 0x0400CF59 RID: 53081
		private static int RegisterId;

		// Token: 0x02002FFD RID: 12285
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __FSkeletalMeshSpecCreateRenderCompRetVal_DelegateParams
		{
			// Token: 0x04016C0A RID: 93194
			[FieldOffset(0)]
			public IntPtr CharRenderingComponent;

			// Token: 0x04016C0B RID: 93195
			[FieldOffset(8)]
			public IntPtr SkeletalMeshComponent;

			// Token: 0x04016C0C RID: 93196
			[FieldOffset(16)]
			public IntPtr Owner;

			// Token: 0x04016C0D RID: 93197
			[FieldOffset(24)]
			public IntPtr __Result;
		}

		// Token: 0x02002FFE RID: 12286
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016C0E RID: 93198
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
