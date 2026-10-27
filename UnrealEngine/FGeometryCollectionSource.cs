using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001432 RID: 5170
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GeometryCollectionEngine.GeometryCollectionSource")]
	[UnrealStructLayout(96, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FGeometryCollectionSource : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06012EAF RID: 77487 RVA: 0x001BCDE4 File Offset: 0x001BAFE4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGeometryCollectionSource._ScriptStructPtr != 0) ? FGeometryCollectionSource._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GeometryCollectionEngine.GeometryCollectionSource", ref FGeometryCollectionSource._ScriptStructPtr);
		}

		// Token: 0x17004983 RID: 18819
		// (get) Token: 0x06012EB0 RID: 77488 RVA: 0x001BCE08 File Offset: 0x001BB008
		// (set) Token: 0x06012EB1 RID: 77489 RVA: 0x001BCE4B File Offset: 0x001BB04B
		public FSoftObjectPath SourceGeometryObject
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._SourceGeometryObject) == null)
				{
					result = (this._SourceGeometryObject = new FSoftObjectPath(base.NativePtr + (IntPtr)FGeometryCollectionSource.__PropertyOffset_SourceGeometryObject, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)FGeometryCollectionSource.__PropertyOffset_SourceGeometryObject, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004984 RID: 18820
		// (get) Token: 0x06012EB2 RID: 77490 RVA: 0x001BCE6C File Offset: 0x001BB06C
		// (set) Token: 0x06012EB3 RID: 77491 RVA: 0x001BCE80 File Offset: 0x001BB080
		public unsafe FTransform LocalTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGeometryCollectionSource.__PropertyOffset_LocalTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGeometryCollectionSource.__PropertyOffset_LocalTransform) = value;
			}
		}

		// Token: 0x17004985 RID: 18821
		// (get) Token: 0x06012EB4 RID: 77492 RVA: 0x001BCE98 File Offset: 0x001BB098
		// (set) Token: 0x06012EB5 RID: 77493 RVA: 0x001BCEDB File Offset: 0x001BB0DB
		public TArray<UMaterialInterface> SourceMaterial
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInterface> result;
				if ((result = this._SourceMaterial) == null)
				{
					result = (this._SourceMaterial = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)FGeometryCollectionSource.__PropertyOffset_SourceMaterial, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SourceMaterial.CopyAssign(value);
			}
		}

		// Token: 0x06012EB6 RID: 77494 RVA: 0x001BCEE9 File Offset: 0x001BB0E9
		public FGeometryCollectionSource()
		{
		}

		// Token: 0x06012EB7 RID: 77495 RVA: 0x001BCEF1 File Offset: 0x001BB0F1
		public FGeometryCollectionSource(FSoftObjectPath SourceGeometryObject, FTransform LocalTransform, TArray<UMaterialInterface> SourceMaterial)
		{
			this.SourceGeometryObject = SourceGeometryObject;
			this.LocalTransform = LocalTransform;
			this.SourceMaterial = SourceMaterial;
		}

		// Token: 0x06012EB8 RID: 77496 RVA: 0x001BCF0E File Offset: 0x001BB10E
		protected override IntPtr GetUStructPtr()
		{
			return FGeometryCollectionSource.StaticStruct();
		}

		// Token: 0x06012EB9 RID: 77497 RVA: 0x001BCF1A File Offset: 0x001BB11A
		[NullableContext(2)]
		public FGeometryCollectionSource(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012EBA RID: 77498 RVA: 0x001BCF24 File Offset: 0x001BB124
		public FGeometryCollectionSource(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012EBB RID: 77499 RVA: 0x001BCF2F File Offset: 0x001BB12F
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGeometryCollectionSource(Pointer, false, true);
		}

		// Token: 0x06012EBC RID: 77500 RVA: 0x001BCF39 File Offset: 0x001BB139
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGeometryCollectionSource(Pointer, MemoryOwner);
		}

		// Token: 0x0400A1B8 RID: 41400
		public const string __ObjectPath = "/Script/GeometryCollectionEngine.GeometryCollectionSource";

		// Token: 0x0400A1B9 RID: 41401
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400A1BA RID: 41402
		internal static int __PropertyOffset_SourceGeometryObject;

		// Token: 0x0400A1BB RID: 41403
		[Nullable(2)]
		private FSoftObjectPath _SourceGeometryObject;

		// Token: 0x0400A1BC RID: 41404
		internal static int __PropertyOffset_LocalTransform;

		// Token: 0x0400A1BD RID: 41405
		internal static int __PropertyOffset_SourceMaterial;

		// Token: 0x0400A1BE RID: 41406
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _SourceMaterial;
	}
}
