using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002013 RID: 8211
	[UnrealObjectPath("/Script/LGUI.GeometryHandle")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UGeometryHandle : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601EF30 RID: 126768 RVA: 0x002E06B8 File Offset: 0x002DE8B8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGeometryHandle._ClassPtr;
		}

		// Token: 0x0601EF31 RID: 126769 RVA: 0x002E06C4 File Offset: 0x002DE8C4
		public UGeometryHandle() : this(BuiltinUtils.AllocNativeUObject(UGeometryHandle.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601EF32 RID: 126770 RVA: 0x002E06EC File Offset: 0x002DE8EC
		[NullableContext(1)]
		public UGeometryHandle(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGeometryHandle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601EF33 RID: 126771 RVA: 0x002E071F File Offset: 0x002DE91F
		public void SetAdditionalUV(int AdditionalUVChannel, in FVector2D UV)
		{
			UGeometryHandle.__SetAdditionalUV_Internal(base.NativePtr, AdditionalUVChannel, UV);
		}

		// Token: 0x0601EF34 RID: 126772 RVA: 0x002E072E File Offset: 0x002DE92E
		public bool IsGeometryValid()
		{
			return UGeometryHandle.__IsGeometryValid_Internal(base.NativePtr);
		}

		// Token: 0x0601EF35 RID: 126773
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAdditionalUV_Internal(IntPtr @this, int AdditionalUVChannel, in FVector2D UV);

		// Token: 0x0601EF36 RID: 126774
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsGeometryValid_Internal(IntPtr @this);

		// Token: 0x0601EF37 RID: 126775 RVA: 0x002E073B File Offset: 0x002DE93B
		static UGeometryHandle()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.GeometryHandle");
		}

		// Token: 0x0601EF38 RID: 126776 RVA: 0x002E0749 File Offset: 0x002DE949
		protected UGeometryHandle(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010D3C RID: 68924
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.GeometryHandle";

		// Token: 0x04010D3D RID: 68925
		private static IntPtr _ClassPtr;

		// Token: 0x04010D3E RID: 68926
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
