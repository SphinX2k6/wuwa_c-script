using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020016AB RID: 5803
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FBackgroundDownloadAllCompleteDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060150CF RID: 86223 RVA: 0x001EEEA0 File Offset: 0x001ED0A0
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FBackgroundDownloadAllCompleteDelegate.StaticFunctionPtr();
		}

		// Token: 0x060150D0 RID: 86224 RVA: 0x001EEEAC File Offset: 0x001ED0AC
		private static IntPtr StaticFunctionPtr()
		{
			if (FBackgroundDownloadAllCompleteDelegate._FunctionPtr == IntPtr.Zero)
			{
				FBackgroundDownloadAllCompleteDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroBackgroundDownload.BackgroundDownloadAllCompleteDelegate__DelegateSignature");
			}
			return FBackgroundDownloadAllCompleteDelegate._FunctionPtr;
		}

		// Token: 0x060150D1 RID: 86225 RVA: 0x001EEECF File Offset: 0x001ED0CF
		public FBackgroundDownloadAllCompleteDelegate()
		{
		}

		// Token: 0x060150D2 RID: 86226 RVA: 0x001EEED7 File Offset: 0x001ED0D7
		[NullableContext(2)]
		public FBackgroundDownloadAllCompleteDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060150D3 RID: 86227 RVA: 0x001EEEE1 File Offset: 0x001ED0E1
		public FBackgroundDownloadAllCompleteDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060150D4 RID: 86228 RVA: 0x001EEEEC File Offset: 0x001ED0EC
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int, int>) ?? ((Action<int, int>)Delegate.CreateDelegate(typeof(Action<int, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060150D5 RID: 86229 RVA: 0x001EEF1E File Offset: 0x001ED11E
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x060150D6 RID: 86230 RVA: 0x001EEF58 File Offset: 0x001ED158
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<int, int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060150D7 RID: 86231 RVA: 0x001EEF64 File Offset: 0x001ED164
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(int State, int HttpCode)
		{
			FBackgroundDownloadAllCompleteDelegate.__FBackgroundDownloadAllCompleteDelegate_DelegateParams* ptr = stackalloc FBackgroundDownloadAllCompleteDelegate.__FBackgroundDownloadAllCompleteDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FBackgroundDownloadAllCompleteDelegate.__FBackgroundDownloadAllCompleteDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FBackgroundDownloadAllCompleteDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->State = State;
			ptr->HttpCode = HttpCode;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060150D8 RID: 86232 RVA: 0x001EEFA8 File Offset: 0x001ED1A8
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
			action(((FBackgroundDownloadAllCompleteDelegate.__FBackgroundDownloadAllCompleteDelegate_DelegateParams*)__Parameters)->State, ((FBackgroundDownloadAllCompleteDelegate.__FBackgroundDownloadAllCompleteDelegate_DelegateParams*)__Parameters)->HttpCode);
		}

		// Token: 0x0400B75A RID: 46938
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400B75B RID: 46939
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroBackgroundDownload.BackgroundDownloadAllCompleteDelegate__DelegateSignature";

		// Token: 0x0400B75C RID: 46940
		private static int RegisterId;

		// Token: 0x02002EE1 RID: 12001
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FBackgroundDownloadAllCompleteDelegate_DelegateParams
		{
			// Token: 0x04016A00 RID: 92672
			[FieldOffset(0)]
			public int State;

			// Token: 0x04016A01 RID: 92673
			[FieldOffset(4)]
			public int HttpCode;
		}

		// Token: 0x02002EE2 RID: 12002
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016A02 RID: 92674
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
