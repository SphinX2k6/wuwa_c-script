using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200173E RID: 5950
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroCloudGame.KuroCloudGameWrapper")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 168)]
	public class UKuroCloudGameWrapper : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06015685 RID: 87685 RVA: 0x001F7524 File Offset: 0x001F5724
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroCloudGameWrapper._ClassPtr;
		}

		// Token: 0x06015686 RID: 87686 RVA: 0x001F7530 File Offset: 0x001F5730
		public UKuroCloudGameWrapper() : this(BuiltinUtils.AllocNativeUObject(UKuroCloudGameWrapper.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06015687 RID: 87687 RVA: 0x001F7558 File Offset: 0x001F5758
		public UKuroCloudGameWrapper(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroCloudGameWrapper.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005489 RID: 21641
		// (get) Token: 0x06015688 RID: 87688 RVA: 0x001F758C File Offset: 0x001F578C
		// (set) Token: 0x06015689 RID: 87689 RVA: 0x001F75C5 File Offset: 0x001F57C5
		public FCloudGameOnReceiveDataDelegate CloudGameOnReceiveDataDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FCloudGameOnReceiveDataDelegate result;
				if ((result = this._CloudGameOnReceiveDataDelegate) == null)
				{
					result = (this._CloudGameOnReceiveDataDelegate = new FCloudGameOnReceiveDataDelegate(base.NativePtr + (IntPtr)UKuroCloudGameWrapper.__PropertyOffset_CloudGameOnReceiveDataDelegate, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroCloudGameWrapper.__PropertyOffset_CloudGameOnReceiveDataDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700548A RID: 21642
		// (get) Token: 0x0601568A RID: 87690 RVA: 0x001F75E8 File Offset: 0x001F57E8
		// (set) Token: 0x0601568B RID: 87691 RVA: 0x001F7621 File Offset: 0x001F5821
		public FCloudGameOnReceiveDataWithKeyDelegate CloudGameOnReceiveDataWithKeyDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FCloudGameOnReceiveDataWithKeyDelegate result;
				if ((result = this._CloudGameOnReceiveDataWithKeyDelegate) == null)
				{
					result = (this._CloudGameOnReceiveDataWithKeyDelegate = new FCloudGameOnReceiveDataWithKeyDelegate(base.NativePtr + (IntPtr)UKuroCloudGameWrapper.__PropertyOffset_CloudGameOnReceiveDataWithKeyDelegate, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroCloudGameWrapper.__PropertyOffset_CloudGameOnReceiveDataWithKeyDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700548B RID: 21643
		// (get) Token: 0x0601568C RID: 87692 RVA: 0x001F7644 File Offset: 0x001F5844
		// (set) Token: 0x0601568D RID: 87693 RVA: 0x001F767D File Offset: 0x001F587D
		public FCloudGameOnChangeResolutionDelegate CloudGameOnChangeResolutionDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FCloudGameOnChangeResolutionDelegate result;
				if ((result = this._CloudGameOnChangeResolutionDelegate) == null)
				{
					result = (this._CloudGameOnChangeResolutionDelegate = new FCloudGameOnChangeResolutionDelegate(base.NativePtr + (IntPtr)UKuroCloudGameWrapper.__PropertyOffset_CloudGameOnChangeResolutionDelegate, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroCloudGameWrapper.__PropertyOffset_CloudGameOnChangeResolutionDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x0601568E RID: 87694 RVA: 0x001F76A0 File Offset: 0x001F58A0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SendDataToPipeBinaryWithKey(string Key, string Data)
		{
			UKuroCloudGameWrapper.__SendDataToPipeBinaryWithKey_FunctionParams* ptr = stackalloc UKuroCloudGameWrapper.__SendDataToPipeBinaryWithKey_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroCloudGameWrapper.__SendDataToPipeBinaryWithKey_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroCloudGameWrapper.__SendDataToPipeBinaryWithKey_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Key), Key);
			FString.CopyFrom((void*)(&ptr->Data), Data);
			UnrealReflectionUtils.CallUFunction(UKuroCloudGameWrapper._ClassDefaultObjectPtr, UKuroCloudGameWrapper.__SendDataToPipeBinaryWithKey_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroCloudGameWrapper.__SendDataToPipeBinaryWithKey_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601568F RID: 87695 RVA: 0x001F770C File Offset: 0x001F590C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SendDataToPipeBinary(string Data)
		{
			UKuroCloudGameWrapper.__SendDataToPipeBinary_FunctionParams* ptr = stackalloc UKuroCloudGameWrapper.__SendDataToPipeBinary_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroCloudGameWrapper.__SendDataToPipeBinary_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroCloudGameWrapper.__SendDataToPipeBinary_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Data), Data);
			UnrealReflectionUtils.CallUFunction(UKuroCloudGameWrapper._ClassDefaultObjectPtr, UKuroCloudGameWrapper.__SendDataToPipeBinary_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroCloudGameWrapper.__SendDataToPipeBinary_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06015690 RID: 87696 RVA: 0x001F7769 File Offset: 0x001F5969
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void ClipBoardPaste()
		{
			UnrealReflectionUtils.CallUFunction(UKuroCloudGameWrapper._ClassDefaultObjectPtr, UKuroCloudGameWrapper.__ClipBoardPaste_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06015691 RID: 87697 RVA: 0x001F777D File Offset: 0x001F597D
		static UKuroCloudGameWrapper()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroCloudGame.KuroCloudGameWrapper");
		}

		// Token: 0x06015692 RID: 87698 RVA: 0x001F778B File Offset: 0x001F598B
		protected UKuroCloudGameWrapper(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400BABF RID: 47807
		public new const string __ObjectPath = "/Script/KuroCloudGame.KuroCloudGameWrapper";

		// Token: 0x0400BAC0 RID: 47808
		private static IntPtr _ClassPtr;

		// Token: 0x0400BAC1 RID: 47809
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400BAC2 RID: 47810
		internal static int __PropertyOffset_CloudGameOnReceiveDataDelegate;

		// Token: 0x0400BAC3 RID: 47811
		[Nullable(2)]
		private FCloudGameOnReceiveDataDelegate _CloudGameOnReceiveDataDelegate;

		// Token: 0x0400BAC4 RID: 47812
		internal static int __PropertyOffset_CloudGameOnReceiveDataWithKeyDelegate;

		// Token: 0x0400BAC5 RID: 47813
		[Nullable(2)]
		private FCloudGameOnReceiveDataWithKeyDelegate _CloudGameOnReceiveDataWithKeyDelegate;

		// Token: 0x0400BAC6 RID: 47814
		internal static int __PropertyOffset_CloudGameOnChangeResolutionDelegate;

		// Token: 0x0400BAC7 RID: 47815
		[Nullable(2)]
		private FCloudGameOnChangeResolutionDelegate _CloudGameOnChangeResolutionDelegate;

		// Token: 0x0400BAC8 RID: 47816
		private static IntPtr __SendDataToPipeBinaryWithKey_NativeFunctionPtr;

		// Token: 0x0400BAC9 RID: 47817
		private static IntPtr __SendDataToPipeBinary_NativeFunctionPtr;

		// Token: 0x0400BACA RID: 47818
		private static IntPtr __ClipBoardPaste_NativeFunctionPtr;

		// Token: 0x02002F00 RID: 12032
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __SendDataToPipeBinaryWithKey_FunctionParams
		{
			// Token: 0x04016A3E RID: 92734
			[FieldOffset(0)]
			public FString Key;

			// Token: 0x04016A3F RID: 92735
			[FieldOffset(16)]
			public FString Data;
		}

		// Token: 0x02002F01 RID: 12033
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SendDataToPipeBinary_FunctionParams
		{
			// Token: 0x04016A40 RID: 92736
			[FieldOffset(0)]
			public FString Data;
		}
	}
}
