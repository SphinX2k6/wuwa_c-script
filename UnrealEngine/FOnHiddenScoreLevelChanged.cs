using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C65 RID: 7269
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnHiddenScoreLevelChanged : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601C31C RID: 115484 RVA: 0x00298EF6 File Offset: 0x002970F6
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnHiddenScoreLevelChanged.StaticFunctionPtr();
		}

		// Token: 0x0601C31D RID: 115485 RVA: 0x00298F02 File Offset: 0x00297102
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnHiddenScoreLevelChanged._FunctionPtr == IntPtr.Zero)
			{
				FOnHiddenScoreLevelChanged._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroRhythmGame.OnHiddenScoreLevelChanged__DelegateSignature");
			}
			return FOnHiddenScoreLevelChanged._FunctionPtr;
		}

		// Token: 0x0601C31E RID: 115486 RVA: 0x00298F25 File Offset: 0x00297125
		public FOnHiddenScoreLevelChanged()
		{
		}

		// Token: 0x0601C31F RID: 115487 RVA: 0x00298F2D File Offset: 0x0029712D
		[NullableContext(2)]
		public FOnHiddenScoreLevelChanged(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C320 RID: 115488 RVA: 0x00298F37 File Offset: 0x00297137
		public FOnHiddenScoreLevelChanged(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C321 RID: 115489 RVA: 0x00298F42 File Offset: 0x00297142
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int, int>) ?? ((Action<int, int>)Delegate.CreateDelegate(typeof(Action<int, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601C322 RID: 115490 RVA: 0x00298F74 File Offset: 0x00297174
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<int, int> Callback)
		{
			if (FOnHiddenScoreLevelChanged.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnHiddenScoreLevelChanged.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnHiddenScoreLevelChanged.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnHiddenScoreLevelChanged.OnScriptCallback));
				}
				FOnHiddenScoreLevelChanged.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnHiddenScoreLevelChanged.RegisterId);
		}

		// Token: 0x0601C323 RID: 115491 RVA: 0x00298FAE File Offset: 0x002971AE
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<int, int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601C324 RID: 115492 RVA: 0x00298FB8 File Offset: 0x002971B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(int NewLevel, int OldLevel)
		{
			FOnHiddenScoreLevelChanged.__FOnHiddenScoreLevelChanged_DelegateParams* ptr = stackalloc FOnHiddenScoreLevelChanged.__FOnHiddenScoreLevelChanged_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnHiddenScoreLevelChanged.__FOnHiddenScoreLevelChanged_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnHiddenScoreLevelChanged.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->NewLevel = NewLevel;
			ptr->OldLevel = OldLevel;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601C325 RID: 115493 RVA: 0x00298FFC File Offset: 0x002971FC
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
			action(((FOnHiddenScoreLevelChanged.__FOnHiddenScoreLevelChanged_DelegateParams*)__Parameters)->NewLevel, ((FOnHiddenScoreLevelChanged.__FOnHiddenScoreLevelChanged_DelegateParams*)__Parameters)->OldLevel);
		}

		// Token: 0x0400F2B3 RID: 62131
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400F2B4 RID: 62132
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRhythmGame.OnHiddenScoreLevelChanged__DelegateSignature";

		// Token: 0x0400F2B5 RID: 62133
		private static int RegisterId;

		// Token: 0x020031FA RID: 12794
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FOnHiddenScoreLevelChanged_DelegateParams
		{
			// Token: 0x04017055 RID: 94293
			[FieldOffset(0)]
			public int NewLevel;

			// Token: 0x04017056 RID: 94294
			[FieldOffset(4)]
			public int OldLevel;
		}

		// Token: 0x020031FB RID: 12795
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017057 RID: 94295
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
