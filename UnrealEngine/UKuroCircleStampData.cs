using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001ACC RID: 6860
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroCircleStampData")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UKuroCircleStampData : UKuroStampData, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060197EE RID: 104430 RVA: 0x0025AB8B File Offset: 0x00258D8B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroCircleStampData._ClassPtr;
		}

		// Token: 0x060197EF RID: 104431 RVA: 0x0025AB98 File Offset: 0x00258D98
		public UKuroCircleStampData() : this(BuiltinUtils.AllocNativeUObject(UKuroCircleStampData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060197F0 RID: 104432 RVA: 0x0025ABC0 File Offset: 0x00258DC0
		public UKuroCircleStampData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroCircleStampData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170065A5 RID: 26021
		// (get) Token: 0x060197F1 RID: 104433 RVA: 0x0025ABF4 File Offset: 0x00258DF4
		// (set) Token: 0x060197F2 RID: 104434 RVA: 0x0025AC2D File Offset: 0x00258E2D
		public TArray<FCircleStampWorld2D> Circles
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FCircleStampWorld2D> result;
				if ((result = this._Circles) == null)
				{
					result = (this._Circles = new TArray<FCircleStampWorld2D>(base.NativePtr + (IntPtr)UKuroCircleStampData.__PropertyOffset_Circles, this));
				}
				return result;
			}
			set
			{
				this.Circles.CopyAssign(value);
			}
		}

		// Token: 0x060197F3 RID: 104435 RVA: 0x0025AC3B File Offset: 0x00258E3B
		static UKuroCircleStampData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroCircleStampData");
		}

		// Token: 0x060197F4 RID: 104436 RVA: 0x0025AC49 File Offset: 0x00258E49
		protected UKuroCircleStampData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400DDFE RID: 56830
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroCircleStampData";

		// Token: 0x0400DDFF RID: 56831
		private static IntPtr _ClassPtr;

		// Token: 0x0400DE00 RID: 56832
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400DE01 RID: 56833
		internal static int __PropertyOffset_Circles;

		// Token: 0x0400DE02 RID: 56834
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FCircleStampWorld2D> _Circles;
	}
}
