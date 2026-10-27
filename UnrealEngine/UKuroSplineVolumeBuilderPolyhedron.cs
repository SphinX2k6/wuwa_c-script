using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001913 RID: 6419
	[UnrealObjectPath("/Script/KuroGameplay.KuroSplineVolumeBuilderPolyhedron")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class UKuroSplineVolumeBuilderPolyhedron : UKuroSplineVolumeBuilder, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06017D26 RID: 97574 RVA: 0x0022E3B9 File Offset: 0x0022C5B9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroSplineVolumeBuilderPolyhedron._ClassPtr;
		}

		// Token: 0x06017D27 RID: 97575 RVA: 0x0022E3C8 File Offset: 0x0022C5C8
		public UKuroSplineVolumeBuilderPolyhedron() : this(BuiltinUtils.AllocNativeUObject(UKuroSplineVolumeBuilderPolyhedron.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017D28 RID: 97576 RVA: 0x0022E3F0 File Offset: 0x0022C5F0
		[NullableContext(1)]
		public UKuroSplineVolumeBuilderPolyhedron(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroSplineVolumeBuilderPolyhedron.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005FC6 RID: 24518
		// (get) Token: 0x06017D29 RID: 97577 RVA: 0x0022E423 File Offset: 0x0022C623
		// (set) Token: 0x06017D2A RID: 97578 RVA: 0x0022E433 File Offset: 0x0022C633
		public unsafe float LowerBoundsHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroSplineVolumeBuilderPolyhedron.__PropertyOffset_LowerBoundsHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSplineVolumeBuilderPolyhedron.__PropertyOffset_LowerBoundsHeight) = value;
			}
		}

		// Token: 0x17005FC7 RID: 24519
		// (get) Token: 0x06017D2B RID: 97579 RVA: 0x0022E444 File Offset: 0x0022C644
		// (set) Token: 0x06017D2C RID: 97580 RVA: 0x0022E454 File Offset: 0x0022C654
		public unsafe float UpperBoundsHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroSplineVolumeBuilderPolyhedron.__PropertyOffset_UpperBoundsHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSplineVolumeBuilderPolyhedron.__PropertyOffset_UpperBoundsHeight) = value;
			}
		}

		// Token: 0x06017D2D RID: 97581 RVA: 0x0022E465 File Offset: 0x0022C665
		static UKuroSplineVolumeBuilderPolyhedron()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroSplineVolumeBuilderPolyhedron");
		}

		// Token: 0x06017D2E RID: 97582 RVA: 0x0022E473 File Offset: 0x0022C673
		protected UKuroSplineVolumeBuilderPolyhedron(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CE98 RID: 52888
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroSplineVolumeBuilderPolyhedron";

		// Token: 0x0400CE99 RID: 52889
		private static IntPtr _ClassPtr;

		// Token: 0x0400CE9A RID: 52890
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400CE9B RID: 52891
		internal static int __PropertyOffset_LowerBoundsHeight;

		// Token: 0x0400CE9C RID: 52892
		internal static int __PropertyOffset_UpperBoundsHeight;
	}
}
