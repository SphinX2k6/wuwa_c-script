using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200094F RID: 2383
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)]
	public sealed class FComponentBeginOverlapBlockSignature : FSparseDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060086FB RID: 34555 RVA: 0x000C07DD File Offset: 0x000BE9DD
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FComponentBeginOverlapBlockSignature.StaticFunctionPtr();
		}

		// Token: 0x060086FC RID: 34556 RVA: 0x000C07E9 File Offset: 0x000BE9E9
		private static IntPtr StaticFunctionPtr()
		{
			if (FComponentBeginOverlapBlockSignature._FunctionPtr == IntPtr.Zero)
			{
				FComponentBeginOverlapBlockSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ComponentBeginOverlapBlockSignature__DelegateSignature");
			}
			return FComponentBeginOverlapBlockSignature._FunctionPtr;
		}

		// Token: 0x17001FF3 RID: 8179
		// (get) Token: 0x060086FD RID: 34557 RVA: 0x000C080C File Offset: 0x000BEA0C
		public override FName DelegateName
		{
			get
			{
				return FNameStatic.OnComponentBeginOverlapBlock;
			}
		}

		// Token: 0x060086FE RID: 34558 RVA: 0x000C0813 File Offset: 0x000BEA13
		[NullableContext(2)]
		public FComponentBeginOverlapBlockSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060086FF RID: 34559 RVA: 0x000C081D File Offset: 0x000BEA1D
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UPrimitiveComponent, AActor, UPrimitiveComponent, int, bool, FHitResult>) ?? ((Action<UPrimitiveComponent, AActor, UPrimitiveComponent, int, bool, FHitResult>)Delegate.CreateDelegate(typeof(Action<UPrimitiveComponent, AActor, UPrimitiveComponent, int, bool, FHitResult>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06008700 RID: 34560 RVA: 0x000C0850 File Offset: 0x000BEA50
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2,
			2,
			2,
			1
		})] Action<UPrimitiveComponent, AActor, UPrimitiveComponent, int, bool, FHitResult> Callback)
		{
			if (FComponentBeginOverlapBlockSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FComponentBeginOverlapBlockSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FComponentBeginOverlapBlockSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FComponentBeginOverlapBlockSignature.OnScriptCallback));
				}
				FComponentBeginOverlapBlockSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			FName delegateName = this.DelegateName;
			base.Add(delegateName, Callback, FComponentBeginOverlapBlockSignature.RegisterId);
		}

		// Token: 0x06008701 RID: 34561 RVA: 0x000C08A0 File Offset: 0x000BEAA0
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2,
			2,
			2,
			1
		})] Action<UPrimitiveComponent, AActor, UPrimitiveComponent, int, bool, FHitResult> Callback)
		{
			FName delegateName = this.DelegateName;
			base.Remove(delegateName, Callback);
		}

		// Token: 0x06008702 RID: 34562 RVA: 0x000C08C0 File Offset: 0x000BEAC0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			FComponentBeginOverlapBlockSignature.__FComponentBeginOverlapBlockSignature_DelegateParams* ptr = stackalloc FComponentBeginOverlapBlockSignature.__FComponentBeginOverlapBlockSignature_DelegateParams[(UIntPtr)199] + 15L / (long)sizeof(FComponentBeginOverlapBlockSignature.__FComponentBeginOverlapBlockSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FComponentBeginOverlapBlockSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			FSparseDelegate.BroadcastInternal(base.GetOwner().NativePtr, this.DelegateName, (void*)ptr);
		}

		// Token: 0x06008703 RID: 34563 RVA: 0x000C0980 File Offset: 0x000BEB80
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UPrimitiveComponent, AActor, UPrimitiveComponent, int, bool, FHitResult> action = target as Action<UPrimitiveComponent, AActor, UPrimitiveComponent, int, bool, FHitResult>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UPrimitiveComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UPrimitiveComponent>(((FComponentBeginOverlapBlockSignature.__FComponentBeginOverlapBlockSignature_DelegateParams*)__Parameters)->OverlappedComponent);
			AActor orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FComponentBeginOverlapBlockSignature.__FComponentBeginOverlapBlockSignature_DelegateParams*)__Parameters)->OtherActor);
			UPrimitiveComponent orCreateUObjectByNativePointer3 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UPrimitiveComponent>(((FComponentBeginOverlapBlockSignature.__FComponentBeginOverlapBlockSignature_DelegateParams*)__Parameters)->OtherComp);
			FHitResult arg = new FHitResult(&((FComponentBeginOverlapBlockSignature.__FComponentBeginOverlapBlockSignature_DelegateParams*)__Parameters)->SweepResult, true, true);
			action(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, orCreateUObjectByNativePointer3, ((FComponentBeginOverlapBlockSignature.__FComponentBeginOverlapBlockSignature_DelegateParams*)__Parameters)->OtherBodyIndex, ((FComponentBeginOverlapBlockSignature.__FComponentBeginOverlapBlockSignature_DelegateParams*)__Parameters)->bFromSweep, arg);
		}

		// Token: 0x04004040 RID: 16448
		internal static IntPtr _FunctionPtr;

		// Token: 0x04004041 RID: 16449
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ComponentBeginOverlapBlockSignature__DelegateSignature";

		// Token: 0x04004042 RID: 16450
		private static int RegisterId;

		// Token: 0x02002CC1 RID: 11457
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __FComponentBeginOverlapBlockSignature_DelegateParams
		{
			// Token: 0x04016652 RID: 91730
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04016653 RID: 91731
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04016654 RID: 91732
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04016655 RID: 91733
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x04016656 RID: 91734
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x04016657 RID: 91735
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02002CC2 RID: 11458
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016658 RID: 91736
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
