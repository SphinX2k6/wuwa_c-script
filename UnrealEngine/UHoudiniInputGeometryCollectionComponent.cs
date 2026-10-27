using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014D0 RID: 5328
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniInputGeometryCollectionComponent")]
	[UnrealStructLayout(304, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 304)]
	public class UHoudiniInputGeometryCollectionComponent : UHoudiniInputSceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060134F6 RID: 79094 RVA: 0x001C64B2 File Offset: 0x001C46B2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniInputGeometryCollectionComponent._ClassPtr;
		}

		// Token: 0x060134F7 RID: 79095 RVA: 0x001C64C0 File Offset: 0x001C46C0
		public UHoudiniInputGeometryCollectionComponent() : this(BuiltinUtils.AllocNativeUObject(UHoudiniInputGeometryCollectionComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060134F8 RID: 79096 RVA: 0x001C64E8 File Offset: 0x001C46E8
		[NullableContext(1)]
		public UHoudiniInputGeometryCollectionComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniInputGeometryCollectionComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060134F9 RID: 79097 RVA: 0x001C651B File Offset: 0x001C471B
		static UHoudiniInputGeometryCollectionComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniInputGeometryCollectionComponent");
		}

		// Token: 0x060134FA RID: 79098 RVA: 0x001C6529 File Offset: 0x001C4729
		protected UHoudiniInputGeometryCollectionComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A6E2 RID: 42722
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniInputGeometryCollectionComponent";

		// Token: 0x0400A6E3 RID: 42723
		private static IntPtr _ClassPtr;

		// Token: 0x0400A6E4 RID: 42724
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
