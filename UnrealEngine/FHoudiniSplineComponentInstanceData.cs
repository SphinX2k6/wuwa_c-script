using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001502 RID: 5378
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniSplineComponentInstanceData")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 168)]
	public class FHoudiniSplineComponentInstanceData : FActorComponentInstanceData, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06013891 RID: 80017 RVA: 0x001CB663 File Offset: 0x001C9863
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FHoudiniSplineComponentInstanceData._ScriptStructPtr != 0) ? FHoudiniSplineComponentInstanceData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/HoudiniEngineRuntime.HoudiniSplineComponentInstanceData", ref FHoudiniSplineComponentInstanceData._ScriptStructPtr);
		}

		// Token: 0x17004C8C RID: 19596
		// (get) Token: 0x06013892 RID: 80018 RVA: 0x001CB688 File Offset: 0x001C9888
		// (set) Token: 0x06013893 RID: 80019 RVA: 0x001CB6CB File Offset: 0x001C98CB
		public TArray<FTransform> CurvePoints
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTransform> result;
				if ((result = this._CurvePoints) == null)
				{
					result = (this._CurvePoints = new TArray<FTransform>(base.NativePtr + (IntPtr)FHoudiniSplineComponentInstanceData.__PropertyOffset_CurvePoints, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CurvePoints.CopyAssign(value);
			}
		}

		// Token: 0x17004C8D RID: 19597
		// (get) Token: 0x06013894 RID: 80020 RVA: 0x001CB6DC File Offset: 0x001C98DC
		// (set) Token: 0x06013895 RID: 80021 RVA: 0x001CB71F File Offset: 0x001C991F
		public TArray<FVector> DisplayPoints
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._DisplayPoints) == null)
				{
					result = (this._DisplayPoints = new TArray<FVector>(base.NativePtr + (IntPtr)FHoudiniSplineComponentInstanceData.__PropertyOffset_DisplayPoints, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.DisplayPoints.CopyAssign(value);
			}
		}

		// Token: 0x17004C8E RID: 19598
		// (get) Token: 0x06013896 RID: 80022 RVA: 0x001CB730 File Offset: 0x001C9930
		// (set) Token: 0x06013897 RID: 80023 RVA: 0x001CB773 File Offset: 0x001C9973
		public TArray<int> DisplayPointIndexDivider
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._DisplayPointIndexDivider) == null)
				{
					result = (this._DisplayPointIndexDivider = new TArray<int>(base.NativePtr + (IntPtr)FHoudiniSplineComponentInstanceData.__PropertyOffset_DisplayPointIndexDivider, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.DisplayPointIndexDivider.CopyAssign(value);
			}
		}

		// Token: 0x06013898 RID: 80024 RVA: 0x001CB781 File Offset: 0x001C9981
		public FHoudiniSplineComponentInstanceData()
		{
		}

		// Token: 0x06013899 RID: 80025 RVA: 0x001CB78C File Offset: 0x001C998C
		public FHoudiniSplineComponentInstanceData(TArray<FTransform> CurvePoints, TArray<FVector> DisplayPoints, TArray<int> DisplayPointIndexDivider, TArray<int> EditedControlPointsIndexes, UObject SourceComponentTemplate, EComponentCreationMethod SourceComponentCreationMethod, int SourceComponentTypeSerializedIndex, TArray<byte> SavedProperties, FActorComponentDuplicatedObjectData UniqueTransientPackage, TArray<FActorComponentDuplicatedObjectData> DuplicatedObjects, TArray<UObject> ReferencedObjects, TArray<FName> ReferencedNames)
		{
			this.CurvePoints = CurvePoints;
			this.DisplayPoints = DisplayPoints;
			this.DisplayPointIndexDivider = DisplayPointIndexDivider;
			base.SourceComponentTemplate = SourceComponentTemplate;
			base.SourceComponentCreationMethod = SourceComponentCreationMethod;
			base.SourceComponentTypeSerializedIndex = SourceComponentTypeSerializedIndex;
			base.SavedProperties = SavedProperties;
			base.UniqueTransientPackage = UniqueTransientPackage;
			base.DuplicatedObjects = DuplicatedObjects;
			base.ReferencedObjects = ReferencedObjects;
			base.ReferencedNames = ReferencedNames;
		}

		// Token: 0x0601389A RID: 80026 RVA: 0x001CB7F4 File Offset: 0x001C99F4
		protected override IntPtr GetUStructPtr()
		{
			return FHoudiniSplineComponentInstanceData.StaticStruct();
		}

		// Token: 0x0601389B RID: 80027 RVA: 0x001CB800 File Offset: 0x001C9A00
		[NullableContext(2)]
		public FHoudiniSplineComponentInstanceData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601389C RID: 80028 RVA: 0x001CB80A File Offset: 0x001C9A0A
		public FHoudiniSplineComponentInstanceData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601389D RID: 80029 RVA: 0x001CB815 File Offset: 0x001C9A15
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FHoudiniSplineComponentInstanceData(Pointer, false, true);
		}

		// Token: 0x0601389E RID: 80030 RVA: 0x001CB81F File Offset: 0x001C9A1F
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FHoudiniSplineComponentInstanceData(Pointer, MemoryOwner);
		}

		// Token: 0x0400A901 RID: 43265
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniSplineComponentInstanceData";

		// Token: 0x0400A902 RID: 43266
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400A903 RID: 43267
		internal static int __PropertyOffset_CurvePoints;

		// Token: 0x0400A904 RID: 43268
		[Nullable(2)]
		private TArray<FTransform> _CurvePoints;

		// Token: 0x0400A905 RID: 43269
		internal static int __PropertyOffset_DisplayPoints;

		// Token: 0x0400A906 RID: 43270
		[Nullable(2)]
		private TArray<FVector> _DisplayPoints;

		// Token: 0x0400A907 RID: 43271
		internal static int __PropertyOffset_DisplayPointIndexDivider;

		// Token: 0x0400A908 RID: 43272
		[Nullable(2)]
		private TArray<int> _DisplayPointIndexDivider;
	}
}
