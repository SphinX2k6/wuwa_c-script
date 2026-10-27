using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007A8 RID: 1960
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)]
	public sealed class FActorBeginOverlapSignature : FSparseDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06006849 RID: 26697 RVA: 0x000950C9 File Offset: 0x000932C9
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FActorBeginOverlapSignature.StaticFunctionPtr();
		}

		// Token: 0x0600684A RID: 26698 RVA: 0x000950D5 File Offset: 0x000932D5
		private static IntPtr StaticFunctionPtr()
		{
			if (FActorBeginOverlapSignature._FunctionPtr == IntPtr.Zero)
			{
				FActorBeginOverlapSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ActorBeginOverlapSignature__DelegateSignature");
			}
			return FActorBeginOverlapSignature._FunctionPtr;
		}

		// Token: 0x170018A0 RID: 6304
		// (get) Token: 0x0600684B RID: 26699 RVA: 0x000950F8 File Offset: 0x000932F8
		public override FName DelegateName
		{
			get
			{
				return FNameStatic.OnActorBeginOverlap;
			}
		}

		// Token: 0x0600684C RID: 26700 RVA: 0x000950FF File Offset: 0x000932FF
		[NullableContext(2)]
		public FActorBeginOverlapSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600684D RID: 26701 RVA: 0x00095109 File Offset: 0x00093309
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<AActor, AActor>) ?? ((Action<AActor, AActor>)Delegate.CreateDelegate(typeof(Action<AActor, AActor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600684E RID: 26702 RVA: 0x0009513C File Offset: 0x0009333C
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2,
			2
		})] Action<AActor, AActor> Callback)
		{
			if (FActorBeginOverlapSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FActorBeginOverlapSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FActorBeginOverlapSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FActorBeginOverlapSignature.OnScriptCallback));
				}
				FActorBeginOverlapSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			FName delegateName = this.DelegateName;
			base.Add(delegateName, Callback, FActorBeginOverlapSignature.RegisterId);
		}

		// Token: 0x0600684F RID: 26703 RVA: 0x0009518C File Offset: 0x0009338C
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

		// Token: 0x06006850 RID: 26704 RVA: 0x000951AC File Offset: 0x000933AC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(AActor OverlappedActor, AActor OtherActor)
		{
			FActorBeginOverlapSignature.__FActorBeginOverlapSignature_DelegateParams* ptr = stackalloc FActorBeginOverlapSignature.__FActorBeginOverlapSignature_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FActorBeginOverlapSignature.__FActorBeginOverlapSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FActorBeginOverlapSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->OverlappedActor = ((OverlappedActor != null) ? OverlappedActor.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			FSparseDelegate.BroadcastInternal(base.GetOwner().NativePtr, this.DelegateName, (void*)ptr);
		}

		// Token: 0x06006851 RID: 26705 RVA: 0x00095220 File Offset: 0x00093420
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
			AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FActorBeginOverlapSignature.__FActorBeginOverlapSignature_DelegateParams*)__Parameters)->OverlappedActor);
			AActor orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FActorBeginOverlapSignature.__FActorBeginOverlapSignature_DelegateParams*)__Parameters)->OtherActor);
			action(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
		}

		// Token: 0x04003226 RID: 12838
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003227 RID: 12839
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ActorBeginOverlapSignature__DelegateSignature";

		// Token: 0x04003228 RID: 12840
		private static int RegisterId;

		// Token: 0x02002C63 RID: 11363
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FActorBeginOverlapSignature_DelegateParams
		{
			// Token: 0x0401658F RID: 91535
			[FieldOffset(0)]
			public IntPtr OverlappedActor;

			// Token: 0x04016590 RID: 91536
			[FieldOffset(8)]
			public IntPtr OtherActor;
		}

		// Token: 0x02002C64 RID: 11364
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016591 RID: 91537
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
