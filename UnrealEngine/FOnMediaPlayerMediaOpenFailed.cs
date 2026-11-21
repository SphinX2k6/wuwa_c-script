using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000755 RID: 1877
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnMediaPlayerMediaOpenFailed : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600A3F3 RID: 41971 RVA: 0x000F204A File Offset: 0x000F024A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnMediaPlayerMediaOpenFailed.StaticFunctionPtr();
		}

		// Token: 0x0600A3F4 RID: 41972 RVA: 0x000F2056 File Offset: 0x000F0256
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnMediaPlayerMediaOpenFailed._FunctionPtr == IntPtr.Zero)
			{
				FOnMediaPlayerMediaOpenFailed._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/MediaAssets.OnMediaPlayerMediaOpenFailed__DelegateSignature");
			}
			return FOnMediaPlayerMediaOpenFailed._FunctionPtr;
		}

		// Token: 0x0600A3F5 RID: 41973 RVA: 0x000F2079 File Offset: 0x000F0279
		public FOnMediaPlayerMediaOpenFailed()
		{
		}

		// Token: 0x0600A3F6 RID: 41974 RVA: 0x000F2081 File Offset: 0x000F0281
		[NullableContext(2)]
		public FOnMediaPlayerMediaOpenFailed(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A3F7 RID: 41975 RVA: 0x000F208B File Offset: 0x000F028B
		public FOnMediaPlayerMediaOpenFailed(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A3F8 RID: 41976 RVA: 0x000F2096 File Offset: 0x000F0296
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600A3F9 RID: 41977 RVA: 0x000F20C8 File Offset: 0x000F02C8
		[NullableContext(1)]
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

		// Token: 0x0600A3FA RID: 41978 RVA: 0x000F2102 File Offset: 0x000F0302
		[NullableContext(1)]
		public void Remove(Action<string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600A3FB RID: 41979 RVA: 0x000F210C File Offset: 0x000F030C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Broadcast(string FailedUrl)
		{
			FOnMediaPlayerMediaOpenFailed.__FOnMediaPlayerMediaOpenFailed_DelegateParams* ptr = stackalloc FOnMediaPlayerMediaOpenFailed.__FOnMediaPlayerMediaOpenFailed_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnMediaPlayerMediaOpenFailed.__FOnMediaPlayerMediaOpenFailed_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnMediaPlayerMediaOpenFailed.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->FailedUrl), FailedUrl);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FOnMediaPlayerMediaOpenFailed._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600A3FC RID: 41980 RVA: 0x000F2160 File Offset: 0x000F0360
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x040045EE RID: 17902
		internal static IntPtr _FunctionPtr;

		// Token: 0x040045EF RID: 17903
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MediaAssets.OnMediaPlayerMediaOpenFailed__DelegateSignature";

		// Token: 0x040045F0 RID: 17904
		private static int RegisterId;

		// Token: 0x02000F42 RID: 3906
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FOnMediaPlayerMediaOpenFailed_DelegateParams
		{
			// Token: 0x04006316 RID: 25366
			[FieldOffset(0)]
			public FString FailedUrl;
		}

		// Token: 0x02000F43 RID: 3907
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006317 RID: 25367
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
