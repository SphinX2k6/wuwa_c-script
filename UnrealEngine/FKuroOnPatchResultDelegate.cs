using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E75 RID: 7797
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FKuroOnPatchResultDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601DB0A RID: 121610 RVA: 0x002BDB95 File Offset: 0x002BBD95
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroOnPatchResultDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601DB0B RID: 121611 RVA: 0x002BDBA1 File Offset: 0x002BBDA1
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroOnPatchResultDelegate._FunctionPtr == IntPtr.Zero)
			{
				FKuroOnPatchResultDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSoHotPatch.KuroOnPatchResultDelegate__DelegateSignature");
			}
			return FKuroOnPatchResultDelegate._FunctionPtr;
		}

		// Token: 0x0601DB0C RID: 121612 RVA: 0x002BDBC4 File Offset: 0x002BBDC4
		public FKuroOnPatchResultDelegate()
		{
		}

		// Token: 0x0601DB0D RID: 121613 RVA: 0x002BDBCC File Offset: 0x002BBDCC
		[NullableContext(2)]
		public FKuroOnPatchResultDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601DB0E RID: 121614 RVA: 0x002BDBD6 File Offset: 0x002BBDD6
		public FKuroOnPatchResultDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601DB0F RID: 121615 RVA: 0x002BDBE1 File Offset: 0x002BBDE1
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<bool, string>) ?? ((Action<bool, string>)Delegate.CreateDelegate(typeof(Action<bool, string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601DB10 RID: 121616 RVA: 0x002BDC13 File Offset: 0x002BBE13
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<bool, string> Callback)
		{
			if (FKuroOnPatchResultDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FKuroOnPatchResultDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FKuroOnPatchResultDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FKuroOnPatchResultDelegate.OnScriptCallback));
				}
				FKuroOnPatchResultDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FKuroOnPatchResultDelegate.RegisterId);
		}

		// Token: 0x0601DB11 RID: 121617 RVA: 0x002BDC4D File Offset: 0x002BBE4D
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<bool, string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601DB12 RID: 121618 RVA: 0x002BDC58 File Offset: 0x002BBE58
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(bool SuccessCount, string ErrorCode)
		{
			FKuroOnPatchResultDelegate.__FKuroOnPatchResultDelegate_DelegateParams* ptr = stackalloc FKuroOnPatchResultDelegate.__FKuroOnPatchResultDelegate_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FKuroOnPatchResultDelegate.__FKuroOnPatchResultDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FKuroOnPatchResultDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->SuccessCount = SuccessCount;
			FString.CopyFrom((void*)(&ptr->ErrorCode), ErrorCode);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FKuroOnPatchResultDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601DB13 RID: 121619 RVA: 0x002BDCB4 File Offset: 0x002BBEB4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool, string> action = target as Action<bool, string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string arg = FString.ToString((void*)(&((FKuroOnPatchResultDelegate.__FKuroOnPatchResultDelegate_DelegateParams*)__Parameters)->ErrorCode));
			action(((FKuroOnPatchResultDelegate.__FKuroOnPatchResultDelegate_DelegateParams*)__Parameters)->SuccessCount, arg);
		}

		// Token: 0x04010140 RID: 65856
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010141 RID: 65857
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSoHotPatch.KuroOnPatchResultDelegate__DelegateSignature";

		// Token: 0x04010142 RID: 65858
		private static int RegisterId;

		// Token: 0x020032CA RID: 13002
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FKuroOnPatchResultDelegate_DelegateParams
		{
			// Token: 0x04017170 RID: 94576
			[FieldOffset(0)]
			public bool SuccessCount;

			// Token: 0x04017171 RID: 94577
			[FieldOffset(8)]
			public FString ErrorCode;
		}

		// Token: 0x020032CB RID: 13003
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017172 RID: 94578
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
