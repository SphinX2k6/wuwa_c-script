using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001911 RID: 6417
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.KuroSplineVolumeBuilder")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public abstract class UKuroSplineVolumeBuilder : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06017D13 RID: 97555 RVA: 0x0022E1F8 File Offset: 0x0022C3F8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroSplineVolumeBuilder._ClassPtr;
		}

		// Token: 0x17005FC1 RID: 24513
		// (get) Token: 0x06017D14 RID: 97556 RVA: 0x0022E204 File Offset: 0x0022C404
		// (set) Token: 0x06017D15 RID: 97557 RVA: 0x0022E23D File Offset: 0x0022C43D
		public TArray<FVector> Vertices
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._Vertices) == null)
				{
					result = (this._Vertices = new TArray<FVector>(base.NativePtr + (IntPtr)UKuroSplineVolumeBuilder.__PropertyOffset_Vertices, this));
				}
				return result;
			}
			set
			{
				this.Vertices.CopyAssign(value);
			}
		}

		// Token: 0x17005FC2 RID: 24514
		// (get) Token: 0x06017D16 RID: 97558 RVA: 0x0022E24C File Offset: 0x0022C44C
		// (set) Token: 0x06017D17 RID: 97559 RVA: 0x0022E285 File Offset: 0x0022C485
		public TArray<FBuilderPoly> Polys
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBuilderPoly> result;
				if ((result = this._Polys) == null)
				{
					result = (this._Polys = new TArray<FBuilderPoly>(base.NativePtr + (IntPtr)UKuroSplineVolumeBuilder.__PropertyOffset_Polys, this));
				}
				return result;
			}
			set
			{
				this.Polys.CopyAssign(value);
			}
		}

		// Token: 0x06017D18 RID: 97560 RVA: 0x0022E293 File Offset: 0x0022C493
		static UKuroSplineVolumeBuilder()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroSplineVolumeBuilder");
		}

		// Token: 0x06017D19 RID: 97561 RVA: 0x0022E2A4 File Offset: 0x0022C4A4
		protected UKuroSplineVolumeBuilder() : this(BuiltinUtils.AllocNativeUObject(UKuroSplineVolumeBuilder.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017D1A RID: 97562 RVA: 0x0022E2CC File Offset: 0x0022C4CC
		protected UKuroSplineVolumeBuilder(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CE8B RID: 52875
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroSplineVolumeBuilder";

		// Token: 0x0400CE8C RID: 52876
		private static IntPtr _ClassPtr;

		// Token: 0x0400CE8D RID: 52877
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400CE8E RID: 52878
		internal static int __PropertyOffset_Vertices;

		// Token: 0x0400CE8F RID: 52879
		[Nullable(2)]
		private TArray<FVector> _Vertices;

		// Token: 0x0400CE90 RID: 52880
		internal static int __PropertyOffset_Polys;

		// Token: 0x0400CE91 RID: 52881
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBuilderPoly> _Polys;
	}
}
