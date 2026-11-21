using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200016C RID: 364
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)]
	public sealed class FActorEndTouchOverSignature : FSparseDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600166D RID: 5741 RVA: 0x00022ADB File Offset: 0x00020CDB
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FActorEndTouchOverSignature.StaticFunctionPtr();
		}

		// Token: 0x0600166E RID: 5742 RVA: 0x00022AE7 File Offset: 0x00020CE7
		private static IntPtr StaticFunctionPtr()
		{
			if (FActorEndTouchOverSignature._FunctionPtr == IntPtr.Zero)
			{
				FActorEndTouchOverSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ActorEndTouchOverSignature__DelegateSignature");
			}
			return FActorEndTouchOverSignature._FunctionPtr;
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x0600166F RID: 5743 RVA: 0x00022B0A File Offset: 0x00020D0A
		public override FName DelegateName
		{
			get
			{
				return FNameStatic.OnInputTouchLeave;
			}
		}

		// Token: 0x06001670 RID: 5744 RVA: 0x00022B11 File Offset: 0x00020D11
		[NullableContext(2)]
		public FActorEndTouchOverSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001671 RID: 5745 RVA: 0x00022B1B File Offset: 0x00020D1B
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<TEnumAsByte<ETouchIndex>, AActor>) ?? ((Action<TEnumAsByte<ETouchIndex>, AActor>)Delegate.CreateDelegate(typeof(Action<TEnumAsByte<ETouchIndex>, AActor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06001672 RID: 5746 RVA: 0x00022B50 File Offset: 0x00020D50
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

		// Token: 0x06001673 RID: 5747 RVA: 0x00022BA0 File Offset: 0x00020DA0
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

		// Token: 0x06001674 RID: 5748 RVA: 0x00022BC0 File Offset: 0x00020DC0
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(ETouchIndex FingerIndex, AActor TouchedActor)
		{
			FActorEndTouchOverSignature.__FActorEndTouchOverSignature_DelegateParams* ptr = stackalloc FActorEndTouchOverSignature.__FActorEndTouchOverSignature_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FActorEndTouchOverSignature.__FActorEndTouchOverSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FActorEndTouchOverSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->FingerIndex = FingerIndex;
			ptr->TouchedActor = ((TouchedActor != null) ? TouchedActor.NativePtr : IntPtr.Zero);
			FSparseDelegate.BroadcastInternal(base.GetOwner().NativePtr, this.DelegateName, (void*)ptr);
		}

		// Token: 0x06001675 RID: 5749 RVA: 0x00022C28 File Offset: 0x00020E28
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04000722 RID: 1826
		internal static IntPtr _FunctionPtr;

		// Token: 0x04000723 RID: 1827
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ActorEndTouchOverSignature__DelegateSignature";

		// Token: 0x04000724 RID: 1828
		private static int RegisterId;

		// Token: 0x02000958 RID: 2392
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FActorEndTouchOverSignature_DelegateParams
		{
			// Token: 0x0400587C RID: 22652
			[FieldOffset(0)]
			public TEnumAsByte<ETouchIndex> FingerIndex;

			// Token: 0x0400587D RID: 22653
			[FieldOffset(8)]
			public IntPtr TouchedActor;
		}

		// Token: 0x02000959 RID: 2393
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400587E RID: 22654
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
