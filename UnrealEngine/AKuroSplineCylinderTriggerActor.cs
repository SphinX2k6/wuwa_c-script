using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200190F RID: 6415
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.KuroSplineCylinderTriggerActor")]
	[UnrealStructLayout(1104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1104)]
	public class AKuroSplineCylinderTriggerActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06017CFE RID: 97534 RVA: 0x0022E047 File Offset: 0x0022C247
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroSplineCylinderTriggerActor._ClassPtr;
		}

		// Token: 0x06017CFF RID: 97535 RVA: 0x0022E054 File Offset: 0x0022C254
		public AKuroSplineCylinderTriggerActor() : this(BuiltinUtils.AllocNativeUObject(AKuroSplineCylinderTriggerActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017D00 RID: 97536 RVA: 0x0022E07C File Offset: 0x0022C27C
		[NullableContext(1)]
		public AKuroSplineCylinderTriggerActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroSplineCylinderTriggerActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005FBE RID: 24510
		// (get) Token: 0x06017D01 RID: 97537 RVA: 0x0022E0AF File Offset: 0x0022C2AF
		// (set) Token: 0x06017D02 RID: 97538 RVA: 0x0022E0C3 File Offset: 0x0022C2C3
		public unsafe UStaticMeshComponent MeshComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroSplineCylinderTriggerActor.__PropertyOffset_MeshComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroSplineCylinderTriggerActor.__PropertyOffset_MeshComponent, value);
			}
		}

		// Token: 0x06017D03 RID: 97539 RVA: 0x0022E0D8 File Offset: 0x0022C2D8
		public void GenerateMesh(USplineComponent Spline, float CircleRadius)
		{
			AKuroSplineCylinderTriggerActor.__GenerateMesh_Internal(base.NativePtr, (Spline != null) ? Spline.NativePtr : IntPtr.Zero, CircleRadius);
		}

		// Token: 0x06017D04 RID: 97540
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GenerateMesh_Internal(IntPtr @this, IntPtr Spline, float CircleRadius);

		// Token: 0x06017D05 RID: 97541 RVA: 0x0022E0F6 File Offset: 0x0022C2F6
		static AKuroSplineCylinderTriggerActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroSplineCylinderTriggerActor");
		}

		// Token: 0x06017D06 RID: 97542 RVA: 0x0022E104 File Offset: 0x0022C304
		protected AKuroSplineCylinderTriggerActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CE82 RID: 52866
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroSplineCylinderTriggerActor";

		// Token: 0x0400CE83 RID: 52867
		private static IntPtr _ClassPtr;

		// Token: 0x0400CE84 RID: 52868
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400CE85 RID: 52869
		internal static int __PropertyOffset_MeshComponent;
	}
}
