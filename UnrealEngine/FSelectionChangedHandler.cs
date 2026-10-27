using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029D3 RID: 10707
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSelectionChangedHandler : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0602799E RID: 162206 RVA: 0x003C66A9 File Offset: 0x003C48A9
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSelectionChangedHandler.StaticFunctionPtr();
		}

		// Token: 0x0602799F RID: 162207 RVA: 0x003C66B5 File Offset: 0x003C48B5
		private static IntPtr StaticFunctionPtr()
		{
			if (FSelectionChangedHandler._FunctionPtr == IntPtr.Zero)
			{
				FSelectionChangedHandler._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.SelectionChangedHandler__DelegateSignature");
			}
			return FSelectionChangedHandler._FunctionPtr;
		}

		// Token: 0x060279A0 RID: 162208 RVA: 0x003C66D8 File Offset: 0x003C48D8
		public FSelectionChangedHandler()
		{
		}

		// Token: 0x060279A1 RID: 162209 RVA: 0x003C66E0 File Offset: 0x003C48E0
		[NullableContext(2)]
		public FSelectionChangedHandler(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060279A2 RID: 162210 RVA: 0x003C66EA File Offset: 0x003C48EA
		public FSelectionChangedHandler(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060279A3 RID: 162211 RVA: 0x003C66F5 File Offset: 0x003C48F5
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int, int>) ?? ((Action<int, int>)Delegate.CreateDelegate(typeof(Action<int, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060279A4 RID: 162212 RVA: 0x003C6727 File Offset: 0x003C4927
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<int, int> Callback)
		{
			if (FSelectionChangedHandler.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSelectionChangedHandler.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSelectionChangedHandler.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSelectionChangedHandler.OnScriptCallback));
				}
				FSelectionChangedHandler.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSelectionChangedHandler.RegisterId);
		}

		// Token: 0x060279A5 RID: 162213 RVA: 0x003C6761 File Offset: 0x003C4961
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<int, int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060279A6 RID: 162214 RVA: 0x003C676C File Offset: 0x003C496C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(int PreIndex, int CurrentIndex)
		{
			FSelectionChangedHandler.__FSelectionChangedHandler_DelegateParams* ptr = stackalloc FSelectionChangedHandler.__FSelectionChangedHandler_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FSelectionChangedHandler.__FSelectionChangedHandler_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSelectionChangedHandler.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->PreIndex = PreIndex;
			ptr->CurrentIndex = CurrentIndex;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060279A7 RID: 162215 RVA: 0x003C67B0 File Offset: 0x003C49B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, int> action = target as Action<int, int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FSelectionChangedHandler.__FSelectionChangedHandler_DelegateParams*)__Parameters)->PreIndex, ((FSelectionChangedHandler.__FSelectionChangedHandler_DelegateParams*)__Parameters)->CurrentIndex);
		}

		// Token: 0x04015B32 RID: 88882
		internal static IntPtr _FunctionPtr;

		// Token: 0x04015B33 RID: 88883
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.SelectionChangedHandler__DelegateSignature";

		// Token: 0x04015B34 RID: 88884
		private static int RegisterId;

		// Token: 0x02003BCE RID: 15310
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FSelectionChangedHandler_DelegateParams
		{
			// Token: 0x04017DB7 RID: 97719
			[FieldOffset(0)]
			public int PreIndex;

			// Token: 0x04017DB8 RID: 97720
			[FieldOffset(4)]
			public int CurrentIndex;
		}

		// Token: 0x02003BCF RID: 15311
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017DB9 RID: 97721
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
