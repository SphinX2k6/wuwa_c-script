using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001973 RID: 6515
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnRotateSequenceFinishedSignature : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06018354 RID: 99156 RVA: 0x0023B1BA File Offset: 0x002393BA
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnRotateSequenceFinishedSignature.StaticFunctionPtr();
		}

		// Token: 0x06018355 RID: 99157 RVA: 0x0023B1C6 File Offset: 0x002393C6
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnRotateSequenceFinishedSignature._FunctionPtr == IntPtr.Zero)
			{
				FOnRotateSequenceFinishedSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGAS.OnRotateSequenceFinishedSignature__DelegateSignature");
			}
			return FOnRotateSequenceFinishedSignature._FunctionPtr;
		}

		// Token: 0x06018356 RID: 99158 RVA: 0x0023B1E9 File Offset: 0x002393E9
		public FOnRotateSequenceFinishedSignature()
		{
		}

		// Token: 0x06018357 RID: 99159 RVA: 0x0023B1F1 File Offset: 0x002393F1
		[NullableContext(2)]
		public FOnRotateSequenceFinishedSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018358 RID: 99160 RVA: 0x0023B1FB File Offset: 0x002393FB
		public FOnRotateSequenceFinishedSignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018359 RID: 99161 RVA: 0x0023B206 File Offset: 0x00239406
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<USceneComponent>) ?? ((Action<USceneComponent>)Delegate.CreateDelegate(typeof(Action<USceneComponent>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601835A RID: 99162 RVA: 0x0023B238 File Offset: 0x00239438
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<USceneComponent> Callback)
		{
			if (FOnRotateSequenceFinishedSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnRotateSequenceFinishedSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnRotateSequenceFinishedSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnRotateSequenceFinishedSignature.OnScriptCallback));
				}
				FOnRotateSequenceFinishedSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnRotateSequenceFinishedSignature.RegisterId);
		}

		// Token: 0x0601835B RID: 99163 RVA: 0x0023B272 File Offset: 0x00239472
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<USceneComponent> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601835C RID: 99164 RVA: 0x0023B27C File Offset: 0x0023947C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(USceneComponent AimPivot)
		{
			FOnRotateSequenceFinishedSignature.__FOnRotateSequenceFinishedSignature_DelegateParams* ptr = stackalloc FOnRotateSequenceFinishedSignature.__FOnRotateSequenceFinishedSignature_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnRotateSequenceFinishedSignature.__FOnRotateSequenceFinishedSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnRotateSequenceFinishedSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->AimPivot = ((AimPivot != null) ? AimPivot.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601835D RID: 99165 RVA: 0x0023B2C8 File Offset: 0x002394C8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<USceneComponent> action = target as Action<USceneComponent>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			USceneComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USceneComponent>(((FOnRotateSequenceFinishedSignature.__FOnRotateSequenceFinishedSignature_DelegateParams*)__Parameters)->AimPivot);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x0400D1CF RID: 53711
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400D1D0 RID: 53712
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGAS.OnRotateSequenceFinishedSignature__DelegateSignature";

		// Token: 0x0400D1D1 RID: 53713
		private static int RegisterId;

		// Token: 0x02003068 RID: 12392
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FOnRotateSequenceFinishedSignature_DelegateParams
		{
			// Token: 0x04016D36 RID: 93494
			[FieldOffset(0)]
			public IntPtr AimPivot;
		}

		// Token: 0x02003069 RID: 12393
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016D37 RID: 93495
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
