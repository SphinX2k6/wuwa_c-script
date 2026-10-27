using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003A9 RID: 937
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FARGetCandidateObjectPin : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060033FD RID: 13309 RVA: 0x0004F799 File Offset: 0x0004D999
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FARGetCandidateObjectPin.StaticFunctionPtr();
		}

		// Token: 0x060033FE RID: 13310 RVA: 0x0004F7A5 File Offset: 0x0004D9A5
		private static IntPtr StaticFunctionPtr()
		{
			if (FARGetCandidateObjectPin._FunctionPtr == IntPtr.Zero)
			{
				FARGetCandidateObjectPin._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/AugmentedReality.ARGetCandidateObjectPin__DelegateSignature");
			}
			return FARGetCandidateObjectPin._FunctionPtr;
		}

		// Token: 0x060033FF RID: 13311 RVA: 0x0004F7C8 File Offset: 0x0004D9C8
		public FARGetCandidateObjectPin()
		{
		}

		// Token: 0x06003400 RID: 13312 RVA: 0x0004F7D0 File Offset: 0x0004D9D0
		[NullableContext(2)]
		public FARGetCandidateObjectPin(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003401 RID: 13313 RVA: 0x0004F7DA File Offset: 0x0004D9DA
		public FARGetCandidateObjectPin(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003402 RID: 13314 RVA: 0x0004F7E5 File Offset: 0x0004D9E5
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UARCandidateObject>) ?? ((Action<UARCandidateObject>)Delegate.CreateDelegate(typeof(Action<UARCandidateObject>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06003403 RID: 13315 RVA: 0x0004F817 File Offset: 0x0004DA17
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<UARCandidateObject> Callback)
		{
			if (FARGetCandidateObjectPin.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FARGetCandidateObjectPin.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FARGetCandidateObjectPin.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FARGetCandidateObjectPin.OnScriptCallback));
				}
				FARGetCandidateObjectPin.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FARGetCandidateObjectPin.RegisterId);
		}

		// Token: 0x06003404 RID: 13316 RVA: 0x0004F851 File Offset: 0x0004DA51
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UARCandidateObject> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06003405 RID: 13317 RVA: 0x0004F85C File Offset: 0x0004DA5C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UARCandidateObject SavedObject)
		{
			FARGetCandidateObjectPin.__FARGetCandidateObjectPin_DelegateParams* ptr = stackalloc FARGetCandidateObjectPin.__FARGetCandidateObjectPin_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FARGetCandidateObjectPin.__FARGetCandidateObjectPin_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FARGetCandidateObjectPin.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->SavedObject = ((SavedObject != null) ? SavedObject.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06003406 RID: 13318 RVA: 0x0004F8A8 File Offset: 0x0004DAA8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UARCandidateObject> action = target as Action<UARCandidateObject>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UARCandidateObject orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UARCandidateObject>(((FARGetCandidateObjectPin.__FARGetCandidateObjectPin_DelegateParams*)__Parameters)->SavedObject);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x04001690 RID: 5776
		internal static IntPtr _FunctionPtr;

		// Token: 0x04001691 RID: 5777
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AugmentedReality.ARGetCandidateObjectPin__DelegateSignature";

		// Token: 0x04001692 RID: 5778
		private static int RegisterId;

		// Token: 0x02002C0A RID: 11274
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FARGetCandidateObjectPin_DelegateParams
		{
			// Token: 0x0401650E RID: 91406
			[FieldOffset(0)]
			public IntPtr SavedObject;
		}

		// Token: 0x02002C0B RID: 11275
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401650F RID: 91407
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
