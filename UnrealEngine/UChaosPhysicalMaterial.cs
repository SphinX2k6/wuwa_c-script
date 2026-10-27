using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200263A RID: 9786
	[UnrealObjectPath("/Script/PhysicsCore.ChaosPhysicalMaterial")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UChaosPhysicalMaterial : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024664 RID: 149092 RVA: 0x0035E443 File Offset: 0x0035C643
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UChaosPhysicalMaterial._ClassPtr;
		}

		// Token: 0x06024665 RID: 149093 RVA: 0x0035E450 File Offset: 0x0035C650
		public UChaosPhysicalMaterial() : this(BuiltinUtils.AllocNativeUObject(UChaosPhysicalMaterial.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024666 RID: 149094 RVA: 0x0035E478 File Offset: 0x0035C678
		[NullableContext(1)]
		public UChaosPhysicalMaterial(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UChaosPhysicalMaterial.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008C35 RID: 35893
		// (get) Token: 0x06024667 RID: 149095 RVA: 0x0035E4AB File Offset: 0x0035C6AB
		// (set) Token: 0x06024668 RID: 149096 RVA: 0x0035E4BB File Offset: 0x0035C6BB
		public unsafe float Friction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UChaosPhysicalMaterial.__PropertyOffset_Friction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UChaosPhysicalMaterial.__PropertyOffset_Friction) = value;
			}
		}

		// Token: 0x17008C36 RID: 35894
		// (get) Token: 0x06024669 RID: 149097 RVA: 0x0035E4CC File Offset: 0x0035C6CC
		// (set) Token: 0x0602466A RID: 149098 RVA: 0x0035E4DC File Offset: 0x0035C6DC
		public unsafe float StaticFriction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UChaosPhysicalMaterial.__PropertyOffset_StaticFriction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UChaosPhysicalMaterial.__PropertyOffset_StaticFriction) = value;
			}
		}

		// Token: 0x17008C37 RID: 35895
		// (get) Token: 0x0602466B RID: 149099 RVA: 0x0035E4ED File Offset: 0x0035C6ED
		// (set) Token: 0x0602466C RID: 149100 RVA: 0x0035E4FD File Offset: 0x0035C6FD
		public unsafe float Restitution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UChaosPhysicalMaterial.__PropertyOffset_Restitution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UChaosPhysicalMaterial.__PropertyOffset_Restitution) = value;
			}
		}

		// Token: 0x17008C38 RID: 35896
		// (get) Token: 0x0602466D RID: 149101 RVA: 0x0035E50E File Offset: 0x0035C70E
		// (set) Token: 0x0602466E RID: 149102 RVA: 0x0035E51E File Offset: 0x0035C71E
		public unsafe float LinearEtherDrag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UChaosPhysicalMaterial.__PropertyOffset_LinearEtherDrag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UChaosPhysicalMaterial.__PropertyOffset_LinearEtherDrag) = value;
			}
		}

		// Token: 0x17008C39 RID: 35897
		// (get) Token: 0x0602466F RID: 149103 RVA: 0x0035E52F File Offset: 0x0035C72F
		// (set) Token: 0x06024670 RID: 149104 RVA: 0x0035E53F File Offset: 0x0035C73F
		public unsafe float AngularEtherDrag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UChaosPhysicalMaterial.__PropertyOffset_AngularEtherDrag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UChaosPhysicalMaterial.__PropertyOffset_AngularEtherDrag) = value;
			}
		}

		// Token: 0x17008C3A RID: 35898
		// (get) Token: 0x06024671 RID: 149105 RVA: 0x0035E550 File Offset: 0x0035C750
		// (set) Token: 0x06024672 RID: 149106 RVA: 0x0035E560 File Offset: 0x0035C760
		public unsafe float SleepingLinearVelocityThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UChaosPhysicalMaterial.__PropertyOffset_SleepingLinearVelocityThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UChaosPhysicalMaterial.__PropertyOffset_SleepingLinearVelocityThreshold) = value;
			}
		}

		// Token: 0x17008C3B RID: 35899
		// (get) Token: 0x06024673 RID: 149107 RVA: 0x0035E571 File Offset: 0x0035C771
		// (set) Token: 0x06024674 RID: 149108 RVA: 0x0035E581 File Offset: 0x0035C781
		public unsafe float SleepingAngularVelocityThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UChaosPhysicalMaterial.__PropertyOffset_SleepingAngularVelocityThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UChaosPhysicalMaterial.__PropertyOffset_SleepingAngularVelocityThreshold) = value;
			}
		}

		// Token: 0x06024675 RID: 149109 RVA: 0x0035E592 File Offset: 0x0035C792
		static UChaosPhysicalMaterial()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/PhysicsCore.ChaosPhysicalMaterial");
		}

		// Token: 0x06024676 RID: 149110 RVA: 0x0035E5A0 File Offset: 0x0035C7A0
		protected UChaosPhysicalMaterial(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013866 RID: 79974
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/PhysicsCore.ChaosPhysicalMaterial";

		// Token: 0x04013867 RID: 79975
		private static IntPtr _ClassPtr;

		// Token: 0x04013868 RID: 79976
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013869 RID: 79977
		internal static int __PropertyOffset_Friction;

		// Token: 0x0401386A RID: 79978
		internal static int __PropertyOffset_StaticFriction;

		// Token: 0x0401386B RID: 79979
		internal static int __PropertyOffset_Restitution;

		// Token: 0x0401386C RID: 79980
		internal static int __PropertyOffset_LinearEtherDrag;

		// Token: 0x0401386D RID: 79981
		internal static int __PropertyOffset_AngularEtherDrag;

		// Token: 0x0401386E RID: 79982
		internal static int __PropertyOffset_SleepingLinearVelocityThreshold;

		// Token: 0x0401386F RID: 79983
		internal static int __PropertyOffset_SleepingAngularVelocityThreshold;
	}
}
