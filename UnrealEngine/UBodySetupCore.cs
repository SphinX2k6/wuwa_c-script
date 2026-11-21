using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007B3 RID: 1971
	[UnrealObjectPath("/Script/PhysicsCore.BodySetupCore")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UBodySetupCore : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600AB46 RID: 43846 RVA: 0x000FC9B6 File Offset: 0x000FABB6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBodySetupCore._ClassPtr;
		}

		// Token: 0x0600AB47 RID: 43847 RVA: 0x000FC9C4 File Offset: 0x000FABC4
		public UBodySetupCore() : this(BuiltinUtils.AllocNativeUObject(UBodySetupCore.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600AB48 RID: 43848 RVA: 0x000FC9EC File Offset: 0x000FABEC
		[NullableContext(1)]
		public UBodySetupCore(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBodySetupCore.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001FDE RID: 8158
		// (get) Token: 0x0600AB49 RID: 43849 RVA: 0x000FCA1F File Offset: 0x000FAC1F
		// (set) Token: 0x0600AB4A RID: 43850 RVA: 0x000FCA33 File Offset: 0x000FAC33
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

		// Token: 0x17001FDF RID: 8159
		// (get) Token: 0x0600AB4B RID: 43851 RVA: 0x000FCA48 File Offset: 0x000FAC48
		// (set) Token: 0x0600AB4C RID: 43852 RVA: 0x000FCA58 File Offset: 0x000FAC58
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

		// Token: 0x0600AB4D RID: 43853 RVA: 0x000FCA69 File Offset: 0x000FAC69
		static UBodySetupCore()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/PhysicsCore.BodySetupCore");
		}

		// Token: 0x0600AB4E RID: 43854 RVA: 0x000FCA77 File Offset: 0x000FAC77
		protected UBodySetupCore(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004943 RID: 18755
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/PhysicsCore.BodySetupCore";

		// Token: 0x04004944 RID: 18756
		private static IntPtr _ClassPtr;

		// Token: 0x04004945 RID: 18757
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004946 RID: 18758
		internal static int __PropertyOffset_BoneName;

		// Token: 0x04004947 RID: 18759
		internal static int __PropertyOffset_bOnlyUseSimpleCollision;
	}
}
