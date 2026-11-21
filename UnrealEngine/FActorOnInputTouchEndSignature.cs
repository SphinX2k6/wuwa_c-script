using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000170 RID: 368
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)]
	public sealed class FActorOnInputTouchEndSignature : FSparseDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06001691 RID: 5777 RVA: 0x000231F7 File Offset: 0x000213F7
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FActorOnInputTouchEndSignature.StaticFunctionPtr();
		}

		// Token: 0x06001692 RID: 5778 RVA: 0x00023203 File Offset: 0x00021403
		private static IntPtr StaticFunctionPtr()
		{
			if (FActorOnInputTouchEndSignature._FunctionPtr == IntPtr.Zero)
			{
				FActorOnInputTouchEndSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ActorOnInputTouchEndSignature__DelegateSignature");
			}
			return FActorOnInputTouchEndSignature._FunctionPtr;
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06001693 RID: 5779 RVA: 0x00023226 File Offset: 0x00021426
		public override FName DelegateName
		{
			get
			{
				return FNameStatic.OnInputTouchEnd;
			}
		}

		// Token: 0x06001694 RID: 5780 RVA: 0x0002322D File Offset: 0x0002142D
		[NullableContext(2)]
		public FActorOnInputTouchEndSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001695 RID: 5781 RVA: 0x00023237 File Offset: 0x00021437
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<TEnumAsByte<ETouchIndex>, AActor>) ?? ((Action<TEnumAsByte<ETouchIndex>, AActor>)Delegate.CreateDelegate(typeof(Action<TEnumAsByte<ETouchIndex>, AActor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06001696 RID: 5782 RVA: 0x0002326C File Offset: 0x0002146C
		public void Add([Nullable(new byte[]
		{
			1,
			0,
			2
		})] Action<TEnumAsByte<ETouchIndex>, AActor> Callback)
		{
			if (FActorOnInputTouchEndSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FActorOnInputTouchEndSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FActorOnInputTouchEndSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FActorOnInputTouchEndSignature.OnScriptCallback));
				}
				FActorOnInputTouchEndSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			FName delegateName = this.DelegateName;
			base.Add(delegateName, Callback, FActorOnInputTouchEndSignature.RegisterId);
		}

		// Token: 0x06001697 RID: 5783 RVA: 0x000232BC File Offset: 0x000214BC
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

		// Token: 0x06001698 RID: 5784 RVA: 0x000232DC File Offset: 0x000214DC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(ETouchIndex FingerIndex, AActor TouchedActor)
		{
			FActorOnInputTouchEndSignature.__FActorOnInputTouchEndSignature_DelegateParams* ptr = stackalloc FActorOnInputTouchEndSignature.__FActorOnInputTouchEndSignature_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FActorOnInputTouchEndSignature.__FActorOnInputTouchEndSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FActorOnInputTouchEndSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->FingerIndex = FingerIndex;
			ptr->TouchedActor = ((TouchedActor != null) ? TouchedActor.NativePtr : IntPtr.Zero);
			FSparseDelegate.BroadcastInternal(base.GetOwner().NativePtr, this.DelegateName, (void*)ptr);
		}

		// Token: 0x06001699 RID: 5785 RVA: 0x00023344 File Offset: 0x00021544
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<TEnumAsByte<ETouchIndex>, AActor> action = target as Action<TEnumAsByte<ETouchIndex>, AActor>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FActorOnInputTouchEndSignature.__FActorOnInputTouchEndSignature_DelegateParams*)__Parameters)->TouchedActor);
			action(((FActorOnInputTouchEndSignature.__FActorOnInputTouchEndSignature_DelegateParams*)__Parameters)->FingerIndex, orCreateUObjectByNativePointer);
		}

		// Token: 0x0400072E RID: 1838
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400072F RID: 1839
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ActorOnInputTouchEndSignature__DelegateSignature";

		// Token: 0x04000730 RID: 1840
		private static int RegisterId;

		// Token: 0x02000960 RID: 2400
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FActorOnInputTouchEndSignature_DelegateParams
		{
			// Token: 0x0400588A RID: 22666
			[FieldOffset(0)]
			public TEnumAsByte<ETouchIndex> FingerIndex;

			// Token: 0x0400588B RID: 22667
			[FieldOffset(8)]
			public IntPtr TouchedActor;
		}

		// Token: 0x02000961 RID: 2401
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400588C RID: 22668
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
