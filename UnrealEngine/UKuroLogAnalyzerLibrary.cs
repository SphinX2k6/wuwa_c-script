using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020019BB RID: 6587
	[UnrealObjectPath("/Script/KuroLogAnalyzer.KuroLogAnalyzerLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroLogAnalyzerLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060187FF RID: 100351 RVA: 0x00241956 File Offset: 0x0023FB56
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroLogAnalyzerLibrary._ClassPtr;
		}

		// Token: 0x06018800 RID: 100352 RVA: 0x00241964 File Offset: 0x0023FB64
		public UKuroLogAnalyzerLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroLogAnalyzerLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06018801 RID: 100353 RVA: 0x0024198C File Offset: 0x0023FB8C
		[NullableContext(1)]
		public UKuroLogAnalyzerLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroLogAnalyzerLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06018802 RID: 100354
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetEnable(bool bEnable);

		// Token: 0x06018803 RID: 100355 RVA: 0x002419BF File Offset: 0x0023FBBF
		[NullableContext(2)]
		public static bool Initialize(int InVerbosity, in FLogDelegate InLogDelegate, int InMessageMaxSize = 4096)
		{
			FLogDelegate flogDelegate = InLogDelegate;
			return UKuroLogAnalyzerLibrary.__Initialize_Internal(InVerbosity, (flogDelegate != null) ? flogDelegate.NativePtr : ((IntPtr)0), InMessageMaxSize);
		}

		// Token: 0x06018804 RID: 100356
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool Clear();

		// Token: 0x06018805 RID: 100357
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Initialize_Internal(int InVerbosity, IntPtr InLogDelegate, int InMessageMaxSize);

		// Token: 0x06018806 RID: 100358 RVA: 0x002419D7 File Offset: 0x0023FBD7
		static UKuroLogAnalyzerLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroLogAnalyzer.KuroLogAnalyzerLibrary");
		}

		// Token: 0x06018807 RID: 100359 RVA: 0x002419E5 File Offset: 0x0023FBE5
		protected UKuroLogAnalyzerLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D3BC RID: 54204
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroLogAnalyzer.KuroLogAnalyzerLibrary";

		// Token: 0x0400D3BD RID: 54205
		private static IntPtr _ClassPtr;

		// Token: 0x0400D3BE RID: 54206
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
