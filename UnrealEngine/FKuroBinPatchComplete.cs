using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001982 RID: 6530
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FKuroBinPatchComplete : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06018418 RID: 99352 RVA: 0x0023C6A7 File Offset: 0x0023A8A7
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroBinPatchComplete.StaticFunctionPtr();
		}

		// Token: 0x06018419 RID: 99353 RVA: 0x0023C6B3 File Offset: 0x0023A8B3
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroBinPatchComplete._FunctionPtr == IntPtr.Zero)
			{
				FKuroBinPatchComplete._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroHotPatch.KuroBinPatchComplete__DelegateSignature");
			}
			return FKuroBinPatchComplete._FunctionPtr;
		}

		// Token: 0x0601841A RID: 99354 RVA: 0x0023C6D6 File Offset: 0x0023A8D6
		public FKuroBinPatchComplete()
		{
		}

		// Token: 0x0601841B RID: 99355 RVA: 0x0023C6DE File Offset: 0x0023A8DE
		[NullableContext(2)]
		public FKuroBinPatchComplete(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601841C RID: 99356 RVA: 0x0023C6E8 File Offset: 0x0023A8E8
		public FKuroBinPatchComplete(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601841D RID: 99357 RVA: 0x0023C6F3 File Offset: 0x0023A8F3
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int, TArray<string>>) ?? ((Action<int, TArray<string>>)Delegate.CreateDelegate(typeof(Action<int, TArray<string>>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601841E RID: 99358 RVA: 0x0023C725 File Offset: 0x0023A925
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<int, TArray<string>> Callback)
		{
			if (FKuroBinPatchComplete.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FKuroBinPatchComplete.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FKuroBinPatchComplete.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FKuroBinPatchComplete.OnScriptCallback));
				}
				FKuroBinPatchComplete.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FKuroBinPatchComplete.RegisterId);
		}

		// Token: 0x0601841F RID: 99359 RVA: 0x0023C75F File Offset: 0x0023A95F
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<int, TArray<string>> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06018420 RID: 99360 RVA: 0x0023C768 File Offset: 0x0023A968
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(int ResultCode, [Nullable(new byte[]
		{
			2,
			1
		})] TArray<string> SucFiles)
		{
			FKuroBinPatchComplete.__FKuroBinPatchComplete_DelegateParams* ptr = stackalloc FKuroBinPatchComplete.__FKuroBinPatchComplete_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FKuroBinPatchComplete.__FKuroBinPatchComplete_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FKuroBinPatchComplete.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->ResultCode = ResultCode;
			if (SucFiles != null)
			{
				SucFiles.CopyTo(&ptr->SucFiles, default(UScriptStructStackOnlyPtr));
			}
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FKuroBinPatchComplete._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06018421 RID: 99361 RVA: 0x0023C7D0 File Offset: 0x0023A9D0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, TArray<string>> action = target as Action<int, TArray<string>>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			TArray<string> arg = new TArray<string>(&((FKuroBinPatchComplete.__FKuroBinPatchComplete_DelegateParams*)__Parameters)->SucFiles, true, true);
			action(((FKuroBinPatchComplete.__FKuroBinPatchComplete_DelegateParams*)__Parameters)->ResultCode, arg);
		}

		// Token: 0x0400D232 RID: 53810
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400D233 RID: 53811
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroHotPatch.KuroBinPatchComplete__DelegateSignature";

		// Token: 0x0400D234 RID: 53812
		private static int RegisterId;

		// Token: 0x02003079 RID: 12409
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FKuroBinPatchComplete_DelegateParams
		{
			// Token: 0x04016D53 RID: 93523
			[FieldOffset(0)]
			public int ResultCode;

			// Token: 0x04016D54 RID: 93524
			[FieldOffset(8)]
			public byte SucFiles;
		}

		// Token: 0x0200307A RID: 12410
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016D55 RID: 93525
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
