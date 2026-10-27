using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001969 RID: 6505
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnAnyAttributeChanged : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060182F0 RID: 99056 RVA: 0x0023A2D6 File Offset: 0x002384D6
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnAnyAttributeChanged.StaticFunctionPtr();
		}

		// Token: 0x060182F1 RID: 99057 RVA: 0x0023A2E2 File Offset: 0x002384E2
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnAnyAttributeChanged._FunctionPtr == IntPtr.Zero)
			{
				FOnAnyAttributeChanged._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGAS.OnAnyAttributeChanged__DelegateSignature");
			}
			return FOnAnyAttributeChanged._FunctionPtr;
		}

		// Token: 0x060182F2 RID: 99058 RVA: 0x0023A305 File Offset: 0x00238505
		public FOnAnyAttributeChanged()
		{
		}

		// Token: 0x060182F3 RID: 99059 RVA: 0x0023A30D File Offset: 0x0023850D
		[NullableContext(2)]
		public FOnAnyAttributeChanged(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060182F4 RID: 99060 RVA: 0x0023A317 File Offset: 0x00238517
		public FOnAnyAttributeChanged(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060182F5 RID: 99061 RVA: 0x0023A322 File Offset: 0x00238522
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int, float, float>) ?? ((Action<int, float, float>)Delegate.CreateDelegate(typeof(Action<int, float, float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060182F6 RID: 99062 RVA: 0x0023A354 File Offset: 0x00238554
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<int, float, float> Callback)
		{
			if (FOnAnyAttributeChanged.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnAnyAttributeChanged.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnAnyAttributeChanged.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnAnyAttributeChanged.OnScriptCallback));
				}
				FOnAnyAttributeChanged.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnAnyAttributeChanged.RegisterId);
		}

		// Token: 0x060182F7 RID: 99063 RVA: 0x0023A38E File Offset: 0x0023858E
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<int, float, float> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060182F8 RID: 99064 RVA: 0x0023A398 File Offset: 0x00238598
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(int AttributeID, float NewValue, float OldValue)
		{
			FOnAnyAttributeChanged.__FOnAnyAttributeChanged_DelegateParams* ptr = stackalloc FOnAnyAttributeChanged.__FOnAnyAttributeChanged_DelegateParams[(UIntPtr)27] + 15L / (long)sizeof(FOnAnyAttributeChanged.__FOnAnyAttributeChanged_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnAnyAttributeChanged.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->AttributeID = AttributeID;
			ptr->NewValue = NewValue;
			ptr->OldValue = OldValue;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060182F9 RID: 99065 RVA: 0x0023A3E4 File Offset: 0x002385E4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, float, float> action = target as Action<int, float, float>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnAnyAttributeChanged.__FOnAnyAttributeChanged_DelegateParams*)__Parameters)->AttributeID, ((FOnAnyAttributeChanged.__FOnAnyAttributeChanged_DelegateParams*)__Parameters)->NewValue, ((FOnAnyAttributeChanged.__FOnAnyAttributeChanged_DelegateParams*)__Parameters)->OldValue);
		}

		// Token: 0x0400D1B1 RID: 53681
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400D1B2 RID: 53682
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGAS.OnAnyAttributeChanged__DelegateSignature";

		// Token: 0x0400D1B3 RID: 53683
		private static int RegisterId;

		// Token: 0x02003054 RID: 12372
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __FOnAnyAttributeChanged_DelegateParams
		{
			// Token: 0x04016D17 RID: 93463
			[FieldOffset(0)]
			public int AttributeID;

			// Token: 0x04016D18 RID: 93464
			[FieldOffset(4)]
			public float NewValue;

			// Token: 0x04016D19 RID: 93465
			[FieldOffset(8)]
			public float OldValue;
		}

		// Token: 0x02003055 RID: 12373
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016D1A RID: 93466
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
