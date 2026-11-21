using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003ED RID: 1005
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.KuroGridLevelActor")]
	[UnrealStructLayout(1240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1240)]
	public class AKuroGridLevelActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060062D4 RID: 25300 RVA: 0x0008D3F0 File Offset: 0x0008B5F0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroGridLevelActor._ClassPtr;
		}

		// Token: 0x060062D5 RID: 25301 RVA: 0x0008D3FC File Offset: 0x0008B5FC
		public AKuroGridLevelActor() : this(BuiltinUtils.AllocNativeUObject(AKuroGridLevelActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060062D6 RID: 25302 RVA: 0x0008D424 File Offset: 0x0008B624
		public AKuroGridLevelActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroGridLevelActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170013F0 RID: 5104
		// (get) Token: 0x060062D7 RID: 25303 RVA: 0x0008D457 File Offset: 0x0008B657
		// (set) Token: 0x060062D8 RID: 25304 RVA: 0x0008D46C File Offset: 0x0008B66C
		public TSoftObjectPtr<UWorld> WorldAsset
		{
			get
			{
				return new TSoftObjectPtr<UWorld>(base.NativePtr + (IntPtr)AKuroGridLevelActor.__PropertyOffset_WorldAsset, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)AKuroGridLevelActor.__PropertyOffset_WorldAsset, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170013F1 RID: 5105
		// (get) Token: 0x060062D9 RID: 25305 RVA: 0x0008D491 File Offset: 0x0008B691
		// (set) Token: 0x060062DA RID: 25306 RVA: 0x0008D4A5 File Offset: 0x0008B6A5
		public unsafe FKuroBuildingGridCellVector GridSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGridLevelActor.__PropertyOffset_GridSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGridLevelActor.__PropertyOffset_GridSize) = value;
			}
		}

		// Token: 0x170013F2 RID: 5106
		// (get) Token: 0x060062DB RID: 25307 RVA: 0x0008D4BA File Offset: 0x0008B6BA
		// (set) Token: 0x060062DC RID: 25308 RVA: 0x0008D4CE File Offset: 0x0008B6CE
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<AKuroBuildingGrid> OccupiedGrid
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGridLevelActor.__PropertyOffset_OccupiedGrid);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGridLevelActor.__PropertyOffset_OccupiedGrid) = value;
			}
		}

		// Token: 0x170013F3 RID: 5107
		// (get) Token: 0x060062DD RID: 25309 RVA: 0x0008D4E3 File Offset: 0x0008B6E3
		// (set) Token: 0x060062DE RID: 25310 RVA: 0x0008D4F7 File Offset: 0x0008B6F7
		public unsafe FKuroBuildingGridCellVector OccupiedCoords
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGridLevelActor.__PropertyOffset_OccupiedCoords);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGridLevelActor.__PropertyOffset_OccupiedCoords) = value;
			}
		}

		// Token: 0x170013F4 RID: 5108
		// (get) Token: 0x060062DF RID: 25311 RVA: 0x0008D50C File Offset: 0x0008B70C
		// (set) Token: 0x060062E0 RID: 25312 RVA: 0x0008D51C File Offset: 0x0008B71C
		public unsafe float OccupiedDegree
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGridLevelActor.__PropertyOffset_OccupiedDegree);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGridLevelActor.__PropertyOffset_OccupiedDegree) = value;
			}
		}

		// Token: 0x060062E1 RID: 25313 RVA: 0x0008D52D File Offset: 0x0008B72D
		public bool SetState(FName StateName, float InPlayRate = 1f)
		{
			return AKuroGridLevelActor.__SetState_Internal(base.NativePtr, StateName, InPlayRate);
		}

		// Token: 0x060062E2 RID: 25314 RVA: 0x0008D53C File Offset: 0x0008B73C
		public bool SetLayerState(FName LayerName, FName StateName, float InPlayRate = 1f)
		{
			return AKuroGridLevelActor.__SetLayerState_Internal(base.NativePtr, LayerName, StateName, InPlayRate);
		}

		// Token: 0x060062E3 RID: 25315 RVA: 0x0008D54C File Offset: 0x0008B74C
		public void SetDirection(FVector Direction)
		{
			AKuroGridLevelActor.__SetDirection_Internal(base.NativePtr, Direction);
		}

		// Token: 0x060062E4 RID: 25316 RVA: 0x0008D55A File Offset: 0x0008B75A
		public virtual void OnLevelShown()
		{
			AKuroGridLevelActor.__OnLevelShown_Internal(base.NativePtr);
		}

		// Token: 0x060062E5 RID: 25317 RVA: 0x0008D567 File Offset: 0x0008B767
		protected virtual void OnLevelShown_Implementation()
		{
			AKuroGridLevelActor.__OnLevelShown_Implementation_Internal(base.NativePtr);
		}

		// Token: 0x060062E6 RID: 25318 RVA: 0x0008D574 File Offset: 0x0008B774
		public void OnLevelLoaded()
		{
			AKuroGridLevelActor.__OnLevelLoaded_Internal(base.NativePtr);
		}

		// Token: 0x060062E7 RID: 25319 RVA: 0x0008D581 File Offset: 0x0008B781
		public bool IsLevelShown()
		{
			return AKuroGridLevelActor.__IsLevelShown_Internal(base.NativePtr);
		}

		// Token: 0x060062E8 RID: 25320 RVA: 0x0008D58E File Offset: 0x0008B78E
		public bool IsLevelLoaded()
		{
			return AKuroGridLevelActor.__IsLevelLoaded_Internal(base.NativePtr);
		}

		// Token: 0x060062E9 RID: 25321 RVA: 0x0008D59B File Offset: 0x0008B79B
		public void Initialize(TSoftObjectPtr<UWorld> InWorldAsset, in FKuroBuildingGridCellVector InGridSize)
		{
			AKuroGridLevelActor.__Initialize_Internal(base.NativePtr, (InWorldAsset ?? new TSoftObjectPtr<UWorld>()).NativePtr, InGridSize);
		}

		// Token: 0x060062EA RID: 25322 RVA: 0x0008D5B8 File Offset: 0x0008B7B8
		public FName GetLayerState(FName LayerName)
		{
			return AKuroGridLevelActor.__GetLayerState_Internal(base.NativePtr, LayerName);
		}

		// Token: 0x060062EB RID: 25323 RVA: 0x0008D5C6 File Offset: 0x0008B7C6
		public FName GetCurrentState()
		{
			return AKuroGridLevelActor.__GetCurrentState_Internal(base.NativePtr);
		}

		// Token: 0x060062EC RID: 25324
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetState_Internal(IntPtr @this, FName StateName, float InPlayRate);

		// Token: 0x060062ED RID: 25325
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetLayerState_Internal(IntPtr @this, FName LayerName, FName StateName, float InPlayRate);

		// Token: 0x060062EE RID: 25326
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDirection_Internal(IntPtr @this, FVector Direction);

		// Token: 0x060062EF RID: 25327
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnLevelShown_Internal(IntPtr @this);

		// Token: 0x060062F0 RID: 25328
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnLevelShown_Implementation_Internal(IntPtr @this);

		// Token: 0x060062F1 RID: 25329
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnLevelLoaded_Internal(IntPtr @this);

		// Token: 0x060062F2 RID: 25330
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsLevelShown_Internal(IntPtr @this);

		// Token: 0x060062F3 RID: 25331
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsLevelLoaded_Internal(IntPtr @this);

		// Token: 0x060062F4 RID: 25332
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Initialize_Internal(IntPtr @this, IntPtr InWorldAsset, in FKuroBuildingGridCellVector InGridSize);

		// Token: 0x060062F5 RID: 25333
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FName __GetLayerState_Internal(IntPtr @this, FName LayerName);

		// Token: 0x060062F6 RID: 25334
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FName __GetCurrentState_Internal(IntPtr @this);

		// Token: 0x060062F7 RID: 25335 RVA: 0x0008D5D3 File Offset: 0x0008B7D3
		static AKuroGridLevelActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroGridLevelActor");
		}

		// Token: 0x060062F8 RID: 25336 RVA: 0x0008D5E1 File Offset: 0x0008B7E1
		protected AKuroGridLevelActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040029CB RID: 10699
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroGridLevelActor";

		// Token: 0x040029CC RID: 10700
		private static IntPtr _ClassPtr;

		// Token: 0x040029CD RID: 10701
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040029CE RID: 10702
		internal static int __PropertyOffset_WorldAsset;

		// Token: 0x040029CF RID: 10703
		internal static int __PropertyOffset_GridSize;

		// Token: 0x040029D0 RID: 10704
		internal static int __PropertyOffset_OccupiedGrid;

		// Token: 0x040029D1 RID: 10705
		internal static int __PropertyOffset_OccupiedCoords;

		// Token: 0x040029D2 RID: 10706
		internal static int __PropertyOffset_OccupiedDegree;
	}
}
