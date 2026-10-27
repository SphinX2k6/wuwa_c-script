using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C1A RID: 7194
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnIDChanged : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601BBEF RID: 113647 RVA: 0x0028D54D File Offset: 0x0028B74D
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnIDChanged.StaticFunctionPtr();
		}

		// Token: 0x0601BBF0 RID: 113648 RVA: 0x0028D559 File Offset: 0x0028B759
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnIDChanged._FunctionPtr == IntPtr.Zero)
			{
				FOnIDChanged._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroRenderingRuntimeBPPlugin.OnIDChanged__DelegateSignature");
			}
			return FOnIDChanged._FunctionPtr;
		}

		// Token: 0x0601BBF1 RID: 113649 RVA: 0x0028D57C File Offset: 0x0028B77C
		public FOnIDChanged()
		{
		}

		// Token: 0x0601BBF2 RID: 113650 RVA: 0x0028D584 File Offset: 0x0028B784
		[NullableContext(2)]
		public FOnIDChanged(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601BBF3 RID: 113651 RVA: 0x0028D58E File Offset: 0x0028B78E
		public FOnIDChanged(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601BBF4 RID: 113652 RVA: 0x0028D599 File Offset: 0x0028B799
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int, int>) ?? ((Action<int, int>)Delegate.CreateDelegate(typeof(Action<int, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601BBF5 RID: 113653 RVA: 0x0028D5CB File Offset: 0x0028B7CB
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<int, int> Callback)
		{
			if (FOnIDChanged.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnIDChanged.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnIDChanged.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnIDChanged.OnScriptCallback));
				}
				FOnIDChanged.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnIDChanged.RegisterId);
		}

		// Token: 0x0601BBF6 RID: 113654 RVA: 0x0028D605 File Offset: 0x0028B805
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<int, int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601BBF7 RID: 113655 RVA: 0x0028D610 File Offset: 0x0028B810
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(int OldID, int NewID)
		{
			FOnIDChanged.__FOnIDChanged_DelegateParams* ptr = stackalloc FOnIDChanged.__FOnIDChanged_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnIDChanged.__FOnIDChanged_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnIDChanged.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->OldID = OldID;
			ptr->NewID = NewID;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601BBF8 RID: 113656 RVA: 0x0028D654 File Offset: 0x0028B854
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
			action(((FOnIDChanged.__FOnIDChanged_DelegateParams*)__Parameters)->OldID, ((FOnIDChanged.__FOnIDChanged_DelegateParams*)__Parameters)->NewID);
		}

		// Token: 0x0400EE9D RID: 61085
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400EE9E RID: 61086
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.OnIDChanged__DelegateSignature";

		// Token: 0x0400EE9F RID: 61087
		private static int RegisterId;

		// Token: 0x020031A0 RID: 12704
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FOnIDChanged_DelegateParams
		{
			// Token: 0x04016FDE RID: 94174
			[FieldOffset(0)]
			public int OldID;

			// Token: 0x04016FDF RID: 94175
			[FieldOffset(4)]
			public int NewID;
		}

		// Token: 0x020031A1 RID: 12705
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016FE0 RID: 94176
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
