using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D76 RID: 7542
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Buff_Period_FaceNearestEnemy")]
	[UnrealStructLayout(640, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 640)]
	public class UKSC_DA_Buff_Period_FaceNearestEnemy : UKSC_DA_Buff_Period, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CE36 RID: 118326 RVA: 0x002AB3A6 File Offset: 0x002A95A6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Buff_Period_FaceNearestEnemy._ClassPtr;
		}

		// Token: 0x0601CE37 RID: 118327 RVA: 0x002AB3B4 File Offset: 0x002A95B4
		public UKSC_DA_Buff_Period_FaceNearestEnemy() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_Period_FaceNearestEnemy.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CE38 RID: 118328 RVA: 0x002AB3DC File Offset: 0x002A95DC
		public UKSC_DA_Buff_Period_FaceNearestEnemy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_Period_FaceNearestEnemy.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007478 RID: 29816
		// (get) Token: 0x0601CE39 RID: 118329 RVA: 0x002AB40F File Offset: 0x002A960F
		// (set) Token: 0x0601CE3A RID: 118330 RVA: 0x002AB41F File Offset: 0x002A961F
		public unsafe float Range
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_Period_FaceNearestEnemy.__PropertyOffset_Range);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Period_FaceNearestEnemy.__PropertyOffset_Range) = value;
			}
		}

		// Token: 0x17007479 RID: 29817
		// (get) Token: 0x0601CE3B RID: 118331 RVA: 0x002AB430 File Offset: 0x002A9630
		// (set) Token: 0x0601CE3C RID: 118332 RVA: 0x002AB469 File Offset: 0x002A9669
		public TArray<EKSC_Faction> IgnoreFaction
		{
			get
			{
				base.FastCheckIsValid();
				TArray<EKSC_Faction> result;
				if ((result = this._IgnoreFaction) == null)
				{
					result = (this._IgnoreFaction = new TArray<EKSC_Faction>(base.NativePtr + (IntPtr)UKSC_DA_Buff_Period_FaceNearestEnemy.__PropertyOffset_IgnoreFaction, this));
				}
				return result;
			}
			set
			{
				this.IgnoreFaction.CopyAssign(value);
			}
		}

		// Token: 0x0601CE3D RID: 118333 RVA: 0x002AB477 File Offset: 0x002A9677
		static UKSC_DA_Buff_Period_FaceNearestEnemy()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Buff_Period_FaceNearestEnemy");
		}

		// Token: 0x0601CE3E RID: 118334 RVA: 0x002AB485 File Offset: 0x002A9685
		protected UKSC_DA_Buff_Period_FaceNearestEnemy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FACA RID: 64202
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Buff_Period_FaceNearestEnemy";

		// Token: 0x0400FACB RID: 64203
		private static IntPtr _ClassPtr;

		// Token: 0x0400FACC RID: 64204
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FACD RID: 64205
		internal static int __PropertyOffset_Range;

		// Token: 0x0400FACE RID: 64206
		internal static int __PropertyOffset_IgnoreFaction;

		// Token: 0x0400FACF RID: 64207
		[Nullable(2)]
		private TArray<EKSC_Faction> _IgnoreFaction;
	}
}
