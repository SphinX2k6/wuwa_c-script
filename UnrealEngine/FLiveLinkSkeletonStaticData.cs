using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002213 RID: 8723
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LiveLinkInterface.LiveLinkSkeletonStaticData")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FLiveLinkSkeletonStaticData : FLiveLinkBaseStaticData, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021397 RID: 136087 RVA: 0x0030FB55 File Offset: 0x0030DD55
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLiveLinkSkeletonStaticData._ScriptStructPtr != 0) ? FLiveLinkSkeletonStaticData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LiveLinkInterface.LiveLinkSkeletonStaticData", ref FLiveLinkSkeletonStaticData._ScriptStructPtr);
		}

		// Token: 0x170081AE RID: 33198
		// (get) Token: 0x06021398 RID: 136088 RVA: 0x0030FB7C File Offset: 0x0030DD7C
		// (set) Token: 0x06021399 RID: 136089 RVA: 0x0030FBBF File Offset: 0x0030DDBF
		public TArray<FName> BoneNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._BoneNames) == null)
				{
					result = (this._BoneNames = new TArray<FName>(base.NativePtr + (IntPtr)FLiveLinkSkeletonStaticData.__PropertyOffset_BoneNames, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BoneNames.CopyAssign(value);
			}
		}

		// Token: 0x170081AF RID: 33199
		// (get) Token: 0x0602139A RID: 136090 RVA: 0x0030FBD0 File Offset: 0x0030DDD0
		// (set) Token: 0x0602139B RID: 136091 RVA: 0x0030FC13 File Offset: 0x0030DE13
		public TArray<int> BoneParents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._BoneParents) == null)
				{
					result = (this._BoneParents = new TArray<int>(base.NativePtr + (IntPtr)FLiveLinkSkeletonStaticData.__PropertyOffset_BoneParents, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BoneParents.CopyAssign(value);
			}
		}

		// Token: 0x0602139C RID: 136092 RVA: 0x0030FC21 File Offset: 0x0030DE21
		public FLiveLinkSkeletonStaticData()
		{
		}

		// Token: 0x0602139D RID: 136093 RVA: 0x0030FC29 File Offset: 0x0030DE29
		public FLiveLinkSkeletonStaticData(TArray<FName> BoneNames, TArray<int> BoneParents, TArray<FName> PropertyNames)
		{
			this.BoneNames = BoneNames;
			this.BoneParents = BoneParents;
			base.PropertyNames = PropertyNames;
		}

		// Token: 0x0602139E RID: 136094 RVA: 0x0030FC46 File Offset: 0x0030DE46
		protected override IntPtr GetUStructPtr()
		{
			return FLiveLinkSkeletonStaticData.StaticStruct();
		}

		// Token: 0x0602139F RID: 136095 RVA: 0x0030FC52 File Offset: 0x0030DE52
		[NullableContext(2)]
		public FLiveLinkSkeletonStaticData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060213A0 RID: 136096 RVA: 0x0030FC5C File Offset: 0x0030DE5C
		public FLiveLinkSkeletonStaticData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060213A1 RID: 136097 RVA: 0x0030FC67 File Offset: 0x0030DE67
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLiveLinkSkeletonStaticData(Pointer, false, true);
		}

		// Token: 0x060213A2 RID: 136098 RVA: 0x0030FC71 File Offset: 0x0030DE71
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLiveLinkSkeletonStaticData(Pointer, MemoryOwner);
		}

		// Token: 0x04011B94 RID: 72596
		public new const string __ObjectPath = "/Script/LiveLinkInterface.LiveLinkSkeletonStaticData";

		// Token: 0x04011B95 RID: 72597
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011B96 RID: 72598
		internal static int __PropertyOffset_BoneNames;

		// Token: 0x04011B97 RID: 72599
		[Nullable(2)]
		private TArray<FName> _BoneNames;

		// Token: 0x04011B98 RID: 72600
		internal static int __PropertyOffset_BoneParents;

		// Token: 0x04011B99 RID: 72601
		[Nullable(2)]
		private TArray<int> _BoneParents;
	}
}
