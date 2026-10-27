using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000299 RID: 665
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnWwiseItemDropDetected : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06002516 RID: 9494 RVA: 0x000375B6 File Offset: 0x000357B6
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnWwiseItemDropDetected.StaticFunctionPtr();
		}

		// Token: 0x06002517 RID: 9495 RVA: 0x000375C2 File Offset: 0x000357C2
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnWwiseItemDropDetected._FunctionPtr == IntPtr.Zero)
			{
				FOnWwiseItemDropDetected._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/AkAudio.OnWwiseItemDropDetected__DelegateSignature");
			}
			return FOnWwiseItemDropDetected._FunctionPtr;
		}

		// Token: 0x06002518 RID: 9496 RVA: 0x000375E5 File Offset: 0x000357E5
		public FOnWwiseItemDropDetected()
		{
		}

		// Token: 0x06002519 RID: 9497 RVA: 0x000375ED File Offset: 0x000357ED
		[NullableContext(2)]
		public FOnWwiseItemDropDetected(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600251A RID: 9498 RVA: 0x000375F7 File Offset: 0x000357F7
		public FOnWwiseItemDropDetected(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600251B RID: 9499 RVA: 0x00037602 File Offset: 0x00035802
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FGuid>) ?? ((Action<FGuid>)Delegate.CreateDelegate(typeof(Action<FGuid>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600251C RID: 9500 RVA: 0x00037634 File Offset: 0x00035834
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<FGuid> Callback)
		{
			if (FOnWwiseItemDropDetected.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnWwiseItemDropDetected.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnWwiseItemDropDetected.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnWwiseItemDropDetected.OnScriptCallback));
				}
				FOnWwiseItemDropDetected.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnWwiseItemDropDetected.RegisterId);
		}

		// Token: 0x0600251D RID: 9501 RVA: 0x0003766E File Offset: 0x0003586E
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<FGuid> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600251E RID: 9502 RVA: 0x00037678 File Offset: 0x00035878
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(FGuid ItemDroppedID)
		{
			FOnWwiseItemDropDetected.__FOnWwiseItemDropDetected_DelegateParams* ptr = stackalloc FOnWwiseItemDropDetected.__FOnWwiseItemDropDetected_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnWwiseItemDropDetected.__FOnWwiseItemDropDetected_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnWwiseItemDropDetected.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->ItemDroppedID = ItemDroppedID;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600251F RID: 9503 RVA: 0x000376B4 File Offset: 0x000358B4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FGuid> action = target as Action<FGuid>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnWwiseItemDropDetected.__FOnWwiseItemDropDetected_DelegateParams*)__Parameters)->ItemDroppedID);
		}

		// Token: 0x04000E15 RID: 3605
		internal static IntPtr _FunctionPtr;

		// Token: 0x04000E16 RID: 3606
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AkAudio.OnWwiseItemDropDetected__DelegateSignature";

		// Token: 0x04000E17 RID: 3607
		private static int RegisterId;

		// Token: 0x02002BA5 RID: 11173
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FOnWwiseItemDropDetected_DelegateParams
		{
			// Token: 0x0401643B RID: 91195
			[FieldOffset(0)]
			public FGuid ItemDroppedID;
		}

		// Token: 0x02002BA6 RID: 11174
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401643C RID: 91196
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
