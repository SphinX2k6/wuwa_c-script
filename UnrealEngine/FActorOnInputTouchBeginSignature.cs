using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007C7 RID: 1991
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)]
	public sealed class FActorOnInputTouchBeginSignature : FSparseDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06006A4B RID: 27211 RVA: 0x0009901E File Offset: 0x0009721E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FActorOnInputTouchBeginSignature.StaticFunctionPtr();
		}

		// Token: 0x06006A4C RID: 27212 RVA: 0x0009902A File Offset: 0x0009722A
		private static IntPtr StaticFunctionPtr()
		{
			if (FActorOnInputTouchBeginSignature._FunctionPtr == IntPtr.Zero)
			{
				FActorOnInputTouchBeginSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ActorOnInputTouchBeginSignature__DelegateSignature");
			}
			return FActorOnInputTouchBeginSignature._FunctionPtr;
		}

		// Token: 0x17001918 RID: 6424
		// (get) Token: 0x06006A4D RID: 27213 RVA: 0x0009904D File Offset: 0x0009724D
		public override FName DelegateName
		{
			get
			{
				return FNameStatic.OnInputTouchBegin;
			}
		}

		// Token: 0x06006A4E RID: 27214 RVA: 0x00099054 File Offset: 0x00097254
		[NullableContext(2)]
		public FActorOnInputTouchBeginSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006A4F RID: 27215 RVA: 0x0009905E File Offset: 0x0009725E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<TEnumAsByte<ETouchIndex>, AActor>) ?? ((Action<TEnumAsByte<ETouchIndex>, AActor>)Delegate.CreateDelegate(typeof(Action<TEnumAsByte<ETouchIndex>, AActor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06006A50 RID: 27216 RVA: 0x00099090 File Offset: 0x00097290
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			0,
			2
		})] Action<TEnumAsByte<ETouchIndex>, AActor> Callback)
		{
			if (FActorOnInputTouchBeginSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FActorOnInputTouchBeginSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FActorOnInputTouchBeginSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FActorOnInputTouchBeginSignature.OnScriptCallback));
				}
				FActorOnInputTouchBeginSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			FName delegateName = this.DelegateName;
			base.Add(delegateName, Callback, FActorOnInputTouchBeginSignature.RegisterId);
		}

		// Token: 0x06006A51 RID: 27217 RVA: 0x000990E0 File Offset: 0x000972E0
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

		// Token: 0x06006A52 RID: 27218 RVA: 0x00099100 File Offset: 0x00097300
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(ETouchIndex FingerIndex, AActor TouchedActor)
		{
			FActorOnInputTouchBeginSignature.__FActorOnInputTouchBeginSignature_DelegateParams* ptr = stackalloc FActorOnInputTouchBeginSignature.__FActorOnInputTouchBeginSignature_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FActorOnInputTouchBeginSignature.__FActorOnInputTouchBeginSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FActorOnInputTouchBeginSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->FingerIndex = FingerIndex;
			ptr->TouchedActor = ((TouchedActor != null) ? TouchedActor.NativePtr : IntPtr.Zero);
			FSparseDelegate.BroadcastInternal(base.GetOwner().NativePtr, this.DelegateName, (void*)ptr);
		}

		// Token: 0x06006A53 RID: 27219 RVA: 0x00099168 File Offset: 0x00097368
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
			AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FActorOnInputTouchBeginSignature.__FActorOnInputTouchBeginSignature_DelegateParams*)__Parameters)->TouchedActor);
			action(((FActorOnInputTouchBeginSignature.__FActorOnInputTouchBeginSignature_DelegateParams*)__Parameters)->FingerIndex, orCreateUObjectByNativePointer);
		}

		// Token: 0x04003333 RID: 13107
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003334 RID: 13108
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ActorOnInputTouchBeginSignature__DelegateSignature";

		// Token: 0x04003335 RID: 13109
		private static int RegisterId;

		// Token: 0x02002C7B RID: 11387
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FActorOnInputTouchBeginSignature_DelegateParams
		{
			// Token: 0x040165B1 RID: 91569
			[FieldOffset(0)]
			public TEnumAsByte<ETouchIndex> FingerIndex;

			// Token: 0x040165B2 RID: 91570
			[FieldOffset(8)]
			public IntPtr TouchedActor;
		}

		// Token: 0x02002C7C RID: 11388
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040165B3 RID: 91571
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
