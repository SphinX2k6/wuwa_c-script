using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C6D RID: 7277
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnTrackSwitched : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601C36C RID: 115564 RVA: 0x002998F2 File Offset: 0x00297AF2
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnTrackSwitched.StaticFunctionPtr();
		}

		// Token: 0x0601C36D RID: 115565 RVA: 0x002998FE File Offset: 0x00297AFE
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnTrackSwitched._FunctionPtr == IntPtr.Zero)
			{
				FOnTrackSwitched._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroRhythmGame.OnTrackSwitched__DelegateSignature");
			}
			return FOnTrackSwitched._FunctionPtr;
		}

		// Token: 0x0601C36E RID: 115566 RVA: 0x00299921 File Offset: 0x00297B21
		public FOnTrackSwitched()
		{
		}

		// Token: 0x0601C36F RID: 115567 RVA: 0x00299929 File Offset: 0x00297B29
		[NullableContext(2)]
		public FOnTrackSwitched(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C370 RID: 115568 RVA: 0x00299933 File Offset: 0x00297B33
		public FOnTrackSwitched(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C371 RID: 115569 RVA: 0x0029993E File Offset: 0x00297B3E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int, int>) ?? ((Action<int, int>)Delegate.CreateDelegate(typeof(Action<int, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601C372 RID: 115570 RVA: 0x00299970 File Offset: 0x00297B70
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<int, int> Callback)
		{
			if (FOnTrackSwitched.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnTrackSwitched.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnTrackSwitched.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnTrackSwitched.OnScriptCallback));
				}
				FOnTrackSwitched.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnTrackSwitched.RegisterId);
		}

		// Token: 0x0601C373 RID: 115571 RVA: 0x002999AA File Offset: 0x00297BAA
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<int, int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601C374 RID: 115572 RVA: 0x002999B4 File Offset: 0x00297BB4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(int NewTrackIndex, int OldTrackIndex)
		{
			FOnTrackSwitched.__FOnTrackSwitched_DelegateParams* ptr = stackalloc FOnTrackSwitched.__FOnTrackSwitched_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnTrackSwitched.__FOnTrackSwitched_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnTrackSwitched.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->NewTrackIndex = NewTrackIndex;
			ptr->OldTrackIndex = OldTrackIndex;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601C375 RID: 115573 RVA: 0x002999F8 File Offset: 0x00297BF8
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
			action(((FOnTrackSwitched.__FOnTrackSwitched_DelegateParams*)__Parameters)->NewTrackIndex, ((FOnTrackSwitched.__FOnTrackSwitched_DelegateParams*)__Parameters)->OldTrackIndex);
		}

		// Token: 0x0400F2CB RID: 62155
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400F2CC RID: 62156
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRhythmGame.OnTrackSwitched__DelegateSignature";

		// Token: 0x0400F2CD RID: 62157
		private static int RegisterId;

		// Token: 0x02003207 RID: 12807
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FOnTrackSwitched_DelegateParams
		{
			// Token: 0x04017069 RID: 94313
			[FieldOffset(0)]
			public int NewTrackIndex;

			// Token: 0x0401706A RID: 94314
			[FieldOffset(4)]
			public int OldTrackIndex;
		}

		// Token: 0x02003208 RID: 12808
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401706B RID: 94315
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
