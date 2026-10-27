using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000EF RID: 239
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FAIMoveCompletedSignature : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060012CA RID: 4810 RVA: 0x0001BD3E File Offset: 0x00019F3E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FAIMoveCompletedSignature.StaticFunctionPtr();
		}

		// Token: 0x060012CB RID: 4811 RVA: 0x0001BD4A File Offset: 0x00019F4A
		private static IntPtr StaticFunctionPtr()
		{
			if (FAIMoveCompletedSignature._FunctionPtr == IntPtr.Zero)
			{
				FAIMoveCompletedSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/AIModule.AIMoveCompletedSignature__DelegateSignature");
			}
			return FAIMoveCompletedSignature._FunctionPtr;
		}

		// Token: 0x060012CC RID: 4812 RVA: 0x0001BD6D File Offset: 0x00019F6D
		public FAIMoveCompletedSignature()
		{
		}

		// Token: 0x060012CD RID: 4813 RVA: 0x0001BD75 File Offset: 0x00019F75
		[NullableContext(2)]
		public FAIMoveCompletedSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060012CE RID: 4814 RVA: 0x0001BD7F File Offset: 0x00019F7F
		public FAIMoveCompletedSignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060012CF RID: 4815 RVA: 0x0001BD8A File Offset: 0x00019F8A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FAIRequestID, TEnumAsByte<EPathFollowingResult>>) ?? ((Action<FAIRequestID, TEnumAsByte<EPathFollowingResult>>)Delegate.CreateDelegate(typeof(Action<FAIRequestID, TEnumAsByte<EPathFollowingResult>>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060012D0 RID: 4816 RVA: 0x0001BDBC File Offset: 0x00019FBC
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			1,
			0
		})] Action<FAIRequestID, TEnumAsByte<EPathFollowingResult>> Callback)
		{
			if (FAIMoveCompletedSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FAIMoveCompletedSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FAIMoveCompletedSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FAIMoveCompletedSignature.OnScriptCallback));
				}
				FAIMoveCompletedSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FAIMoveCompletedSignature.RegisterId);
		}

		// Token: 0x060012D1 RID: 4817 RVA: 0x0001BDF6 File Offset: 0x00019FF6
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			1,
			0
		})] Action<FAIRequestID, TEnumAsByte<EPathFollowingResult>> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060012D2 RID: 4818 RVA: 0x0001BE00 File Offset: 0x0001A000
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(FAIRequestID RequestID, EPathFollowingResult Result)
		{
			FAIMoveCompletedSignature.__FAIMoveCompletedSignature_DelegateParams* ptr = stackalloc FAIMoveCompletedSignature.__FAIMoveCompletedSignature_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FAIMoveCompletedSignature.__FAIMoveCompletedSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FAIMoveCompletedSignature.StaticFunctionPtr(), (void*)ptr, 1);
			if (RequestID != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FAIRequestID.StaticStruct(), &ptr->RequestID, RequestID.NativePtr, 1, false);
			}
			ptr->Result = Result;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060012D3 RID: 4819 RVA: 0x0001BE64 File Offset: 0x0001A064
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FAIRequestID, TEnumAsByte<EPathFollowingResult>> action = target as Action<FAIRequestID, TEnumAsByte<EPathFollowingResult>>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			FAIRequestID arg = new FAIRequestID(&((FAIMoveCompletedSignature.__FAIMoveCompletedSignature_DelegateParams*)__Parameters)->RequestID, true, true);
			action(arg, ((FAIMoveCompletedSignature.__FAIMoveCompletedSignature_DelegateParams*)__Parameters)->Result);
		}

		// Token: 0x0400034D RID: 845
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400034E RID: 846
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AIModule.AIMoveCompletedSignature__DelegateSignature";

		// Token: 0x0400034F RID: 847
		private static int RegisterId;

		// Token: 0x02002B41 RID: 11073
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FAIMoveCompletedSignature_DelegateParams
		{
			// Token: 0x040163A1 RID: 91041
			[FieldOffset(0)]
			public byte RequestID;

			// Token: 0x040163A2 RID: 91042
			[FieldOffset(4)]
			public TEnumAsByte<EPathFollowingResult> Result;
		}

		// Token: 0x02002B42 RID: 11074
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040163A3 RID: 91043
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
