using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001949 RID: 6473
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnTakeScreenshotCompressed : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06017FC6 RID: 98246 RVA: 0x00232FF3 File Offset: 0x002311F3
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnTakeScreenshotCompressed.StaticFunctionPtr();
		}

		// Token: 0x06017FC7 RID: 98247 RVA: 0x00232FFF File Offset: 0x002311FF
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnTakeScreenshotCompressed._FunctionPtr == IntPtr.Zero)
			{
				FOnTakeScreenshotCompressed._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameScreenshot.OnTakeScreenshotCompressed__DelegateSignature");
			}
			return FOnTakeScreenshotCompressed._FunctionPtr;
		}

		// Token: 0x06017FC8 RID: 98248 RVA: 0x00233022 File Offset: 0x00231222
		public FOnTakeScreenshotCompressed()
		{
		}

		// Token: 0x06017FC9 RID: 98249 RVA: 0x0023302A File Offset: 0x0023122A
		[NullableContext(2)]
		public FOnTakeScreenshotCompressed(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06017FCA RID: 98250 RVA: 0x00233034 File Offset: 0x00231234
		public FOnTakeScreenshotCompressed(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06017FCB RID: 98251 RVA: 0x0023303F File Offset: 0x0023123F
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as FOnTakeScreenshotCompressed.FOnTakeScreenshotCompressed_ScriptDelegate) ?? ((FOnTakeScreenshotCompressed.FOnTakeScreenshotCompressed_ScriptDelegate)Delegate.CreateDelegate(typeof(FOnTakeScreenshotCompressed.FOnTakeScreenshotCompressed_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x06017FCC RID: 98252 RVA: 0x00233071 File Offset: 0x00231271
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06017FCD RID: 98253 RVA: 0x002330AB File Offset: 0x002312AB
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(FOnTakeScreenshotCompressed.FOnTakeScreenshotCompressed_ScriptDelegate Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06017FCE RID: 98254 RVA: 0x002330B4 File Offset: 0x002312B4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06017FCF RID: 98255 RVA: 0x00233124 File Offset: 0x00231324
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x0400CF95 RID: 53141
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400CF96 RID: 53142
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameScreenshot.OnTakeScreenshotCompressed__DelegateSignature";

		// Token: 0x0400CF97 RID: 53143
		private static int RegisterId;

		// Token: 0x0200301C RID: 12316
		// (Invoke) Token: 0x0602858A RID: 165258
		public delegate void FOnTakeScreenshotCompressed_ScriptDelegate(in TArray<byte> CompressedBitMap);

		// Token: 0x0200301D RID: 12317
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FOnTakeScreenshotCompressed_DelegateParams
		{
			// Token: 0x04016C53 RID: 93267
			[FieldOffset(0)]
			public byte CompressedBitMap;
		}

		// Token: 0x0200301E RID: 12318
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016C54 RID: 93268
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
