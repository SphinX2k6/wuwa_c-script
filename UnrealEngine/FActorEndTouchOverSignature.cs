using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007C3 RID: 1987
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)]
	public sealed class FActorEndTouchOverSignature : FSparseDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06006A29 RID: 27177 RVA: 0x00098A43 File Offset: 0x00096C43
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FActorEndTouchOverSignature.StaticFunctionPtr();
		}

		// Token: 0x06006A2A RID: 27178 RVA: 0x00098A4F File Offset: 0x00096C4F
		private static IntPtr StaticFunctionPtr()
		{
			if (FActorEndTouchOverSignature._FunctionPtr == IntPtr.Zero)
			{
				FActorEndTouchOverSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ActorEndTouchOverSignature__DelegateSignature");
			}
			return FActorEndTouchOverSignature._FunctionPtr;
		}

		// Token: 0x17001915 RID: 6421
		// (get) Token: 0x06006A2B RID: 27179 RVA: 0x00098A72 File Offset: 0x00096C72
		public override FName DelegateName
		{
			get
			{
				return FNameStatic.OnInputTouchLeave;
			}
		}

		// Token: 0x06006A2C RID: 27180 RVA: 0x00098A79 File Offset: 0x00096C79
		[NullableContext(2)]
		public FActorEndTouchOverSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006A2D RID: 27181 RVA: 0x00098A83 File Offset: 0x00096C83
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<TEnumAsByte<ETouchIndex>, AActor>) ?? ((Action<TEnumAsByte<ETouchIndex>, AActor>)Delegate.CreateDelegate(typeof(Action<TEnumAsByte<ETouchIndex>, AActor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06006A2E RID: 27182 RVA: 0x00098AB8 File Offset: 0x00096CB8
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			0,
			2
		})] Action<TEnumAsByte<ETouchIndex>, AActor> Callback)
		{
			if (FActorEndTouchOverSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FActorEndTouchOverSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FActorEndTouchOverSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FActorEndTouchOverSignature.OnScriptCallback));
				}
				FActorEndTouchOverSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			FName delegateName = this.DelegateName;
			base.Add(delegateName, Callback, FActorEndTouchOverSignature.RegisterId);
		}

		// Token: 0x06006A2F RID: 27183 RVA: 0x00098B08 File Offset: 0x00096D08
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			0,
			2
		})] Action<TEnumAsByte<ETouchIndex>, AActor> Callback)
		{
			FName delegateName = this.DelegateName;
			base.Remove(delegateName, Callback);
		}

		// Token: 0x06006A30 RID: 27184 RVA: 0x00098B28 File Offset: 0x00096D28
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(ETouchIndex FingerIndex, AActor TouchedActor)
		{
			FActorEndTouchOverSignature.__FActorEndTouchOverSignature_DelegateParams* ptr = stackalloc FActorEndTouchOverSignature.__FActorEndTouchOverSignature_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FActorEndTouchOverSignature.__FActorEndTouchOverSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FActorEndTouchOverSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->FingerIndex = FingerIndex;
			ptr->TouchedActor = ((TouchedActor != null) ? TouchedActor.NativePtr : IntPtr.Zero);
			FSparseDelegate.BroadcastInternal(base.GetOwner().NativePtr, this.DelegateName, (void*)ptr);
		}

		// Token: 0x06006A31 RID: 27185 RVA: 0x00098B90 File Offset: 0x00096D90
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<TEnumAsByte<ETouchIndex>, AActor> action = target as Action<TEnumAsByte<ETouchIndex>, AActor>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FActorEndTouchOverSignature.__FActorEndTouchOverSignature_DelegateParams*)__Parameters)->TouchedActor);
			action(((FActorEndTouchOverSignature.__FActorEndTouchOverSignature_DelegateParams*)__Parameters)->FingerIndex, orCreateUObjectByNativePointer);
		}

		// Token: 0x04003328 RID: 13096
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003329 RID: 13097
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ActorEndTouchOverSignature__DelegateSignature";

		// Token: 0x0400332A RID: 13098
		private static int RegisterId;

		// Token: 0x02002C75 RID: 11381
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FActorEndTouchOverSignature_DelegateParams
		{
			// Token: 0x040165A6 RID: 91558
			[FieldOffset(0)]
			public TEnumAsByte<ETouchIndex> FingerIndex;

			// Token: 0x040165A7 RID: 91559
			[FieldOffset(8)]
			public IntPtr TouchedActor;
		}

		// Token: 0x02002C76 RID: 11382
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040165A8 RID: 91560
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
