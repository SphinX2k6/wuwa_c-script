using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000439 RID: 1081
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnRotateStepSignature : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060068CF RID: 26831 RVA: 0x00098FE9 File Offset: 0x000971E9
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnRotateStepSignature.StaticFunctionPtr();
		}

		// Token: 0x060068D0 RID: 26832 RVA: 0x00098FF5 File Offset: 0x000971F5
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnRotateStepSignature._FunctionPtr == IntPtr.Zero)
			{
				FOnRotateStepSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGAS.OnRotateStepSignature__DelegateSignature");
			}
			return FOnRotateStepSignature._FunctionPtr;
		}

		// Token: 0x060068D1 RID: 26833 RVA: 0x00099018 File Offset: 0x00097218
		public FOnRotateStepSignature()
		{
		}

		// Token: 0x060068D2 RID: 26834 RVA: 0x00099020 File Offset: 0x00097220
		[NullableContext(2)]
		public FOnRotateStepSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060068D3 RID: 26835 RVA: 0x0009902A File Offset: 0x0009722A
		public FOnRotateStepSignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060068D4 RID: 26836 RVA: 0x00099035 File Offset: 0x00097235
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<USceneComponent, FVector>) ?? ((Action<USceneComponent, FVector>)Delegate.CreateDelegate(typeof(Action<USceneComponent, FVector>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060068D5 RID: 26837 RVA: 0x00099067 File Offset: 0x00097267
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<USceneComponent, FVector> Callback)
		{
			if (FOnRotateStepSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnRotateStepSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnRotateStepSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnRotateStepSignature.OnScriptCallback));
				}
				FOnRotateStepSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnRotateStepSignature.RegisterId);
		}

		// Token: 0x060068D6 RID: 26838 RVA: 0x000990A1 File Offset: 0x000972A1
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<USceneComponent, FVector> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060068D7 RID: 26839 RVA: 0x000990AC File Offset: 0x000972AC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(USceneComponent AimPivot, FVector TargetLocation)
		{
			FOnRotateStepSignature.__FOnRotateStepSignature_DelegateParams* ptr = stackalloc FOnRotateStepSignature.__FOnRotateStepSignature_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FOnRotateStepSignature.__FOnRotateStepSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnRotateStepSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->AimPivot = ((AimPivot != null) ? AimPivot.NativePtr : IntPtr.Zero);
			ptr->TargetLocation = TargetLocation;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060068D8 RID: 26840 RVA: 0x00099100 File Offset: 0x00097300
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<USceneComponent, FVector> action = target as Action<USceneComponent, FVector>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			USceneComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USceneComponent>(((FOnRotateStepSignature.__FOnRotateStepSignature_DelegateParams*)__Parameters)->AimPivot);
			action(orCreateUObjectByNativePointer, ((FOnRotateStepSignature.__FOnRotateStepSignature_DelegateParams*)__Parameters)->TargetLocation);
		}

		// Token: 0x04002CAA RID: 11434
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002CAB RID: 11435
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGAS.OnRotateStepSignature__DelegateSignature";

		// Token: 0x04002CAC RID: 11436
		private static int RegisterId;

		// Token: 0x02000B5A RID: 2906
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		private ref struct __FOnRotateStepSignature_DelegateParams
		{
			// Token: 0x04005C6D RID: 23661
			[FieldOffset(0)]
			public IntPtr AimPivot;

			// Token: 0x04005C6E RID: 23662
			[FieldOffset(8)]
			public FVector TargetLocation;
		}

		// Token: 0x02000B5B RID: 2907
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005C6F RID: 23663
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
