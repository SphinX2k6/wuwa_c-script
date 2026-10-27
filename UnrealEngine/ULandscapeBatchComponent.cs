using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F6B RID: 8043
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Landscape.LandscapeBatchComponent")]
	[UnrealStructLayout(1776, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1776)]
	public class ULandscapeBatchComponent : UPrimitiveComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E800 RID: 124928 RVA: 0x002D55AA File Offset: 0x002D37AA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULandscapeBatchComponent._ClassPtr;
		}

		// Token: 0x0601E801 RID: 124929 RVA: 0x002D55B8 File Offset: 0x002D37B8
		public ULandscapeBatchComponent() : this(BuiltinUtils.AllocNativeUObject(ULandscapeBatchComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E802 RID: 124930 RVA: 0x002D55E0 File Offset: 0x002D37E0
		public ULandscapeBatchComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULandscapeBatchComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007946 RID: 31046
		// (get) Token: 0x0601E803 RID: 124931 RVA: 0x002D5614 File Offset: 0x002D3814
		// (set) Token: 0x0601E804 RID: 124932 RVA: 0x002D564D File Offset: 0x002D384D
		public TArray<UMaterialInterface> MaterialInterfaces
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInterface> result;
				if ((result = this._MaterialInterfaces) == null)
				{
					result = (this._MaterialInterfaces = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)ULandscapeBatchComponent.__PropertyOffset_MaterialInterfaces, this));
				}
				return result;
			}
			set
			{
				this.MaterialInterfaces.CopyAssign(value);
			}
		}

		// Token: 0x17007947 RID: 31047
		// (get) Token: 0x0601E805 RID: 124933 RVA: 0x002D565C File Offset: 0x002D385C
		// (set) Token: 0x0601E806 RID: 124934 RVA: 0x002D5695 File Offset: 0x002D3895
		public TArray<ULandscapeComponent> OrdedComponents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<ULandscapeComponent> result;
				if ((result = this._OrdedComponents) == null)
				{
					result = (this._OrdedComponents = new TArray<ULandscapeComponent>(base.NativePtr + (IntPtr)ULandscapeBatchComponent.__PropertyOffset_OrdedComponents, this));
				}
				return result;
			}
			set
			{
				this.OrdedComponents.CopyAssign(value);
			}
		}

		// Token: 0x17007948 RID: 31048
		// (get) Token: 0x0601E807 RID: 124935 RVA: 0x002D56A4 File Offset: 0x002D38A4
		// (set) Token: 0x0601E808 RID: 124936 RVA: 0x002D56DD File Offset: 0x002D38DD
		public TArray<UTexture2DArray> WeightmapArrays
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UTexture2DArray> result;
				if ((result = this._WeightmapArrays) == null)
				{
					result = (this._WeightmapArrays = new TArray<UTexture2DArray>(base.NativePtr + (IntPtr)ULandscapeBatchComponent.__PropertyOffset_WeightmapArrays, this));
				}
				return result;
			}
			set
			{
				this.WeightmapArrays.CopyAssign(value);
			}
		}

		// Token: 0x17007949 RID: 31049
		// (get) Token: 0x0601E809 RID: 124937 RVA: 0x002D56EC File Offset: 0x002D38EC
		// (set) Token: 0x0601E80A RID: 124938 RVA: 0x002D5725 File Offset: 0x002D3925
		public TArray<uint> ComponentVertexStarts
		{
			get
			{
				base.FastCheckIsValid();
				TArray<uint> result;
				if ((result = this._ComponentVertexStarts) == null)
				{
					result = (this._ComponentVertexStarts = new TArray<uint>(base.NativePtr + (IntPtr)ULandscapeBatchComponent.__PropertyOffset_ComponentVertexStarts, this));
				}
				return result;
			}
			set
			{
				this.ComponentVertexStarts.CopyAssign(value);
			}
		}

		// Token: 0x1700794A RID: 31050
		// (get) Token: 0x0601E80B RID: 124939 RVA: 0x002D5733 File Offset: 0x002D3933
		// (set) Token: 0x0601E80C RID: 124940 RVA: 0x002D5743 File Offset: 0x002D3943
		public unsafe bool IndirectMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULandscapeBatchComponent.__PropertyOffset_IndirectMode) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULandscapeBatchComponent.__PropertyOffset_IndirectMode) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700794B RID: 31051
		// (get) Token: 0x0601E80D RID: 124941 RVA: 0x002D5754 File Offset: 0x002D3954
		// (set) Token: 0x0601E80E RID: 124942 RVA: 0x002D578D File Offset: 0x002D398D
		public TArray<byte> CompressedGeometryData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._CompressedGeometryData) == null)
				{
					result = (this._CompressedGeometryData = new TArray<byte>(base.NativePtr + (IntPtr)ULandscapeBatchComponent.__PropertyOffset_CompressedGeometryData, this));
				}
				return result;
			}
			set
			{
				this.CompressedGeometryData.CopyAssign(value);
			}
		}

		// Token: 0x0601E80F RID: 124943 RVA: 0x002D579B File Offset: 0x002D399B
		static ULandscapeBatchComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Landscape.LandscapeBatchComponent");
		}

		// Token: 0x0601E810 RID: 124944 RVA: 0x002D57A9 File Offset: 0x002D39A9
		protected ULandscapeBatchComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040107B9 RID: 67513
		public new const string __ObjectPath = "/Script/Landscape.LandscapeBatchComponent";

		// Token: 0x040107BA RID: 67514
		private static IntPtr _ClassPtr;

		// Token: 0x040107BB RID: 67515
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040107BC RID: 67516
		internal static int __PropertyOffset_MaterialInterfaces;

		// Token: 0x040107BD RID: 67517
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _MaterialInterfaces;

		// Token: 0x040107BE RID: 67518
		internal static int __PropertyOffset_OrdedComponents;

		// Token: 0x040107BF RID: 67519
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ULandscapeComponent> _OrdedComponents;

		// Token: 0x040107C0 RID: 67520
		internal static int __PropertyOffset_WeightmapArrays;

		// Token: 0x040107C1 RID: 67521
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UTexture2DArray> _WeightmapArrays;

		// Token: 0x040107C2 RID: 67522
		internal static int __PropertyOffset_ComponentVertexStarts;

		// Token: 0x040107C3 RID: 67523
		[Nullable(2)]
		private TArray<uint> _ComponentVertexStarts;

		// Token: 0x040107C4 RID: 67524
		internal static int __PropertyOffset_IndirectMode;

		// Token: 0x040107C5 RID: 67525
		internal static int __PropertyOffset_CompressedGeometryData;

		// Token: 0x040107C6 RID: 67526
		[Nullable(2)]
		private TArray<byte> _CompressedGeometryData;
	}
}
