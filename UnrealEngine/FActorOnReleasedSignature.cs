using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007C9 RID: 1993
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)]
	public sealed class FActorOnReleasedSignature : FSparseDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06006A5D RID: 27229 RVA: 0x00099363 File Offset: 0x00097563
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FActorOnReleasedSignature.StaticFunctionPtr();
		}

		// Token: 0x06006A5E RID: 27230 RVA: 0x0009936F File Offset: 0x0009756F
		private static IntPtr StaticFunctionPtr()
		{
			if (FActorOnReleasedSignature._FunctionPtr == IntPtr.Zero)
			{
				FActorOnReleasedSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ActorOnReleasedSignature__DelegateSignature");
			}
			return FActorOnReleasedSignature._FunctionPtr;
		}

		// Token: 0x1700191A RID: 6426
		// (get) Token: 0x06006A5F RID: 27231 RVA: 0x00099392 File Offset: 0x00097592
		public override FName DelegateName
		{
			get
			{
				return FNameStatic.OnReleased;
			}
		}

		// Token: 0x06006A60 RID: 27232 RVA: 0x00099399 File Offset: 0x00097599
		[NullableContext(2)]
		public FActorOnReleasedSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006A61 RID: 27233 RVA: 0x000993A3 File Offset: 0x000975A3
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<AActor, FKey>) ?? ((Action<AActor, FKey>)Delegate.CreateDelegate(typeof(Action<AActor, FKey>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06006A62 RID: 27234 RVA: 0x000993D8 File Offset: 0x000975D8
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2,
			1
		})] Action<AActor, FKey> Callback)
		{
			if (FActorOnReleasedSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FActorOnReleasedSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FActorOnReleasedSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FActorOnReleasedSignature.OnScriptCallback));
				}
				FActorOnReleasedSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			FName delegateName = this.DelegateName;
			base.Add(delegateName, Callback, FActorOnReleasedSignature.RegisterId);
		}

		// Token: 0x06006A63 RID: 27235 RVA: 0x00099428 File Offset: 0x00097628
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2,
			1
		})] Action<AActor, FKey> Callback)
		{
			FName delegateName = this.DelegateName;
			base.Remove(delegateName, Callback);
		}

		// Token: 0x06006A64 RID: 27236 RVA: 0x00099448 File Offset: 0x00097648
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(AActor TouchedActor, FKey ButtonReleased)
		{
			FActorOnReleasedSignature.__FActorOnReleasedSignature_DelegateParams* ptr = stackalloc FActorOnReleasedSignature.__FActorOnReleasedSignature_DelegateParams[(UIntPtr)55] + 15L / (long)sizeof(FActorOnReleasedSignature.__FActorOnReleasedSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FActorOnReleasedSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->TouchedActor = ((TouchedActor != null) ? TouchedActor.NativePtr : IntPtr.Zero);
			if (ButtonReleased != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->ButtonReleased, ButtonReleased.NativePtr, 1, false);
			}
			FSparseDelegate.BroadcastInternal(base.GetOwner().NativePtr, this.DelegateName, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FActorOnReleasedSignature._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06006A65 RID: 27237 RVA: 0x000994D8 File Offset: 0x000976D8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<AActor, FKey> action = target as Action<AActor, FKey>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FActorOnReleasedSignature.__FActorOnReleasedSignature_DelegateParams*)__Parameters)->TouchedActor);
			FKey arg = new FKey(&((FActorOnReleasedSignature.__FActorOnReleasedSignature_DelegateParams*)__Parameters)->ButtonReleased, true, true);
			action(orCreateUObjectByNativePointer, arg);
		}

		// Token: 0x04003339 RID: 13113
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400333A RID: 13114
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ActorOnReleasedSignature__DelegateSignature";

		// Token: 0x0400333B RID: 13115
		private static int RegisterId;

		// Token: 0x02002C7F RID: 11391
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __FActorOnReleasedSignature_DelegateParams
		{
			// Token: 0x040165B7 RID: 91575
			[FieldOffset(0)]
			public IntPtr TouchedActor;

			// Token: 0x040165B8 RID: 91576
			[FieldOffset(8)]
			public byte ButtonReleased;
		}

		// Token: 0x02002C80 RID: 11392
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040165B9 RID: 91577
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
