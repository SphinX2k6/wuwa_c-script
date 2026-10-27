using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200119B RID: 4507
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.StaticParameterSet")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FStaticParameterSet : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060109AD RID: 68013 RVA: 0x001862AB File Offset: 0x001844AB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FStaticParameterSet._ScriptStructPtr != 0) ? FStaticParameterSet._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.StaticParameterSet", ref FStaticParameterSet._ScriptStructPtr);
		}

		// Token: 0x170040D3 RID: 16595
		// (get) Token: 0x060109AE RID: 68014 RVA: 0x001862D0 File Offset: 0x001844D0
		// (set) Token: 0x060109AF RID: 68015 RVA: 0x00186313 File Offset: 0x00184513
		public TArray<FStaticSwitchParameter> StaticSwitchParameters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FStaticSwitchParameter> result;
				if ((result = this._StaticSwitchParameters) == null)
				{
					result = (this._StaticSwitchParameters = new TArray<FStaticSwitchParameter>(base.NativePtr + (IntPtr)FStaticParameterSet.__PropertyOffset_StaticSwitchParameters, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.StaticSwitchParameters.CopyAssign(value);
			}
		}

		// Token: 0x170040D4 RID: 16596
		// (get) Token: 0x060109B0 RID: 68016 RVA: 0x00186324 File Offset: 0x00184524
		// (set) Token: 0x060109B1 RID: 68017 RVA: 0x00186367 File Offset: 0x00184567
		public TArray<FStaticComponentMaskParameter> StaticComponentMaskParameters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FStaticComponentMaskParameter> result;
				if ((result = this._StaticComponentMaskParameters) == null)
				{
					result = (this._StaticComponentMaskParameters = new TArray<FStaticComponentMaskParameter>(base.NativePtr + (IntPtr)FStaticParameterSet.__PropertyOffset_StaticComponentMaskParameters, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.StaticComponentMaskParameters.CopyAssign(value);
			}
		}

		// Token: 0x170040D5 RID: 16597
		// (get) Token: 0x060109B2 RID: 68018 RVA: 0x00186378 File Offset: 0x00184578
		// (set) Token: 0x060109B3 RID: 68019 RVA: 0x001863BB File Offset: 0x001845BB
		public TArray<FStaticTerrainLayerWeightParameter> TerrainLayerWeightParameters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FStaticTerrainLayerWeightParameter> result;
				if ((result = this._TerrainLayerWeightParameters) == null)
				{
					result = (this._TerrainLayerWeightParameters = new TArray<FStaticTerrainLayerWeightParameter>(base.NativePtr + (IntPtr)FStaticParameterSet.__PropertyOffset_TerrainLayerWeightParameters, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TerrainLayerWeightParameters.CopyAssign(value);
			}
		}

		// Token: 0x170040D6 RID: 16598
		// (get) Token: 0x060109B4 RID: 68020 RVA: 0x001863CC File Offset: 0x001845CC
		// (set) Token: 0x060109B5 RID: 68021 RVA: 0x0018640F File Offset: 0x0018460F
		public TArray<FStaticMaterialLayersParameter> MaterialLayersParameters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FStaticMaterialLayersParameter> result;
				if ((result = this._MaterialLayersParameters) == null)
				{
					result = (this._MaterialLayersParameters = new TArray<FStaticMaterialLayersParameter>(base.NativePtr + (IntPtr)FStaticParameterSet.__PropertyOffset_MaterialLayersParameters, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MaterialLayersParameters.CopyAssign(value);
			}
		}

		// Token: 0x060109B6 RID: 68022 RVA: 0x0018641D File Offset: 0x0018461D
		public FStaticParameterSet()
		{
		}

		// Token: 0x060109B7 RID: 68023 RVA: 0x00186425 File Offset: 0x00184625
		public FStaticParameterSet(TArray<FStaticSwitchParameter> StaticSwitchParameters, TArray<FStaticComponentMaskParameter> StaticComponentMaskParameters, TArray<FStaticTerrainLayerWeightParameter> TerrainLayerWeightParameters, TArray<FStaticMaterialLayersParameter> MaterialLayersParameters)
		{
			this.StaticSwitchParameters = StaticSwitchParameters;
			this.StaticComponentMaskParameters = StaticComponentMaskParameters;
			this.TerrainLayerWeightParameters = TerrainLayerWeightParameters;
			this.MaterialLayersParameters = MaterialLayersParameters;
		}

		// Token: 0x060109B8 RID: 68024 RVA: 0x0018644A File Offset: 0x0018464A
		protected override IntPtr GetUStructPtr()
		{
			return FStaticParameterSet.StaticStruct();
		}

		// Token: 0x060109B9 RID: 68025 RVA: 0x00186456 File Offset: 0x00184656
		[NullableContext(2)]
		public FStaticParameterSet(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060109BA RID: 68026 RVA: 0x00186460 File Offset: 0x00184660
		public FStaticParameterSet(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060109BB RID: 68027 RVA: 0x0018646B File Offset: 0x0018466B
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FStaticParameterSet(Pointer, false, true);
		}

		// Token: 0x060109BC RID: 68028 RVA: 0x00186475 File Offset: 0x00184675
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FStaticParameterSet(Pointer, MemoryOwner);
		}

		// Token: 0x04008E1C RID: 36380
		public const string __ObjectPath = "/Script/Engine.StaticParameterSet";

		// Token: 0x04008E1D RID: 36381
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008E1E RID: 36382
		internal static int __PropertyOffset_StaticSwitchParameters;

		// Token: 0x04008E1F RID: 36383
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FStaticSwitchParameter> _StaticSwitchParameters;

		// Token: 0x04008E20 RID: 36384
		internal static int __PropertyOffset_StaticComponentMaskParameters;

		// Token: 0x04008E21 RID: 36385
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FStaticComponentMaskParameter> _StaticComponentMaskParameters;

		// Token: 0x04008E22 RID: 36386
		internal static int __PropertyOffset_TerrainLayerWeightParameters;

		// Token: 0x04008E23 RID: 36387
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FStaticTerrainLayerWeightParameter> _TerrainLayerWeightParameters;

		// Token: 0x04008E24 RID: 36388
		internal static int __PropertyOffset_MaterialLayersParameters;

		// Token: 0x04008E25 RID: 36389
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FStaticMaterialLayersParameter> _MaterialLayersParameters;
	}
}
