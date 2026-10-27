using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000E8F RID: 3727
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialLayersFunctions")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 160)]
	public class FMaterialLayersFunctions : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600C887 RID: 51335 RVA: 0x00123E5D File Offset: 0x0012205D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMaterialLayersFunctions._ScriptStructPtr != 0) ? FMaterialLayersFunctions._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.MaterialLayersFunctions", ref FMaterialLayersFunctions._ScriptStructPtr);
		}

		// Token: 0x17002EE6 RID: 12006
		// (get) Token: 0x0600C888 RID: 51336 RVA: 0x00123E84 File Offset: 0x00122084
		// (set) Token: 0x0600C889 RID: 51337 RVA: 0x00123EC7 File Offset: 0x001220C7
		public TArray<UMaterialFunctionInterface> Layers
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialFunctionInterface> result;
				if ((result = this._Layers) == null)
				{
					result = (this._Layers = new TArray<UMaterialFunctionInterface>(base.NativePtr + (IntPtr)FMaterialLayersFunctions.__PropertyOffset_Layers, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Layers.CopyAssign(value);
			}
		}

		// Token: 0x17002EE7 RID: 12007
		// (get) Token: 0x0600C88A RID: 51338 RVA: 0x00123ED8 File Offset: 0x001220D8
		// (set) Token: 0x0600C88B RID: 51339 RVA: 0x00123F1B File Offset: 0x0012211B
		public TArray<UMaterialFunctionInterface> Blends
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialFunctionInterface> result;
				if ((result = this._Blends) == null)
				{
					result = (this._Blends = new TArray<UMaterialFunctionInterface>(base.NativePtr + (IntPtr)FMaterialLayersFunctions.__PropertyOffset_Blends, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Blends.CopyAssign(value);
			}
		}

		// Token: 0x17002EE8 RID: 12008
		// (get) Token: 0x0600C88C RID: 51340 RVA: 0x00123F2C File Offset: 0x0012212C
		// (set) Token: 0x0600C88D RID: 51341 RVA: 0x00123F6F File Offset: 0x0012216F
		public TArray<bool> LayerStates
		{
			get
			{
				base.FastCheckIsValid();
				TArray<bool> result;
				if ((result = this._LayerStates) == null)
				{
					result = (this._LayerStates = new TArray<bool>(base.NativePtr + (IntPtr)FMaterialLayersFunctions.__PropertyOffset_LayerStates, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.LayerStates.CopyAssign(value);
			}
		}

		// Token: 0x17002EE9 RID: 12009
		// (get) Token: 0x0600C88E RID: 51342 RVA: 0x00123F7D File Offset: 0x0012217D
		// (set) Token: 0x0600C88F RID: 51343 RVA: 0x00123F91 File Offset: 0x00122191
		public unsafe string KeyString_DEPRECATED
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FMaterialLayersFunctions.__PropertyOffset_KeyString_DEPRECATED)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FMaterialLayersFunctions.__PropertyOffset_KeyString_DEPRECATED)), value);
			}
		}

		// Token: 0x0600C890 RID: 51344 RVA: 0x00123FA6 File Offset: 0x001221A6
		public FMaterialLayersFunctions()
		{
		}

		// Token: 0x0600C891 RID: 51345 RVA: 0x00123FAE File Offset: 0x001221AE
		public FMaterialLayersFunctions(TArray<UMaterialFunctionInterface> Layers, TArray<UMaterialFunctionInterface> Blends, TArray<bool> LayerStates, TArray<FText> LayerNames, TArray<bool> RestrictToLayerRelatives, TArray<bool> RestrictToBlendRelatives, TArray<FGuid> LayerGuids, TArray<EMaterialLayerLinkState> LayerLinkStates, TArray<FGuid> DeletedParentLayerGuids, string KeyString_DEPRECATED)
		{
			this.Layers = Layers;
			this.Blends = Blends;
			this.LayerStates = LayerStates;
			this.KeyString_DEPRECATED = KeyString_DEPRECATED;
		}

		// Token: 0x0600C892 RID: 51346 RVA: 0x00123FD3 File Offset: 0x001221D3
		protected override IntPtr GetUStructPtr()
		{
			return FMaterialLayersFunctions.StaticStruct();
		}

		// Token: 0x0600C893 RID: 51347 RVA: 0x00123FDF File Offset: 0x001221DF
		[NullableContext(2)]
		public FMaterialLayersFunctions(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600C894 RID: 51348 RVA: 0x00123FE9 File Offset: 0x001221E9
		public FMaterialLayersFunctions(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600C895 RID: 51349 RVA: 0x00123FF4 File Offset: 0x001221F4
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMaterialLayersFunctions(Pointer, false, true);
		}

		// Token: 0x0600C896 RID: 51350 RVA: 0x00123FFE File Offset: 0x001221FE
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMaterialLayersFunctions(Pointer, MemoryOwner);
		}

		// Token: 0x04006BE6 RID: 27622
		public const string __ObjectPath = "/Script/Engine.MaterialLayersFunctions";

		// Token: 0x04006BE7 RID: 27623
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04006BE8 RID: 27624
		internal static int __PropertyOffset_Layers;

		// Token: 0x04006BE9 RID: 27625
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialFunctionInterface> _Layers;

		// Token: 0x04006BEA RID: 27626
		internal static int __PropertyOffset_Blends;

		// Token: 0x04006BEB RID: 27627
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialFunctionInterface> _Blends;

		// Token: 0x04006BEC RID: 27628
		internal static int __PropertyOffset_LayerStates;

		// Token: 0x04006BED RID: 27629
		[Nullable(2)]
		private TArray<bool> _LayerStates;

		// Token: 0x04006BEE RID: 27630
		internal static int __PropertyOffset_KeyString_DEPRECATED;
	}
}
