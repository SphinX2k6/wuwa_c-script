using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000289 RID: 649
	[UnrealObjectPath("/Script/Engine.SplineMeshComponent")]
	[UnrealStructLayout(2176, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2176)]
	public class USplineMeshComponent : UStaticMeshComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06004717 RID: 18199 RVA: 0x00063BD1 File Offset: 0x00061DD1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USplineMeshComponent._ClassPtr;
		}

		// Token: 0x06004718 RID: 18200 RVA: 0x00063BE0 File Offset: 0x00061DE0
		public USplineMeshComponent() : this(BuiltinUtils.AllocNativeUObject(USplineMeshComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06004719 RID: 18201 RVA: 0x00063C08 File Offset: 0x00061E08
		[NullableContext(1)]
		public USplineMeshComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USplineMeshComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000D19 RID: 3353
		// (get) Token: 0x0600471A RID: 18202 RVA: 0x00063C3B File Offset: 0x00061E3B
		// (set) Token: 0x0600471B RID: 18203 RVA: 0x00063C4F File Offset: 0x00061E4F
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

		// Token: 0x17000D1A RID: 3354
		// (get) Token: 0x0600471C RID: 18204 RVA: 0x00063C64 File Offset: 0x00061E64
		// (set) Token: 0x0600471D RID: 18205 RVA: 0x00063C74 File Offset: 0x00061E74
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

		// Token: 0x17000D1B RID: 3355
		// (get) Token: 0x0600471E RID: 18206 RVA: 0x00063C85 File Offset: 0x00061E85
		// (set) Token: 0x0600471F RID: 18207 RVA: 0x00063C99 File Offset: 0x00061E99
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

		// Token: 0x17000D1C RID: 3356
		// (get) Token: 0x06004720 RID: 18208 RVA: 0x00063CAE File Offset: 0x00061EAE
		// (set) Token: 0x06004721 RID: 18209 RVA: 0x00063CC2 File Offset: 0x00061EC2
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

		// Token: 0x17000D1D RID: 3357
		// (get) Token: 0x06004722 RID: 18210 RVA: 0x00063CD7 File Offset: 0x00061ED7
		// (set) Token: 0x06004723 RID: 18211 RVA: 0x00063CE7 File Offset: 0x00061EE7
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

		// Token: 0x17000D1E RID: 3358
		// (get) Token: 0x06004724 RID: 18212 RVA: 0x00063CF8 File Offset: 0x00061EF8
		// (set) Token: 0x06004725 RID: 18213 RVA: 0x00063D11 File Offset: 0x00061F11
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

		// Token: 0x17000D1F RID: 3359
		// (get) Token: 0x06004726 RID: 18214 RVA: 0x00063D41 File Offset: 0x00061F41
		// (set) Token: 0x06004727 RID: 18215 RVA: 0x00063D5A File Offset: 0x00061F5A
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

		// Token: 0x17000D20 RID: 3360
		// (get) Token: 0x06004728 RID: 18216 RVA: 0x00063D8A File Offset: 0x00061F8A
		// (set) Token: 0x06004729 RID: 18217 RVA: 0x00063DA3 File Offset: 0x00061FA3
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

		// Token: 0x17000D21 RID: 3361
		// (get) Token: 0x0600472A RID: 18218 RVA: 0x00063DD3 File Offset: 0x00061FD3
		// (set) Token: 0x0600472B RID: 18219 RVA: 0x00063DE7 File Offset: 0x00061FE7
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

		// Token: 0x17000D22 RID: 3362
		// (get) Token: 0x0600472C RID: 18220 RVA: 0x00063DFC File Offset: 0x00061FFC
		// (set) Token: 0x0600472D RID: 18221 RVA: 0x00063E0C File Offset: 0x0006200C
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

		// Token: 0x0600472E RID: 18222 RVA: 0x00063E1D File Offset: 0x0006201D
		public void UpdateMesh()
		{
			USplineMeshComponent.__UpdateMesh_Internal(base.NativePtr);
		}

		// Token: 0x0600472F RID: 18223 RVA: 0x00063E2A File Offset: 0x0006202A
		public void SetStartTangent(FVector StartTangent, bool bUpdateMesh = true)
		{
			USplineMeshComponent.__SetStartTangent_Internal(base.NativePtr, StartTangent, bUpdateMesh);
		}

		// Token: 0x06004730 RID: 18224 RVA: 0x00063E3C File Offset: 0x0006203C
		public void SetStartScale(FVector2D? StartScale = null, bool bUpdateMesh = true)
		{
			USplineMeshComponent.__SetStartScale_Internal(base.NativePtr, StartScale ?? new FVector2D
			{
				X = 1f,
				Y = 1f
			}, bUpdateMesh);
		}

		// Token: 0x06004731 RID: 18225 RVA: 0x00063E89 File Offset: 0x00062089
		public void SetStartRoll(float StartRoll, bool bUpdateMesh = true)
		{
			USplineMeshComponent.__SetStartRoll_Internal(base.NativePtr, StartRoll, bUpdateMesh);
		}

		// Token: 0x06004732 RID: 18226 RVA: 0x00063E98 File Offset: 0x00062098
		public void SetStartPosition(FVector StartPos, bool bUpdateMesh = true)
		{
			USplineMeshComponent.__SetStartPosition_Internal(base.NativePtr, StartPos, bUpdateMesh);
		}

		// Token: 0x06004733 RID: 18227 RVA: 0x00063EA7 File Offset: 0x000620A7
		public void SetStartOffset(FVector2D StartOffset, bool bUpdateMesh = true)
		{
			USplineMeshComponent.__SetStartOffset_Internal(base.NativePtr, StartOffset, bUpdateMesh);
		}

		// Token: 0x06004734 RID: 18228 RVA: 0x00063EB6 File Offset: 0x000620B6
		public void SetStartAndEnd(FVector StartPos, FVector StartTangent, FVector EndPos, FVector EndTangent, bool bUpdateMesh = true)
		{
			USplineMeshComponent.__SetStartAndEnd_Internal(base.NativePtr, StartPos, StartTangent, EndPos, EndTangent, bUpdateMesh);
		}

		// Token: 0x06004735 RID: 18229 RVA: 0x00063ECA File Offset: 0x000620CA
		public void SetSplineUpDir(in FVector InSplineUpDir, bool bUpdateMesh = true)
		{
			USplineMeshComponent.__SetSplineUpDir_Internal(base.NativePtr, InSplineUpDir, bUpdateMesh);
		}

		// Token: 0x06004736 RID: 18230 RVA: 0x00063ED9 File Offset: 0x000620D9
		public void SetForwardAxis(ESplineMeshAxis InForwardAxis, bool bUpdateMesh = true)
		{
			USplineMeshComponent.__SetForwardAxis_Internal(base.NativePtr, InForwardAxis, bUpdateMesh);
		}

		// Token: 0x06004737 RID: 18231 RVA: 0x00063EED File Offset: 0x000620ED
		public void SetEndTangent(FVector EndTangent, bool bUpdateMesh = true)
		{
			USplineMeshComponent.__SetEndTangent_Internal(base.NativePtr, EndTangent, bUpdateMesh);
		}

		// Token: 0x06004738 RID: 18232 RVA: 0x00063EFC File Offset: 0x000620FC
		public void SetEndScale(FVector2D? EndScale = null, bool bUpdateMesh = true)
		{
			USplineMeshComponent.__SetEndScale_Internal(base.NativePtr, EndScale ?? new FVector2D
			{
				X = 1f,
				Y = 1f
			}, bUpdateMesh);
		}

		// Token: 0x06004739 RID: 18233 RVA: 0x00063F49 File Offset: 0x00062149
		public void SetEndRoll(float EndRoll, bool bUpdateMesh = true)
		{
			USplineMeshComponent.__SetEndRoll_Internal(base.NativePtr, EndRoll, bUpdateMesh);
		}

		// Token: 0x0600473A RID: 18234 RVA: 0x00063F58 File Offset: 0x00062158
		public void SetEndPosition(FVector EndPos, bool bUpdateMesh = true)
		{
			USplineMeshComponent.__SetEndPosition_Internal(base.NativePtr, EndPos, bUpdateMesh);
		}

		// Token: 0x0600473B RID: 18235 RVA: 0x00063F67 File Offset: 0x00062167
		public void SetEndOffset(FVector2D EndOffset, bool bUpdateMesh = true)
		{
			USplineMeshComponent.__SetEndOffset_Internal(base.NativePtr, EndOffset, bUpdateMesh);
		}

		// Token: 0x0600473C RID: 18236 RVA: 0x00063F76 File Offset: 0x00062176
		public void SetBoundaryMin(float InBoundaryMin, bool bUpdateMesh = true)
		{
			USplineMeshComponent.__SetBoundaryMin_Internal(base.NativePtr, InBoundaryMin, bUpdateMesh);
		}

		// Token: 0x0600473D RID: 18237 RVA: 0x00063F85 File Offset: 0x00062185
		public void SetBoundaryMax(float InBoundaryMax, bool bUpdateMesh = true)
		{
			USplineMeshComponent.__SetBoundaryMax_Internal(base.NativePtr, InBoundaryMax, bUpdateMesh);
		}

		// Token: 0x0600473E RID: 18238 RVA: 0x00063F94 File Offset: 0x00062194
		public FVector GetStartTangent()
		{
			return USplineMeshComponent.__GetStartTangent_Internal(base.NativePtr);
		}

		// Token: 0x0600473F RID: 18239 RVA: 0x00063FA1 File Offset: 0x000621A1
		public FVector2D GetStartScale()
		{
			return USplineMeshComponent.__GetStartScale_Internal(base.NativePtr);
		}

		// Token: 0x06004740 RID: 18240 RVA: 0x00063FAE File Offset: 0x000621AE
		public float GetStartRoll()
		{
			return USplineMeshComponent.__GetStartRoll_Internal(base.NativePtr);
		}

		// Token: 0x06004741 RID: 18241 RVA: 0x00063FBB File Offset: 0x000621BB
		public FVector GetStartPosition()
		{
			return USplineMeshComponent.__GetStartPosition_Internal(base.NativePtr);
		}

		// Token: 0x06004742 RID: 18242 RVA: 0x00063FC8 File Offset: 0x000621C8
		public FVector2D GetStartOffset()
		{
			return USplineMeshComponent.__GetStartOffset_Internal(base.NativePtr);
		}

		// Token: 0x06004743 RID: 18243 RVA: 0x00063FD5 File Offset: 0x000621D5
		public FVector GetSplineUpDir()
		{
			return USplineMeshComponent.__GetSplineUpDir_Internal(base.NativePtr);
		}

		// Token: 0x06004744 RID: 18244 RVA: 0x00063FE2 File Offset: 0x000621E2
		public TEnumAsByte<ESplineMeshAxis> GetForwardAxis()
		{
			return USplineMeshComponent.__GetForwardAxis_Internal(base.NativePtr);
		}

		// Token: 0x06004745 RID: 18245 RVA: 0x00063FEF File Offset: 0x000621EF
		public FVector GetEndTangent()
		{
			return USplineMeshComponent.__GetEndTangent_Internal(base.NativePtr);
		}

		// Token: 0x06004746 RID: 18246 RVA: 0x00063FFC File Offset: 0x000621FC
		public FVector2D GetEndScale()
		{
			return USplineMeshComponent.__GetEndScale_Internal(base.NativePtr);
		}

		// Token: 0x06004747 RID: 18247 RVA: 0x00064009 File Offset: 0x00062209
		public float GetEndRoll()
		{
			return USplineMeshComponent.__GetEndRoll_Internal(base.NativePtr);
		}

		// Token: 0x06004748 RID: 18248 RVA: 0x00064016 File Offset: 0x00062216
		public FVector GetEndPosition()
		{
			return USplineMeshComponent.__GetEndPosition_Internal(base.NativePtr);
		}

		// Token: 0x06004749 RID: 18249 RVA: 0x00064023 File Offset: 0x00062223
		public FVector2D GetEndOffset()
		{
			return USplineMeshComponent.__GetEndOffset_Internal(base.NativePtr);
		}

		// Token: 0x0600474A RID: 18250 RVA: 0x00064030 File Offset: 0x00062230
		public float GetBoundaryMin()
		{
			return USplineMeshComponent.__GetBoundaryMin_Internal(base.NativePtr);
		}

		// Token: 0x0600474B RID: 18251 RVA: 0x0006403D File Offset: 0x0006223D
		public float GetBoundaryMax()
		{
			return USplineMeshComponent.__GetBoundaryMax_Internal(base.NativePtr);
		}

		// Token: 0x0600474C RID: 18252
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateMesh_Internal(IntPtr @this);

		// Token: 0x0600474D RID: 18253
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStartTangent_Internal(IntPtr @this, FVector StartTangent, bool bUpdateMesh);

		// Token: 0x0600474E RID: 18254
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStartScale_Internal(IntPtr @this, FVector2D StartScale, bool bUpdateMesh);

		// Token: 0x0600474F RID: 18255
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStartRoll_Internal(IntPtr @this, float StartRoll, bool bUpdateMesh);

		// Token: 0x06004750 RID: 18256
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStartPosition_Internal(IntPtr @this, FVector StartPos, bool bUpdateMesh);

		// Token: 0x06004751 RID: 18257
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStartOffset_Internal(IntPtr @this, FVector2D StartOffset, bool bUpdateMesh);

		// Token: 0x06004752 RID: 18258
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStartAndEnd_Internal(IntPtr @this, FVector StartPos, FVector StartTangent, FVector EndPos, FVector EndTangent, bool bUpdateMesh);

		// Token: 0x06004753 RID: 18259
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSplineUpDir_Internal(IntPtr @this, in FVector InSplineUpDir, bool bUpdateMesh);

		// Token: 0x06004754 RID: 18260
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetForwardAxis_Internal(IntPtr @this, TEnumAsByte<ESplineMeshAxis> InForwardAxis, bool bUpdateMesh);

		// Token: 0x06004755 RID: 18261
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEndTangent_Internal(IntPtr @this, FVector EndTangent, bool bUpdateMesh);

		// Token: 0x06004756 RID: 18262
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEndScale_Internal(IntPtr @this, FVector2D EndScale, bool bUpdateMesh);

		// Token: 0x06004757 RID: 18263
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEndRoll_Internal(IntPtr @this, float EndRoll, bool bUpdateMesh);

		// Token: 0x06004758 RID: 18264
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEndPosition_Internal(IntPtr @this, FVector EndPos, bool bUpdateMesh);

		// Token: 0x06004759 RID: 18265
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEndOffset_Internal(IntPtr @this, FVector2D EndOffset, bool bUpdateMesh);

		// Token: 0x0600475A RID: 18266
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBoundaryMin_Internal(IntPtr @this, float InBoundaryMin, bool bUpdateMesh);

		// Token: 0x0600475B RID: 18267
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBoundaryMax_Internal(IntPtr @this, float InBoundaryMax, bool bUpdateMesh);

		// Token: 0x0600475C RID: 18268
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetStartTangent_Internal(IntPtr @this);

		// Token: 0x0600475D RID: 18269
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetStartScale_Internal(IntPtr @this);

		// Token: 0x0600475E RID: 18270
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetStartRoll_Internal(IntPtr @this);

		// Token: 0x0600475F RID: 18271
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetStartPosition_Internal(IntPtr @this);

		// Token: 0x06004760 RID: 18272
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetStartOffset_Internal(IntPtr @this);

		// Token: 0x06004761 RID: 18273
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetSplineUpDir_Internal(IntPtr @this);

		// Token: 0x06004762 RID: 18274
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern TEnumAsByte<ESplineMeshAxis> __GetForwardAxis_Internal(IntPtr @this);

		// Token: 0x06004763 RID: 18275
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetEndTangent_Internal(IntPtr @this);

		// Token: 0x06004764 RID: 18276
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetEndScale_Internal(IntPtr @this);

		// Token: 0x06004765 RID: 18277
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetEndRoll_Internal(IntPtr @this);

		// Token: 0x06004766 RID: 18278
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetEndPosition_Internal(IntPtr @this);

		// Token: 0x06004767 RID: 18279
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetEndOffset_Internal(IntPtr @this);

		// Token: 0x06004768 RID: 18280
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetBoundaryMin_Internal(IntPtr @this);

		// Token: 0x06004769 RID: 18281
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetBoundaryMax_Internal(IntPtr @this);

		// Token: 0x0600476A RID: 18282 RVA: 0x0006404A File Offset: 0x0006224A
		static USplineMeshComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SplineMeshComponent");
		}

		// Token: 0x0600476B RID: 18283 RVA: 0x00064058 File Offset: 0x00062258
		protected USplineMeshComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001B66 RID: 7014
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SplineMeshComponent";

		// Token: 0x04001B67 RID: 7015
		private static IntPtr _ClassPtr;

		// Token: 0x04001B68 RID: 7016
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001B69 RID: 7017
		internal static int __PropertyOffset_SplineUpDir;

		// Token: 0x04001B6A RID: 7018
		internal static int __PropertyOffset_SplineBoundaryMin;

		// Token: 0x04001B6B RID: 7019
		internal static int __PropertyOffset_CachedMeshBodySetupGuid;

		// Token: 0x04001B6C RID: 7020
		internal static int __PropertyOffset_BodySetup;

		// Token: 0x04001B6D RID: 7021
		internal static int __PropertyOffset_SplineBoundaryMax;

		// Token: 0x04001B6E RID: 7022
		internal static int __PropertyOffset_bAllowSplineEditingPerInstance;

		// Token: 0x04001B6F RID: 7023
		internal static byte __PropertyMask_bAllowSplineEditingPerInstance;

		// Token: 0x04001B70 RID: 7024
		internal static int __PropertyOffset_bSmoothInterpRollScale;

		// Token: 0x04001B71 RID: 7025
		internal static byte __PropertyMask_bSmoothInterpRollScale;

		// Token: 0x04001B72 RID: 7026
		internal static int __PropertyOffset_bMeshDirty;

		// Token: 0x04001B73 RID: 7027
		internal static byte __PropertyMask_bMeshDirty;

		// Token: 0x04001B74 RID: 7028
		internal static int __PropertyOffset_ForwardAxis;

		// Token: 0x04001B75 RID: 7029
		internal static int __PropertyOffset_VirtualTextureMainPassMaxDrawDistance;
	}
}
