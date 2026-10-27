using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F0B RID: 3851
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnCanvasRenderTargetUpdate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600D05E RID: 53342 RVA: 0x0013039A File Offset: 0x0012E59A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnCanvasRenderTargetUpdate.StaticFunctionPtr();
		}

		// Token: 0x0600D05F RID: 53343 RVA: 0x001303A6 File Offset: 0x0012E5A6
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnCanvasRenderTargetUpdate._FunctionPtr == IntPtr.Zero)
			{
				FOnCanvasRenderTargetUpdate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.OnCanvasRenderTargetUpdate__DelegateSignature");
			}
			return FOnCanvasRenderTargetUpdate._FunctionPtr;
		}

		// Token: 0x0600D060 RID: 53344 RVA: 0x001303C9 File Offset: 0x0012E5C9
		public FOnCanvasRenderTargetUpdate()
		{
		}

		// Token: 0x0600D061 RID: 53345 RVA: 0x001303D1 File Offset: 0x0012E5D1
		[NullableContext(2)]
		public FOnCanvasRenderTargetUpdate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600D062 RID: 53346 RVA: 0x001303DB File Offset: 0x0012E5DB
		public FOnCanvasRenderTargetUpdate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600D063 RID: 53347 RVA: 0x001303E6 File Offset: 0x0012E5E6
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UCanvas, int, int>) ?? ((Action<UCanvas, int, int>)Delegate.CreateDelegate(typeof(Action<UCanvas, int, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600D064 RID: 53348 RVA: 0x00130418 File Offset: 0x0012E618
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<UCanvas, int, int> Callback)
		{
			if (FOnCanvasRenderTargetUpdate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnCanvasRenderTargetUpdate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnCanvasRenderTargetUpdate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnCanvasRenderTargetUpdate.OnScriptCallback));
				}
				FOnCanvasRenderTargetUpdate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnCanvasRenderTargetUpdate.RegisterId);
		}

		// Token: 0x0600D065 RID: 53349 RVA: 0x00130452 File Offset: 0x0012E652
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UCanvas, int, int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600D066 RID: 53350 RVA: 0x0013045C File Offset: 0x0012E65C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UCanvas Canvas, int Width, int Height)
		{
			FOnCanvasRenderTargetUpdate.__FOnCanvasRenderTargetUpdate_DelegateParams* ptr = stackalloc FOnCanvasRenderTargetUpdate.__FOnCanvasRenderTargetUpdate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnCanvasRenderTargetUpdate.__FOnCanvasRenderTargetUpdate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnCanvasRenderTargetUpdate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Canvas = ((Canvas != null) ? Canvas.NativePtr : IntPtr.Zero);
			ptr->Width = Width;
			ptr->Height = Height;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600D067 RID: 53351 RVA: 0x001304B8 File Offset: 0x0012E6B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UCanvas, int, int> action = target as Action<UCanvas, int, int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UCanvas orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UCanvas>(((FOnCanvasRenderTargetUpdate.__FOnCanvasRenderTargetUpdate_DelegateParams*)__Parameters)->Canvas);
			action(orCreateUObjectByNativePointer, ((FOnCanvasRenderTargetUpdate.__FOnCanvasRenderTargetUpdate_DelegateParams*)__Parameters)->Width, ((FOnCanvasRenderTargetUpdate.__FOnCanvasRenderTargetUpdate_DelegateParams*)__Parameters)->Height);
		}

		// Token: 0x04007036 RID: 28726
		internal static IntPtr _FunctionPtr;

		// Token: 0x04007037 RID: 28727
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.OnCanvasRenderTargetUpdate__DelegateSignature";

		// Token: 0x04007038 RID: 28728
		private static int RegisterId;

		// Token: 0x02002D65 RID: 11621
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FOnCanvasRenderTargetUpdate_DelegateParams
		{
			// Token: 0x0401677D RID: 92029
			[FieldOffset(0)]
			public IntPtr Canvas;

			// Token: 0x0401677E RID: 92030
			[FieldOffset(8)]
			public int Width;

			// Token: 0x0401677F RID: 92031
			[FieldOffset(12)]
			public int Height;
		}

		// Token: 0x02002D66 RID: 11622
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016780 RID: 92032
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
