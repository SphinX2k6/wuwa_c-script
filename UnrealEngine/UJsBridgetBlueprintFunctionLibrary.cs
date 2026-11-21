using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200080C RID: 2060
	[UnrealObjectPath("/Script/Sharphereal.JsBridgetBlueprintFunctionLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UJsBridgetBlueprintFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B535 RID: 46389 RVA: 0x00120271 File Offset: 0x0011E471
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UJsBridgetBlueprintFunctionLibrary._ClassPtr;
		}

		// Token: 0x0600B536 RID: 46390 RVA: 0x00120280 File Offset: 0x0011E480
		public UJsBridgetBlueprintFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(UJsBridgetBlueprintFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B537 RID: 46391 RVA: 0x001202A8 File Offset: 0x0011E4A8
		[NullableContext(1)]
		public UJsBridgetBlueprintFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UJsBridgetBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600B538 RID: 46392 RVA: 0x001202DC File Offset: 0x0011E4DC
		[SkipLocalsInit]
		public unsafe static void CSharpCallJavascript(uint EventId, int TargetId, byte ParameterCount, ulong ParameterBufferPtr)
		{
			UJsBridgetBlueprintFunctionLibrary.__CSharpCallJavascript_FunctionParams* ptr = stackalloc UJsBridgetBlueprintFunctionLibrary.__CSharpCallJavascript_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UJsBridgetBlueprintFunctionLibrary.__CSharpCallJavascript_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UJsBridgetBlueprintFunctionLibrary.__CSharpCallJavascript_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EventId = EventId;
			ptr->TargetId = TargetId;
			ptr->ParameterCount = ParameterCount;
			ptr->ParameterBufferPtr = ParameterBufferPtr;
			UnrealReflectionUtils.CallUFunction(UJsBridgetBlueprintFunctionLibrary._ClassDefaultObjectPtr, UJsBridgetBlueprintFunctionLibrary.__CSharpCallJavascript_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B539 RID: 46393 RVA: 0x00120336 File Offset: 0x0011E536
		static UJsBridgetBlueprintFunctionLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Sharphereal.JsBridgetBlueprintFunctionLibrary");
		}

		// Token: 0x0600B53A RID: 46394 RVA: 0x00120344 File Offset: 0x0011E544
		protected UJsBridgetBlueprintFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040051C8 RID: 20936
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Sharphereal.JsBridgetBlueprintFunctionLibrary";

		// Token: 0x040051C9 RID: 20937
		private static IntPtr _ClassPtr;

		// Token: 0x040051CA RID: 20938
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040051CB RID: 20939
		private static IntPtr __CSharpCallJavascript_NativeFunctionPtr;

		// Token: 0x0200132A RID: 4906
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __CSharpCallJavascript_FunctionParams
		{
			// Token: 0x04006762 RID: 26466
			[FieldOffset(0)]
			public uint EventId;

			// Token: 0x04006763 RID: 26467
			[FieldOffset(4)]
			public int TargetId;

			// Token: 0x04006764 RID: 26468
			[FieldOffset(8)]
			public byte ParameterCount;

			// Token: 0x04006765 RID: 26469
			[FieldOffset(16)]
			public ulong ParameterBufferPtr;
		}
	}
}
