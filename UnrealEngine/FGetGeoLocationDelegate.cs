using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000405 RID: 1029
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FGetGeoLocationDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600375A RID: 14170 RVA: 0x000540B2 File Offset: 0x000522B2
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FGetGeoLocationDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600375B RID: 14171 RVA: 0x000540BE File Offset: 0x000522BE
		private static IntPtr StaticFunctionPtr()
		{
			if (UGetGeoLocationAsyncTaskBlueprintProxy.__GetGeoLocationDelegate__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UGetGeoLocationAsyncTaskBlueprintProxy.__GetGeoLocationDelegate__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/AugmentedReality.GetGeoLocationAsyncTaskBlueprintProxy:GetGeoLocationDelegate__DelegateSignature");
			}
			return UGetGeoLocationAsyncTaskBlueprintProxy.__GetGeoLocationDelegate__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0600375C RID: 14172 RVA: 0x000540E1 File Offset: 0x000522E1
		public FGetGeoLocationDelegate()
		{
		}

		// Token: 0x0600375D RID: 14173 RVA: 0x000540E9 File Offset: 0x000522E9
		[NullableContext(2)]
		public FGetGeoLocationDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600375E RID: 14174 RVA: 0x000540F3 File Offset: 0x000522F3
		public FGetGeoLocationDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600375F RID: 14175 RVA: 0x000540FE File Offset: 0x000522FE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<float, float, float, string>) ?? ((Action<float, float, float, string>)Delegate.CreateDelegate(typeof(Action<float, float, float, string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06003760 RID: 14176 RVA: 0x00054130 File Offset: 0x00052330
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<float, float, float, string> Callback)
		{
			if (FGetGeoLocationDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FGetGeoLocationDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FGetGeoLocationDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FGetGeoLocationDelegate.OnScriptCallback));
				}
				FGetGeoLocationDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FGetGeoLocationDelegate.RegisterId);
		}

		// Token: 0x06003761 RID: 14177 RVA: 0x0005416A File Offset: 0x0005236A
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<float, float, float, string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06003762 RID: 14178 RVA: 0x00054174 File Offset: 0x00052374
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(float Longitude, float Latitude, float Altitude, string Error)
		{
			FGetGeoLocationDelegate.__FGetGeoLocationDelegate_DelegateParams* ptr = stackalloc FGetGeoLocationDelegate.__FGetGeoLocationDelegate_DelegateParams[(UIntPtr)47] + 15L / (long)sizeof(FGetGeoLocationDelegate.__FGetGeoLocationDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FGetGeoLocationDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Longitude = Longitude;
			ptr->Latitude = Latitude;
			ptr->Altitude = Altitude;
			FString.CopyFrom((void*)(&ptr->Error), Error);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UGetGeoLocationAsyncTaskBlueprintProxy.__GetGeoLocationDelegate__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06003763 RID: 14179 RVA: 0x000541E0 File Offset: 0x000523E0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<float, float, float, string> action = target as Action<float, float, float, string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string arg = FString.ToString((void*)(&((FGetGeoLocationDelegate.__FGetGeoLocationDelegate_DelegateParams*)__Parameters)->Error));
			action(((FGetGeoLocationDelegate.__FGetGeoLocationDelegate_DelegateParams*)__Parameters)->Longitude, ((FGetGeoLocationDelegate.__FGetGeoLocationDelegate_DelegateParams*)__Parameters)->Latitude, ((FGetGeoLocationDelegate.__FGetGeoLocationDelegate_DelegateParams*)__Parameters)->Altitude, arg);
		}

		// Token: 0x04001930 RID: 6448
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AugmentedReality.GetGeoLocationAsyncTaskBlueprintProxy:GetGeoLocationDelegate__DelegateSignature";

		// Token: 0x04001931 RID: 6449
		private static int RegisterId;

		// Token: 0x02002C20 RID: 11296
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __FGetGeoLocationDelegate_DelegateParams
		{
			// Token: 0x04016525 RID: 91429
			[FieldOffset(0)]
			public float Longitude;

			// Token: 0x04016526 RID: 91430
			[FieldOffset(4)]
			public float Latitude;

			// Token: 0x04016527 RID: 91431
			[FieldOffset(8)]
			public float Altitude;

			// Token: 0x04016528 RID: 91432
			[FieldOffset(16)]
			public FString Error;
		}

		// Token: 0x02002C21 RID: 11297
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016529 RID: 91433
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
