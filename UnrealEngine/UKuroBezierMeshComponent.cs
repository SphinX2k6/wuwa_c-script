using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001AAB RID: 6827
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroBezierMeshComponent")]
	[UnrealStructLayout(1904, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1904)]
	public class UKuroBezierMeshComponent : UProceduralMeshComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601944F RID: 103503 RVA: 0x00255F0A File Offset: 0x0025410A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroBezierMeshComponent._ClassPtr;
		}

		// Token: 0x06019450 RID: 103504 RVA: 0x00255F18 File Offset: 0x00254118
		public UKuroBezierMeshComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroBezierMeshComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06019451 RID: 103505 RVA: 0x00255F40 File Offset: 0x00254140
		public UKuroBezierMeshComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroBezierMeshComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06019452 RID: 103506 RVA: 0x00255F73 File Offset: 0x00254173
		public void UpdateMesh(int Section)
		{
			UKuroBezierMeshComponent.__UpdateMesh_Internal(base.NativePtr, Section);
		}

		// Token: 0x06019453 RID: 103507 RVA: 0x00255F81 File Offset: 0x00254181
		public void Setup(int Width, float InUnitLength)
		{
			UKuroBezierMeshComponent.__Setup_Internal(base.NativePtr, Width, InUnitLength);
		}

		// Token: 0x06019454 RID: 103508 RVA: 0x00255F90 File Offset: 0x00254190
		public void SetKeyPoint(int Index, float X, float Y, float Z)
		{
			UKuroBezierMeshComponent.__SetKeyPoint_Internal(base.NativePtr, Index, X, Y, Z);
		}

		// Token: 0x06019455 RID: 103509 RVA: 0x00255FA2 File Offset: 0x002541A2
		public TArray<FVector> GetPointsArray()
		{
			return new TArray<FVector>(UKuroBezierMeshComponent.__GetPointsArray_Internal(base.NativePtr), null);
		}

		// Token: 0x06019456 RID: 103510 RVA: 0x00255FB5 File Offset: 0x002541B5
		public int GetMeshWidth()
		{
			return UKuroBezierMeshComponent.__GetMeshWidth_Internal(base.NativePtr);
		}

		// Token: 0x06019457 RID: 103511 RVA: 0x00255FC2 File Offset: 0x002541C2
		public TArray<int> GetMeshTriangles()
		{
			return new TArray<int>(UKuroBezierMeshComponent.__GetMeshTriangles_Internal(base.NativePtr), null);
		}

		// Token: 0x06019458 RID: 103512 RVA: 0x00255FD5 File Offset: 0x002541D5
		public TArray<FVector> GetMeshPoints()
		{
			return new TArray<FVector>(UKuroBezierMeshComponent.__GetMeshPoints_Internal(base.NativePtr), null);
		}

		// Token: 0x06019459 RID: 103513 RVA: 0x00255FE8 File Offset: 0x002541E8
		public int GetMeshHeight()
		{
			return UKuroBezierMeshComponent.__GetMeshHeight_Internal(base.NativePtr);
		}

		// Token: 0x0601945A RID: 103514 RVA: 0x00255FF5 File Offset: 0x002541F5
		public int GetLayerNum()
		{
			return UKuroBezierMeshComponent.__GetLayerNum_Internal(base.NativePtr);
		}

		// Token: 0x0601945B RID: 103515 RVA: 0x00256002 File Offset: 0x00254202
		public void Dissipate(float SubLayersNum)
		{
			UKuroBezierMeshComponent.__Dissipate_Internal(base.NativePtr, SubLayersNum);
		}

		// Token: 0x0601945C RID: 103516 RVA: 0x00256010 File Offset: 0x00254210
		public void ClearData()
		{
			UKuroBezierMeshComponent.__ClearData_Internal(base.NativePtr);
		}

		// Token: 0x0601945D RID: 103517 RVA: 0x0025601D File Offset: 0x0025421D
		public void AddLayer(float alpha)
		{
			UKuroBezierMeshComponent.__AddLayer_Internal(base.NativePtr, alpha);
		}

		// Token: 0x0601945E RID: 103518
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateMesh_Internal(IntPtr @this, int Section);

		// Token: 0x0601945F RID: 103519
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Setup_Internal(IntPtr @this, int Width, float InUnitLength);

		// Token: 0x06019460 RID: 103520
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKeyPoint_Internal(IntPtr @this, int Index, float X, float Y, float Z);

		// Token: 0x06019461 RID: 103521
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetPointsArray_Internal(IntPtr @this);

		// Token: 0x06019462 RID: 103522
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetMeshWidth_Internal(IntPtr @this);

		// Token: 0x06019463 RID: 103523
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetMeshTriangles_Internal(IntPtr @this);

		// Token: 0x06019464 RID: 103524
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetMeshPoints_Internal(IntPtr @this);

		// Token: 0x06019465 RID: 103525
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetMeshHeight_Internal(IntPtr @this);

		// Token: 0x06019466 RID: 103526
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetLayerNum_Internal(IntPtr @this);

		// Token: 0x06019467 RID: 103527
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Dissipate_Internal(IntPtr @this, float SubLayersNum);

		// Token: 0x06019468 RID: 103528
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearData_Internal(IntPtr @this);

		// Token: 0x06019469 RID: 103529
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddLayer_Internal(IntPtr @this, float alpha);

		// Token: 0x0601946A RID: 103530 RVA: 0x0025602B File Offset: 0x0025422B
		static UKuroBezierMeshComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroBezierMeshComponent");
		}

		// Token: 0x0601946B RID: 103531 RVA: 0x00256039 File Offset: 0x00254239
		protected UKuroBezierMeshComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400DC7C RID: 56444
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroBezierMeshComponent";

		// Token: 0x0400DC7D RID: 56445
		private static IntPtr _ClassPtr;

		// Token: 0x0400DC7E RID: 56446
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
