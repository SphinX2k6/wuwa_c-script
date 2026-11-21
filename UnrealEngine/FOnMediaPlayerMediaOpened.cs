using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000754 RID: 1876
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnMediaPlayerMediaOpened : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600A3E9 RID: 41961 RVA: 0x000F1EE2 File Offset: 0x000F00E2
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnMediaPlayerMediaOpened.StaticFunctionPtr();
		}

		// Token: 0x0600A3EA RID: 41962 RVA: 0x000F1EEE File Offset: 0x000F00EE
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnMediaPlayerMediaOpened._FunctionPtr == IntPtr.Zero)
			{
				FOnMediaPlayerMediaOpened._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/MediaAssets.OnMediaPlayerMediaOpened__DelegateSignature");
			}
			return FOnMediaPlayerMediaOpened._FunctionPtr;
		}

		// Token: 0x0600A3EB RID: 41963 RVA: 0x000F1F11 File Offset: 0x000F0111
		public FOnMediaPlayerMediaOpened()
		{
		}

		// Token: 0x0600A3EC RID: 41964 RVA: 0x000F1F19 File Offset: 0x000F0119
		[NullableContext(2)]
		public FOnMediaPlayerMediaOpened(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A3ED RID: 41965 RVA: 0x000F1F23 File Offset: 0x000F0123
		public FOnMediaPlayerMediaOpened(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A3EE RID: 41966 RVA: 0x000F1F2E File Offset: 0x000F012E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600A3EF RID: 41967 RVA: 0x000F1F60 File Offset: 0x000F0160
		[NullableContext(1)]
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

		// Token: 0x0600A3F0 RID: 41968 RVA: 0x000F1F9A File Offset: 0x000F019A
		[NullableContext(1)]
		public void Remove(Action<string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600A3F1 RID: 41969 RVA: 0x000F1FA4 File Offset: 0x000F01A4
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Broadcast(string OpenedUrl)
		{
			FOnMediaPlayerMediaOpened.__FOnMediaPlayerMediaOpened_DelegateParams* ptr = stackalloc FOnMediaPlayerMediaOpened.__FOnMediaPlayerMediaOpened_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnMediaPlayerMediaOpened.__FOnMediaPlayerMediaOpened_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnMediaPlayerMediaOpened.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->OpenedUrl), OpenedUrl);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FOnMediaPlayerMediaOpened._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600A3F2 RID: 41970 RVA: 0x000F1FF8 File Offset: 0x000F01F8
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x040045EB RID: 17899
		internal static IntPtr _FunctionPtr;

		// Token: 0x040045EC RID: 17900
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MediaAssets.OnMediaPlayerMediaOpened__DelegateSignature";

		// Token: 0x040045ED RID: 17901
		private static int RegisterId;

		// Token: 0x02000F40 RID: 3904
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FOnMediaPlayerMediaOpened_DelegateParams
		{
			// Token: 0x04006314 RID: 25364
			[FieldOffset(0)]
			public FString OpenedUrl;
		}

		// Token: 0x02000F41 RID: 3905
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006315 RID: 25365
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
