using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000950 RID: 2384
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)]
	public sealed class FComponentBeginOverlapSignature : FSparseDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06008704 RID: 34564 RVA: 0x000C0A0C File Offset: 0x000BEC0C
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FComponentBeginOverlapSignature.StaticFunctionPtr();
		}

		// Token: 0x06008705 RID: 34565 RVA: 0x000C0A18 File Offset: 0x000BEC18
		private static IntPtr StaticFunctionPtr()
		{
			if (FComponentBeginOverlapSignature._FunctionPtr == IntPtr.Zero)
			{
				FComponentBeginOverlapSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ComponentBeginOverlapSignature__DelegateSignature");
			}
			return FComponentBeginOverlapSignature._FunctionPtr;
		}

		// Token: 0x17001FF4 RID: 8180
		// (get) Token: 0x06008706 RID: 34566 RVA: 0x000C0A3B File Offset: 0x000BEC3B
		public override FName DelegateName
		{
			get
			{
				return FNameStatic.OnComponentBeginOverlap;
			}
		}

		// Token: 0x06008707 RID: 34567 RVA: 0x000C0A42 File Offset: 0x000BEC42
		[NullableContext(2)]
		public FComponentBeginOverlapSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008708 RID: 34568 RVA: 0x000C0A4C File Offset: 0x000BEC4C
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UPrimitiveComponent, AActor, UPrimitiveComponent, int, bool, FHitResult>) ?? ((Action<UPrimitiveComponent, AActor, UPrimitiveComponent, int, bool, FHitResult>)Delegate.CreateDelegate(typeof(Action<UPrimitiveComponent, AActor, UPrimitiveComponent, int, bool, FHitResult>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06008709 RID: 34569 RVA: 0x000C0A80 File Offset: 0x000BEC80
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
			if (FComponentBeginOverlapSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FComponentBeginOverlapSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FComponentBeginOverlapSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FComponentBeginOverlapSignature.OnScriptCallback));
				}
				FComponentBeginOverlapSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			FName delegateName = this.DelegateName;
			base.Add(delegateName, Callback, FComponentBeginOverlapSignature.RegisterId);
		}

		// Token: 0x0600870A RID: 34570 RVA: 0x000C0AD0 File Offset: 0x000BECD0
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

		// Token: 0x0600870B RID: 34571 RVA: 0x000C0AF0 File Offset: 0x000BECF0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			FComponentBeginOverlapSignature.__FComponentBeginOverlapSignature_DelegateParams* ptr = stackalloc FComponentBeginOverlapSignature.__FComponentBeginOverlapSignature_DelegateParams[(UIntPtr)199] + 15L / (long)sizeof(FComponentBeginOverlapSignature.__FComponentBeginOverlapSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FComponentBeginOverlapSignature.StaticFunctionPtr(), (void*)ptr, 1);
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

		// Token: 0x0600870C RID: 34572 RVA: 0x000C0BB0 File Offset: 0x000BEDB0
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
			UPrimitiveComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UPrimitiveComponent>(((FComponentBeginOverlapSignature.__FComponentBeginOverlapSignature_DelegateParams*)__Parameters)->OverlappedComponent);
			AActor orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FComponentBeginOverlapSignature.__FComponentBeginOverlapSignature_DelegateParams*)__Parameters)->OtherActor);
			UPrimitiveComponent orCreateUObjectByNativePointer3 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UPrimitiveComponent>(((FComponentBeginOverlapSignature.__FComponentBeginOverlapSignature_DelegateParams*)__Parameters)->OtherComp);
			FHitResult arg = new FHitResult(&((FComponentBeginOverlapSignature.__FComponentBeginOverlapSignature_DelegateParams*)__Parameters)->SweepResult, true, true);
			action(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, orCreateUObjectByNativePointer3, ((FComponentBeginOverlapSignature.__FComponentBeginOverlapSignature_DelegateParams*)__Parameters)->OtherBodyIndex, ((FComponentBeginOverlapSignature.__FComponentBeginOverlapSignature_DelegateParams*)__Parameters)->bFromSweep, arg);
		}

		// Token: 0x04004043 RID: 16451
		internal static IntPtr _FunctionPtr;

		// Token: 0x04004044 RID: 16452
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ComponentBeginOverlapSignature__DelegateSignature";

		// Token: 0x04004045 RID: 16453
		private static int RegisterId;

		// Token: 0x02002CC3 RID: 11459
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __FComponentBeginOverlapSignature_DelegateParams
		{
			// Token: 0x04016659 RID: 91737
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x0401665A RID: 91738
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x0401665B RID: 91739
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x0401665C RID: 91740
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x0401665D RID: 91741
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x0401665E RID: 91742
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02002CC4 RID: 11460
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401665F RID: 91743
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
