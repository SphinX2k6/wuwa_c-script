using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007C2 RID: 1986
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)]
	public sealed class FActorEndPlaySignature : FSparseDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06006A20 RID: 27168 RVA: 0x0009889F File Offset: 0x00096A9F
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FActorEndPlaySignature.StaticFunctionPtr();
		}

		// Token: 0x06006A21 RID: 27169 RVA: 0x000988AB File Offset: 0x00096AAB
		private static IntPtr StaticFunctionPtr()
		{
			if (FActorEndPlaySignature._FunctionPtr == IntPtr.Zero)
			{
				FActorEndPlaySignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ActorEndPlaySignature__DelegateSignature");
			}
			return FActorEndPlaySignature._FunctionPtr;
		}

		// Token: 0x17001914 RID: 6420
		// (get) Token: 0x06006A22 RID: 27170 RVA: 0x000988CE File Offset: 0x00096ACE
		public override FName DelegateName
		{
			get
			{
				return FNameStatic.OnEndPlay;
			}
		}

		// Token: 0x06006A23 RID: 27171 RVA: 0x000988D5 File Offset: 0x00096AD5
		[NullableContext(2)]
		public FActorEndPlaySignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006A24 RID: 27172 RVA: 0x000988DF File Offset: 0x00096ADF
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<AActor, TEnumAsByte<EEndPlayReason>>) ?? ((Action<AActor, TEnumAsByte<EEndPlayReason>>)Delegate.CreateDelegate(typeof(Action<AActor, TEnumAsByte<EEndPlayReason>>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06006A25 RID: 27173 RVA: 0x00098914 File Offset: 0x00096B14
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2,
			0
		})] Action<AActor, TEnumAsByte<EEndPlayReason>> Callback)
		{
			if (FActorEndPlaySignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FActorEndPlaySignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FActorEndPlaySignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FActorEndPlaySignature.OnScriptCallback));
				}
				FActorEndPlaySignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			FName delegateName = this.DelegateName;
			base.Add(delegateName, Callback, FActorEndPlaySignature.RegisterId);
		}

		// Token: 0x06006A26 RID: 27174 RVA: 0x00098964 File Offset: 0x00096B64
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2,
			0
		})] Action<AActor, TEnumAsByte<EEndPlayReason>> Callback)
		{
			FName delegateName = this.DelegateName;
			base.Remove(delegateName, Callback);
		}

		// Token: 0x06006A27 RID: 27175 RVA: 0x00098984 File Offset: 0x00096B84
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(AActor Actor, EEndPlayReason EndPlayReason)
		{
			FActorEndPlaySignature.__FActorEndPlaySignature_DelegateParams* ptr = stackalloc FActorEndPlaySignature.__FActorEndPlaySignature_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FActorEndPlaySignature.__FActorEndPlaySignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FActorEndPlaySignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Actor = ((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
			ptr->EndPlayReason = EndPlayReason;
			FSparseDelegate.BroadcastInternal(base.GetOwner().NativePtr, this.DelegateName, (void*)ptr);
		}

		// Token: 0x06006A28 RID: 27176 RVA: 0x000989EC File Offset: 0x00096BEC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<AActor, TEnumAsByte<EEndPlayReason>> action = target as Action<AActor, TEnumAsByte<EEndPlayReason>>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FActorEndPlaySignature.__FActorEndPlaySignature_DelegateParams*)__Parameters)->Actor);
			action(orCreateUObjectByNativePointer, ((FActorEndPlaySignature.__FActorEndPlaySignature_DelegateParams*)__Parameters)->EndPlayReason);
		}

		// Token: 0x04003325 RID: 13093
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003326 RID: 13094
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ActorEndPlaySignature__DelegateSignature";

		// Token: 0x04003327 RID: 13095
		private static int RegisterId;

		// Token: 0x02002C73 RID: 11379
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FActorEndPlaySignature_DelegateParams
		{
			// Token: 0x040165A3 RID: 91555
			[FieldOffset(0)]
			public IntPtr Actor;

			// Token: 0x040165A4 RID: 91556
			[FieldOffset(8)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}

		// Token: 0x02002C74 RID: 11380
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040165A5 RID: 91557
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
