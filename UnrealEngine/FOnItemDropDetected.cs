using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000291 RID: 657
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnItemDropDetected : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060024C9 RID: 9417 RVA: 0x00036B98 File Offset: 0x00034D98
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnItemDropDetected.StaticFunctionPtr();
		}

		// Token: 0x060024CA RID: 9418 RVA: 0x00036BA4 File Offset: 0x00034DA4
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnItemDropDetected._FunctionPtr == IntPtr.Zero)
			{
				FOnItemDropDetected._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/AkAudio.OnItemDropDetected__DelegateSignature");
			}
			return FOnItemDropDetected._FunctionPtr;
		}

		// Token: 0x060024CB RID: 9419 RVA: 0x00036BC7 File Offset: 0x00034DC7
		public FOnItemDropDetected()
		{
		}

		// Token: 0x060024CC RID: 9420 RVA: 0x00036BCF File Offset: 0x00034DCF
		[NullableContext(2)]
		public FOnItemDropDetected(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060024CD RID: 9421 RVA: 0x00036BD9 File Offset: 0x00034DD9
		public FOnItemDropDetected(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060024CE RID: 9422 RVA: 0x00036BE4 File Offset: 0x00034DE4
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FGuid>) ?? ((Action<FGuid>)Delegate.CreateDelegate(typeof(Action<FGuid>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060024CF RID: 9423 RVA: 0x00036C16 File Offset: 0x00034E16
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<FGuid> Callback)
		{
			if (FOnItemDropDetected.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnItemDropDetected.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnItemDropDetected.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnItemDropDetected.OnScriptCallback));
				}
				FOnItemDropDetected.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnItemDropDetected.RegisterId);
		}

		// Token: 0x060024D0 RID: 9424 RVA: 0x00036C50 File Offset: 0x00034E50
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<FGuid> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060024D1 RID: 9425 RVA: 0x00036C5C File Offset: 0x00034E5C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(FGuid ItemDroppedID)
		{
			FOnItemDropDetected.__FOnItemDropDetected_DelegateParams* ptr = stackalloc FOnItemDropDetected.__FOnItemDropDetected_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnItemDropDetected.__FOnItemDropDetected_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnItemDropDetected.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->ItemDroppedID = ItemDroppedID;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060024D2 RID: 9426 RVA: 0x00036C98 File Offset: 0x00034E98
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
			action(((FOnItemDropDetected.__FOnItemDropDetected_DelegateParams*)__Parameters)->ItemDroppedID);
		}

		// Token: 0x04000DFD RID: 3581
		internal static IntPtr _FunctionPtr;

		// Token: 0x04000DFE RID: 3582
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AkAudio.OnItemDropDetected__DelegateSignature";

		// Token: 0x04000DFF RID: 3583
		private static int RegisterId;

		// Token: 0x02002B97 RID: 11159
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FOnItemDropDetected_DelegateParams
		{
			// Token: 0x0401642D RID: 91181
			[FieldOffset(0)]
			public FGuid ItemDroppedID;
		}

		// Token: 0x02002B98 RID: 11160
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401642E RID: 91182
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
