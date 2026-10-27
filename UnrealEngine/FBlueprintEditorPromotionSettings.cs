using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020008BF RID: 2239
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BlueprintEditorPromotionSettings")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FBlueprintEditorPromotionSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007A4F RID: 31311 RVA: 0x000AEE7E File Offset: 0x000AD07E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBlueprintEditorPromotionSettings._ScriptStructPtr != 0) ? FBlueprintEditorPromotionSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BlueprintEditorPromotionSettings", ref FBlueprintEditorPromotionSettings._ScriptStructPtr);
		}

		// Token: 0x17001CE6 RID: 7398
		// (get) Token: 0x06007A50 RID: 31312 RVA: 0x000AEEA4 File Offset: 0x000AD0A4
		// (set) Token: 0x06007A51 RID: 31313 RVA: 0x000AEEE7 File Offset: 0x000AD0E7
		public FFilePath FirstMeshPath
		{
			get
			{
				base.FastCheckIsValid();
				FFilePath result;
				if ((result = this._FirstMeshPath) == null)
				{
					result = (this._FirstMeshPath = new FFilePath(base.NativePtr + (IntPtr)FBlueprintEditorPromotionSettings.__PropertyOffset_FirstMeshPath, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFilePath.StaticStruct(), base.NativePtr + (IntPtr)FBlueprintEditorPromotionSettings.__PropertyOffset_FirstMeshPath, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001CE7 RID: 7399
		// (get) Token: 0x06007A52 RID: 31314 RVA: 0x000AEF08 File Offset: 0x000AD108
		// (set) Token: 0x06007A53 RID: 31315 RVA: 0x000AEF4B File Offset: 0x000AD14B
		public FFilePath SecondMeshPath
		{
			get
			{
				base.FastCheckIsValid();
				FFilePath result;
				if ((result = this._SecondMeshPath) == null)
				{
					result = (this._SecondMeshPath = new FFilePath(base.NativePtr + (IntPtr)FBlueprintEditorPromotionSettings.__PropertyOffset_SecondMeshPath, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFilePath.StaticStruct(), base.NativePtr + (IntPtr)FBlueprintEditorPromotionSettings.__PropertyOffset_SecondMeshPath, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001CE8 RID: 7400
		// (get) Token: 0x06007A54 RID: 31316 RVA: 0x000AEF6C File Offset: 0x000AD16C
		// (set) Token: 0x06007A55 RID: 31317 RVA: 0x000AEFAF File Offset: 0x000AD1AF
		public FFilePath DefaultParticleAsset
		{
			get
			{
				base.FastCheckIsValid();
				FFilePath result;
				if ((result = this._DefaultParticleAsset) == null)
				{
					result = (this._DefaultParticleAsset = new FFilePath(base.NativePtr + (IntPtr)FBlueprintEditorPromotionSettings.__PropertyOffset_DefaultParticleAsset, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFilePath.StaticStruct(), base.NativePtr + (IntPtr)FBlueprintEditorPromotionSettings.__PropertyOffset_DefaultParticleAsset, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06007A56 RID: 31318 RVA: 0x000AEFD0 File Offset: 0x000AD1D0
		public FBlueprintEditorPromotionSettings()
		{
		}

		// Token: 0x06007A57 RID: 31319 RVA: 0x000AEFD8 File Offset: 0x000AD1D8
		public FBlueprintEditorPromotionSettings(FFilePath FirstMeshPath, FFilePath SecondMeshPath, FFilePath DefaultParticleAsset)
		{
			this.FirstMeshPath = FirstMeshPath;
			this.SecondMeshPath = SecondMeshPath;
			this.DefaultParticleAsset = DefaultParticleAsset;
		}

		// Token: 0x06007A58 RID: 31320 RVA: 0x000AEFF5 File Offset: 0x000AD1F5
		protected override IntPtr GetUStructPtr()
		{
			return FBlueprintEditorPromotionSettings.StaticStruct();
		}

		// Token: 0x06007A59 RID: 31321 RVA: 0x000AF001 File Offset: 0x000AD201
		[NullableContext(2)]
		public FBlueprintEditorPromotionSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007A5A RID: 31322 RVA: 0x000AF00B File Offset: 0x000AD20B
		public FBlueprintEditorPromotionSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007A5B RID: 31323 RVA: 0x000AF016 File Offset: 0x000AD216
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBlueprintEditorPromotionSettings(Pointer, false, true);
		}

		// Token: 0x06007A5C RID: 31324 RVA: 0x000AF020 File Offset: 0x000AD220
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBlueprintEditorPromotionSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04003ACC RID: 15052
		public const string __ObjectPath = "/Script/Engine.BlueprintEditorPromotionSettings";

		// Token: 0x04003ACD RID: 15053
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003ACE RID: 15054
		internal static int __PropertyOffset_FirstMeshPath;

		// Token: 0x04003ACF RID: 15055
		[Nullable(2)]
		private FFilePath _FirstMeshPath;

		// Token: 0x04003AD0 RID: 15056
		internal static int __PropertyOffset_SecondMeshPath;

		// Token: 0x04003AD1 RID: 15057
		[Nullable(2)]
		private FFilePath _SecondMeshPath;

		// Token: 0x04003AD2 RID: 15058
		internal static int __PropertyOffset_DefaultParticleAsset;

		// Token: 0x04003AD3 RID: 15059
		[Nullable(2)]
		private FFilePath _DefaultParticleAsset;
	}
}
