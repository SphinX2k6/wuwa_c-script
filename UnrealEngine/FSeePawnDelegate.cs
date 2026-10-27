using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001DF RID: 479
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSeePawnDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06001C54 RID: 7252 RVA: 0x0002A3F3 File Offset: 0x000285F3
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSeePawnDelegate.StaticFunctionPtr();
		}

		// Token: 0x06001C55 RID: 7253 RVA: 0x0002A3FF File Offset: 0x000285FF
		private static IntPtr StaticFunctionPtr()
		{
			if (UPawnSensingComponent.__SeePawnDelegate__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UPawnSensingComponent.__SeePawnDelegate__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/AIModule.PawnSensingComponent:SeePawnDelegate__DelegateSignature");
			}
			return UPawnSensingComponent.__SeePawnDelegate__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x06001C56 RID: 7254 RVA: 0x0002A422 File Offset: 0x00028622
		public FSeePawnDelegate()
		{
		}

		// Token: 0x06001C57 RID: 7255 RVA: 0x0002A42A File Offset: 0x0002862A
		[NullableContext(2)]
		public FSeePawnDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001C58 RID: 7256 RVA: 0x0002A434 File Offset: 0x00028634
		public FSeePawnDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06001C59 RID: 7257 RVA: 0x0002A43F File Offset: 0x0002863F
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<APawn>) ?? ((Action<APawn>)Delegate.CreateDelegate(typeof(Action<APawn>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06001C5A RID: 7258 RVA: 0x0002A471 File Offset: 0x00028671
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<APawn> Callback)
		{
			if (FSeePawnDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSeePawnDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSeePawnDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSeePawnDelegate.OnScriptCallback));
				}
				FSeePawnDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSeePawnDelegate.RegisterId);
		}

		// Token: 0x06001C5B RID: 7259 RVA: 0x0002A4AB File Offset: 0x000286AB
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<APawn> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06001C5C RID: 7260 RVA: 0x0002A4B4 File Offset: 0x000286B4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(APawn Pawn)
		{
			FSeePawnDelegate.__FSeePawnDelegate_DelegateParams* ptr = stackalloc FSeePawnDelegate.__FSeePawnDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FSeePawnDelegate.__FSeePawnDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSeePawnDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Pawn = ((Pawn != null) ? Pawn.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06001C5D RID: 7261 RVA: 0x0002A500 File Offset: 0x00028700
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<APawn> action = target as Action<APawn>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			APawn orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(((FSeePawnDelegate.__FSeePawnDelegate_DelegateParams*)__Parameters)->Pawn);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x0400093B RID: 2363
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AIModule.PawnSensingComponent:SeePawnDelegate__DelegateSignature";

		// Token: 0x0400093C RID: 2364
		private static int RegisterId;

		// Token: 0x02002B79 RID: 11129
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FSeePawnDelegate_DelegateParams
		{
			// Token: 0x04016403 RID: 91139
			[FieldOffset(0)]
			public IntPtr Pawn;
		}

		// Token: 0x02002B7A RID: 11130
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016404 RID: 91140
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
