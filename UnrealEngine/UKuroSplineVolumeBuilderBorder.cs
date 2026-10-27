using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001912 RID: 6418
	[UnrealObjectPath("/Script/KuroGameplay.KuroSplineVolumeBuilderBorder")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UKuroSplineVolumeBuilderBorder : UKuroSplineVolumeBuilder, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06017D1B RID: 97563 RVA: 0x0022E2D5 File Offset: 0x0022C4D5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroSplineVolumeBuilderBorder._ClassPtr;
		}

		// Token: 0x06017D1C RID: 97564 RVA: 0x0022E2E4 File Offset: 0x0022C4E4
		public UKuroSplineVolumeBuilderBorder() : this(BuiltinUtils.AllocNativeUObject(UKuroSplineVolumeBuilderBorder.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017D1D RID: 97565 RVA: 0x0022E30C File Offset: 0x0022C50C
		[NullableContext(1)]
		public UKuroSplineVolumeBuilderBorder(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroSplineVolumeBuilderBorder.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005FC3 RID: 24515
		// (get) Token: 0x06017D1E RID: 97566 RVA: 0x0022E33F File Offset: 0x0022C53F
		// (set) Token: 0x06017D1F RID: 97567 RVA: 0x0022E34F File Offset: 0x0022C54F
		public unsafe float HalfBoundsWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroSplineVolumeBuilderBorder.__PropertyOffset_HalfBoundsWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSplineVolumeBuilderBorder.__PropertyOffset_HalfBoundsWidth) = value;
			}
		}

		// Token: 0x17005FC4 RID: 24516
		// (get) Token: 0x06017D20 RID: 97568 RVA: 0x0022E360 File Offset: 0x0022C560
		// (set) Token: 0x06017D21 RID: 97569 RVA: 0x0022E370 File Offset: 0x0022C570
		public unsafe float LowerBoundsHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroSplineVolumeBuilderBorder.__PropertyOffset_LowerBoundsHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSplineVolumeBuilderBorder.__PropertyOffset_LowerBoundsHeight) = value;
			}
		}

		// Token: 0x17005FC5 RID: 24517
		// (get) Token: 0x06017D22 RID: 97570 RVA: 0x0022E381 File Offset: 0x0022C581
		// (set) Token: 0x06017D23 RID: 97571 RVA: 0x0022E391 File Offset: 0x0022C591
		public unsafe float UpperBoundsHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroSplineVolumeBuilderBorder.__PropertyOffset_UpperBoundsHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSplineVolumeBuilderBorder.__PropertyOffset_UpperBoundsHeight) = value;
			}
		}

		// Token: 0x06017D24 RID: 97572 RVA: 0x0022E3A2 File Offset: 0x0022C5A2
		static UKuroSplineVolumeBuilderBorder()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroSplineVolumeBuilderBorder");
		}

		// Token: 0x06017D25 RID: 97573 RVA: 0x0022E3B0 File Offset: 0x0022C5B0
		protected UKuroSplineVolumeBuilderBorder(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CE92 RID: 52882
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroSplineVolumeBuilderBorder";

		// Token: 0x0400CE93 RID: 52883
		private static IntPtr _ClassPtr;

		// Token: 0x0400CE94 RID: 52884
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400CE95 RID: 52885
		internal static int __PropertyOffset_HalfBoundsWidth;

		// Token: 0x0400CE96 RID: 52886
		internal static int __PropertyOffset_LowerBoundsHeight;

		// Token: 0x0400CE97 RID: 52887
		internal static int __PropertyOffset_UpperBoundsHeight;
	}
}
