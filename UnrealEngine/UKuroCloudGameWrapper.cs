using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200033C RID: 828
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroCloudGame.KuroCloudGameWrapper")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 168)]
	public class UKuroCloudGameWrapper : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060055BB RID: 21947 RVA: 0x00077FC1 File Offset: 0x000761C1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroCloudGameWrapper._ClassPtr;
		}

		// Token: 0x060055BC RID: 21948 RVA: 0x00077FD0 File Offset: 0x000761D0
		public UKuroCloudGameWrapper() : this(BuiltinUtils.AllocNativeUObject(UKuroCloudGameWrapper.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060055BD RID: 21949 RVA: 0x00077FF8 File Offset: 0x000761F8
		public UKuroCloudGameWrapper(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroCloudGameWrapper.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170010E1 RID: 4321
		// (get) Token: 0x060055BE RID: 21950 RVA: 0x0007802C File Offset: 0x0007622C
		// (set) Token: 0x060055BF RID: 21951 RVA: 0x00078065 File Offset: 0x00076265
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

		// Token: 0x170010E2 RID: 4322
		// (get) Token: 0x060055C0 RID: 21952 RVA: 0x00078088 File Offset: 0x00076288
		// (set) Token: 0x060055C1 RID: 21953 RVA: 0x000780C1 File Offset: 0x000762C1
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

		// Token: 0x170010E3 RID: 4323
		// (get) Token: 0x060055C2 RID: 21954 RVA: 0x000780E4 File Offset: 0x000762E4
		// (set) Token: 0x060055C3 RID: 21955 RVA: 0x0007811D File Offset: 0x0007631D
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

		// Token: 0x060055C4 RID: 21956 RVA: 0x00078140 File Offset: 0x00076340
		[SkipLocalsInit]
		public unsafe static void SendDataToPipeBinaryWithKey(string Key, string Data)
		{
			UKuroCloudGameWrapper.__SendDataToPipeBinaryWithKey_FunctionParams* ptr = stackalloc UKuroCloudGameWrapper.__SendDataToPipeBinaryWithKey_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroCloudGameWrapper.__SendDataToPipeBinaryWithKey_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroCloudGameWrapper.__SendDataToPipeBinaryWithKey_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Key), Key);
			FString.CopyFrom((void*)(&ptr->Data), Data);
			UnrealReflectionUtils.CallUFunction(UKuroCloudGameWrapper._ClassDefaultObjectPtr, UKuroCloudGameWrapper.__SendDataToPipeBinaryWithKey_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroCloudGameWrapper.__SendDataToPipeBinaryWithKey_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060055C5 RID: 21957 RVA: 0x000781AC File Offset: 0x000763AC
		[SkipLocalsInit]
		public unsafe static void SendDataToPipeBinary(string Data)
		{
			UKuroCloudGameWrapper.__SendDataToPipeBinary_FunctionParams* ptr = stackalloc UKuroCloudGameWrapper.__SendDataToPipeBinary_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroCloudGameWrapper.__SendDataToPipeBinary_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroCloudGameWrapper.__SendDataToPipeBinary_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Data), Data);
			UnrealReflectionUtils.CallUFunction(UKuroCloudGameWrapper._ClassDefaultObjectPtr, UKuroCloudGameWrapper.__SendDataToPipeBinary_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroCloudGameWrapper.__SendDataToPipeBinary_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060055C6 RID: 21958 RVA: 0x00078208 File Offset: 0x00076408
		[SkipLocalsInit]
		public static void ClipBoardPaste()
		{
			UnrealReflectionUtils.CallUFunction(UKuroCloudGameWrapper._ClassDefaultObjectPtr, UKuroCloudGameWrapper.__ClipBoardPaste_NativeFunctionPtr, null);
		}

		// Token: 0x060055C7 RID: 21959 RVA: 0x0007821B File Offset: 0x0007641B
		static UKuroCloudGameWrapper()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroCloudGame.KuroCloudGameWrapper");
		}

		// Token: 0x060055C8 RID: 21960 RVA: 0x00078229 File Offset: 0x00076429
		protected UKuroCloudGameWrapper(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002309 RID: 8969
		public new const string __ObjectPath = "/Script/KuroCloudGame.KuroCloudGameWrapper";

		// Token: 0x0400230A RID: 8970
		private static IntPtr _ClassPtr;

		// Token: 0x0400230B RID: 8971
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400230C RID: 8972
		internal static int __PropertyOffset_CloudGameOnReceiveDataDelegate;

		// Token: 0x0400230D RID: 8973
		[Nullable(2)]
		private FCloudGameOnReceiveDataDelegate _CloudGameOnReceiveDataDelegate;

		// Token: 0x0400230E RID: 8974
		internal static int __PropertyOffset_CloudGameOnReceiveDataWithKeyDelegate;

		// Token: 0x0400230F RID: 8975
		[Nullable(2)]
		private FCloudGameOnReceiveDataWithKeyDelegate _CloudGameOnReceiveDataWithKeyDelegate;

		// Token: 0x04002310 RID: 8976
		internal static int __PropertyOffset_CloudGameOnChangeResolutionDelegate;

		// Token: 0x04002311 RID: 8977
		[Nullable(2)]
		private FCloudGameOnChangeResolutionDelegate _CloudGameOnChangeResolutionDelegate;

		// Token: 0x04002312 RID: 8978
		private static IntPtr __SendDataToPipeBinaryWithKey_NativeFunctionPtr;

		// Token: 0x04002313 RID: 8979
		private static IntPtr __SendDataToPipeBinary_NativeFunctionPtr;

		// Token: 0x04002314 RID: 8980
		private static IntPtr __ClipBoardPaste_NativeFunctionPtr;

		// Token: 0x02000A35 RID: 2613
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __SendDataToPipeBinaryWithKey_FunctionParams
		{
			// Token: 0x04005A12 RID: 23058
			[FieldOffset(0)]
			public FString Key;

			// Token: 0x04005A13 RID: 23059
			[FieldOffset(16)]
			public FString Data;
		}

		// Token: 0x02000A36 RID: 2614
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SendDataToPipeBinary_FunctionParams
		{
			// Token: 0x04005A14 RID: 23060
			[FieldOffset(0)]
			public FString Data;
		}
	}
}
