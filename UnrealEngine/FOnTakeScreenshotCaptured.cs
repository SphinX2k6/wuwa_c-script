using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001948 RID: 6472
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnTakeScreenshotCaptured : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06017FBC RID: 98236 RVA: 0x00232E3A File Offset: 0x0023103A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnTakeScreenshotCaptured.StaticFunctionPtr();
		}

		// Token: 0x06017FBD RID: 98237 RVA: 0x00232E46 File Offset: 0x00231046
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnTakeScreenshotCaptured._FunctionPtr == IntPtr.Zero)
			{
				FOnTakeScreenshotCaptured._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameScreenshot.OnTakeScreenshotCaptured__DelegateSignature");
			}
			return FOnTakeScreenshotCaptured._FunctionPtr;
		}

		// Token: 0x06017FBE RID: 98238 RVA: 0x00232E69 File Offset: 0x00231069
		public FOnTakeScreenshotCaptured()
		{
		}

		// Token: 0x06017FBF RID: 98239 RVA: 0x00232E71 File Offset: 0x00231071
		[NullableContext(2)]
		public FOnTakeScreenshotCaptured(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06017FC0 RID: 98240 RVA: 0x00232E7B File Offset: 0x0023107B
		public FOnTakeScreenshotCaptured(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06017FC1 RID: 98241 RVA: 0x00232E86 File Offset: 0x00231086
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as FOnTakeScreenshotCaptured.FOnTakeScreenshotCaptured_ScriptDelegate) ?? ((FOnTakeScreenshotCaptured.FOnTakeScreenshotCaptured_ScriptDelegate)Delegate.CreateDelegate(typeof(FOnTakeScreenshotCaptured.FOnTakeScreenshotCaptured_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x06017FC2 RID: 98242 RVA: 0x00232EB8 File Offset: 0x002310B8
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(FOnTakeScreenshotCaptured.FOnTakeScreenshotCaptured_ScriptDelegate Callback)
		{
			if (FOnTakeScreenshotCaptured.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnTakeScreenshotCaptured.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnTakeScreenshotCaptured.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnTakeScreenshotCaptured.OnScriptCallback));
				}
				FOnTakeScreenshotCaptured.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnTakeScreenshotCaptured.RegisterId);
		}

		// Token: 0x06017FC3 RID: 98243 RVA: 0x00232EF2 File Offset: 0x002310F2
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(FOnTakeScreenshotCaptured.FOnTakeScreenshotCaptured_ScriptDelegate Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06017FC4 RID: 98244 RVA: 0x00232EFC File Offset: 0x002310FC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(int Width, int Height, in TArray<FColor> Colors)
		{
			FOnTakeScreenshotCaptured.__FOnTakeScreenshotCaptured_DelegateParams* ptr = stackalloc FOnTakeScreenshotCaptured.__FOnTakeScreenshotCaptured_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FOnTakeScreenshotCaptured.__FOnTakeScreenshotCaptured_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnTakeScreenshotCaptured.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Width = Width;
			ptr->Height = Height;
			TArray<FColor> tarray = Colors;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Colors);
			}
			base.BroadcastInternal((void*)ptr);
			TArray<FColor> tarray2 = Colors;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->Colors);
			}
			UnrealReflectionUtils.DestroyStruct(FOnTakeScreenshotCaptured._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06017FC5 RID: 98245 RVA: 0x00232F78 File Offset: 0x00231178
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			FOnTakeScreenshotCaptured.FOnTakeScreenshotCaptured_ScriptDelegate fonTakeScreenshotCaptured_ScriptDelegate = target as FOnTakeScreenshotCaptured.FOnTakeScreenshotCaptured_ScriptDelegate;
			if (fonTakeScreenshotCaptured_ScriptDelegate == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			TArray<FColor> tarray = new TArray<FColor>(&((FOnTakeScreenshotCaptured.__FOnTakeScreenshotCaptured_DelegateParams*)__Parameters)->Colors, true, true);
			fonTakeScreenshotCaptured_ScriptDelegate(((FOnTakeScreenshotCaptured.__FOnTakeScreenshotCaptured_DelegateParams*)__Parameters)->Width, ((FOnTakeScreenshotCaptured.__FOnTakeScreenshotCaptured_DelegateParams*)__Parameters)->Height, tarray);
			if (tarray != null)
			{
				tarray.CopyTo(&((FOnTakeScreenshotCaptured.__FOnTakeScreenshotCaptured_DelegateParams*)__Parameters)->Colors, default(UScriptStructStackOnlyPtr));
			}
		}

		// Token: 0x0400CF92 RID: 53138
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400CF93 RID: 53139
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameScreenshot.OnTakeScreenshotCaptured__DelegateSignature";

		// Token: 0x0400CF94 RID: 53140
		private static int RegisterId;

		// Token: 0x02003019 RID: 12313
		// (Invoke) Token: 0x06028586 RID: 165254
		public delegate void FOnTakeScreenshotCaptured_ScriptDelegate(int Width, int Height, in TArray<FColor> Colors);

		// Token: 0x0200301A RID: 12314
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FOnTakeScreenshotCaptured_DelegateParams
		{
			// Token: 0x04016C4F RID: 93263
			[FieldOffset(0)]
			public int Width;

			// Token: 0x04016C50 RID: 93264
			[FieldOffset(4)]
			public int Height;

			// Token: 0x04016C51 RID: 93265
			[FieldOffset(8)]
			public byte Colors;
		}

		// Token: 0x0200301B RID: 12315
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016C52 RID: 93266
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
