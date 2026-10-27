using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001179 RID: 4473
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SplineInstanceData")]
	[UnrealStructLayout(416, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 416)]
	public class FSplineInstanceData : FSceneComponentInstanceData, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060106B1 RID: 67249 RVA: 0x00181F3F File Offset: 0x0018013F
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSplineInstanceData._ScriptStructPtr != 0) ? FSplineInstanceData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SplineInstanceData", ref FSplineInstanceData._ScriptStructPtr);
		}

		// Token: 0x1700400A RID: 16394
		// (get) Token: 0x060106B2 RID: 67250 RVA: 0x00181F63 File Offset: 0x00180163
		// (set) Token: 0x060106B3 RID: 67251 RVA: 0x00181F73 File Offset: 0x00180173
		public unsafe bool bSplineHasBeenEdited
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSplineInstanceData.__PropertyOffset_bSplineHasBeenEdited) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSplineInstanceData.__PropertyOffset_bSplineHasBeenEdited) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700400B RID: 16395
		// (get) Token: 0x060106B4 RID: 67252 RVA: 0x00181F84 File Offset: 0x00180184
		// (set) Token: 0x060106B5 RID: 67253 RVA: 0x00181FC7 File Offset: 0x001801C7
		public FSplineCurves SplineCurves
		{
			get
			{
				base.FastCheckIsValid();
				FSplineCurves result;
				if ((result = this._SplineCurves) == null)
				{
					result = (this._SplineCurves = new FSplineCurves(base.NativePtr + (IntPtr)FSplineInstanceData.__PropertyOffset_SplineCurves, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSplineCurves.StaticStruct(), base.NativePtr + (IntPtr)FSplineInstanceData.__PropertyOffset_SplineCurves, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700400C RID: 16396
		// (get) Token: 0x060106B6 RID: 67254 RVA: 0x00181FE8 File Offset: 0x001801E8
		// (set) Token: 0x060106B7 RID: 67255 RVA: 0x0018202B File Offset: 0x0018022B
		public FSplineCurves SplineCurvesPreUCS
		{
			get
			{
				base.FastCheckIsValid();
				FSplineCurves result;
				if ((result = this._SplineCurvesPreUCS) == null)
				{
					result = (this._SplineCurvesPreUCS = new FSplineCurves(base.NativePtr + (IntPtr)FSplineInstanceData.__PropertyOffset_SplineCurvesPreUCS, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSplineCurves.StaticStruct(), base.NativePtr + (IntPtr)FSplineInstanceData.__PropertyOffset_SplineCurvesPreUCS, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060106B8 RID: 67256 RVA: 0x0018204C File Offset: 0x0018024C
		public FSplineInstanceData()
		{
		}

		// Token: 0x060106B9 RID: 67257 RVA: 0x00182054 File Offset: 0x00180254
		public FSplineInstanceData(bool bSplineHasBeenEdited, FSplineCurves SplineCurves, FSplineCurves SplineCurvesPreUCS, TMap<USceneComponent, FTransform> AttachedInstanceComponents, UObject SourceComponentTemplate, EComponentCreationMethod SourceComponentCreationMethod, int SourceComponentTypeSerializedIndex, TArray<byte> SavedProperties, FActorComponentDuplicatedObjectData UniqueTransientPackage, TArray<FActorComponentDuplicatedObjectData> DuplicatedObjects, TArray<UObject> ReferencedObjects, TArray<FName> ReferencedNames)
		{
			this.bSplineHasBeenEdited = bSplineHasBeenEdited;
			this.SplineCurves = SplineCurves;
			this.SplineCurvesPreUCS = SplineCurvesPreUCS;
			base.AttachedInstanceComponents = AttachedInstanceComponents;
			base.SourceComponentTemplate = SourceComponentTemplate;
			base.SourceComponentCreationMethod = SourceComponentCreationMethod;
			base.SourceComponentTypeSerializedIndex = SourceComponentTypeSerializedIndex;
			base.SavedProperties = SavedProperties;
			base.UniqueTransientPackage = UniqueTransientPackage;
			base.DuplicatedObjects = DuplicatedObjects;
			base.ReferencedObjects = ReferencedObjects;
			base.ReferencedNames = ReferencedNames;
		}

		// Token: 0x060106BA RID: 67258 RVA: 0x001820C4 File Offset: 0x001802C4
		protected override IntPtr GetUStructPtr()
		{
			return FSplineInstanceData.StaticStruct();
		}

		// Token: 0x060106BB RID: 67259 RVA: 0x001820D0 File Offset: 0x001802D0
		[NullableContext(2)]
		public FSplineInstanceData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060106BC RID: 67260 RVA: 0x001820DA File Offset: 0x001802DA
		public FSplineInstanceData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060106BD RID: 67261 RVA: 0x001820E5 File Offset: 0x001802E5
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSplineInstanceData(Pointer, false, true);
		}

		// Token: 0x060106BE RID: 67262 RVA: 0x001820EF File Offset: 0x001802EF
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSplineInstanceData(Pointer, MemoryOwner);
		}

		// Token: 0x04008CA3 RID: 36003
		public new const string __ObjectPath = "/Script/Engine.SplineInstanceData";

		// Token: 0x04008CA4 RID: 36004
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008CA5 RID: 36005
		internal static int __PropertyOffset_bSplineHasBeenEdited;

		// Token: 0x04008CA6 RID: 36006
		internal static int __PropertyOffset_SplineCurves;

		// Token: 0x04008CA7 RID: 36007
		[Nullable(2)]
		private FSplineCurves _SplineCurves;

		// Token: 0x04008CA8 RID: 36008
		internal static int __PropertyOffset_SplineCurvesPreUCS;

		// Token: 0x04008CA9 RID: 36009
		[Nullable(2)]
		private FSplineCurves _SplineCurvesPreUCS;
	}
}
