using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018A2 RID: 6306
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.EffectModelGroup")]
	[UnrealStructLayout(1480, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1480)]
	public class UEffectModelGroup : UEffectModelBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601739A RID: 95130 RVA: 0x0021E0F1 File Offset: 0x0021C2F1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEffectModelGroup._ClassPtr;
		}

		// Token: 0x0601739B RID: 95131 RVA: 0x0021E100 File Offset: 0x0021C300
		public UEffectModelGroup() : this(BuiltinUtils.AllocNativeUObject(UEffectModelGroup.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601739C RID: 95132 RVA: 0x0021E128 File Offset: 0x0021C328
		public UEffectModelGroup(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEffectModelGroup.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005D68 RID: 23912
		// (get) Token: 0x0601739D RID: 95133 RVA: 0x0021E15C File Offset: 0x0021C35C
		// (set) Token: 0x0601739E RID: 95134 RVA: 0x0021E195 File Offset: 0x0021C395
		public FKuroCurveVector Location
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveVector result;
				if ((result = this._Location) == null)
				{
					result = (this._Location = new FKuroCurveVector(base.NativePtr + (IntPtr)UEffectModelGroup.__PropertyOffset_Location, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveVector.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelGroup.__PropertyOffset_Location, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005D69 RID: 23913
		// (get) Token: 0x0601739F RID: 95135 RVA: 0x0021E1B8 File Offset: 0x0021C3B8
		// (set) Token: 0x060173A0 RID: 95136 RVA: 0x0021E1F1 File Offset: 0x0021C3F1
		public FKuroCurveVector Rotation
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveVector result;
				if ((result = this._Rotation) == null)
				{
					result = (this._Rotation = new FKuroCurveVector(base.NativePtr + (IntPtr)UEffectModelGroup.__PropertyOffset_Rotation, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveVector.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelGroup.__PropertyOffset_Rotation, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005D6A RID: 23914
		// (get) Token: 0x060173A1 RID: 95137 RVA: 0x0021E214 File Offset: 0x0021C414
		// (set) Token: 0x060173A2 RID: 95138 RVA: 0x0021E24D File Offset: 0x0021C44D
		public FKuroCurveVector Scale
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveVector result;
				if ((result = this._Scale) == null)
				{
					result = (this._Scale = new FKuroCurveVector(base.NativePtr + (IntPtr)UEffectModelGroup.__PropertyOffset_Scale, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveVector.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelGroup.__PropertyOffset_Scale, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005D6B RID: 23915
		// (get) Token: 0x060173A3 RID: 95139 RVA: 0x0021E270 File Offset: 0x0021C470
		// (set) Token: 0x060173A4 RID: 95140 RVA: 0x0021E2A9 File Offset: 0x0021C4A9
		public TMap<UEffectModelBase, float> EffectData
		{
			get
			{
				base.FastCheckIsValid();
				TMap<UEffectModelBase, float> result;
				if ((result = this._EffectData) == null)
				{
					result = (this._EffectData = new TMap<UEffectModelBase, float>(base.NativePtr + (IntPtr)UEffectModelGroup.__PropertyOffset_EffectData, this));
				}
				return result;
			}
			set
			{
				this.EffectData.CopyAssign(value);
			}
		}

		// Token: 0x060173A5 RID: 95141 RVA: 0x0021E2B7 File Offset: 0x0021C4B7
		static UEffectModelGroup()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.EffectModelGroup");
		}

		// Token: 0x060173A6 RID: 95142 RVA: 0x0021E2C5 File Offset: 0x0021C4C5
		protected UEffectModelGroup(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C998 RID: 51608
		public new const string __ObjectPath = "/Script/KuroGameplay.EffectModelGroup";

		// Token: 0x0400C999 RID: 51609
		private static IntPtr _ClassPtr;

		// Token: 0x0400C99A RID: 51610
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C99B RID: 51611
		internal static int __PropertyOffset_Location;

		// Token: 0x0400C99C RID: 51612
		[Nullable(2)]
		private FKuroCurveVector _Location;

		// Token: 0x0400C99D RID: 51613
		internal static int __PropertyOffset_Rotation;

		// Token: 0x0400C99E RID: 51614
		[Nullable(2)]
		private FKuroCurveVector _Rotation;

		// Token: 0x0400C99F RID: 51615
		internal static int __PropertyOffset_Scale;

		// Token: 0x0400C9A0 RID: 51616
		[Nullable(2)]
		private FKuroCurveVector _Scale;

		// Token: 0x0400C9A1 RID: 51617
		internal static int __PropertyOffset_EffectData;

		// Token: 0x0400C9A2 RID: 51618
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<UEffectModelBase, float> _EffectData;
	}
}
