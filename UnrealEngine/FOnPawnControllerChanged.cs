using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F1F RID: 3871
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnPawnControllerChanged : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600D117 RID: 53527 RVA: 0x00131CD1 File Offset: 0x0012FED1
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnPawnControllerChanged.StaticFunctionPtr();
		}

		// Token: 0x0600D118 RID: 53528 RVA: 0x00131CDD File Offset: 0x0012FEDD
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnPawnControllerChanged._FunctionPtr == IntPtr.Zero)
			{
				FOnPawnControllerChanged._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.OnPawnControllerChanged__DelegateSignature");
			}
			return FOnPawnControllerChanged._FunctionPtr;
		}

		// Token: 0x0600D119 RID: 53529 RVA: 0x00131D00 File Offset: 0x0012FF00
		public FOnPawnControllerChanged()
		{
		}

		// Token: 0x0600D11A RID: 53530 RVA: 0x00131D08 File Offset: 0x0012FF08
		[NullableContext(2)]
		public FOnPawnControllerChanged(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600D11B RID: 53531 RVA: 0x00131D12 File Offset: 0x0012FF12
		public FOnPawnControllerChanged(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600D11C RID: 53532 RVA: 0x00131D1D File Offset: 0x0012FF1D
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<APawn, AController>) ?? ((Action<APawn, AController>)Delegate.CreateDelegate(typeof(Action<APawn, AController>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600D11D RID: 53533 RVA: 0x00131D4F File Offset: 0x0012FF4F
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2,
			2
		})] Action<APawn, AController> Callback)
		{
			if (FOnPawnControllerChanged.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnPawnControllerChanged.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnPawnControllerChanged.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnPawnControllerChanged.OnScriptCallback));
				}
				FOnPawnControllerChanged.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnPawnControllerChanged.RegisterId);
		}

		// Token: 0x0600D11E RID: 53534 RVA: 0x00131D89 File Offset: 0x0012FF89
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2,
			2
		})] Action<APawn, AController> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600D11F RID: 53535 RVA: 0x00131D94 File Offset: 0x0012FF94
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(APawn Pawn, AController Controller)
		{
			FOnPawnControllerChanged.__FOnPawnControllerChanged_DelegateParams* ptr = stackalloc FOnPawnControllerChanged.__FOnPawnControllerChanged_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnPawnControllerChanged.__FOnPawnControllerChanged_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnPawnControllerChanged.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Pawn = ((Pawn != null) ? Pawn.NativePtr : IntPtr.Zero);
			ptr->Controller = ((Controller != null) ? Controller.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600D120 RID: 53536 RVA: 0x00131DF8 File Offset: 0x0012FFF8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<APawn, AController> action = target as Action<APawn, AController>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			APawn orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(((FOnPawnControllerChanged.__FOnPawnControllerChanged_DelegateParams*)__Parameters)->Pawn);
			AController orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<AController>(((FOnPawnControllerChanged.__FOnPawnControllerChanged_DelegateParams*)__Parameters)->Controller);
			action(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
		}

		// Token: 0x0400706B RID: 28779
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400706C RID: 28780
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.OnPawnControllerChanged__DelegateSignature";

		// Token: 0x0400706D RID: 28781
		private static int RegisterId;

		// Token: 0x02002D86 RID: 11654
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FOnPawnControllerChanged_DelegateParams
		{
			// Token: 0x040167A9 RID: 92073
			[FieldOffset(0)]
			public IntPtr Pawn;

			// Token: 0x040167AA RID: 92074
			[FieldOffset(8)]
			public IntPtr Controller;
		}

		// Token: 0x02002D87 RID: 11655
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040167AB RID: 92075
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
