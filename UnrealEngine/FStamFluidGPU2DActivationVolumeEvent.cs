using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020017DE RID: 6110
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FStamFluidGPU2DActivationVolumeEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060168B2 RID: 92338 RVA: 0x0020E9BC File Offset: 0x0020CBBC
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FStamFluidGPU2DActivationVolumeEvent.StaticFunctionPtr();
		}

		// Token: 0x060168B3 RID: 92339 RVA: 0x0020E9C8 File Offset: 0x0020CBC8
		private static IntPtr StaticFunctionPtr()
		{
			if (FStamFluidGPU2DActivationVolumeEvent._FunctionPtr == IntPtr.Zero)
			{
				FStamFluidGPU2DActivationVolumeEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroComputeShader.StamFluidGPU2DActivationVolumeEvent__DelegateSignature");
			}
			return FStamFluidGPU2DActivationVolumeEvent._FunctionPtr;
		}

		// Token: 0x060168B4 RID: 92340 RVA: 0x0020E9EB File Offset: 0x0020CBEB
		public FStamFluidGPU2DActivationVolumeEvent()
		{
		}

		// Token: 0x060168B5 RID: 92341 RVA: 0x0020E9F3 File Offset: 0x0020CBF3
		[NullableContext(2)]
		public FStamFluidGPU2DActivationVolumeEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060168B6 RID: 92342 RVA: 0x0020E9FD File Offset: 0x0020CBFD
		public FStamFluidGPU2DActivationVolumeEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060168B7 RID: 92343 RVA: 0x0020EA08 File Offset: 0x0020CC08
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<APawn, UPrimitiveComponent>) ?? ((Action<APawn, UPrimitiveComponent>)Delegate.CreateDelegate(typeof(Action<APawn, UPrimitiveComponent>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060168B8 RID: 92344 RVA: 0x0020EA3A File Offset: 0x0020CC3A
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2,
			2
		})] Action<APawn, UPrimitiveComponent> Callback)
		{
			if (FStamFluidGPU2DActivationVolumeEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FStamFluidGPU2DActivationVolumeEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FStamFluidGPU2DActivationVolumeEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FStamFluidGPU2DActivationVolumeEvent.OnScriptCallback));
				}
				FStamFluidGPU2DActivationVolumeEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FStamFluidGPU2DActivationVolumeEvent.RegisterId);
		}

		// Token: 0x060168B9 RID: 92345 RVA: 0x0020EA74 File Offset: 0x0020CC74
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2,
			2
		})] Action<APawn, UPrimitiveComponent> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060168BA RID: 92346 RVA: 0x0020EA80 File Offset: 0x0020CC80
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(APawn Pawn, UPrimitiveComponent ActivateVolume)
		{
			FStamFluidGPU2DActivationVolumeEvent.__FStamFluidGPU2DActivationVolumeEvent_DelegateParams* ptr = stackalloc FStamFluidGPU2DActivationVolumeEvent.__FStamFluidGPU2DActivationVolumeEvent_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FStamFluidGPU2DActivationVolumeEvent.__FStamFluidGPU2DActivationVolumeEvent_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FStamFluidGPU2DActivationVolumeEvent.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Pawn = ((Pawn != null) ? Pawn.NativePtr : IntPtr.Zero);
			ptr->ActivateVolume = ((ActivateVolume != null) ? ActivateVolume.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060168BB RID: 92347 RVA: 0x0020EAE4 File Offset: 0x0020CCE4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<APawn, UPrimitiveComponent> action = target as Action<APawn, UPrimitiveComponent>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			APawn orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(((FStamFluidGPU2DActivationVolumeEvent.__FStamFluidGPU2DActivationVolumeEvent_DelegateParams*)__Parameters)->Pawn);
			UPrimitiveComponent orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UPrimitiveComponent>(((FStamFluidGPU2DActivationVolumeEvent.__FStamFluidGPU2DActivationVolumeEvent_DelegateParams*)__Parameters)->ActivateVolume);
			action(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
		}

		// Token: 0x0400C3E9 RID: 50153
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400C3EA RID: 50154
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroComputeShader.StamFluidGPU2DActivationVolumeEvent__DelegateSignature";

		// Token: 0x0400C3EB RID: 50155
		private static int RegisterId;

		// Token: 0x02002F31 RID: 12081
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FStamFluidGPU2DActivationVolumeEvent_DelegateParams
		{
			// Token: 0x04016AAD RID: 92845
			[FieldOffset(0)]
			public IntPtr Pawn;

			// Token: 0x04016AAE RID: 92846
			[FieldOffset(8)]
			public IntPtr ActivateVolume;
		}

		// Token: 0x02002F32 RID: 12082
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016AAF RID: 92847
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
