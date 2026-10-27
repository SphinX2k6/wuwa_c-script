using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C83 RID: 7299
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSceneModifier.KuroSceneModifierSubsystem")]
	[UnrealStructLayout(336, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 336)]
	public class UKuroSceneModifierSubsystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C555 RID: 116053 RVA: 0x0029C188 File Offset: 0x0029A388
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroSceneModifierSubsystem._ClassPtr;
		}

		// Token: 0x0601C556 RID: 116054 RVA: 0x0029C194 File Offset: 0x0029A394
		public UKuroSceneModifierSubsystem() : this(BuiltinUtils.AllocNativeUObject(UKuroSceneModifierSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C557 RID: 116055 RVA: 0x0029C1BC File Offset: 0x0029A3BC
		public UKuroSceneModifierSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroSceneModifierSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700728C RID: 29324
		// (get) Token: 0x0601C558 RID: 116056 RVA: 0x0029C1F0 File Offset: 0x0029A3F0
		// (set) Token: 0x0601C559 RID: 116057 RVA: 0x0029C229 File Offset: 0x0029A429
		public TMap<FName, FKuroSceneModifierDataState> ConsideredDataLayers
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FKuroSceneModifierDataState> result;
				if ((result = this._ConsideredDataLayers) == null)
				{
					result = (this._ConsideredDataLayers = new TMap<FName, FKuroSceneModifierDataState>(base.NativePtr + (IntPtr)UKuroSceneModifierSubsystem.__PropertyOffset_ConsideredDataLayers, this));
				}
				return result;
			}
			set
			{
				this.ConsideredDataLayers.CopyAssign(value);
			}
		}

		// Token: 0x1700728D RID: 29325
		// (get) Token: 0x0601C55A RID: 116058 RVA: 0x0029C238 File Offset: 0x0029A438
		// (set) Token: 0x0601C55B RID: 116059 RVA: 0x0029C271 File Offset: 0x0029A471
		public TMap<FName, FKuroSceneModifierEntry> AllModifiedLevels
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FKuroSceneModifierEntry> result;
				if ((result = this._AllModifiedLevels) == null)
				{
					result = (this._AllModifiedLevels = new TMap<FName, FKuroSceneModifierEntry>(base.NativePtr + (IntPtr)UKuroSceneModifierSubsystem.__PropertyOffset_AllModifiedLevels, this));
				}
				return result;
			}
			set
			{
				this.AllModifiedLevels.CopyAssign(value);
			}
		}

		// Token: 0x0601C55C RID: 116060 RVA: 0x0029C27F File Offset: 0x0029A47F
		[NullableContext(2)]
		public void ResetMaterialsByDataLayer(in TSet<FName> InDataLayerLabels)
		{
			UKuroSceneModifierSubsystem.__ResetMaterialsByDataLayer_Internal(base.NativePtr, (InDataLayerLabels ?? new TSet<FName>()).NativeSetPtr);
		}

		// Token: 0x0601C55D RID: 116061 RVA: 0x0029C29C File Offset: 0x0029A49C
		[NullableContext(2)]
		public void ModifyMaterialsByDataLayer(in TSet<FName> InDataLayerLabels, UKuroSceneMatModifyDataAsset InMatDataAsset, bool bVisibleBeforeModify = false)
		{
			UKuroSceneModifierSubsystem.__ModifyMaterialsByDataLayer_Internal(base.NativePtr, (InDataLayerLabels ?? new TSet<FName>()).NativeSetPtr, (InMatDataAsset != null) ? InMatDataAsset.NativePtr : IntPtr.Zero, bVisibleBeforeModify);
		}

		// Token: 0x0601C55E RID: 116062
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetMaterialsByDataLayer_Internal(IntPtr @this, IntPtr InDataLayerLabels);

		// Token: 0x0601C55F RID: 116063
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ModifyMaterialsByDataLayer_Internal(IntPtr @this, IntPtr InDataLayerLabels, IntPtr InMatDataAsset, bool bVisibleBeforeModify);

		// Token: 0x0601C560 RID: 116064 RVA: 0x0029C2CA File Offset: 0x0029A4CA
		static UKuroSceneModifierSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSceneModifier.KuroSceneModifierSubsystem");
		}

		// Token: 0x0601C561 RID: 116065 RVA: 0x0029C2D8 File Offset: 0x0029A4D8
		protected UKuroSceneModifierSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F3B0 RID: 62384
		public new const string __ObjectPath = "/Script/KuroSceneModifier.KuroSceneModifierSubsystem";

		// Token: 0x0400F3B1 RID: 62385
		private static IntPtr _ClassPtr;

		// Token: 0x0400F3B2 RID: 62386
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F3B3 RID: 62387
		internal static int __PropertyOffset_ConsideredDataLayers;

		// Token: 0x0400F3B4 RID: 62388
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FKuroSceneModifierDataState> _ConsideredDataLayers;

		// Token: 0x0400F3B5 RID: 62389
		internal static int __PropertyOffset_AllModifiedLevels;

		// Token: 0x0400F3B6 RID: 62390
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FKuroSceneModifierEntry> _AllModifiedLevels;
	}
}
