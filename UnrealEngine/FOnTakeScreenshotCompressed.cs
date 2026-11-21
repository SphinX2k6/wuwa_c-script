using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000429 RID: 1065
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnTakeScreenshotCompressed : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06006669 RID: 26217 RVA: 0x0009363F File Offset: 0x0009183F
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnTakeScreenshotCompressed.StaticFunctionPtr();
		}

		// Token: 0x0600666A RID: 26218 RVA: 0x0009364B File Offset: 0x0009184B
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnTakeScreenshotCompressed._FunctionPtr == IntPtr.Zero)
			{
				FOnTakeScreenshotCompressed._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameScreenshot.OnTakeScreenshotCompressed__DelegateSignature");
			}
			return FOnTakeScreenshotCompressed._FunctionPtr;
		}

		// Token: 0x0600666B RID: 26219 RVA: 0x0009366E File Offset: 0x0009186E
		public FOnTakeScreenshotCompressed()
		{
		}

		// Token: 0x0600666C RID: 26220 RVA: 0x00093676 File Offset: 0x00091876
		[NullableContext(2)]
		public FOnTakeScreenshotCompressed(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600666D RID: 26221 RVA: 0x00093680 File Offset: 0x00091880
		public FOnTakeScreenshotCompressed(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600666E RID: 26222 RVA: 0x0009368B File Offset: 0x0009188B
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as FOnTakeScreenshotCompressed.FOnTakeScreenshotCompressed_ScriptDelegate) ?? ((FOnTakeScreenshotCompressed.FOnTakeScreenshotCompressed_ScriptDelegate)Delegate.CreateDelegate(typeof(FOnTakeScreenshotCompressed.FOnTakeScreenshotCompressed_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600666F RID: 26223 RVA: 0x000936BD File Offset: 0x000918BD
		[NullableContext(1)]
		public void Add(FOnTakeScreenshotCompressed.FOnTakeScreenshotCompressed_ScriptDelegate Callback)
		{
			if (FOnTakeScreenshotCompressed.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnTakeScreenshotCompressed.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnTakeScreenshotCompressed.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnTakeScreenshotCompressed.OnScriptCallback));
				}
				FOnTakeScreenshotCompressed.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnTakeScreenshotCompressed.RegisterId);
		}

		// Token: 0x06006670 RID: 26224 RVA: 0x000936F7 File Offset: 0x000918F7
		[NullableContext(1)]
		public void Remove(FOnTakeScreenshotCompressed.FOnTakeScreenshotCompressed_ScriptDelegate Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06006671 RID: 26225 RVA: 0x00093700 File Offset: 0x00091900
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(in TArray<byte> CompressedBitMap)
		{
			FOnTakeScreenshotCompressed.__FOnTakeScreenshotCompressed_DelegateParams* ptr = stackalloc FOnTakeScreenshotCompressed.__FOnTakeScreenshotCompressed_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnTakeScreenshotCompressed.__FOnTakeScreenshotCompressed_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnTakeScreenshotCompressed.StaticFunctionPtr(), (void*)ptr, 1);
			TArray<byte> tarray = CompressedBitMap;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->CompressedBitMap);
			}
			base.BroadcastInternal((void*)ptr);
			TArray<byte> tarray2 = CompressedBitMap;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->CompressedBitMap);
			}
			UnrealReflectionUtils.DestroyStruct(FOnTakeScreenshotCompressed._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06006672 RID: 26226 RVA: 0x00093770 File Offset: 0x00091970
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			FOnTakeScreenshotCompressed.FOnTakeScreenshotCompressed_ScriptDelegate fonTakeScreenshotCompressed_ScriptDelegate = target as FOnTakeScreenshotCompressed.FOnTakeScreenshotCompressed_ScriptDelegate;
			if (fonTakeScreenshotCompressed_ScriptDelegate == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			TArray<byte> tarray = new TArray<byte>(&((FOnTakeScreenshotCompressed.__FOnTakeScreenshotCompressed_DelegateParams*)__Parameters)->CompressedBitMap, true, true);
			fonTakeScreenshotCompressed_ScriptDelegate(tarray);
			if (tarray != null)
			{
				tarray.CopyTo(&((FOnTakeScreenshotCompressed.__FOnTakeScreenshotCompressed_DelegateParams*)__Parameters)->CompressedBitMap, default(UScriptStructStackOnlyPtr));
			}
		}

		// Token: 0x04002B0F RID: 11023
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002B10 RID: 11024
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameScreenshot.OnTakeScreenshotCompressed__DelegateSignature";

		// Token: 0x04002B11 RID: 11025
		private static int RegisterId;

		// Token: 0x02000B30 RID: 2864
		// (Invoke) Token: 0x0600BEFB RID: 48891
		public delegate void FOnTakeScreenshotCompressed_ScriptDelegate(in TArray<byte> CompressedBitMap);

		// Token: 0x02000B31 RID: 2865
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FOnTakeScreenshotCompressed_DelegateParams
		{
			// Token: 0x04005BFC RID: 23548
			[FieldOffset(0)]
			public byte CompressedBitMap;
		}

		// Token: 0x02000B32 RID: 2866
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005BFD RID: 23549
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
