using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002639 RID: 9785
	[UnrealObjectPath("/Script/PhysicsCore.BodySetupCore")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UBodySetupCore : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024655 RID: 149077 RVA: 0x0035E2FF File Offset: 0x0035C4FF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBodySetupCore._ClassPtr;
		}

		// Token: 0x06024656 RID: 149078 RVA: 0x0035E30C File Offset: 0x0035C50C
		public UBodySetupCore() : this(BuiltinUtils.AllocNativeUObject(UBodySetupCore.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024657 RID: 149079 RVA: 0x0035E334 File Offset: 0x0035C534
		[NullableContext(1)]
		public UBodySetupCore(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBodySetupCore.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008C30 RID: 35888
		// (get) Token: 0x06024658 RID: 149080 RVA: 0x0035E367 File Offset: 0x0035C567
		// (set) Token: 0x06024659 RID: 149081 RVA: 0x0035E37B File Offset: 0x0035C57B
		public unsafe FName BoneName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBodySetupCore.__PropertyOffset_BoneName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBodySetupCore.__PropertyOffset_BoneName) = value;
			}
		}

		// Token: 0x17008C31 RID: 35889
		// (get) Token: 0x0602465A RID: 149082 RVA: 0x0035E390 File Offset: 0x0035C590
		// (set) Token: 0x0602465B RID: 149083 RVA: 0x0035E3A4 File Offset: 0x0035C5A4
		public unsafe TEnumAsByte<EPhysicsType> PhysicsType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBodySetupCore.__PropertyOffset_PhysicsType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBodySetupCore.__PropertyOffset_PhysicsType) = value;
			}
		}

		// Token: 0x17008C32 RID: 35890
		// (get) Token: 0x0602465C RID: 149084 RVA: 0x0035E3B9 File Offset: 0x0035C5B9
		// (set) Token: 0x0602465D RID: 149085 RVA: 0x0035E3CD File Offset: 0x0035C5CD
		public unsafe TEnumAsByte<ECollisionTraceFlag> CollisionTraceFlag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBodySetupCore.__PropertyOffset_CollisionTraceFlag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBodySetupCore.__PropertyOffset_CollisionTraceFlag) = value;
			}
		}

		// Token: 0x17008C33 RID: 35891
		// (get) Token: 0x0602465E RID: 149086 RVA: 0x0035E3E2 File Offset: 0x0035C5E2
		// (set) Token: 0x0602465F RID: 149087 RVA: 0x0035E3F6 File Offset: 0x0035C5F6
		public unsafe TEnumAsByte<EBodyCollisionResponse> CollisionReponse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBodySetupCore.__PropertyOffset_CollisionReponse);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBodySetupCore.__PropertyOffset_CollisionReponse) = value;
			}
		}

		// Token: 0x17008C34 RID: 35892
		// (get) Token: 0x06024660 RID: 149088 RVA: 0x0035E40B File Offset: 0x0035C60B
		// (set) Token: 0x06024661 RID: 149089 RVA: 0x0035E41B File Offset: 0x0035C61B
		public unsafe bool bOnlyUseSimpleCollision
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBodySetupCore.__PropertyOffset_bOnlyUseSimpleCollision) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBodySetupCore.__PropertyOffset_bOnlyUseSimpleCollision) = (value ? 1 : 0);
			}
		}

		// Token: 0x06024662 RID: 149090 RVA: 0x0035E42C File Offset: 0x0035C62C
		static UBodySetupCore()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/PhysicsCore.BodySetupCore");
		}

		// Token: 0x06024663 RID: 149091 RVA: 0x0035E43A File Offset: 0x0035C63A
		protected UBodySetupCore(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401385E RID: 79966
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/PhysicsCore.BodySetupCore";

		// Token: 0x0401385F RID: 79967
		private static IntPtr _ClassPtr;

		// Token: 0x04013860 RID: 79968
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013861 RID: 79969
		internal static int __PropertyOffset_BoneName;

		// Token: 0x04013862 RID: 79970
		internal static int __PropertyOffset_PhysicsType;

		// Token: 0x04013863 RID: 79971
		internal static int __PropertyOffset_CollisionTraceFlag;

		// Token: 0x04013864 RID: 79972
		internal static int __PropertyOffset_CollisionReponse;

		// Token: 0x04013865 RID: 79973
		internal static int __PropertyOffset_bOnlyUseSimpleCollision;
	}
}
