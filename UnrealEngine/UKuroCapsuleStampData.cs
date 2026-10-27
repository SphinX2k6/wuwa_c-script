using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001ABC RID: 6844
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroCapsuleStampData")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UKuroCapsuleStampData : UKuroStampData, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06019626 RID: 103974 RVA: 0x00258244 File Offset: 0x00256444
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroCapsuleStampData._ClassPtr;
		}

		// Token: 0x06019627 RID: 103975 RVA: 0x00258250 File Offset: 0x00256450
		public UKuroCapsuleStampData() : this(BuiltinUtils.AllocNativeUObject(UKuroCapsuleStampData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06019628 RID: 103976 RVA: 0x00258278 File Offset: 0x00256478
		public UKuroCapsuleStampData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroCapsuleStampData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006550 RID: 25936
		// (get) Token: 0x06019629 RID: 103977 RVA: 0x002582AC File Offset: 0x002564AC
		// (set) Token: 0x0601962A RID: 103978 RVA: 0x002582E5 File Offset: 0x002564E5
		public TArray<FCapsuleStampWorld2D> Capsules
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FCapsuleStampWorld2D> result;
				if ((result = this._Capsules) == null)
				{
					result = (this._Capsules = new TArray<FCapsuleStampWorld2D>(base.NativePtr + (IntPtr)UKuroCapsuleStampData.__PropertyOffset_Capsules, this));
				}
				return result;
			}
			set
			{
				this.Capsules.CopyAssign(value);
			}
		}

		// Token: 0x0601962B RID: 103979 RVA: 0x002582F3 File Offset: 0x002564F3
		static UKuroCapsuleStampData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroCapsuleStampData");
		}

		// Token: 0x0601962C RID: 103980 RVA: 0x00258301 File Offset: 0x00256501
		protected UKuroCapsuleStampData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400DD51 RID: 56657
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroCapsuleStampData";

		// Token: 0x0400DD52 RID: 56658
		private static IntPtr _ClassPtr;

		// Token: 0x0400DD53 RID: 56659
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400DD54 RID: 56660
		internal static int __PropertyOffset_Capsules;

		// Token: 0x0400DD55 RID: 56661
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FCapsuleStampWorld2D> _Capsules;
	}
}
