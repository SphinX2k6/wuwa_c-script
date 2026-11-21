using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200031A RID: 794
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FBackgroundDownloadProgressDelegateNew : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060053DC RID: 21468 RVA: 0x0007547E File Offset: 0x0007367E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FBackgroundDownloadProgressDelegateNew.StaticFunctionPtr();
		}

		// Token: 0x060053DD RID: 21469 RVA: 0x0007548A File Offset: 0x0007368A
		private static IntPtr StaticFunctionPtr()
		{
			if (FBackgroundDownloadProgressDelegateNew._FunctionPtr == IntPtr.Zero)
			{
				FBackgroundDownloadProgressDelegateNew._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroBackgroundDownload.BackgroundDownloadProgressDelegateNew__DelegateSignature");
			}
			return FBackgroundDownloadProgressDelegateNew._FunctionPtr;
		}

		// Token: 0x060053DE RID: 21470 RVA: 0x000754AD File Offset: 0x000736AD
		public FBackgroundDownloadProgressDelegateNew()
		{
		}

		// Token: 0x060053DF RID: 21471 RVA: 0x000754B5 File Offset: 0x000736B5
		[NullableContext(2)]
		public FBackgroundDownloadProgressDelegateNew(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060053E0 RID: 21472 RVA: 0x000754BF File Offset: 0x000736BF
		public FBackgroundDownloadProgressDelegateNew(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060053E1 RID: 21473 RVA: 0x000754CA File Offset: 0x000736CA
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int, long>) ?? ((Action<int, long>)Delegate.CreateDelegate(typeof(Action<int, long>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060053E2 RID: 21474 RVA: 0x000754FC File Offset: 0x000736FC
		[NullableContext(1)]
		public void Add(Action<int, long> Callback)
		{
			if (FBackgroundDownloadProgressDelegateNew.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FBackgroundDownloadProgressDelegateNew.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FBackgroundDownloadProgressDelegateNew.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FBackgroundDownloadProgressDelegateNew.OnScriptCallback));
				}
				FBackgroundDownloadProgressDelegateNew.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FBackgroundDownloadProgressDelegateNew.RegisterId);
		}

		// Token: 0x060053E3 RID: 21475 RVA: 0x00075536 File Offset: 0x00073736
		[NullableContext(1)]
		public void Remove(Action<int, long> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060053E4 RID: 21476 RVA: 0x00075540 File Offset: 0x00073740
		[SkipLocalsInit]
		public unsafe void Broadcast(int RequestIndex, long SavedSize)
		{
			FBackgroundDownloadProgressDelegateNew.__FBackgroundDownloadProgressDelegateNew_DelegateParams* ptr = stackalloc FBackgroundDownloadProgressDelegateNew.__FBackgroundDownloadProgressDelegateNew_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FBackgroundDownloadProgressDelegateNew.__FBackgroundDownloadProgressDelegateNew_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FBackgroundDownloadProgressDelegateNew.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->RequestIndex = RequestIndex;
			ptr->SavedSize = SavedSize;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060053E5 RID: 21477 RVA: 0x00075584 File Offset: 0x00073784
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, long> action = target as Action<int, long>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FBackgroundDownloadProgressDelegateNew.__FBackgroundDownloadProgressDelegateNew_DelegateParams*)__Parameters)->RequestIndex, ((FBackgroundDownloadProgressDelegateNew.__FBackgroundDownloadProgressDelegateNew_DelegateParams*)__Parameters)->SavedSize);
		}

		// Token: 0x04002240 RID: 8768
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002241 RID: 8769
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroBackgroundDownload.BackgroundDownloadProgressDelegateNew__DelegateSignature";

		// Token: 0x04002242 RID: 8770
		private static int RegisterId;

		// Token: 0x02000A1E RID: 2590
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FBackgroundDownloadProgressDelegateNew_DelegateParams
		{
			// Token: 0x040059E0 RID: 23008
			[FieldOffset(0)]
			public int RequestIndex;

			// Token: 0x040059E1 RID: 23009
			[FieldOffset(8)]
			public long SavedSize;
		}

		// Token: 0x02000A1F RID: 2591
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040059E2 RID: 23010
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
