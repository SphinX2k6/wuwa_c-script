using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000403 RID: 1027
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FGeoTrackingAvailabilityDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06003745 RID: 14149 RVA: 0x00053DEB File Offset: 0x00051FEB
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FGeoTrackingAvailabilityDelegate.StaticFunctionPtr();
		}

		// Token: 0x06003746 RID: 14150 RVA: 0x00053DF7 File Offset: 0x00051FF7
		private static IntPtr StaticFunctionPtr()
		{
			if (UCheckGeoTrackingAvailabilityAsyncTaskBlueprintProxy.__GeoTrackingAvailabilityDelegate__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UCheckGeoTrackingAvailabilityAsyncTaskBlueprintProxy.__GeoTrackingAvailabilityDelegate__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/AugmentedReality.CheckGeoTrackingAvailabilityAsyncTaskBlueprintProxy:GeoTrackingAvailabilityDelegate__DelegateSignature");
			}
			return UCheckGeoTrackingAvailabilityAsyncTaskBlueprintProxy.__GeoTrackingAvailabilityDelegate__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x06003747 RID: 14151 RVA: 0x00053E1A File Offset: 0x0005201A
		public FGeoTrackingAvailabilityDelegate()
		{
		}

		// Token: 0x06003748 RID: 14152 RVA: 0x00053E22 File Offset: 0x00052022
		[NullableContext(2)]
		public FGeoTrackingAvailabilityDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003749 RID: 14153 RVA: 0x00053E2C File Offset: 0x0005202C
		public FGeoTrackingAvailabilityDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600374A RID: 14154 RVA: 0x00053E37 File Offset: 0x00052037
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<bool, string>) ?? ((Action<bool, string>)Delegate.CreateDelegate(typeof(Action<bool, string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600374B RID: 14155 RVA: 0x00053E69 File Offset: 0x00052069
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<bool, string> Callback)
		{
			if (FGeoTrackingAvailabilityDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FGeoTrackingAvailabilityDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FGeoTrackingAvailabilityDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FGeoTrackingAvailabilityDelegate.OnScriptCallback));
				}
				FGeoTrackingAvailabilityDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FGeoTrackingAvailabilityDelegate.RegisterId);
		}

		// Token: 0x0600374C RID: 14156 RVA: 0x00053EA3 File Offset: 0x000520A3
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<bool, string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600374D RID: 14157 RVA: 0x00053EAC File Offset: 0x000520AC
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(bool bIsAvailable, string Error)
		{
			FGeoTrackingAvailabilityDelegate.__FGeoTrackingAvailabilityDelegate_DelegateParams* ptr = stackalloc FGeoTrackingAvailabilityDelegate.__FGeoTrackingAvailabilityDelegate_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FGeoTrackingAvailabilityDelegate.__FGeoTrackingAvailabilityDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FGeoTrackingAvailabilityDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->bIsAvailable = bIsAvailable;
			FString.CopyFrom((void*)(&ptr->Error), Error);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UCheckGeoTrackingAvailabilityAsyncTaskBlueprintProxy.__GeoTrackingAvailabilityDelegate__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600374E RID: 14158 RVA: 0x00053F08 File Offset: 0x00052108
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
			string arg = FString.ToString((void*)(&((FGeoTrackingAvailabilityDelegate.__FGeoTrackingAvailabilityDelegate_DelegateParams*)__Parameters)->Error));
			action(((FGeoTrackingAvailabilityDelegate.__FGeoTrackingAvailabilityDelegate_DelegateParams*)__Parameters)->bIsAvailable, arg);
		}

		// Token: 0x04001926 RID: 6438
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AugmentedReality.CheckGeoTrackingAvailabilityAsyncTaskBlueprintProxy:GeoTrackingAvailabilityDelegate__DelegateSignature";

		// Token: 0x04001927 RID: 6439
		private static int RegisterId;

		// Token: 0x02002C1E RID: 11294
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FGeoTrackingAvailabilityDelegate_DelegateParams
		{
			// Token: 0x04016522 RID: 91426
			[FieldOffset(0)]
			public bool bIsAvailable;

			// Token: 0x04016523 RID: 91427
			[FieldOffset(8)]
			public FString Error;
		}

		// Token: 0x02002C1F RID: 11295
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016524 RID: 91428
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
