using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D2C RID: 7468
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Buff_Period_FaceNearestEnemy")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 184)]
	public class UKSC_Buff_Period_FaceNearestEnemy : UKSC_Buff_Period, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CA55 RID: 117333 RVA: 0x002A58DF File Offset: 0x002A3ADF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Buff_Period_FaceNearestEnemy._ClassPtr;
		}

		// Token: 0x0601CA56 RID: 117334 RVA: 0x002A58EC File Offset: 0x002A3AEC
		public UKSC_Buff_Period_FaceNearestEnemy() : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_Period_FaceNearestEnemy.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CA57 RID: 117335 RVA: 0x002A5914 File Offset: 0x002A3B14
		[NullableContext(1)]
		public UKSC_Buff_Period_FaceNearestEnemy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_Period_FaceNearestEnemy.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007346 RID: 29510
		// (get) Token: 0x0601CA58 RID: 117336 RVA: 0x002A5947 File Offset: 0x002A3B47
		// (set) Token: 0x0601CA59 RID: 117337 RVA: 0x002A595B File Offset: 0x002A3B5B
		[Nullable(2)]
		public unsafe UKSC_DA_Buff_Period_FaceNearestEnemy DaBuffPeriodFaceNearestEnemy_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff_Period_FaceNearestEnemy>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_Period_FaceNearestEnemy.__PropertyOffset_DaBuffPeriodFaceNearestEnemy_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_Period_FaceNearestEnemy.__PropertyOffset_DaBuffPeriodFaceNearestEnemy_, value);
			}
		}

		// Token: 0x0601CA5A RID: 117338 RVA: 0x002A5970 File Offset: 0x002A3B70
		static UKSC_Buff_Period_FaceNearestEnemy()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Buff_Period_FaceNearestEnemy");
		}

		// Token: 0x0601CA5B RID: 117339 RVA: 0x002A597E File Offset: 0x002A3B7E
		protected UKSC_Buff_Period_FaceNearestEnemy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F878 RID: 63608
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Buff_Period_FaceNearestEnemy";

		// Token: 0x0400F879 RID: 63609
		private static IntPtr _ClassPtr;

		// Token: 0x0400F87A RID: 63610
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F87B RID: 63611
		internal static int __PropertyOffset_DaBuffPeriodFaceNearestEnemy_;
	}
}
