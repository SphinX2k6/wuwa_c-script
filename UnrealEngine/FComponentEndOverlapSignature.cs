using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000956 RID: 2390
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)]
	public sealed class FComponentEndOverlapSignature : FSparseDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06008738 RID: 34616 RVA: 0x000C13BD File Offset: 0x000BF5BD
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FComponentEndOverlapSignature.StaticFunctionPtr();
		}

		// Token: 0x06008739 RID: 34617 RVA: 0x000C13C9 File Offset: 0x000BF5C9
		private static IntPtr StaticFunctionPtr()
		{
			if (FComponentEndOverlapSignature._FunctionPtr == IntPtr.Zero)
			{
				FComponentEndOverlapSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ComponentEndOverlapSignature__DelegateSignature");
			}
			return FComponentEndOverlapSignature._FunctionPtr;
		}

		// Token: 0x17001FFA RID: 8186
		// (get) Token: 0x0600873A RID: 34618 RVA: 0x000C13EC File Offset: 0x000BF5EC
		public override FName DelegateName
		{
			get
			{
				return FNameStatic.OnComponentEndOverlap;
			}
		}

		// Token: 0x0600873B RID: 34619 RVA: 0x000C13F3 File Offset: 0x000BF5F3
		[NullableContext(2)]
		public FComponentEndOverlapSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600873C RID: 34620 RVA: 0x000C13FD File Offset: 0x000BF5FD
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UPrimitiveComponent, AActor, UPrimitiveComponent, int>) ?? ((Action<UPrimitiveComponent, AActor, UPrimitiveComponent, int>)Delegate.CreateDelegate(typeof(Action<UPrimitiveComponent, AActor, UPrimitiveComponent, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600873D RID: 34621 RVA: 0x000C1430 File Offset: 0x000BF630
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2,
			2,
			2
		})] Action<UPrimitiveComponent, AActor, UPrimitiveComponent, int> Callback)
		{
			if (FComponentEndOverlapSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FComponentEndOverlapSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FComponentEndOverlapSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FComponentEndOverlapSignature.OnScriptCallback));
				}
				FComponentEndOverlapSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			FName delegateName = this.DelegateName;
			base.Add(delegateName, Callback, FComponentEndOverlapSignature.RegisterId);
		}

		// Token: 0x0600873E RID: 34622 RVA: 0x000C1480 File Offset: 0x000BF680
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2,
			2,
			2
		})] Action<UPrimitiveComponent, AActor, UPrimitiveComponent, int> Callback)
		{
			FName delegateName = this.DelegateName;
			base.Remove(delegateName, Callback);
		}

		// Token: 0x0600873F RID: 34623 RVA: 0x000C14A0 File Offset: 0x000BF6A0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			FComponentEndOverlapSignature.__FComponentEndOverlapSignature_DelegateParams* ptr = stackalloc FComponentEndOverlapSignature.__FComponentEndOverlapSignature_DelegateParams[(UIntPtr)47] + 15L / (long)sizeof(FComponentEndOverlapSignature.__FComponentEndOverlapSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FComponentEndOverlapSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			FSparseDelegate.BroadcastInternal(base.GetOwner().NativePtr, this.DelegateName, (void*)ptr);
		}

		// Token: 0x06008740 RID: 34624 RVA: 0x000C1530 File Offset: 0x000BF730
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UPrimitiveComponent, AActor, UPrimitiveComponent, int> action = target as Action<UPrimitiveComponent, AActor, UPrimitiveComponent, int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UPrimitiveComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UPrimitiveComponent>(((FComponentEndOverlapSignature.__FComponentEndOverlapSignature_DelegateParams*)__Parameters)->OverlappedComponent);
			AActor orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FComponentEndOverlapSignature.__FComponentEndOverlapSignature_DelegateParams*)__Parameters)->OtherActor);
			UPrimitiveComponent orCreateUObjectByNativePointer3 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UPrimitiveComponent>(((FComponentEndOverlapSignature.__FComponentEndOverlapSignature_DelegateParams*)__Parameters)->OtherComp);
			action(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, orCreateUObjectByNativePointer3, ((FComponentEndOverlapSignature.__FComponentEndOverlapSignature_DelegateParams*)__Parameters)->OtherBodyIndex);
		}

		// Token: 0x04004057 RID: 16471
		internal static IntPtr _FunctionPtr;

		// Token: 0x04004058 RID: 16472
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ComponentEndOverlapSignature__DelegateSignature";

		// Token: 0x04004059 RID: 16473
		private static int RegisterId;

		// Token: 0x02002CCD RID: 11469
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __FComponentEndOverlapSignature_DelegateParams
		{
			// Token: 0x0401666D RID: 91757
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x0401666E RID: 91758
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x0401666F RID: 91759
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04016670 RID: 91760
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}

		// Token: 0x02002CCE RID: 11470
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016671 RID: 91761
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
