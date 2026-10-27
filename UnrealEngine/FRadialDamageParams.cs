using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001061 RID: 4193
	[UnrealObjectPath("/Script/Engine.RadialDamageParams")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class FRadialDamageParams : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600EE8A RID: 61066 RVA: 0x00161E26 File Offset: 0x00160026
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRadialDamageParams._ScriptStructPtr != 0) ? FRadialDamageParams._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.RadialDamageParams", ref FRadialDamageParams._ScriptStructPtr);
		}

		// Token: 0x170039BC RID: 14780
		// (get) Token: 0x0600EE8B RID: 61067 RVA: 0x00161E4A File Offset: 0x0016004A
		// (set) Token: 0x0600EE8C RID: 61068 RVA: 0x00161E5A File Offset: 0x0016005A
		public unsafe float BaseDamage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRadialDamageParams.__PropertyOffset_BaseDamage);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRadialDamageParams.__PropertyOffset_BaseDamage) = value;
			}
		}

		// Token: 0x170039BD RID: 14781
		// (get) Token: 0x0600EE8D RID: 61069 RVA: 0x00161E6B File Offset: 0x0016006B
		// (set) Token: 0x0600EE8E RID: 61070 RVA: 0x00161E7B File Offset: 0x0016007B
		public unsafe float MinimumDamage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRadialDamageParams.__PropertyOffset_MinimumDamage);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRadialDamageParams.__PropertyOffset_MinimumDamage) = value;
			}
		}

		// Token: 0x170039BE RID: 14782
		// (get) Token: 0x0600EE8F RID: 61071 RVA: 0x00161E8C File Offset: 0x0016008C
		// (set) Token: 0x0600EE90 RID: 61072 RVA: 0x00161E9C File Offset: 0x0016009C
		public unsafe float InnerRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRadialDamageParams.__PropertyOffset_InnerRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRadialDamageParams.__PropertyOffset_InnerRadius) = value;
			}
		}

		// Token: 0x170039BF RID: 14783
		// (get) Token: 0x0600EE91 RID: 61073 RVA: 0x00161EAD File Offset: 0x001600AD
		// (set) Token: 0x0600EE92 RID: 61074 RVA: 0x00161EBD File Offset: 0x001600BD
		public unsafe float OuterRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRadialDamageParams.__PropertyOffset_OuterRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRadialDamageParams.__PropertyOffset_OuterRadius) = value;
			}
		}

		// Token: 0x170039C0 RID: 14784
		// (get) Token: 0x0600EE93 RID: 61075 RVA: 0x00161ECE File Offset: 0x001600CE
		// (set) Token: 0x0600EE94 RID: 61076 RVA: 0x00161EDE File Offset: 0x001600DE
		public unsafe float DamageFalloff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRadialDamageParams.__PropertyOffset_DamageFalloff);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRadialDamageParams.__PropertyOffset_DamageFalloff) = value;
			}
		}

		// Token: 0x0600EE95 RID: 61077 RVA: 0x00161EEF File Offset: 0x001600EF
		public FRadialDamageParams()
		{
		}

		// Token: 0x0600EE96 RID: 61078 RVA: 0x00161EF7 File Offset: 0x001600F7
		public FRadialDamageParams(float BaseDamage, float MinimumDamage, float InnerRadius, float OuterRadius, float DamageFalloff)
		{
			this.BaseDamage = BaseDamage;
			this.MinimumDamage = MinimumDamage;
			this.InnerRadius = InnerRadius;
			this.OuterRadius = OuterRadius;
			this.DamageFalloff = DamageFalloff;
		}

		// Token: 0x0600EE97 RID: 61079 RVA: 0x00161F24 File Offset: 0x00160124
		protected override IntPtr GetUStructPtr()
		{
			return FRadialDamageParams.StaticStruct();
		}

		// Token: 0x0600EE98 RID: 61080 RVA: 0x00161F30 File Offset: 0x00160130
		[NullableContext(2)]
		public FRadialDamageParams(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600EE99 RID: 61081 RVA: 0x00161F3A File Offset: 0x0016013A
		public FRadialDamageParams(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600EE9A RID: 61082 RVA: 0x00161F45 File Offset: 0x00160145
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRadialDamageParams(Pointer, false, true);
		}

		// Token: 0x0600EE9B RID: 61083 RVA: 0x00161F4F File Offset: 0x0016014F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRadialDamageParams(Pointer, MemoryOwner);
		}

		// Token: 0x0400811D RID: 33053
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.RadialDamageParams";

		// Token: 0x0400811E RID: 33054
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400811F RID: 33055
		internal static int __PropertyOffset_BaseDamage;

		// Token: 0x04008120 RID: 33056
		internal static int __PropertyOffset_MinimumDamage;

		// Token: 0x04008121 RID: 33057
		internal static int __PropertyOffset_InnerRadius;

		// Token: 0x04008122 RID: 33058
		internal static int __PropertyOffset_OuterRadius;

		// Token: 0x04008123 RID: 33059
		internal static int __PropertyOffset_DamageFalloff;
	}
}
