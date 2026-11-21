using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200038C RID: 908
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnStopTrackTarget : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06005AF6 RID: 23286 RVA: 0x00080782 File Offset: 0x0007E982
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnStopTrackTarget.StaticFunctionPtr();
		}

		// Token: 0x06005AF7 RID: 23287 RVA: 0x0008078E File Offset: 0x0007E98E
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnStopTrackTarget._FunctionPtr == IntPtr.Zero)
			{
				FOnStopTrackTarget._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroFauxPhysics.OnStopTrackTarget__DelegateSignature");
			}
			return FOnStopTrackTarget._FunctionPtr;
		}

		// Token: 0x06005AF8 RID: 23288 RVA: 0x000807B1 File Offset: 0x0007E9B1
		public FOnStopTrackTarget()
		{
		}

		// Token: 0x06005AF9 RID: 23289 RVA: 0x000807B9 File Offset: 0x0007E9B9
		[NullableContext(2)]
		public FOnStopTrackTarget(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005AFA RID: 23290 RVA: 0x000807C3 File Offset: 0x0007E9C3
		public FOnStopTrackTarget(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005AFB RID: 23291 RVA: 0x000807CE File Offset: 0x0007E9CE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FVector>) ?? ((Action<FVector>)Delegate.CreateDelegate(typeof(Action<FVector>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06005AFC RID: 23292 RVA: 0x00080800 File Offset: 0x0007EA00
		[NullableContext(1)]
		public void Add(Action<FVector> Callback)
		{
			if (FOnStopTrackTarget.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnStopTrackTarget.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnStopTrackTarget.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnStopTrackTarget.OnScriptCallback));
				}
				FOnStopTrackTarget.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnStopTrackTarget.RegisterId);
		}

		// Token: 0x06005AFD RID: 23293 RVA: 0x0008083A File Offset: 0x0007EA3A
		[NullableContext(1)]
		public void Remove(Action<FVector> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06005AFE RID: 23294 RVA: 0x00080844 File Offset: 0x0007EA44
		[SkipLocalsInit]
		public unsafe void Broadcast(FVector CurrentLinearVelocity)
		{
			FOnStopTrackTarget.__FOnStopTrackTarget_DelegateParams* ptr = stackalloc FOnStopTrackTarget.__FOnStopTrackTarget_DelegateParams[(UIntPtr)27] + 15L / (long)sizeof(FOnStopTrackTarget.__FOnStopTrackTarget_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnStopTrackTarget.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->CurrentLinearVelocity = CurrentLinearVelocity;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06005AFF RID: 23295 RVA: 0x00080880 File Offset: 0x0007EA80
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FVector> action = target as Action<FVector>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnStopTrackTarget.__FOnStopTrackTarget_DelegateParams*)__Parameters)->CurrentLinearVelocity);
		}

		// Token: 0x040025CE RID: 9678
		internal static IntPtr _FunctionPtr;

		// Token: 0x040025CF RID: 9679
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroFauxPhysics.OnStopTrackTarget__DelegateSignature";

		// Token: 0x040025D0 RID: 9680
		private static int RegisterId;

		// Token: 0x02000A97 RID: 2711
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		private ref struct __FOnStopTrackTarget_DelegateParams
		{
			// Token: 0x04005AEB RID: 23275
			[FieldOffset(0)]
			public FVector CurrentLinearVelocity;
		}

		// Token: 0x02000A98 RID: 2712
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005AEC RID: 23276
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
