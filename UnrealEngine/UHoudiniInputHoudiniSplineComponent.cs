using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014D2 RID: 5330
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniInputHoudiniSplineComponent")]
	[UnrealStructLayout(272, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 272)]
	public class UHoudiniInputHoudiniSplineComponent : UHoudiniInputObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013502 RID: 79106 RVA: 0x001C65D3 File Offset: 0x001C47D3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniInputHoudiniSplineComponent._ClassPtr;
		}

		// Token: 0x06013503 RID: 79107 RVA: 0x001C65E0 File Offset: 0x001C47E0
		public UHoudiniInputHoudiniSplineComponent() : this(BuiltinUtils.AllocNativeUObject(UHoudiniInputHoudiniSplineComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013504 RID: 79108 RVA: 0x001C6608 File Offset: 0x001C4808
		[NullableContext(1)]
		public UHoudiniInputHoudiniSplineComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniInputHoudiniSplineComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004B46 RID: 19270
		// (get) Token: 0x06013505 RID: 79109 RVA: 0x001C663B File Offset: 0x001C483B
		// (set) Token: 0x06013506 RID: 79110 RVA: 0x001C664B File Offset: 0x001C484B
		public unsafe EHoudiniCurveType CurveType
		{
			get
			{
				return (EHoudiniCurveType)(*(base.NativePtr + (IntPtr)UHoudiniInputHoudiniSplineComponent.__PropertyOffset_CurveType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInputHoudiniSplineComponent.__PropertyOffset_CurveType) = (byte)value;
			}
		}

		// Token: 0x17004B47 RID: 19271
		// (get) Token: 0x06013507 RID: 79111 RVA: 0x001C665C File Offset: 0x001C485C
		// (set) Token: 0x06013508 RID: 79112 RVA: 0x001C666C File Offset: 0x001C486C
		public unsafe EHoudiniCurveMethod CurveMethod
		{
			get
			{
				return (EHoudiniCurveMethod)(*(base.NativePtr + (IntPtr)UHoudiniInputHoudiniSplineComponent.__PropertyOffset_CurveMethod));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInputHoudiniSplineComponent.__PropertyOffset_CurveMethod) = (byte)value;
			}
		}

		// Token: 0x17004B48 RID: 19272
		// (get) Token: 0x06013509 RID: 79113 RVA: 0x001C667D File Offset: 0x001C487D
		// (set) Token: 0x0601350A RID: 79114 RVA: 0x001C668D File Offset: 0x001C488D
		public unsafe bool Reversed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInputHoudiniSplineComponent.__PropertyOffset_Reversed) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInputHoudiniSplineComponent.__PropertyOffset_Reversed) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B49 RID: 19273
		// (get) Token: 0x0601350B RID: 79115 RVA: 0x001C669E File Offset: 0x001C489E
		// (set) Token: 0x0601350C RID: 79116 RVA: 0x001C66B2 File Offset: 0x001C48B2
		[Nullable(2)]
		public unsafe UHoudiniSplineComponent CachedComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UHoudiniSplineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UHoudiniInputHoudiniSplineComponent.__PropertyOffset_CachedComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UHoudiniInputHoudiniSplineComponent.__PropertyOffset_CachedComponent, value);
			}
		}

		// Token: 0x0601350D RID: 79117 RVA: 0x001C66C7 File Offset: 0x001C48C7
		static UHoudiniInputHoudiniSplineComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniInputHoudiniSplineComponent");
		}

		// Token: 0x0601350E RID: 79118 RVA: 0x001C66D5 File Offset: 0x001C48D5
		protected UHoudiniInputHoudiniSplineComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A6E9 RID: 42729
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniInputHoudiniSplineComponent";

		// Token: 0x0400A6EA RID: 42730
		private static IntPtr _ClassPtr;

		// Token: 0x0400A6EB RID: 42731
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A6EC RID: 42732
		internal static int __PropertyOffset_CurveType;

		// Token: 0x0400A6ED RID: 42733
		internal static int __PropertyOffset_CurveMethod;

		// Token: 0x0400A6EE RID: 42734
		internal static int __PropertyOffset_Reversed;

		// Token: 0x0400A6EF RID: 42735
		internal static int __PropertyOffset_CachedComponent;
	}
}
