using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014A0 RID: 5280
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniAssetActor")]
	[UnrealStructLayout(1048, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1048)]
	public class AHoudiniAssetActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060131E5 RID: 78309 RVA: 0x001C1EA6 File Offset: 0x001C00A6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AHoudiniAssetActor._ClassPtr;
		}

		// Token: 0x060131E6 RID: 78310 RVA: 0x001C1EB4 File Offset: 0x001C00B4
		public AHoudiniAssetActor() : this(BuiltinUtils.AllocNativeUObject(AHoudiniAssetActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060131E7 RID: 78311 RVA: 0x001C1EDC File Offset: 0x001C00DC
		[NullableContext(1)]
		public AHoudiniAssetActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AHoudiniAssetActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004A45 RID: 19013
		// (get) Token: 0x060131E8 RID: 78312 RVA: 0x001C1F0F File Offset: 0x001C010F
		// (set) Token: 0x060131E9 RID: 78313 RVA: 0x001C1F23 File Offset: 0x001C0123
		[Nullable(2)]
		public unsafe UHoudiniAssetComponent HoudiniAssetComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UHoudiniAssetComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AHoudiniAssetActor.__PropertyOffset_HoudiniAssetComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AHoudiniAssetActor.__PropertyOffset_HoudiniAssetComponent, value);
			}
		}

		// Token: 0x060131EA RID: 78314 RVA: 0x001C1F38 File Offset: 0x001C0138
		static AHoudiniAssetActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniAssetActor");
		}

		// Token: 0x060131EB RID: 78315 RVA: 0x001C1F46 File Offset: 0x001C0146
		protected AHoudiniAssetActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A525 RID: 42277
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniAssetActor";

		// Token: 0x0400A526 RID: 42278
		private static IntPtr _ClassPtr;

		// Token: 0x0400A527 RID: 42279
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A528 RID: 42280
		internal static int __PropertyOffset_HoudiniAssetComponent;
	}
}
