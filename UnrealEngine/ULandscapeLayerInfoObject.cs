using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F7D RID: 8061
	[UnrealObjectPath("/Script/Landscape.LandscapeLayerInfoObject")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class ULandscapeLayerInfoObject : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E957 RID: 125271 RVA: 0x002D73DA File Offset: 0x002D55DA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULandscapeLayerInfoObject._ClassPtr;
		}

		// Token: 0x0601E958 RID: 125272 RVA: 0x002D73E8 File Offset: 0x002D55E8
		public ULandscapeLayerInfoObject() : this(BuiltinUtils.AllocNativeUObject(ULandscapeLayerInfoObject.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E959 RID: 125273 RVA: 0x002D7410 File Offset: 0x002D5610
		[NullableContext(1)]
		public ULandscapeLayerInfoObject(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULandscapeLayerInfoObject.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170079B0 RID: 31152
		// (get) Token: 0x0601E95A RID: 125274 RVA: 0x002D7443 File Offset: 0x002D5643
		// (set) Token: 0x0601E95B RID: 125275 RVA: 0x002D7457 File Offset: 0x002D5657
		public unsafe FName LayerName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULandscapeLayerInfoObject.__PropertyOffset_LayerName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULandscapeLayerInfoObject.__PropertyOffset_LayerName) = value;
			}
		}

		// Token: 0x170079B1 RID: 31153
		// (get) Token: 0x0601E95C RID: 125276 RVA: 0x002D746C File Offset: 0x002D566C
		// (set) Token: 0x0601E95D RID: 125277 RVA: 0x002D7480 File Offset: 0x002D5680
		[Nullable(2)]
		public unsafe UPhysicalMaterial PhysMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicalMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + ULandscapeLayerInfoObject.__PropertyOffset_PhysMaterial);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULandscapeLayerInfoObject.__PropertyOffset_PhysMaterial, value);
			}
		}

		// Token: 0x170079B2 RID: 31154
		// (get) Token: 0x0601E95E RID: 125278 RVA: 0x002D7495 File Offset: 0x002D5695
		// (set) Token: 0x0601E95F RID: 125279 RVA: 0x002D74A5 File Offset: 0x002D56A5
		public unsafe float Hardness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULandscapeLayerInfoObject.__PropertyOffset_Hardness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULandscapeLayerInfoObject.__PropertyOffset_Hardness) = value;
			}
		}

		// Token: 0x170079B3 RID: 31155
		// (get) Token: 0x0601E960 RID: 125280 RVA: 0x002D74B6 File Offset: 0x002D56B6
		// (set) Token: 0x0601E961 RID: 125281 RVA: 0x002D74CA File Offset: 0x002D56CA
		public unsafe FLinearColor LayerUsageDebugColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULandscapeLayerInfoObject.__PropertyOffset_LayerUsageDebugColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULandscapeLayerInfoObject.__PropertyOffset_LayerUsageDebugColor) = value;
			}
		}

		// Token: 0x0601E962 RID: 125282 RVA: 0x002D74DF File Offset: 0x002D56DF
		static ULandscapeLayerInfoObject()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Landscape.LandscapeLayerInfoObject");
		}

		// Token: 0x0601E963 RID: 125283 RVA: 0x002D74ED File Offset: 0x002D56ED
		protected ULandscapeLayerInfoObject(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401086F RID: 67695
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Landscape.LandscapeLayerInfoObject";

		// Token: 0x04010870 RID: 67696
		private static IntPtr _ClassPtr;

		// Token: 0x04010871 RID: 67697
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010872 RID: 67698
		internal static int __PropertyOffset_LayerName;

		// Token: 0x04010873 RID: 67699
		internal static int __PropertyOffset_PhysMaterial;

		// Token: 0x04010874 RID: 67700
		internal static int __PropertyOffset_Hardness;

		// Token: 0x04010875 RID: 67701
		internal static int __PropertyOffset_LayerUsageDebugColor;
	}
}
