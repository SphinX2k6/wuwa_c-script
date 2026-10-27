using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007EF RID: 2031
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AnimBlueprintGeneratedClass")]
	[UnrealStructLayout(2848, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2848)]
	public class UAnimBlueprintGeneratedClass : UBlueprintGeneratedClass, IUnrealUObject, IUnrealObject, IAnimClassInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06006C5C RID: 27740 RVA: 0x0009BD02 File Offset: 0x00099F02
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnimBlueprintGeneratedClass._ClassPtr;
		}

		// Token: 0x06006C5D RID: 27741 RVA: 0x0009BD0E File Offset: 0x00099F0E
		int IAnimClassInterface.InterfaceOffset()
		{
			return UAnimBlueprintGeneratedClass.__InterfaceOffset_IAnimClassInterface;
		}

		// Token: 0x06006C5E RID: 27742 RVA: 0x0009BD18 File Offset: 0x00099F18
		public UAnimBlueprintGeneratedClass() : this(BuiltinUtils.AllocNativeUObject(UAnimBlueprintGeneratedClass.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006C5F RID: 27743 RVA: 0x0009BD40 File Offset: 0x00099F40
		public UAnimBlueprintGeneratedClass(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAnimBlueprintGeneratedClass.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001989 RID: 6537
		// (get) Token: 0x06006C60 RID: 27744 RVA: 0x0009BD74 File Offset: 0x00099F74
		// (set) Token: 0x06006C61 RID: 27745 RVA: 0x0009BDAD File Offset: 0x00099FAD
		public TArray<FBakedAnimationStateMachine> BakedStateMachines
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBakedAnimationStateMachine> result;
				if ((result = this._BakedStateMachines) == null)
				{
					result = (this._BakedStateMachines = new TArray<FBakedAnimationStateMachine>(base.NativePtr + (IntPtr)UAnimBlueprintGeneratedClass.__PropertyOffset_BakedStateMachines, this));
				}
				return result;
			}
			set
			{
				this.BakedStateMachines.CopyAssign(value);
			}
		}

		// Token: 0x1700198A RID: 6538
		// (get) Token: 0x06006C62 RID: 27746 RVA: 0x0009BDBB File Offset: 0x00099FBB
		// (set) Token: 0x06006C63 RID: 27747 RVA: 0x0009BDCF File Offset: 0x00099FCF
		[Nullable(2)]
		public unsafe USkeleton TargetSkeleton
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeleton>(base.NativePtr / (IntPtr)sizeof(void*) + UAnimBlueprintGeneratedClass.__PropertyOffset_TargetSkeleton);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAnimBlueprintGeneratedClass.__PropertyOffset_TargetSkeleton, value);
			}
		}

		// Token: 0x1700198B RID: 6539
		// (get) Token: 0x06006C64 RID: 27748 RVA: 0x0009BDE4 File Offset: 0x00099FE4
		// (set) Token: 0x06006C65 RID: 27749 RVA: 0x0009BE1D File Offset: 0x0009A01D
		public TArray<FAnimNotifyEvent> AnimNotifies
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FAnimNotifyEvent> result;
				if ((result = this._AnimNotifies) == null)
				{
					result = (this._AnimNotifies = new TArray<FAnimNotifyEvent>(base.NativePtr + (IntPtr)UAnimBlueprintGeneratedClass.__PropertyOffset_AnimNotifies, this));
				}
				return result;
			}
			set
			{
				this.AnimNotifies.CopyAssign(value);
			}
		}

		// Token: 0x1700198C RID: 6540
		// (get) Token: 0x06006C66 RID: 27750 RVA: 0x0009BE2C File Offset: 0x0009A02C
		// (set) Token: 0x06006C67 RID: 27751 RVA: 0x0009BE65 File Offset: 0x0009A065
		public TMap<FName, FCachedPoseIndices> OrderedSavedPoseIndicesMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FCachedPoseIndices> result;
				if ((result = this._OrderedSavedPoseIndicesMap) == null)
				{
					result = (this._OrderedSavedPoseIndicesMap = new TMap<FName, FCachedPoseIndices>(base.NativePtr + (IntPtr)UAnimBlueprintGeneratedClass.__PropertyOffset_OrderedSavedPoseIndicesMap, this));
				}
				return result;
			}
			set
			{
				this.OrderedSavedPoseIndicesMap.CopyAssign(value);
			}
		}

		// Token: 0x1700198D RID: 6541
		// (get) Token: 0x06006C68 RID: 27752 RVA: 0x0009BE74 File Offset: 0x0009A074
		// (set) Token: 0x06006C69 RID: 27753 RVA: 0x0009BEAD File Offset: 0x0009A0AD
		public TArray<FName> SyncGroupNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._SyncGroupNames) == null)
				{
					result = (this._SyncGroupNames = new TArray<FName>(base.NativePtr + (IntPtr)UAnimBlueprintGeneratedClass.__PropertyOffset_SyncGroupNames, this));
				}
				return result;
			}
			set
			{
				this.SyncGroupNames.CopyAssign(value);
			}
		}

		// Token: 0x1700198E RID: 6542
		// (get) Token: 0x06006C6A RID: 27754 RVA: 0x0009BEBC File Offset: 0x0009A0BC
		// (set) Token: 0x06006C6B RID: 27755 RVA: 0x0009BEF5 File Offset: 0x0009A0F5
		public TArray<FExposedValueHandler> EvaluateGraphExposedInputs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FExposedValueHandler> result;
				if ((result = this._EvaluateGraphExposedInputs) == null)
				{
					result = (this._EvaluateGraphExposedInputs = new TArray<FExposedValueHandler>(base.NativePtr + (IntPtr)UAnimBlueprintGeneratedClass.__PropertyOffset_EvaluateGraphExposedInputs, this));
				}
				return result;
			}
			set
			{
				this.EvaluateGraphExposedInputs.CopyAssign(value);
			}
		}

		// Token: 0x1700198F RID: 6543
		// (get) Token: 0x06006C6C RID: 27756 RVA: 0x0009BF04 File Offset: 0x0009A104
		// (set) Token: 0x06006C6D RID: 27757 RVA: 0x0009BF3D File Offset: 0x0009A13D
		public TMap<FName, FGraphAssetPlayerInformation> GraphAssetPlayerInformation
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FGraphAssetPlayerInformation> result;
				if ((result = this._GraphAssetPlayerInformation) == null)
				{
					result = (this._GraphAssetPlayerInformation = new TMap<FName, FGraphAssetPlayerInformation>(base.NativePtr + (IntPtr)UAnimBlueprintGeneratedClass.__PropertyOffset_GraphAssetPlayerInformation, this));
				}
				return result;
			}
			set
			{
				this.GraphAssetPlayerInformation.CopyAssign(value);
			}
		}

		// Token: 0x17001990 RID: 6544
		// (get) Token: 0x06006C6E RID: 27758 RVA: 0x0009BF4C File Offset: 0x0009A14C
		// (set) Token: 0x06006C6F RID: 27759 RVA: 0x0009BF85 File Offset: 0x0009A185
		public TMap<FName, FAnimGraphBlendOptions> GraphBlendOptions
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FAnimGraphBlendOptions> result;
				if ((result = this._GraphBlendOptions) == null)
				{
					result = (this._GraphBlendOptions = new TMap<FName, FAnimGraphBlendOptions>(base.NativePtr + (IntPtr)UAnimBlueprintGeneratedClass.__PropertyOffset_GraphBlendOptions, this));
				}
				return result;
			}
			set
			{
				this.GraphBlendOptions.CopyAssign(value);
			}
		}

		// Token: 0x17001991 RID: 6545
		// (get) Token: 0x06006C70 RID: 27760 RVA: 0x0009BF93 File Offset: 0x0009A193
		// (set) Token: 0x06006C71 RID: 27761 RVA: 0x0009BFA3 File Offset: 0x0009A1A3
		public unsafe bool bKuroOverrideAnimGraphInChildAnimClass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimBlueprintGeneratedClass.__PropertyOffset_bKuroOverrideAnimGraphInChildAnimClass) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimBlueprintGeneratedClass.__PropertyOffset_bKuroOverrideAnimGraphInChildAnimClass) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001992 RID: 6546
		// (get) Token: 0x06006C72 RID: 27762 RVA: 0x0009BFB4 File Offset: 0x0009A1B4
		// (set) Token: 0x06006C73 RID: 27763 RVA: 0x0009BFC8 File Offset: 0x0009A1C8
		public unsafe UClassStackOnlyPtr KuroOverrideAnimGraphParentClass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimBlueprintGeneratedClass.__PropertyOffset_KuroOverrideAnimGraphParentClass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimBlueprintGeneratedClass.__PropertyOffset_KuroOverrideAnimGraphParentClass) = value;
			}
		}

		// Token: 0x17001993 RID: 6547
		// (get) Token: 0x06006C74 RID: 27764 RVA: 0x0009BFE0 File Offset: 0x0009A1E0
		// (set) Token: 0x06006C75 RID: 27765 RVA: 0x0009C019 File Offset: 0x0009A219
		public FPropertyAccessLibrary PropertyAccessLibrary
		{
			get
			{
				base.FastCheckIsValid();
				FPropertyAccessLibrary result;
				if ((result = this._PropertyAccessLibrary) == null)
				{
					result = (this._PropertyAccessLibrary = new FPropertyAccessLibrary(base.NativePtr + (IntPtr)UAnimBlueprintGeneratedClass.__PropertyOffset_PropertyAccessLibrary, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPropertyAccessLibrary.StaticStruct(), base.NativePtr + (IntPtr)UAnimBlueprintGeneratedClass.__PropertyOffset_PropertyAccessLibrary, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06006C76 RID: 27766 RVA: 0x0009C03A File Offset: 0x0009A23A
		static UAnimBlueprintGeneratedClass()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AnimBlueprintGeneratedClass");
		}

		// Token: 0x06006C77 RID: 27767 RVA: 0x0009C048 File Offset: 0x0009A248
		protected UAnimBlueprintGeneratedClass(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003424 RID: 13348
		internal static int __InterfaceOffset_IAnimClassInterface;

		// Token: 0x04003425 RID: 13349
		public new const string __ObjectPath = "/Script/Engine.AnimBlueprintGeneratedClass";

		// Token: 0x04003426 RID: 13350
		private static IntPtr _ClassPtr;

		// Token: 0x04003427 RID: 13351
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003428 RID: 13352
		internal static int __PropertyOffset_BakedStateMachines;

		// Token: 0x04003429 RID: 13353
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBakedAnimationStateMachine> _BakedStateMachines;

		// Token: 0x0400342A RID: 13354
		internal static int __PropertyOffset_TargetSkeleton;

		// Token: 0x0400342B RID: 13355
		internal static int __PropertyOffset_AnimNotifies;

		// Token: 0x0400342C RID: 13356
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAnimNotifyEvent> _AnimNotifies;

		// Token: 0x0400342D RID: 13357
		internal static int __PropertyOffset_OrderedSavedPoseIndicesMap;

		// Token: 0x0400342E RID: 13358
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FCachedPoseIndices> _OrderedSavedPoseIndicesMap;

		// Token: 0x0400342F RID: 13359
		internal static int __PropertyOffset_SyncGroupNames;

		// Token: 0x04003430 RID: 13360
		[Nullable(2)]
		private TArray<FName> _SyncGroupNames;

		// Token: 0x04003431 RID: 13361
		internal static int __PropertyOffset_EvaluateGraphExposedInputs;

		// Token: 0x04003432 RID: 13362
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FExposedValueHandler> _EvaluateGraphExposedInputs;

		// Token: 0x04003433 RID: 13363
		internal static int __PropertyOffset_GraphAssetPlayerInformation;

		// Token: 0x04003434 RID: 13364
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FGraphAssetPlayerInformation> _GraphAssetPlayerInformation;

		// Token: 0x04003435 RID: 13365
		internal static int __PropertyOffset_GraphBlendOptions;

		// Token: 0x04003436 RID: 13366
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FAnimGraphBlendOptions> _GraphBlendOptions;

		// Token: 0x04003437 RID: 13367
		internal static int __PropertyOffset_bKuroOverrideAnimGraphInChildAnimClass;

		// Token: 0x04003438 RID: 13368
		internal static int __PropertyOffset_KuroOverrideAnimGraphParentClass;

		// Token: 0x04003439 RID: 13369
		internal static int __PropertyOffset_PropertyAccessLibrary;

		// Token: 0x0400343A RID: 13370
		[Nullable(2)]
		private FPropertyAccessLibrary _PropertyAccessLibrary;
	}
}
