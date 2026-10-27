using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001845 RID: 6213
	[UnrealObjectPath("/Script/KuroFauxPhysics.KuroFauxPhysicsRotateComponentBase")]
	[UnrealStructLayout(752, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 752)]
	public abstract class UKuroFauxPhysicsRotateComponentBase : UKuroFauxPhysicsComponentBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06016E79 RID: 93817 RVA: 0x00216CDA File Offset: 0x00214EDA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroFauxPhysicsRotateComponentBase._ClassPtr;
		}

		// Token: 0x17005C61 RID: 23649
		// (get) Token: 0x06016E7A RID: 93818 RVA: 0x00216CE6 File Offset: 0x00214EE6
		// (set) Token: 0x06016E7B RID: 93819 RVA: 0x00216CF6 File Offset: 0x00214EF6
		public unsafe float Friction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroFauxPhysicsRotateComponentBase.__PropertyOffset_Friction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFauxPhysicsRotateComponentBase.__PropertyOffset_Friction) = value;
			}
		}

		// Token: 0x17005C62 RID: 23650
		// (get) Token: 0x06016E7C RID: 93820 RVA: 0x00216D07 File Offset: 0x00214F07
		// (set) Token: 0x06016E7D RID: 93821 RVA: 0x00216D17 File Offset: 0x00214F17
		public unsafe float TorqueBounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroFauxPhysicsRotateComponentBase.__PropertyOffset_TorqueBounds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFauxPhysicsRotateComponentBase.__PropertyOffset_TorqueBounds) = value;
			}
		}

		// Token: 0x17005C63 RID: 23651
		// (get) Token: 0x06016E7E RID: 93822 RVA: 0x00216D28 File Offset: 0x00214F28
		// (set) Token: 0x06016E7F RID: 93823 RVA: 0x00216D38 File Offset: 0x00214F38
		public unsafe float ForceScalar
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroFauxPhysicsRotateComponentBase.__PropertyOffset_ForceScalar);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFauxPhysicsRotateComponentBase.__PropertyOffset_ForceScalar) = value;
			}
		}

		// Token: 0x17005C64 RID: 23652
		// (get) Token: 0x06016E80 RID: 93824 RVA: 0x00216D49 File Offset: 0x00214F49
		// (set) Token: 0x06016E81 RID: 93825 RVA: 0x00216D59 File Offset: 0x00214F59
		public unsafe float SpringStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroFauxPhysicsRotateComponentBase.__PropertyOffset_SpringStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFauxPhysicsRotateComponentBase.__PropertyOffset_SpringStrength) = value;
			}
		}

		// Token: 0x06016E82 RID: 93826 RVA: 0x00216D6A File Offset: 0x00214F6A
		static UKuroFauxPhysicsRotateComponentBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroFauxPhysics.KuroFauxPhysicsRotateComponentBase");
		}

		// Token: 0x06016E83 RID: 93827 RVA: 0x00216D78 File Offset: 0x00214F78
		protected UKuroFauxPhysicsRotateComponentBase() : this(BuiltinUtils.AllocNativeUObject(UKuroFauxPhysicsRotateComponentBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06016E84 RID: 93828 RVA: 0x00216DA0 File Offset: 0x00214FA0
		protected UKuroFauxPhysicsRotateComponentBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C726 RID: 50982
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroFauxPhysics.KuroFauxPhysicsRotateComponentBase";

		// Token: 0x0400C727 RID: 50983
		private static IntPtr _ClassPtr;

		// Token: 0x0400C728 RID: 50984
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C729 RID: 50985
		internal static int __PropertyOffset_Friction;

		// Token: 0x0400C72A RID: 50986
		internal static int __PropertyOffset_TorqueBounds;

		// Token: 0x0400C72B RID: 50987
		internal static int __PropertyOffset_ForceScalar;

		// Token: 0x0400C72C RID: 50988
		internal static int __PropertyOffset_SpringStrength;
	}
}
