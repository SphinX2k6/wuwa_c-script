using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001976 RID: 6518
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnTagCountChanged : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06018372 RID: 99186 RVA: 0x0023B5EA File Offset: 0x002397EA
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnTagCountChanged.StaticFunctionPtr();
		}

		// Token: 0x06018373 RID: 99187 RVA: 0x0023B5F6 File Offset: 0x002397F6
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnTagCountChanged._FunctionPtr == IntPtr.Zero)
			{
				FOnTagCountChanged._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGAS.OnTagCountChanged__DelegateSignature");
			}
			return FOnTagCountChanged._FunctionPtr;
		}

		// Token: 0x06018374 RID: 99188 RVA: 0x0023B619 File Offset: 0x00239819
		public FOnTagCountChanged()
		{
		}

		// Token: 0x06018375 RID: 99189 RVA: 0x0023B621 File Offset: 0x00239821
		[NullableContext(2)]
		public FOnTagCountChanged(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018376 RID: 99190 RVA: 0x0023B62B File Offset: 0x0023982B
		public FOnTagCountChanged(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018377 RID: 99191 RVA: 0x0023B636 File Offset: 0x00239836
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06018378 RID: 99192 RVA: 0x0023B668 File Offset: 0x00239868
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<int> Callback)
		{
			if (FOnTagCountChanged.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnTagCountChanged.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnTagCountChanged.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnTagCountChanged.OnScriptCallback));
				}
				FOnTagCountChanged.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnTagCountChanged.RegisterId);
		}

		// Token: 0x06018379 RID: 99193 RVA: 0x0023B6A2 File Offset: 0x002398A2
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601837A RID: 99194 RVA: 0x0023B6AC File Offset: 0x002398AC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(int NewCount)
		{
			FOnTagCountChanged.__FOnTagCountChanged_DelegateParams* ptr = stackalloc FOnTagCountChanged.__FOnTagCountChanged_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FOnTagCountChanged.__FOnTagCountChanged_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnTagCountChanged.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->NewCount = NewCount;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601837B RID: 99195 RVA: 0x0023B6E8 File Offset: 0x002398E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int> action = target as Action<int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnTagCountChanged.__FOnTagCountChanged_DelegateParams*)__Parameters)->NewCount);
		}

		// Token: 0x0400D1D8 RID: 53720
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400D1D9 RID: 53721
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGAS.OnTagCountChanged__DelegateSignature";

		// Token: 0x0400D1DA RID: 53722
		private static int RegisterId;

		// Token: 0x0200306E RID: 12398
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FOnTagCountChanged_DelegateParams
		{
			// Token: 0x04016D3F RID: 93503
			[FieldOffset(0)]
			public int NewCount;
		}

		// Token: 0x0200306F RID: 12399
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016D40 RID: 93504
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
