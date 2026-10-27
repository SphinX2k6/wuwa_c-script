using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001FA4 RID: 8100
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Landscape.WeightmapData")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FWeightmapData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601EBC9 RID: 125897 RVA: 0x002DB282 File Offset: 0x002D9482
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWeightmapData._ScriptStructPtr != 0) ? FWeightmapData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Landscape.WeightmapData", ref FWeightmapData._ScriptStructPtr);
		}

		// Token: 0x17007A71 RID: 31345
		// (get) Token: 0x0601EBCA RID: 125898 RVA: 0x002DB2A8 File Offset: 0x002D94A8
		// (set) Token: 0x0601EBCB RID: 125899 RVA: 0x002DB2EB File Offset: 0x002D94EB
		public TArray<UTexture2D> Textures
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UTexture2D> result;
				if ((result = this._Textures) == null)
				{
					result = (this._Textures = new TArray<UTexture2D>(base.NativePtr + (IntPtr)FWeightmapData.__PropertyOffset_Textures, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Textures.CopyAssign(value);
			}
		}

		// Token: 0x17007A72 RID: 31346
		// (get) Token: 0x0601EBCC RID: 125900 RVA: 0x002DB2FC File Offset: 0x002D94FC
		// (set) Token: 0x0601EBCD RID: 125901 RVA: 0x002DB33F File Offset: 0x002D953F
		public TArray<FWeightmapLayerAllocationInfo> LayerAllocations
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FWeightmapLayerAllocationInfo> result;
				if ((result = this._LayerAllocations) == null)
				{
					result = (this._LayerAllocations = new TArray<FWeightmapLayerAllocationInfo>(base.NativePtr + (IntPtr)FWeightmapData.__PropertyOffset_LayerAllocations, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.LayerAllocations.CopyAssign(value);
			}
		}

		// Token: 0x17007A73 RID: 31347
		// (get) Token: 0x0601EBCE RID: 125902 RVA: 0x002DB350 File Offset: 0x002D9550
		// (set) Token: 0x0601EBCF RID: 125903 RVA: 0x002DB393 File Offset: 0x002D9593
		public TArray<ULandscapeWeightmapUsage> TextureUsages
		{
			get
			{
				base.FastCheckIsValid();
				TArray<ULandscapeWeightmapUsage> result;
				if ((result = this._TextureUsages) == null)
				{
					result = (this._TextureUsages = new TArray<ULandscapeWeightmapUsage>(base.NativePtr + (IntPtr)FWeightmapData.__PropertyOffset_TextureUsages, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TextureUsages.CopyAssign(value);
			}
		}

		// Token: 0x0601EBD0 RID: 125904 RVA: 0x002DB3A1 File Offset: 0x002D95A1
		public FWeightmapData()
		{
		}

		// Token: 0x0601EBD1 RID: 125905 RVA: 0x002DB3A9 File Offset: 0x002D95A9
		public FWeightmapData(TArray<UTexture2D> Textures, TArray<FWeightmapLayerAllocationInfo> LayerAllocations, TArray<ULandscapeWeightmapUsage> TextureUsages)
		{
			this.Textures = Textures;
			this.LayerAllocations = LayerAllocations;
			this.TextureUsages = TextureUsages;
		}

		// Token: 0x0601EBD2 RID: 125906 RVA: 0x002DB3C6 File Offset: 0x002D95C6
		protected override IntPtr GetUStructPtr()
		{
			return FWeightmapData.StaticStruct();
		}

		// Token: 0x0601EBD3 RID: 125907 RVA: 0x002DB3D2 File Offset: 0x002D95D2
		[NullableContext(2)]
		public FWeightmapData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601EBD4 RID: 125908 RVA: 0x002DB3DC File Offset: 0x002D95DC
		public FWeightmapData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601EBD5 RID: 125909 RVA: 0x002DB3E7 File Offset: 0x002D95E7
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWeightmapData(Pointer, false, true);
		}

		// Token: 0x0601EBD6 RID: 125910 RVA: 0x002DB3F1 File Offset: 0x002D95F1
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWeightmapData(Pointer, MemoryOwner);
		}

		// Token: 0x040109EC RID: 68076
		public const string __ObjectPath = "/Script/Landscape.WeightmapData";

		// Token: 0x040109ED RID: 68077
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040109EE RID: 68078
		internal static int __PropertyOffset_Textures;

		// Token: 0x040109EF RID: 68079
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UTexture2D> _Textures;

		// Token: 0x040109F0 RID: 68080
		internal static int __PropertyOffset_LayerAllocations;

		// Token: 0x040109F1 RID: 68081
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FWeightmapLayerAllocationInfo> _LayerAllocations;

		// Token: 0x040109F2 RID: 68082
		internal static int __PropertyOffset_TextureUsages;

		// Token: 0x040109F3 RID: 68083
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ULandscapeWeightmapUsage> _TextureUsages;
	}
}
