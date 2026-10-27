using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014E8 RID: 5352
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniParameter")]
	[UnrealStructLayout(272, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 272)]
	public class UHoudiniParameter : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601361D RID: 79389 RVA: 0x001C8030 File Offset: 0x001C6230
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniParameter._ClassPtr;
		}

		// Token: 0x0601361E RID: 79390 RVA: 0x001C803C File Offset: 0x001C623C
		public UHoudiniParameter() : this(BuiltinUtils.AllocNativeUObject(UHoudiniParameter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601361F RID: 79391 RVA: 0x001C8064 File Offset: 0x001C6264
		public UHoudiniParameter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniParameter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004B96 RID: 19350
		// (get) Token: 0x06013620 RID: 79392 RVA: 0x001C8097 File Offset: 0x001C6297
		// (set) Token: 0x06013621 RID: 79393 RVA: 0x001C80AB File Offset: 0x001C62AB
		public unsafe string Name
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniParameter.__PropertyOffset_Name)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniParameter.__PropertyOffset_Name)), value);
			}
		}

		// Token: 0x17004B97 RID: 19351
		// (get) Token: 0x06013622 RID: 79394 RVA: 0x001C80C0 File Offset: 0x001C62C0
		// (set) Token: 0x06013623 RID: 79395 RVA: 0x001C80D4 File Offset: 0x001C62D4
		public unsafe string Label
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniParameter.__PropertyOffset_Label)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniParameter.__PropertyOffset_Label)), value);
			}
		}

		// Token: 0x17004B98 RID: 19352
		// (get) Token: 0x06013624 RID: 79396 RVA: 0x001C80E9 File Offset: 0x001C62E9
		// (set) Token: 0x06013625 RID: 79397 RVA: 0x001C80F9 File Offset: 0x001C62F9
		public unsafe EHoudiniParameterType ParmType
		{
			get
			{
				return (EHoudiniParameterType)(*(base.NativePtr + (IntPtr)UHoudiniParameter.__PropertyOffset_ParmType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameter.__PropertyOffset_ParmType) = (byte)value;
			}
		}

		// Token: 0x17004B99 RID: 19353
		// (get) Token: 0x06013626 RID: 79398 RVA: 0x001C810A File Offset: 0x001C630A
		// (set) Token: 0x06013627 RID: 79399 RVA: 0x001C811A File Offset: 0x001C631A
		public unsafe uint TupleSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameter.__PropertyOffset_TupleSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameter.__PropertyOffset_TupleSize) = (int)value;
			}
		}

		// Token: 0x17004B9A RID: 19354
		// (get) Token: 0x06013628 RID: 79400 RVA: 0x001C812B File Offset: 0x001C632B
		// (set) Token: 0x06013629 RID: 79401 RVA: 0x001C813B File Offset: 0x001C633B
		public unsafe int NodeId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameter.__PropertyOffset_NodeId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameter.__PropertyOffset_NodeId) = value;
			}
		}

		// Token: 0x17004B9B RID: 19355
		// (get) Token: 0x0601362A RID: 79402 RVA: 0x001C814C File Offset: 0x001C634C
		// (set) Token: 0x0601362B RID: 79403 RVA: 0x001C815C File Offset: 0x001C635C
		public unsafe int ParmId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameter.__PropertyOffset_ParmId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameter.__PropertyOffset_ParmId) = value;
			}
		}

		// Token: 0x17004B9C RID: 19356
		// (get) Token: 0x0601362C RID: 79404 RVA: 0x001C816D File Offset: 0x001C636D
		// (set) Token: 0x0601362D RID: 79405 RVA: 0x001C817D File Offset: 0x001C637D
		public unsafe int ParentParmId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameter.__PropertyOffset_ParentParmId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameter.__PropertyOffset_ParentParmId) = value;
			}
		}

		// Token: 0x17004B9D RID: 19357
		// (get) Token: 0x0601362E RID: 79406 RVA: 0x001C818E File Offset: 0x001C638E
		// (set) Token: 0x0601362F RID: 79407 RVA: 0x001C819E File Offset: 0x001C639E
		public unsafe int ChildIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameter.__PropertyOffset_ChildIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameter.__PropertyOffset_ChildIndex) = value;
			}
		}

		// Token: 0x17004B9E RID: 19358
		// (get) Token: 0x06013630 RID: 79408 RVA: 0x001C81AF File Offset: 0x001C63AF
		// (set) Token: 0x06013631 RID: 79409 RVA: 0x001C81BF File Offset: 0x001C63BF
		public unsafe bool bIsVisible
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameter.__PropertyOffset_bIsVisible) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameter.__PropertyOffset_bIsVisible) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B9F RID: 19359
		// (get) Token: 0x06013632 RID: 79410 RVA: 0x001C81D0 File Offset: 0x001C63D0
		// (set) Token: 0x06013633 RID: 79411 RVA: 0x001C81E0 File Offset: 0x001C63E0
		public unsafe bool bIsParentFolderVisible
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameter.__PropertyOffset_bIsParentFolderVisible) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameter.__PropertyOffset_bIsParentFolderVisible) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004BA0 RID: 19360
		// (get) Token: 0x06013634 RID: 79412 RVA: 0x001C81F1 File Offset: 0x001C63F1
		// (set) Token: 0x06013635 RID: 79413 RVA: 0x001C8201 File Offset: 0x001C6401
		public unsafe bool bIsDisabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameter.__PropertyOffset_bIsDisabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameter.__PropertyOffset_bIsDisabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004BA1 RID: 19361
		// (get) Token: 0x06013636 RID: 79414 RVA: 0x001C8212 File Offset: 0x001C6412
		// (set) Token: 0x06013637 RID: 79415 RVA: 0x001C8222 File Offset: 0x001C6422
		public unsafe bool bHasChanged
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameter.__PropertyOffset_bHasChanged) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameter.__PropertyOffset_bHasChanged) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004BA2 RID: 19362
		// (get) Token: 0x06013638 RID: 79416 RVA: 0x001C8233 File Offset: 0x001C6433
		// (set) Token: 0x06013639 RID: 79417 RVA: 0x001C8243 File Offset: 0x001C6443
		public unsafe bool bNeedsToTriggerUpdate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameter.__PropertyOffset_bNeedsToTriggerUpdate) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameter.__PropertyOffset_bNeedsToTriggerUpdate) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004BA3 RID: 19363
		// (get) Token: 0x0601363A RID: 79418 RVA: 0x001C8254 File Offset: 0x001C6454
		// (set) Token: 0x0601363B RID: 79419 RVA: 0x001C8264 File Offset: 0x001C6464
		public unsafe bool bIsDefault
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameter.__PropertyOffset_bIsDefault) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameter.__PropertyOffset_bIsDefault) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004BA4 RID: 19364
		// (get) Token: 0x0601363C RID: 79420 RVA: 0x001C8275 File Offset: 0x001C6475
		// (set) Token: 0x0601363D RID: 79421 RVA: 0x001C8285 File Offset: 0x001C6485
		public unsafe bool bIsSpare
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameter.__PropertyOffset_bIsSpare) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameter.__PropertyOffset_bIsSpare) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004BA5 RID: 19365
		// (get) Token: 0x0601363E RID: 79422 RVA: 0x001C8296 File Offset: 0x001C6496
		// (set) Token: 0x0601363F RID: 79423 RVA: 0x001C82A6 File Offset: 0x001C64A6
		public unsafe bool bJoinNext
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameter.__PropertyOffset_bJoinNext) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameter.__PropertyOffset_bJoinNext) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004BA6 RID: 19366
		// (get) Token: 0x06013640 RID: 79424 RVA: 0x001C82B7 File Offset: 0x001C64B7
		// (set) Token: 0x06013641 RID: 79425 RVA: 0x001C82C7 File Offset: 0x001C64C7
		public unsafe bool bIsChildOfMultiParm
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameter.__PropertyOffset_bIsChildOfMultiParm) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameter.__PropertyOffset_bIsChildOfMultiParm) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004BA7 RID: 19367
		// (get) Token: 0x06013642 RID: 79426 RVA: 0x001C82D8 File Offset: 0x001C64D8
		// (set) Token: 0x06013643 RID: 79427 RVA: 0x001C82E8 File Offset: 0x001C64E8
		public unsafe bool bIsDirectChildOfMultiParm
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameter.__PropertyOffset_bIsDirectChildOfMultiParm) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameter.__PropertyOffset_bIsDirectChildOfMultiParm) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004BA8 RID: 19368
		// (get) Token: 0x06013644 RID: 79428 RVA: 0x001C82F9 File Offset: 0x001C64F9
		// (set) Token: 0x06013645 RID: 79429 RVA: 0x001C8309 File Offset: 0x001C6509
		public unsafe bool bPendingRevertToDefault
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameter.__PropertyOffset_bPendingRevertToDefault) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameter.__PropertyOffset_bPendingRevertToDefault) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004BA9 RID: 19369
		// (get) Token: 0x06013646 RID: 79430 RVA: 0x001C831C File Offset: 0x001C651C
		// (set) Token: 0x06013647 RID: 79431 RVA: 0x001C8355 File Offset: 0x001C6555
		public TArray<int> TuplePendingRevertToDefault
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._TuplePendingRevertToDefault) == null)
				{
					result = (this._TuplePendingRevertToDefault = new TArray<int>(base.NativePtr + (IntPtr)UHoudiniParameter.__PropertyOffset_TuplePendingRevertToDefault, this));
				}
				return result;
			}
			set
			{
				this.TuplePendingRevertToDefault.CopyAssign(value);
			}
		}

		// Token: 0x17004BAA RID: 19370
		// (get) Token: 0x06013648 RID: 79432 RVA: 0x001C8363 File Offset: 0x001C6563
		// (set) Token: 0x06013649 RID: 79433 RVA: 0x001C8377 File Offset: 0x001C6577
		public unsafe string Help
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniParameter.__PropertyOffset_Help)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniParameter.__PropertyOffset_Help)), value);
			}
		}

		// Token: 0x17004BAB RID: 19371
		// (get) Token: 0x0601364A RID: 79434 RVA: 0x001C838C File Offset: 0x001C658C
		// (set) Token: 0x0601364B RID: 79435 RVA: 0x001C839C File Offset: 0x001C659C
		public unsafe uint TagCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameter.__PropertyOffset_TagCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameter.__PropertyOffset_TagCount) = (int)value;
			}
		}

		// Token: 0x17004BAC RID: 19372
		// (get) Token: 0x0601364C RID: 79436 RVA: 0x001C83AD File Offset: 0x001C65AD
		// (set) Token: 0x0601364D RID: 79437 RVA: 0x001C83BD File Offset: 0x001C65BD
		public unsafe int ValueIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameter.__PropertyOffset_ValueIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameter.__PropertyOffset_ValueIndex) = value;
			}
		}

		// Token: 0x17004BAD RID: 19373
		// (get) Token: 0x0601364E RID: 79438 RVA: 0x001C83CE File Offset: 0x001C65CE
		// (set) Token: 0x0601364F RID: 79439 RVA: 0x001C83DE File Offset: 0x001C65DE
		public unsafe bool bHasExpression
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameter.__PropertyOffset_bHasExpression) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameter.__PropertyOffset_bHasExpression) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004BAE RID: 19374
		// (get) Token: 0x06013650 RID: 79440 RVA: 0x001C83EF File Offset: 0x001C65EF
		// (set) Token: 0x06013651 RID: 79441 RVA: 0x001C83FF File Offset: 0x001C65FF
		public unsafe bool bShowExpression
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameter.__PropertyOffset_bShowExpression) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameter.__PropertyOffset_bShowExpression) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004BAF RID: 19375
		// (get) Token: 0x06013652 RID: 79442 RVA: 0x001C8410 File Offset: 0x001C6610
		// (set) Token: 0x06013653 RID: 79443 RVA: 0x001C8424 File Offset: 0x001C6624
		public unsafe string ParamExpression
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniParameter.__PropertyOffset_ParamExpression)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniParameter.__PropertyOffset_ParamExpression)), value);
			}
		}

		// Token: 0x17004BB0 RID: 19376
		// (get) Token: 0x06013654 RID: 79444 RVA: 0x001C843C File Offset: 0x001C663C
		// (set) Token: 0x06013655 RID: 79445 RVA: 0x001C8475 File Offset: 0x001C6675
		public TMap<string, string> Tags
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, string> result;
				if ((result = this._Tags) == null)
				{
					result = (this._Tags = new TMap<string, string>(base.NativePtr + (IntPtr)UHoudiniParameter.__PropertyOffset_Tags, this));
				}
				return result;
			}
			set
			{
				this.Tags.CopyAssign(value);
			}
		}

		// Token: 0x17004BB1 RID: 19377
		// (get) Token: 0x06013656 RID: 79446 RVA: 0x001C8483 File Offset: 0x001C6683
		// (set) Token: 0x06013657 RID: 79447 RVA: 0x001C8493 File Offset: 0x001C6693
		public unsafe bool bAutoUpdate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameter.__PropertyOffset_bAutoUpdate) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameter.__PropertyOffset_bAutoUpdate) = (value ? 1 : 0);
			}
		}

		// Token: 0x06013658 RID: 79448 RVA: 0x001C84A4 File Offset: 0x001C66A4
		static UHoudiniParameter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniParameter");
		}

		// Token: 0x06013659 RID: 79449 RVA: 0x001C84B2 File Offset: 0x001C66B2
		protected UHoudiniParameter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A78B RID: 42891
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniParameter";

		// Token: 0x0400A78C RID: 42892
		private static IntPtr _ClassPtr;

		// Token: 0x0400A78D RID: 42893
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A78E RID: 42894
		internal static int __PropertyOffset_Name;

		// Token: 0x0400A78F RID: 42895
		internal static int __PropertyOffset_Label;

		// Token: 0x0400A790 RID: 42896
		internal static int __PropertyOffset_ParmType;

		// Token: 0x0400A791 RID: 42897
		internal static int __PropertyOffset_TupleSize;

		// Token: 0x0400A792 RID: 42898
		internal static int __PropertyOffset_NodeId;

		// Token: 0x0400A793 RID: 42899
		internal static int __PropertyOffset_ParmId;

		// Token: 0x0400A794 RID: 42900
		internal static int __PropertyOffset_ParentParmId;

		// Token: 0x0400A795 RID: 42901
		internal static int __PropertyOffset_ChildIndex;

		// Token: 0x0400A796 RID: 42902
		internal static int __PropertyOffset_bIsVisible;

		// Token: 0x0400A797 RID: 42903
		internal static int __PropertyOffset_bIsParentFolderVisible;

		// Token: 0x0400A798 RID: 42904
		internal static int __PropertyOffset_bIsDisabled;

		// Token: 0x0400A799 RID: 42905
		internal static int __PropertyOffset_bHasChanged;

		// Token: 0x0400A79A RID: 42906
		internal static int __PropertyOffset_bNeedsToTriggerUpdate;

		// Token: 0x0400A79B RID: 42907
		internal static int __PropertyOffset_bIsDefault;

		// Token: 0x0400A79C RID: 42908
		internal static int __PropertyOffset_bIsSpare;

		// Token: 0x0400A79D RID: 42909
		internal static int __PropertyOffset_bJoinNext;

		// Token: 0x0400A79E RID: 42910
		internal static int __PropertyOffset_bIsChildOfMultiParm;

		// Token: 0x0400A79F RID: 42911
		internal static int __PropertyOffset_bIsDirectChildOfMultiParm;

		// Token: 0x0400A7A0 RID: 42912
		internal static int __PropertyOffset_bPendingRevertToDefault;

		// Token: 0x0400A7A1 RID: 42913
		internal static int __PropertyOffset_TuplePendingRevertToDefault;

		// Token: 0x0400A7A2 RID: 42914
		[Nullable(2)]
		private TArray<int> _TuplePendingRevertToDefault;

		// Token: 0x0400A7A3 RID: 42915
		internal static int __PropertyOffset_Help;

		// Token: 0x0400A7A4 RID: 42916
		internal static int __PropertyOffset_TagCount;

		// Token: 0x0400A7A5 RID: 42917
		internal static int __PropertyOffset_ValueIndex;

		// Token: 0x0400A7A6 RID: 42918
		internal static int __PropertyOffset_bHasExpression;

		// Token: 0x0400A7A7 RID: 42919
		internal static int __PropertyOffset_bShowExpression;

		// Token: 0x0400A7A8 RID: 42920
		internal static int __PropertyOffset_ParamExpression;

		// Token: 0x0400A7A9 RID: 42921
		internal static int __PropertyOffset_Tags;

		// Token: 0x0400A7AA RID: 42922
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, string> _Tags;

		// Token: 0x0400A7AB RID: 42923
		internal static int __PropertyOffset_bAutoUpdate;
	}
}
