using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DCF RID: 7631
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_WorldBoundsRound")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UKSC_DA_WorldBoundsRound : UKSC_DA_WorldBounds, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D2BA RID: 119482 RVA: 0x002B18AC File Offset: 0x002AFAAC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_WorldBoundsRound._ClassPtr;
		}

		// Token: 0x0601D2BB RID: 119483 RVA: 0x002B18B8 File Offset: 0x002AFAB8
		public UKSC_DA_WorldBoundsRound() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_WorldBoundsRound.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D2BC RID: 119484 RVA: 0x002B18E0 File Offset: 0x002AFAE0
		[NullableContext(1)]
		public UKSC_DA_WorldBoundsRound(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_WorldBoundsRound.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170075DC RID: 30172
		// (get) Token: 0x0601D2BD RID: 119485 RVA: 0x002B1913 File Offset: 0x002AFB13
		// (set) Token: 0x0601D2BE RID: 119486 RVA: 0x002B1923 File Offset: 0x002AFB23
		public unsafe float WorldRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_WorldBoundsRound.__PropertyOffset_WorldRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_WorldBoundsRound.__PropertyOffset_WorldRadius) = value;
			}
		}

		// Token: 0x170075DD RID: 30173
		// (get) Token: 0x0601D2BF RID: 119487 RVA: 0x002B1934 File Offset: 0x002AFB34
		// (set) Token: 0x0601D2C0 RID: 119488 RVA: 0x002B1948 File Offset: 0x002AFB48
		public unsafe FVectorDouble WorldCenterOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_WorldBoundsRound.__PropertyOffset_WorldCenterOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_WorldBoundsRound.__PropertyOffset_WorldCenterOffset) = value;
			}
		}

		// Token: 0x0601D2C1 RID: 119489 RVA: 0x002B195D File Offset: 0x002AFB5D
		static UKSC_DA_WorldBoundsRound()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_WorldBoundsRound");
		}

		// Token: 0x0601D2C2 RID: 119490 RVA: 0x002B196B File Offset: 0x002AFB6B
		protected UKSC_DA_WorldBoundsRound(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FD68 RID: 64872
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_WorldBoundsRound";

		// Token: 0x0400FD69 RID: 64873
		private static IntPtr _ClassPtr;

		// Token: 0x0400FD6A RID: 64874
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FD6B RID: 64875
		internal static int __PropertyOffset_WorldRadius;

		// Token: 0x0400FD6C RID: 64876
		internal static int __PropertyOffset_WorldCenterOffset;
	}
}
