using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007C0 RID: 1984
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)]
	public sealed class FActorEndCursorOverSignature : FSparseDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06006A0E RID: 27150 RVA: 0x00098559 File Offset: 0x00096759
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FActorEndCursorOverSignature.StaticFunctionPtr();
		}

		// Token: 0x06006A0F RID: 27151 RVA: 0x00098565 File Offset: 0x00096765
		private static IntPtr StaticFunctionPtr()
		{
			if (FActorEndCursorOverSignature._FunctionPtr == IntPtr.Zero)
			{
				FActorEndCursorOverSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ActorEndCursorOverSignature__DelegateSignature");
			}
			return FActorEndCursorOverSignature._FunctionPtr;
		}

		// Token: 0x17001912 RID: 6418
		// (get) Token: 0x06006A10 RID: 27152 RVA: 0x00098588 File Offset: 0x00096788
		public override FName DelegateName
		{
			get
			{
				return FNameStatic.OnEndCursorOver;
			}
		}

		// Token: 0x06006A11 RID: 27153 RVA: 0x0009858F File Offset: 0x0009678F
		[NullableContext(2)]
		public FActorEndCursorOverSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006A12 RID: 27154 RVA: 0x00098599 File Offset: 0x00096799
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<AActor>) ?? ((Action<AActor>)Delegate.CreateDelegate(typeof(Action<AActor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06006A13 RID: 27155 RVA: 0x000985CC File Offset: 0x000967CC
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<AActor> Callback)
		{
			if (FActorEndCursorOverSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FActorEndCursorOverSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FActorEndCursorOverSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FActorEndCursorOverSignature.OnScriptCallback));
				}
				FActorEndCursorOverSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			FName delegateName = this.DelegateName;
			base.Add(delegateName, Callback, FActorEndCursorOverSignature.RegisterId);
		}

		// Token: 0x06006A14 RID: 27156 RVA: 0x0009861C File Offset: 0x0009681C
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<AActor> Callback)
		{
			FName delegateName = this.DelegateName;
			base.Remove(delegateName, Callback);
		}

		// Token: 0x06006A15 RID: 27157 RVA: 0x0009863C File Offset: 0x0009683C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(AActor TouchedActor)
		{
			FActorEndCursorOverSignature.__FActorEndCursorOverSignature_DelegateParams* ptr = stackalloc FActorEndCursorOverSignature.__FActorEndCursorOverSignature_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FActorEndCursorOverSignature.__FActorEndCursorOverSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FActorEndCursorOverSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->TouchedActor = ((TouchedActor != null) ? TouchedActor.NativePtr : IntPtr.Zero);
			FSparseDelegate.BroadcastInternal(base.GetOwner().NativePtr, this.DelegateName, (void*)ptr);
		}

		// Token: 0x06006A16 RID: 27158 RVA: 0x00098698 File Offset: 0x00096898
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<AActor> action = target as Action<AActor>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FActorEndCursorOverSignature.__FActorEndCursorOverSignature_DelegateParams*)__Parameters)->TouchedActor);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x0400331F RID: 13087
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003320 RID: 13088
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ActorEndCursorOverSignature__DelegateSignature";

		// Token: 0x04003321 RID: 13089
		private static int RegisterId;

		// Token: 0x02002C6F RID: 11375
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FActorEndCursorOverSignature_DelegateParams
		{
			// Token: 0x0401659E RID: 91550
			[FieldOffset(0)]
			public IntPtr TouchedActor;
		}

		// Token: 0x02002C70 RID: 11376
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401659F RID: 91551
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
