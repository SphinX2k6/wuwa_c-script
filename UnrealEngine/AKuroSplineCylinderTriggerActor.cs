using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000404 RID: 1028
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.KuroSplineCylinderTriggerActor")]
	[UnrealStructLayout(1104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1104)]
	public class AKuroSplineCylinderTriggerActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060064CC RID: 25804 RVA: 0x0008FDCB File Offset: 0x0008DFCB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroSplineCylinderTriggerActor._ClassPtr;
		}

		// Token: 0x060064CD RID: 25805 RVA: 0x0008FDD8 File Offset: 0x0008DFD8
		public AKuroSplineCylinderTriggerActor() : this(BuiltinUtils.AllocNativeUObject(AKuroSplineCylinderTriggerActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060064CE RID: 25806 RVA: 0x0008FE00 File Offset: 0x0008E000
		[NullableContext(1)]
		public AKuroSplineCylinderTriggerActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroSplineCylinderTriggerActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001435 RID: 5173
		// (get) Token: 0x060064CF RID: 25807 RVA: 0x0008FE33 File Offset: 0x0008E033
		// (set) Token: 0x060064D0 RID: 25808 RVA: 0x0008FE47 File Offset: 0x0008E047
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

		// Token: 0x060064D1 RID: 25809 RVA: 0x0008FE5C File Offset: 0x0008E05C
		public void GenerateMesh(USplineComponent Spline, float CircleRadius)
		{
			AKuroSplineCylinderTriggerActor.__GenerateMesh_Internal(base.NativePtr, (Spline != null) ? Spline.NativePtr : IntPtr.Zero, CircleRadius);
		}

		// Token: 0x060064D2 RID: 25810
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GenerateMesh_Internal(IntPtr @this, IntPtr Spline, float CircleRadius);

		// Token: 0x060064D3 RID: 25811 RVA: 0x0008FE7A File Offset: 0x0008E07A
		static AKuroSplineCylinderTriggerActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroSplineCylinderTriggerActor");
		}

		// Token: 0x060064D4 RID: 25812 RVA: 0x0008FE88 File Offset: 0x0008E088
		protected AKuroSplineCylinderTriggerActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002A76 RID: 10870
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroSplineCylinderTriggerActor";

		// Token: 0x04002A77 RID: 10871
		private static IntPtr _ClassPtr;

		// Token: 0x04002A78 RID: 10872
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002A79 RID: 10873
		internal static int __PropertyOffset_MeshComponent;
	}
}
