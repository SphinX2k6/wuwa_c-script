using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000455 RID: 1109
	[UnrealObjectPath("/Script/KuroLogAnalyzer.KuroLogAnalyzerLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroLogAnalyzerLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006B14 RID: 27412 RVA: 0x0009BE91 File Offset: 0x0009A091
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroLogAnalyzerLibrary._ClassPtr;
		}

		// Token: 0x06006B15 RID: 27413 RVA: 0x0009BEA0 File Offset: 0x0009A0A0
		public UKuroLogAnalyzerLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroLogAnalyzerLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006B16 RID: 27414 RVA: 0x0009BEC8 File Offset: 0x0009A0C8
		[NullableContext(1)]
		public UKuroLogAnalyzerLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroLogAnalyzerLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06006B17 RID: 27415
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetEnable(bool bEnable);

		// Token: 0x06006B18 RID: 27416 RVA: 0x0009BEFB File Offset: 0x0009A0FB
		[NullableContext(2)]
		public static bool Initialize(int InVerbosity, in FLogDelegate InLogDelegate, int InMessageMaxSize = 4096)
		{
			FLogDelegate flogDelegate = InLogDelegate;
			return UKuroLogAnalyzerLibrary.__Initialize_Internal(InVerbosity, (flogDelegate != null) ? flogDelegate.NativePtr : ((IntPtr)0), InMessageMaxSize);
		}

		// Token: 0x06006B19 RID: 27417
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool Clear();

		// Token: 0x06006B1A RID: 27418
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Initialize_Internal(int InVerbosity, IntPtr InLogDelegate, int InMessageMaxSize);

		// Token: 0x06006B1B RID: 27419 RVA: 0x0009BF13 File Offset: 0x0009A113
		static UKuroLogAnalyzerLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroLogAnalyzer.KuroLogAnalyzerLibrary");
		}

		// Token: 0x06006B1C RID: 27420 RVA: 0x0009BF21 File Offset: 0x0009A121
		protected UKuroLogAnalyzerLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002D69 RID: 11625
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroLogAnalyzer.KuroLogAnalyzerLibrary";

		// Token: 0x04002D6A RID: 11626
		private static IntPtr _ClassPtr;

		// Token: 0x04002D6B RID: 11627
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
