using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000746 RID: 1862
	[UnrealObjectPath("/Script/CoreUObject.LinkerPlaceholderFunction")]
	[UnrealStructLayout(680, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 680)]
	public class ULinkerPlaceholderFunction : UFunction, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060062D5 RID: 25301 RVA: 0x0008DD4A File Offset: 0x0008BF4A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULinkerPlaceholderFunction._ClassPtr;
		}

		// Token: 0x060062D6 RID: 25302 RVA: 0x0008DD58 File Offset: 0x0008BF58
		public ULinkerPlaceholderFunction() : this(BuiltinUtils.AllocNativeUObject(ULinkerPlaceholderFunction.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060062D7 RID: 25303 RVA: 0x0008DD80 File Offset: 0x0008BF80
		[NullableContext(1)]
		public ULinkerPlaceholderFunction(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULinkerPlaceholderFunction.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060062D8 RID: 25304 RVA: 0x0008DDB3 File Offset: 0x0008BFB3
		static ULinkerPlaceholderFunction()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.LinkerPlaceholderFunction");
		}

		// Token: 0x060062D9 RID: 25305 RVA: 0x0008DDC1 File Offset: 0x0008BFC1
		protected ULinkerPlaceholderFunction(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002F49 RID: 12105
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.LinkerPlaceholderFunction";

		// Token: 0x04002F4A RID: 12106
		private static IntPtr _ClassPtr;

		// Token: 0x04002F4B RID: 12107
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
