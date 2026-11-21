using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000318 RID: 792
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FBackgroundDownloadAllCompleteDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060053C8 RID: 21448 RVA: 0x000751DE File Offset: 0x000733DE
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FBackgroundDownloadAllCompleteDelegate.StaticFunctionPtr();
		}

		// Token: 0x060053C9 RID: 21449 RVA: 0x000751EA File Offset: 0x000733EA
		private static IntPtr StaticFunctionPtr()
		{
			if (FBackgroundDownloadAllCompleteDelegate._FunctionPtr == IntPtr.Zero)
			{
				FBackgroundDownloadAllCompleteDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroBackgroundDownload.BackgroundDownloadAllCompleteDelegate__DelegateSignature");
			}
			return FBackgroundDownloadAllCompleteDelegate._FunctionPtr;
		}

		// Token: 0x060053CA RID: 21450 RVA: 0x0007520D File Offset: 0x0007340D
		public FBackgroundDownloadAllCompleteDelegate()
		{
		}

		// Token: 0x060053CB RID: 21451 RVA: 0x00075215 File Offset: 0x00073415
		[NullableContext(2)]
		public FBackgroundDownloadAllCompleteDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060053CC RID: 21452 RVA: 0x0007521F File Offset: 0x0007341F
		public FBackgroundDownloadAllCompleteDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060053CD RID: 21453 RVA: 0x0007522A File Offset: 0x0007342A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int, int>) ?? ((Action<int, int>)Delegate.CreateDelegate(typeof(Action<int, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060053CE RID: 21454 RVA: 0x0007525C File Offset: 0x0007345C
		[NullableContext(1)]
		public void Add(Action<int, int> Callback)
		{
			if (FBackgroundDownloadAllCompleteDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FBackgroundDownloadAllCompleteDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FBackgroundDownloadAllCompleteDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FBackgroundDownloadAllCompleteDelegate.OnScriptCallback));
				}
				FBackgroundDownloadAllCompleteDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FBackgroundDownloadAllCompleteDelegate.RegisterId);
		}

		// Token: 0x060053CF RID: 21455 RVA: 0x00075296 File Offset: 0x00073496
		[NullableContext(1)]
		public void Remove(Action<int, int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060053D0 RID: 21456 RVA: 0x000752A0 File Offset: 0x000734A0
		[SkipLocalsInit]
		public unsafe void Broadcast(int State, int HttpCode)
		{
			FBackgroundDownloadAllCompleteDelegate.__FBackgroundDownloadAllCompleteDelegate_DelegateParams* ptr = stackalloc FBackgroundDownloadAllCompleteDelegate.__FBackgroundDownloadAllCompleteDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FBackgroundDownloadAllCompleteDelegate.__FBackgroundDownloadAllCompleteDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FBackgroundDownloadAllCompleteDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->State = State;
			ptr->HttpCode = HttpCode;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060053D1 RID: 21457 RVA: 0x000752E4 File Offset: 0x000734E4
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, int> action = target as Action<int, int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FBackgroundDownloadAllCompleteDelegate.__FBackgroundDownloadAllCompleteDelegate_DelegateParams*)__Parameters)->State, ((FBackgroundDownloadAllCompleteDelegate.__FBackgroundDownloadAllCompleteDelegate_DelegateParams*)__Parameters)->HttpCode);
		}

		// Token: 0x0400223A RID: 8762
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400223B RID: 8763
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroBackgroundDownload.BackgroundDownloadAllCompleteDelegate__DelegateSignature";

		// Token: 0x0400223C RID: 8764
		private static int RegisterId;

		// Token: 0x02000A1A RID: 2586
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FBackgroundDownloadAllCompleteDelegate_DelegateParams
		{
			// Token: 0x040059DB RID: 23003
			[FieldOffset(0)]
			public int State;

			// Token: 0x040059DC RID: 23004
			[FieldOffset(4)]
			public int HttpCode;
		}

		// Token: 0x02000A1B RID: 2587
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040059DD RID: 23005
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
