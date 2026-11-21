using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000163 RID: 355
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)]
	public sealed class FActorBeginTouchOverSignature : FSparseDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060015C9 RID: 5577 RVA: 0x000218BB File Offset: 0x0001FABB
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FActorBeginTouchOverSignature.StaticFunctionPtr();
		}

		// Token: 0x060015CA RID: 5578 RVA: 0x000218C7 File Offset: 0x0001FAC7
		private static IntPtr StaticFunctionPtr()
		{
			if (FActorBeginTouchOverSignature._FunctionPtr == IntPtr.Zero)
			{
				FActorBeginTouchOverSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ActorBeginTouchOverSignature__DelegateSignature");
			}
			return FActorBeginTouchOverSignature._FunctionPtr;
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x060015CB RID: 5579 RVA: 0x000218EA File Offset: 0x0001FAEA
		public override FName DelegateName
		{
			get
			{
				return FNameStatic.OnInputTouchEnter;
			}
		}

		// Token: 0x060015CC RID: 5580 RVA: 0x000218F1 File Offset: 0x0001FAF1
		[NullableContext(2)]
		public FActorBeginTouchOverSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060015CD RID: 5581 RVA: 0x000218FB File Offset: 0x0001FAFB
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<TEnumAsByte<ETouchIndex>, AActor>) ?? ((Action<TEnumAsByte<ETouchIndex>, AActor>)Delegate.CreateDelegate(typeof(Action<TEnumAsByte<ETouchIndex>, AActor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060015CE RID: 5582 RVA: 0x00021930 File Offset: 0x0001FB30
		public void Add([Nullable(new byte[]
		{
			1,
			0,
			2
		})] Action<TEnumAsByte<ETouchIndex>, AActor> Callback)
		{
			if (FActorBeginTouchOverSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FActorBeginTouchOverSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FActorBeginTouchOverSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FActorBeginTouchOverSignature.OnScriptCallback));
				}
				FActorBeginTouchOverSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			FName delegateName = this.DelegateName;
			base.Add(delegateName, Callback, FActorBeginTouchOverSignature.RegisterId);
		}

		// Token: 0x060015CF RID: 5583 RVA: 0x00021980 File Offset: 0x0001FB80
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

		// Token: 0x060015D0 RID: 5584 RVA: 0x000219A0 File Offset: 0x0001FBA0
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(ETouchIndex FingerIndex, AActor TouchedActor)
		{
			FActorBeginTouchOverSignature.__FActorBeginTouchOverSignature_DelegateParams* ptr = stackalloc FActorBeginTouchOverSignature.__FActorBeginTouchOverSignature_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FActorBeginTouchOverSignature.__FActorBeginTouchOverSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FActorBeginTouchOverSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->FingerIndex = FingerIndex;
			ptr->TouchedActor = ((TouchedActor != null) ? TouchedActor.NativePtr : IntPtr.Zero);
			FSparseDelegate.BroadcastInternal(base.GetOwner().NativePtr, this.DelegateName, (void*)ptr);
		}

		// Token: 0x060015D1 RID: 5585 RVA: 0x00021A08 File Offset: 0x0001FC08
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<TEnumAsByte<ETouchIndex>, AActor> action = target as Action<TEnumAsByte<ETouchIndex>, AActor>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FActorBeginTouchOverSignature.__FActorBeginTouchOverSignature_DelegateParams*)__Parameters)->TouchedActor);
			action(((FActorBeginTouchOverSignature.__FActorBeginTouchOverSignature_DelegateParams*)__Parameters)->FingerIndex, orCreateUObjectByNativePointer);
		}

		// Token: 0x040006EC RID: 1772
		internal static IntPtr _FunctionPtr;

		// Token: 0x040006ED RID: 1773
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ActorBeginTouchOverSignature__DelegateSignature";

		// Token: 0x040006EE RID: 1774
		private static int RegisterId;

		// Token: 0x02000948 RID: 2376
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FActorBeginTouchOverSignature_DelegateParams
		{
			// Token: 0x04005868 RID: 22632
			[FieldOffset(0)]
			public TEnumAsByte<ETouchIndex> FingerIndex;

			// Token: 0x04005869 RID: 22633
			[FieldOffset(8)]
			public IntPtr TouchedActor;
		}

		// Token: 0x02000949 RID: 2377
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400586A RID: 22634
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
