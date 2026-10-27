using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007A7 RID: 1959
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)]
	public sealed class FActorBeginCursorOverSignature : FSparseDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06006840 RID: 26688 RVA: 0x00094F39 File Offset: 0x00093139
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FActorBeginCursorOverSignature.StaticFunctionPtr();
		}

		// Token: 0x06006841 RID: 26689 RVA: 0x00094F45 File Offset: 0x00093145
		private static IntPtr StaticFunctionPtr()
		{
			if (FActorBeginCursorOverSignature._FunctionPtr == IntPtr.Zero)
			{
				FActorBeginCursorOverSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ActorBeginCursorOverSignature__DelegateSignature");
			}
			return FActorBeginCursorOverSignature._FunctionPtr;
		}

		// Token: 0x1700189F RID: 6303
		// (get) Token: 0x06006842 RID: 26690 RVA: 0x00094F68 File Offset: 0x00093168
		public override FName DelegateName
		{
			get
			{
				return FNameStatic.OnBeginCursorOver;
			}
		}

		// Token: 0x06006843 RID: 26691 RVA: 0x00094F6F File Offset: 0x0009316F
		[NullableContext(2)]
		public FActorBeginCursorOverSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006844 RID: 26692 RVA: 0x00094F79 File Offset: 0x00093179
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<AActor>) ?? ((Action<AActor>)Delegate.CreateDelegate(typeof(Action<AActor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06006845 RID: 26693 RVA: 0x00094FAC File Offset: 0x000931AC
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<AActor> Callback)
		{
			if (FActorBeginCursorOverSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FActorBeginCursorOverSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FActorBeginCursorOverSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FActorBeginCursorOverSignature.OnScriptCallback));
				}
				FActorBeginCursorOverSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			FName delegateName = this.DelegateName;
			base.Add(delegateName, Callback, FActorBeginCursorOverSignature.RegisterId);
		}

		// Token: 0x06006846 RID: 26694 RVA: 0x00094FFC File Offset: 0x000931FC
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

		// Token: 0x06006847 RID: 26695 RVA: 0x0009501C File Offset: 0x0009321C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(AActor TouchedActor)
		{
			FActorBeginCursorOverSignature.__FActorBeginCursorOverSignature_DelegateParams* ptr = stackalloc FActorBeginCursorOverSignature.__FActorBeginCursorOverSignature_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FActorBeginCursorOverSignature.__FActorBeginCursorOverSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FActorBeginCursorOverSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->TouchedActor = ((TouchedActor != null) ? TouchedActor.NativePtr : IntPtr.Zero);
			FSparseDelegate.BroadcastInternal(base.GetOwner().NativePtr, this.DelegateName, (void*)ptr);
		}

		// Token: 0x06006848 RID: 26696 RVA: 0x00095078 File Offset: 0x00093278
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
			AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FActorBeginCursorOverSignature.__FActorBeginCursorOverSignature_DelegateParams*)__Parameters)->TouchedActor);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x04003223 RID: 12835
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003224 RID: 12836
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ActorBeginCursorOverSignature__DelegateSignature";

		// Token: 0x04003225 RID: 12837
		private static int RegisterId;

		// Token: 0x02002C61 RID: 11361
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FActorBeginCursorOverSignature_DelegateParams
		{
			// Token: 0x0401658D RID: 91533
			[FieldOffset(0)]
			public IntPtr TouchedActor;
		}

		// Token: 0x02002C62 RID: 11362
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401658E RID: 91534
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
