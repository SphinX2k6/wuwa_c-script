using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D64 RID: 7524
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Buff_KuroBulletPattern")]
	[UnrealStructLayout(448, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 448)]
	public class UKSC_DA_Buff_KuroBulletPattern : UKSC_DA_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CD0D RID: 118029 RVA: 0x002A9804 File Offset: 0x002A7A04
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Buff_KuroBulletPattern._ClassPtr;
		}

		// Token: 0x0601CD0E RID: 118030 RVA: 0x002A9810 File Offset: 0x002A7A10
		public UKSC_DA_Buff_KuroBulletPattern() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_KuroBulletPattern.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CD0F RID: 118031 RVA: 0x002A9838 File Offset: 0x002A7A38
		[NullableContext(1)]
		public UKSC_DA_Buff_KuroBulletPattern(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_KuroBulletPattern.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007410 RID: 29712
		// (get) Token: 0x0601CD10 RID: 118032 RVA: 0x002A986B File Offset: 0x002A7A6B
		// (set) Token: 0x0601CD11 RID: 118033 RVA: 0x002A987F File Offset: 0x002A7A7F
		[Nullable(2)]
		public unsafe UKuroBulletPatternDataAsset PatternDA
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroBulletPatternDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Buff_KuroBulletPattern.__PropertyOffset_PatternDA);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Buff_KuroBulletPattern.__PropertyOffset_PatternDA, value);
			}
		}

		// Token: 0x17007411 RID: 29713
		// (get) Token: 0x0601CD12 RID: 118034 RVA: 0x002A9894 File Offset: 0x002A7A94
		// (set) Token: 0x0601CD13 RID: 118035 RVA: 0x002A98A4 File Offset: 0x002A7AA4
		public unsafe bool PatternDestroyOnEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_KuroBulletPattern.__PropertyOffset_PatternDestroyOnEnd) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_KuroBulletPattern.__PropertyOffset_PatternDestroyOnEnd) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601CD14 RID: 118036 RVA: 0x002A98B5 File Offset: 0x002A7AB5
		static UKSC_DA_Buff_KuroBulletPattern()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Buff_KuroBulletPattern");
		}

		// Token: 0x0601CD15 RID: 118037 RVA: 0x002A98C3 File Offset: 0x002A7AC3
		protected UKSC_DA_Buff_KuroBulletPattern(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FA11 RID: 64017
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Buff_KuroBulletPattern";

		// Token: 0x0400FA12 RID: 64018
		private static IntPtr _ClassPtr;

		// Token: 0x0400FA13 RID: 64019
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FA14 RID: 64020
		internal static int __PropertyOffset_PatternDA;

		// Token: 0x0400FA15 RID: 64021
		internal static int __PropertyOffset_PatternDestroyOnEnd;
	}
}
