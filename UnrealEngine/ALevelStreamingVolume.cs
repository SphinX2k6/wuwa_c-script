using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D41 RID: 3393
	[UnrealObjectPath("/Script/Engine.LevelStreamingVolume")]
	[UnrealStructLayout(1128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1128)]
	public class ALevelStreamingVolume : AVolume, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B5CF RID: 46543 RVA: 0x00103652 File Offset: 0x00101852
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ALevelStreamingVolume._ClassPtr;
		}

		// Token: 0x0600B5D0 RID: 46544 RVA: 0x00103660 File Offset: 0x00101860
		public ALevelStreamingVolume() : this(BuiltinUtils.AllocNativeUObject(ALevelStreamingVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B5D1 RID: 46545 RVA: 0x00103688 File Offset: 0x00101888
		[NullableContext(1)]
		public ALevelStreamingVolume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ALevelStreamingVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002990 RID: 10640
		// (get) Token: 0x0600B5D2 RID: 46546 RVA: 0x001036BC File Offset: 0x001018BC
		// (set) Token: 0x0600B5D3 RID: 46547 RVA: 0x001036F5 File Offset: 0x001018F5
		[Nullable(1)]
		public TArray<FName> StreamingLevelNames
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._StreamingLevelNames) == null)
				{
					result = (this._StreamingLevelNames = new TArray<FName>(base.NativePtr + (IntPtr)ALevelStreamingVolume.__PropertyOffset_StreamingLevelNames, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.StreamingLevelNames.CopyAssign(value);
			}
		}

		// Token: 0x17002991 RID: 10641
		// (get) Token: 0x0600B5D4 RID: 46548 RVA: 0x00103703 File Offset: 0x00101903
		// (set) Token: 0x0600B5D5 RID: 46549 RVA: 0x0010371C File Offset: 0x0010191C
		public unsafe bool bEditorPreVisOnly
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ALevelStreamingVolume.__PropertyOffset_bEditorPreVisOnly) & ALevelStreamingVolume.__PropertyMask_bEditorPreVisOnly) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ALevelStreamingVolume.__PropertyOffset_bEditorPreVisOnly) = ((*(base.NativePtr + (IntPtr)ALevelStreamingVolume.__PropertyOffset_bEditorPreVisOnly) & ~ALevelStreamingVolume.__PropertyMask_bEditorPreVisOnly) | (value ? ALevelStreamingVolume.__PropertyMask_bEditorPreVisOnly : 0));
			}
		}

		// Token: 0x17002992 RID: 10642
		// (get) Token: 0x0600B5D6 RID: 46550 RVA: 0x0010374C File Offset: 0x0010194C
		// (set) Token: 0x0600B5D7 RID: 46551 RVA: 0x00103765 File Offset: 0x00101965
		public unsafe bool bDisabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ALevelStreamingVolume.__PropertyOffset_bDisabled) & ALevelStreamingVolume.__PropertyMask_bDisabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ALevelStreamingVolume.__PropertyOffset_bDisabled) = ((*(base.NativePtr + (IntPtr)ALevelStreamingVolume.__PropertyOffset_bDisabled) & ~ALevelStreamingVolume.__PropertyMask_bDisabled) | (value ? ALevelStreamingVolume.__PropertyMask_bDisabled : 0));
			}
		}

		// Token: 0x17002993 RID: 10643
		// (get) Token: 0x0600B5D8 RID: 46552 RVA: 0x00103795 File Offset: 0x00101995
		// (set) Token: 0x0600B5D9 RID: 46553 RVA: 0x001037A9 File Offset: 0x001019A9
		public unsafe TEnumAsByte<EStreamingVolumeUsage> StreamingUsage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALevelStreamingVolume.__PropertyOffset_StreamingUsage);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALevelStreamingVolume.__PropertyOffset_StreamingUsage) = value;
			}
		}

		// Token: 0x0600B5DA RID: 46554 RVA: 0x001037BE File Offset: 0x001019BE
		static ALevelStreamingVolume()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.LevelStreamingVolume");
		}

		// Token: 0x0600B5DB RID: 46555 RVA: 0x001037CC File Offset: 0x001019CC
		protected ALevelStreamingVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005F8A RID: 24458
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.LevelStreamingVolume";

		// Token: 0x04005F8B RID: 24459
		private static IntPtr _ClassPtr;

		// Token: 0x04005F8C RID: 24460
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005F8D RID: 24461
		internal static int __PropertyOffset_StreamingLevelNames;

		// Token: 0x04005F8E RID: 24462
		[Nullable(2)]
		private TArray<FName> _StreamingLevelNames;

		// Token: 0x04005F8F RID: 24463
		internal static int __PropertyOffset_bEditorPreVisOnly;

		// Token: 0x04005F90 RID: 24464
		internal static byte __PropertyMask_bEditorPreVisOnly;

		// Token: 0x04005F91 RID: 24465
		internal static int __PropertyOffset_bDisabled;

		// Token: 0x04005F92 RID: 24466
		internal static byte __PropertyMask_bDisabled;

		// Token: 0x04005F93 RID: 24467
		internal static int __PropertyOffset_StreamingUsage;
	}
}
