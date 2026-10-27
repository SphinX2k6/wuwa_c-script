using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000E99 RID: 3737
	[UnrealObjectPath("/Script/Engine.MaterialTextureInfo")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FMaterialTextureInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600C944 RID: 51524 RVA: 0x00124FE2 File Offset: 0x001231E2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMaterialTextureInfo._ScriptStructPtr != 0) ? FMaterialTextureInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.MaterialTextureInfo", ref FMaterialTextureInfo._ScriptStructPtr);
		}

		// Token: 0x17002F21 RID: 12065
		// (get) Token: 0x0600C945 RID: 51525 RVA: 0x00125006 File Offset: 0x00123206
		// (set) Token: 0x0600C946 RID: 51526 RVA: 0x00125016 File Offset: 0x00123216
		public unsafe float SamplingScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialTextureInfo.__PropertyOffset_SamplingScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialTextureInfo.__PropertyOffset_SamplingScale) = value;
			}
		}

		// Token: 0x17002F22 RID: 12066
		// (get) Token: 0x0600C947 RID: 51527 RVA: 0x00125027 File Offset: 0x00123227
		// (set) Token: 0x0600C948 RID: 51528 RVA: 0x00125037 File Offset: 0x00123237
		public unsafe int UVChannelIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialTextureInfo.__PropertyOffset_UVChannelIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialTextureInfo.__PropertyOffset_UVChannelIndex) = value;
			}
		}

		// Token: 0x17002F23 RID: 12067
		// (get) Token: 0x0600C949 RID: 51529 RVA: 0x00125048 File Offset: 0x00123248
		// (set) Token: 0x0600C94A RID: 51530 RVA: 0x0012505C File Offset: 0x0012325C
		public unsafe FName TextureName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialTextureInfo.__PropertyOffset_TextureName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialTextureInfo.__PropertyOffset_TextureName) = value;
			}
		}

		// Token: 0x0600C94B RID: 51531 RVA: 0x00125071 File Offset: 0x00123271
		public FMaterialTextureInfo()
		{
		}

		// Token: 0x0600C94C RID: 51532 RVA: 0x00125079 File Offset: 0x00123279
		[NullableContext(1)]
		public FMaterialTextureInfo(float SamplingScale, int UVChannelIndex, FName TextureName, FSoftObjectPath TextureReference, int TextureIndex)
		{
			this.SamplingScale = SamplingScale;
			this.UVChannelIndex = UVChannelIndex;
			this.TextureName = TextureName;
		}

		// Token: 0x0600C94D RID: 51533 RVA: 0x00125096 File Offset: 0x00123296
		protected override IntPtr GetUStructPtr()
		{
			return FMaterialTextureInfo.StaticStruct();
		}

		// Token: 0x0600C94E RID: 51534 RVA: 0x001250A2 File Offset: 0x001232A2
		[NullableContext(2)]
		public FMaterialTextureInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600C94F RID: 51535 RVA: 0x001250AC File Offset: 0x001232AC
		public FMaterialTextureInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600C950 RID: 51536 RVA: 0x001250B7 File Offset: 0x001232B7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMaterialTextureInfo(Pointer, false, true);
		}

		// Token: 0x0600C951 RID: 51537 RVA: 0x001250C1 File Offset: 0x001232C1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMaterialTextureInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04006C4B RID: 27723
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.MaterialTextureInfo";

		// Token: 0x04006C4C RID: 27724
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04006C4D RID: 27725
		internal static int __PropertyOffset_SamplingScale;

		// Token: 0x04006C4E RID: 27726
		internal static int __PropertyOffset_UVChannelIndex;

		// Token: 0x04006C4F RID: 27727
		internal static int __PropertyOffset_TextureName;
	}
}
