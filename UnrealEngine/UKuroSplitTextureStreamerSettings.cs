using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BC6 RID: 7110
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroSplitTextureStreamerSettings")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UKuroSplitTextureStreamerSettings : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601B481 RID: 111745 RVA: 0x00283373 File Offset: 0x00281573
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroSplitTextureStreamerSettings._ClassPtr;
		}

		// Token: 0x0601B482 RID: 111746 RVA: 0x00283380 File Offset: 0x00281580
		public UKuroSplitTextureStreamerSettings() : this(BuiltinUtils.AllocNativeUObject(UKuroSplitTextureStreamerSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601B483 RID: 111747 RVA: 0x002833A8 File Offset: 0x002815A8
		public UKuroSplitTextureStreamerSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroSplitTextureStreamerSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006D95 RID: 28053
		// (get) Token: 0x0601B484 RID: 111748 RVA: 0x002833DC File Offset: 0x002815DC
		// (set) Token: 0x0601B485 RID: 111749 RVA: 0x00283415 File Offset: 0x00281615
		public TArray<TSoftObjectPtr<UTexture2D>> SplitTextureReferences
		{
			get
			{
				base.FastCheckIsValid();
				TArray<TSoftObjectPtr<UTexture2D>> result;
				if ((result = this._SplitTextureReferences) == null)
				{
					result = (this._SplitTextureReferences = new TArray<TSoftObjectPtr<UTexture2D>>(base.NativePtr + (IntPtr)UKuroSplitTextureStreamerSettings.__PropertyOffset_SplitTextureReferences, this));
				}
				return result;
			}
			set
			{
				this.SplitTextureReferences.CopyAssign(value);
			}
		}

		// Token: 0x17006D96 RID: 28054
		// (get) Token: 0x0601B486 RID: 111750 RVA: 0x00283424 File Offset: 0x00281624
		// (set) Token: 0x0601B487 RID: 111751 RVA: 0x0028345D File Offset: 0x0028165D
		public TArray<float> SplitTextureShotHeight
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._SplitTextureShotHeight) == null)
				{
					result = (this._SplitTextureShotHeight = new TArray<float>(base.NativePtr + (IntPtr)UKuroSplitTextureStreamerSettings.__PropertyOffset_SplitTextureShotHeight, this));
				}
				return result;
			}
			set
			{
				this.SplitTextureShotHeight.CopyAssign(value);
			}
		}

		// Token: 0x17006D97 RID: 28055
		// (get) Token: 0x0601B488 RID: 111752 RVA: 0x0028346B File Offset: 0x0028166B
		// (set) Token: 0x0601B489 RID: 111753 RVA: 0x0028347B File Offset: 0x0028167B
		public unsafe int SideCellNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroSplitTextureStreamerSettings.__PropertyOffset_SideCellNum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSplitTextureStreamerSettings.__PropertyOffset_SideCellNum) = value;
			}
		}

		// Token: 0x17006D98 RID: 28056
		// (get) Token: 0x0601B48A RID: 111754 RVA: 0x0028348C File Offset: 0x0028168C
		// (set) Token: 0x0601B48B RID: 111755 RVA: 0x0028349C File Offset: 0x0028169C
		public unsafe int SizePerCell
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroSplitTextureStreamerSettings.__PropertyOffset_SizePerCell);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSplitTextureStreamerSettings.__PropertyOffset_SizePerCell) = value;
			}
		}

		// Token: 0x17006D99 RID: 28057
		// (get) Token: 0x0601B48C RID: 111756 RVA: 0x002834AD File Offset: 0x002816AD
		// (set) Token: 0x0601B48D RID: 111757 RVA: 0x002834C1 File Offset: 0x002816C1
		public unsafe FVector2D StartWorldPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroSplitTextureStreamerSettings.__PropertyOffset_StartWorldPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSplitTextureStreamerSettings.__PropertyOffset_StartWorldPosition) = value;
			}
		}

		// Token: 0x0601B48E RID: 111758 RVA: 0x002834D6 File Offset: 0x002816D6
		static UKuroSplitTextureStreamerSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroSplitTextureStreamerSettings");
		}

		// Token: 0x0601B48F RID: 111759 RVA: 0x002834E4 File Offset: 0x002816E4
		protected UKuroSplitTextureStreamerSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400EB12 RID: 60178
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroSplitTextureStreamerSettings";

		// Token: 0x0400EB13 RID: 60179
		private static IntPtr _ClassPtr;

		// Token: 0x0400EB14 RID: 60180
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400EB15 RID: 60181
		internal static int __PropertyOffset_SplitTextureReferences;

		// Token: 0x0400EB16 RID: 60182
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TArray<TSoftObjectPtr<UTexture2D>> _SplitTextureReferences;

		// Token: 0x0400EB17 RID: 60183
		internal static int __PropertyOffset_SplitTextureShotHeight;

		// Token: 0x0400EB18 RID: 60184
		[Nullable(2)]
		private TArray<float> _SplitTextureShotHeight;

		// Token: 0x0400EB19 RID: 60185
		internal static int __PropertyOffset_SideCellNum;

		// Token: 0x0400EB1A RID: 60186
		internal static int __PropertyOffset_SizePerCell;

		// Token: 0x0400EB1B RID: 60187
		internal static int __PropertyOffset_StartWorldPosition;
	}
}
