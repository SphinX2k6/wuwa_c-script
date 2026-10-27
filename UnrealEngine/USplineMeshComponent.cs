using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200117B RID: 4475
	[UnrealObjectPath("/Script/Engine.SplineMeshComponent")]
	[UnrealStructLayout(2176, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2176)]
	public class USplineMeshComponent : UStaticMeshComponent, IUnrealUObject, IUnrealObject, IInterface_CollisionDataProvider, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x060106C6 RID: 67270 RVA: 0x0018219F File Offset: 0x0018039F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USplineMeshComponent._ClassPtr;
		}

		// Token: 0x060106C7 RID: 67271 RVA: 0x001821AB File Offset: 0x001803AB
		int IInterface_CollisionDataProvider.InterfaceOffset()
		{
			return USplineMeshComponent.__InterfaceOffset_IInterface_CollisionDataProvider;
		}

		// Token: 0x060106C8 RID: 67272 RVA: 0x001821B4 File Offset: 0x001803B4
		public USplineMeshComponent() : this(BuiltinUtils.AllocNativeUObject(USplineMeshComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060106C9 RID: 67273 RVA: 0x001821DC File Offset: 0x001803DC
		[NullableContext(1)]
		public USplineMeshComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USplineMeshComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700400E RID: 16398
		// (get) Token: 0x060106CA RID: 67274 RVA: 0x00182210 File Offset: 0x00180410
		// (set) Token: 0x060106CB RID: 67275 RVA: 0x00182249 File Offset: 0x00180449
		[Nullable(1)]
		public FSplineMeshParams SplineParams
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FSplineMeshParams result;
				if ((result = this._SplineParams) == null)
				{
					result = (this._SplineParams = new FSplineMeshParams(base.NativePtr + (IntPtr)USplineMeshComponent.__PropertyOffset_SplineParams, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSplineMeshParams.StaticStruct(), base.NativePtr + (IntPtr)USplineMeshComponent.__PropertyOffset_SplineParams, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700400F RID: 16399
		// (get) Token: 0x060106CC RID: 67276 RVA: 0x0018226A File Offset: 0x0018046A
		// (set) Token: 0x060106CD RID: 67277 RVA: 0x0018227E File Offset: 0x0018047E
		public unsafe FVector SplineUpDir
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USplineMeshComponent.__PropertyOffset_SplineUpDir);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USplineMeshComponent.__PropertyOffset_SplineUpDir) = value;
			}
		}

		// Token: 0x17004010 RID: 16400
		// (get) Token: 0x060106CE RID: 67278 RVA: 0x00182293 File Offset: 0x00180493
		// (set) Token: 0x060106CF RID: 67279 RVA: 0x001822A3 File Offset: 0x001804A3
		public unsafe float SplineBoundaryMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USplineMeshComponent.__PropertyOffset_SplineBoundaryMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USplineMeshComponent.__PropertyOffset_SplineBoundaryMin) = value;
			}
		}

		// Token: 0x17004011 RID: 16401
		// (get) Token: 0x060106D0 RID: 67280 RVA: 0x001822B4 File Offset: 0x001804B4
		// (set) Token: 0x060106D1 RID: 67281 RVA: 0x001822C8 File Offset: 0x001804C8
		public unsafe FGuid CachedMeshBodySetupGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USplineMeshComponent.__PropertyOffset_CachedMeshBodySetupGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USplineMeshComponent.__PropertyOffset_CachedMeshBodySetupGuid) = value;
			}
		}

		// Token: 0x17004012 RID: 16402
		// (get) Token: 0x060106D2 RID: 67282 RVA: 0x001822DD File Offset: 0x001804DD
		// (set) Token: 0x060106D3 RID: 67283 RVA: 0x001822F1 File Offset: 0x001804F1
		[Nullable(2)]
		public unsafe UBodySetup BodySetup
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBodySetup>(base.NativePtr / (IntPtr)sizeof(void*) + USplineMeshComponent.__PropertyOffset_BodySetup);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USplineMeshComponent.__PropertyOffset_BodySetup, value);
			}
		}

		// Token: 0x17004013 RID: 16403
		// (get) Token: 0x060106D4 RID: 67284 RVA: 0x00182306 File Offset: 0x00180506
		// (set) Token: 0x060106D5 RID: 67285 RVA: 0x00182316 File Offset: 0x00180516
		public unsafe float SplineBoundaryMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USplineMeshComponent.__PropertyOffset_SplineBoundaryMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USplineMeshComponent.__PropertyOffset_SplineBoundaryMax) = value;
			}
		}

		// Token: 0x17004014 RID: 16404
		// (get) Token: 0x060106D6 RID: 67286 RVA: 0x00182327 File Offset: 0x00180527
		// (set) Token: 0x060106D7 RID: 67287 RVA: 0x00182340 File Offset: 0x00180540
		public unsafe bool bAllowSplineEditingPerInstance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USplineMeshComponent.__PropertyOffset_bAllowSplineEditingPerInstance) & USplineMeshComponent.__PropertyMask_bAllowSplineEditingPerInstance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USplineMeshComponent.__PropertyOffset_bAllowSplineEditingPerInstance) = ((*(base.NativePtr + (IntPtr)USplineMeshComponent.__PropertyOffset_bAllowSplineEditingPerInstance) & ~USplineMeshComponent.__PropertyMask_bAllowSplineEditingPerInstance) | (value ? USplineMeshComponent.__PropertyMask_bAllowSplineEditingPerInstance : 0));
			}
		}

		// Token: 0x17004015 RID: 16405
		// (get) Token: 0x060106D8 RID: 67288 RVA: 0x00182370 File Offset: 0x00180570
		// (set) Token: 0x060106D9 RID: 67289 RVA: 0x00182389 File Offset: 0x00180589
		public unsafe bool bSmoothInterpRollScale
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USplineMeshComponent.__PropertyOffset_bSmoothInterpRollScale) & USplineMeshComponent.__PropertyMask_bSmoothInterpRollScale) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USplineMeshComponent.__PropertyOffset_bSmoothInterpRollScale) = ((*(base.NativePtr + (IntPtr)USplineMeshComponent.__PropertyOffset_bSmoothInterpRollScale) & ~USplineMeshComponent.__PropertyMask_bSmoothInterpRollScale) | (value ? USplineMeshComponent.__PropertyMask_bSmoothInterpRollScale : 0));
			}
		}

		// Token: 0x17004016 RID: 16406
		// (get) Token: 0x060106DA RID: 67290 RVA: 0x001823B9 File Offset: 0x001805B9
		// (set) Token: 0x060106DB RID: 67291 RVA: 0x001823D2 File Offset: 0x001805D2
		public unsafe bool bMeshDirty
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USplineMeshComponent.__PropertyOffset_bMeshDirty) & USplineMeshComponent.__PropertyMask_bMeshDirty) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USplineMeshComponent.__PropertyOffset_bMeshDirty) = ((*(base.NativePtr + (IntPtr)USplineMeshComponent.__PropertyOffset_bMeshDirty) & ~USplineMeshComponent.__PropertyMask_bMeshDirty) | (value ? USplineMeshComponent.__PropertyMask_bMeshDirty : 0));
			}
		}

		// Token: 0x17004017 RID: 16407
		// (get) Token: 0x060106DC RID: 67292 RVA: 0x00182402 File Offset: 0x00180602
		// (set) Token: 0x060106DD RID: 67293 RVA: 0x00182416 File Offset: 0x00180616
		public unsafe TEnumAsByte<ESplineMeshAxis> ForwardAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USplineMeshComponent.__PropertyOffset_ForwardAxis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USplineMeshComponent.__PropertyOffset_ForwardAxis) = value;
			}
		}

		// Token: 0x17004018 RID: 16408
		// (get) Token: 0x060106DE RID: 67294 RVA: 0x0018242B File Offset: 0x0018062B
		// (set) Token: 0x060106DF RID: 67295 RVA: 0x0018243B File Offset: 0x0018063B
		public unsafe float VirtualTextureMainPassMaxDrawDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USplineMeshComponent.__PropertyOffset_VirtualTextureMainPassMaxDrawDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USplineMeshComponent.__PropertyOffset_VirtualTextureMainPassMaxDrawDistance) = value;
			}
		}

		// Token: 0x060106E0 RID: 67296 RVA: 0x0018244C File Offset: 0x0018064C
		public void UpdateMesh()
		{
			USplineMeshComponent.__UpdateMesh_Internal(base.NativePtr);
		}

		// Token: 0x060106E1 RID: 67297 RVA: 0x00182459 File Offset: 0x00180659
		public void SetStartTangent(FVector StartTangent, bool bUpdateMesh = true)
		{
			USplineMeshComponent.__SetStartTangent_Internal(base.NativePtr, StartTangent, bUpdateMesh);
		}

		// Token: 0x060106E2 RID: 67298 RVA: 0x00182468 File Offset: 0x00180668
		public void SetStartScale(FVector2D? StartScale = null, bool bUpdateMesh = true)
		{
			USplineMeshComponent.__SetStartScale_Internal(base.NativePtr, StartScale ?? new FVector2D
			{
				X = 1f,
				Y = 1f
			}, bUpdateMesh);
		}

		// Token: 0x060106E3 RID: 67299 RVA: 0x001824B5 File Offset: 0x001806B5
		public void SetStartRoll(float StartRoll, bool bUpdateMesh = true)
		{
			USplineMeshComponent.__SetStartRoll_Internal(base.NativePtr, StartRoll, bUpdateMesh);
		}

		// Token: 0x060106E4 RID: 67300 RVA: 0x001824C4 File Offset: 0x001806C4
		public void SetStartPosition(FVector StartPos, bool bUpdateMesh = true)
		{
			USplineMeshComponent.__SetStartPosition_Internal(base.NativePtr, StartPos, bUpdateMesh);
		}

		// Token: 0x060106E5 RID: 67301 RVA: 0x001824D3 File Offset: 0x001806D3
		public void SetStartOffset(FVector2D StartOffset, bool bUpdateMesh = true)
		{
			USplineMeshComponent.__SetStartOffset_Internal(base.NativePtr, StartOffset, bUpdateMesh);
		}

		// Token: 0x060106E6 RID: 67302 RVA: 0x001824E2 File Offset: 0x001806E2
		public void SetStartAndEnd(FVector StartPos, FVector StartTangent, FVector EndPos, FVector EndTangent, bool bUpdateMesh = true)
		{
			USplineMeshComponent.__SetStartAndEnd_Internal(base.NativePtr, StartPos, StartTangent, EndPos, EndTangent, bUpdateMesh);
		}

		// Token: 0x060106E7 RID: 67303 RVA: 0x001824F6 File Offset: 0x001806F6
		public void SetSplineUpDir(in FVector InSplineUpDir, bool bUpdateMesh = true)
		{
			USplineMeshComponent.__SetSplineUpDir_Internal(base.NativePtr, InSplineUpDir, bUpdateMesh);
		}

		// Token: 0x060106E8 RID: 67304 RVA: 0x00182505 File Offset: 0x00180705
		public void SetForwardAxis(ESplineMeshAxis InForwardAxis, bool bUpdateMesh = true)
		{
			USplineMeshComponent.__SetForwardAxis_Internal(base.NativePtr, InForwardAxis, bUpdateMesh);
		}

		// Token: 0x060106E9 RID: 67305 RVA: 0x00182519 File Offset: 0x00180719
		public void SetEndTangent(FVector EndTangent, bool bUpdateMesh = true)
		{
			USplineMeshComponent.__SetEndTangent_Internal(base.NativePtr, EndTangent, bUpdateMesh);
		}

		// Token: 0x060106EA RID: 67306 RVA: 0x00182528 File Offset: 0x00180728
		public void SetEndScale(FVector2D? EndScale = null, bool bUpdateMesh = true)
		{
			USplineMeshComponent.__SetEndScale_Internal(base.NativePtr, EndScale ?? new FVector2D
			{
				X = 1f,
				Y = 1f
			}, bUpdateMesh);
		}

		// Token: 0x060106EB RID: 67307 RVA: 0x00182575 File Offset: 0x00180775
		public void SetEndRoll(float EndRoll, bool bUpdateMesh = true)
		{
			USplineMeshComponent.__SetEndRoll_Internal(base.NativePtr, EndRoll, bUpdateMesh);
		}

		// Token: 0x060106EC RID: 67308 RVA: 0x00182584 File Offset: 0x00180784
		public void SetEndPosition(FVector EndPos, bool bUpdateMesh = true)
		{
			USplineMeshComponent.__SetEndPosition_Internal(base.NativePtr, EndPos, bUpdateMesh);
		}

		// Token: 0x060106ED RID: 67309 RVA: 0x00182593 File Offset: 0x00180793
		public void SetEndOffset(FVector2D EndOffset, bool bUpdateMesh = true)
		{
			USplineMeshComponent.__SetEndOffset_Internal(base.NativePtr, EndOffset, bUpdateMesh);
		}

		// Token: 0x060106EE RID: 67310 RVA: 0x001825A2 File Offset: 0x001807A2
		public void SetBoundaryMin(float InBoundaryMin, bool bUpdateMesh = true)
		{
			USplineMeshComponent.__SetBoundaryMin_Internal(base.NativePtr, InBoundaryMin, bUpdateMesh);
		}

		// Token: 0x060106EF RID: 67311 RVA: 0x001825B1 File Offset: 0x001807B1
		public void SetBoundaryMax(float InBoundaryMax, bool bUpdateMesh = true)
		{
			USplineMeshComponent.__SetBoundaryMax_Internal(base.NativePtr, InBoundaryMax, bUpdateMesh);
		}

		// Token: 0x060106F0 RID: 67312 RVA: 0x001825C0 File Offset: 0x001807C0
		public FVector GetStartTangent()
		{
			return USplineMeshComponent.__GetStartTangent_Internal(base.NativePtr);
		}

		// Token: 0x060106F1 RID: 67313 RVA: 0x001825CD File Offset: 0x001807CD
		public FVector2D GetStartScale()
		{
			return USplineMeshComponent.__GetStartScale_Internal(base.NativePtr);
		}

		// Token: 0x060106F2 RID: 67314 RVA: 0x001825DA File Offset: 0x001807DA
		public float GetStartRoll()
		{
			return USplineMeshComponent.__GetStartRoll_Internal(base.NativePtr);
		}

		// Token: 0x060106F3 RID: 67315 RVA: 0x001825E7 File Offset: 0x001807E7
		public FVector GetStartPosition()
		{
			return USplineMeshComponent.__GetStartPosition_Internal(base.NativePtr);
		}

		// Token: 0x060106F4 RID: 67316 RVA: 0x001825F4 File Offset: 0x001807F4
		public FVector2D GetStartOffset()
		{
			return USplineMeshComponent.__GetStartOffset_Internal(base.NativePtr);
		}

		// Token: 0x060106F5 RID: 67317 RVA: 0x00182601 File Offset: 0x00180801
		public FVector GetSplineUpDir()
		{
			return USplineMeshComponent.__GetSplineUpDir_Internal(base.NativePtr);
		}

		// Token: 0x060106F6 RID: 67318 RVA: 0x0018260E File Offset: 0x0018080E
		public TEnumAsByte<ESplineMeshAxis> GetForwardAxis()
		{
			return USplineMeshComponent.__GetForwardAxis_Internal(base.NativePtr);
		}

		// Token: 0x060106F7 RID: 67319 RVA: 0x0018261B File Offset: 0x0018081B
		public FVector GetEndTangent()
		{
			return USplineMeshComponent.__GetEndTangent_Internal(base.NativePtr);
		}

		// Token: 0x060106F8 RID: 67320 RVA: 0x00182628 File Offset: 0x00180828
		public FVector2D GetEndScale()
		{
			return USplineMeshComponent.__GetEndScale_Internal(base.NativePtr);
		}

		// Token: 0x060106F9 RID: 67321 RVA: 0x00182635 File Offset: 0x00180835
		public float GetEndRoll()
		{
			return USplineMeshComponent.__GetEndRoll_Internal(base.NativePtr);
		}

		// Token: 0x060106FA RID: 67322 RVA: 0x00182642 File Offset: 0x00180842
		public FVector GetEndPosition()
		{
			return USplineMeshComponent.__GetEndPosition_Internal(base.NativePtr);
		}

		// Token: 0x060106FB RID: 67323 RVA: 0x0018264F File Offset: 0x0018084F
		public FVector2D GetEndOffset()
		{
			return USplineMeshComponent.__GetEndOffset_Internal(base.NativePtr);
		}

		// Token: 0x060106FC RID: 67324 RVA: 0x0018265C File Offset: 0x0018085C
		public float GetBoundaryMin()
		{
			return USplineMeshComponent.__GetBoundaryMin_Internal(base.NativePtr);
		}

		// Token: 0x060106FD RID: 67325 RVA: 0x00182669 File Offset: 0x00180869
		public float GetBoundaryMax()
		{
			return USplineMeshComponent.__GetBoundaryMax_Internal(base.NativePtr);
		}

		// Token: 0x060106FE RID: 67326
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateMesh_Internal(IntPtr @this);

		// Token: 0x060106FF RID: 67327
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStartTangent_Internal(IntPtr @this, FVector StartTangent, bool bUpdateMesh);

		// Token: 0x06010700 RID: 67328
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStartScale_Internal(IntPtr @this, FVector2D StartScale, bool bUpdateMesh);

		// Token: 0x06010701 RID: 67329
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStartRoll_Internal(IntPtr @this, float StartRoll, bool bUpdateMesh);

		// Token: 0x06010702 RID: 67330
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStartPosition_Internal(IntPtr @this, FVector StartPos, bool bUpdateMesh);

		// Token: 0x06010703 RID: 67331
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStartOffset_Internal(IntPtr @this, FVector2D StartOffset, bool bUpdateMesh);

		// Token: 0x06010704 RID: 67332
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStartAndEnd_Internal(IntPtr @this, FVector StartPos, FVector StartTangent, FVector EndPos, FVector EndTangent, bool bUpdateMesh);

		// Token: 0x06010705 RID: 67333
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSplineUpDir_Internal(IntPtr @this, in FVector InSplineUpDir, bool bUpdateMesh);

		// Token: 0x06010706 RID: 67334
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetForwardAxis_Internal(IntPtr @this, TEnumAsByte<ESplineMeshAxis> InForwardAxis, bool bUpdateMesh);

		// Token: 0x06010707 RID: 67335
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEndTangent_Internal(IntPtr @this, FVector EndTangent, bool bUpdateMesh);

		// Token: 0x06010708 RID: 67336
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEndScale_Internal(IntPtr @this, FVector2D EndScale, bool bUpdateMesh);

		// Token: 0x06010709 RID: 67337
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEndRoll_Internal(IntPtr @this, float EndRoll, bool bUpdateMesh);

		// Token: 0x0601070A RID: 67338
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEndPosition_Internal(IntPtr @this, FVector EndPos, bool bUpdateMesh);

		// Token: 0x0601070B RID: 67339
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEndOffset_Internal(IntPtr @this, FVector2D EndOffset, bool bUpdateMesh);

		// Token: 0x0601070C RID: 67340
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBoundaryMin_Internal(IntPtr @this, float InBoundaryMin, bool bUpdateMesh);

		// Token: 0x0601070D RID: 67341
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBoundaryMax_Internal(IntPtr @this, float InBoundaryMax, bool bUpdateMesh);

		// Token: 0x0601070E RID: 67342
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetStartTangent_Internal(IntPtr @this);

		// Token: 0x0601070F RID: 67343
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetStartScale_Internal(IntPtr @this);

		// Token: 0x06010710 RID: 67344
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetStartRoll_Internal(IntPtr @this);

		// Token: 0x06010711 RID: 67345
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetStartPosition_Internal(IntPtr @this);

		// Token: 0x06010712 RID: 67346
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetStartOffset_Internal(IntPtr @this);

		// Token: 0x06010713 RID: 67347
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetSplineUpDir_Internal(IntPtr @this);

		// Token: 0x06010714 RID: 67348
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern TEnumAsByte<ESplineMeshAxis> __GetForwardAxis_Internal(IntPtr @this);

		// Token: 0x06010715 RID: 67349
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetEndTangent_Internal(IntPtr @this);

		// Token: 0x06010716 RID: 67350
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetEndScale_Internal(IntPtr @this);

		// Token: 0x06010717 RID: 67351
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetEndRoll_Internal(IntPtr @this);

		// Token: 0x06010718 RID: 67352
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetEndPosition_Internal(IntPtr @this);

		// Token: 0x06010719 RID: 67353
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetEndOffset_Internal(IntPtr @this);

		// Token: 0x0601071A RID: 67354
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetBoundaryMin_Internal(IntPtr @this);

		// Token: 0x0601071B RID: 67355
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetBoundaryMax_Internal(IntPtr @this);

		// Token: 0x0601071C RID: 67356 RVA: 0x00182676 File Offset: 0x00180876
		static USplineMeshComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SplineMeshComponent");
		}

		// Token: 0x0601071D RID: 67357 RVA: 0x00182684 File Offset: 0x00180884
		protected USplineMeshComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008CAE RID: 36014
		internal static int __InterfaceOffset_IInterface_CollisionDataProvider;

		// Token: 0x04008CAF RID: 36015
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SplineMeshComponent";

		// Token: 0x04008CB0 RID: 36016
		private static IntPtr _ClassPtr;

		// Token: 0x04008CB1 RID: 36017
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008CB2 RID: 36018
		internal static int __PropertyOffset_SplineParams;

		// Token: 0x04008CB3 RID: 36019
		[Nullable(2)]
		private FSplineMeshParams _SplineParams;

		// Token: 0x04008CB4 RID: 36020
		internal static int __PropertyOffset_SplineUpDir;

		// Token: 0x04008CB5 RID: 36021
		internal static int __PropertyOffset_SplineBoundaryMin;

		// Token: 0x04008CB6 RID: 36022
		internal static int __PropertyOffset_CachedMeshBodySetupGuid;

		// Token: 0x04008CB7 RID: 36023
		internal static int __PropertyOffset_BodySetup;

		// Token: 0x04008CB8 RID: 36024
		internal static int __PropertyOffset_SplineBoundaryMax;

		// Token: 0x04008CB9 RID: 36025
		internal static int __PropertyOffset_bAllowSplineEditingPerInstance;

		// Token: 0x04008CBA RID: 36026
		internal static byte __PropertyMask_bAllowSplineEditingPerInstance;

		// Token: 0x04008CBB RID: 36027
		internal static int __PropertyOffset_bSmoothInterpRollScale;

		// Token: 0x04008CBC RID: 36028
		internal static byte __PropertyMask_bSmoothInterpRollScale;

		// Token: 0x04008CBD RID: 36029
		internal static int __PropertyOffset_bMeshDirty;

		// Token: 0x04008CBE RID: 36030
		internal static byte __PropertyMask_bMeshDirty;

		// Token: 0x04008CBF RID: 36031
		internal static int __PropertyOffset_ForwardAxis;

		// Token: 0x04008CC0 RID: 36032
		internal static int __PropertyOffset_VirtualTextureMainPassMaxDrawDistance;
	}
}
