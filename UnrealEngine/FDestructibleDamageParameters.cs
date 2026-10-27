using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000351 RID: 849
	[UnrealObjectPath("/Script/ApexDestruction.DestructibleDamageParameters")]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 28)]
	public class FDestructibleDamageParameters : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002F20 RID: 12064 RVA: 0x000483B9 File Offset: 0x000465B9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FDestructibleDamageParameters._ScriptStructPtr != 0) ? FDestructibleDamageParameters._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ApexDestruction.DestructibleDamageParameters", ref FDestructibleDamageParameters._ScriptStructPtr);
		}

		// Token: 0x17000BAC RID: 2988
		// (get) Token: 0x06002F21 RID: 12065 RVA: 0x000483DD File Offset: 0x000465DD
		// (set) Token: 0x06002F22 RID: 12066 RVA: 0x000483ED File Offset: 0x000465ED
		public unsafe float DamageThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDestructibleDamageParameters.__PropertyOffset_DamageThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDestructibleDamageParameters.__PropertyOffset_DamageThreshold) = value;
			}
		}

		// Token: 0x17000BAD RID: 2989
		// (get) Token: 0x06002F23 RID: 12067 RVA: 0x000483FE File Offset: 0x000465FE
		// (set) Token: 0x06002F24 RID: 12068 RVA: 0x0004840E File Offset: 0x0004660E
		public unsafe float DamageSpread
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDestructibleDamageParameters.__PropertyOffset_DamageSpread);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDestructibleDamageParameters.__PropertyOffset_DamageSpread) = value;
			}
		}

		// Token: 0x17000BAE RID: 2990
		// (get) Token: 0x06002F25 RID: 12069 RVA: 0x0004841F File Offset: 0x0004661F
		// (set) Token: 0x06002F26 RID: 12070 RVA: 0x0004842F File Offset: 0x0004662F
		public unsafe bool bEnableImpactDamage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDestructibleDamageParameters.__PropertyOffset_bEnableImpactDamage) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDestructibleDamageParameters.__PropertyOffset_bEnableImpactDamage) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000BAF RID: 2991
		// (get) Token: 0x06002F27 RID: 12071 RVA: 0x00048440 File Offset: 0x00046640
		// (set) Token: 0x06002F28 RID: 12072 RVA: 0x00048450 File Offset: 0x00046650
		public unsafe float ImpactDamage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDestructibleDamageParameters.__PropertyOffset_ImpactDamage);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDestructibleDamageParameters.__PropertyOffset_ImpactDamage) = value;
			}
		}

		// Token: 0x17000BB0 RID: 2992
		// (get) Token: 0x06002F29 RID: 12073 RVA: 0x00048461 File Offset: 0x00046661
		// (set) Token: 0x06002F2A RID: 12074 RVA: 0x00048471 File Offset: 0x00046671
		public unsafe int DefaultImpactDamageDepth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDestructibleDamageParameters.__PropertyOffset_DefaultImpactDamageDepth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDestructibleDamageParameters.__PropertyOffset_DefaultImpactDamageDepth) = value;
			}
		}

		// Token: 0x17000BB1 RID: 2993
		// (get) Token: 0x06002F2B RID: 12075 RVA: 0x00048482 File Offset: 0x00046682
		// (set) Token: 0x06002F2C RID: 12076 RVA: 0x00048492 File Offset: 0x00046692
		public unsafe bool bCustomImpactResistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDestructibleDamageParameters.__PropertyOffset_bCustomImpactResistance) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDestructibleDamageParameters.__PropertyOffset_bCustomImpactResistance) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000BB2 RID: 2994
		// (get) Token: 0x06002F2D RID: 12077 RVA: 0x000484A3 File Offset: 0x000466A3
		// (set) Token: 0x06002F2E RID: 12078 RVA: 0x000484B3 File Offset: 0x000466B3
		public unsafe float ImpactResistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDestructibleDamageParameters.__PropertyOffset_ImpactResistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDestructibleDamageParameters.__PropertyOffset_ImpactResistance) = value;
			}
		}

		// Token: 0x06002F2F RID: 12079 RVA: 0x000484C4 File Offset: 0x000466C4
		public FDestructibleDamageParameters()
		{
		}

		// Token: 0x06002F30 RID: 12080 RVA: 0x000484CC File Offset: 0x000466CC
		public FDestructibleDamageParameters(float DamageThreshold, float DamageSpread, bool bEnableImpactDamage, float ImpactDamage, int DefaultImpactDamageDepth, bool bCustomImpactResistance, float ImpactResistance)
		{
			this.DamageThreshold = DamageThreshold;
			this.DamageSpread = DamageSpread;
			this.bEnableImpactDamage = bEnableImpactDamage;
			this.ImpactDamage = ImpactDamage;
			this.DefaultImpactDamageDepth = DefaultImpactDamageDepth;
			this.bCustomImpactResistance = bCustomImpactResistance;
			this.ImpactResistance = ImpactResistance;
		}

		// Token: 0x06002F31 RID: 12081 RVA: 0x00048509 File Offset: 0x00046709
		protected override IntPtr GetUStructPtr()
		{
			return FDestructibleDamageParameters.StaticStruct();
		}

		// Token: 0x06002F32 RID: 12082 RVA: 0x00048515 File Offset: 0x00046715
		[NullableContext(2)]
		public FDestructibleDamageParameters(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002F33 RID: 12083 RVA: 0x0004851F File Offset: 0x0004671F
		public FDestructibleDamageParameters(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002F34 RID: 12084 RVA: 0x0004852A File Offset: 0x0004672A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FDestructibleDamageParameters(Pointer, false, true);
		}

		// Token: 0x06002F35 RID: 12085 RVA: 0x00048534 File Offset: 0x00046734
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FDestructibleDamageParameters(Pointer, MemoryOwner);
		}

		// Token: 0x04001455 RID: 5205
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ApexDestruction.DestructibleDamageParameters";

		// Token: 0x04001456 RID: 5206
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001457 RID: 5207
		internal static int __PropertyOffset_DamageThreshold;

		// Token: 0x04001458 RID: 5208
		internal static int __PropertyOffset_DamageSpread;

		// Token: 0x04001459 RID: 5209
		internal static int __PropertyOffset_bEnableImpactDamage;

		// Token: 0x0400145A RID: 5210
		internal static int __PropertyOffset_ImpactDamage;

		// Token: 0x0400145B RID: 5211
		internal static int __PropertyOffset_DefaultImpactDamageDepth;

		// Token: 0x0400145C RID: 5212
		internal static int __PropertyOffset_bCustomImpactResistance;

		// Token: 0x0400145D RID: 5213
		internal static int __PropertyOffset_ImpactResistance;
	}
}
