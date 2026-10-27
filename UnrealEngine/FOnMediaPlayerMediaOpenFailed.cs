using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020022A2 RID: 8866
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnMediaPlayerMediaOpenFailed : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06021B8B RID: 138123 RVA: 0x0031DB6E File Offset: 0x0031BD6E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnMediaPlayerMediaOpenFailed.StaticFunctionPtr();
		}

		// Token: 0x06021B8C RID: 138124 RVA: 0x0031DB7A File Offset: 0x0031BD7A
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnMediaPlayerMediaOpenFailed._FunctionPtr == IntPtr.Zero)
			{
				FOnMediaPlayerMediaOpenFailed._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/MediaAssets.OnMediaPlayerMediaOpenFailed__DelegateSignature");
			}
			return FOnMediaPlayerMediaOpenFailed._FunctionPtr;
		}

		// Token: 0x06021B8D RID: 138125 RVA: 0x0031DB9D File Offset: 0x0031BD9D
		public FOnMediaPlayerMediaOpenFailed()
		{
		}

		// Token: 0x06021B8E RID: 138126 RVA: 0x0031DBA5 File Offset: 0x0031BDA5
		[NullableContext(2)]
		public FOnMediaPlayerMediaOpenFailed(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021B8F RID: 138127 RVA: 0x0031DBAF File Offset: 0x0031BDAF
		public FOnMediaPlayerMediaOpenFailed(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021B90 RID: 138128 RVA: 0x0031DBBA File Offset: 0x0031BDBA
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06021B91 RID: 138129 RVA: 0x0031DBEC File Offset: 0x0031BDEC
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<string> Callback)
		{
			if (FOnMediaPlayerMediaOpenFailed.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnMediaPlayerMediaOpenFailed.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnMediaPlayerMediaOpenFailed.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnMediaPlayerMediaOpenFailed.OnScriptCallback));
				}
				FOnMediaPlayerMediaOpenFailed.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnMediaPlayerMediaOpenFailed.RegisterId);
		}

		// Token: 0x06021B92 RID: 138130 RVA: 0x0031DC26 File Offset: 0x0031BE26
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06021B93 RID: 138131 RVA: 0x0031DC30 File Offset: 0x0031BE30
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(string FailedUrl)
		{
			FOnMediaPlayerMediaOpenFailed.__FOnMediaPlayerMediaOpenFailed_DelegateParams* ptr = stackalloc FOnMediaPlayerMediaOpenFailed.__FOnMediaPlayerMediaOpenFailed_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnMediaPlayerMediaOpenFailed.__FOnMediaPlayerMediaOpenFailed_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnMediaPlayerMediaOpenFailed.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->FailedUrl), FailedUrl);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FOnMediaPlayerMediaOpenFailed._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06021B94 RID: 138132 RVA: 0x0031DC84 File Offset: 0x0031BE84
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<string> action = target as Action<string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string obj = FString.ToString((void*)(&((FOnMediaPlayerMediaOpenFailed.__FOnMediaPlayerMediaOpenFailed_DelegateParams*)__Parameters)->FailedUrl));
			action(obj);
		}

		// Token: 0x04011FD4 RID: 73684
		internal static IntPtr _FunctionPtr;

		// Token: 0x04011FD5 RID: 73685
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MediaAssets.OnMediaPlayerMediaOpenFailed__DelegateSignature";

		// Token: 0x04011FD6 RID: 73686
		private static int RegisterId;

		// Token: 0x02003614 RID: 13844
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FOnMediaPlayerMediaOpenFailed_DelegateParams
		{
			// Token: 0x040176A4 RID: 95908
			[FieldOffset(0)]
			public FString FailedUrl;
		}

		// Token: 0x02003615 RID: 13845
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040176A5 RID: 95909
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
