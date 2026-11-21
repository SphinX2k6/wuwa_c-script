using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000428 RID: 1064
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnTakeScreenshotCaptured : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600665F RID: 26207 RVA: 0x00093486 File Offset: 0x00091686
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnTakeScreenshotCaptured.StaticFunctionPtr();
		}

		// Token: 0x06006660 RID: 26208 RVA: 0x00093492 File Offset: 0x00091692
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnTakeScreenshotCaptured._FunctionPtr == IntPtr.Zero)
			{
				FOnTakeScreenshotCaptured._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameScreenshot.OnTakeScreenshotCaptured__DelegateSignature");
			}
			return FOnTakeScreenshotCaptured._FunctionPtr;
		}

		// Token: 0x06006661 RID: 26209 RVA: 0x000934B5 File Offset: 0x000916B5
		public FOnTakeScreenshotCaptured()
		{
		}

		// Token: 0x06006662 RID: 26210 RVA: 0x000934BD File Offset: 0x000916BD
		[NullableContext(2)]
		public FOnTakeScreenshotCaptured(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006663 RID: 26211 RVA: 0x000934C7 File Offset: 0x000916C7
		public FOnTakeScreenshotCaptured(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006664 RID: 26212 RVA: 0x000934D2 File Offset: 0x000916D2
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as FOnTakeScreenshotCaptured.FOnTakeScreenshotCaptured_ScriptDelegate) ?? ((FOnTakeScreenshotCaptured.FOnTakeScreenshotCaptured_ScriptDelegate)Delegate.CreateDelegate(typeof(FOnTakeScreenshotCaptured.FOnTakeScreenshotCaptured_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x06006665 RID: 26213 RVA: 0x00093504 File Offset: 0x00091704
		[NullableContext(1)]
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

		// Token: 0x06006666 RID: 26214 RVA: 0x0009353E File Offset: 0x0009173E
		[NullableContext(1)]
		public void Remove(FOnTakeScreenshotCaptured.FOnTakeScreenshotCaptured_ScriptDelegate Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06006667 RID: 26215 RVA: 0x00093548 File Offset: 0x00091748
		[NullableContext(2)]
		[SkipLocalsInit]
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

		// Token: 0x06006668 RID: 26216 RVA: 0x000935C4 File Offset: 0x000917C4
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04002B0C RID: 11020
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002B0D RID: 11021
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameScreenshot.OnTakeScreenshotCaptured__DelegateSignature";

		// Token: 0x04002B0E RID: 11022
		private static int RegisterId;

		// Token: 0x02000B2D RID: 2861
		// (Invoke) Token: 0x0600BEF7 RID: 48887
		public delegate void FOnTakeScreenshotCaptured_ScriptDelegate(int Width, int Height, in TArray<FColor> Colors);

		// Token: 0x02000B2E RID: 2862
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		private ref struct __FOnTakeScreenshotCaptured_DelegateParams
		{
			// Token: 0x04005BF8 RID: 23544
			[FieldOffset(0)]
			public int Width;

			// Token: 0x04005BF9 RID: 23545
			[FieldOffset(4)]
			public int Height;

			// Token: 0x04005BFA RID: 23546
			[FieldOffset(8)]
			public byte Colors;
		}

		// Token: 0x02000B2F RID: 2863
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005BFB RID: 23547
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
