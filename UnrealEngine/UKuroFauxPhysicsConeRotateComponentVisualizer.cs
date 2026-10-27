using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001842 RID: 6210
	[UnrealObjectPath("/Script/KuroFauxPhysics.KuroFauxPhysicsConeRotateComponentVisualizer")]
	[UnrealStructLayout(1616, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1616)]
	public class UKuroFauxPhysicsConeRotateComponentVisualizer : UKuroPrimitiveComponentVisualizer, IUnrealUObject, IUnrealObject, IKuroVisualizerInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06016E64 RID: 93796 RVA: 0x00216B21 File Offset: 0x00214D21
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroFauxPhysicsConeRotateComponentVisualizer._ClassPtr;
		}

		// Token: 0x06016E65 RID: 93797 RVA: 0x00216B2D File Offset: 0x00214D2D
		int IKuroVisualizerInterface.InterfaceOffset()
		{
			return UKuroFauxPhysicsConeRotateComponentVisualizer.__InterfaceOffset_IKuroVisualizerInterface;
		}

		// Token: 0x06016E66 RID: 93798 RVA: 0x00216B34 File Offset: 0x00214D34
		public UKuroFauxPhysicsConeRotateComponentVisualizer() : this(BuiltinUtils.AllocNativeUObject(UKuroFauxPhysicsConeRotateComponentVisualizer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06016E67 RID: 93799 RVA: 0x00216B5C File Offset: 0x00214D5C
		[NullableContext(1)]
		public UKuroFauxPhysicsConeRotateComponentVisualizer(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroFauxPhysicsConeRotateComponentVisualizer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06016E68 RID: 93800 RVA: 0x00216B8F File Offset: 0x00214D8F
		static UKuroFauxPhysicsConeRotateComponentVisualizer()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroFauxPhysics.KuroFauxPhysicsConeRotateComponentVisualizer");
		}

		// Token: 0x06016E69 RID: 93801 RVA: 0x00216B9D File Offset: 0x00214D9D
		protected UKuroFauxPhysicsConeRotateComponentVisualizer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C718 RID: 50968
		internal static int __InterfaceOffset_IKuroVisualizerInterface;

		// Token: 0x0400C719 RID: 50969
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroFauxPhysics.KuroFauxPhysicsConeRotateComponentVisualizer";

		// Token: 0x0400C71A RID: 50970
		private static IntPtr _ClassPtr;

		// Token: 0x0400C71B RID: 50971
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
