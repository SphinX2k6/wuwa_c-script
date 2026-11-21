using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003C5 RID: 965
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.EffectModelGroup")]
	[UnrealStructLayout(1480, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1480)]
	public class UEffectModelGroup : UEffectModelBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005E3F RID: 24127 RVA: 0x000854F5 File Offset: 0x000836F5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEffectModelGroup._ClassPtr;
		}

		// Token: 0x06005E40 RID: 24128 RVA: 0x00085504 File Offset: 0x00083704
		public UEffectModelGroup() : this(BuiltinUtils.AllocNativeUObject(UEffectModelGroup.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005E41 RID: 24129 RVA: 0x0008552C File Offset: 0x0008372C
		public UEffectModelGroup(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEffectModelGroup.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170012A8 RID: 4776
		// (get) Token: 0x06005E42 RID: 24130 RVA: 0x00085560 File Offset: 0x00083760
		// (set) Token: 0x06005E43 RID: 24131 RVA: 0x00085599 File Offset: 0x00083799
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

		// Token: 0x170012A9 RID: 4777
		// (get) Token: 0x06005E44 RID: 24132 RVA: 0x000855BC File Offset: 0x000837BC
		// (set) Token: 0x06005E45 RID: 24133 RVA: 0x000855F5 File Offset: 0x000837F5
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

		// Token: 0x170012AA RID: 4778
		// (get) Token: 0x06005E46 RID: 24134 RVA: 0x00085618 File Offset: 0x00083818
		// (set) Token: 0x06005E47 RID: 24135 RVA: 0x00085651 File Offset: 0x00083851
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

		// Token: 0x170012AB RID: 4779
		// (get) Token: 0x06005E48 RID: 24136 RVA: 0x00085674 File Offset: 0x00083874
		// (set) Token: 0x06005E49 RID: 24137 RVA: 0x000856AD File Offset: 0x000838AD
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

		// Token: 0x06005E4A RID: 24138 RVA: 0x000856BB File Offset: 0x000838BB
		static UEffectModelGroup()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.EffectModelGroup");
		}

		// Token: 0x06005E4B RID: 24139 RVA: 0x000856C9 File Offset: 0x000838C9
		protected UEffectModelGroup(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002763 RID: 10083
		public new const string __ObjectPath = "/Script/KuroGameplay.EffectModelGroup";

		// Token: 0x04002764 RID: 10084
		private static IntPtr _ClassPtr;

		// Token: 0x04002765 RID: 10085
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002766 RID: 10086
		internal static int __PropertyOffset_Location;

		// Token: 0x04002767 RID: 10087
		[Nullable(2)]
		private FKuroCurveVector _Location;

		// Token: 0x04002768 RID: 10088
		internal static int __PropertyOffset_Rotation;

		// Token: 0x04002769 RID: 10089
		[Nullable(2)]
		private FKuroCurveVector _Rotation;

		// Token: 0x0400276A RID: 10090
		internal static int __PropertyOffset_Scale;

		// Token: 0x0400276B RID: 10091
		[Nullable(2)]
		private FKuroCurveVector _Scale;

		// Token: 0x0400276C RID: 10092
		internal static int __PropertyOffset_EffectData;

		// Token: 0x0400276D RID: 10093
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<UEffectModelBase, float> _EffectData;
	}
}
