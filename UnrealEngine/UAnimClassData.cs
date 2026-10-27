using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007F2 RID: 2034
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AnimClassData")]
	[UnrealStructLayout(824, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 824)]
	public class UAnimClassData : UObject, IUnrealUObject, IUnrealObject, IAnimClassInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06006C85 RID: 27781 RVA: 0x0009C18E File Offset: 0x0009A38E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnimClassData._ClassPtr;
		}

		// Token: 0x06006C86 RID: 27782 RVA: 0x0009C19A File Offset: 0x0009A39A
		int IAnimClassInterface.InterfaceOffset()
		{
			return UAnimClassData.__InterfaceOffset_IAnimClassInterface;
		}

		// Token: 0x06006C87 RID: 27783 RVA: 0x0009C1A4 File Offset: 0x0009A3A4
		public UAnimClassData() : this(BuiltinUtils.AllocNativeUObject(UAnimClassData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006C88 RID: 27784 RVA: 0x0009C1CC File Offset: 0x0009A3CC
		public UAnimClassData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAnimClassData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001996 RID: 6550
		// (get) Token: 0x06006C89 RID: 27785 RVA: 0x0009C200 File Offset: 0x0009A400
		// (set) Token: 0x06006C8A RID: 27786 RVA: 0x0009C239 File Offset: 0x0009A439
		public TArray<FBakedAnimationStateMachine> BakedStateMachines
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBakedAnimationStateMachine> result;
				if ((result = this._BakedStateMachines) == null)
				{
					result = (this._BakedStateMachines = new TArray<FBakedAnimationStateMachine>(base.NativePtr + (IntPtr)UAnimClassData.__PropertyOffset_BakedStateMachines, this));
				}
				return result;
			}
			set
			{
				this.BakedStateMachines.CopyAssign(value);
			}
		}

		// Token: 0x17001997 RID: 6551
		// (get) Token: 0x06006C8B RID: 27787 RVA: 0x0009C247 File Offset: 0x0009A447
		// (set) Token: 0x06006C8C RID: 27788 RVA: 0x0009C25B File Offset: 0x0009A45B
		[Nullable(2)]
		public unsafe USkeleton TargetSkeleton
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeleton>(base.NativePtr / (IntPtr)sizeof(void*) + UAnimClassData.__PropertyOffset_TargetSkeleton);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAnimClassData.__PropertyOffset_TargetSkeleton, value);
			}
		}

		// Token: 0x17001998 RID: 6552
		// (get) Token: 0x06006C8D RID: 27789 RVA: 0x0009C270 File Offset: 0x0009A470
		// (set) Token: 0x06006C8E RID: 27790 RVA: 0x0009C2A9 File Offset: 0x0009A4A9
		public TArray<FAnimNotifyEvent> AnimNotifies
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FAnimNotifyEvent> result;
				if ((result = this._AnimNotifies) == null)
				{
					result = (this._AnimNotifies = new TArray<FAnimNotifyEvent>(base.NativePtr + (IntPtr)UAnimClassData.__PropertyOffset_AnimNotifies, this));
				}
				return result;
			}
			set
			{
				this.AnimNotifies.CopyAssign(value);
			}
		}

		// Token: 0x17001999 RID: 6553
		// (get) Token: 0x06006C8F RID: 27791 RVA: 0x0009C2B8 File Offset: 0x0009A4B8
		// (set) Token: 0x06006C90 RID: 27792 RVA: 0x0009C2F1 File Offset: 0x0009A4F1
		public TMap<FName, FCachedPoseIndices> OrderedSavedPoseIndicesMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FCachedPoseIndices> result;
				if ((result = this._OrderedSavedPoseIndicesMap) == null)
				{
					result = (this._OrderedSavedPoseIndicesMap = new TMap<FName, FCachedPoseIndices>(base.NativePtr + (IntPtr)UAnimClassData.__PropertyOffset_OrderedSavedPoseIndicesMap, this));
				}
				return result;
			}
			set
			{
				this.OrderedSavedPoseIndicesMap.CopyAssign(value);
			}
		}

		// Token: 0x1700199A RID: 6554
		// (get) Token: 0x06006C91 RID: 27793 RVA: 0x0009C300 File Offset: 0x0009A500
		// (set) Token: 0x06006C92 RID: 27794 RVA: 0x0009C339 File Offset: 0x0009A539
		public TArray<FAnimBlueprintFunction> AnimBlueprintFunctions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FAnimBlueprintFunction> result;
				if ((result = this._AnimBlueprintFunctions) == null)
				{
					result = (this._AnimBlueprintFunctions = new TArray<FAnimBlueprintFunction>(base.NativePtr + (IntPtr)UAnimClassData.__PropertyOffset_AnimBlueprintFunctions, this));
				}
				return result;
			}
			set
			{
				this.AnimBlueprintFunctions.CopyAssign(value);
			}
		}

		// Token: 0x1700199B RID: 6555
		// (get) Token: 0x06006C93 RID: 27795 RVA: 0x0009C348 File Offset: 0x0009A548
		// (set) Token: 0x06006C94 RID: 27796 RVA: 0x0009C381 File Offset: 0x0009A581
		public TArray<FAnimBlueprintFunctionData> AnimBlueprintFunctionData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FAnimBlueprintFunctionData> result;
				if ((result = this._AnimBlueprintFunctionData) == null)
				{
					result = (this._AnimBlueprintFunctionData = new TArray<FAnimBlueprintFunctionData>(base.NativePtr + (IntPtr)UAnimClassData.__PropertyOffset_AnimBlueprintFunctionData, this));
				}
				return result;
			}
			set
			{
				this.AnimBlueprintFunctionData.CopyAssign(value);
			}
		}

		// Token: 0x1700199C RID: 6556
		// (get) Token: 0x06006C95 RID: 27797 RVA: 0x0009C390 File Offset: 0x0009A590
		// (set) Token: 0x06006C96 RID: 27798 RVA: 0x0009C3C9 File Offset: 0x0009A5C9
		public TArray<Unusable> AnimNodeProperties
		{
			get
			{
				base.FastCheckIsValid();
				TArray<Unusable> result;
				if ((result = this._AnimNodeProperties) == null)
				{
					result = (this._AnimNodeProperties = new TArray<Unusable>(base.NativePtr + (IntPtr)UAnimClassData.__PropertyOffset_AnimNodeProperties, this));
				}
				return result;
			}
			set
			{
				this.AnimNodeProperties.CopyAssign(value);
			}
		}

		// Token: 0x1700199D RID: 6557
		// (get) Token: 0x06006C97 RID: 27799 RVA: 0x0009C3D8 File Offset: 0x0009A5D8
		// (set) Token: 0x06006C98 RID: 27800 RVA: 0x0009C411 File Offset: 0x0009A611
		public TArray<Unusable> LinkedAnimGraphNodeProperties
		{
			get
			{
				base.FastCheckIsValid();
				TArray<Unusable> result;
				if ((result = this._LinkedAnimGraphNodeProperties) == null)
				{
					result = (this._LinkedAnimGraphNodeProperties = new TArray<Unusable>(base.NativePtr + (IntPtr)UAnimClassData.__PropertyOffset_LinkedAnimGraphNodeProperties, this));
				}
				return result;
			}
			set
			{
				this.LinkedAnimGraphNodeProperties.CopyAssign(value);
			}
		}

		// Token: 0x1700199E RID: 6558
		// (get) Token: 0x06006C99 RID: 27801 RVA: 0x0009C420 File Offset: 0x0009A620
		// (set) Token: 0x06006C9A RID: 27802 RVA: 0x0009C459 File Offset: 0x0009A659
		public TArray<Unusable> LinkedAnimLayerNodeProperties
		{
			get
			{
				base.FastCheckIsValid();
				TArray<Unusable> result;
				if ((result = this._LinkedAnimLayerNodeProperties) == null)
				{
					result = (this._LinkedAnimLayerNodeProperties = new TArray<Unusable>(base.NativePtr + (IntPtr)UAnimClassData.__PropertyOffset_LinkedAnimLayerNodeProperties, this));
				}
				return result;
			}
			set
			{
				this.LinkedAnimLayerNodeProperties.CopyAssign(value);
			}
		}

		// Token: 0x1700199F RID: 6559
		// (get) Token: 0x06006C9B RID: 27803 RVA: 0x0009C468 File Offset: 0x0009A668
		// (set) Token: 0x06006C9C RID: 27804 RVA: 0x0009C4A1 File Offset: 0x0009A6A1
		public TArray<Unusable> PreUpdateNodeProperties
		{
			get
			{
				base.FastCheckIsValid();
				TArray<Unusable> result;
				if ((result = this._PreUpdateNodeProperties) == null)
				{
					result = (this._PreUpdateNodeProperties = new TArray<Unusable>(base.NativePtr + (IntPtr)UAnimClassData.__PropertyOffset_PreUpdateNodeProperties, this));
				}
				return result;
			}
			set
			{
				this.PreUpdateNodeProperties.CopyAssign(value);
			}
		}

		// Token: 0x170019A0 RID: 6560
		// (get) Token: 0x06006C9D RID: 27805 RVA: 0x0009C4B0 File Offset: 0x0009A6B0
		// (set) Token: 0x06006C9E RID: 27806 RVA: 0x0009C4E9 File Offset: 0x0009A6E9
		public TArray<Unusable> DynamicResetNodeProperties
		{
			get
			{
				base.FastCheckIsValid();
				TArray<Unusable> result;
				if ((result = this._DynamicResetNodeProperties) == null)
				{
					result = (this._DynamicResetNodeProperties = new TArray<Unusable>(base.NativePtr + (IntPtr)UAnimClassData.__PropertyOffset_DynamicResetNodeProperties, this));
				}
				return result;
			}
			set
			{
				this.DynamicResetNodeProperties.CopyAssign(value);
			}
		}

		// Token: 0x170019A1 RID: 6561
		// (get) Token: 0x06006C9F RID: 27807 RVA: 0x0009C4F8 File Offset: 0x0009A6F8
		// (set) Token: 0x06006CA0 RID: 27808 RVA: 0x0009C531 File Offset: 0x0009A731
		public TArray<Unusable> StateMachineNodeProperties
		{
			get
			{
				base.FastCheckIsValid();
				TArray<Unusable> result;
				if ((result = this._StateMachineNodeProperties) == null)
				{
					result = (this._StateMachineNodeProperties = new TArray<Unusable>(base.NativePtr + (IntPtr)UAnimClassData.__PropertyOffset_StateMachineNodeProperties, this));
				}
				return result;
			}
			set
			{
				this.StateMachineNodeProperties.CopyAssign(value);
			}
		}

		// Token: 0x170019A2 RID: 6562
		// (get) Token: 0x06006CA1 RID: 27809 RVA: 0x0009C540 File Offset: 0x0009A740
		// (set) Token: 0x06006CA2 RID: 27810 RVA: 0x0009C579 File Offset: 0x0009A779
		public TArray<Unusable> InitializationNodeProperties
		{
			get
			{
				base.FastCheckIsValid();
				TArray<Unusable> result;
				if ((result = this._InitializationNodeProperties) == null)
				{
					result = (this._InitializationNodeProperties = new TArray<Unusable>(base.NativePtr + (IntPtr)UAnimClassData.__PropertyOffset_InitializationNodeProperties, this));
				}
				return result;
			}
			set
			{
				this.InitializationNodeProperties.CopyAssign(value);
			}
		}

		// Token: 0x170019A3 RID: 6563
		// (get) Token: 0x06006CA3 RID: 27811 RVA: 0x0009C588 File Offset: 0x0009A788
		// (set) Token: 0x06006CA4 RID: 27812 RVA: 0x0009C5C1 File Offset: 0x0009A7C1
		public TMap<FName, FGraphAssetPlayerInformation> GraphNameAssetPlayers
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FGraphAssetPlayerInformation> result;
				if ((result = this._GraphNameAssetPlayers) == null)
				{
					result = (this._GraphNameAssetPlayers = new TMap<FName, FGraphAssetPlayerInformation>(base.NativePtr + (IntPtr)UAnimClassData.__PropertyOffset_GraphNameAssetPlayers, this));
				}
				return result;
			}
			set
			{
				this.GraphNameAssetPlayers.CopyAssign(value);
			}
		}

		// Token: 0x170019A4 RID: 6564
		// (get) Token: 0x06006CA5 RID: 27813 RVA: 0x0009C5D0 File Offset: 0x0009A7D0
		// (set) Token: 0x06006CA6 RID: 27814 RVA: 0x0009C609 File Offset: 0x0009A809
		public TArray<FName> SyncGroupNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._SyncGroupNames) == null)
				{
					result = (this._SyncGroupNames = new TArray<FName>(base.NativePtr + (IntPtr)UAnimClassData.__PropertyOffset_SyncGroupNames, this));
				}
				return result;
			}
			set
			{
				this.SyncGroupNames.CopyAssign(value);
			}
		}

		// Token: 0x170019A5 RID: 6565
		// (get) Token: 0x06006CA7 RID: 27815 RVA: 0x0009C618 File Offset: 0x0009A818
		// (set) Token: 0x06006CA8 RID: 27816 RVA: 0x0009C651 File Offset: 0x0009A851
		public TArray<FExposedValueHandler> EvaluateGraphExposedInputs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FExposedValueHandler> result;
				if ((result = this._EvaluateGraphExposedInputs) == null)
				{
					result = (this._EvaluateGraphExposedInputs = new TArray<FExposedValueHandler>(base.NativePtr + (IntPtr)UAnimClassData.__PropertyOffset_EvaluateGraphExposedInputs, this));
				}
				return result;
			}
			set
			{
				this.EvaluateGraphExposedInputs.CopyAssign(value);
			}
		}

		// Token: 0x170019A6 RID: 6566
		// (get) Token: 0x06006CA9 RID: 27817 RVA: 0x0009C660 File Offset: 0x0009A860
		// (set) Token: 0x06006CAA RID: 27818 RVA: 0x0009C699 File Offset: 0x0009A899
		public TMap<FName, FAnimGraphBlendOptions> GraphBlendOptions
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FAnimGraphBlendOptions> result;
				if ((result = this._GraphBlendOptions) == null)
				{
					result = (this._GraphBlendOptions = new TMap<FName, FAnimGraphBlendOptions>(base.NativePtr + (IntPtr)UAnimClassData.__PropertyOffset_GraphBlendOptions, this));
				}
				return result;
			}
			set
			{
				this.GraphBlendOptions.CopyAssign(value);
			}
		}

		// Token: 0x170019A7 RID: 6567
		// (get) Token: 0x06006CAB RID: 27819 RVA: 0x0009C6A8 File Offset: 0x0009A8A8
		// (set) Token: 0x06006CAC RID: 27820 RVA: 0x0009C6E1 File Offset: 0x0009A8E1
		public FPropertyAccessLibrary PropertyAccessLibrary
		{
			get
			{
				base.FastCheckIsValid();
				FPropertyAccessLibrary result;
				if ((result = this._PropertyAccessLibrary) == null)
				{
					result = (this._PropertyAccessLibrary = new FPropertyAccessLibrary(base.NativePtr + (IntPtr)UAnimClassData.__PropertyOffset_PropertyAccessLibrary, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPropertyAccessLibrary.StaticStruct(), base.NativePtr + (IntPtr)UAnimClassData.__PropertyOffset_PropertyAccessLibrary, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06006CAD RID: 27821 RVA: 0x0009C702 File Offset: 0x0009A902
		static UAnimClassData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AnimClassData");
		}

		// Token: 0x06006CAE RID: 27822 RVA: 0x0009C710 File Offset: 0x0009A910
		protected UAnimClassData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003444 RID: 13380
		internal static int __InterfaceOffset_IAnimClassInterface;

		// Token: 0x04003445 RID: 13381
		public new const string __ObjectPath = "/Script/Engine.AnimClassData";

		// Token: 0x04003446 RID: 13382
		private static IntPtr _ClassPtr;

		// Token: 0x04003447 RID: 13383
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003448 RID: 13384
		internal static int __PropertyOffset_BakedStateMachines;

		// Token: 0x04003449 RID: 13385
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBakedAnimationStateMachine> _BakedStateMachines;

		// Token: 0x0400344A RID: 13386
		internal static int __PropertyOffset_TargetSkeleton;

		// Token: 0x0400344B RID: 13387
		internal static int __PropertyOffset_AnimNotifies;

		// Token: 0x0400344C RID: 13388
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAnimNotifyEvent> _AnimNotifies;

		// Token: 0x0400344D RID: 13389
		internal static int __PropertyOffset_OrderedSavedPoseIndicesMap;

		// Token: 0x0400344E RID: 13390
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FCachedPoseIndices> _OrderedSavedPoseIndicesMap;

		// Token: 0x0400344F RID: 13391
		internal static int __PropertyOffset_AnimBlueprintFunctions;

		// Token: 0x04003450 RID: 13392
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAnimBlueprintFunction> _AnimBlueprintFunctions;

		// Token: 0x04003451 RID: 13393
		internal static int __PropertyOffset_AnimBlueprintFunctionData;

		// Token: 0x04003452 RID: 13394
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAnimBlueprintFunctionData> _AnimBlueprintFunctionData;

		// Token: 0x04003453 RID: 13395
		internal static int __PropertyOffset_AnimNodeProperties;

		// Token: 0x04003454 RID: 13396
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<Unusable> _AnimNodeProperties;

		// Token: 0x04003455 RID: 13397
		internal static int __PropertyOffset_LinkedAnimGraphNodeProperties;

		// Token: 0x04003456 RID: 13398
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<Unusable> _LinkedAnimGraphNodeProperties;

		// Token: 0x04003457 RID: 13399
		internal static int __PropertyOffset_LinkedAnimLayerNodeProperties;

		// Token: 0x04003458 RID: 13400
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<Unusable> _LinkedAnimLayerNodeProperties;

		// Token: 0x04003459 RID: 13401
		internal static int __PropertyOffset_PreUpdateNodeProperties;

		// Token: 0x0400345A RID: 13402
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<Unusable> _PreUpdateNodeProperties;

		// Token: 0x0400345B RID: 13403
		internal static int __PropertyOffset_DynamicResetNodeProperties;

		// Token: 0x0400345C RID: 13404
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<Unusable> _DynamicResetNodeProperties;

		// Token: 0x0400345D RID: 13405
		internal static int __PropertyOffset_StateMachineNodeProperties;

		// Token: 0x0400345E RID: 13406
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<Unusable> _StateMachineNodeProperties;

		// Token: 0x0400345F RID: 13407
		internal static int __PropertyOffset_InitializationNodeProperties;

		// Token: 0x04003460 RID: 13408
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<Unusable> _InitializationNodeProperties;

		// Token: 0x04003461 RID: 13409
		internal static int __PropertyOffset_GraphNameAssetPlayers;

		// Token: 0x04003462 RID: 13410
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FGraphAssetPlayerInformation> _GraphNameAssetPlayers;

		// Token: 0x04003463 RID: 13411
		internal static int __PropertyOffset_SyncGroupNames;

		// Token: 0x04003464 RID: 13412
		[Nullable(2)]
		private TArray<FName> _SyncGroupNames;

		// Token: 0x04003465 RID: 13413
		internal static int __PropertyOffset_EvaluateGraphExposedInputs;

		// Token: 0x04003466 RID: 13414
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FExposedValueHandler> _EvaluateGraphExposedInputs;

		// Token: 0x04003467 RID: 13415
		internal static int __PropertyOffset_GraphBlendOptions;

		// Token: 0x04003468 RID: 13416
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FAnimGraphBlendOptions> _GraphBlendOptions;

		// Token: 0x04003469 RID: 13417
		internal static int __PropertyOffset_PropertyAccessLibrary;

		// Token: 0x0400346A RID: 13418
		[Nullable(2)]
		private FPropertyAccessLibrary _PropertyAccessLibrary;
	}
}
