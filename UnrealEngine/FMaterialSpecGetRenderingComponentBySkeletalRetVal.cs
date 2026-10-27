using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001921 RID: 6433
	public sealed class FMaterialSpecGetRenderingComponentBySkeletalRetVal : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06017DD2 RID: 97746 RVA: 0x0022F595 File Offset: 0x0022D795
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FMaterialSpecGetRenderingComponentBySkeletalRetVal.StaticFunctionPtr();
		}

		// Token: 0x06017DD3 RID: 97747 RVA: 0x0022F5A1 File Offset: 0x0022D7A1
		private static IntPtr StaticFunctionPtr()
		{
			if (FMaterialSpecGetRenderingComponentBySkeletalRetVal._FunctionPtr == IntPtr.Zero)
			{
				FMaterialSpecGetRenderingComponentBySkeletalRetVal._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.MaterialSpecGetRenderingComponentBySkeletalRetVal__DelegateSignature");
			}
			return FMaterialSpecGetRenderingComponentBySkeletalRetVal._FunctionPtr;
		}

		// Token: 0x06017DD4 RID: 97748 RVA: 0x0022F5C4 File Offset: 0x0022D7C4
		public FMaterialSpecGetRenderingComponentBySkeletalRetVal()
		{
		}

		// Token: 0x06017DD5 RID: 97749 RVA: 0x0022F5CC File Offset: 0x0022D7CC
		[NullableContext(2)]
		public FMaterialSpecGetRenderingComponentBySkeletalRetVal(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06017DD6 RID: 97750 RVA: 0x0022F5D6 File Offset: 0x0022D7D6
		public FMaterialSpecGetRenderingComponentBySkeletalRetVal(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06017DD7 RID: 97751 RVA: 0x0022F5E1 File Offset: 0x0022D7E1
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<USkeletalMeshComponent, UKuroCharRenderingComponent>) ?? ((Func<USkeletalMeshComponent, UKuroCharRenderingComponent>)Delegate.CreateDelegate(typeof(Func<USkeletalMeshComponent, UKuroCharRenderingComponent>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06017DD8 RID: 97752 RVA: 0x0022F613 File Offset: 0x0022D813
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind([Nullable(new byte[]
		{
			1,
			2,
			2
		})] Func<USkeletalMeshComponent, UKuroCharRenderingComponent> Callback)
		{
			if (FMaterialSpecGetRenderingComponentBySkeletalRetVal.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FMaterialSpecGetRenderingComponentBySkeletalRetVal.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FMaterialSpecGetRenderingComponentBySkeletalRetVal.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FMaterialSpecGetRenderingComponentBySkeletalRetVal.OnScriptCallback));
				}
				FMaterialSpecGetRenderingComponentBySkeletalRetVal.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FMaterialSpecGetRenderingComponentBySkeletalRetVal.RegisterId);
		}

		// Token: 0x06017DD9 RID: 97753 RVA: 0x0022F650 File Offset: 0x0022D850
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe UKuroCharRenderingComponent Execute(USkeletalMeshComponent SkeletalMeshComponent)
		{
			FMaterialSpecGetRenderingComponentBySkeletalRetVal.__FMaterialSpecGetRenderingComponentBySkeletalRetVal_DelegateParams* ptr = stackalloc FMaterialSpecGetRenderingComponentBySkeletalRetVal.__FMaterialSpecGetRenderingComponentBySkeletalRetVal_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FMaterialSpecGetRenderingComponentBySkeletalRetVal.__FMaterialSpecGetRenderingComponentBySkeletalRetVal_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FMaterialSpecGetRenderingComponentBySkeletalRetVal.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->SkeletalMeshComponent = ((SkeletalMeshComponent != null) ? SkeletalMeshComponent.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroCharRenderingComponent>(ptr->__Result);
		}

		// Token: 0x06017DDA RID: 97754 RVA: 0x0022F6A8 File Offset: 0x0022D8A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Func<USkeletalMeshComponent, UKuroCharRenderingComponent> func = target as Func<USkeletalMeshComponent, UKuroCharRenderingComponent>;
			if (func == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(((FMaterialSpecGetRenderingComponentBySkeletalRetVal.__FMaterialSpecGetRenderingComponentBySkeletalRetVal_DelegateParams*)__Parameters)->SkeletalMeshComponent);
			UKuroCharRenderingComponent ukuroCharRenderingComponent = func(orCreateUObjectByNativePointer);
			((FMaterialSpecGetRenderingComponentBySkeletalRetVal.__FMaterialSpecGetRenderingComponentBySkeletalRetVal_DelegateParams*)__Parameters)->__Result = ((ukuroCharRenderingComponent != null) ? ukuroCharRenderingComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0400CED4 RID: 52948
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400CED5 RID: 52949
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.MaterialSpecGetRenderingComponentBySkeletalRetVal__DelegateSignature";

		// Token: 0x0400CED6 RID: 52950
		private static int RegisterId;

		// Token: 0x02002FEB RID: 12267
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FMaterialSpecGetRenderingComponentBySkeletalRetVal_DelegateParams
		{
			// Token: 0x04016BEB RID: 93163
			[FieldOffset(0)]
			public IntPtr SkeletalMeshComponent;

			// Token: 0x04016BEC RID: 93164
			[FieldOffset(8)]
			public IntPtr __Result;
		}

		// Token: 0x02002FEC RID: 12268
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016BED RID: 93165
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
