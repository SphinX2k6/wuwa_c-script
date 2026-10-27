using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001844 RID: 6212
	[UnrealObjectPath("/Script/KuroFauxPhysics.KuroFauxPhysicsFreeRotateComponentVisualizer")]
	[UnrealStructLayout(1616, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1616)]
	public class UKuroFauxPhysicsFreeRotateComponentVisualizer : UKuroPrimitiveComponentVisualizer, IUnrealUObject, IUnrealObject, IKuroVisualizerInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06016E73 RID: 93811 RVA: 0x00216C53 File Offset: 0x00214E53
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroFauxPhysicsFreeRotateComponentVisualizer._ClassPtr;
		}

		// Token: 0x06016E74 RID: 93812 RVA: 0x00216C5F File Offset: 0x00214E5F
		int IKuroVisualizerInterface.InterfaceOffset()
		{
			return UKuroFauxPhysicsFreeRotateComponentVisualizer.__InterfaceOffset_IKuroVisualizerInterface;
		}

		// Token: 0x06016E75 RID: 93813 RVA: 0x00216C68 File Offset: 0x00214E68
		public UKuroFauxPhysicsFreeRotateComponentVisualizer() : this(BuiltinUtils.AllocNativeUObject(UKuroFauxPhysicsFreeRotateComponentVisualizer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06016E76 RID: 93814 RVA: 0x00216C90 File Offset: 0x00214E90
		[NullableContext(1)]
		public UKuroFauxPhysicsFreeRotateComponentVisualizer(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroFauxPhysicsFreeRotateComponentVisualizer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06016E77 RID: 93815 RVA: 0x00216CC3 File Offset: 0x00214EC3
		static UKuroFauxPhysicsFreeRotateComponentVisualizer()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroFauxPhysics.KuroFauxPhysicsFreeRotateComponentVisualizer");
		}

		// Token: 0x06016E78 RID: 93816 RVA: 0x00216CD1 File Offset: 0x00214ED1
		protected UKuroFauxPhysicsFreeRotateComponentVisualizer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C722 RID: 50978
		internal static int __InterfaceOffset_IKuroVisualizerInterface;

		// Token: 0x0400C723 RID: 50979
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroFauxPhysics.KuroFauxPhysicsFreeRotateComponentVisualizer";

		// Token: 0x0400C724 RID: 50980
		private static IntPtr _ClassPtr;

		// Token: 0x0400C725 RID: 50981
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
