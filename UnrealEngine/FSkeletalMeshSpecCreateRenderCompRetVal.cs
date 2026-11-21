using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200041C RID: 1052
	public sealed class FSkeletalMeshSpecCreateRenderCompRetVal : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060065D7 RID: 26071 RVA: 0x00091D13 File Offset: 0x0008FF13
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSkeletalMeshSpecCreateRenderCompRetVal.StaticFunctionPtr();
		}

		// Token: 0x060065D8 RID: 26072 RVA: 0x00091D1F File Offset: 0x0008FF1F
		private static IntPtr StaticFunctionPtr()
		{
			if (FSkeletalMeshSpecCreateRenderCompRetVal._FunctionPtr == IntPtr.Zero)
			{
				FSkeletalMeshSpecCreateRenderCompRetVal._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.SkeletalMeshSpecCreateRenderCompRetVal__DelegateSignature");
			}
			return FSkeletalMeshSpecCreateRenderCompRetVal._FunctionPtr;
		}

		// Token: 0x060065D9 RID: 26073 RVA: 0x00091D42 File Offset: 0x0008FF42
		public FSkeletalMeshSpecCreateRenderCompRetVal()
		{
		}

		// Token: 0x060065DA RID: 26074 RVA: 0x00091D4A File Offset: 0x0008FF4A
		[NullableContext(2)]
		public FSkeletalMeshSpecCreateRenderCompRetVal(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060065DB RID: 26075 RVA: 0x00091D54 File Offset: 0x0008FF54
		public FSkeletalMeshSpecCreateRenderCompRetVal(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060065DC RID: 26076 RVA: 0x00091D5F File Offset: 0x0008FF5F
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<UActorComponent, USkeletalMeshComponent, AActor, UActorComponent>) ?? ((Func<UActorComponent, USkeletalMeshComponent, AActor, UActorComponent>)Delegate.CreateDelegate(typeof(Func<UActorComponent, USkeletalMeshComponent, AActor, UActorComponent>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060065DD RID: 26077 RVA: 0x00091D91 File Offset: 0x0008FF91
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

		// Token: 0x060065DE RID: 26078 RVA: 0x00091DCC File Offset: 0x0008FFCC
		[NullableContext(2)]
		[SkipLocalsInit]
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

		// Token: 0x060065DF RID: 26079 RVA: 0x00091E50 File Offset: 0x00090050
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04002AD8 RID: 10968
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002AD9 RID: 10969
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.SkeletalMeshSpecCreateRenderCompRetVal__DelegateSignature";

		// Token: 0x04002ADA RID: 10970
		private static int RegisterId;

		// Token: 0x02000B11 RID: 2833
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		private ref struct __FSkeletalMeshSpecCreateRenderCompRetVal_DelegateParams
		{
			// Token: 0x04005BB3 RID: 23475
			[FieldOffset(0)]
			public IntPtr CharRenderingComponent;

			// Token: 0x04005BB4 RID: 23476
			[FieldOffset(8)]
			public IntPtr SkeletalMeshComponent;

			// Token: 0x04005BB5 RID: 23477
			[FieldOffset(16)]
			public IntPtr Owner;

			// Token: 0x04005BB6 RID: 23478
			[FieldOffset(24)]
			public IntPtr __Result;
		}

		// Token: 0x02000B12 RID: 2834
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005BB7 RID: 23479
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
