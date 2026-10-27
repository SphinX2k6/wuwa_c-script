using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F44 RID: 3908
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleEditorPromotionSettings")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FParticleEditorPromotionSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600D2BF RID: 53951 RVA: 0x00134EB4 File Offset: 0x001330B4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FParticleEditorPromotionSettings._ScriptStructPtr != 0) ? FParticleEditorPromotionSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ParticleEditorPromotionSettings", ref FParticleEditorPromotionSettings._ScriptStructPtr);
		}

		// Token: 0x17003136 RID: 12598
		// (get) Token: 0x0600D2C0 RID: 53952 RVA: 0x00134ED8 File Offset: 0x001330D8
		// (set) Token: 0x0600D2C1 RID: 53953 RVA: 0x00134F1B File Offset: 0x0013311B
		public FFilePath DefaultParticleAsset
		{
			get
			{
				base.FastCheckIsValid();
				FFilePath result;
				if ((result = this._DefaultParticleAsset) == null)
				{
					result = (this._DefaultParticleAsset = new FFilePath(base.NativePtr + (IntPtr)FParticleEditorPromotionSettings.__PropertyOffset_DefaultParticleAsset, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFilePath.StaticStruct(), base.NativePtr + (IntPtr)FParticleEditorPromotionSettings.__PropertyOffset_DefaultParticleAsset, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600D2C2 RID: 53954 RVA: 0x00134F3C File Offset: 0x0013313C
		public FParticleEditorPromotionSettings()
		{
		}

		// Token: 0x0600D2C3 RID: 53955 RVA: 0x00134F44 File Offset: 0x00133144
		public FParticleEditorPromotionSettings(FFilePath DefaultParticleAsset)
		{
			this.DefaultParticleAsset = DefaultParticleAsset;
		}

		// Token: 0x0600D2C4 RID: 53956 RVA: 0x00134F53 File Offset: 0x00133153
		protected override IntPtr GetUStructPtr()
		{
			return FParticleEditorPromotionSettings.StaticStruct();
		}

		// Token: 0x0600D2C5 RID: 53957 RVA: 0x00134F5F File Offset: 0x0013315F
		[NullableContext(2)]
		public FParticleEditorPromotionSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600D2C6 RID: 53958 RVA: 0x00134F69 File Offset: 0x00133169
		public FParticleEditorPromotionSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600D2C7 RID: 53959 RVA: 0x00134F74 File Offset: 0x00133174
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FParticleEditorPromotionSettings(Pointer, false, true);
		}

		// Token: 0x0600D2C8 RID: 53960 RVA: 0x00134F7E File Offset: 0x0013317E
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FParticleEditorPromotionSettings(Pointer, MemoryOwner);
		}

		// Token: 0x0400710A RID: 28938
		public const string __ObjectPath = "/Script/Engine.ParticleEditorPromotionSettings";

		// Token: 0x0400710B RID: 28939
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400710C RID: 28940
		internal static int __PropertyOffset_DefaultParticleAsset;

		// Token: 0x0400710D RID: 28941
		[Nullable(2)]
		private FFilePath _DefaultParticleAsset;
	}
}
