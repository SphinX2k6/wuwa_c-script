using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200028C RID: 652
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnBoolPropertyDropDetected : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06002498 RID: 9368 RVA: 0x0003643F File Offset: 0x0003463F
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnBoolPropertyDropDetected.StaticFunctionPtr();
		}

		// Token: 0x06002499 RID: 9369 RVA: 0x0003644B File Offset: 0x0003464B
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnBoolPropertyDropDetected._FunctionPtr == IntPtr.Zero)
			{
				FOnBoolPropertyDropDetected._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/AkAudio.OnBoolPropertyDropDetected__DelegateSignature");
			}
			return FOnBoolPropertyDropDetected._FunctionPtr;
		}

		// Token: 0x0600249A RID: 9370 RVA: 0x0003646E File Offset: 0x0003466E
		public FOnBoolPropertyDropDetected()
		{
		}

		// Token: 0x0600249B RID: 9371 RVA: 0x00036476 File Offset: 0x00034676
		[NullableContext(2)]
		public FOnBoolPropertyDropDetected(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600249C RID: 9372 RVA: 0x00036480 File Offset: 0x00034680
		public FOnBoolPropertyDropDetected(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600249D RID: 9373 RVA: 0x0003648B File Offset: 0x0003468B
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600249E RID: 9374 RVA: 0x000364BD File Offset: 0x000346BD
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<string> Callback)
		{
			if (FOnBoolPropertyDropDetected.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnBoolPropertyDropDetected.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnBoolPropertyDropDetected.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnBoolPropertyDropDetected.OnScriptCallback));
				}
				FOnBoolPropertyDropDetected.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnBoolPropertyDropDetected.RegisterId);
		}

		// Token: 0x0600249F RID: 9375 RVA: 0x000364F7 File Offset: 0x000346F7
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060024A0 RID: 9376 RVA: 0x00036500 File Offset: 0x00034700
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(string PropertyDropped)
		{
			FOnBoolPropertyDropDetected.__FOnBoolPropertyDropDetected_DelegateParams* ptr = stackalloc FOnBoolPropertyDropDetected.__FOnBoolPropertyDropDetected_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnBoolPropertyDropDetected.__FOnBoolPropertyDropDetected_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnBoolPropertyDropDetected.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->PropertyDropped), PropertyDropped);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FOnBoolPropertyDropDetected._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060024A1 RID: 9377 RVA: 0x00036554 File Offset: 0x00034754
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<string> action = target as Action<string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string obj = FString.ToString((void*)(&((FOnBoolPropertyDropDetected.__FOnBoolPropertyDropDetected_DelegateParams*)__Parameters)->PropertyDropped));
			action(obj);
		}

		// Token: 0x04000DEE RID: 3566
		internal static IntPtr _FunctionPtr;

		// Token: 0x04000DEF RID: 3567
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AkAudio.OnBoolPropertyDropDetected__DelegateSignature";

		// Token: 0x04000DF0 RID: 3568
		private static int RegisterId;

		// Token: 0x02002B8D RID: 11149
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FOnBoolPropertyDropDetected_DelegateParams
		{
			// Token: 0x04016421 RID: 91169
			[FieldOffset(0)]
			public FString PropertyDropped;
		}

		// Token: 0x02002B8E RID: 11150
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016422 RID: 91170
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
