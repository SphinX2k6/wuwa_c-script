using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000162 RID: 354
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)]
	public sealed class FActorBeginOverlapSignature : FSparseDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060015C0 RID: 5568 RVA: 0x00021705 File Offset: 0x0001F905
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FActorBeginOverlapSignature.StaticFunctionPtr();
		}

		// Token: 0x060015C1 RID: 5569 RVA: 0x00021711 File Offset: 0x0001F911
		private static IntPtr StaticFunctionPtr()
		{
			if (FActorBeginOverlapSignature._FunctionPtr == IntPtr.Zero)
			{
				FActorBeginOverlapSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ActorBeginOverlapSignature__DelegateSignature");
			}
			return FActorBeginOverlapSignature._FunctionPtr;
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x060015C2 RID: 5570 RVA: 0x00021734 File Offset: 0x0001F934
		public override FName DelegateName
		{
			get
			{
				return FNameStatic.OnActorBeginOverlap;
			}
		}

		// Token: 0x060015C3 RID: 5571 RVA: 0x0002173B File Offset: 0x0001F93B
		[NullableContext(2)]
		public FActorBeginOverlapSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060015C4 RID: 5572 RVA: 0x00021745 File Offset: 0x0001F945
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<AActor, AActor>) ?? ((Action<AActor, AActor>)Delegate.CreateDelegate(typeof(Action<AActor, AActor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060015C5 RID: 5573 RVA: 0x00021778 File Offset: 0x0001F978
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

		// Token: 0x060015C6 RID: 5574 RVA: 0x000217C8 File Offset: 0x0001F9C8
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

		// Token: 0x060015C7 RID: 5575 RVA: 0x000217E8 File Offset: 0x0001F9E8
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(AActor OverlappedActor, AActor OtherActor)
		{
			FActorBeginOverlapSignature.__FActorBeginOverlapSignature_DelegateParams* ptr = stackalloc FActorBeginOverlapSignature.__FActorBeginOverlapSignature_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FActorBeginOverlapSignature.__FActorBeginOverlapSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FActorBeginOverlapSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->OverlappedActor = ((OverlappedActor != null) ? OverlappedActor.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			FSparseDelegate.BroadcastInternal(base.GetOwner().NativePtr, this.DelegateName, (void*)ptr);
		}

		// Token: 0x060015C8 RID: 5576 RVA: 0x0002185C File Offset: 0x0001FA5C
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x040006E9 RID: 1769
		internal static IntPtr _FunctionPtr;

		// Token: 0x040006EA RID: 1770
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ActorBeginOverlapSignature__DelegateSignature";

		// Token: 0x040006EB RID: 1771
		private static int RegisterId;

		// Token: 0x02000946 RID: 2374
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FActorBeginOverlapSignature_DelegateParams
		{
			// Token: 0x04005865 RID: 22629
			[FieldOffset(0)]
			public IntPtr OverlappedActor;

			// Token: 0x04005866 RID: 22630
			[FieldOffset(8)]
			public IntPtr OtherActor;
		}

		// Token: 0x02000947 RID: 2375
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005867 RID: 22631
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
