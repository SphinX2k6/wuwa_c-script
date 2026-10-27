using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C59 RID: 3161
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.InputComponent")]
	[UnrealStructLayout(336, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 336)]
	public class UInputComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A03F RID: 41023 RVA: 0x000E3AEF File Offset: 0x000E1CEF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInputComponent._ClassPtr;
		}

		// Token: 0x0600A040 RID: 41024 RVA: 0x000E3AFC File Offset: 0x000E1CFC
		public UInputComponent() : this(BuiltinUtils.AllocNativeUObject(UInputComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A041 RID: 41025 RVA: 0x000E3B24 File Offset: 0x000E1D24
		[NullableContext(1)]
		public UInputComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInputComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700262D RID: 9773
		// (get) Token: 0x0600A042 RID: 41026 RVA: 0x000E3B58 File Offset: 0x000E1D58
		// (set) Token: 0x0600A043 RID: 41027 RVA: 0x000E3B91 File Offset: 0x000E1D91
		[Nullable(1)]
		public TArray<FCachedKeyToActionInfo> CachedKeyToActionInfo
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FCachedKeyToActionInfo> result;
				if ((result = this._CachedKeyToActionInfo) == null)
				{
					result = (this._CachedKeyToActionInfo = new TArray<FCachedKeyToActionInfo>(base.NativePtr + (IntPtr)UInputComponent.__PropertyOffset_CachedKeyToActionInfo, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CachedKeyToActionInfo.CopyAssign(value);
			}
		}

		// Token: 0x0600A044 RID: 41028 RVA: 0x000E3B9F File Offset: 0x000E1D9F
		public bool WasControllerKeyJustReleased(FKey Key)
		{
			return UInputComponent.__WasControllerKeyJustReleased_Internal(base.NativePtr, (Key ?? new FKey()).NativePtr);
		}

		// Token: 0x0600A045 RID: 41029 RVA: 0x000E3BBB File Offset: 0x000E1DBB
		public bool WasControllerKeyJustPressed(FKey Key)
		{
			return UInputComponent.__WasControllerKeyJustPressed_Internal(base.NativePtr, (Key ?? new FKey()).NativePtr);
		}

		// Token: 0x0600A046 RID: 41030 RVA: 0x000E3BD7 File Offset: 0x000E1DD7
		public bool IsControllerKeyDown(FKey Key)
		{
			return UInputComponent.__IsControllerKeyDown_Internal(base.NativePtr, (Key ?? new FKey()).NativePtr);
		}

		// Token: 0x0600A047 RID: 41031 RVA: 0x000E3BF4 File Offset: 0x000E1DF4
		public unsafe void GetTouchState(int FingerIndex, ref float LocationX, ref float LocationY, ref bool bIsCurrentlyPressed)
		{
			fixed (float* ptr = &LocationX)
			{
				void* ptr2 = (void*)ptr;
				fixed (float* ptr3 = &LocationY)
				{
					void* ptr4 = (void*)ptr3;
					fixed (bool* ptr5 = &bIsCurrentlyPressed)
					{
						void* ptr6 = (void*)ptr5;
						UInputComponent.__GetTouchState_Internal(base.NativePtr, FingerIndex, ref LocationX, ref LocationY, ref bIsCurrentlyPressed);
						ptr = null;
						ptr3 = null;
					}
				}
			}
		}

		// Token: 0x0600A048 RID: 41032 RVA: 0x000E3C30 File Offset: 0x000E1E30
		public FVector GetControllerVectorKeyState(FKey Key)
		{
			return UInputComponent.__GetControllerVectorKeyState_Internal(base.NativePtr, (Key ?? new FKey()).NativePtr);
		}

		// Token: 0x0600A049 RID: 41033 RVA: 0x000E3C4C File Offset: 0x000E1E4C
		public unsafe void GetControllerMouseDelta(ref float DeltaX, ref float DeltaY)
		{
			fixed (float* ptr = &DeltaX)
			{
				void* ptr2 = (void*)ptr;
				fixed (float* ptr3 = &DeltaY)
				{
					void* ptr4 = (void*)ptr3;
					UInputComponent.__GetControllerMouseDelta_Internal(base.NativePtr, ref DeltaX, ref DeltaY);
					ptr = null;
				}
			}
		}

		// Token: 0x0600A04A RID: 41034 RVA: 0x000E3C76 File Offset: 0x000E1E76
		public float GetControllerKeyTimeDown(FKey Key)
		{
			return UInputComponent.__GetControllerKeyTimeDown_Internal(base.NativePtr, (Key ?? new FKey()).NativePtr);
		}

		// Token: 0x0600A04B RID: 41035 RVA: 0x000E3C94 File Offset: 0x000E1E94
		public unsafe void GetControllerAnalogStickState(EControllerAnalogStick WhichStick, ref float StickX, ref float StickY)
		{
			fixed (float* ptr = &StickX)
			{
				void* ptr2 = (void*)ptr;
				fixed (float* ptr3 = &StickY)
				{
					void* ptr4 = (void*)ptr3;
					UInputComponent.__GetControllerAnalogStickState_Internal(base.NativePtr, WhichStick, ref StickX, ref StickY);
					ptr = null;
				}
			}
		}

		// Token: 0x0600A04C RID: 41036 RVA: 0x000E3CC4 File Offset: 0x000E1EC4
		public float GetControllerAnalogKeyState(FKey Key)
		{
			return UInputComponent.__GetControllerAnalogKeyState_Internal(base.NativePtr, (Key ?? new FKey()).NativePtr);
		}

		// Token: 0x0600A04D RID: 41037
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __WasControllerKeyJustReleased_Internal(IntPtr @this, IntPtr Key);

		// Token: 0x0600A04E RID: 41038
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __WasControllerKeyJustPressed_Internal(IntPtr @this, IntPtr Key);

		// Token: 0x0600A04F RID: 41039
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsControllerKeyDown_Internal(IntPtr @this, IntPtr Key);

		// Token: 0x0600A050 RID: 41040
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetTouchState_Internal(IntPtr @this, int FingerIndex, ref float LocationX, ref float LocationY, ref bool bIsCurrentlyPressed);

		// Token: 0x0600A051 RID: 41041
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetControllerVectorKeyState_Internal(IntPtr @this, IntPtr Key);

		// Token: 0x0600A052 RID: 41042
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetControllerMouseDelta_Internal(IntPtr @this, ref float DeltaX, ref float DeltaY);

		// Token: 0x0600A053 RID: 41043
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetControllerKeyTimeDown_Internal(IntPtr @this, IntPtr Key);

		// Token: 0x0600A054 RID: 41044
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetControllerAnalogStickState_Internal(IntPtr @this, TEnumAsByte<EControllerAnalogStick> WhichStick, ref float StickX, ref float StickY);

		// Token: 0x0600A055 RID: 41045
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetControllerAnalogKeyState_Internal(IntPtr @this, IntPtr Key);

		// Token: 0x0600A056 RID: 41046 RVA: 0x000E3CE0 File Offset: 0x000E1EE0
		static UInputComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InputComponent");
		}

		// Token: 0x0600A057 RID: 41047 RVA: 0x000E3CEE File Offset: 0x000E1EEE
		protected UInputComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005825 RID: 22565
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.InputComponent";

		// Token: 0x04005826 RID: 22566
		private static IntPtr _ClassPtr;

		// Token: 0x04005827 RID: 22567
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005828 RID: 22568
		internal static int __PropertyOffset_CachedKeyToActionInfo;

		// Token: 0x04005829 RID: 22569
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FCachedKeyToActionInfo> _CachedKeyToActionInfo;
	}
}
