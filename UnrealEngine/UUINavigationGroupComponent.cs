using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200218A RID: 8586
	[UnrealObjectPath("/Script/LGUI.UINavigationGroupComponent")]
	[UnrealStructLayout(536, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 536)]
	public class UUINavigationGroupComponent : ULGUIBehaviour, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060208B8 RID: 133304 RVA: 0x00303195 File Offset: 0x00301395
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUINavigationGroupComponent._ClassPtr;
		}

		// Token: 0x060208B9 RID: 133305 RVA: 0x003031A4 File Offset: 0x003013A4
		public UUINavigationGroupComponent() : this(BuiltinUtils.AllocNativeUObject(UUINavigationGroupComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060208BA RID: 133306 RVA: 0x003031CC File Offset: 0x003013CC
		[NullableContext(1)]
		public UUINavigationGroupComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUINavigationGroupComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007F43 RID: 32579
		// (get) Token: 0x060208BB RID: 133307 RVA: 0x003031FF File Offset: 0x003013FF
		// (set) Token: 0x060208BC RID: 133308 RVA: 0x0030320F File Offset: 0x0030140F
		public unsafe UINavigationWrapMode HorizontalWrapMode
		{
			get
			{
				return (UINavigationWrapMode)(*(base.NativePtr + (IntPtr)UUINavigationGroupComponent.__PropertyOffset_HorizontalWrapMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUINavigationGroupComponent.__PropertyOffset_HorizontalWrapMode) = (byte)value;
			}
		}

		// Token: 0x17007F44 RID: 32580
		// (get) Token: 0x060208BD RID: 133309 RVA: 0x00303220 File Offset: 0x00301420
		// (set) Token: 0x060208BE RID: 133310 RVA: 0x00303230 File Offset: 0x00301430
		public unsafe UINavigationPriorityMode HorizontalPriorityMode
		{
			get
			{
				return (UINavigationPriorityMode)(*(base.NativePtr + (IntPtr)UUINavigationGroupComponent.__PropertyOffset_HorizontalPriorityMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUINavigationGroupComponent.__PropertyOffset_HorizontalPriorityMode) = (byte)value;
			}
		}

		// Token: 0x17007F45 RID: 32581
		// (get) Token: 0x060208BF RID: 133311 RVA: 0x00303241 File Offset: 0x00301441
		// (set) Token: 0x060208C0 RID: 133312 RVA: 0x00303251 File Offset: 0x00301451
		public unsafe UINavigationWrapMode VerticalWrapMode
		{
			get
			{
				return (UINavigationWrapMode)(*(base.NativePtr + (IntPtr)UUINavigationGroupComponent.__PropertyOffset_VerticalWrapMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUINavigationGroupComponent.__PropertyOffset_VerticalWrapMode) = (byte)value;
			}
		}

		// Token: 0x17007F46 RID: 32582
		// (get) Token: 0x060208C1 RID: 133313 RVA: 0x00303262 File Offset: 0x00301462
		// (set) Token: 0x060208C2 RID: 133314 RVA: 0x00303272 File Offset: 0x00301472
		public unsafe UINavigationPriorityMode VerticalPriorityMode
		{
			get
			{
				return (UINavigationPriorityMode)(*(base.NativePtr + (IntPtr)UUINavigationGroupComponent.__PropertyOffset_VerticalPriorityMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUINavigationGroupComponent.__PropertyOffset_VerticalPriorityMode) = (byte)value;
			}
		}

		// Token: 0x17007F47 RID: 32583
		// (get) Token: 0x060208C3 RID: 133315 RVA: 0x00303283 File Offset: 0x00301483
		// (set) Token: 0x060208C4 RID: 133316 RVA: 0x00303297 File Offset: 0x00301497
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<AActor> PrevNavigationGroupActor
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUINavigationGroupComponent.__PropertyOffset_PrevNavigationGroupActor);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUINavigationGroupComponent.__PropertyOffset_PrevNavigationGroupActor) = value;
			}
		}

		// Token: 0x17007F48 RID: 32584
		// (get) Token: 0x060208C5 RID: 133317 RVA: 0x003032AC File Offset: 0x003014AC
		// (set) Token: 0x060208C6 RID: 133318 RVA: 0x003032C0 File Offset: 0x003014C0
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UUINavigationGroupComponent> PrevNavigationGroup
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUINavigationGroupComponent.__PropertyOffset_PrevNavigationGroup);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUINavigationGroupComponent.__PropertyOffset_PrevNavigationGroup) = value;
			}
		}

		// Token: 0x17007F49 RID: 32585
		// (get) Token: 0x060208C7 RID: 133319 RVA: 0x003032D5 File Offset: 0x003014D5
		// (set) Token: 0x060208C8 RID: 133320 RVA: 0x003032E9 File Offset: 0x003014E9
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<AActor> NextNavigationGroupActor
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUINavigationGroupComponent.__PropertyOffset_NextNavigationGroupActor);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUINavigationGroupComponent.__PropertyOffset_NextNavigationGroupActor) = value;
			}
		}

		// Token: 0x17007F4A RID: 32586
		// (get) Token: 0x060208C9 RID: 133321 RVA: 0x003032FE File Offset: 0x003014FE
		// (set) Token: 0x060208CA RID: 133322 RVA: 0x00303312 File Offset: 0x00301512
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UUINavigationGroupComponent> NextNavigationGroup
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUINavigationGroupComponent.__PropertyOffset_NextNavigationGroup);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUINavigationGroupComponent.__PropertyOffset_NextNavigationGroup) = value;
			}
		}

		// Token: 0x17007F4B RID: 32587
		// (get) Token: 0x060208CB RID: 133323 RVA: 0x00303327 File Offset: 0x00301527
		// (set) Token: 0x060208CC RID: 133324 RVA: 0x0030333B File Offset: 0x0030153B
		public unsafe FName PrevNavigationGroupName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUINavigationGroupComponent.__PropertyOffset_PrevNavigationGroupName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUINavigationGroupComponent.__PropertyOffset_PrevNavigationGroupName) = value;
			}
		}

		// Token: 0x17007F4C RID: 32588
		// (get) Token: 0x060208CD RID: 133325 RVA: 0x00303350 File Offset: 0x00301550
		// (set) Token: 0x060208CE RID: 133326 RVA: 0x00303364 File Offset: 0x00301564
		public unsafe FName NextNavigationGroupName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUINavigationGroupComponent.__PropertyOffset_NextNavigationGroupName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUINavigationGroupComponent.__PropertyOffset_NextNavigationGroupName) = value;
			}
		}

		// Token: 0x17007F4D RID: 32589
		// (get) Token: 0x060208CF RID: 133327 RVA: 0x00303379 File Offset: 0x00301579
		// (set) Token: 0x060208D0 RID: 133328 RVA: 0x0030338D File Offset: 0x0030158D
		public unsafe FName NavigationGroupName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUINavigationGroupComponent.__PropertyOffset_NavigationGroupName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUINavigationGroupComponent.__PropertyOffset_NavigationGroupName) = value;
			}
		}

		// Token: 0x17007F4E RID: 32590
		// (get) Token: 0x060208D1 RID: 133329 RVA: 0x003033A4 File Offset: 0x003015A4
		// (set) Token: 0x060208D2 RID: 133330 RVA: 0x003033DD File Offset: 0x003015DD
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TArray<TWeakObjectPtr<AActor>> DefaultNavigateActors
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TWeakObjectPtr<AActor>> result;
				if ((result = this._DefaultNavigateActors) == null)
				{
					result = (this._DefaultNavigateActors = new TArray<TWeakObjectPtr<AActor>>(base.NativePtr + (IntPtr)UUINavigationGroupComponent.__PropertyOffset_DefaultNavigateActors, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.DefaultNavigateActors.CopyAssign(value);
			}
		}

		// Token: 0x17007F4F RID: 32591
		// (get) Token: 0x060208D3 RID: 133331 RVA: 0x003033EB File Offset: 0x003015EB
		// (set) Token: 0x060208D4 RID: 133332 RVA: 0x003033FB File Offset: 0x003015FB
		public unsafe bool BookMark
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUINavigationGroupComponent.__PropertyOffset_BookMark) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUINavigationGroupComponent.__PropertyOffset_BookMark) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007F50 RID: 32592
		// (get) Token: 0x060208D5 RID: 133333 RVA: 0x0030340C File Offset: 0x0030160C
		// (set) Token: 0x060208D6 RID: 133334 RVA: 0x0030341C File Offset: 0x0030161C
		public unsafe bool ScrollBall
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUINavigationGroupComponent.__PropertyOffset_ScrollBall) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUINavigationGroupComponent.__PropertyOffset_ScrollBall) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007F51 RID: 32593
		// (get) Token: 0x060208D7 RID: 133335 RVA: 0x0030342D File Offset: 0x0030162D
		// (set) Token: 0x060208D8 RID: 133336 RVA: 0x0030343D File Offset: 0x0030163D
		public unsafe bool MouseCanJump
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUINavigationGroupComponent.__PropertyOffset_MouseCanJump) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUINavigationGroupComponent.__PropertyOffset_MouseCanJump) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007F52 RID: 32594
		// (get) Token: 0x060208D9 RID: 133337 RVA: 0x0030344E File Offset: 0x0030164E
		// (set) Token: 0x060208DA RID: 133338 RVA: 0x0030345E File Offset: 0x0030165E
		public unsafe bool AutoSearch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUINavigationGroupComponent.__PropertyOffset_AutoSearch) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUINavigationGroupComponent.__PropertyOffset_AutoSearch) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007F53 RID: 32595
		// (get) Token: 0x060208DB RID: 133339 RVA: 0x0030346F File Offset: 0x0030166F
		// (set) Token: 0x060208DC RID: 133340 RVA: 0x0030347F File Offset: 0x0030167F
		public unsafe bool SelectableMemory
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUINavigationGroupComponent.__PropertyOffset_SelectableMemory) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUINavigationGroupComponent.__PropertyOffset_SelectableMemory) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007F54 RID: 32596
		// (get) Token: 0x060208DD RID: 133341 RVA: 0x00303490 File Offset: 0x00301690
		// (set) Token: 0x060208DE RID: 133342 RVA: 0x003034A0 File Offset: 0x003016A0
		public unsafe int ViewId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUINavigationGroupComponent.__PropertyOffset_ViewId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUINavigationGroupComponent.__PropertyOffset_ViewId) = value;
			}
		}

		// Token: 0x060208DF RID: 133343
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetNavigateTolerance(float Tolerance);

		// Token: 0x060208E0 RID: 133344 RVA: 0x003034B1 File Offset: 0x003016B1
		[NullableContext(2)]
		public static void SetNavigateGroupDelegate(in FLGUINavigateGroupDelegate Delegate)
		{
			FLGUINavigateGroupDelegate flguinavigateGroupDelegate = Delegate;
			UUINavigationGroupComponent.__SetNavigateGroupDelegate_Internal((flguinavigateGroupDelegate != null) ? flguinavigateGroupDelegate.NativePtr : ((IntPtr)0));
		}

		// Token: 0x060208E1 RID: 133345
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ResetNavigateGroupDelegate();

		// Token: 0x060208E2 RID: 133346 RVA: 0x003034C7 File Offset: 0x003016C7
		public void NavigateToPrevGroup()
		{
			UUINavigationGroupComponent.__NavigateToPrevGroup_Internal(base.NativePtr);
		}

		// Token: 0x060208E3 RID: 133347 RVA: 0x003034D4 File Offset: 0x003016D4
		public void NavigateToNextGroup()
		{
			UUINavigationGroupComponent.__NavigateToNextGroup_Internal(base.NativePtr);
		}

		// Token: 0x060208E4 RID: 133348 RVA: 0x003034E1 File Offset: 0x003016E1
		public void Navigate()
		{
			UUINavigationGroupComponent.__Navigate_Internal(base.NativePtr);
		}

		// Token: 0x060208E5 RID: 133349 RVA: 0x003034EE File Offset: 0x003016EE
		public void GetRootNavigationGrade([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UUISelectableComponent> Result)
		{
			UUINavigationGroupComponent.__GetRootNavigationGrade_Internal(base.NativePtr, (Result ?? new TArray<UUISelectableComponent>()).NativePtr);
		}

		// Token: 0x060208E6 RID: 133350
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNavigateGroupDelegate_Internal(IntPtr Delegate);

		// Token: 0x060208E7 RID: 133351
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __NavigateToPrevGroup_Internal(IntPtr @this);

		// Token: 0x060208E8 RID: 133352
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __NavigateToNextGroup_Internal(IntPtr @this);

		// Token: 0x060208E9 RID: 133353
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Navigate_Internal(IntPtr @this);

		// Token: 0x060208EA RID: 133354
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetRootNavigationGrade_Internal(IntPtr @this, IntPtr Result);

		// Token: 0x060208EB RID: 133355 RVA: 0x0030350B File Offset: 0x0030170B
		static UUINavigationGroupComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UINavigationGroupComponent");
		}

		// Token: 0x060208EC RID: 133356 RVA: 0x00303519 File Offset: 0x00301719
		protected UUINavigationGroupComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040116CA RID: 71370
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UINavigationGroupComponent";

		// Token: 0x040116CB RID: 71371
		private static IntPtr _ClassPtr;

		// Token: 0x040116CC RID: 71372
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040116CD RID: 71373
		internal static int __PropertyOffset_HorizontalWrapMode;

		// Token: 0x040116CE RID: 71374
		internal static int __PropertyOffset_HorizontalPriorityMode;

		// Token: 0x040116CF RID: 71375
		internal static int __PropertyOffset_VerticalWrapMode;

		// Token: 0x040116D0 RID: 71376
		internal static int __PropertyOffset_VerticalPriorityMode;

		// Token: 0x040116D1 RID: 71377
		internal static int __PropertyOffset_PrevNavigationGroupActor;

		// Token: 0x040116D2 RID: 71378
		internal static int __PropertyOffset_PrevNavigationGroup;

		// Token: 0x040116D3 RID: 71379
		internal static int __PropertyOffset_NextNavigationGroupActor;

		// Token: 0x040116D4 RID: 71380
		internal static int __PropertyOffset_NextNavigationGroup;

		// Token: 0x040116D5 RID: 71381
		internal static int __PropertyOffset_PrevNavigationGroupName;

		// Token: 0x040116D6 RID: 71382
		internal static int __PropertyOffset_NextNavigationGroupName;

		// Token: 0x040116D7 RID: 71383
		internal static int __PropertyOffset_NavigationGroupName;

		// Token: 0x040116D8 RID: 71384
		internal static int __PropertyOffset_DefaultNavigateActors;

		// Token: 0x040116D9 RID: 71385
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TWeakObjectPtr<AActor>> _DefaultNavigateActors;

		// Token: 0x040116DA RID: 71386
		internal static int __PropertyOffset_BookMark;

		// Token: 0x040116DB RID: 71387
		internal static int __PropertyOffset_ScrollBall;

		// Token: 0x040116DC RID: 71388
		internal static int __PropertyOffset_MouseCanJump;

		// Token: 0x040116DD RID: 71389
		internal static int __PropertyOffset_AutoSearch;

		// Token: 0x040116DE RID: 71390
		internal static int __PropertyOffset_SelectableMemory;

		// Token: 0x040116DF RID: 71391
		internal static int __PropertyOffset_ViewId;
	}
}
