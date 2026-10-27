using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001975 RID: 6517
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnStackChanged : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06018368 RID: 99176 RVA: 0x0023B487 File Offset: 0x00239687
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnStackChanged.StaticFunctionPtr();
		}

		// Token: 0x06018369 RID: 99177 RVA: 0x0023B493 File Offset: 0x00239693
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnStackChanged._FunctionPtr == IntPtr.Zero)
			{
				FOnStackChanged._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGAS.OnStackChanged__DelegateSignature");
			}
			return FOnStackChanged._FunctionPtr;
		}

		// Token: 0x0601836A RID: 99178 RVA: 0x0023B4B6 File Offset: 0x002396B6
		public FOnStackChanged()
		{
		}

		// Token: 0x0601836B RID: 99179 RVA: 0x0023B4BE File Offset: 0x002396BE
		[NullableContext(2)]
		public FOnStackChanged(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601836C RID: 99180 RVA: 0x0023B4C8 File Offset: 0x002396C8
		public FOnStackChanged(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601836D RID: 99181 RVA: 0x0023B4D3 File Offset: 0x002396D3
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int, int, bool>) ?? ((Action<int, int, bool>)Delegate.CreateDelegate(typeof(Action<int, int, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601836E RID: 99182 RVA: 0x0023B505 File Offset: 0x00239705
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<int, int, bool> Callback)
		{
			if (FOnStackChanged.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnStackChanged.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnStackChanged.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnStackChanged.OnScriptCallback));
				}
				FOnStackChanged.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnStackChanged.RegisterId);
		}

		// Token: 0x0601836F RID: 99183 RVA: 0x0023B53F File Offset: 0x0023973F
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<int, int, bool> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06018370 RID: 99184 RVA: 0x0023B548 File Offset: 0x00239748
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(int NewStackCount, int PreviousStackCount, bool bPremature)
		{
			FOnStackChanged.__FOnStackChanged_DelegateParams* ptr = stackalloc FOnStackChanged.__FOnStackChanged_DelegateParams[(UIntPtr)27] + 15L / (long)sizeof(FOnStackChanged.__FOnStackChanged_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnStackChanged.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->NewStackCount = NewStackCount;
			ptr->PreviousStackCount = PreviousStackCount;
			ptr->bPremature = bPremature;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06018371 RID: 99185 RVA: 0x0023B594 File Offset: 0x00239794
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, int, bool> action = target as Action<int, int, bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnStackChanged.__FOnStackChanged_DelegateParams*)__Parameters)->NewStackCount, ((FOnStackChanged.__FOnStackChanged_DelegateParams*)__Parameters)->PreviousStackCount, ((FOnStackChanged.__FOnStackChanged_DelegateParams*)__Parameters)->bPremature);
		}

		// Token: 0x0400D1D5 RID: 53717
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400D1D6 RID: 53718
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGAS.OnStackChanged__DelegateSignature";

		// Token: 0x0400D1D7 RID: 53719
		private static int RegisterId;

		// Token: 0x0200306C RID: 12396
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __FOnStackChanged_DelegateParams
		{
			// Token: 0x04016D3B RID: 93499
			[FieldOffset(0)]
			public int NewStackCount;

			// Token: 0x04016D3C RID: 93500
			[FieldOffset(4)]
			public int PreviousStackCount;

			// Token: 0x04016D3D RID: 93501
			[FieldOffset(8)]
			public bool bPremature;
		}

		// Token: 0x0200306D RID: 12397
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016D3E RID: 93502
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
