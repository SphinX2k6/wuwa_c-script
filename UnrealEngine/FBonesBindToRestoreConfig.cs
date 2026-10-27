using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200162C RID: 5676
	[UnrealObjectPath("/Script/KuroAnim.BonesBindToRestoreConfig")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FBonesBindToRestoreConfig : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060148A2 RID: 84130 RVA: 0x001E37D5 File Offset: 0x001E19D5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBonesBindToRestoreConfig._ScriptStructPtr != 0) ? FBonesBindToRestoreConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.BonesBindToRestoreConfig", ref FBonesBindToRestoreConfig._ScriptStructPtr);
		}

		// Token: 0x170050E3 RID: 20707
		// (get) Token: 0x060148A3 RID: 84131 RVA: 0x001E37F9 File Offset: 0x001E19F9
		// (set) Token: 0x060148A4 RID: 84132 RVA: 0x001E3809 File Offset: 0x001E1A09
		public unsafe int BoneLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBonesBindToRestoreConfig.__PropertyOffset_BoneLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBonesBindToRestoreConfig.__PropertyOffset_BoneLevel) = value;
			}
		}

		// Token: 0x170050E4 RID: 20708
		// (get) Token: 0x060148A5 RID: 84133 RVA: 0x001E381A File Offset: 0x001E1A1A
		// (set) Token: 0x060148A6 RID: 84134 RVA: 0x001E382A File Offset: 0x001E1A2A
		public unsafe EBonesBindToRestoreRuleType RestoreRuleType
		{
			get
			{
				return (EBonesBindToRestoreRuleType)(*(base.NativePtr + (IntPtr)FBonesBindToRestoreConfig.__PropertyOffset_RestoreRuleType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBonesBindToRestoreConfig.__PropertyOffset_RestoreRuleType) = (byte)value;
			}
		}

		// Token: 0x170050E5 RID: 20709
		// (get) Token: 0x060148A7 RID: 84135 RVA: 0x001E383B File Offset: 0x001E1A3B
		// (set) Token: 0x060148A8 RID: 84136 RVA: 0x001E384F File Offset: 0x001E1A4F
		[Nullable(2)]
		public unsafe UCurveFloat AlphaCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + FBonesBindToRestoreConfig.__PropertyOffset_AlphaCurve);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FBonesBindToRestoreConfig.__PropertyOffset_AlphaCurve, value);
			}
		}

		// Token: 0x060148A9 RID: 84137 RVA: 0x001E3864 File Offset: 0x001E1A64
		public FBonesBindToRestoreConfig()
		{
		}

		// Token: 0x060148AA RID: 84138 RVA: 0x001E386C File Offset: 0x001E1A6C
		[NullableContext(1)]
		public FBonesBindToRestoreConfig(int BoneLevel, EBonesBindToRestoreRuleType RestoreRuleType, UCurveFloat AlphaCurve)
		{
			this.BoneLevel = BoneLevel;
			this.RestoreRuleType = RestoreRuleType;
			this.AlphaCurve = AlphaCurve;
		}

		// Token: 0x060148AB RID: 84139 RVA: 0x001E3889 File Offset: 0x001E1A89
		protected override IntPtr GetUStructPtr()
		{
			return FBonesBindToRestoreConfig.StaticStruct();
		}

		// Token: 0x060148AC RID: 84140 RVA: 0x001E3895 File Offset: 0x001E1A95
		[NullableContext(2)]
		public FBonesBindToRestoreConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060148AD RID: 84141 RVA: 0x001E389F File Offset: 0x001E1A9F
		public FBonesBindToRestoreConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060148AE RID: 84142 RVA: 0x001E38AA File Offset: 0x001E1AAA
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBonesBindToRestoreConfig(Pointer, false, true);
		}

		// Token: 0x060148AF RID: 84143 RVA: 0x001E38B4 File Offset: 0x001E1AB4
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBonesBindToRestoreConfig(Pointer, MemoryOwner);
		}

		// Token: 0x0400B2B7 RID: 45751
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroAnim.BonesBindToRestoreConfig";

		// Token: 0x0400B2B8 RID: 45752
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B2B9 RID: 45753
		internal static int __PropertyOffset_BoneLevel;

		// Token: 0x0400B2BA RID: 45754
		internal static int __PropertyOffset_RestoreRuleType;

		// Token: 0x0400B2BB RID: 45755
		internal static int __PropertyOffset_AlphaCurve;
	}
}
