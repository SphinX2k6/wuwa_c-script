using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200183D RID: 6205
	[UnrealObjectPath("/Script/KuroFauxPhysics.KuroFauxPhysicsAxisRotateComponentVisualizer")]
	[UnrealStructLayout(1616, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1616)]
	public class UKuroFauxPhysicsAxisRotateComponentVisualizer : UKuroPrimitiveComponentVisualizer, IUnrealUObject, IUnrealObject, IKuroVisualizerInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06016E0A RID: 93706 RVA: 0x00216508 File Offset: 0x00214708
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroFauxPhysicsAxisRotateComponentVisualizer._ClassPtr;
		}

		// Token: 0x06016E0B RID: 93707 RVA: 0x00216514 File Offset: 0x00214714
		int IKuroVisualizerInterface.InterfaceOffset()
		{
			return UKuroFauxPhysicsAxisRotateComponentVisualizer.__InterfaceOffset_IKuroVisualizerInterface;
		}

		// Token: 0x06016E0C RID: 93708 RVA: 0x0021651C File Offset: 0x0021471C
		public UKuroFauxPhysicsAxisRotateComponentVisualizer() : this(BuiltinUtils.AllocNativeUObject(UKuroFauxPhysicsAxisRotateComponentVisualizer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06016E0D RID: 93709 RVA: 0x00216544 File Offset: 0x00214744
		[NullableContext(1)]
		public UKuroFauxPhysicsAxisRotateComponentVisualizer(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroFauxPhysicsAxisRotateComponentVisualizer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06016E0E RID: 93710 RVA: 0x00216577 File Offset: 0x00214777
		static UKuroFauxPhysicsAxisRotateComponentVisualizer()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroFauxPhysics.KuroFauxPhysicsAxisRotateComponentVisualizer");
		}

		// Token: 0x06016E0F RID: 93711 RVA: 0x00216585 File Offset: 0x00214785
		protected UKuroFauxPhysicsAxisRotateComponentVisualizer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C6F9 RID: 50937
		internal static int __InterfaceOffset_IKuroVisualizerInterface;

		// Token: 0x0400C6FA RID: 50938
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroFauxPhysics.KuroFauxPhysicsAxisRotateComponentVisualizer";

		// Token: 0x0400C6FB RID: 50939
		private static IntPtr _ClassPtr;

		// Token: 0x0400C6FC RID: 50940
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
