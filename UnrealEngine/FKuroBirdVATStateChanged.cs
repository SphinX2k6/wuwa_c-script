using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001AB5 RID: 6837
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FKuroBirdVATStateChanged : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060195F7 RID: 103927 RVA: 0x00257D72 File Offset: 0x00255F72
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroBirdVATStateChanged.StaticFunctionPtr();
		}

		// Token: 0x060195F8 RID: 103928 RVA: 0x00257D7E File Offset: 0x00255F7E
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroBirdVATStateChanged._FunctionPtr == IntPtr.Zero)
			{
				FKuroBirdVATStateChanged._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroBirdVATStateChanged__DelegateSignature");
			}
			return FKuroBirdVATStateChanged._FunctionPtr;
		}

		// Token: 0x060195F9 RID: 103929 RVA: 0x00257DA1 File Offset: 0x00255FA1
		public FKuroBirdVATStateChanged()
		{
		}

		// Token: 0x060195FA RID: 103930 RVA: 0x00257DA9 File Offset: 0x00255FA9
		[NullableContext(2)]
		public FKuroBirdVATStateChanged(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060195FB RID: 103931 RVA: 0x00257DB3 File Offset: 0x00255FB3
		public FKuroBirdVATStateChanged(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060195FC RID: 103932 RVA: 0x00257DBE File Offset: 0x00255FBE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<EBirdVATState>) ?? ((Action<EBirdVATState>)Delegate.CreateDelegate(typeof(Action<EBirdVATState>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060195FD RID: 103933 RVA: 0x00257DF0 File Offset: 0x00255FF0
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<EBirdVATState> Callback)
		{
			if (FKuroBirdVATStateChanged.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FKuroBirdVATStateChanged.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FKuroBirdVATStateChanged.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FKuroBirdVATStateChanged.OnScriptCallback));
				}
				FKuroBirdVATStateChanged.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FKuroBirdVATStateChanged.RegisterId);
		}

		// Token: 0x060195FE RID: 103934 RVA: 0x00257E2A File Offset: 0x0025602A
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<EBirdVATState> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060195FF RID: 103935 RVA: 0x00257E34 File Offset: 0x00256034
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(EBirdVATState NewState)
		{
			FKuroBirdVATStateChanged.__FKuroBirdVATStateChanged_DelegateParams* ptr = stackalloc FKuroBirdVATStateChanged.__FKuroBirdVATStateChanged_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FKuroBirdVATStateChanged.__FKuroBirdVATStateChanged_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FKuroBirdVATStateChanged.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->NewState = NewState;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06019600 RID: 103936 RVA: 0x00257E70 File Offset: 0x00256070
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<EBirdVATState> action = target as Action<EBirdVATState>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FKuroBirdVATStateChanged.__FKuroBirdVATStateChanged_DelegateParams*)__Parameters)->NewState);
		}

		// Token: 0x0400DD39 RID: 56633
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400DD3A RID: 56634
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroBirdVATStateChanged__DelegateSignature";

		// Token: 0x0400DD3B RID: 56635
		private static int RegisterId;

		// Token: 0x02003135 RID: 12597
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __FKuroBirdVATStateChanged_DelegateParams
		{
			// Token: 0x04016F45 RID: 94021
			[FieldOffset(0)]
			public EBirdVATState NewState;
		}

		// Token: 0x02003136 RID: 12598
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016F46 RID: 94022
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
