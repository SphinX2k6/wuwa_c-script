using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001007 RID: 4103
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FPlatformScreenOrientationChangedDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600DE22 RID: 56866 RVA: 0x00147746 File Offset: 0x00145946
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FPlatformScreenOrientationChangedDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600DE23 RID: 56867 RVA: 0x00147752 File Offset: 0x00145952
		private static IntPtr StaticFunctionPtr()
		{
			if (UPlatformGameInstance.__PlatformScreenOrientationChangedDelegate__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UPlatformGameInstance.__PlatformScreenOrientationChangedDelegate__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.PlatformGameInstance:PlatformScreenOrientationChangedDelegate__DelegateSignature");
			}
			return UPlatformGameInstance.__PlatformScreenOrientationChangedDelegate__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0600DE24 RID: 56868 RVA: 0x00147775 File Offset: 0x00145975
		public FPlatformScreenOrientationChangedDelegate()
		{
		}

		// Token: 0x0600DE25 RID: 56869 RVA: 0x0014777D File Offset: 0x0014597D
		[NullableContext(2)]
		public FPlatformScreenOrientationChangedDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600DE26 RID: 56870 RVA: 0x00147787 File Offset: 0x00145987
		public FPlatformScreenOrientationChangedDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600DE27 RID: 56871 RVA: 0x00147792 File Offset: 0x00145992
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<TEnumAsByte<EScreenOrientation>>) ?? ((Action<TEnumAsByte<EScreenOrientation>>)Delegate.CreateDelegate(typeof(Action<TEnumAsByte<EScreenOrientation>>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600DE28 RID: 56872 RVA: 0x001477C4 File Offset: 0x001459C4
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			0
		})] Action<TEnumAsByte<EScreenOrientation>> Callback)
		{
			if (FPlatformScreenOrientationChangedDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FPlatformScreenOrientationChangedDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FPlatformScreenOrientationChangedDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FPlatformScreenOrientationChangedDelegate.OnScriptCallback));
				}
				FPlatformScreenOrientationChangedDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FPlatformScreenOrientationChangedDelegate.RegisterId);
		}

		// Token: 0x0600DE29 RID: 56873 RVA: 0x001477FE File Offset: 0x001459FE
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			0
		})] Action<TEnumAsByte<EScreenOrientation>> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600DE2A RID: 56874 RVA: 0x00147808 File Offset: 0x00145A08
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(EScreenOrientation inScreenOrientation)
		{
			FPlatformScreenOrientationChangedDelegate.__FPlatformScreenOrientationChangedDelegate_DelegateParams* ptr = stackalloc FPlatformScreenOrientationChangedDelegate.__FPlatformScreenOrientationChangedDelegate_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FPlatformScreenOrientationChangedDelegate.__FPlatformScreenOrientationChangedDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FPlatformScreenOrientationChangedDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->inScreenOrientation = inScreenOrientation;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600DE2B RID: 56875 RVA: 0x0014784C File Offset: 0x00145A4C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<TEnumAsByte<EScreenOrientation>> action = target as Action<TEnumAsByte<EScreenOrientation>>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FPlatformScreenOrientationChangedDelegate.__FPlatformScreenOrientationChangedDelegate_DelegateParams*)__Parameters)->inScreenOrientation);
		}

		// Token: 0x0400780A RID: 30730
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.PlatformGameInstance:PlatformScreenOrientationChangedDelegate__DelegateSignature";

		// Token: 0x0400780B RID: 30731
		private static int RegisterId;

		// Token: 0x02002DD4 RID: 11732
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __FPlatformScreenOrientationChangedDelegate_DelegateParams
		{
			// Token: 0x04016811 RID: 92177
			[FieldOffset(0)]
			public TEnumAsByte<EScreenOrientation> inScreenOrientation;
		}

		// Token: 0x02002DD5 RID: 11733
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016812 RID: 92178
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
