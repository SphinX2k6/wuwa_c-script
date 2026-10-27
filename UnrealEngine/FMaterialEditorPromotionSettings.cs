using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D7D RID: 3453
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialEditorPromotionSettings")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FMaterialEditorPromotionSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600BCC9 RID: 48329 RVA: 0x0010DC42 File Offset: 0x0010BE42
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMaterialEditorPromotionSettings._ScriptStructPtr != 0) ? FMaterialEditorPromotionSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.MaterialEditorPromotionSettings", ref FMaterialEditorPromotionSettings._ScriptStructPtr);
		}

		// Token: 0x17002BCE RID: 11214
		// (get) Token: 0x0600BCCA RID: 48330 RVA: 0x0010DC68 File Offset: 0x0010BE68
		// (set) Token: 0x0600BCCB RID: 48331 RVA: 0x0010DCAB File Offset: 0x0010BEAB
		public FFilePath DefaultMaterialAsset
		{
			get
			{
				base.FastCheckIsValid();
				FFilePath result;
				if ((result = this._DefaultMaterialAsset) == null)
				{
					result = (this._DefaultMaterialAsset = new FFilePath(base.NativePtr + (IntPtr)FMaterialEditorPromotionSettings.__PropertyOffset_DefaultMaterialAsset, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFilePath.StaticStruct(), base.NativePtr + (IntPtr)FMaterialEditorPromotionSettings.__PropertyOffset_DefaultMaterialAsset, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002BCF RID: 11215
		// (get) Token: 0x0600BCCC RID: 48332 RVA: 0x0010DCCC File Offset: 0x0010BECC
		// (set) Token: 0x0600BCCD RID: 48333 RVA: 0x0010DD0F File Offset: 0x0010BF0F
		public FFilePath DefaultDiffuseTexture
		{
			get
			{
				base.FastCheckIsValid();
				FFilePath result;
				if ((result = this._DefaultDiffuseTexture) == null)
				{
					result = (this._DefaultDiffuseTexture = new FFilePath(base.NativePtr + (IntPtr)FMaterialEditorPromotionSettings.__PropertyOffset_DefaultDiffuseTexture, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFilePath.StaticStruct(), base.NativePtr + (IntPtr)FMaterialEditorPromotionSettings.__PropertyOffset_DefaultDiffuseTexture, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002BD0 RID: 11216
		// (get) Token: 0x0600BCCE RID: 48334 RVA: 0x0010DD30 File Offset: 0x0010BF30
		// (set) Token: 0x0600BCCF RID: 48335 RVA: 0x0010DD73 File Offset: 0x0010BF73
		public FFilePath DefaultNormalTexture
		{
			get
			{
				base.FastCheckIsValid();
				FFilePath result;
				if ((result = this._DefaultNormalTexture) == null)
				{
					result = (this._DefaultNormalTexture = new FFilePath(base.NativePtr + (IntPtr)FMaterialEditorPromotionSettings.__PropertyOffset_DefaultNormalTexture, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFilePath.StaticStruct(), base.NativePtr + (IntPtr)FMaterialEditorPromotionSettings.__PropertyOffset_DefaultNormalTexture, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600BCD0 RID: 48336 RVA: 0x0010DD94 File Offset: 0x0010BF94
		public FMaterialEditorPromotionSettings()
		{
		}

		// Token: 0x0600BCD1 RID: 48337 RVA: 0x0010DD9C File Offset: 0x0010BF9C
		public FMaterialEditorPromotionSettings(FFilePath DefaultMaterialAsset, FFilePath DefaultDiffuseTexture, FFilePath DefaultNormalTexture)
		{
			this.DefaultMaterialAsset = DefaultMaterialAsset;
			this.DefaultDiffuseTexture = DefaultDiffuseTexture;
			this.DefaultNormalTexture = DefaultNormalTexture;
		}

		// Token: 0x0600BCD2 RID: 48338 RVA: 0x0010DDB9 File Offset: 0x0010BFB9
		protected override IntPtr GetUStructPtr()
		{
			return FMaterialEditorPromotionSettings.StaticStruct();
		}

		// Token: 0x0600BCD3 RID: 48339 RVA: 0x0010DDC5 File Offset: 0x0010BFC5
		[NullableContext(2)]
		public FMaterialEditorPromotionSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600BCD4 RID: 48340 RVA: 0x0010DDCF File Offset: 0x0010BFCF
		public FMaterialEditorPromotionSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600BCD5 RID: 48341 RVA: 0x0010DDDA File Offset: 0x0010BFDA
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMaterialEditorPromotionSettings(Pointer, false, true);
		}

		// Token: 0x0600BCD6 RID: 48342 RVA: 0x0010DDE4 File Offset: 0x0010BFE4
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMaterialEditorPromotionSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04006389 RID: 25481
		public const string __ObjectPath = "/Script/Engine.MaterialEditorPromotionSettings";

		// Token: 0x0400638A RID: 25482
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400638B RID: 25483
		internal static int __PropertyOffset_DefaultMaterialAsset;

		// Token: 0x0400638C RID: 25484
		[Nullable(2)]
		private FFilePath _DefaultMaterialAsset;

		// Token: 0x0400638D RID: 25485
		internal static int __PropertyOffset_DefaultDiffuseTexture;

		// Token: 0x0400638E RID: 25486
		[Nullable(2)]
		private FFilePath _DefaultDiffuseTexture;

		// Token: 0x0400638F RID: 25487
		internal static int __PropertyOffset_DefaultNormalTexture;

		// Token: 0x04006390 RID: 25488
		[Nullable(2)]
		private FFilePath _DefaultNormalTexture;
	}
}
