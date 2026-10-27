using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001594 RID: 5524
	[UnrealObjectPath("/Script/InteractiveToolsFramework.SingleClickInputBehavior")]
	[UnrealStructLayout(336, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 336)]
	public class USingleClickInputBehavior : UAnyButtonInputBehavior, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013ECC RID: 81612 RVA: 0x001D421E File Offset: 0x001D241E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USingleClickInputBehavior._ClassPtr;
		}

		// Token: 0x06013ECD RID: 81613 RVA: 0x001D422C File Offset: 0x001D242C
		public USingleClickInputBehavior() : this(BuiltinUtils.AllocNativeUObject(USingleClickInputBehavior.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013ECE RID: 81614 RVA: 0x001D4254 File Offset: 0x001D2454
		[NullableContext(1)]
		public USingleClickInputBehavior(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USingleClickInputBehavior.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004DFF RID: 19967
		// (get) Token: 0x06013ECF RID: 81615 RVA: 0x001D4287 File Offset: 0x001D2487
		// (set) Token: 0x06013ED0 RID: 81616 RVA: 0x001D4297 File Offset: 0x001D2497
		public unsafe bool HitTestOnRelease
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USingleClickInputBehavior.__PropertyOffset_HitTestOnRelease) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USingleClickInputBehavior.__PropertyOffset_HitTestOnRelease) = (value ? 1 : 0);
			}
		}

		// Token: 0x06013ED1 RID: 81617 RVA: 0x001D42A8 File Offset: 0x001D24A8
		static USingleClickInputBehavior()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.SingleClickInputBehavior");
		}

		// Token: 0x06013ED2 RID: 81618 RVA: 0x001D42B6 File Offset: 0x001D24B6
		protected USingleClickInputBehavior(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AC8C RID: 44172
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.SingleClickInputBehavior";

		// Token: 0x0400AC8D RID: 44173
		private static IntPtr _ClassPtr;

		// Token: 0x0400AC8E RID: 44174
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400AC8F RID: 44175
		internal static int __PropertyOffset_HitTestOnRelease;
	}
}
