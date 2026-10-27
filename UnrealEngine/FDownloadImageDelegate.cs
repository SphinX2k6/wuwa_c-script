using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200294D RID: 10573
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FDownloadImageDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0602725B RID: 160347 RVA: 0x003BAF76 File Offset: 0x003B9176
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FDownloadImageDelegate.StaticFunctionPtr();
		}

		// Token: 0x0602725C RID: 160348 RVA: 0x003BAF82 File Offset: 0x003B9182
		private static IntPtr StaticFunctionPtr()
		{
			if (FDownloadImageDelegate._FunctionPtr == IntPtr.Zero)
			{
				FDownloadImageDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.DownloadImageDelegate__DelegateSignature");
			}
			return FDownloadImageDelegate._FunctionPtr;
		}

		// Token: 0x0602725D RID: 160349 RVA: 0x003BAFA5 File Offset: 0x003B91A5
		public FDownloadImageDelegate()
		{
		}

		// Token: 0x0602725E RID: 160350 RVA: 0x003BAFAD File Offset: 0x003B91AD
		[NullableContext(2)]
		public FDownloadImageDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602725F RID: 160351 RVA: 0x003BAFB7 File Offset: 0x003B91B7
		public FDownloadImageDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06027260 RID: 160352 RVA: 0x003BAFC2 File Offset: 0x003B91C2
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UTexture2DDynamic>) ?? ((Action<UTexture2DDynamic>)Delegate.CreateDelegate(typeof(Action<UTexture2DDynamic>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06027261 RID: 160353 RVA: 0x003BAFF4 File Offset: 0x003B91F4
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<UTexture2DDynamic> Callback)
		{
			if (FDownloadImageDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FDownloadImageDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FDownloadImageDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FDownloadImageDelegate.OnScriptCallback));
				}
				FDownloadImageDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FDownloadImageDelegate.RegisterId);
		}

		// Token: 0x06027262 RID: 160354 RVA: 0x003BB02E File Offset: 0x003B922E
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UTexture2DDynamic> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06027263 RID: 160355 RVA: 0x003BB038 File Offset: 0x003B9238
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UTexture2DDynamic Texture)
		{
			FDownloadImageDelegate.__FDownloadImageDelegate_DelegateParams* ptr = stackalloc FDownloadImageDelegate.__FDownloadImageDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FDownloadImageDelegate.__FDownloadImageDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FDownloadImageDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Texture = ((Texture != null) ? Texture.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06027264 RID: 160356 RVA: 0x003BB084 File Offset: 0x003B9284
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UTexture2DDynamic> action = target as Action<UTexture2DDynamic>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UTexture2DDynamic orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UTexture2DDynamic>(((FDownloadImageDelegate.__FDownloadImageDelegate_DelegateParams*)__Parameters)->Texture);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x040157F2 RID: 88050
		internal static IntPtr _FunctionPtr;

		// Token: 0x040157F3 RID: 88051
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.DownloadImageDelegate__DelegateSignature";

		// Token: 0x040157F4 RID: 88052
		private static int RegisterId;

		// Token: 0x02003B68 RID: 15208
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FDownloadImageDelegate_DelegateParams
		{
			// Token: 0x04017D40 RID: 97600
			[FieldOffset(0)]
			public IntPtr Texture;
		}

		// Token: 0x02003B69 RID: 15209
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017D41 RID: 97601
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
