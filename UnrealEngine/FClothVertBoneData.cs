using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000494 RID: 1172
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ClothingSystemRuntimeInterface.ClothVertBoneData")]
	[UnrealStructLayout(76, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 76)]
	public class FClothVertBoneData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06003EED RID: 16109 RVA: 0x0005E899 File Offset: 0x0005CA99
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FClothVertBoneData._ScriptStructPtr != 0) ? FClothVertBoneData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ClothingSystemRuntimeInterface.ClothVertBoneData", ref FClothVertBoneData._ScriptStructPtr);
		}

		// Token: 0x17000F53 RID: 3923
		// (get) Token: 0x06003EEE RID: 16110 RVA: 0x0005E8BD File Offset: 0x0005CABD
		// (set) Token: 0x06003EEF RID: 16111 RVA: 0x0005E8CD File Offset: 0x0005CACD
		public unsafe int NumInfluences
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClothVertBoneData.__PropertyOffset_NumInfluences);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothVertBoneData.__PropertyOffset_NumInfluences) = value;
			}
		}

		// Token: 0x17000F54 RID: 3924
		// (get) Token: 0x06003EF0 RID: 16112 RVA: 0x0005E8E0 File Offset: 0x0005CAE0
		// (set) Token: 0x06003EF1 RID: 16113 RVA: 0x0005E925 File Offset: 0x0005CB25
		public TFixedArray<ushort> BoneIndices
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<ushort> result;
				if ((result = this._BoneIndices) == null)
				{
					result = (this._BoneIndices = new TFixedArray<ushort>(base.NativePtr + (IntPtr)FClothVertBoneData.__PropertyOffset_BoneIndices, 12, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BoneIndices.CopyAssign(value);
			}
		}

		// Token: 0x17000F55 RID: 3925
		// (get) Token: 0x06003EF2 RID: 16114 RVA: 0x0005E934 File Offset: 0x0005CB34
		// (set) Token: 0x06003EF3 RID: 16115 RVA: 0x0005E979 File Offset: 0x0005CB79
		public TFixedArray<float> BoneWeights
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<float> result;
				if ((result = this._BoneWeights) == null)
				{
					result = (this._BoneWeights = new TFixedArray<float>(base.NativePtr + (IntPtr)FClothVertBoneData.__PropertyOffset_BoneWeights, 12, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BoneWeights.CopyAssign(value);
			}
		}

		// Token: 0x06003EF4 RID: 16116 RVA: 0x0005E987 File Offset: 0x0005CB87
		public FClothVertBoneData()
		{
		}

		// Token: 0x06003EF5 RID: 16117 RVA: 0x0005E98F File Offset: 0x0005CB8F
		public FClothVertBoneData(int NumInfluences, TFixedArray<ushort> BoneIndices, TFixedArray<float> BoneWeights)
		{
			this.NumInfluences = NumInfluences;
			this.BoneIndices = BoneIndices;
			this.BoneWeights = BoneWeights;
		}

		// Token: 0x06003EF6 RID: 16118 RVA: 0x0005E9AC File Offset: 0x0005CBAC
		protected override IntPtr GetUStructPtr()
		{
			return FClothVertBoneData.StaticStruct();
		}

		// Token: 0x06003EF7 RID: 16119 RVA: 0x0005E9B8 File Offset: 0x0005CBB8
		[NullableContext(2)]
		public FClothVertBoneData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003EF8 RID: 16120 RVA: 0x0005E9C2 File Offset: 0x0005CBC2
		public FClothVertBoneData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003EF9 RID: 16121 RVA: 0x0005E9CD File Offset: 0x0005CBCD
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FClothVertBoneData(Pointer, false, true);
		}

		// Token: 0x06003EFA RID: 16122 RVA: 0x0005E9D7 File Offset: 0x0005CBD7
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FClothVertBoneData(Pointer, MemoryOwner);
		}

		// Token: 0x04001DAD RID: 7597
		public const string __ObjectPath = "/Script/ClothingSystemRuntimeInterface.ClothVertBoneData";

		// Token: 0x04001DAE RID: 7598
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001DAF RID: 7599
		internal static int __PropertyOffset_NumInfluences;

		// Token: 0x04001DB0 RID: 7600
		internal static int __PropertyOffset_BoneIndices;

		// Token: 0x04001DB1 RID: 7601
		[Nullable(2)]
		private TFixedArray<ushort> _BoneIndices;

		// Token: 0x04001DB2 RID: 7602
		internal static int __PropertyOffset_BoneWeights;

		// Token: 0x04001DB3 RID: 7603
		[Nullable(2)]
		private TFixedArray<float> _BoneWeights;
	}
}
