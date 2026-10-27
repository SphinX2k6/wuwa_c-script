using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000209 RID: 521
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.AkGeometryData")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FAkGeometryData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06001F1A RID: 7962 RVA: 0x0002DF5E File Offset: 0x0002C15E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAkGeometryData._ScriptStructPtr != 0) ? FAkGeometryData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AkAudio.AkGeometryData", ref FAkGeometryData._ScriptStructPtr);
		}

		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x06001F1B RID: 7963 RVA: 0x0002DF84 File Offset: 0x0002C184
		// (set) Token: 0x06001F1C RID: 7964 RVA: 0x0002DFC7 File Offset: 0x0002C1C7
		public TArray<FVector> Vertices
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._Vertices) == null)
				{
					result = (this._Vertices = new TArray<FVector>(base.NativePtr + (IntPtr)FAkGeometryData.__PropertyOffset_Vertices, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Vertices.CopyAssign(value);
			}
		}

		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x06001F1D RID: 7965 RVA: 0x0002DFD8 File Offset: 0x0002C1D8
		// (set) Token: 0x06001F1E RID: 7966 RVA: 0x0002E01B File Offset: 0x0002C21B
		public TArray<FAkAcousticSurface> Surfaces
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FAkAcousticSurface> result;
				if ((result = this._Surfaces) == null)
				{
					result = (this._Surfaces = new TArray<FAkAcousticSurface>(base.NativePtr + (IntPtr)FAkGeometryData.__PropertyOffset_Surfaces, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Surfaces.CopyAssign(value);
			}
		}

		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x06001F1F RID: 7967 RVA: 0x0002E02C File Offset: 0x0002C22C
		// (set) Token: 0x06001F20 RID: 7968 RVA: 0x0002E06F File Offset: 0x0002C26F
		public TArray<FAkTriangle> Triangles
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FAkTriangle> result;
				if ((result = this._Triangles) == null)
				{
					result = (this._Triangles = new TArray<FAkTriangle>(base.NativePtr + (IntPtr)FAkGeometryData.__PropertyOffset_Triangles, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Triangles.CopyAssign(value);
			}
		}

		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x06001F21 RID: 7969 RVA: 0x0002E080 File Offset: 0x0002C280
		// (set) Token: 0x06001F22 RID: 7970 RVA: 0x0002E0C3 File Offset: 0x0002C2C3
		public TArray<UPhysicalMaterial> ToOverrideAcousticTexture
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UPhysicalMaterial> result;
				if ((result = this._ToOverrideAcousticTexture) == null)
				{
					result = (this._ToOverrideAcousticTexture = new TArray<UPhysicalMaterial>(base.NativePtr + (IntPtr)FAkGeometryData.__PropertyOffset_ToOverrideAcousticTexture, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ToOverrideAcousticTexture.CopyAssign(value);
			}
		}

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x06001F23 RID: 7971 RVA: 0x0002E0D4 File Offset: 0x0002C2D4
		// (set) Token: 0x06001F24 RID: 7972 RVA: 0x0002E117 File Offset: 0x0002C317
		public TArray<UPhysicalMaterial> ToOverrideOcclusion
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UPhysicalMaterial> result;
				if ((result = this._ToOverrideOcclusion) == null)
				{
					result = (this._ToOverrideOcclusion = new TArray<UPhysicalMaterial>(base.NativePtr + (IntPtr)FAkGeometryData.__PropertyOffset_ToOverrideOcclusion, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ToOverrideOcclusion.CopyAssign(value);
			}
		}

		// Token: 0x06001F25 RID: 7973 RVA: 0x0002E125 File Offset: 0x0002C325
		public FAkGeometryData()
		{
		}

		// Token: 0x06001F26 RID: 7974 RVA: 0x0002E12D File Offset: 0x0002C32D
		public FAkGeometryData(TArray<FVector> Vertices, TArray<FAkAcousticSurface> Surfaces, TArray<FAkTriangle> Triangles, TArray<UPhysicalMaterial> ToOverrideAcousticTexture, TArray<UPhysicalMaterial> ToOverrideOcclusion)
		{
			this.Vertices = Vertices;
			this.Surfaces = Surfaces;
			this.Triangles = Triangles;
			this.ToOverrideAcousticTexture = ToOverrideAcousticTexture;
			this.ToOverrideOcclusion = ToOverrideOcclusion;
		}

		// Token: 0x06001F27 RID: 7975 RVA: 0x0002E15A File Offset: 0x0002C35A
		protected override IntPtr GetUStructPtr()
		{
			return FAkGeometryData.StaticStruct();
		}

		// Token: 0x06001F28 RID: 7976 RVA: 0x0002E166 File Offset: 0x0002C366
		[NullableContext(2)]
		public FAkGeometryData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001F29 RID: 7977 RVA: 0x0002E170 File Offset: 0x0002C370
		public FAkGeometryData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06001F2A RID: 7978 RVA: 0x0002E17B File Offset: 0x0002C37B
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAkGeometryData(Pointer, false, true);
		}

		// Token: 0x06001F2B RID: 7979 RVA: 0x0002E185 File Offset: 0x0002C385
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAkGeometryData(Pointer, MemoryOwner);
		}

		// Token: 0x04000A34 RID: 2612
		public const string __ObjectPath = "/Script/AkAudio.AkGeometryData";

		// Token: 0x04000A35 RID: 2613
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000A36 RID: 2614
		internal static int __PropertyOffset_Vertices;

		// Token: 0x04000A37 RID: 2615
		[Nullable(2)]
		private TArray<FVector> _Vertices;

		// Token: 0x04000A38 RID: 2616
		internal static int __PropertyOffset_Surfaces;

		// Token: 0x04000A39 RID: 2617
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAkAcousticSurface> _Surfaces;

		// Token: 0x04000A3A RID: 2618
		internal static int __PropertyOffset_Triangles;

		// Token: 0x04000A3B RID: 2619
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAkTriangle> _Triangles;

		// Token: 0x04000A3C RID: 2620
		internal static int __PropertyOffset_ToOverrideAcousticTexture;

		// Token: 0x04000A3D RID: 2621
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UPhysicalMaterial> _ToOverrideAcousticTexture;

		// Token: 0x04000A3E RID: 2622
		internal static int __PropertyOffset_ToOverrideOcclusion;

		// Token: 0x04000A3F RID: 2623
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UPhysicalMaterial> _ToOverrideOcclusion;
	}
}
