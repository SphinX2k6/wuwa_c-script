using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B2F RID: 6959
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroLensFlare")]
	[UnrealStructLayout(272, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 272)]
	public class UKuroLensFlare : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601A440 RID: 107584 RVA: 0x0026C19E File Offset: 0x0026A39E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroLensFlare._ClassPtr;
		}

		// Token: 0x0601A441 RID: 107585 RVA: 0x0026C1AC File Offset: 0x0026A3AC
		public UKuroLensFlare() : this(BuiltinUtils.AllocNativeUObject(UKuroLensFlare.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601A442 RID: 107586 RVA: 0x0026C1D4 File Offset: 0x0026A3D4
		public UKuroLensFlare(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroLensFlare.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700699F RID: 27039
		// (get) Token: 0x0601A443 RID: 107587 RVA: 0x0026C208 File Offset: 0x0026A408
		// (set) Token: 0x0601A444 RID: 107588 RVA: 0x0026C241 File Offset: 0x0026A441
		public TArray<FVector> Vertices
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._Vertices) == null)
				{
					result = (this._Vertices = new TArray<FVector>(base.NativePtr + (IntPtr)UKuroLensFlare.__PropertyOffset_Vertices, this));
				}
				return result;
			}
			set
			{
				this.Vertices.CopyAssign(value);
			}
		}

		// Token: 0x170069A0 RID: 27040
		// (get) Token: 0x0601A445 RID: 107589 RVA: 0x0026C250 File Offset: 0x0026A450
		// (set) Token: 0x0601A446 RID: 107590 RVA: 0x0026C289 File Offset: 0x0026A489
		public TArray<int> Triangles
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._Triangles) == null)
				{
					result = (this._Triangles = new TArray<int>(base.NativePtr + (IntPtr)UKuroLensFlare.__PropertyOffset_Triangles, this));
				}
				return result;
			}
			set
			{
				this.Triangles.CopyAssign(value);
			}
		}

		// Token: 0x170069A1 RID: 27041
		// (get) Token: 0x0601A447 RID: 107591 RVA: 0x0026C298 File Offset: 0x0026A498
		// (set) Token: 0x0601A448 RID: 107592 RVA: 0x0026C2D1 File Offset: 0x0026A4D1
		public TArray<FVector2D> UVs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector2D> result;
				if ((result = this._UVs) == null)
				{
					result = (this._UVs = new TArray<FVector2D>(base.NativePtr + (IntPtr)UKuroLensFlare.__PropertyOffset_UVs, this));
				}
				return result;
			}
			set
			{
				this.UVs.CopyAssign(value);
			}
		}

		// Token: 0x170069A2 RID: 27042
		// (get) Token: 0x0601A449 RID: 107593 RVA: 0x0026C2E0 File Offset: 0x0026A4E0
		// (set) Token: 0x0601A44A RID: 107594 RVA: 0x0026C319 File Offset: 0x0026A519
		public TArray<FLinearColor> VertexColor
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FLinearColor> result;
				if ((result = this._VertexColor) == null)
				{
					result = (this._VertexColor = new TArray<FLinearColor>(base.NativePtr + (IntPtr)UKuroLensFlare.__PropertyOffset_VertexColor, this));
				}
				return result;
			}
			set
			{
				this.VertexColor.CopyAssign(value);
			}
		}

		// Token: 0x170069A3 RID: 27043
		// (get) Token: 0x0601A44B RID: 107595 RVA: 0x0026C327 File Offset: 0x0026A527
		// (set) Token: 0x0601A44C RID: 107596 RVA: 0x0026C33B File Offset: 0x0026A53B
		[Nullable(2)]
		public unsafe UProceduralMeshComponent MeshComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UProceduralMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroLensFlare.__PropertyOffset_MeshComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroLensFlare.__PropertyOffset_MeshComponent, value);
			}
		}

		// Token: 0x0601A44D RID: 107597 RVA: 0x0026C350 File Offset: 0x0026A550
		public void SetVertsProperties(FVector2D ViewportScale, int PrimityIndex, FVector2D UVCenter, FVector2D UVSize, FVector2D LensFlareScale, float LensFlareOffset, float LensFlareRotation, FLinearColor LensFlareTint, FVector2D LensFlareScreenPosition, FVector2D LensFlareDirection)
		{
			UKuroLensFlare.__SetVertsProperties_Internal(base.NativePtr, ViewportScale, PrimityIndex, UVCenter, UVSize, LensFlareScale, LensFlareOffset, LensFlareRotation, LensFlareTint, LensFlareScreenPosition, LensFlareDirection);
		}

		// Token: 0x0601A44E RID: 107598 RVA: 0x0026C379 File Offset: 0x0026A579
		public bool IsViewportEnable()
		{
			return UKuroLensFlare.__IsViewportEnable_Internal(base.NativePtr);
		}

		// Token: 0x0601A44F RID: 107599 RVA: 0x0026C386 File Offset: 0x0026A586
		public bool IsInit()
		{
			return UKuroLensFlare.__IsInit_Internal(base.NativePtr);
		}

		// Token: 0x0601A450 RID: 107600 RVA: 0x0026C393 File Offset: 0x0026A593
		public void InitVecticesData(int LensImageLengths)
		{
			UKuroLensFlare.__InitVecticesData_Internal(base.NativePtr, LensImageLengths);
		}

		// Token: 0x0601A451 RID: 107601 RVA: 0x0026C3A1 File Offset: 0x0026A5A1
		[NullableContext(2)]
		public void Init(UProceduralMeshComponent InputMeshComponent)
		{
			UKuroLensFlare.__Init_Internal(base.NativePtr, (InputMeshComponent != null) ? InputMeshComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601A452 RID: 107602 RVA: 0x0026C3BE File Offset: 0x0026A5BE
		public FVector2D GetViewportSize()
		{
			return UKuroLensFlare.__GetViewportSize_Internal(base.NativePtr);
		}

		// Token: 0x0601A453 RID: 107603
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVertsProperties_Internal(IntPtr @this, FVector2D ViewportScale, int PrimityIndex, FVector2D UVCenter, FVector2D UVSize, FVector2D LensFlareScale, float LensFlareOffset, float LensFlareRotation, FLinearColor LensFlareTint, FVector2D LensFlareScreenPosition, FVector2D LensFlareDirection);

		// Token: 0x0601A454 RID: 107604
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsViewportEnable_Internal(IntPtr @this);

		// Token: 0x0601A455 RID: 107605
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsInit_Internal(IntPtr @this);

		// Token: 0x0601A456 RID: 107606
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitVecticesData_Internal(IntPtr @this, int LensImageLengths);

		// Token: 0x0601A457 RID: 107607
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Init_Internal(IntPtr @this, IntPtr InputMeshComponent);

		// Token: 0x0601A458 RID: 107608
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetViewportSize_Internal(IntPtr @this);

		// Token: 0x0601A459 RID: 107609 RVA: 0x0026C3CB File Offset: 0x0026A5CB
		static UKuroLensFlare()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroLensFlare");
		}

		// Token: 0x0601A45A RID: 107610 RVA: 0x0026C3D9 File Offset: 0x0026A5D9
		protected UKuroLensFlare(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E411 RID: 58385
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroLensFlare";

		// Token: 0x0400E412 RID: 58386
		private static IntPtr _ClassPtr;

		// Token: 0x0400E413 RID: 58387
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E414 RID: 58388
		internal static int __PropertyOffset_Vertices;

		// Token: 0x0400E415 RID: 58389
		[Nullable(2)]
		private TArray<FVector> _Vertices;

		// Token: 0x0400E416 RID: 58390
		internal static int __PropertyOffset_Triangles;

		// Token: 0x0400E417 RID: 58391
		[Nullable(2)]
		private TArray<int> _Triangles;

		// Token: 0x0400E418 RID: 58392
		internal static int __PropertyOffset_UVs;

		// Token: 0x0400E419 RID: 58393
		[Nullable(2)]
		private TArray<FVector2D> _UVs;

		// Token: 0x0400E41A RID: 58394
		internal static int __PropertyOffset_VertexColor;

		// Token: 0x0400E41B RID: 58395
		[Nullable(2)]
		private TArray<FLinearColor> _VertexColor;

		// Token: 0x0400E41C RID: 58396
		internal static int __PropertyOffset_MeshComponent;
	}
}
