using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E4F RID: 3663
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionSparseVolumeTextureSample")]
	[UnrealStructLayout(376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 376)]
	public class UMaterialExpressionSparseVolumeTextureSample : UMaterialExpressionSparseVolumeTextureBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C46E RID: 50286 RVA: 0x0011C09E File Offset: 0x0011A29E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionSparseVolumeTextureSample._ClassPtr;
		}

		// Token: 0x0600C46F RID: 50287 RVA: 0x0011C0AC File Offset: 0x0011A2AC
		public UMaterialExpressionSparseVolumeTextureSample() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionSparseVolumeTextureSample.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C470 RID: 50288 RVA: 0x0011C0D4 File Offset: 0x0011A2D4
		public UMaterialExpressionSparseVolumeTextureSample(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionSparseVolumeTextureSample.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002D95 RID: 11669
		// (get) Token: 0x0600C471 RID: 50289 RVA: 0x0011C108 File Offset: 0x0011A308
		// (set) Token: 0x0600C472 RID: 50290 RVA: 0x0011C141 File Offset: 0x0011A341
		public FExpressionInput Coordinates
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Coordinates) == null)
				{
					result = (this._Coordinates = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionSparseVolumeTextureSample.__PropertyOffset_Coordinates, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionSparseVolumeTextureSample.__PropertyOffset_Coordinates, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002D96 RID: 11670
		// (get) Token: 0x0600C473 RID: 50291 RVA: 0x0011C164 File Offset: 0x0011A364
		// (set) Token: 0x0600C474 RID: 50292 RVA: 0x0011C19D File Offset: 0x0011A39D
		public FExpressionInput TextureObject
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._TextureObject) == null)
				{
					result = (this._TextureObject = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionSparseVolumeTextureSample.__PropertyOffset_TextureObject, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionSparseVolumeTextureSample.__PropertyOffset_TextureObject, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002D97 RID: 11671
		// (get) Token: 0x0600C475 RID: 50293 RVA: 0x0011C1C0 File Offset: 0x0011A3C0
		// (set) Token: 0x0600C476 RID: 50294 RVA: 0x0011C1F9 File Offset: 0x0011A3F9
		public FExpressionInput MipLevel
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._MipLevel) == null)
				{
					result = (this._MipLevel = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionSparseVolumeTextureSample.__PropertyOffset_MipLevel, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionSparseVolumeTextureSample.__PropertyOffset_MipLevel, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002D98 RID: 11672
		// (get) Token: 0x0600C477 RID: 50295 RVA: 0x0011C21A File Offset: 0x0011A41A
		// (set) Token: 0x0600C478 RID: 50296 RVA: 0x0011C22E File Offset: 0x0011A42E
		[Nullable(0)]
		public unsafe TEnumAsByte<ESamplerSourceMode> SamplerSource
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionSparseVolumeTextureSample.__PropertyOffset_SamplerSource);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionSparseVolumeTextureSample.__PropertyOffset_SamplerSource) = value;
			}
		}

		// Token: 0x0600C479 RID: 50297 RVA: 0x0011C243 File Offset: 0x0011A443
		static UMaterialExpressionSparseVolumeTextureSample()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionSparseVolumeTextureSample");
		}

		// Token: 0x0600C47A RID: 50298 RVA: 0x0011C251 File Offset: 0x0011A451
		protected UMaterialExpressionSparseVolumeTextureSample(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040068E5 RID: 26853
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionSparseVolumeTextureSample";

		// Token: 0x040068E6 RID: 26854
		private static IntPtr _ClassPtr;

		// Token: 0x040068E7 RID: 26855
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040068E8 RID: 26856
		internal static int __PropertyOffset_Coordinates;

		// Token: 0x040068E9 RID: 26857
		[Nullable(2)]
		private FExpressionInput _Coordinates;

		// Token: 0x040068EA RID: 26858
		internal static int __PropertyOffset_TextureObject;

		// Token: 0x040068EB RID: 26859
		[Nullable(2)]
		private FExpressionInput _TextureObject;

		// Token: 0x040068EC RID: 26860
		internal static int __PropertyOffset_MipLevel;

		// Token: 0x040068ED RID: 26861
		[Nullable(2)]
		private FExpressionInput _MipLevel;

		// Token: 0x040068EE RID: 26862
		internal static int __PropertyOffset_SamplerSource;
	}
}
