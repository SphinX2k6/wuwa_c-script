using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001002 RID: 4098
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PlatformInterfaceWebResponse")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 184)]
	public class UPlatformInterfaceWebResponse : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600DDE8 RID: 56808 RVA: 0x00146EBA File Offset: 0x001450BA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPlatformInterfaceWebResponse._ClassPtr;
		}

		// Token: 0x0600DDE9 RID: 56809 RVA: 0x00146EC8 File Offset: 0x001450C8
		public UPlatformInterfaceWebResponse() : this(BuiltinUtils.AllocNativeUObject(UPlatformInterfaceWebResponse.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600DDEA RID: 56810 RVA: 0x00146EF0 File Offset: 0x001450F0
		public UPlatformInterfaceWebResponse(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPlatformInterfaceWebResponse.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003453 RID: 13395
		// (get) Token: 0x0600DDEB RID: 56811 RVA: 0x00146F23 File Offset: 0x00145123
		// (set) Token: 0x0600DDEC RID: 56812 RVA: 0x00146F37 File Offset: 0x00145137
		public unsafe string OriginalURL
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UPlatformInterfaceWebResponse.__PropertyOffset_OriginalURL)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UPlatformInterfaceWebResponse.__PropertyOffset_OriginalURL)), value);
			}
		}

		// Token: 0x17003454 RID: 13396
		// (get) Token: 0x0600DDED RID: 56813 RVA: 0x00146F4C File Offset: 0x0014514C
		// (set) Token: 0x0600DDEE RID: 56814 RVA: 0x00146F5C File Offset: 0x0014515C
		public unsafe int ResponseCode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlatformInterfaceWebResponse.__PropertyOffset_ResponseCode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlatformInterfaceWebResponse.__PropertyOffset_ResponseCode) = value;
			}
		}

		// Token: 0x17003455 RID: 13397
		// (get) Token: 0x0600DDEF RID: 56815 RVA: 0x00146F6D File Offset: 0x0014516D
		// (set) Token: 0x0600DDF0 RID: 56816 RVA: 0x00146F7D File Offset: 0x0014517D
		public unsafe int Tag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlatformInterfaceWebResponse.__PropertyOffset_Tag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlatformInterfaceWebResponse.__PropertyOffset_Tag) = value;
			}
		}

		// Token: 0x17003456 RID: 13398
		// (get) Token: 0x0600DDF1 RID: 56817 RVA: 0x00146F8E File Offset: 0x0014518E
		// (set) Token: 0x0600DDF2 RID: 56818 RVA: 0x00146FA2 File Offset: 0x001451A2
		public unsafe string StringResponse
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UPlatformInterfaceWebResponse.__PropertyOffset_StringResponse)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UPlatformInterfaceWebResponse.__PropertyOffset_StringResponse)), value);
			}
		}

		// Token: 0x17003457 RID: 13399
		// (get) Token: 0x0600DDF3 RID: 56819 RVA: 0x00146FB8 File Offset: 0x001451B8
		// (set) Token: 0x0600DDF4 RID: 56820 RVA: 0x00146FF1 File Offset: 0x001451F1
		public TArray<byte> BinaryResponse
		{
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._BinaryResponse) == null)
				{
					result = (this._BinaryResponse = new TArray<byte>(base.NativePtr + (IntPtr)UPlatformInterfaceWebResponse.__PropertyOffset_BinaryResponse, this));
				}
				return result;
			}
			set
			{
				this.BinaryResponse.CopyAssign(value);
			}
		}

		// Token: 0x0600DDF5 RID: 56821 RVA: 0x00147000 File Offset: 0x00145200
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe int GetNumHeaders()
		{
			UPlatformInterfaceWebResponse.__GetNumHeaders_FunctionParams* ptr = stackalloc UPlatformInterfaceWebResponse.__GetNumHeaders_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UPlatformInterfaceWebResponse.__GetNumHeaders_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UPlatformInterfaceWebResponse.__GetNumHeaders_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UPlatformInterfaceWebResponse.__GetNumHeaders_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0600DDF6 RID: 56822 RVA: 0x00147048 File Offset: 0x00145248
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe string GetHeaderValue(string HeaderName)
		{
			UPlatformInterfaceWebResponse.__GetHeaderValue_FunctionParams* ptr = stackalloc UPlatformInterfaceWebResponse.__GetHeaderValue_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UPlatformInterfaceWebResponse.__GetHeaderValue_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UPlatformInterfaceWebResponse.__GetHeaderValue_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->HeaderName), HeaderName);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UPlatformInterfaceWebResponse.__GetHeaderValue_NativeFunctionPtr, (void*)ptr, 0);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UPlatformInterfaceWebResponse.__GetHeaderValue_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600DDF7 RID: 56823 RVA: 0x001470B4 File Offset: 0x001452B4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void GetHeader(int HeaderIndex, ref string Header, ref string Value)
		{
			UPlatformInterfaceWebResponse.__GetHeader_FunctionParams* ptr = stackalloc UPlatformInterfaceWebResponse.__GetHeader_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UPlatformInterfaceWebResponse.__GetHeader_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UPlatformInterfaceWebResponse.__GetHeader_NativeFunctionPtr, (void*)ptr, 1);
			ptr->HeaderIndex = HeaderIndex;
			FString.CopyFrom((void*)(&ptr->Header), Header);
			FString.CopyFrom((void*)(&ptr->Value), Value);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UPlatformInterfaceWebResponse.__GetHeader_NativeFunctionPtr, (void*)ptr, 0);
			Header = FString.ToString((void*)(&ptr->Header));
			Value = FString.ToString((void*)(&ptr->Value));
			UnrealReflectionUtils.DestroyStruct(UPlatformInterfaceWebResponse.__GetHeader_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600DDF8 RID: 56824 RVA: 0x00147144 File Offset: 0x00145344
		static UPlatformInterfaceWebResponse()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PlatformInterfaceWebResponse");
		}

		// Token: 0x0600DDF9 RID: 56825 RVA: 0x00147152 File Offset: 0x00145352
		protected UPlatformInterfaceWebResponse(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040077F6 RID: 30710
		public new const string __ObjectPath = "/Script/Engine.PlatformInterfaceWebResponse";

		// Token: 0x040077F7 RID: 30711
		private static IntPtr _ClassPtr;

		// Token: 0x040077F8 RID: 30712
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040077F9 RID: 30713
		internal static int __PropertyOffset_OriginalURL;

		// Token: 0x040077FA RID: 30714
		internal static int __PropertyOffset_ResponseCode;

		// Token: 0x040077FB RID: 30715
		internal static int __PropertyOffset_Tag;

		// Token: 0x040077FC RID: 30716
		internal static int __PropertyOffset_StringResponse;

		// Token: 0x040077FD RID: 30717
		internal static int __PropertyOffset_BinaryResponse;

		// Token: 0x040077FE RID: 30718
		[Nullable(2)]
		private TArray<byte> _BinaryResponse;

		// Token: 0x040077FF RID: 30719
		private static IntPtr __GetNumHeaders_NativeFunctionPtr;

		// Token: 0x04007800 RID: 30720
		private static IntPtr __GetHeaderValue_NativeFunctionPtr;

		// Token: 0x04007801 RID: 30721
		private static IntPtr __GetHeader_NativeFunctionPtr;

		// Token: 0x02002DC8 RID: 11720
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetNumHeaders_FunctionParams
		{
			// Token: 0x04016800 RID: 92160
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02002DC9 RID: 11721
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetHeaderValue_FunctionParams
		{
			// Token: 0x04016801 RID: 92161
			[FieldOffset(0)]
			public FString HeaderName;

			// Token: 0x04016802 RID: 92162
			[FieldOffset(16)]
			public FString __Result;
		}

		// Token: 0x02002DCA RID: 11722
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __GetHeader_FunctionParams
		{
			// Token: 0x04016803 RID: 92163
			[FieldOffset(0)]
			public int HeaderIndex;

			// Token: 0x04016804 RID: 92164
			[FieldOffset(8)]
			public FString Header;

			// Token: 0x04016805 RID: 92165
			[FieldOffset(24)]
			public FString Value;
		}
	}
}
