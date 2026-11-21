using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000389 RID: 905
	[UnrealObjectPath("/Script/KuroFauxPhysics.KuroFauxPhysicsRotateComponentBase")]
	[UnrealStructLayout(752, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 752)]
	public abstract class UKuroFauxPhysicsRotateComponentBase : UKuroFauxPhysicsComponentBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005AC3 RID: 23235 RVA: 0x0008033B File Offset: 0x0007E53B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroFauxPhysicsRotateComponentBase._ClassPtr;
		}

		// Token: 0x170011F4 RID: 4596
		// (get) Token: 0x06005AC4 RID: 23236 RVA: 0x00080347 File Offset: 0x0007E547
		// (set) Token: 0x06005AC5 RID: 23237 RVA: 0x00080357 File Offset: 0x0007E557
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

		// Token: 0x170011F5 RID: 4597
		// (get) Token: 0x06005AC6 RID: 23238 RVA: 0x00080368 File Offset: 0x0007E568
		// (set) Token: 0x06005AC7 RID: 23239 RVA: 0x00080378 File Offset: 0x0007E578
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

		// Token: 0x170011F6 RID: 4598
		// (get) Token: 0x06005AC8 RID: 23240 RVA: 0x00080389 File Offset: 0x0007E589
		// (set) Token: 0x06005AC9 RID: 23241 RVA: 0x00080399 File Offset: 0x0007E599
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

		// Token: 0x170011F7 RID: 4599
		// (get) Token: 0x06005ACA RID: 23242 RVA: 0x000803AA File Offset: 0x0007E5AA
		// (set) Token: 0x06005ACB RID: 23243 RVA: 0x000803BA File Offset: 0x0007E5BA
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

		// Token: 0x06005ACC RID: 23244 RVA: 0x000803CB File Offset: 0x0007E5CB
		static UKuroFauxPhysicsRotateComponentBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroFauxPhysics.KuroFauxPhysicsRotateComponentBase");
		}

		// Token: 0x06005ACD RID: 23245 RVA: 0x000803DC File Offset: 0x0007E5DC
		protected UKuroFauxPhysicsRotateComponentBase() : this(BuiltinUtils.AllocNativeUObject(UKuroFauxPhysicsRotateComponentBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005ACE RID: 23246 RVA: 0x00080404 File Offset: 0x0007E604
		protected UKuroFauxPhysicsRotateComponentBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040025B7 RID: 9655
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroFauxPhysics.KuroFauxPhysicsRotateComponentBase";

		// Token: 0x040025B8 RID: 9656
		private static IntPtr _ClassPtr;

		// Token: 0x040025B9 RID: 9657
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040025BA RID: 9658
		internal static int __PropertyOffset_Friction;

		// Token: 0x040025BB RID: 9659
		internal static int __PropertyOffset_TorqueBounds;

		// Token: 0x040025BC RID: 9660
		internal static int __PropertyOffset_ForceScalar;

		// Token: 0x040025BD RID: 9661
		internal static int __PropertyOffset_SpringStrength;
	}
}
