using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001AB RID: 427
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)]
	public sealed class FComponentBeginOverlapBlockSignature : FSparseDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06001FE2 RID: 8162 RVA: 0x0002E19D File Offset: 0x0002C39D
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FComponentBeginOverlapBlockSignature.StaticFunctionPtr();
		}

		// Token: 0x06001FE3 RID: 8163 RVA: 0x0002E1A9 File Offset: 0x0002C3A9
		private static IntPtr StaticFunctionPtr()
		{
			if (FComponentBeginOverlapBlockSignature._FunctionPtr == IntPtr.Zero)
			{
				FComponentBeginOverlapBlockSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ComponentBeginOverlapBlockSignature__DelegateSignature");
			}
			return FComponentBeginOverlapBlockSignature._FunctionPtr;
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06001FE4 RID: 8164 RVA: 0x0002E1CC File Offset: 0x0002C3CC
		public override FName DelegateName
		{
			get
			{
				return FNameStatic.OnComponentBeginOverlapBlock;
			}
		}

		// Token: 0x06001FE5 RID: 8165 RVA: 0x0002E1D3 File Offset: 0x0002C3D3
		[NullableContext(2)]
		public FComponentBeginOverlapBlockSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001FE6 RID: 8166 RVA: 0x0002E1DD File Offset: 0x0002C3DD
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UPrimitiveComponent, AActor, UPrimitiveComponent, int, bool, FHitResult>) ?? ((Action<UPrimitiveComponent, AActor, UPrimitiveComponent, int, bool, FHitResult>)Delegate.CreateDelegate(typeof(Action<UPrimitiveComponent, AActor, UPrimitiveComponent, int, bool, FHitResult>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06001FE7 RID: 8167 RVA: 0x0002E210 File Offset: 0x0002C410
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

		// Token: 0x06001FE8 RID: 8168 RVA: 0x0002E260 File Offset: 0x0002C460
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

		// Token: 0x06001FE9 RID: 8169 RVA: 0x0002E280 File Offset: 0x0002C480
		[NullableContext(2)]
		[SkipLocalsInit]
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

		// Token: 0x06001FEA RID: 8170 RVA: 0x0002E340 File Offset: 0x0002C540
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04000A9A RID: 2714
		internal static IntPtr _FunctionPtr;

		// Token: 0x04000A9B RID: 2715
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ComponentBeginOverlapBlockSignature__DelegateSignature";

		// Token: 0x04000A9C RID: 2716
		private static int RegisterId;

		// Token: 0x0200097D RID: 2429
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		private ref struct __FComponentBeginOverlapBlockSignature_DelegateParams
		{
			// Token: 0x040058C7 RID: 22727
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x040058C8 RID: 22728
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x040058C9 RID: 22729
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x040058CA RID: 22730
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x040058CB RID: 22731
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x040058CC RID: 22732
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x0200097E RID: 2430
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040058CD RID: 22733
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
