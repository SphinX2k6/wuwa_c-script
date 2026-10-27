using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020022A1 RID: 8865
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnMediaPlayerMediaOpened : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06021B81 RID: 138113 RVA: 0x0031DA06 File Offset: 0x0031BC06
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnMediaPlayerMediaOpened.StaticFunctionPtr();
		}

		// Token: 0x06021B82 RID: 138114 RVA: 0x0031DA12 File Offset: 0x0031BC12
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnMediaPlayerMediaOpened._FunctionPtr == IntPtr.Zero)
			{
				FOnMediaPlayerMediaOpened._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/MediaAssets.OnMediaPlayerMediaOpened__DelegateSignature");
			}
			return FOnMediaPlayerMediaOpened._FunctionPtr;
		}

		// Token: 0x06021B83 RID: 138115 RVA: 0x0031DA35 File Offset: 0x0031BC35
		public FOnMediaPlayerMediaOpened()
		{
		}

		// Token: 0x06021B84 RID: 138116 RVA: 0x0031DA3D File Offset: 0x0031BC3D
		[NullableContext(2)]
		public FOnMediaPlayerMediaOpened(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021B85 RID: 138117 RVA: 0x0031DA47 File Offset: 0x0031BC47
		public FOnMediaPlayerMediaOpened(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021B86 RID: 138118 RVA: 0x0031DA52 File Offset: 0x0031BC52
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06021B87 RID: 138119 RVA: 0x0031DA84 File Offset: 0x0031BC84
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<string> Callback)
		{
			if (FOnMediaPlayerMediaOpened.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnMediaPlayerMediaOpened.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnMediaPlayerMediaOpened.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnMediaPlayerMediaOpened.OnScriptCallback));
				}
				FOnMediaPlayerMediaOpened.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnMediaPlayerMediaOpened.RegisterId);
		}

		// Token: 0x06021B88 RID: 138120 RVA: 0x0031DABE File Offset: 0x0031BCBE
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06021B89 RID: 138121 RVA: 0x0031DAC8 File Offset: 0x0031BCC8
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(string OpenedUrl)
		{
			FOnMediaPlayerMediaOpened.__FOnMediaPlayerMediaOpened_DelegateParams* ptr = stackalloc FOnMediaPlayerMediaOpened.__FOnMediaPlayerMediaOpened_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnMediaPlayerMediaOpened.__FOnMediaPlayerMediaOpened_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnMediaPlayerMediaOpened.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->OpenedUrl), OpenedUrl);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FOnMediaPlayerMediaOpened._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06021B8A RID: 138122 RVA: 0x0031DB1C File Offset: 0x0031BD1C
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
			string obj = FString.ToString((void*)(&((FOnMediaPlayerMediaOpened.__FOnMediaPlayerMediaOpened_DelegateParams*)__Parameters)->OpenedUrl));
			action(obj);
		}

		// Token: 0x04011FD1 RID: 73681
		internal static IntPtr _FunctionPtr;

		// Token: 0x04011FD2 RID: 73682
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MediaAssets.OnMediaPlayerMediaOpened__DelegateSignature";

		// Token: 0x04011FD3 RID: 73683
		private static int RegisterId;

		// Token: 0x02003612 RID: 13842
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FOnMediaPlayerMediaOpened_DelegateParams
		{
			// Token: 0x040176A2 RID: 95906
			[FieldOffset(0)]
			public FString OpenedUrl;
		}

		// Token: 0x02003613 RID: 13843
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040176A3 RID: 95907
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
