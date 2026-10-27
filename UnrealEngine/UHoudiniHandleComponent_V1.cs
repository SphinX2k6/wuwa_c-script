using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014C6 RID: 5318
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniHandleComponent_V1")]
	[UnrealStructLayout(720, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 720)]
	public class UHoudiniHandleComponent_V1 : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013410 RID: 78864 RVA: 0x001C5046 File Offset: 0x001C3246
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniHandleComponent_V1._ClassPtr;
		}

		// Token: 0x06013411 RID: 78865 RVA: 0x001C5054 File Offset: 0x001C3254
		public UHoudiniHandleComponent_V1() : this(BuiltinUtils.AllocNativeUObject(UHoudiniHandleComponent_V1.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013412 RID: 78866 RVA: 0x001C507C File Offset: 0x001C327C
		[NullableContext(1)]
		public UHoudiniHandleComponent_V1(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniHandleComponent_V1.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06013413 RID: 78867 RVA: 0x001C50AF File Offset: 0x001C32AF
		static UHoudiniHandleComponent_V1()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniHandleComponent_V1");
		}

		// Token: 0x06013414 RID: 78868 RVA: 0x001C50BD File Offset: 0x001C32BD
		protected UHoudiniHandleComponent_V1(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A653 RID: 42579
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniHandleComponent_V1";

		// Token: 0x0400A654 RID: 42580
		private static IntPtr _ClassPtr;

		// Token: 0x0400A655 RID: 42581
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
