using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200220D RID: 8717
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LiveLinkInterface.LiveLinkMeshFrameData")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 224)]
	public class FLiveLinkMeshFrameData : FLiveLinkBaseFrameData, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602134E RID: 136014 RVA: 0x0030F486 File Offset: 0x0030D686
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLiveLinkMeshFrameData._ScriptStructPtr != 0) ? FLiveLinkMeshFrameData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LiveLinkInterface.LiveLinkMeshFrameData", ref FLiveLinkMeshFrameData._ScriptStructPtr);
		}

		// Token: 0x1700819E RID: 33182
		// (get) Token: 0x0602134F RID: 136015 RVA: 0x0030F4AC File Offset: 0x0030D6AC
		// (set) Token: 0x06021350 RID: 136016 RVA: 0x0030F4EF File Offset: 0x0030D6EF
		public TArray<FLiveLinkVertex> ModifiedVertices
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FLiveLinkVertex> result;
				if ((result = this._ModifiedVertices) == null)
				{
					result = (this._ModifiedVertices = new TArray<FLiveLinkVertex>(base.NativePtr + (IntPtr)FLiveLinkMeshFrameData.__PropertyOffset_ModifiedVertices, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ModifiedVertices.CopyAssign(value);
			}
		}

		// Token: 0x1700819F RID: 33183
		// (get) Token: 0x06021351 RID: 136017 RVA: 0x0030F500 File Offset: 0x0030D700
		// (set) Token: 0x06021352 RID: 136018 RVA: 0x0030F543 File Offset: 0x0030D743
		public TArray<FLiveLinkVertexPosition> ModifiedVertexPositions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FLiveLinkVertexPosition> result;
				if ((result = this._ModifiedVertexPositions) == null)
				{
					result = (this._ModifiedVertexPositions = new TArray<FLiveLinkVertexPosition>(base.NativePtr + (IntPtr)FLiveLinkMeshFrameData.__PropertyOffset_ModifiedVertexPositions, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ModifiedVertexPositions.CopyAssign(value);
			}
		}

		// Token: 0x170081A0 RID: 33184
		// (get) Token: 0x06021353 RID: 136019 RVA: 0x0030F554 File Offset: 0x0030D754
		// (set) Token: 0x06021354 RID: 136020 RVA: 0x0030F597 File Offset: 0x0030D797
		public TArray<FLiveLinkVertexNormal> ModifiedVertexNormals
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FLiveLinkVertexNormal> result;
				if ((result = this._ModifiedVertexNormals) == null)
				{
					result = (this._ModifiedVertexNormals = new TArray<FLiveLinkVertexNormal>(base.NativePtr + (IntPtr)FLiveLinkMeshFrameData.__PropertyOffset_ModifiedVertexNormals, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ModifiedVertexNormals.CopyAssign(value);
			}
		}

		// Token: 0x170081A1 RID: 33185
		// (get) Token: 0x06021355 RID: 136021 RVA: 0x0030F5A8 File Offset: 0x0030D7A8
		// (set) Token: 0x06021356 RID: 136022 RVA: 0x0030F5EB File Offset: 0x0030D7EB
		public TArray<FLiveLinkVertexUV> ModifiedVertexUVs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FLiveLinkVertexUV> result;
				if ((result = this._ModifiedVertexUVs) == null)
				{
					result = (this._ModifiedVertexUVs = new TArray<FLiveLinkVertexUV>(base.NativePtr + (IntPtr)FLiveLinkMeshFrameData.__PropertyOffset_ModifiedVertexUVs, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ModifiedVertexUVs.CopyAssign(value);
			}
		}

		// Token: 0x06021357 RID: 136023 RVA: 0x0030F5F9 File Offset: 0x0030D7F9
		public FLiveLinkMeshFrameData()
		{
		}

		// Token: 0x06021358 RID: 136024 RVA: 0x0030F601 File Offset: 0x0030D801
		public FLiveLinkMeshFrameData(TArray<FLiveLinkVertex> ModifiedVertices, TArray<FLiveLinkVertexPosition> ModifiedVertexPositions, TArray<FLiveLinkVertexNormal> ModifiedVertexNormals, TArray<FLiveLinkVertexUV> ModifiedVertexUVs, FLiveLinkWorldTime WorldTime, FLiveLinkMetaData MetaData, TArray<float> PropertyValues)
		{
			this.ModifiedVertices = ModifiedVertices;
			this.ModifiedVertexPositions = ModifiedVertexPositions;
			this.ModifiedVertexNormals = ModifiedVertexNormals;
			this.ModifiedVertexUVs = ModifiedVertexUVs;
			base.WorldTime = WorldTime;
			base.MetaData = MetaData;
			base.PropertyValues = PropertyValues;
		}

		// Token: 0x06021359 RID: 136025 RVA: 0x0030F63E File Offset: 0x0030D83E
		protected override IntPtr GetUStructPtr()
		{
			return FLiveLinkMeshFrameData.StaticStruct();
		}

		// Token: 0x0602135A RID: 136026 RVA: 0x0030F64A File Offset: 0x0030D84A
		[NullableContext(2)]
		public FLiveLinkMeshFrameData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602135B RID: 136027 RVA: 0x0030F654 File Offset: 0x0030D854
		public FLiveLinkMeshFrameData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602135C RID: 136028 RVA: 0x0030F65F File Offset: 0x0030D85F
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLiveLinkMeshFrameData(Pointer, false, true);
		}

		// Token: 0x0602135D RID: 136029 RVA: 0x0030F669 File Offset: 0x0030D869
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLiveLinkMeshFrameData(Pointer, MemoryOwner);
		}

		// Token: 0x04011B6E RID: 72558
		public new const string __ObjectPath = "/Script/LiveLinkInterface.LiveLinkMeshFrameData";

		// Token: 0x04011B6F RID: 72559
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011B70 RID: 72560
		internal static int __PropertyOffset_ModifiedVertices;

		// Token: 0x04011B71 RID: 72561
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FLiveLinkVertex> _ModifiedVertices;

		// Token: 0x04011B72 RID: 72562
		internal static int __PropertyOffset_ModifiedVertexPositions;

		// Token: 0x04011B73 RID: 72563
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FLiveLinkVertexPosition> _ModifiedVertexPositions;

		// Token: 0x04011B74 RID: 72564
		internal static int __PropertyOffset_ModifiedVertexNormals;

		// Token: 0x04011B75 RID: 72565
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FLiveLinkVertexNormal> _ModifiedVertexNormals;

		// Token: 0x04011B76 RID: 72566
		internal static int __PropertyOffset_ModifiedVertexUVs;

		// Token: 0x04011B77 RID: 72567
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FLiveLinkVertexUV> _ModifiedVertexUVs;
	}
}
