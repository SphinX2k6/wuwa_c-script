using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020013B1 RID: 5041
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.ReplicatedPredictionKeyMap")]
	[UnrealStructLayout(280, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 280)]
	public class FReplicatedPredictionKeyMap : FFastArraySerializer, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060127E4 RID: 75748 RVA: 0x001B2FE1 File Offset: 0x001B11E1
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FReplicatedPredictionKeyMap._ScriptStructPtr != 0) ? FReplicatedPredictionKeyMap._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.ReplicatedPredictionKeyMap", ref FReplicatedPredictionKeyMap._ScriptStructPtr);
		}

		// Token: 0x170047FE RID: 18430
		// (get) Token: 0x060127E5 RID: 75749 RVA: 0x001B3008 File Offset: 0x001B1208
		// (set) Token: 0x060127E6 RID: 75750 RVA: 0x001B304B File Offset: 0x001B124B
		public TArray<FReplicatedPredictionKeyItem> PredictionKeys
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FReplicatedPredictionKeyItem> result;
				if ((result = this._PredictionKeys) == null)
				{
					result = (this._PredictionKeys = new TArray<FReplicatedPredictionKeyItem>(base.NativePtr + (IntPtr)FReplicatedPredictionKeyMap.__PropertyOffset_PredictionKeys, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PredictionKeys.CopyAssign(value);
			}
		}

		// Token: 0x060127E7 RID: 75751 RVA: 0x001B3059 File Offset: 0x001B1259
		public FReplicatedPredictionKeyMap()
		{
		}

		// Token: 0x060127E8 RID: 75752 RVA: 0x001B3061 File Offset: 0x001B1261
		public FReplicatedPredictionKeyMap(TArray<FReplicatedPredictionKeyItem> PredictionKeys, int ArrayReplicationKey, EFastArraySerializerDeltaFlags DeltaFlags)
		{
			this.PredictionKeys = PredictionKeys;
			base.ArrayReplicationKey = ArrayReplicationKey;
			base.DeltaFlags = DeltaFlags;
		}

		// Token: 0x060127E9 RID: 75753 RVA: 0x001B307E File Offset: 0x001B127E
		protected override IntPtr GetUStructPtr()
		{
			return FReplicatedPredictionKeyMap.StaticStruct();
		}

		// Token: 0x060127EA RID: 75754 RVA: 0x001B308A File Offset: 0x001B128A
		[NullableContext(2)]
		public FReplicatedPredictionKeyMap(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060127EB RID: 75755 RVA: 0x001B3094 File Offset: 0x001B1294
		public FReplicatedPredictionKeyMap(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060127EC RID: 75756 RVA: 0x001B309F File Offset: 0x001B129F
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FReplicatedPredictionKeyMap(Pointer, false, true);
		}

		// Token: 0x060127ED RID: 75757 RVA: 0x001B30A9 File Offset: 0x001B12A9
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FReplicatedPredictionKeyMap(Pointer, MemoryOwner);
		}

		// Token: 0x04009E4F RID: 40527
		public new const string __ObjectPath = "/Script/GameplayAbilities.ReplicatedPredictionKeyMap";

		// Token: 0x04009E50 RID: 40528
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009E51 RID: 40529
		internal static int __PropertyOffset_PredictionKeys;

		// Token: 0x04009E52 RID: 40530
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FReplicatedPredictionKeyItem> _PredictionKeys;
	}
}
