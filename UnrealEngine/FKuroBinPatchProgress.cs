using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001983 RID: 6531
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FKuroBinPatchProgress : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06018422 RID: 99362 RVA: 0x0023C82A File Offset: 0x0023AA2A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroBinPatchProgress.StaticFunctionPtr();
		}

		// Token: 0x06018423 RID: 99363 RVA: 0x0023C836 File Offset: 0x0023AA36
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroBinPatchProgress._FunctionPtr == IntPtr.Zero)
			{
				FKuroBinPatchProgress._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroHotPatch.KuroBinPatchProgress__DelegateSignature");
			}
			return FKuroBinPatchProgress._FunctionPtr;
		}

		// Token: 0x06018424 RID: 99364 RVA: 0x0023C859 File Offset: 0x0023AA59
		public FKuroBinPatchProgress()
		{
		}

		// Token: 0x06018425 RID: 99365 RVA: 0x0023C861 File Offset: 0x0023AA61
		[NullableContext(2)]
		public FKuroBinPatchProgress(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018426 RID: 99366 RVA: 0x0023C86B File Offset: 0x0023AA6B
		public FKuroBinPatchProgress(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018427 RID: 99367 RVA: 0x0023C876 File Offset: 0x0023AA76
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<long>) ?? ((Action<long>)Delegate.CreateDelegate(typeof(Action<long>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06018428 RID: 99368 RVA: 0x0023C8A8 File Offset: 0x0023AAA8
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<long> Callback)
		{
			if (FKuroBinPatchProgress.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FKuroBinPatchProgress.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FKuroBinPatchProgress.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FKuroBinPatchProgress.OnScriptCallback));
				}
				FKuroBinPatchProgress.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FKuroBinPatchProgress.RegisterId);
		}

		// Token: 0x06018429 RID: 99369 RVA: 0x0023C8E2 File Offset: 0x0023AAE2
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<long> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601842A RID: 99370 RVA: 0x0023C8EC File Offset: 0x0023AAEC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(long CurrentSize)
		{
			FKuroBinPatchProgress.__FKuroBinPatchProgress_DelegateParams* ptr = stackalloc FKuroBinPatchProgress.__FKuroBinPatchProgress_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FKuroBinPatchProgress.__FKuroBinPatchProgress_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FKuroBinPatchProgress.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->CurrentSize = CurrentSize;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601842B RID: 99371 RVA: 0x0023C928 File Offset: 0x0023AB28
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<long> action = target as Action<long>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FKuroBinPatchProgress.__FKuroBinPatchProgress_DelegateParams*)__Parameters)->CurrentSize);
		}

		// Token: 0x0400D235 RID: 53813
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400D236 RID: 53814
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroHotPatch.KuroBinPatchProgress__DelegateSignature";

		// Token: 0x0400D237 RID: 53815
		private static int RegisterId;

		// Token: 0x0200307B RID: 12411
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FKuroBinPatchProgress_DelegateParams
		{
			// Token: 0x04016D56 RID: 93526
			[FieldOffset(0)]
			public long CurrentSize;
		}

		// Token: 0x0200307C RID: 12412
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016D57 RID: 93527
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
