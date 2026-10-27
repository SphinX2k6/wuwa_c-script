using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020016AC RID: 5804
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FBackgroundDownloadProgressDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060150D9 RID: 86233 RVA: 0x001EEFF8 File Offset: 0x001ED1F8
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FBackgroundDownloadProgressDelegate.StaticFunctionPtr();
		}

		// Token: 0x060150DA RID: 86234 RVA: 0x001EF004 File Offset: 0x001ED204
		private static IntPtr StaticFunctionPtr()
		{
			if (FBackgroundDownloadProgressDelegate._FunctionPtr == IntPtr.Zero)
			{
				FBackgroundDownloadProgressDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroBackgroundDownload.BackgroundDownloadProgressDelegate__DelegateSignature");
			}
			return FBackgroundDownloadProgressDelegate._FunctionPtr;
		}

		// Token: 0x060150DB RID: 86235 RVA: 0x001EF027 File Offset: 0x001ED227
		public FBackgroundDownloadProgressDelegate()
		{
		}

		// Token: 0x060150DC RID: 86236 RVA: 0x001EF02F File Offset: 0x001ED22F
		[NullableContext(2)]
		public FBackgroundDownloadProgressDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060150DD RID: 86237 RVA: 0x001EF039 File Offset: 0x001ED239
		public FBackgroundDownloadProgressDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060150DE RID: 86238 RVA: 0x001EF044 File Offset: 0x001ED244
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<long>) ?? ((Action<long>)Delegate.CreateDelegate(typeof(Action<long>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060150DF RID: 86239 RVA: 0x001EF076 File Offset: 0x001ED276
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x060150E0 RID: 86240 RVA: 0x001EF0B0 File Offset: 0x001ED2B0
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<long> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060150E1 RID: 86241 RVA: 0x001EF0BC File Offset: 0x001ED2BC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(long SavedSize)
		{
			FBackgroundDownloadProgressDelegate.__FBackgroundDownloadProgressDelegate_DelegateParams* ptr = stackalloc FBackgroundDownloadProgressDelegate.__FBackgroundDownloadProgressDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FBackgroundDownloadProgressDelegate.__FBackgroundDownloadProgressDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FBackgroundDownloadProgressDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->SavedSize = SavedSize;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060150E2 RID: 86242 RVA: 0x001EF0F8 File Offset: 0x001ED2F8
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
			action(((FBackgroundDownloadProgressDelegate.__FBackgroundDownloadProgressDelegate_DelegateParams*)__Parameters)->SavedSize);
		}

		// Token: 0x0400B75D RID: 46941
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400B75E RID: 46942
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroBackgroundDownload.BackgroundDownloadProgressDelegate__DelegateSignature";

		// Token: 0x0400B75F RID: 46943
		private static int RegisterId;

		// Token: 0x02002EE3 RID: 12003
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FBackgroundDownloadProgressDelegate_DelegateParams
		{
			// Token: 0x04016A03 RID: 92675
			[FieldOffset(0)]
			public long SavedSize;
		}

		// Token: 0x02002EE4 RID: 12004
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016A04 RID: 92676
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
