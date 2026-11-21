using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200016F RID: 367
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)]
	public sealed class FActorOnInputTouchBeginSignature : FSparseDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06001688 RID: 5768 RVA: 0x00023056 File Offset: 0x00021256
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FActorOnInputTouchBeginSignature.StaticFunctionPtr();
		}

		// Token: 0x06001689 RID: 5769 RVA: 0x00023062 File Offset: 0x00021262
		private static IntPtr StaticFunctionPtr()
		{
			if (FActorOnInputTouchBeginSignature._FunctionPtr == IntPtr.Zero)
			{
				FActorOnInputTouchBeginSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ActorOnInputTouchBeginSignature__DelegateSignature");
			}
			return FActorOnInputTouchBeginSignature._FunctionPtr;
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x0600168A RID: 5770 RVA: 0x00023085 File Offset: 0x00021285
		public override FName DelegateName
		{
			get
			{
				return FNameStatic.OnInputTouchBegin;
			}
		}

		// Token: 0x0600168B RID: 5771 RVA: 0x0002308C File Offset: 0x0002128C
		[NullableContext(2)]
		public FActorOnInputTouchBeginSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600168C RID: 5772 RVA: 0x00023096 File Offset: 0x00021296
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<TEnumAsByte<ETouchIndex>, AActor>) ?? ((Action<TEnumAsByte<ETouchIndex>, AActor>)Delegate.CreateDelegate(typeof(Action<TEnumAsByte<ETouchIndex>, AActor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600168D RID: 5773 RVA: 0x000230C8 File Offset: 0x000212C8
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

		// Token: 0x0600168E RID: 5774 RVA: 0x00023118 File Offset: 0x00021318
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

		// Token: 0x0600168F RID: 5775 RVA: 0x00023138 File Offset: 0x00021338
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(ETouchIndex FingerIndex, AActor TouchedActor)
		{
			FActorOnInputTouchBeginSignature.__FActorOnInputTouchBeginSignature_DelegateParams* ptr = stackalloc FActorOnInputTouchBeginSignature.__FActorOnInputTouchBeginSignature_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FActorOnInputTouchBeginSignature.__FActorOnInputTouchBeginSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FActorOnInputTouchBeginSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->FingerIndex = FingerIndex;
			ptr->TouchedActor = ((TouchedActor != null) ? TouchedActor.NativePtr : IntPtr.Zero);
			FSparseDelegate.BroadcastInternal(base.GetOwner().NativePtr, this.DelegateName, (void*)ptr);
		}

		// Token: 0x06001690 RID: 5776 RVA: 0x000231A0 File Offset: 0x000213A0
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x0400072B RID: 1835
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400072C RID: 1836
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ActorOnInputTouchBeginSignature__DelegateSignature";

		// Token: 0x0400072D RID: 1837
		private static int RegisterId;

		// Token: 0x0200095E RID: 2398
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FActorOnInputTouchBeginSignature_DelegateParams
		{
			// Token: 0x04005887 RID: 22663
			[FieldOffset(0)]
			public TEnumAsByte<ETouchIndex> FingerIndex;

			// Token: 0x04005888 RID: 22664
			[FieldOffset(8)]
			public IntPtr TouchedActor;
		}

		// Token: 0x0200095F RID: 2399
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005889 RID: 22665
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
