using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001847 RID: 6215
	[UnrealObjectPath("/Script/KuroFauxPhysics.KuroFauxPhysicsTrackTargetComponentVisualizer")]
	[UnrealStructLayout(1616, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1616)]
	public class UKuroFauxPhysicsTrackTargetComponentVisualizer : UKuroPrimitiveComponentVisualizer, IUnrealUObject, IUnrealObject, IKuroVisualizerInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06016EA4 RID: 93860 RVA: 0x00216FE3 File Offset: 0x002151E3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroFauxPhysicsTrackTargetComponentVisualizer._ClassPtr;
		}

		// Token: 0x06016EA5 RID: 93861 RVA: 0x00216FEF File Offset: 0x002151EF
		int IKuroVisualizerInterface.InterfaceOffset()
		{
			return UKuroFauxPhysicsTrackTargetComponentVisualizer.__InterfaceOffset_IKuroVisualizerInterface;
		}

		// Token: 0x06016EA6 RID: 93862 RVA: 0x00216FF8 File Offset: 0x002151F8
		public UKuroFauxPhysicsTrackTargetComponentVisualizer() : this(BuiltinUtils.AllocNativeUObject(UKuroFauxPhysicsTrackTargetComponentVisualizer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06016EA7 RID: 93863 RVA: 0x00217020 File Offset: 0x00215220
		[NullableContext(1)]
		public UKuroFauxPhysicsTrackTargetComponentVisualizer(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroFauxPhysicsTrackTargetComponentVisualizer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06016EA8 RID: 93864 RVA: 0x00217053 File Offset: 0x00215253
		static UKuroFauxPhysicsTrackTargetComponentVisualizer()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroFauxPhysics.KuroFauxPhysicsTrackTargetComponentVisualizer");
		}

		// Token: 0x06016EA9 RID: 93865 RVA: 0x00217061 File Offset: 0x00215261
		protected UKuroFauxPhysicsTrackTargetComponentVisualizer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C73C RID: 51004
		internal static int __InterfaceOffset_IKuroVisualizerInterface;

		// Token: 0x0400C73D RID: 51005
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroFauxPhysics.KuroFauxPhysicsTrackTargetComponentVisualizer";

		// Token: 0x0400C73E RID: 51006
		private static IntPtr _ClassPtr;

		// Token: 0x0400C73F RID: 51007
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
