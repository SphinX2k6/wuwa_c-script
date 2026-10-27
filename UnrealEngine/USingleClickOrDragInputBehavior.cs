using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001595 RID: 5525
	[UnrealObjectPath("/Script/InteractiveToolsFramework.SingleClickOrDragInputBehavior")]
	[UnrealStructLayout(384, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 384)]
	public class USingleClickOrDragInputBehavior : UAnyButtonInputBehavior, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013ED3 RID: 81619 RVA: 0x001D42BF File Offset: 0x001D24BF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USingleClickOrDragInputBehavior._ClassPtr;
		}

		// Token: 0x06013ED4 RID: 81620 RVA: 0x001D42CC File Offset: 0x001D24CC
		public USingleClickOrDragInputBehavior() : this(BuiltinUtils.AllocNativeUObject(USingleClickOrDragInputBehavior.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013ED5 RID: 81621 RVA: 0x001D42F4 File Offset: 0x001D24F4
		[NullableContext(1)]
		public USingleClickOrDragInputBehavior(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USingleClickOrDragInputBehavior.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004E00 RID: 19968
		// (get) Token: 0x06013ED6 RID: 81622 RVA: 0x001D4327 File Offset: 0x001D2527
		// (set) Token: 0x06013ED7 RID: 81623 RVA: 0x001D4337 File Offset: 0x001D2537
		public unsafe bool bBeginDragIfClickTargetNotHit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USingleClickOrDragInputBehavior.__PropertyOffset_bBeginDragIfClickTargetNotHit) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USingleClickOrDragInputBehavior.__PropertyOffset_bBeginDragIfClickTargetNotHit) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004E01 RID: 19969
		// (get) Token: 0x06013ED8 RID: 81624 RVA: 0x001D4348 File Offset: 0x001D2548
		// (set) Token: 0x06013ED9 RID: 81625 RVA: 0x001D4358 File Offset: 0x001D2558
		public unsafe float ClickDistanceThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USingleClickOrDragInputBehavior.__PropertyOffset_ClickDistanceThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USingleClickOrDragInputBehavior.__PropertyOffset_ClickDistanceThreshold) = value;
			}
		}

		// Token: 0x06013EDA RID: 81626 RVA: 0x001D4369 File Offset: 0x001D2569
		static USingleClickOrDragInputBehavior()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.SingleClickOrDragInputBehavior");
		}

		// Token: 0x06013EDB RID: 81627 RVA: 0x001D4377 File Offset: 0x001D2577
		protected USingleClickOrDragInputBehavior(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AC90 RID: 44176
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.SingleClickOrDragInputBehavior";

		// Token: 0x0400AC91 RID: 44177
		private static IntPtr _ClassPtr;

		// Token: 0x0400AC92 RID: 44178
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400AC93 RID: 44179
		internal static int __PropertyOffset_bBeginDragIfClickTargetNotHit;

		// Token: 0x0400AC94 RID: 44180
		internal static int __PropertyOffset_ClickDistanceThreshold;
	}
}
