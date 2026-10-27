using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020014DE RID: 5342
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniInstancedOutput")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 144)]
	public class FHoudiniInstancedOutput : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601357C RID: 79228 RVA: 0x001C70CA File Offset: 0x001C52CA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FHoudiniInstancedOutput._ScriptStructPtr != 0) ? FHoudiniInstancedOutput._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/HoudiniEngineRuntime.HoudiniInstancedOutput", ref FHoudiniInstancedOutput._ScriptStructPtr);
		}

		// Token: 0x17004B65 RID: 19301
		// (get) Token: 0x0601357D RID: 79229 RVA: 0x001C70EE File Offset: 0x001C52EE
		// (set) Token: 0x0601357E RID: 79230 RVA: 0x001C710D File Offset: 0x001C530D
		public TSoftObjectPtr<UObject> OriginalObject
		{
			get
			{
				return new TSoftObjectPtr<UObject>(base.NativePtr + (IntPtr)FHoudiniInstancedOutput.__PropertyOffset_OriginalObject, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)FHoudiniInstancedOutput.__PropertyOffset_OriginalObject, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17004B66 RID: 19302
		// (get) Token: 0x0601357F RID: 79231 RVA: 0x001C7132 File Offset: 0x001C5332
		// (set) Token: 0x06013580 RID: 79232 RVA: 0x001C7142 File Offset: 0x001C5342
		public unsafe int OriginalObjectIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHoudiniInstancedOutput.__PropertyOffset_OriginalObjectIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniInstancedOutput.__PropertyOffset_OriginalObjectIndex) = value;
			}
		}

		// Token: 0x17004B67 RID: 19303
		// (get) Token: 0x06013581 RID: 79233 RVA: 0x001C7154 File Offset: 0x001C5354
		// (set) Token: 0x06013582 RID: 79234 RVA: 0x001C7197 File Offset: 0x001C5397
		public TArray<FTransform> OriginalTransforms
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTransform> result;
				if ((result = this._OriginalTransforms) == null)
				{
					result = (this._OriginalTransforms = new TArray<FTransform>(base.NativePtr + (IntPtr)FHoudiniInstancedOutput.__PropertyOffset_OriginalTransforms, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.OriginalTransforms.CopyAssign(value);
			}
		}

		// Token: 0x17004B68 RID: 19304
		// (get) Token: 0x06013583 RID: 79235 RVA: 0x001C71A8 File Offset: 0x001C53A8
		// (set) Token: 0x06013584 RID: 79236 RVA: 0x001C71EB File Offset: 0x001C53EB
		public TArray<TSoftObjectPtr<UObject>> VariationObjects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<TSoftObjectPtr<UObject>> result;
				if ((result = this._VariationObjects) == null)
				{
					result = (this._VariationObjects = new TArray<TSoftObjectPtr<UObject>>(base.NativePtr + (IntPtr)FHoudiniInstancedOutput.__PropertyOffset_VariationObjects, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.VariationObjects.CopyAssign(value);
			}
		}

		// Token: 0x17004B69 RID: 19305
		// (get) Token: 0x06013585 RID: 79237 RVA: 0x001C71FC File Offset: 0x001C53FC
		// (set) Token: 0x06013586 RID: 79238 RVA: 0x001C723F File Offset: 0x001C543F
		public TArray<FTransform> VariationTransformOffsets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTransform> result;
				if ((result = this._VariationTransformOffsets) == null)
				{
					result = (this._VariationTransformOffsets = new TArray<FTransform>(base.NativePtr + (IntPtr)FHoudiniInstancedOutput.__PropertyOffset_VariationTransformOffsets, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.VariationTransformOffsets.CopyAssign(value);
			}
		}

		// Token: 0x17004B6A RID: 19306
		// (get) Token: 0x06013587 RID: 79239 RVA: 0x001C7250 File Offset: 0x001C5450
		// (set) Token: 0x06013588 RID: 79240 RVA: 0x001C7293 File Offset: 0x001C5493
		public TArray<int> TransformVariationIndices
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._TransformVariationIndices) == null)
				{
					result = (this._TransformVariationIndices = new TArray<int>(base.NativePtr + (IntPtr)FHoudiniInstancedOutput.__PropertyOffset_TransformVariationIndices, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TransformVariationIndices.CopyAssign(value);
			}
		}

		// Token: 0x17004B6B RID: 19307
		// (get) Token: 0x06013589 RID: 79241 RVA: 0x001C72A4 File Offset: 0x001C54A4
		// (set) Token: 0x0601358A RID: 79242 RVA: 0x001C72E7 File Offset: 0x001C54E7
		public TArray<int> OriginalInstanceIndices
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._OriginalInstanceIndices) == null)
				{
					result = (this._OriginalInstanceIndices = new TArray<int>(base.NativePtr + (IntPtr)FHoudiniInstancedOutput.__PropertyOffset_OriginalInstanceIndices, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.OriginalInstanceIndices.CopyAssign(value);
			}
		}

		// Token: 0x17004B6C RID: 19308
		// (get) Token: 0x0601358B RID: 79243 RVA: 0x001C72F5 File Offset: 0x001C54F5
		// (set) Token: 0x0601358C RID: 79244 RVA: 0x001C7305 File Offset: 0x001C5505
		public unsafe bool bChanged
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHoudiniInstancedOutput.__PropertyOffset_bChanged) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniInstancedOutput.__PropertyOffset_bChanged) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B6D RID: 19309
		// (get) Token: 0x0601358D RID: 79245 RVA: 0x001C7316 File Offset: 0x001C5516
		// (set) Token: 0x0601358E RID: 79246 RVA: 0x001C7326 File Offset: 0x001C5526
		public unsafe bool bStale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHoudiniInstancedOutput.__PropertyOffset_bStale) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniInstancedOutput.__PropertyOffset_bStale) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601358F RID: 79247 RVA: 0x001C7337 File Offset: 0x001C5537
		public FHoudiniInstancedOutput()
		{
		}

		// Token: 0x06013590 RID: 79248 RVA: 0x001C7340 File Offset: 0x001C5540
		public FHoudiniInstancedOutput(TSoftObjectPtr<UObject> OriginalObject, int OriginalObjectIndex, TArray<FTransform> OriginalTransforms, TArray<TSoftObjectPtr<UObject>> VariationObjects, TArray<FTransform> VariationTransformOffsets, TArray<int> TransformVariationIndices, TArray<int> OriginalInstanceIndices, bool bChanged, bool bStale, bool bUniformScaleLocked)
		{
			this.OriginalObject = OriginalObject;
			this.OriginalObjectIndex = OriginalObjectIndex;
			this.OriginalTransforms = OriginalTransforms;
			this.VariationObjects = VariationObjects;
			this.VariationTransformOffsets = VariationTransformOffsets;
			this.TransformVariationIndices = TransformVariationIndices;
			this.OriginalInstanceIndices = OriginalInstanceIndices;
			this.bChanged = bChanged;
			this.bStale = bStale;
		}

		// Token: 0x06013591 RID: 79249 RVA: 0x001C7398 File Offset: 0x001C5598
		protected override IntPtr GetUStructPtr()
		{
			return FHoudiniInstancedOutput.StaticStruct();
		}

		// Token: 0x06013592 RID: 79250 RVA: 0x001C73A4 File Offset: 0x001C55A4
		[NullableContext(2)]
		public FHoudiniInstancedOutput(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06013593 RID: 79251 RVA: 0x001C73AE File Offset: 0x001C55AE
		public FHoudiniInstancedOutput(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06013594 RID: 79252 RVA: 0x001C73B9 File Offset: 0x001C55B9
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FHoudiniInstancedOutput(Pointer, false, true);
		}

		// Token: 0x06013595 RID: 79253 RVA: 0x001C73C3 File Offset: 0x001C55C3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FHoudiniInstancedOutput(Pointer, MemoryOwner);
		}

		// Token: 0x0400A730 RID: 42800
		public const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniInstancedOutput";

		// Token: 0x0400A731 RID: 42801
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400A732 RID: 42802
		internal static int __PropertyOffset_OriginalObject;

		// Token: 0x0400A733 RID: 42803
		internal static int __PropertyOffset_OriginalObjectIndex;

		// Token: 0x0400A734 RID: 42804
		internal static int __PropertyOffset_OriginalTransforms;

		// Token: 0x0400A735 RID: 42805
		[Nullable(2)]
		private TArray<FTransform> _OriginalTransforms;

		// Token: 0x0400A736 RID: 42806
		internal static int __PropertyOffset_VariationObjects;

		// Token: 0x0400A737 RID: 42807
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TArray<TSoftObjectPtr<UObject>> _VariationObjects;

		// Token: 0x0400A738 RID: 42808
		internal static int __PropertyOffset_VariationTransformOffsets;

		// Token: 0x0400A739 RID: 42809
		[Nullable(2)]
		private TArray<FTransform> _VariationTransformOffsets;

		// Token: 0x0400A73A RID: 42810
		internal static int __PropertyOffset_TransformVariationIndices;

		// Token: 0x0400A73B RID: 42811
		[Nullable(2)]
		private TArray<int> _TransformVariationIndices;

		// Token: 0x0400A73C RID: 42812
		internal static int __PropertyOffset_OriginalInstanceIndices;

		// Token: 0x0400A73D RID: 42813
		[Nullable(2)]
		private TArray<int> _OriginalInstanceIndices;

		// Token: 0x0400A73E RID: 42814
		internal static int __PropertyOffset_bChanged;

		// Token: 0x0400A73F RID: 42815
		internal static int __PropertyOffset_bStale;
	}
}
