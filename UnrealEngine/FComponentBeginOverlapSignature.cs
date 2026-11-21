using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001AC RID: 428
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)]
	public sealed class FComponentBeginOverlapSignature : FSparseDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06001FEB RID: 8171 RVA: 0x0002E3CC File Offset: 0x0002C5CC
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FComponentBeginOverlapSignature.StaticFunctionPtr();
		}

		// Token: 0x06001FEC RID: 8172 RVA: 0x0002E3D8 File Offset: 0x0002C5D8
		private static IntPtr StaticFunctionPtr()
		{
			if (FComponentBeginOverlapSignature._FunctionPtr == IntPtr.Zero)
			{
				FComponentBeginOverlapSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ComponentBeginOverlapSignature__DelegateSignature");
			}
			return FComponentBeginOverlapSignature._FunctionPtr;
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06001FED RID: 8173 RVA: 0x0002E3FB File Offset: 0x0002C5FB
		public override FName DelegateName
		{
			get
			{
				return FNameStatic.OnComponentBeginOverlap;
			}
		}

		// Token: 0x06001FEE RID: 8174 RVA: 0x0002E402 File Offset: 0x0002C602
		[NullableContext(2)]
		public FComponentBeginOverlapSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001FEF RID: 8175 RVA: 0x0002E40C File Offset: 0x0002C60C
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UPrimitiveComponent, AActor, UPrimitiveComponent, int, bool, FHitResult>) ?? ((Action<UPrimitiveComponent, AActor, UPrimitiveComponent, int, bool, FHitResult>)Delegate.CreateDelegate(typeof(Action<UPrimitiveComponent, AActor, UPrimitiveComponent, int, bool, FHitResult>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06001FF0 RID: 8176 RVA: 0x0002E440 File Offset: 0x0002C640
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

		// Token: 0x06001FF1 RID: 8177 RVA: 0x0002E490 File Offset: 0x0002C690
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

		// Token: 0x06001FF2 RID: 8178 RVA: 0x0002E4B0 File Offset: 0x0002C6B0
		[NullableContext(2)]
		[SkipLocalsInit]
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

		// Token: 0x06001FF3 RID: 8179 RVA: 0x0002E570 File Offset: 0x0002C770
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04000A9D RID: 2717
		internal static IntPtr _FunctionPtr;

		// Token: 0x04000A9E RID: 2718
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ComponentBeginOverlapSignature__DelegateSignature";

		// Token: 0x04000A9F RID: 2719
		private static int RegisterId;

		// Token: 0x0200097F RID: 2431
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		private ref struct __FComponentBeginOverlapSignature_DelegateParams
		{
			// Token: 0x040058CE RID: 22734
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x040058CF RID: 22735
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x040058D0 RID: 22736
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x040058D1 RID: 22737
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x040058D2 RID: 22738
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x040058D3 RID: 22739
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02000980 RID: 2432
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040058D4 RID: 22740
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
