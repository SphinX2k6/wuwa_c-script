using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020013B0 RID: 5040
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.ReplicatedPredictionKeyItem")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FReplicatedPredictionKeyItem : FFastArraySerializerItem, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060127DA RID: 75738 RVA: 0x001B2EF6 File Offset: 0x001B10F6
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FReplicatedPredictionKeyItem._ScriptStructPtr != 0) ? FReplicatedPredictionKeyItem._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.ReplicatedPredictionKeyItem", ref FReplicatedPredictionKeyItem._ScriptStructPtr);
		}

		// Token: 0x170047FD RID: 18429
		// (get) Token: 0x060127DB RID: 75739 RVA: 0x001B2F1C File Offset: 0x001B111C
		// (set) Token: 0x060127DC RID: 75740 RVA: 0x001B2F5F File Offset: 0x001B115F
		public FPredictionKey PredictionKey
		{
			get
			{
				base.FastCheckIsValid();
				FPredictionKey result;
				if ((result = this._PredictionKey) == null)
				{
					result = (this._PredictionKey = new FPredictionKey(base.NativePtr + (IntPtr)FReplicatedPredictionKeyItem.__PropertyOffset_PredictionKey, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPredictionKey.StaticStruct(), base.NativePtr + (IntPtr)FReplicatedPredictionKeyItem.__PropertyOffset_PredictionKey, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060127DD RID: 75741 RVA: 0x001B2F80 File Offset: 0x001B1180
		public FReplicatedPredictionKeyItem()
		{
		}

		// Token: 0x060127DE RID: 75742 RVA: 0x001B2F88 File Offset: 0x001B1188
		public FReplicatedPredictionKeyItem(FPredictionKey PredictionKey, int ReplicationID, int ReplicationKey, int MostRecentArrayReplicationKey)
		{
			this.PredictionKey = PredictionKey;
			base.ReplicationID = ReplicationID;
			base.ReplicationKey = ReplicationKey;
			base.MostRecentArrayReplicationKey = MostRecentArrayReplicationKey;
		}

		// Token: 0x060127DF RID: 75743 RVA: 0x001B2FAD File Offset: 0x001B11AD
		protected override IntPtr GetUStructPtr()
		{
			return FReplicatedPredictionKeyItem.StaticStruct();
		}

		// Token: 0x060127E0 RID: 75744 RVA: 0x001B2FB9 File Offset: 0x001B11B9
		[NullableContext(2)]
		public FReplicatedPredictionKeyItem(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060127E1 RID: 75745 RVA: 0x001B2FC3 File Offset: 0x001B11C3
		public FReplicatedPredictionKeyItem(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060127E2 RID: 75746 RVA: 0x001B2FCE File Offset: 0x001B11CE
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FReplicatedPredictionKeyItem(Pointer, false, true);
		}

		// Token: 0x060127E3 RID: 75747 RVA: 0x001B2FD8 File Offset: 0x001B11D8
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FReplicatedPredictionKeyItem(Pointer, MemoryOwner);
		}

		// Token: 0x04009E4B RID: 40523
		public new const string __ObjectPath = "/Script/GameplayAbilities.ReplicatedPredictionKeyItem";

		// Token: 0x04009E4C RID: 40524
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009E4D RID: 40525
		internal static int __PropertyOffset_PredictionKey;

		// Token: 0x04009E4E RID: 40526
		[Nullable(2)]
		private FPredictionKey _PredictionKey;
	}
}
