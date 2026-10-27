using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007A9 RID: 1961
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)]
	public sealed class FActorBeginTouchOverSignature : FSparseDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06006852 RID: 26706 RVA: 0x0009527F File Offset: 0x0009347F
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FActorBeginTouchOverSignature.StaticFunctionPtr();
		}

		// Token: 0x06006853 RID: 26707 RVA: 0x0009528B File Offset: 0x0009348B
		private static IntPtr StaticFunctionPtr()
		{
			if (FActorBeginTouchOverSignature._FunctionPtr == IntPtr.Zero)
			{
				FActorBeginTouchOverSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ActorBeginTouchOverSignature__DelegateSignature");
			}
			return FActorBeginTouchOverSignature._FunctionPtr;
		}

		// Token: 0x170018A1 RID: 6305
		// (get) Token: 0x06006854 RID: 26708 RVA: 0x000952AE File Offset: 0x000934AE
		public override FName DelegateName
		{
			get
			{
				return FNameStatic.OnInputTouchEnter;
			}
		}

		// Token: 0x06006855 RID: 26709 RVA: 0x000952B5 File Offset: 0x000934B5
		[NullableContext(2)]
		public FActorBeginTouchOverSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006856 RID: 26710 RVA: 0x000952BF File Offset: 0x000934BF
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<TEnumAsByte<ETouchIndex>, AActor>) ?? ((Action<TEnumAsByte<ETouchIndex>, AActor>)Delegate.CreateDelegate(typeof(Action<TEnumAsByte<ETouchIndex>, AActor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06006857 RID: 26711 RVA: 0x000952F4 File Offset: 0x000934F4
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06006858 RID: 26712 RVA: 0x00095344 File Offset: 0x00093544
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

		// Token: 0x06006859 RID: 26713 RVA: 0x00095364 File Offset: 0x00093564
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(ETouchIndex FingerIndex, AActor TouchedActor)
		{
			FActorBeginTouchOverSignature.__FActorBeginTouchOverSignature_DelegateParams* ptr = stackalloc FActorBeginTouchOverSignature.__FActorBeginTouchOverSignature_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FActorBeginTouchOverSignature.__FActorBeginTouchOverSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FActorBeginTouchOverSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->FingerIndex = FingerIndex;
			ptr->TouchedActor = ((TouchedActor != null) ? TouchedActor.NativePtr : IntPtr.Zero);
			FSparseDelegate.BroadcastInternal(base.GetOwner().NativePtr, this.DelegateName, (void*)ptr);
		}

		// Token: 0x0600685A RID: 26714 RVA: 0x000953CC File Offset: 0x000935CC
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
			AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FActorBeginTouchOverSignature.__FActorBeginTouchOverSignature_DelegateParams*)__Parameters)->TouchedActor);
			action(((FActorBeginTouchOverSignature.__FActorBeginTouchOverSignature_DelegateParams*)__Parameters)->FingerIndex, orCreateUObjectByNativePointer);
		}

		// Token: 0x04003229 RID: 12841
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400322A RID: 12842
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ActorBeginTouchOverSignature__DelegateSignature";

		// Token: 0x0400322B RID: 12843
		private static int RegisterId;

		// Token: 0x02002C65 RID: 11365
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FActorBeginTouchOverSignature_DelegateParams
		{
			// Token: 0x04016592 RID: 91538
			[FieldOffset(0)]
			public TEnumAsByte<ETouchIndex> FingerIndex;

			// Token: 0x04016593 RID: 91539
			[FieldOffset(8)]
			public IntPtr TouchedActor;
		}

		// Token: 0x02002C66 RID: 11366
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016594 RID: 91540
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
