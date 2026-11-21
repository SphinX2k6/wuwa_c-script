using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000319 RID: 793
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FBackgroundDownloadProgressDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060053D2 RID: 21458 RVA: 0x00075334 File Offset: 0x00073534
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FBackgroundDownloadProgressDelegate.StaticFunctionPtr();
		}

		// Token: 0x060053D3 RID: 21459 RVA: 0x00075340 File Offset: 0x00073540
		private static IntPtr StaticFunctionPtr()
		{
			if (FBackgroundDownloadProgressDelegate._FunctionPtr == IntPtr.Zero)
			{
				FBackgroundDownloadProgressDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroBackgroundDownload.BackgroundDownloadProgressDelegate__DelegateSignature");
			}
			return FBackgroundDownloadProgressDelegate._FunctionPtr;
		}

		// Token: 0x060053D4 RID: 21460 RVA: 0x00075363 File Offset: 0x00073563
		public FBackgroundDownloadProgressDelegate()
		{
		}

		// Token: 0x060053D5 RID: 21461 RVA: 0x0007536B File Offset: 0x0007356B
		[NullableContext(2)]
		public FBackgroundDownloadProgressDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060053D6 RID: 21462 RVA: 0x00075375 File Offset: 0x00073575
		public FBackgroundDownloadProgressDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060053D7 RID: 21463 RVA: 0x00075380 File Offset: 0x00073580
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<long>) ?? ((Action<long>)Delegate.CreateDelegate(typeof(Action<long>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060053D8 RID: 21464 RVA: 0x000753B2 File Offset: 0x000735B2
		[NullableContext(1)]
		public void Add(Action<long> Callback)
		{
			if (FBackgroundDownloadProgressDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FBackgroundDownloadProgressDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FBackgroundDownloadProgressDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FBackgroundDownloadProgressDelegate.OnScriptCallback));
				}
				FBackgroundDownloadProgressDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FBackgroundDownloadProgressDelegate.RegisterId);
		}

		// Token: 0x060053D9 RID: 21465 RVA: 0x000753EC File Offset: 0x000735EC
		[NullableContext(1)]
		public void Remove(Action<long> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060053DA RID: 21466 RVA: 0x000753F8 File Offset: 0x000735F8
		[SkipLocalsInit]
		public unsafe void Broadcast(long SavedSize)
		{
			FBackgroundDownloadProgressDelegate.__FBackgroundDownloadProgressDelegate_DelegateParams* ptr = stackalloc FBackgroundDownloadProgressDelegate.__FBackgroundDownloadProgressDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FBackgroundDownloadProgressDelegate.__FBackgroundDownloadProgressDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FBackgroundDownloadProgressDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->SavedSize = SavedSize;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060053DB RID: 21467 RVA: 0x00075434 File Offset: 0x00073634
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<long> action = target as Action<long>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FBackgroundDownloadProgressDelegate.__FBackgroundDownloadProgressDelegate_DelegateParams*)__Parameters)->SavedSize);
		}

		// Token: 0x0400223D RID: 8765
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400223E RID: 8766
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroBackgroundDownload.BackgroundDownloadProgressDelegate__DelegateSignature";

		// Token: 0x0400223F RID: 8767
		private static int RegisterId;

		// Token: 0x02000A1C RID: 2588
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FBackgroundDownloadProgressDelegate_DelegateParams
		{
			// Token: 0x040059DE RID: 23006
			[FieldOffset(0)]
			public long SavedSize;
		}

		// Token: 0x02000A1D RID: 2589
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040059DF RID: 23007
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
