using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020016AD RID: 5805
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FBackgroundDownloadProgressDelegateNew : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060150E3 RID: 86243 RVA: 0x001EF142 File Offset: 0x001ED342
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FBackgroundDownloadProgressDelegateNew.StaticFunctionPtr();
		}

		// Token: 0x060150E4 RID: 86244 RVA: 0x001EF14E File Offset: 0x001ED34E
		private static IntPtr StaticFunctionPtr()
		{
			if (FBackgroundDownloadProgressDelegateNew._FunctionPtr == IntPtr.Zero)
			{
				FBackgroundDownloadProgressDelegateNew._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroBackgroundDownload.BackgroundDownloadProgressDelegateNew__DelegateSignature");
			}
			return FBackgroundDownloadProgressDelegateNew._FunctionPtr;
		}

		// Token: 0x060150E5 RID: 86245 RVA: 0x001EF171 File Offset: 0x001ED371
		public FBackgroundDownloadProgressDelegateNew()
		{
		}

		// Token: 0x060150E6 RID: 86246 RVA: 0x001EF179 File Offset: 0x001ED379
		[NullableContext(2)]
		public FBackgroundDownloadProgressDelegateNew(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060150E7 RID: 86247 RVA: 0x001EF183 File Offset: 0x001ED383
		public FBackgroundDownloadProgressDelegateNew(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060150E8 RID: 86248 RVA: 0x001EF18E File Offset: 0x001ED38E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int, long>) ?? ((Action<int, long>)Delegate.CreateDelegate(typeof(Action<int, long>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060150E9 RID: 86249 RVA: 0x001EF1C0 File Offset: 0x001ED3C0
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x060150EA RID: 86250 RVA: 0x001EF1FA File Offset: 0x001ED3FA
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<int, long> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060150EB RID: 86251 RVA: 0x001EF204 File Offset: 0x001ED404
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(int RequestIndex, long SavedSize)
		{
			FBackgroundDownloadProgressDelegateNew.__FBackgroundDownloadProgressDelegateNew_DelegateParams* ptr = stackalloc FBackgroundDownloadProgressDelegateNew.__FBackgroundDownloadProgressDelegateNew_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FBackgroundDownloadProgressDelegateNew.__FBackgroundDownloadProgressDelegateNew_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FBackgroundDownloadProgressDelegateNew.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->RequestIndex = RequestIndex;
			ptr->SavedSize = SavedSize;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060150EC RID: 86252 RVA: 0x001EF248 File Offset: 0x001ED448
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, long> action = target as Action<int, long>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FBackgroundDownloadProgressDelegateNew.__FBackgroundDownloadProgressDelegateNew_DelegateParams*)__Parameters)->RequestIndex, ((FBackgroundDownloadProgressDelegateNew.__FBackgroundDownloadProgressDelegateNew_DelegateParams*)__Parameters)->SavedSize);
		}

		// Token: 0x0400B760 RID: 46944
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400B761 RID: 46945
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroBackgroundDownload.BackgroundDownloadProgressDelegateNew__DelegateSignature";

		// Token: 0x0400B762 RID: 46946
		private static int RegisterId;

		// Token: 0x02002EE5 RID: 12005
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FBackgroundDownloadProgressDelegateNew_DelegateParams
		{
			// Token: 0x04016A05 RID: 92677
			[FieldOffset(0)]
			public int RequestIndex;

			// Token: 0x04016A06 RID: 92678
			[FieldOffset(8)]
			public long SavedSize;
		}

		// Token: 0x02002EE6 RID: 12006
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016A07 RID: 92679
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
