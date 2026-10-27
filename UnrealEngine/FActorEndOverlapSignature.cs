using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007C1 RID: 1985
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)]
	public sealed class FActorEndOverlapSignature : FSparseDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06006A17 RID: 27159 RVA: 0x000986E9 File Offset: 0x000968E9
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FActorEndOverlapSignature.StaticFunctionPtr();
		}

		// Token: 0x06006A18 RID: 27160 RVA: 0x000986F5 File Offset: 0x000968F5
		private static IntPtr StaticFunctionPtr()
		{
			if (FActorEndOverlapSignature._FunctionPtr == IntPtr.Zero)
			{
				FActorEndOverlapSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ActorEndOverlapSignature__DelegateSignature");
			}
			return FActorEndOverlapSignature._FunctionPtr;
		}

		// Token: 0x17001913 RID: 6419
		// (get) Token: 0x06006A19 RID: 27161 RVA: 0x00098718 File Offset: 0x00096918
		public override FName DelegateName
		{
			get
			{
				return FNameStatic.OnActorEndOverlap;
			}
		}

		// Token: 0x06006A1A RID: 27162 RVA: 0x0009871F File Offset: 0x0009691F
		[NullableContext(2)]
		public FActorEndOverlapSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006A1B RID: 27163 RVA: 0x00098729 File Offset: 0x00096929
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<AActor, AActor>) ?? ((Action<AActor, AActor>)Delegate.CreateDelegate(typeof(Action<AActor, AActor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06006A1C RID: 27164 RVA: 0x0009875C File Offset: 0x0009695C
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2,
			2
		})] Action<AActor, AActor> Callback)
		{
			if (FActorEndOverlapSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FActorEndOverlapSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FActorEndOverlapSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FActorEndOverlapSignature.OnScriptCallback));
				}
				FActorEndOverlapSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			FName delegateName = this.DelegateName;
			base.Add(delegateName, Callback, FActorEndOverlapSignature.RegisterId);
		}

		// Token: 0x06006A1D RID: 27165 RVA: 0x000987AC File Offset: 0x000969AC
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2,
			2
		})] Action<AActor, AActor> Callback)
		{
			FName delegateName = this.DelegateName;
			base.Remove(delegateName, Callback);
		}

		// Token: 0x06006A1E RID: 27166 RVA: 0x000987CC File Offset: 0x000969CC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(AActor OverlappedActor, AActor OtherActor)
		{
			FActorEndOverlapSignature.__FActorEndOverlapSignature_DelegateParams* ptr = stackalloc FActorEndOverlapSignature.__FActorEndOverlapSignature_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FActorEndOverlapSignature.__FActorEndOverlapSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FActorEndOverlapSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->OverlappedActor = ((OverlappedActor != null) ? OverlappedActor.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			FSparseDelegate.BroadcastInternal(base.GetOwner().NativePtr, this.DelegateName, (void*)ptr);
		}

		// Token: 0x06006A1F RID: 27167 RVA: 0x00098840 File Offset: 0x00096A40
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<AActor, AActor> action = target as Action<AActor, AActor>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FActorEndOverlapSignature.__FActorEndOverlapSignature_DelegateParams*)__Parameters)->OverlappedActor);
			AActor orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FActorEndOverlapSignature.__FActorEndOverlapSignature_DelegateParams*)__Parameters)->OtherActor);
			action(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
		}

		// Token: 0x04003322 RID: 13090
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003323 RID: 13091
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ActorEndOverlapSignature__DelegateSignature";

		// Token: 0x04003324 RID: 13092
		private static int RegisterId;

		// Token: 0x02002C71 RID: 11377
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FActorEndOverlapSignature_DelegateParams
		{
			// Token: 0x040165A0 RID: 91552
			[FieldOffset(0)]
			public IntPtr OverlappedActor;

			// Token: 0x040165A1 RID: 91553
			[FieldOffset(8)]
			public IntPtr OtherActor;
		}

		// Token: 0x02002C72 RID: 11378
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040165A2 RID: 91554
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
