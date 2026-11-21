using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005A8 RID: 1448
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FKuroOnPatchResultDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06008274 RID: 33396 RVA: 0x000C0E71 File Offset: 0x000BF071
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroOnPatchResultDelegate.StaticFunctionPtr();
		}

		// Token: 0x06008275 RID: 33397 RVA: 0x000C0E7D File Offset: 0x000BF07D
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroOnPatchResultDelegate._FunctionPtr == IntPtr.Zero)
			{
				FKuroOnPatchResultDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSoHotPatch.KuroOnPatchResultDelegate__DelegateSignature");
			}
			return FKuroOnPatchResultDelegate._FunctionPtr;
		}

		// Token: 0x06008276 RID: 33398 RVA: 0x000C0EA0 File Offset: 0x000BF0A0
		public FKuroOnPatchResultDelegate()
		{
		}

		// Token: 0x06008277 RID: 33399 RVA: 0x000C0EA8 File Offset: 0x000BF0A8
		[NullableContext(2)]
		public FKuroOnPatchResultDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008278 RID: 33400 RVA: 0x000C0EB2 File Offset: 0x000BF0B2
		public FKuroOnPatchResultDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008279 RID: 33401 RVA: 0x000C0EBD File Offset: 0x000BF0BD
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<bool, string>) ?? ((Action<bool, string>)Delegate.CreateDelegate(typeof(Action<bool, string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600827A RID: 33402 RVA: 0x000C0EEF File Offset: 0x000BF0EF
		[NullableContext(1)]
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

		// Token: 0x0600827B RID: 33403 RVA: 0x000C0F29 File Offset: 0x000BF129
		[NullableContext(1)]
		public void Remove(Action<bool, string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600827C RID: 33404 RVA: 0x000C0F34 File Offset: 0x000BF134
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Broadcast(bool SuccessCount, string ErrorCode)
		{
			FKuroOnPatchResultDelegate.__FKuroOnPatchResultDelegate_DelegateParams* ptr = stackalloc FKuroOnPatchResultDelegate.__FKuroOnPatchResultDelegate_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FKuroOnPatchResultDelegate.__FKuroOnPatchResultDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FKuroOnPatchResultDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->SuccessCount = SuccessCount;
			FString.CopyFrom((void*)(&ptr->ErrorCode), ErrorCode);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FKuroOnPatchResultDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600827D RID: 33405 RVA: 0x000C0F90 File Offset: 0x000BF190
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x040038D5 RID: 14549
		internal static IntPtr _FunctionPtr;

		// Token: 0x040038D6 RID: 14550
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSoHotPatch.KuroOnPatchResultDelegate__DelegateSignature";

		// Token: 0x040038D7 RID: 14551
		private static int RegisterId;

		// Token: 0x02000D29 RID: 3369
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		private ref struct __FKuroOnPatchResultDelegate_DelegateParams
		{
			// Token: 0x04005FBC RID: 24508
			[FieldOffset(0)]
			public bool SuccessCount;

			// Token: 0x04005FBD RID: 24509
			[FieldOffset(8)]
			public FString ErrorCode;
		}

		// Token: 0x02000D2A RID: 3370
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005FBE RID: 24510
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
