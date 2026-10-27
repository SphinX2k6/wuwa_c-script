using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000CDD RID: 3293
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.Kuro2DMapGenerateMatMapDetail")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FKuro2DMapGenerateMatMapDetail : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600AE95 RID: 44693 RVA: 0x000F7A05 File Offset: 0x000F5C05
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuro2DMapGenerateMatMapDetail._ScriptStructPtr != 0) ? FKuro2DMapGenerateMatMapDetail._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.Kuro2DMapGenerateMatMapDetail", ref FKuro2DMapGenerateMatMapDetail._ScriptStructPtr);
		}

		// Token: 0x17002770 RID: 10096
		// (get) Token: 0x0600AE96 RID: 44694 RVA: 0x000F7A2C File Offset: 0x000F5C2C
		// (set) Token: 0x0600AE97 RID: 44695 RVA: 0x000F7A6F File Offset: 0x000F5C6F
		public TArray<string> Generate2DMapLandMaterial
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._Generate2DMapLandMaterial) == null)
				{
					result = (this._Generate2DMapLandMaterial = new TArray<string>(base.NativePtr + (IntPtr)FKuro2DMapGenerateMatMapDetail.__PropertyOffset_Generate2DMapLandMaterial, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Generate2DMapLandMaterial.CopyAssign(value);
			}
		}

		// Token: 0x17002771 RID: 10097
		// (get) Token: 0x0600AE98 RID: 44696 RVA: 0x000F7A80 File Offset: 0x000F5C80
		// (set) Token: 0x0600AE99 RID: 44697 RVA: 0x000F7AC3 File Offset: 0x000F5CC3
		public TArray<string> Generate2DMapBuildingMaterial
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._Generate2DMapBuildingMaterial) == null)
				{
					result = (this._Generate2DMapBuildingMaterial = new TArray<string>(base.NativePtr + (IntPtr)FKuro2DMapGenerateMatMapDetail.__PropertyOffset_Generate2DMapBuildingMaterial, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Generate2DMapBuildingMaterial.CopyAssign(value);
			}
		}

		// Token: 0x17002772 RID: 10098
		// (get) Token: 0x0600AE9A RID: 44698 RVA: 0x000F7AD4 File Offset: 0x000F5CD4
		// (set) Token: 0x0600AE9B RID: 44699 RVA: 0x000F7B17 File Offset: 0x000F5D17
		public TArray<string> Generate2DMapWaterMaterial
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._Generate2DMapWaterMaterial) == null)
				{
					result = (this._Generate2DMapWaterMaterial = new TArray<string>(base.NativePtr + (IntPtr)FKuro2DMapGenerateMatMapDetail.__PropertyOffset_Generate2DMapWaterMaterial, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Generate2DMapWaterMaterial.CopyAssign(value);
			}
		}

		// Token: 0x17002773 RID: 10099
		// (get) Token: 0x0600AE9C RID: 44700 RVA: 0x000F7B28 File Offset: 0x000F5D28
		// (set) Token: 0x0600AE9D RID: 44701 RVA: 0x000F7B6B File Offset: 0x000F5D6B
		public TArray<string> Generate2DMapTreeMaterial
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._Generate2DMapTreeMaterial) == null)
				{
					result = (this._Generate2DMapTreeMaterial = new TArray<string>(base.NativePtr + (IntPtr)FKuro2DMapGenerateMatMapDetail.__PropertyOffset_Generate2DMapTreeMaterial, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Generate2DMapTreeMaterial.CopyAssign(value);
			}
		}

		// Token: 0x17002774 RID: 10100
		// (get) Token: 0x0600AE9E RID: 44702 RVA: 0x000F7B7C File Offset: 0x000F5D7C
		// (set) Token: 0x0600AE9F RID: 44703 RVA: 0x000F7BBF File Offset: 0x000F5DBF
		public TArray<string> Generate2DMapSpecil01Material
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._Generate2DMapSpecil01Material) == null)
				{
					result = (this._Generate2DMapSpecil01Material = new TArray<string>(base.NativePtr + (IntPtr)FKuro2DMapGenerateMatMapDetail.__PropertyOffset_Generate2DMapSpecil01Material, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Generate2DMapSpecil01Material.CopyAssign(value);
			}
		}

		// Token: 0x17002775 RID: 10101
		// (get) Token: 0x0600AEA0 RID: 44704 RVA: 0x000F7BD0 File Offset: 0x000F5DD0
		// (set) Token: 0x0600AEA1 RID: 44705 RVA: 0x000F7C13 File Offset: 0x000F5E13
		public TArray<string> Generate2DMapSpecil02Material
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._Generate2DMapSpecil02Material) == null)
				{
					result = (this._Generate2DMapSpecil02Material = new TArray<string>(base.NativePtr + (IntPtr)FKuro2DMapGenerateMatMapDetail.__PropertyOffset_Generate2DMapSpecil02Material, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Generate2DMapSpecil02Material.CopyAssign(value);
			}
		}

		// Token: 0x0600AEA2 RID: 44706 RVA: 0x000F7C21 File Offset: 0x000F5E21
		public FKuro2DMapGenerateMatMapDetail()
		{
		}

		// Token: 0x0600AEA3 RID: 44707 RVA: 0x000F7C29 File Offset: 0x000F5E29
		public FKuro2DMapGenerateMatMapDetail(TArray<string> Generate2DMapLandMaterial, TArray<string> Generate2DMapBuildingMaterial, TArray<string> Generate2DMapWaterMaterial, TArray<string> Generate2DMapTreeMaterial, TArray<string> Generate2DMapSpecil01Material, TArray<string> Generate2DMapSpecil02Material)
		{
			this.Generate2DMapLandMaterial = Generate2DMapLandMaterial;
			this.Generate2DMapBuildingMaterial = Generate2DMapBuildingMaterial;
			this.Generate2DMapWaterMaterial = Generate2DMapWaterMaterial;
			this.Generate2DMapTreeMaterial = Generate2DMapTreeMaterial;
			this.Generate2DMapSpecil01Material = Generate2DMapSpecil01Material;
			this.Generate2DMapSpecil02Material = Generate2DMapSpecil02Material;
		}

		// Token: 0x0600AEA4 RID: 44708 RVA: 0x000F7C5E File Offset: 0x000F5E5E
		protected override IntPtr GetUStructPtr()
		{
			return FKuro2DMapGenerateMatMapDetail.StaticStruct();
		}

		// Token: 0x0600AEA5 RID: 44709 RVA: 0x000F7C6A File Offset: 0x000F5E6A
		[NullableContext(2)]
		public FKuro2DMapGenerateMatMapDetail(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600AEA6 RID: 44710 RVA: 0x000F7C74 File Offset: 0x000F5E74
		public FKuro2DMapGenerateMatMapDetail(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600AEA7 RID: 44711 RVA: 0x000F7C7F File Offset: 0x000F5E7F
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuro2DMapGenerateMatMapDetail(Pointer, false, true);
		}

		// Token: 0x0600AEA8 RID: 44712 RVA: 0x000F7C89 File Offset: 0x000F5E89
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuro2DMapGenerateMatMapDetail(Pointer, MemoryOwner);
		}

		// Token: 0x04005B76 RID: 23414
		public const string __ObjectPath = "/Script/Engine.Kuro2DMapGenerateMatMapDetail";

		// Token: 0x04005B77 RID: 23415
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005B78 RID: 23416
		internal static int __PropertyOffset_Generate2DMapLandMaterial;

		// Token: 0x04005B79 RID: 23417
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _Generate2DMapLandMaterial;

		// Token: 0x04005B7A RID: 23418
		internal static int __PropertyOffset_Generate2DMapBuildingMaterial;

		// Token: 0x04005B7B RID: 23419
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _Generate2DMapBuildingMaterial;

		// Token: 0x04005B7C RID: 23420
		internal static int __PropertyOffset_Generate2DMapWaterMaterial;

		// Token: 0x04005B7D RID: 23421
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _Generate2DMapWaterMaterial;

		// Token: 0x04005B7E RID: 23422
		internal static int __PropertyOffset_Generate2DMapTreeMaterial;

		// Token: 0x04005B7F RID: 23423
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _Generate2DMapTreeMaterial;

		// Token: 0x04005B80 RID: 23424
		internal static int __PropertyOffset_Generate2DMapSpecil01Material;

		// Token: 0x04005B81 RID: 23425
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _Generate2DMapSpecil01Material;

		// Token: 0x04005B82 RID: 23426
		internal static int __PropertyOffset_Generate2DMapSpecil02Material;

		// Token: 0x04005B83 RID: 23427
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _Generate2DMapSpecil02Material;
	}
}
