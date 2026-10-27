using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020028C3 RID: 10435
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/StaticMeshDescription.StaticMeshDescription")]
	[UnrealStructLayout(968, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 968)]
	public class UStaticMeshDescription : UMeshDescriptionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026BE5 RID: 158693 RVA: 0x003B1ACF File Offset: 0x003AFCCF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UStaticMeshDescription._ClassPtr;
		}

		// Token: 0x06026BE6 RID: 158694 RVA: 0x003B1ADC File Offset: 0x003AFCDC
		public UStaticMeshDescription() : this(BuiltinUtils.AllocNativeUObject(UStaticMeshDescription.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026BE7 RID: 158695 RVA: 0x003B1B04 File Offset: 0x003AFD04
		[NullableContext(1)]
		public UStaticMeshDescription(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UStaticMeshDescription.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06026BE8 RID: 158696 RVA: 0x003B1B37 File Offset: 0x003AFD37
		public void SetVertexInstanceUV(FVertexInstanceID VertexInstanceID, FVector2D UV, int UVIndex = 0)
		{
			UStaticMeshDescription.__SetVertexInstanceUV_Internal(base.NativePtr, (VertexInstanceID ?? new FVertexInstanceID()).NativePtr, UV, UVIndex);
		}

		// Token: 0x06026BE9 RID: 158697 RVA: 0x003B1B58 File Offset: 0x003AFD58
		public unsafe void SetPolygonGroupMaterialSlotName(FPolygonGroupID PolygonGroupID, in FName SlotName)
		{
			fixed (FName* ptr = &SlotName)
			{
				void* ptr2 = (void*)ptr;
				UStaticMeshDescription.__SetPolygonGroupMaterialSlotName_Internal(base.NativePtr, (PolygonGroupID ?? new FPolygonGroupID()).NativePtr, SlotName);
			}
		}

		// Token: 0x06026BEA RID: 158698 RVA: 0x003B1B88 File Offset: 0x003AFD88
		public FVector2D GetVertexInstanceUV(FVertexInstanceID VertexInstanceID, int UVIndex = 0)
		{
			return UStaticMeshDescription.__GetVertexInstanceUV_Internal(base.NativePtr, (VertexInstanceID ?? new FVertexInstanceID()).NativePtr, UVIndex);
		}

		// Token: 0x06026BEB RID: 158699 RVA: 0x003B1BA8 File Offset: 0x003AFDA8
		public void CreateCube(FVector Center, FVector HalfExtents, FPolygonGroupID PolygonGroup, ref FPolygonID PolygonID_PlusX, ref FPolygonID PolygonID_MinusX, ref FPolygonID PolygonID_PlusY, ref FPolygonID PolygonID_MinusY, ref FPolygonID PolygonID_PlusZ, ref FPolygonID PolygonID_MinusZ)
		{
			UStaticMeshDescription.__CreateCube_Internal(base.NativePtr, Center, HalfExtents, (PolygonGroup ?? new FPolygonGroupID()).NativePtr, (PolygonID_PlusX ?? new FPolygonID()).NativePtr, (PolygonID_MinusX ?? new FPolygonID()).NativePtr, (PolygonID_PlusY ?? new FPolygonID()).NativePtr, (PolygonID_MinusY ?? new FPolygonID()).NativePtr, (PolygonID_PlusZ ?? new FPolygonID()).NativePtr, (PolygonID_MinusZ ?? new FPolygonID()).NativePtr);
		}

		// Token: 0x06026BEC RID: 158700
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVertexInstanceUV_Internal(IntPtr @this, IntPtr VertexInstanceID, FVector2D UV, int UVIndex);

		// Token: 0x06026BED RID: 158701
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPolygonGroupMaterialSlotName_Internal(IntPtr @this, IntPtr PolygonGroupID, in FName SlotName);

		// Token: 0x06026BEE RID: 158702
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetVertexInstanceUV_Internal(IntPtr @this, IntPtr VertexInstanceID, int UVIndex);

		// Token: 0x06026BEF RID: 158703
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CreateCube_Internal(IntPtr @this, FVector Center, FVector HalfExtents, IntPtr PolygonGroup, IntPtr PolygonID_PlusX, IntPtr PolygonID_MinusX, IntPtr PolygonID_PlusY, IntPtr PolygonID_MinusY, IntPtr PolygonID_PlusZ, IntPtr PolygonID_MinusZ);

		// Token: 0x06026BF0 RID: 158704 RVA: 0x003B1C37 File Offset: 0x003AFE37
		static UStaticMeshDescription()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/StaticMeshDescription.StaticMeshDescription");
		}

		// Token: 0x06026BF1 RID: 158705 RVA: 0x003B1C45 File Offset: 0x003AFE45
		protected UStaticMeshDescription(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401542F RID: 87087
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/StaticMeshDescription.StaticMeshDescription";

		// Token: 0x04015430 RID: 87088
		private static IntPtr _ClassPtr;

		// Token: 0x04015431 RID: 87089
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
