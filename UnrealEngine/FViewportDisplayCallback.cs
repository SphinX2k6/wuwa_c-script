using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200122C RID: 4652
	public sealed class FViewportDisplayCallback : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060111CA RID: 70090 RVA: 0x00191B52 File Offset: 0x0018FD52
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FViewportDisplayCallback.StaticFunctionPtr();
		}

		// Token: 0x060111CB RID: 70091 RVA: 0x00191B5E File Offset: 0x0018FD5E
		private static IntPtr StaticFunctionPtr()
		{
			if (FViewportDisplayCallback._FunctionPtr == IntPtr.Zero)
			{
				FViewportDisplayCallback._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ViewportDisplayCallback__DelegateSignature");
			}
			return FViewportDisplayCallback._FunctionPtr;
		}

		// Token: 0x060111CC RID: 70092 RVA: 0x00191B81 File Offset: 0x0018FD81
		public FViewportDisplayCallback()
		{
		}

		// Token: 0x060111CD RID: 70093 RVA: 0x00191B89 File Offset: 0x0018FD89
		[NullableContext(2)]
		public FViewportDisplayCallback(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060111CE RID: 70094 RVA: 0x00191B93 File Offset: 0x0018FD93
		public FViewportDisplayCallback(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060111CF RID: 70095 RVA: 0x00191B9E File Offset: 0x0018FD9E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as FViewportDisplayCallback.FViewportDisplayCallback_ScriptDelegate) ?? ((FViewportDisplayCallback.FViewportDisplayCallback_ScriptDelegate)Delegate.CreateDelegate(typeof(FViewportDisplayCallback.FViewportDisplayCallback_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x060111D0 RID: 70096 RVA: 0x00191BD0 File Offset: 0x0018FDD0
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(FViewportDisplayCallback.FViewportDisplayCallback_ScriptDelegate Callback)
		{
			if (FViewportDisplayCallback.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FViewportDisplayCallback.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FViewportDisplayCallback.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FViewportDisplayCallback.OnScriptCallback));
				}
				FViewportDisplayCallback.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FViewportDisplayCallback.RegisterId);
		}

		// Token: 0x060111D1 RID: 70097 RVA: 0x00191C0C File Offset: 0x0018FE0C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool Execute(ref FText OutText, ref FLinearColor OutColor)
		{
			FViewportDisplayCallback.__FViewportDisplayCallback_DelegateParams* ptr = stackalloc FViewportDisplayCallback.__FViewportDisplayCallback_DelegateParams[(UIntPtr)63] + 15L / (long)sizeof(FViewportDisplayCallback.__FViewportDisplayCallback_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FViewportDisplayCallback.StaticFunctionPtr(), (void*)ptr, 1);
			FText.NativeMove((void*)(&ptr->OutText), OutText.NativePtr);
			ptr->OutColor = OutColor;
			base.ExecuteInternal((void*)ptr);
			FText.NativeMove(OutText.NativePtr, (void*)(&ptr->OutText));
			OutColor = ptr->OutColor;
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(FViewportDisplayCallback._FunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x060111D2 RID: 70098 RVA: 0x00191C98 File Offset: 0x0018FE98
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			FViewportDisplayCallback.FViewportDisplayCallback_ScriptDelegate fviewportDisplayCallback_ScriptDelegate = target as FViewportDisplayCallback.FViewportDisplayCallback_ScriptDelegate;
			if (fviewportDisplayCallback_ScriptDelegate == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			FText ftext = new FText(&((FViewportDisplayCallback.__FViewportDisplayCallback_DelegateParams*)__Parameters)->OutText, true, true);
			bool _Result = fviewportDisplayCallback_ScriptDelegate(ref ftext, ref ((FViewportDisplayCallback.__FViewportDisplayCallback_DelegateParams*)__Parameters)->OutColor);
			FText.NativeCopy((void*)(&((FViewportDisplayCallback.__FViewportDisplayCallback_DelegateParams*)__Parameters)->OutText), ftext.NativePtr, 1);
			((FViewportDisplayCallback.__FViewportDisplayCallback_DelegateParams*)__Parameters)->__Result = _Result;
		}

		// Token: 0x0400928C RID: 37516
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400928D RID: 37517
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ViewportDisplayCallback__DelegateSignature";

		// Token: 0x0400928E RID: 37518
		private static int RegisterId;

		// Token: 0x02002E03 RID: 11779
		// (Invoke) Token: 0x0602855E RID: 165214
		public delegate bool FViewportDisplayCallback_ScriptDelegate(ref FText OutText, ref FLinearColor OutColor);

		// Token: 0x02002E04 RID: 11780
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __FViewportDisplayCallback_DelegateParams
		{
			// Token: 0x0401686C RID: 92268
			[FieldOffset(0)]
			public byte OutText;

			// Token: 0x0401686D RID: 92269
			[FieldOffset(24)]
			public FLinearColor OutColor;

			// Token: 0x0401686E RID: 92270
			[FieldOffset(40)]
			public bool __Result;
		}

		// Token: 0x02002E05 RID: 11781
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401686F RID: 92271
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
