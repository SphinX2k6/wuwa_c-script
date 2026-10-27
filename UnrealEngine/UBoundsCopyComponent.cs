using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020008E6 RID: 2278
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BoundsCopyComponent")]
	[UnrealStructLayout(320, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 320)]
	public class UBoundsCopyComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007CF5 RID: 31989 RVA: 0x000B32A9 File Offset: 0x000B14A9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBoundsCopyComponent._ClassPtr;
		}

		// Token: 0x06007CF6 RID: 31990 RVA: 0x000B32B8 File Offset: 0x000B14B8
		public UBoundsCopyComponent() : this(BuiltinUtils.AllocNativeUObject(UBoundsCopyComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007CF7 RID: 31991 RVA: 0x000B32E0 File Offset: 0x000B14E0
		public UBoundsCopyComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBoundsCopyComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001D57 RID: 7511
		// (get) Token: 0x06007CF8 RID: 31992 RVA: 0x000B3313 File Offset: 0x000B1513
		// (set) Token: 0x06007CF9 RID: 31993 RVA: 0x000B3328 File Offset: 0x000B1528
		public TSoftObjectPtr<AActor> BoundsSourceActor
		{
			get
			{
				return new TSoftObjectPtr<AActor>(base.NativePtr + (IntPtr)UBoundsCopyComponent.__PropertyOffset_BoundsSourceActor, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)UBoundsCopyComponent.__PropertyOffset_BoundsSourceActor, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17001D58 RID: 7512
		// (get) Token: 0x06007CFA RID: 31994 RVA: 0x000B334D File Offset: 0x000B154D
		// (set) Token: 0x06007CFB RID: 31995 RVA: 0x000B335D File Offset: 0x000B155D
		public unsafe bool bUseCollidingComponentsForSourceBounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBoundsCopyComponent.__PropertyOffset_bUseCollidingComponentsForSourceBounds) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBoundsCopyComponent.__PropertyOffset_bUseCollidingComponentsForSourceBounds) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001D59 RID: 7513
		// (get) Token: 0x06007CFC RID: 31996 RVA: 0x000B336E File Offset: 0x000B156E
		// (set) Token: 0x06007CFD RID: 31997 RVA: 0x000B337E File Offset: 0x000B157E
		public unsafe bool bKeepOwnBoundsScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBoundsCopyComponent.__PropertyOffset_bKeepOwnBoundsScale) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBoundsCopyComponent.__PropertyOffset_bKeepOwnBoundsScale) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001D5A RID: 7514
		// (get) Token: 0x06007CFE RID: 31998 RVA: 0x000B338F File Offset: 0x000B158F
		// (set) Token: 0x06007CFF RID: 31999 RVA: 0x000B339F File Offset: 0x000B159F
		public unsafe bool bUseCollidingComponentsForOwnBounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBoundsCopyComponent.__PropertyOffset_bUseCollidingComponentsForOwnBounds) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBoundsCopyComponent.__PropertyOffset_bUseCollidingComponentsForOwnBounds) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001D5B RID: 7515
		// (get) Token: 0x06007D00 RID: 32000 RVA: 0x000B33B0 File Offset: 0x000B15B0
		// (set) Token: 0x06007D01 RID: 32001 RVA: 0x000B33C4 File Offset: 0x000B15C4
		public unsafe FTransform PostTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBoundsCopyComponent.__PropertyOffset_PostTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBoundsCopyComponent.__PropertyOffset_PostTransform) = value;
			}
		}

		// Token: 0x17001D5C RID: 7516
		// (get) Token: 0x06007D02 RID: 32002 RVA: 0x000B33D9 File Offset: 0x000B15D9
		// (set) Token: 0x06007D03 RID: 32003 RVA: 0x000B33E9 File Offset: 0x000B15E9
		public unsafe bool bCopyXBounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBoundsCopyComponent.__PropertyOffset_bCopyXBounds) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBoundsCopyComponent.__PropertyOffset_bCopyXBounds) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001D5D RID: 7517
		// (get) Token: 0x06007D04 RID: 32004 RVA: 0x000B33FA File Offset: 0x000B15FA
		// (set) Token: 0x06007D05 RID: 32005 RVA: 0x000B340A File Offset: 0x000B160A
		public unsafe bool bCopyYBounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBoundsCopyComponent.__PropertyOffset_bCopyYBounds) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBoundsCopyComponent.__PropertyOffset_bCopyYBounds) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001D5E RID: 7518
		// (get) Token: 0x06007D06 RID: 32006 RVA: 0x000B341B File Offset: 0x000B161B
		// (set) Token: 0x06007D07 RID: 32007 RVA: 0x000B342B File Offset: 0x000B162B
		public unsafe bool bCopyZBounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBoundsCopyComponent.__PropertyOffset_bCopyZBounds) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBoundsCopyComponent.__PropertyOffset_bCopyZBounds) = (value ? 1 : 0);
			}
		}

		// Token: 0x06007D08 RID: 32008 RVA: 0x000B343C File Offset: 0x000B163C
		static UBoundsCopyComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.BoundsCopyComponent");
		}

		// Token: 0x06007D09 RID: 32009 RVA: 0x000B344A File Offset: 0x000B164A
		protected UBoundsCopyComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003BE4 RID: 15332
		public new const string __ObjectPath = "/Script/Engine.BoundsCopyComponent";

		// Token: 0x04003BE5 RID: 15333
		private static IntPtr _ClassPtr;

		// Token: 0x04003BE6 RID: 15334
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003BE7 RID: 15335
		internal static int __PropertyOffset_BoundsSourceActor;

		// Token: 0x04003BE8 RID: 15336
		internal static int __PropertyOffset_bUseCollidingComponentsForSourceBounds;

		// Token: 0x04003BE9 RID: 15337
		internal static int __PropertyOffset_bKeepOwnBoundsScale;

		// Token: 0x04003BEA RID: 15338
		internal static int __PropertyOffset_bUseCollidingComponentsForOwnBounds;

		// Token: 0x04003BEB RID: 15339
		internal static int __PropertyOffset_PostTransform;

		// Token: 0x04003BEC RID: 15340
		internal static int __PropertyOffset_bCopyXBounds;

		// Token: 0x04003BED RID: 15341
		internal static int __PropertyOffset_bCopyYBounds;

		// Token: 0x04003BEE RID: 15342
		internal static int __PropertyOffset_bCopyZBounds;
	}
}
